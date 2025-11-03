using System;
using System.Data;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using System.Diagnostics;

namespace CapaPresentacion.VentanasEmergentes
{
    public partial class frmReporteResultado : Form
    {
        private DataTable _dtActual;
        private string _tituloActual;

        public frmReporteResultado()
        {
            InitializeComponent();
        }

        // Lo llama frmReportes
        public void CargarDatos(DataTable dt, string titulo = "Reporte")
        {
            _dtActual = dt;
            _tituloActual = titulo;

            this.Text = titulo;

            dgvDatos.DataSource = dt;
            dgvDatos.ReadOnly = true;
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.MultiSelect = false;
        }

        // Exportar a PDF
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (_dtActual == null)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            try
            {
                string ruta = PdfReporte.GenerarDesdeDataTable(_dtActual, _tituloActual);

                // Abrir el PDF automáticamente con la app predeterminada del sistema
                if (System.IO.File.Exists(ruta))
                {
                    var psi = new ProcessStartInfo
                    {
                        FileName = ruta,
                        UseShellExecute = true // importante para que Windows lo abra con el visor por defecto
                    };
                    Process.Start(psi);
                }
                else
                {
                    MessageBox.Show("Se exportó el PDF, pero no se encontró el archivo en disco.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo exportar/abrir el PDF.\n" + ex.Message);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // sin uso
        }
    }
}
