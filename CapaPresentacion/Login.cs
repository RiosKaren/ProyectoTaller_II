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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void iconButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonIngresar_Click(object sender, EventArgs e)
        {
            List<Usuarios> TEST = new CN_Usuario().Listar();

            Usuarios ousuario = new CN_Usuario().Listar().Where(u => u.usuario == textBoxUser.Text
                                                                && u.hash_password == textBoxPassword.Text).FirstOrDefault();

            if (ousuario != null)
            {
                Inicio form = new Inicio(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontró el usuario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            textBoxUser.Text = "";
            textBoxPassword.Text = "";

            this.Show();
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
