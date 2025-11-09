using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using System.IO;


namespace CapaPresentacion.VentanasEmergentes
{
    public partial class frmReporteResultado : Form
    {
        private DataTable _dtActual;
        private string _tituloActual;
        private string _subtituloActual;

        public frmReporteResultado()
        {
            InitializeComponent();
        }

        public void CargarDatos(DataTable dt, string titulo = "Reporte")
        {
            _dtActual = dt;
            _tituloActual = titulo;
            _subtituloActual = null;

            this.Text = titulo;

            dgvDatos.DataSource = dt;
            dgvDatos.ReadOnly = true;
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void CargarDatos(DataTable dt, string titulo, string subtitulo)
        {
            _dtActual = dt;
            _tituloActual = titulo;
            _subtituloActual = subtitulo;

            this.Text = titulo;

            dgvDatos.DataSource = dt;
            dgvDatos.ReadOnly = true;
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (_dtActual == null || _dtActual.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            try
            {
                byte[] grafBytes = null;
                try
                {
                    var fg = new frmReporteGrafico();
                    fg.Cargar(_dtActual, _tituloActual ?? "Reporte");

                    // menos resolución (texto más grande en el PDF)
                    grafBytes = fg.ExportarComoImagen(1000, 550);
                }
                catch
                {
                    //si falla el gráfico seguimos sin el
                }

                string ruta = CapaPresentacion.Utilidades.PdfReporte.GenerarDesdeDataTable(
                    _dtActual,
                    _tituloActual ?? "Reporte",
                    carpetaDestino: null,
                    grafico: grafBytes,
                    subtitulo: _subtituloActual
                );

                if (File.Exists(ruta))
                {
                    var psi = new System.Diagnostics.ProcessStartInfo { FileName = ruta, UseShellExecute = true };
                    System.Diagnostics.Process.Start(psi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo exportar/abrir el PDF.\n" + ex.Message);
            }
        }


        private void btnGrafico_Click(object sender, EventArgs e)
        {
            if (_dtActual == null || _dtActual.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para graficar.");
                return;
            }

            var f = new frmReporteGrafico();
            f.Cargar(_dtActual, _tituloActual ?? "Reporte");
            f.ShowDialog(this);
        }


    }
}
