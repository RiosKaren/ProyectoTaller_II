using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.VentanasEmergentes
{
    public partial class frmReporteResultado : Form
    {
        public frmReporteResultado()
        {
            InitializeComponent();
        }

        // lo llama frmReportes
        public void CargarDatos(DataTable dt, string titulo = "Reporte")
        {
            this.Text = titulo;
            dgvDatos.DataSource = dt;
            dgvDatos.ReadOnly = true;
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ESTE MÉTODO ES EL QUE QUIERE EL DISEÑADOR
        private void btnExportar_Click(object sender, EventArgs e)
        {
            var dt = dgvDatos.DataSource as DataTable;
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "reporte.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new System.IO.StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // encabezados
                        var headers = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName);
                        sw.WriteLine(string.Join(";", headers));

                        // filas
                        foreach (DataRow row in dt.Rows)
                        {
                            var celdas = dt.Columns.Cast<DataColumn>()
                                                   .Select(c => row[c].ToString().Replace(";", ","));
                            sw.WriteLine(string.Join(";", celdas));
                        }
                    }

                    MessageBox.Show("Exportado.");
                }
            }
        }
    }
}