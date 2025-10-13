using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaPresentacion.VentanasEmergentes;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        private Usuarios _Usuario;

        public frmVentas(Usuarios oUsuarios = null)
        {
            _Usuario = oUsuarios;
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            
            textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            textBoxIDCliente.Text = "0";
            textBoxIDProducto.Text = "0";
            




        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var ventana = new veClientes())
            {
                var result = ventana.ShowDialog();

            }
        }
    }
}
