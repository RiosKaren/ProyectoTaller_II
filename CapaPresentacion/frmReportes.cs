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
        private string _tituloActualReporte = "Reporte";

        // IDs reales de roles (según tu script)
        private const int ROL_ADMIN = 1;
        private const int ROL_VENDEDOR = 2;
        private const int ROL_SUPERVISOR = 3;

        public frmReportes(Usuarios usuario)
        {
            _usuarioActual = usuario;
            InitializeComponent();
            this.Load += frmReportes_Load; // los Clicks los maneja el Designer
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            DTPReporteDesde.Value = DateTime.Today;
            DTPReporteHasta.Value = DateTime.Today;
            ConfigurarSegunRol();
        }

        private void ConfigurarSegunRol()
        {
            if (_usuarioActual == null)
            {
                CargarVendedores();
                return;
            }

            int idRol = _usuarioActual.id_rol.id_rol;

            if (idRol == ROL_VENDEDOR)
            {
                // Vendedor: combo fijo consigo mismo y Buscar deshabilitado
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
            else
            {
                // Admin / Supervisor: puede elegir
                CargarVendedores();
                comboBox1.Enabled = true;
                bBuscar.Enabled = true;
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

        // ---------- Utilitario común ----------
        private int ObtenerIdVendedorSeleccionado()
        {
            int idRol = _usuarioActual.id_rol.id_rol;

            if (idRol == ROL_VENDEDOR)
                return _usuarioActual.id_usuario; // siempre él

            if (comboBox1.SelectedItem is Utilidades.OpcionCombo oc)
                return Convert.ToInt32(oc.Valor);

            return 0; // todos
        }

        // ---------- Botones de reporte ----------
        private void BRecaudacion_Click(object sender, EventArgs e)
        {
            int idVend = ObtenerIdVendedorSeleccionado();

            var cn = new CapaNegocio.CN_Reportes();
            var dt = cn.ObtenerRecaudacion(
                DTPReporteDesde.Value,
                DTPReporteHasta.Value,
                idVend,
                true // incluir NC
            );

            _ultimoResultado = dt;
            _tituloActualReporte = "Recaudación";
            MessageBox.Show("Recaudación generada. Ahora podés mostrarla.");
        }

        private void BProductosMasVendidos_Click(object sender, EventArgs e)
        {
            int idVend = ObtenerIdVendedorSeleccionado();

            var cn = new CapaNegocio.CN_Reportes();
            var dt = cn.ObtenerProductosMasVendidos(
                DTPReporteDesde.Value,
                DTPReporteHasta.Value,
                idVend,
                false // no contamos NC
            );

            _ultimoResultado = dt;
            _tituloActualReporte = "Productos más vendidos";
            MessageBox.Show("Reporte de productos generado. Ahora podés mostrarlo.");
        }

        private void BTotalVentas_Click(object sender, EventArgs e)
        {
            int idVend = ObtenerIdVendedorSeleccionado();

            var cn = new CapaNegocio.CN_Reportes();
            var dt = cn.ObtenerTotalVentas(
                DTPReporteDesde.Value,
                DTPReporteHasta.Value,
                idVend,
                false // no contamos NC
            );

            _ultimoResultado = dt;
            _tituloActualReporte = "Total de ventas";
            MessageBox.Show("Reporte de total de ventas generado. Ahora podés mostrarlo.");
        }

        private void BGenerarReporte_Click(object sender, EventArgs e)
        {
            if (_ultimoResultado == null)
            {
                MessageBox.Show("No hay datos para mostrar. Primero generá un reporte.");
                return;
            }

            var f = new frmReporteResultado();
            f.CargarDatos(_ultimoResultado, _tituloActualReporte);
            f.ShowDialog(this);
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            // Refrescar lista de vendedores (solo útil para admin/supervisor)
            if (comboBox1.Enabled)
                CargarVendedores();
        }
    }
}
