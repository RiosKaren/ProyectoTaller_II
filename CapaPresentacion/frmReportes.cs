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

        private const int ROL_ADMIN = 1;
        private const int ROL_VENDEDOR = 2;
        private const int ROL_SUPERVISOR = 3;

        public frmReportes(Usuarios usuario)
        {
            _usuarioActual = usuario;
            InitializeComponent();
            this.Load += frmReportes_Load;
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
                // Vendedor: combo fijo consigo mismo
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
                
            }
            else
            {
                //Supervisor: puede elegir
                CargarVendedores();
                comboBox1.Enabled = true;
            }
        }

        private void CargarVendedores()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add(new Utilidades.OpcionCombo { Valor = 0, Texto = "-- Todos --" });

            var lista = new CapaNegocio.CN_Usuario().ListarActivos();
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

        private int ObtenerIdVendedorSeleccionado()
        {
            int idRol = _usuarioActual.id_rol.id_rol;

            if (idRol == ROL_VENDEDOR)
                return _usuarioActual.id_usuario; 

            if (comboBox1.SelectedItem is Utilidades.OpcionCombo oc)
                return Convert.ToInt32(oc.Valor);

            return 0; 
        }

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

            mostrarReporte(sender,e);

        }

        private void BProductosMasVendidos_Click(object sender, EventArgs e)
        {
            int idVend = ObtenerIdVendedorSeleccionado();

            var cn = new CapaNegocio.CN_Reportes();
            var dt = cn.ObtenerProductosMasVendidos(
                DTPReporteDesde.Value,
                DTPReporteHasta.Value,
                idVend,
                true // contamos NC
            );

            _ultimoResultado = dt;
            _tituloActualReporte = "Productos más vendidos";

            mostrarReporte(sender, e);
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

            mostrarReporte(sender, e);
        }

        private void mostrarReporte(object sender, EventArgs e)
        {
            if (_ultimoResultado == null)
            {
                MessageBox.Show("No hay datos para mostrar. Primero generá un reporte.");
                return;
            }

            string textoVendedor;
            if (comboBox1.Enabled && comboBox1.SelectedItem is Utilidades.OpcionCombo oc)
                textoVendedor = (Convert.ToInt32(oc.Valor) == 0) ? "Todos" : oc.Texto;
            else
                textoVendedor = $"{_usuarioActual.apellido}, {_usuarioActual.nombre}";

            // Subtítulo con período + vendedor
            string subtitulo = $"Período: {DTPReporteDesde.Value:dd/MM/yyyy} – {DTPReporteHasta.Value:dd/MM/yyyy} | Vendedor: {textoVendedor}";

            var f = new CapaPresentacion.VentanasEmergentes.frmReporteResultado();
            f.CargarDatos(_ultimoResultado, _tituloActualReporte, subtitulo); 
            f.ShowDialog(this);
        }
    }
}
