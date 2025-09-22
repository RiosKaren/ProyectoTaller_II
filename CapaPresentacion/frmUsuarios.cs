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
using CapaPresentacion.Utilidades;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 1 , Texto = "ACTIVO" });
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 0 , Texto = "NO ACTIVO" });
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";
            comboBoxEstado.SelectedIndex = 0;

            

            List<Roles> listaRoles = new CN_Rol().Listar();

            foreach (Roles item in listaRoles)
            {
                comboBoxRoles.Items.Add(new OpcionCombo() { Valor = item.id_rol, Texto = item.nombre });
            }
            comboBoxRoles.DisplayMember = "Texto";
            comboBoxRoles.ValueMember = "Valor";

            foreach (DataGridViewColumn columna in UsuariosDGV.Columns)
            {
                if(columna.Visible == true && columna.Name != "botonSeleccionar")
                {
                    comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";



            //Mostrar todos los usuarios
            List<Usuarios> listaUsuarios = new CN_Usuario().Listar();

            foreach (Usuarios item in listaUsuarios)
            {
                string sexo = item.sexo ? "Masculino" : "Femenino";
                DateTime fechaDT = item.fecha_nacimiento;
                string fecha = fechaDT.ToString("dd/MM/yyyy");
                string estado = item.activo ? "ACTIVO" : "NO ACTIVO";

                string rol = "";
                switch (item.id_rol.id_rol)
                {
                    case 1: rol = "ADMINISTRADOR"; break;
                    case 2: rol = "VENDEDOR"; break;
                    case 3: rol = "SUPERVISOR"; break;
                    default: rol = "DESCONOCIDO"; break;
                }

                UsuariosDGV.Rows.Add(new object[] {"", item.id_usuario,item.dni, item.nombre, item.apellido,
                                item.email, fecha,
                                sexo, item.usuario, item.hash_password,
                                item.id_rol.id_rol, rol, item.activo, estado,
                                });

            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuarios objusuario = new Usuarios()
            {
                id_usuario = Convert.ToInt32(textBoxID.Text),
                dni = Convert.ToInt32(textBoxDNI.Text),
                nombre = textBoxNombre.Text,
                apellido = textBoxApellido.Text,
                email = textBoxEmail.Text,
                usuario = textBoxUser.Text,
                hash_password = textBoxPassword.Text,
                id_rol = new Roles() { id_rol = Convert.ToInt32(((OpcionCombo)comboBoxRoles.SelectedItem).Valor) },
                activo = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1,
                fecha_nacimiento = dateTimeNacimiento.Value,
                sexo = radioButtonMasculino.Checked
            };

            if (objusuario.id_usuario == 0)
            {
                // NUEVO USUARIO
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    // lo agregás al DataGridView
                    string sexo = radioButtonFemenino.Checked ? "Femenino" : "Masculino";
                    UsuariosDGV.Rows.Add(new object[] { "", idusuariogenerado, textBoxDNI.Text, textBoxNombre.Text, textBoxApellido.Text,
                                textBoxEmail.Text, dateTimeNacimiento.Value.ToString("dd/MM/yyyy"),
                                sexo, textBoxUser.Text, textBoxPassword.Text,
                                ((OpcionCombo)comboBoxRoles.SelectedItem).Valor.ToString(),
                                ((OpcionCombo)comboBoxRoles.SelectedItem).Texto.ToString(),
                                ((OpcionCombo)comboBoxEstado.SelectedItem).Valor.ToString(),
                                ((OpcionCombo)comboBoxEstado.SelectedItem).Texto.ToString(),
                                });
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // EDITAR USUARIO
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                if (resultado)
                {
                    // actualizar fila existente en el DGV
                    DataGridViewRow row = UsuariosDGV.Rows[Convert.ToInt32(textBoxIndice.Text)];
                    row.Cells["dni"].Value = textBoxDNI.Text;
                    row.Cells["nombre"].Value = textBoxNombre.Text;
                    row.Cells["apellido"].Value = textBoxApellido.Text;
                    row.Cells["email"].Value = textBoxEmail.Text;
                    row.Cells["usuario"].Value = textBoxUser.Text;
                    row.Cells["hash_password"].Value = textBoxPassword.Text;
                    row.Cells["fecha_nacimiento"].Value = dateTimeNacimiento.Value.ToString("dd/MM/yyyy");
                    row.Cells["sexo"].Value = radioButtonMasculino.Checked ? "Masculino" : "Femenino";
                    row.Cells["id_rol"].Value = ((OpcionCombo)comboBoxRoles.SelectedItem).Valor.ToString();
                    row.Cells["rol"].Value = ((OpcionCombo)comboBoxRoles.SelectedItem).Texto.ToString();
                    row.Cells["activo"].Value = ((OpcionCombo)comboBoxEstado.SelectedItem).Valor.ToString();
                    row.Cells["estado"].Value = ((OpcionCombo)comboBoxEstado.SelectedItem).Texto.ToString();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            Limpiar();
        }

        private void Limpiar()
        {
            textBoxIndice.Text = "-1";
            textBoxID.Text = "0";
            textBoxDNI.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxEmail.Text = "";
            textBoxUser.Text = "";
            textBoxPassword.Text = "";
            textBoxCPassword.Text = "";

            //asegurarse de que este en rango
            if (DateTime.Today < dateTimeNacimiento.MinDate)
            {
                dateTimeNacimiento.Value = dateTimeNacimiento.MinDate;
            }
            else if (DateTime.Today > dateTimeNacimiento.MaxDate)
            {
                dateTimeNacimiento.Value = dateTimeNacimiento.MaxDate;
            }
            else
            {
                dateTimeNacimiento.Value = DateTime.Today;
            }

            radioButtonFemenino.Checked = true;
            radioButtonMasculino.Checked = false;

            comboBoxEstado.SelectedIndex = 0;

            comboBoxRoles.SelectedIndex = -1;
        }


        private void UsuariosDGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) 
            {  
                return; 
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;

            }

           
        }



        private void UsuariosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

  
            if (UsuariosDGV.Columns[e.ColumnIndex].Name != "botonSeleccionar")
                return;

            var row = UsuariosDGV.Rows[e.RowIndex];
            textBoxIndice.Text = e.RowIndex.ToString();
            textBoxID.Text = Convert.ToString(row.Cells["id_usuario"].Value);
            textBoxDNI.Text = Convert.ToString(row.Cells["dni"].Value);
            textBoxApellido.Text = Convert.ToString(row.Cells["apellido"].Value);
            textBoxNombre.Text = Convert.ToString(row.Cells["nombre"].Value);
            textBoxEmail.Text = Convert.ToString(row.Cells["email"].Value);   // Name = email
            textBoxUser.Text = Convert.ToString(row.Cells["usuario"].Value);
            textBoxPassword.Text = Convert.ToString(row.Cells["hash_password"].Value);
            textBoxCPassword.Text = textBoxPassword.Text;

            //Fecha de nacimiento 
            if (row.Cells["fecha_nacimiento"].Value != null)
            {
                DateTime fecha;
                if (DateTime.TryParse(row.Cells["fecha_nacimiento"].Value.ToString(), out fecha))
                {
                    dateTimeNacimiento.Value = fecha;
                }
            }

            //Genero
            string sexo = Convert.ToString(row.Cells["Sexo"].Value);
            if (sexo == "Masculino")
            {
                radioButtonMasculino.Checked = true;
                radioButtonFemenino.Checked = false;
            }
            else
            {
                radioButtonFemenino.Checked = true;
                radioButtonMasculino.Checked = false;
            }

            //Combo Rol
            foreach (OpcionCombo oc in comboBoxRoles.Items)
            {
                if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(row.Cells["id_rol"].Value))
                {
                    comboBoxRoles.SelectedIndex = comboBoxRoles.Items.IndexOf(oc);
                    break;
                }
            }

            //Combo Estado
            foreach (OpcionCombo oc in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(row.Cells["activo"].Value))
                {
                    comboBoxEstado.SelectedIndex = comboBoxEstado.Items.IndexOf(oc);
                    break;
                }
            }

            BloquearCampos();

        }

        private void BloquearCampos()
        {
            foreach (var tb in new[] { textBoxDNI, textBoxNombre, textBoxApellido,
                               textBoxEmail, textBoxUser, textBoxPassword, textBoxCPassword })
            {
                tb.ReadOnly = true;         // no editable
                tb.Cursor = Cursors.No;     
            }

            dateTimeNacimiento.Enabled = false;
            radioButtonFemenino.Enabled = false;
            radioButtonMasculino.Enabled = false;
            comboBoxRoles.Enabled = false;
            comboBoxEstado.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (var tb in new[] { textBoxDNI, textBoxNombre, textBoxApellido,
                               textBoxEmail, textBoxUser, textBoxPassword, textBoxCPassword })
            {
                tb.ReadOnly = false;          // editable
                tb.Cursor = Cursors.IBeam; 
            }

            dateTimeNacimiento.Enabled = true;
            radioButtonFemenino.Enabled = true;
            radioButtonMasculino.Enabled = true;
            comboBoxRoles.Enabled = true;
            comboBoxEstado.Enabled = true;
        }


        ////////////////////////
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


        ///////////////////////// VERRRRRRRRRRRRRRR
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
        


        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBoxCPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonLimpiar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
