using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            //Combo Estado
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "ACTIVO" });
            comboBoxEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "NO ACTIVO" });
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";
            comboBoxEstado.SelectedIndex = 0;


            //Combo de Búsqueda (columnas del DGV)
            foreach (DataGridViewColumn columna in ClientesDGV.Columns)
            {
                if (columna.Visible == true
                    && columna.Name != "botonSeleccionar"
                    && !columna.Name.Equals("estado", StringComparison.OrdinalIgnoreCase))
                {
                    comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";

            //Cargar Clientes 
            CargarClientes();
        }

        private void CargarClientes()
        {
            ClientesDGV.Rows.Clear();

            List<Clientes> listaClientes = new CN_Cliente().Listar();

            foreach (Clientes item in listaClientes)
            {
                string sexo = item.sexo ? "Masculino" : "Femenino";
                string estado = item.activo ? "ACTIVO" : "NO ACTIVO";

                ClientesDGV.Rows.Add(new object[]
                {
                    "", // columna botón seleccionar
                    item.id_cliente, item.dni, item.apellido, item.nombre, item.telefono, item.email,
                    item.direccion, sexo, item.activo, estado
                });
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxDNI.Text) ||
                string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelefono.Text) ||
                string.IsNullOrWhiteSpace(textBoxDireccion.Text) ||
                comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(textBoxEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string mensaje = string.Empty;

            Clientes objCliente = new Clientes()
            {
                id_cliente = Convert.ToInt32(textBoxID.Text),
                dni = Convert.ToInt32(textBoxDNI.Text),
                nombre = textBoxNombre.Text.Trim(),
                apellido = textBoxApellido.Text.Trim(),
                email = textBoxEmail.Text.Trim(),
                direccion = textBoxDireccion.Text.Trim(),
                sexo = radioButtonMasculino.Checked,
                telefono = textBoxTelefono.Text.Trim(),
                activo = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1
            };

            if (objCliente.id_cliente == 0)
            {
                // NUEVO CLIENTE
                int idGenerado = new CN_Cliente().Registrar(objCliente, out mensaje);

                if (idGenerado != 0)
                {
                    string sexo = radioButtonMasculino.Checked ? "Masculino" : "Femenino";
                    string estado = ((OpcionCombo)comboBoxEstado.SelectedItem).Texto.ToString();

                    ClientesDGV.Rows.Add(new object[]
                    {
                        "",
                        idGenerado,
                        objCliente.dni,
                        objCliente.apellido,
                        objCliente.nombre,
                        objCliente.telefono,
                        objCliente.email,
                        objCliente.direccion,
                        sexo,
                        estado,
                        objCliente.activo
                    });

                    MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //´EDITAR CLIENTE
                bool resultado = new CN_Cliente().Editar(objCliente, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = ClientesDGV.Rows[Convert.ToInt32(textBoxIndice.Text)];
                    row.Cells["dni"].Value = objCliente.dni;
                    row.Cells["apellido"].Value = objCliente.apellido;
                    row.Cells["nombre"].Value = objCliente.nombre;
                    row.Cells["telefono"].Value = objCliente.telefono;
                    row.Cells["email"].Value = objCliente.email;
                    row.Cells["direccion"].Value = objCliente.direccion;
                    row.Cells["sexo"].Value = objCliente.sexo ? "Masculino" : "Femenino";
                    row.Cells["estado"].Value = ((OpcionCombo)comboBoxEstado.SelectedItem).Texto.ToString();
                    row.Cells["activo"].Value = objCliente.activo;

                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Limpiar()
        {
            textBoxIndice.Text = "-1";
            textBoxID.Text = "0";
            textBoxDNI.Clear();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxEmail.Clear();
            textBoxTelefono.Clear();
            textBoxDireccion.Clear();
            radioButtonFemenino.Checked = true;
            radioButtonMasculino.Checked = false;
            comboBoxEstado.SelectedIndex = 0;

            textBoxDNI.Select(); //Pone el foco en la textbox DNI
        }

        private void ClientesDGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0) //Si es la columna del boton es el indice 0, entonces 
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All); //Pinta la celda
                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                
                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h)); //Dibuja la imagen en el centro de la celda
                e.Handled = true; //Indica que el evento se ha manejado
            }
        }

        private void ClientesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //si la celda seleccionada es el encabezado, no hace nada
                return;

            if (ClientesDGV.Columns[e.ColumnIndex].Name != "botonSeleccionar") // si es diferente a la columna del boton seleccionar, no hace nada
                return;

            var row = ClientesDGV.Rows[e.RowIndex]; //obtiene la fila seleccionada
            textBoxIndice.Text = e.RowIndex.ToString(); //guarda el indice de la fila seleccionada
            textBoxID.Text = Convert.ToString(row.Cells["id_cliente"].Value); //guarda el id del cliente seleccionado
            textBoxDNI.Text = Convert.ToString(row.Cells["dni"].Value); //guarda el dni del cliente seleccionado
            textBoxApellido.Text = Convert.ToString(row.Cells["apellido"].Value); //guarda el apellido del cliente seleccionado
            textBoxNombre.Text = Convert.ToString(row.Cells["nombre"].Value); //  guarda el nombre del cliente seleccionado
            textBoxEmail.Text = Convert.ToString(row.Cells["email"].Value); // guarda el email del cleinte seleccionado
            textBoxTelefono.Text = Convert.ToString(row.Cells["telefono"].Value); // guarda el telefono del cliente seleccionado
            textBoxDireccion.Text = Convert.ToString(row.Cells["direccion"].Value); // guarda la direccion del cliente seleccionado

            //Genero
            string sexo = Convert.ToString(row.Cells["sexo"].Value);
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
            foreach (TextBoxBase tb in new TextBoxBase[]
            {
                textBoxDNI, textBoxNombre, textBoxApellido, textBoxEmail, textBoxTelefono, textBoxDireccion
            })
            {
                tb.ReadOnly = true;
                tb.Cursor = Cursors.No;
            }

            radioButtonFemenino.Enabled = false;
            radioButtonMasculino.Enabled = false;
            comboBoxEstado.Enabled = false;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text) || textBoxID.Text == "0")
            {
                MessageBox.Show("Debe seleccionar un cliente primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (TextBoxBase tb in new TextBoxBase[]
            {
                textBoxDNI, textBoxNombre, textBoxApellido, textBoxEmail, textBoxTelefono, textBoxDireccion
            })
            {
                tb.ReadOnly = false;
                tb.Cursor = Cursors.IBeam;
            }

            radioButtonFemenino.Enabled = true;
            radioButtonMasculino.Enabled = true;
            comboBoxEstado.Enabled = true;
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text) || textBoxID.Text == "0")
            {
                MessageBox.Show("Debe seleccionar un cliente primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Desea dar de baja al cliente?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = string.Empty;
                bool respuesta = new CN_Cliente().CambiarEstado(Convert.ToInt32(textBoxID.Text), "BAJA", out mensaje);

                if (respuesta)
                {
                    DataGridViewRow row = ClientesDGV.Rows[Convert.ToInt32(textBoxIndice.Text)];
                    row.Cells["activo"].Value = 0;
                    row.Cells["estado"].Value = "NO ACTIVO";
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Limpiar();
        }

        private void btnHabilitarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text) || textBoxID.Text == "0")
            {
                MessageBox.Show("Debe seleccionar un cliente primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Desea habilitar al cliente?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = string.Empty;
                bool respuesta = new CN_Cliente().CambiarEstado(Convert.ToInt32(textBoxID.Text), "ALTA", out mensaje);

                if (respuesta)
                {
                    DataGridViewRow row = ClientesDGV.Rows[Convert.ToInt32(textBoxIndice.Text)];
                    row.Cells["activo"].Value = 1;
                    row.Cells["estado"].Value = "ACTIVO";
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Limpiar();
        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBusqueda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un campo para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxBusqueda.Text))
            {
                MessageBox.Show("Ingrese un texto para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string columnaFiltro = ((OpcionCombo)comboBoxBusqueda.SelectedItem).Valor.ToString();
            string textoBuscado = RemoverAcentos(textBoxBusqueda.Text.Trim().ToUpper());

            foreach (DataGridViewRow row in ClientesDGV.Rows)
            {
                if (row.Cells[columnaFiltro].Value != null)
                {
                    string valorCelda = RemoverAcentos(row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper());

                    if (valorCelda.Contains(textoBuscado))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private string RemoverAcentos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            // Normaliza los caracteres a su forma base
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in textoNormalizado)
            {
                UnicodeCategory categoria = CharUnicodeInfo.GetUnicodeCategory(c);
                if (categoria != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        private void iconButtonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Text = "";
            foreach (DataGridViewRow row in ClientesDGV.Rows)
            {
                row.Visible = true;
            }
        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;

        }

        private bool EsEmailValido(string email) //valida que el email tenga un formato correcto
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

        
    }
}
