using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;


namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuarios usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuarios objusuario)
        {
            usuarioActual = objusuario;

            InitializeComponent();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.Silver;

            contenedor.Controls.Add(formulario);
            formulario.Show();

        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permisos> ListaPermisos = new CN_Permiso().Listar(usuarioActual.id_usuario);

            foreach (IconMenuItem iconmenu in menuStrip1.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.nombre_menu == iconmenu.Name);

                if(encontrado == false)
                {
                    iconmenu.Visible = false;
                }

            }

            lbusuario.Text = usuarioActual.usuario;

            IconMenuItem primerMenu = menuStrip1.Items
                                                .OfType<IconMenuItem>()
                                                .FirstOrDefault(m => m.Visible);

            if (primerMenu != null)
            {
                primerMenu.PerformClick();
            }
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes(usuarioActual));
        }

        private void menuProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProductos());
        }

        private void menuBackUp_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmBackUp());
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubMenuRegistrarV_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new frmVentas(usuarioActual));
        }

        private void SubMenuVerDetalle_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new FrmVerVentas(usuarioActual));
        }
    }
}
