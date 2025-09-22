using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iconButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonIngresar_Click(object sender, EventArgs e)
        {
            // Buscamos el usuario
            Usuarios ousuario = new CN_Usuario().Listar()
                .Where(u => u.usuario == textBoxUser.Text
                         && u.hash_password == textBoxPassword.Text)
                .FirstOrDefault();

            if (ousuario != null)
            {
                // 👇 Validamos si está activo
                if (!ousuario.activo)
                {
                    MessageBox.Show("Usuario deshabilitado. Comuniquese con el administrador.",
                                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // salimos y no abre Inicio
                }

                // si está activo, abrimos el sistema
                Inicio form = new Inicio(ousuario);
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            textBoxUser.Text = "";
            textBoxPassword.Text = "";

            this.Show();
        }
    }
}
