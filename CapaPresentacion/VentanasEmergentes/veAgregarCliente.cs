using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.VentanasEmergentes
{
    public partial class veAgregarCliente : Form
    {
        public veAgregarCliente()
        {
            InitializeComponent();
        }

        public Clientes ClienteCreado { get; private set; }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string mensaje = string.Empty;

            Clientes objCliente = new Clientes()
            { 
                dni = Convert.ToInt32(textBoxDNI.Text),
                nombre = textBoxNombre.Text.Trim(),
                apellido = textBoxApellido.Text.Trim(),
                email = textBoxEmail.Text.Trim(),
                direccion = textBoxDireccion.Text.Trim(),
                sexo = radioButtonMasculino.Checked,
                telefono = textBoxTelefono.Text.Trim(),
                activo = true
            };

            // NUEVO CLIENTE
            int idGenerado = new CN_Cliente().Registrar(objCliente, out mensaje);


            if (idGenerado != 0)
            {
                MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objCliente.id_cliente = idGenerado;  
                ClienteCreado = objCliente;

                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxDNI.Text) ||
                string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelefono.Text) ||
                string.IsNullOrWhiteSpace(textBoxDireccion.Text) )
                //comboBoxEstado.SelectedIndex == -1)
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
