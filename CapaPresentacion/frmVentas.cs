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

using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

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
            textBoxIDTalle.Text = "0";
            textBoxVendedor.Text = _Usuario.nombre + ", " + _Usuario.apellido;

            // Combo tipo de pago
            comboBoxPagaCon.Items.Clear();
            comboBoxPagaCon.Items.Add(new OpcionCombo() { Valor = "efectivo", Texto = "Efectivo" });
            comboBoxPagaCon.Items.Add(new OpcionCombo() { Valor = "debito", Texto = "Débito" });
            comboBoxPagaCon.Items.Add(new OpcionCombo() { Valor = "credito", Texto = "Crédito" });
            comboBoxPagaCon.DisplayMember = "Texto";
            comboBoxPagaCon.ValueMember = "Valor";
            comboBoxPagaCon.SelectedIndex = 0;

            comboBoxPagaCon.SelectedIndexChanged += comboBoxPagaCon_SelectedIndexChanged;

            labelCuotas.Visible = false;
            comboBoxCuotas.Visible = false;
            comboBoxCuotas.Enabled = false;
            comboBoxPagaCon.Enabled = false;
            textBoxTotal.ReadOnly = true;

        }


        private void comboBoxPagaCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seleccion = ((OpcionCombo)comboBoxPagaCon.SelectedItem).Valor.ToString();
            decimal total = 0;
            decimal.TryParse(textBoxTotal.Text.Replace("$", "").Trim(), out total);

            comboBoxCuotas.Items.Clear();

            if (seleccion == "credito")
            {
                labelCuotas.Visible = true;
                comboBoxCuotas.Visible = true;

                comboBoxCuotas.Items.Add($"1 cuota de ${total:N0} sin interés");
                comboBoxCuotas.Items.Add($"3 cuotas de ${(total / 3):N0} sin interés");
                comboBoxCuotas.Items.Add($"6 cuotas de ${(total / 6):N0} sin interés");
                comboBoxCuotas.Items.Add($"12 cuotas de ${(total / 12):N0} sin interés");
                comboBoxCuotas.SelectedIndex = 0;
            }
            else if (seleccion == "debito")
            {
                labelCuotas.Visible = true;
                comboBoxCuotas.Visible = true;

                comboBoxCuotas.Items.Add($"1 cuota de ${total:N0}");
                comboBoxCuotas.SelectedIndex = 0;
            }
            else // efectivo
            {
                labelCuotas.Visible = false;
                comboBoxCuotas.Visible = false;
            }
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

                    numericUpDownCantidad.Enabled = true;
                    comboBoxTalle.Select();
                }
                else
                {
                    textBoxCodigoP.Select();
                }
            }
        }

        private void CargarTalles(int idProducto)
        {
            comboBoxTalle.Items.Clear();

            List<Talle_producto> listaTalles = new CN_Producto().ObtenerTallesPorProducto(idProducto);
            var tallesDisponibles = listaTalles.Where(t => t.stock > 0).ToList();

            if (tallesDisponibles.Count > 0)
            {
                foreach (Talle_producto t in tallesDisponibles)
                {
                    comboBoxTalle.Items.Add(new TalleComboItem()
                    {
                        IdTalle = t.id_talle, // Asumiendo que existe esta propiedad
                        Stock = t.stock,
                        Texto = t.talla
                    });
                }

                comboBoxTalle.DisplayMember = "Texto";
                comboBoxTalle.SelectedIndex = 0;
                comboBoxTalle.Enabled = true;
            }
            else
            {
                comboBoxTalle.Items.Add(new TalleComboItem()
                {
                    IdTalle = 0,
                    Stock = 0,
                    Texto = "Sin stock disponible"
                });
                comboBoxTalle.SelectedIndex = 0;
                comboBoxTalle.Enabled = false;
            }
        }

        private void comboBoxTalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTalle.SelectedItem != null && comboBoxTalle.SelectedItem is TalleComboItem item)
            {
                // Muestra el ID del talle
                textBoxIDTalle.Text = item.IdTalle.ToString();

                // Muestra el stock en el TextBox
                textBoxStock.Text = item.Stock.ToString();

                // Actualiza el máximo permitido en el NumericUpDown de cantidad
                numericUpDownCantidad.Maximum = item.Stock;

                // Reinicia la cantidad a 1 cada vez que cambia el talle
                numericUpDownCantidad.Value = 1;
            }
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxTalle.SelectedItem is TalleComboItem item) // <- antes OpcionCombo
            {
                int stockMaximo = item.Stock;
                if (numericUpDownCantidad.Value > stockMaximo)
                {
                    numericUpDownCantidad.Value = stockMaximo;
                    MessageBox.Show($"No puede superar el stock disponible ({stockMaximo}).",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    fila.Cells["talla"].Value.ToString() == comboBoxTalle.Text)
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
                    textBoxProducto.Text,
                    textBoxIDTalle.Text,
                    comboBoxTalle.Text,
                    numericUpDownCantidad.Value,
                    textBoxPrecio.Text,
                    (numericUpDownCantidad.Value * decimal.Parse(textBoxPrecio.Text.Replace("$",""))).ToString("$0.00")
                });
            }
            comboBoxCuotas.Enabled = true;
            comboBoxPagaCon.Enabled = true;
            calcularTotal();
            limpiarProducto();
            textBoxCodigoP.Focus();

        }

        private void limpiarProducto()
        {
            textBoxIDProducto.Text = "0";
            textBoxCodigoP.Text = "";
            textBoxProducto.Text = "";
            textBoxIDTalle.Text = "0";
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

            // Actualizar comboBoxCuotas si el pago ya está habilitado
            if (comboBoxPagaCon.Enabled)
            {
                ActualizarCuotas();
            }
        }

        private void ActualizarCuotas()
        {
            if (comboBoxPagaCon.SelectedItem == null)
                return;

            var seleccion = ((OpcionCombo)comboBoxPagaCon.SelectedItem).Valor.ToString();

            decimal total = 0;
            decimal.TryParse(textBoxTotal.Text.Replace("$", "").Trim(), out total);

            comboBoxCuotas.Items.Clear();

            if (seleccion == "credito")
            {
                labelCuotas.Visible = true;
                comboBoxCuotas.Visible = true;

                comboBoxCuotas.Items.Add("Seleccione las cuotas");
                comboBoxCuotas.Items.Add($"1 cuota de ${total:N0} sin interés");
                comboBoxCuotas.Items.Add($"3 cuotas de ${(total / 3):N0} sin interés");
                comboBoxCuotas.Items.Add($"6 cuotas de ${(total / 6):N0} sin interés");
                comboBoxCuotas.Items.Add($"12 cuotas de ${(total / 12):N0} sin interés");
                comboBoxCuotas.SelectedIndex = 0;
            }
            else if (seleccion == "debito")
            {
                labelCuotas.Visible = true;
                comboBoxCuotas.Visible = true;

                comboBoxCuotas.Items.Add($"1 cuota de ${total:N0}");
                comboBoxCuotas.SelectedIndex = 0;
            }
            else // efectivo
            {
                labelCuotas.Visible = false;
                comboBoxCuotas.Visible = false;
            }
        }

        private void VentaProductosDGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return; // No pintar encabezado

            // Verificamos si la columna actual es la del botón eliminar
            if (e.ColumnIndex == 7) // Asegúrate que la columna del botón tenga índice 8
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Dimensiones del icono
                var w = Properties.Resources.borrar.Width;
                var h = Properties.Resources.borrar.Height;

                // Centramos la imagen dentro de la celda
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.borrar, new Rectangle(x, y, w, h));

                e.Handled = true; // Marcamos el evento como manejado
            }
        }

        private void VentaProductosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VentaProductosDGV.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    VentaProductosDGV.Rows.RemoveAt(index);
                    calcularTotal();

                    // Si ya no quedan filas, deshabilitar opciones de pago
                    if (VentaProductosDGV.Rows.Count == 0)
                    {
                        comboBoxPagaCon.Enabled = false;
                        comboBoxCuotas.Visible = false;
                        labelCuotas.Visible = false;
                    }
                }
            }
        }


        private void comboBoxPagaCon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActualizarCuotas();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            // Validaciones mínimas
            if (VentaProductosDGV.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!int.TryParse(textBoxIDCliente.Text, out int idCliente) || idCliente == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Armar TVP desde el DGV
            var dt = CapaDatos.CD_Venta.NuevaTablaDetalles();
            foreach (DataGridViewRow fila in VentaProductosDGV.Rows)
            {
                if (fila.IsNewRow) continue;

                int idTalle = Convert.ToInt32(fila.Cells["id_talle"].Value);
                int cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);

                // "precio" llega con símbolo "$"
                decimal precioUnit =
                    Convert.ToDecimal(fila.Cells["precio_unitario"].Value.ToString().Replace("$", "").Trim());

                dt.Rows.Add(idTalle, cantidad, precioUnit);
            }

            // Llamada a negocio
            var cn = new CapaNegocio.CN_Venta();
            bool ok = cn.RegistrarVenta(
                puntoVenta: 1, 
                idCliente: idCliente,
                idUsuario: _Usuario.id_usuario,   // <- tu objeto ya está en el form
                detalles: dt,
                idFactura: out int idFactura,
                nroFactura: out string nroFactura,
                mensaje: out string msg
            );

            if (ok)
            {
                MessageBox.Show($"Venta registrada. Factura #{nroFactura}", "OK",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    var ds = new CapaNegocio.CN_Venta().ObtenerVentaDS(idFactura);
                    string rutaPdf = PdfFactura.GenerarDesdeVentaDS(ds); // crea en Mis Documentos\Facturas
                    PdfFactura.Abrir(rutaPdf);                           // lo abre con el visor por defecto
                                                                         // Si querés mandarlo directo a impresión:
                                                                         // PdfFactura.Imprimir(rutaPdf);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La venta se registró, pero no se pudo generar/abrir el PDF.\n" + ex.Message,
                                    "PDF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Reset UI
                VentaProductosDGV.Rows.Clear();
                textBoxTotal.Text = "$0.00";
                comboBoxPagaCon.Enabled = false;
                comboBoxCuotas.Visible = false;
                labelCuotas.Visible = false;
                textBoxDNICliente.Text = string.Empty;
                textBoxNombreCliente.Text = string.Empty;
                textBoxIDCliente.Text = "0";
            }
            else
            {
                MessageBox.Show($"No se pudo registrar la venta.\n{msg}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
