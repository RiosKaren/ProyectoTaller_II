
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


namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {
        private DataTable tablaTalles;


        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in ProductosDGV.Columns)
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


            //Mostrar todos los prductos
            List<Productos> listaProductos = new CN_Producto().Listar();

            ProductosDGV.Rows.Clear();

            // Permitir multilínea y ajuste de altura dinámico
            ProductosDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            ProductosDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            foreach (Productos item in listaProductos)
            {
                ProductosDGV.Rows.Add(new object[]
                {
                    "", // columna para seleccionar
                    item.id_producto,
                    item.codigo,
                    item.imagen_url,
                    item.nombre,
                    item.descripcion,
                    item.tallesTexto,   // formato: [8US] - 10 pares | [9US] - 5 pares 
                    item.stock_total,
                    item.precio,
                    item.activo,
                    item.activo ? "ACTIVO" : "NO ACTIVO"
                });
            }

        }

        private void btnAgregarTalle_Click(object sender, EventArgs e)
        {
            if (comboBoxTalles.SelectedItem == null || string.IsNullOrWhiteSpace(textBoxStock.Text))
            {
                MessageBox.Show("Seleccione un talle y un stock");
                return;
            }

            string talle = comboBoxTalles.SelectedItem.ToString();
            int stock;

            if (!int.TryParse(textBoxStock.Text, out stock) || stock <= 0)
            {
                MessageBox.Show("Stock inválido");
                return;
            }

            // Verificar que no exista ya ese talle
            foreach (DataRow row in tablaTalles.Rows)
            {
                if (row["Talle"].ToString() == talle)
                {
                    MessageBox.Show("Ese talle ya fue agregado.");
                    return;
                }
            }

            tablaTalles.Rows.Add(talle, stock);
            textBoxStock.Clear();

        }

    }
}
