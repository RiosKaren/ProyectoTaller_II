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
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.VentanasEmergentes
{
    public partial class veClientes : Form
    {
        public Clientes _Cliente { get; set; }

        public veClientes()
        {
            InitializeComponent();
        }

        private void veCliente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in ClientesDGV.Columns)
            {
                if (columna.Visible == true)
                {
                    comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";

            ClientesDGV.Rows.Clear();

            List<Clientes> listaClientes = new CN_Cliente().ListarActivos();

            foreach (Clientes item in listaClientes)
            {
                ClientesDGV.Rows.Add(new object[]
                {
                    item.id_cliente, item.dni, item.apellido, item.nombre, item.activo
                });
            }






        }
    }
}
