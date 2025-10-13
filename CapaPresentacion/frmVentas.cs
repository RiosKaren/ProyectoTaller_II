using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using CapaPresentacion.VentanasEmergentes;
using FontAwesome.Sharp;
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
            
            textBoxVendedor.Text = _Usuario.nombre + ", " + _Usuario.apellido;




        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var ventana = new veClientes())
            {
                var result = ventana.ShowDialog();

                if (result == DialogResult.OK) 
                {
                    Clientes oCliente = ventana._Cliente;
                    textBoxIDCliente.Text = oCliente.id_cliente.ToString();
                    textBoxDNICliente.Text = oCliente.dni.ToString();
                    textBoxNombreCliente.Text = oCliente.apellido + ", " + oCliente.nombre;
                }


            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var ventana = new veProductos())
            {
                var result = ventana.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Productos oProducto = ventana._Producto;
                    textBoxIDProducto.Text = oProducto.id_producto.ToString();
                    textBoxCodigoP.Text = oProducto.codigo.ToString();
                    textBoxProducto.Text = oProducto.nombre.ToString();
                    CargarTalles(oProducto.id_producto);
                    textBoxPrecio.Text = oProducto.precio.ToString("$0.00");

                    numericUpDownCantidad.ReadOnly = false;
                    numericUpDownCantidad.Enabled = true;


                }
            }
        }

        private void CargarTalles(int idProducto)
        {
            comboBoxTalle.Items.Clear();

            // Obtiene la lista de talles del producto desde la capa de negocio
            List<Talle_producto> listaTalles = new CN_Producto().ObtenerTallesPorProducto(idProducto);

            // Filtra solo los talles con stock mayor a 0
            var tallesDisponibles = listaTalles.Where(t => t.stock > 0).ToList();

            if (tallesDisponibles.Count > 0)
            {
                // Carga solo los talles disponibles en el combo
                foreach (Talle_producto t in tallesDisponibles)
                {
                    comboBoxTalle.Items.Add(new OpcionCombo()
                    {
                        Valor = t.stock,
                        Texto = t.talla
                    });
                }

                comboBoxTalle.DisplayMember = "Texto";
                comboBoxTalle.ValueMember = "Valor";
                comboBoxTalle.SelectedIndex = 0;
                comboBoxTalle.Enabled = true;
            }
            else
            {
                // Si ningún talle tiene stock, deshabilita el combo
                comboBoxTalle.Items.Add(new OpcionCombo()
                {
                    Valor = 0,
                    Texto = "Sin stock disponible"
                });
                comboBoxTalle.SelectedIndex = 0;
                comboBoxTalle.Enabled = false;
            }
        }

        private void comboBoxTalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTalle.SelectedItem != null && comboBoxTalle.SelectedItem is OpcionCombo opcion)
            {
                // Convierte el valor del item seleccionado en stock disponible
                int stockDisponible = Convert.ToInt32(opcion.Valor);

                // Muestra el stock en el TextBox
                textBoxStock.Text = stockDisponible.ToString();

                // Actualiza el máximo permitido en el NumericUpDown de cantidad
                numericUpDownCantidad.Maximum = stockDisponible;

                // Reinicia la cantidad a 1 cada vez que cambia el talle
                numericUpDownCantidad.Value = 1;
            }
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxTalle.SelectedItem != null && comboBoxTalle.SelectedItem is OpcionCombo opcion)
            {
                int stockMaximo = Convert.ToInt32(opcion.Valor);

                if (numericUpDownCantidad.Value > stockMaximo)
                {
                    numericUpDownCantidad.Value = stockMaximo;
                    MessageBox.Show($"No puede superar el stock disponible ({stockMaximo}).",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Para buscar el producto por su codigo al presionar Enter
        private void textBoxCodigoP_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Productos oProducto = new CN_Producto().ListarActivosConStock().Where(p => p.codigo == textBoxCodigoP.Text && p.activo == true).FirstOrDefault();

                if(oProducto != null)
                {
                    textBoxCodigoP.BackColor = Color.Honeydew;
                    textBoxIDProducto.Text = oProducto.id_producto.ToString();
                    textBoxProducto.Text = oProducto.nombre.ToString();
                    CargarTalles(oProducto.id_producto);
                    textBoxPrecio.Text = oProducto.precio.ToString("$0.00");
                    numericUpDownCantidad.ReadOnly = false;
                    numericUpDownCantidad.Enabled = true;
                    numericUpDownCantidad.Value = 1;
                    comboBoxTalle.Focus();

                } else
                {
                                       textBoxCodigoP.BackColor = Color.MistyRose;
                    textBoxIDProducto.Text = "0";
                    textBoxProducto.Text = "";
                    comboBoxTalle.Items.Clear();
                    comboBoxTalle.Enabled = false;
                    textBoxPrecio.Text = "";
                    numericUpDownCantidad.Value = 1;
                    numericUpDownCantidad.ReadOnly = true;
                    numericUpDownCantidad.Enabled = false;
                }

            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool productoExiste = false;

            if (int.Parse(textBoxIDProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in VentaProductosDGV.Rows)
            {
                if (fila.Cells["id_producto"].Value.ToString() == textBoxIDProducto.Text &&
                    fila.Cells["talle"].Value.ToString() == comboBoxTalle.Text)
                {
                    productoExiste = true;
                    break;
                }
            }
            
            
            if(!productoExiste)
            {
                VentaProductosDGV.Rows.Add(new object[]
                {
                    textBoxIDProducto.Text,
                    textBoxCodigoP.Text,
                    textBoxProducto.Text,
                    comboBoxTalle.Text,
                    numericUpDownCantidad.Value,
                    textBoxPrecio.Text,
                    (numericUpDownCantidad.Value * decimal.Parse(textBoxPrecio.Text.Replace("$",""))).ToString("$0.00")
                });
            }

            calcularTotal();
            limpiarProducto();
            textBoxCodigoP.Focus();

        }

        private void limpiarProducto()
        {
            textBoxIDProducto.Text = "0";
            textBoxCodigoP.Text = "";
            textBoxProducto.Text = "";
            comboBoxTalle.Items.Clear();
            comboBoxTalle.Enabled = false;
            textBoxPrecio.Text = "";
            textBoxStock.Text = "";
            numericUpDownCantidad.Value = 1;
            numericUpDownCantidad.ReadOnly = true;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in VentaProductosDGV.Rows)
            {
                total += Convert.ToDecimal(fila.Cells["subtotal"].Value.ToString().Replace("$", ""));
            }
            textBoxTotal.Text = total.ToString("$0.00");
        }   

    }
}
