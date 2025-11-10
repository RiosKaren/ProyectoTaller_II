using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.VentanasEmergentes
{
    public partial class veProductos : Form
    {
        public Productos _Producto { get; set; }

        public veProductos()
        {
            InitializeComponent();
        }

        private void veProductos_Load(object sender, EventArgs e)
        {
            List<Productos> listaProductos = new CN_Producto().ListarActivosConStock();

            ProductosDGV.Rows.Clear();

            // Configura el DataGridView para texto multilínea y ajuste dinámico
            ProductosDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            ProductosDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Carga productos en el DataGridView
            foreach (Productos item in listaProductos)
            {
                Image imagenProducto = null;

                if (!string.IsNullOrEmpty(item.imagen_url))
                {
                    string rutaImagen = Path.Combine(Application.StartupPath, "..\\..\\Fotos", item.imagen_url);
                    if (File.Exists(rutaImagen))
                        imagenProducto = Image.FromFile(rutaImagen);
                }

                ProductosDGV.Rows.Add(new object[]
                {
                    item.id_producto,
                    item.codigo,
                    imagenProducto, // muestra la imagen del producto
                    item.nombre,
                    item.descripcion,
                    item.tallesTexto, // ejemplo: [38 ARG] - 3 pares | [39 ARG] - 5 pares
                    item.stock_total,
                    item.precio,
                    item.activo,
                });

                comboBoxBusqueda.Items.Clear();
                comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = "codigo", Texto = "Código" });
                comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = "nombre", Texto = "Nombre" });
                comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = "descripcion", Texto = "Descripción" });
                comboBoxBusqueda.DisplayMember = "Texto";
                comboBoxBusqueda.ValueMember = "Valor";
                comboBoxBusqueda.SelectedIndex = 0;
            }
        }

        private void ProductosDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if(iRow >= 0 && iColum > 0)
            {
                _Producto = new Productos()
                {
                    id_producto = Convert.ToInt32(ProductosDGV.Rows[iRow].Cells["id_producto"].Value),
                    codigo = ProductosDGV.Rows[iRow].Cells["codigo"].Value.ToString(),
                    nombre = ProductosDGV.Rows[iRow].Cells["nombre"].Value.ToString(),
                    descripcion = ProductosDGV.Rows[iRow].Cells["descripcion"].Value.ToString(),
                    precio = Convert.ToDecimal(ProductosDGV.Rows[iRow].Cells["precio"].Value),
                    activo = Convert.ToBoolean(ProductosDGV.Rows[iRow].Cells["activo"].Value)
                };

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBusqueda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un campo para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxBusqueda.Text))
            {
                MessageBox.Show("Ingrese un texto para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string columnaFiltro = ((OpcionCombo)comboBoxBusqueda.SelectedItem).Valor.ToString();
            string textoBuscado = RemoverAcentos(textBoxBusqueda.Text.Trim().ToUpper());

            foreach (DataGridViewRow row in ProductosDGV.Rows)
            {
                if (row.Cells[columnaFiltro].Value != null)
                {
                    string valorCelda = RemoverAcentos(row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper());

                    if (valorCelda.Contains(textoBuscado))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private string RemoverAcentos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            // Normaliza los caracteres a su forma base
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in textoNormalizado)
            {
                UnicodeCategory categoria = CharUnicodeInfo.GetUnicodeCategory(c);
                if (categoria != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        private void iconButtonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Text = "";
            foreach (DataGridViewRow row in ProductosDGV.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
