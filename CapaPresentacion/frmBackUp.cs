using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmBackUp : Form
    {
        public frmBackUp()
        {
            InitializeComponent();

            // Ruta por defecto: Escritorio\Backups
            if (string.IsNullOrWhiteSpace(tbRutaDeGuardado.Text))
            {
                tbRutaDeGuardado.Text = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Backups");
            }
        }

        private void bElegirRuta_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog
            {
                Description = "Selecciona la carpeta donde guardar la copia de seguridad"
            })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    tbRutaDeGuardado.Text = fbd.SelectedPath;
            }
        }

        private void bCopiaDeSeguridad_Click(object sender, EventArgs e)
        {
            string ruta = tbRutaDeGuardado.Text.Trim();
            if (string.IsNullOrEmpty(ruta))
            {
                MessageBox.Show("Seleccioná una ruta de guardado.");
                return;
            }

            Directory.CreateDirectory(ruta);

            var csb = new SqlConnectionStringBuilder(Conexion.cadena);
            string db = csb.InitialCatalog;

            // timestamp para evitar pisar: 20241027_183512 (con milisegundos si querés: yyyyMMdd_HHmmssfff)
            string ts = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string archivo = Path.Combine(ruta, $"{db}_{ts}.bak");

            try
            {
                using (var cn = new SqlConnection(Conexion.cadena))
                using (var cmd = cn.CreateCommand())
                {
                    cmd.CommandText = $@"
                        BACKUP DATABASE [{db}]
                        TO DISK = @path
                        WITH COPY_ONLY, INIT, FORMAT,
                             NAME = @name, STATS = 10;";

                    cmd.Parameters.AddWithValue("@path", archivo);
                    cmd.Parameters.AddWithValue("@name", $"Full backup {db} {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"Backup generado:\n{archivo}", "Backup OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el backup:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
