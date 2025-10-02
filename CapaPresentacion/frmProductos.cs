using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            tablaTalles = new DataTable();
            tablaTalles.Columns.Add("Talle", typeof(string));
            tablaTalles.Columns.Add("Stock", typeof(int));

            // Vincularlo al DataGridView
            dgvTalles.DataSource = tablaTalles;
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
