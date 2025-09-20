using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text.Length > 0)
            {
                // Guardar la posición del cursor
                int cursorPosition = tb.SelectionStart;

                // Formatear el texto: primera letra mayúscula, resto minúsculas
                string formattedText = char.ToUpper(tb.Text[0]) + tb.Text.Substring(1).ToLower();

                // Solo actualizar si el texto cambió para evitar bucle infinito
                if (tb.Text != formattedText)
                {
                    tb.Text = formattedText;
                    // Restaurar la posición del cursor
                    tb.SelectionStart = cursorPosition;
                }
            }
        }
        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text.Length > 0)
            {
                // Guardar la posición del cursor
                int cursorPosition = tb.SelectionStart;

                // Formatear el texto: primera letra mayúscula, resto minúsculas
                string formattedText = char.ToUpper(tb.Text[0]) + tb.Text.Substring(1).ToLower();

                // Solo actualizar si el texto cambió para evitar bucle infinito
                if (tb.Text != formattedText)
                {
                    tb.Text = formattedText;
                    // Restaurar la posición del cursor
                    tb.SelectionStart = cursorPosition;
                }
            }
        }
        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }
        private bool EsEmailValido(string email)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron, RegexOptions.IgnoreCase);
        }
        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (!EsEmailValido(textBoxEmail.Text))
            {
                MessageBox.Show("Por favor ingrese un correo electrónico válido.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim();
            string apellido = textBoxApellido.Text.Trim();
            string dni = textBoxDNI.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string sexo = radioButtonMasculino.Checked ? "Masculino" : "Femenino"; // Ajusta los nombres de los RadioButton

            // Validación básica
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(nombre, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El nombre solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(apellido, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El apellido solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar en la base de datos
            string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (Nombre, Apellido, DNI, Email) VALUES (@Nombre, @Apellido, @DNI, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    cmd.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void CargarUsuariosEnGrid()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Nombre, Apellido, DNI, Email FROM Usuarios";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    UsuariosDGV.DataSource = dt;
                }
            }
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuariosEnGrid();
        }
    }
}
