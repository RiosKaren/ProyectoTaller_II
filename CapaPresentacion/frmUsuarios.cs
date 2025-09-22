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
                if (columna.Visible == true
                    && columna.Name != "botonSeleccionar"
                    && !columna.Name.Equals("estado", StringComparison.OrdinalIgnoreCase))
                {
                    comboBoxBusqueda.Items.Add(
                        new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText }
                    );
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

                UsuariosDGV.Rows.Add(new object[] {"", item.id_usuario,item.dni, item.apellido, item.nombre,
                                item.email, fecha,
                                sexo, item.usuario, item.hash_password,
                                item.id_rol.id_rol, rol, item.activo, estado
                                });

            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxDNI.Text) ||
                string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxUser.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxCPassword.Text) ||
                comboBoxRoles.SelectedIndex == -1 ||
                comboBoxEstado.SelectedIndex == -1)    //Si ningun campo está vacio
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            if (textBoxPassword.Text != textBoxCPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }                                   //Validacion de contraseñas

            return true;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return; //si no pasa validación, no guarda, sale del metodo

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
                sexo = radioButtonMasculino.Checked   //Se instancia un objeto usuario
            };

            if (objusuario.id_usuario == 0)
            {
                // NUEVO USUARIO
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    // se agregá el instanciado al DataGridView
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
            textBoxCPassword.Text = "";             //Limpia las textbox

            //asegurarse de que este en rango
            if (DateTime.Today < dateTimeNacimiento.MinDate)
            {
                dateTimeNacimiento.Value = dateTimeNacimiento.MinDate;
            }
            else if (DateTime.Today > dateTimeNacimiento.MaxDate)
            {
                dateTimeNacimiento.Value = dateTimeNacimiento.MaxDate;  //Limpia el dtp
            }
            else
            {
                dateTimeNacimiento.Value = DateTime.Today;
            }

            radioButtonFemenino.Checked = true;
            radioButtonMasculino.Checked = false;       //Deja un rb seleccionado

            comboBoxEstado.SelectedIndex = 0;

            comboBoxRoles.SelectedIndex = -1;

            textBoxDNI.Select(); //Pone el foco en la textbox DNI
        }


        private void UsuariosDGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) 
            {  
                return; 
            }

            if (e.ColumnIndex == 0) //Si es la columna del boton es el indice 0, entonces 
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All); //Pinta la celda
                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h)); //Dibuja la imagen en el centro de la celda
                e.Handled = true;      //Indica que el evento se ha manejado

            }

           
        }



        private void UsuariosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; //si la celda seleccionada es el encabezado, no hace nada


            if (UsuariosDGV.Columns[e.ColumnIndex].Name != "botonSeleccionar") // si es diferente a la columna del boton seleccionar, no hace nada
                return;

            var row = UsuariosDGV.Rows[e.RowIndex];                 //obtiene la fila seleccionada
            textBoxIndice.Text = e.RowIndex.ToString();             //guarda el indice de la fila seleccionada
            textBoxID.Text = Convert.ToString(row.Cells["id_usuario"].Value);//guarda el id del usuario seleccionado
            textBoxDNI.Text = Convert.ToString(row.Cells["dni"].Value);     //guarda el dni del usuario seleccionado
            textBoxApellido.Text = Convert.ToString(row.Cells["apellido"].Value);   //guarda el apellido del usuario seleccionado
            textBoxNombre.Text = Convert.ToString(row.Cells["nombre"].Value);       //  guarda el nombre del usuario seleccionado
            textBoxEmail.Text = Convert.ToString(row.Cells["email"].Value);         // guarda el email del usuario seleccionado
            textBoxUser.Text = Convert.ToString(row.Cells["usuario"].Value);        // guarda el usuario del usuario seleccionado
            textBoxPassword.Text = Convert.ToString(row.Cells["hash_password"].Value);   // guarda la contraseña del usuario seleccionado
            textBoxCPassword.Text = textBoxPassword.Text;       // guarda la contraseña 

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
                               textBoxEmail, textBoxUser, textBoxPassword, textBoxCPassword }) //para cada campo de texto
            {
                tb.ReadOnly = true;         // no editable
                tb.Cursor = Cursors.No;     // cursor de no disponible
            }

            dateTimeNacimiento.Enabled = false;
            radioButtonFemenino.Enabled = false;
            radioButtonMasculino.Enabled = false;
            comboBoxRoles.Enabled = false;
            comboBoxEstado.Enabled = false;         //deshabilita los controles , con esto no se puede editar ningun campo
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (var tb in new[] { textBoxDNI, textBoxNombre, textBoxApellido,
                               textBoxEmail, textBoxUser, textBoxPassword, textBoxCPassword }) //para cada campo de texto
            {
                tb.ReadOnly = false;          // lo hace editable
                tb.Cursor = Cursors.IBeam;    //libera el cursor
            }

            dateTimeNacimiento.Enabled = true;
            radioButtonFemenino.Enabled = true;
            radioButtonMasculino.Enabled = true;
            comboBoxRoles.Enabled = true;
            comboBoxEstado.Enabled = true; //Hace que los controles restantes se puedan editar
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxID.Text) != 0) //si el id es diferente de 0
            {
                if (MessageBox.Show("¿Desea dar de baja al usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //pregunta si desea eliminar
                {//si la respuesta es si
                    string mensaje = string.Empty; //variable para el mensaje de error
                    Usuarios objusuario = new Usuarios() //instancia de usuario
                    {
                        id_usuario = Convert.ToInt32(textBoxID.Text) //solo necesita el id para eliminar
                    };

                    bool respuesta = new CN_Usuario().Baja(objusuario, out mensaje); //llama al metodo baja de la capa negocio

                    if (respuesta)
                    {
                        DataGridViewRow row = UsuariosDGV.Rows[Convert.ToInt32(textBoxIndice.Text)]; //obtiene la fila seleccionada
                        row.Cells["activo"].Value = "0"; //cambia el valor de activo a 0
                        row.Cells["estado"].Value = "NO ACTIVO"; //cambia el valor de estado a no activo
                    }
                    else
                    {//si la respuesta es no
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //muestra el mensaje de error 
                    }
                }
            }
        }

        private void iconButtonHabilitar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxID.Text) != 0) //si el id es diferente de 0
            {
                if (MessageBox.Show("¿Desea habilitar al usuario?", "Confirmación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //pregunta si desea dar de alta
                {//si la respuesta es si
                    string mensaje = string.Empty;
                    Usuarios objusuario = new Usuarios() //instancia un usuario
                    {
                        id_usuario = Convert.ToInt32(textBoxID.Text) //solo necesita el id para habilitar
                    };

                    bool respuesta = new CN_Usuario().Habilitar(objusuario, out mensaje); //llama al metodo habilitar de la capa negocio

                    if (respuesta)
                    {
                        DataGridViewRow row = UsuariosDGV.Rows[Convert.ToInt32(textBoxIndice.Text)]; //obtiene la fila seleccionada
                        row.Cells["activo"].Value = "1"; //cambia el valor de activo a 1
                        row.Cells["estado"].Value = "ACTIVO"; //cambia el valor de estado a activo

                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); //mensaje de confirmacion
                    }
                    else
                    {//si la respuesta es no
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //muestra el mensaje de error
                    }
                }
            }
        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)comboBoxBusqueda.SelectedItem).Valor.ToString(); //obtiene el valor de la columna seleccionada en el combobox

            if (UsuariosDGV.Rows.Count > 0) //si hay filas en el datagridview
            {
                foreach (DataGridViewRow row in UsuariosDGV.Rows) //para cada fila en el datagridview
                {//recorre todas las filas
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textBoxBusqueda.Text.Trim().ToUpper()))//si el valor de la celda en la columna seleccionada contiene el texto buscado
                        row.Visible = true; //muestra la fila
                    else 
                        row.Visible = false; //oculta la fila
                }
            }
        }

        private void iconButtonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Text = ""; //limpia el textbox de busqueda
            foreach (DataGridViewRow row in UsuariosDGV.Rows) //recorre todas las filas del datagridview
            {
                row.Visible = true; //muestra todas las filas
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox; //castea el sender(la tecla presionada) a un textbox
            if (tb.Text.Length > 0) //si el largo del texto es mayor a 0
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
        private void textBoxApellido_TextChanged(object sender, EventArgs e) //mismo procedimiento pero para el apellido
        {
            TextBox tb = sender as TextBox;
            if (tb.Text.Length > 0)
            {
                int cursorPosition = tb.SelectionStart;
                string formattedText = char.ToUpper(tb.Text[0]) + tb.Text.Substring(1).ToLower();

                if (tb.Text != formattedText)
                {
                    tb.Text = formattedText;
                    tb.SelectionStart = cursorPosition;
                }
            }
        }
        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e) //solo permite ingresar numeros en la textbox DNI
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }
        private bool EsEmailValido(string email) //valida que el email tenga un formato correcto
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron, RegexOptions.IgnoreCase);
        }
        private void textBoxEmail_Leave(object sender, EventArgs e) //verifica que el email sea valido al salir de la textbox
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
            string nombre = textBoxNombre.Text.Trim(); // guarda los valores de las textbox en variables
            string apellido = textBoxApellido.Text.Trim();
            string dni = textBoxDNI.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string sexo = radioButtonMasculino.Checked ? "Masculino" : "Femenino"; // Ajusta los nombres de los RadioButton

            // Validación básica
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //Si algun campo está vacio, no guarda
            }
            if (!Regex.IsMatch(nombre, @"^[a-zA-Z]+$")) //Valida que el nombre solo contenga letras
            {
                MessageBox.Show("El nombre solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(apellido, @"^[a-zA-Z]+$")) //valida que el apellido solo contenga letras
            {
                MessageBox.Show("El apellido solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar en la base de datos
            string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString; // Obtiene la cadena de conexión desde App.config
            using (SqlConnection conn = new SqlConnection(connectionString)) // Usa la cadena de conexión
            {
                string query = "INSERT INTO Usuarios (Nombre, Apellido, DNI, Email) VALUES (@Nombre, @Apellido, @DNI, @Email)"; // Consulta SQL para insertar un nuevo usuario
                using (SqlCommand cmd = new SqlCommand(query, conn)) // Usa la consulta y la conexión
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre); 
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    cmd.Parameters.AddWithValue("@Email", email);
                    // Agrega los parámetros para evitar inyección SQL
                    try
                    {// Intenta abrir la conexión y ejecutar el comando
                        conn.Open(); //abre la conexión
                        cmd.ExecuteNonQuery(); //ejecuta el comando
                        MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); // Muestra un mensaje de éxito
                    }
                    catch (Exception ex) // Si hay un error, lo muestra en un mensaje
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
