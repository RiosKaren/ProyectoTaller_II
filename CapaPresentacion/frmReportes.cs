using System;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;
using CapaPresentacion.VentanasEmergentes;

namespace CapaPresentacion
{
    public partial class frmReportes : Form
    {
        private readonly Usuarios _usuarioActual;
        private DataTable _ultimoResultado;

        public frmReportes(Usuarios usuario)
        {
            _usuarioActual = usuario;
            InitializeComponent();
            this.Load += frmReportes_Load;     // solo el Load, los Click ya los pone el designer
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            DTPReporteDesde.Value = DateTime.Today;
            DTPReporteHasta.Value = DateTime.Today;

            ConfigurarSegunRol();
        }

        private void ConfigurarSegunRol()
        {
            // si por alguna razón no llegó el usuario, muestro todo
            if (_usuarioActual == null)
            {
                CargarVendedores();
                return;
            }

            // ids reales (de tu script)
            const int ROL_ADMIN = 1;
            const int ROL_VENDEDOR = 2;
            const int ROL_SUPERVISOR = 3;

            int idRol = _usuarioActual.id_rol.id_rol;

            if (idRol == ROL_VENDEDOR)
            {
                // vendedor → solo él
                comboBox1.Items.Clear();
                comboBox1.Items.Add(new Utilidades.OpcionCombo
                {
                    Valor = _usuarioActual.id_usuario,
                    Texto = _usuarioActual.apellido + ", " + _usuarioActual.nombre
                });
                comboBox1.DisplayMember = "Texto";
                comboBox1.ValueMember = "Valor";
                comboBox1.SelectedIndex = 0;

                comboBox1.Enabled = false;
                bBuscar.Enabled = false;
            }
            else if (idRol == ROL_ADMIN || idRol == ROL_SUPERVISOR)
            {
                // admin / supervisor → pueden elegir
                CargarVendedores();
                comboBox1.Enabled = true;
                bBuscar.Enabled = true;
            }
            else
            {
                // por si en el futuro hay otro rol
                CargarVendedores();
            }
        }

        private void CargarVendedores()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add(new Utilidades.OpcionCombo { Valor = 0, Texto = "-- Todos --" });

            var lista = new CapaNegocio.CN_Usuario().Listar();
            foreach (var u in lista)
            {
                comboBox1.Items.Add(new Utilidades.OpcionCombo
                {
                    Valor = u.id_usuario,
                    Texto = $"{u.apellido}, {u.nombre}"
                });
            }

            comboBox1.DisplayMember = "Texto";
            comboBox1.ValueMember = "Valor";
            comboBox1.SelectedIndex = 0;
        }

        private void BRecaudacion_Click(object sender, EventArgs e)
        {
            const int ROL_ADMIN = 1;
            const int ROL_VENDEDOR = 2;
            const int ROL_SUPERVISOR = 3;

            int idRol = _usuarioActual.id_rol.id_rol;
            int idVend;

            if (idRol == ROL_VENDEDOR)
            {
                // vendedor → siempre él
                idVend = _usuarioActual.id_usuario;
            }
            else
            {
                // admin / supervisor → lo que figure en el combo
                if (comboBox1.SelectedItem is Utilidades.OpcionCombo oc)
                    idVend = Convert.ToInt32(oc.Valor);
                else
                    idVend = 0; // todos
            }

            var cn = new CapaNegocio.CN_Reportes();
            var dt = cn.ObtenerRecaudacion(
                DTPReporteDesde.Value,
                DTPReporteHasta.Value,
                idVend,
                true   // incluir NC
            );

            _ultimoResultado = dt;
            MessageBox.Show("Recaudación generada. Ahora podés mostrarla.");
        }

        private void BProductosMasVendidos_Click(object sender, EventArgs e)
        {
            const int ROL_ADMIN = 1;
            const int ROL_VENDEDOR = 2;
            const int ROL_SUPERVISOR = 3;

            int idRol = _usuarioActual.id_rol.id_rol;
            int idVend;

            if (idRol == ROL_VENDEDOR)
            {
                idVend = _usuarioActual.id_usuario;
            }
            else
            {
                if (comboBox1.SelectedItem is Utilidades.OpcionCombo oc)
                    idVend = Convert.ToInt32(oc.Valor);
                else
                    idVend = 0;
            }

            var cn = new CapaNegocio.CN_Reportes();
            var dt = cn.ObtenerProductosMasVendidos(
                DTPReporteDesde.Value,
                DTPReporteHasta.Value,
                idVend,
                false   // no contamos NC
            );

            _ultimoResultado = dt;
            MessageBox.Show("Reporte de productos generado. Ahora podés mostrarlo.");
        }

        private void BTotalVentas_Click(object sender, EventArgs e)
        {
            const int ROL_ADMIN = 1;
            const int ROL_VENDEDOR = 2;
            const int ROL_SUPERVISOR = 3;

            int idRol = _usuarioActual.id_rol.id_rol;
            int idVend;

            if (idRol == ROL_VENDEDOR)
            {
                // vendedor: solo sus ventas
                idVend = _usuarioActual.id_usuario;
            }
            else
            {
                // admin / supervisor: lo que diga el combo (0 = todos)
                if (comboBox1.SelectedItem is Utilidades.OpcionCombo oc)
                    idVend = Convert.ToInt32(oc.Valor);
                else
                    idVend = 0;
            }

            var cn = new CapaNegocio.CN_Reportes();
            var dt = cn.ObtenerTotalVentas(
                DTPReporteDesde.Value,
                DTPReporteHasta.Value,
                idVend,
                false   // no contamos NC
            );

            _ultimoResultado = dt;
            MessageBox.Show("Reporte de total de ventas generado. Ahora podés mostrarlo.");
        }

        private void BGenerarReporte_Click(object sender, EventArgs e)
        {
            // si nunca se generó nada
            if (_ultimoResultado == null)
            {
                MessageBox.Show("No hay datos para mostrar. Primero generá un reporte.");
                return;
            }

            var f = new frmReporteResultado();
            f.CargarDatos(_ultimoResultado, "Reporte");
            f.ShowDialog(this);
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
