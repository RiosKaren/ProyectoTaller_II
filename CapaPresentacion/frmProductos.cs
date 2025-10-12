using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            // Inicializa el comboBoxBusqueda con columnas visibles del DataGridView
            comboBoxBusqueda.Items.Clear();

            comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = "codigo", Texto = "Código" });
            comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = "nombre", Texto = "Nombre" });
            comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = "talle", Texto = "Talles" });

            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";

            // Inicializa la tabla de talles
            tablaTalles = new DataTable();
            tablaTalles.Columns.Add("Talle", typeof(string));
            tablaTalles.Columns.Add("Stock", typeof(int));

            // vincula la tabla al DataGridView para mostrar talles cargados
            TallesDGV.DataSource = tablaTalles;
            TallesDGV.Columns["Talle"].HeaderText = "Talle";
            TallesDGV.Columns["Stock"].HeaderText = "Stock";
            TallesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TallesDGV.ReadOnly = true;
            TallesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TallesDGV.MultiSelect = false;
            TallesDGV.RowHeadersVisible = false;
            TallesDGV.AllowUserToAddRows = false;
            TallesDGV.AllowUserToDeleteRows = false;
            TallesDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TallesDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Preestablece talles del 35ARG al 42ARG en el ComboBox
            comboBoxTalles.Items.Clear();
            for (int i = 35; i <= 42; i++)
            {
                comboBoxTalles.Items.Add(i.ToString() + " ARG");
            }
            comboBoxTalles.SelectedIndex = -1; 

            // Muestra todos los productos existentes
            List<Productos> listaProductos = new CN_Producto().Listar();

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
            "", // columna botón seleccionar
            item.id_producto,
            item.codigo,
            imagenProducto, // muestra la imagen del producto
            item.nombre,
            item.descripcion,
            item.tallesTexto, // ejemplo: [38 ARG] - 3 pares | [39 ARG] - 5 pares
            item.stock_total,
            item.precio,
            item.activo,
            item.activo ? "ACTIVO" : "NO ACTIVO"
                });
            }

            // Precio predeterminado
            textBoxPrecio.Text = "0,00";
        }

        

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFDFotos = new OpenFileDialog();

            // Carpeta predeterminada: Imágenes del usuario
            string imagenesUsuario = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            OFDFotos.InitialDirectory = imagenesUsuario;

            if (OFDFotos.ShowDialog() == DialogResult.OK)
            {
                TBFotoPath.Text = OFDFotos.FileName;
                PBFoto.Image = Image.FromFile(OFDFotos.FileName);
                PBFoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string mensaje = string.Empty;

            Productos objProducto = new Productos()
            {
                id_producto = Convert.ToInt32(textBoxID.Text),
                codigo = textBoxCodigo.Text,
                nombre = textBoxNombre.Text,
                descripcion = TextBoxDescripcion.Text,
                precio = Convert.ToDecimal(textBoxPrecio.Text),
                imagen_url = string.IsNullOrEmpty(TBFotoPath.Text) ? null : Path.GetFileName(TBFotoPath.Text),
                activo = true
            };

            if (objProducto.id_producto == 0)
            {
                // NUEVO PRODUCTO
                int idGenerado = new CN_Producto().Registrar(objProducto, out mensaje);

                if (idGenerado != 0)
                {
                    GuardarTalles(idGenerado);
                    CopiarImagen();

                    MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // EDITAR PRODUCTO
                bool resultado = new CN_Producto().Editar(objProducto, out mensaje);

                if (resultado)
                {
                    // Actualiza los talles (elimino y vuelvo a insertar)
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                    {
                        conn.Open();

                        SqlCommand cmdDel = new SqlCommand("DELETE FROM talle_producto WHERE id_producto = @id", conn);
                        cmdDel.Parameters.AddWithValue("@id", objProducto.id_producto);
                        cmdDel.ExecuteNonQuery();

                        foreach (DataRow fila in tablaTalles.Rows)
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO talle_producto (id_producto, talla, stock) VALUES (@id, @talla, @stock)", conn);
                            cmd.Parameters.AddWithValue("@id", objProducto.id_producto);
                            cmd.Parameters.AddWithValue("@talla", fila["Talle"].ToString());
                            cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(fila["Stock"]));
                            cmd.ExecuteNonQuery();
                        }
                    }

                    CopiarImagen();

                    // Actualizo visualmente en el DataGridView
                    DataGridViewRow row = ProductosDGV.Rows[Convert.ToInt32(textBoxIndice.Text)];
                    row.Cells["codigo"].Value = objProducto.codigo;
                    row.Cells["nombre"].Value = objProducto.nombre;
                    row.Cells["descripcion"].Value = objProducto.descripcion;
                    row.Cells["precio"].Value = objProducto.precio;

                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GuardarTalles(int idProducto)
        {
            foreach (DataRow row in tablaTalles.Rows)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO talle_producto (id_producto, talla, stock) VALUES (@id, @talla, @stock)", conn);
                    cmd.Parameters.AddWithValue("@id", idProducto);
                    cmd.Parameters.AddWithValue("@talla", row["Talle"].ToString());
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(row["Stock"]));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void CopiarImagen()
        {
            if (!string.IsNullOrEmpty(TBFotoPath.Text) && File.Exists(TBFotoPath.Text))
            {
                string destino = Path.Combine(Application.StartupPath, "..\\..\\Fotos", Path.GetFileName(TBFotoPath.Text));
                if (!File.Exists(destino))
                    File.Copy(TBFotoPath.Text, destino, true);
            }
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxCodigo.Text) ||
                string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(TextBoxDescripcion.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrecio.Text) ||
                TallesDGV.Rows.Count == 0)
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Valida que el precio sea mayor que 0.00
            if (!decimal.TryParse(textBoxPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor que 0.00.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            textBoxCodigo.Clear();
            textBoxNombre.Clear();
            TextBoxDescripcion.Clear();
            textBoxPrecio.Text = "0,00";
            TBFotoPath.Clear();
            PBFoto.Image = null;

            if (tablaTalles != null)
                tablaTalles.Rows.Clear();

            textBoxStock.Clear();
            comboBoxTalles.SelectedIndex = -1;

            textBoxCodigo.Select(); //Pone el foco en la textbox DNI
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permitir solo control, dígitos o coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }

            // Solo permitir una coma
            if (e.KeyChar == ',' && txt.Text.Contains(','))
            {
                e.Handled = true;
                return;
            }

            // Limitar a 2 decimales después de la coma
            if (char.IsDigit(e.KeyChar) && txt.Text.Contains(','))
            {
                int indexComa = txt.Text.IndexOf(',');
                string decimales = txt.Text.Substring(indexComa + 1);

                if (txt.SelectionStart > indexComa && decimales.Length >= 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
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
            comboBoxTalles.SelectedIndex = -1;

        }

        private void btnBorrarTalle_Click(object sender, EventArgs e)
        {
            if (TallesDGV.SelectedRows.Count > 0)
            {
                int index = TallesDGV.SelectedRows[0].Index;
                string talle = tablaTalles.Rows[index]["Talle"].ToString();

                DialogResult result = MessageBox.Show(
                    $"¿Desea eliminar el talle {talle}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    tablaTalles.Rows.RemoveAt(index);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un talle para eliminar.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            textBoxStock.Clear();
            comboBoxTalles.SelectedIndex = -1;
        }


        private void TallesDGV_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica que haya al menos una fila seleccionada
            if (TallesDGV.SelectedRows.Count > 0)
            {
                int index = TallesDGV.SelectedRows[0].Index;

                // Validar que el índice exista en la tabla (por seguridad)
                if (index >= 0 && index < tablaTalles.Rows.Count)
                {
                    string talle = tablaTalles.Rows[index]["Talle"].ToString();
                    string stock = tablaTalles.Rows[index]["Stock"].ToString();

                }
            }
        }



        private void CargarProductos()
        {
            ProductosDGV.Rows.Clear();

            List<Productos> listaProductos = new CN_Producto().Listar();

            foreach (Productos item in listaProductos)
            {
                Image imagenProducto = null;

                if (!string.IsNullOrEmpty(item.imagen_url))
                {
                    // ruta correcta de la carpeta Fotos
                    string rutaImagen = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Fotos", item.imagen_url);
                    if (File.Exists(rutaImagen))
                        imagenProducto = Image.FromFile(rutaImagen);
                }

                ProductosDGV.Rows.Add(new object[]
                {
            "",
            item.id_producto,
            item.codigo,
            imagenProducto,
            item.nombre,
            item.descripcion,
            item.tallesTexto,
            item.stock_total,
            item.precio,
            item.activo,
            item.activo ? "ACTIVO" : "NO ACTIVO",
                });
            }
        }


        private void ProductosDGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return; // No pintar encabezado

            // Verificamos si la columna actual es la del botón seleccionar
            if (e.ColumnIndex == 0) // Asegúrate que la columna del botón tenga índice 0
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Dimensiones del icono
                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;

                // Centramos la imagen dentro de la celda
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                // Dibuja el ícono (usa el mismo "check" del proyecto)
                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));

                e.Handled = true; // Marcamos el evento como manejado
            }
        }

        private void ProductosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return; // si la celda seleccionada es el encabezado, no hace nada

            if (ProductosDGV.Columns[e.ColumnIndex].Name != "botonSeleccionar")
                return; // si no es la columna del botón seleccionar, no hace nada

            // Obtiene la fila seleccionada
            var row = ProductosDGV.Rows[e.RowIndex];

            // Guarda el índice y el id del producto seleccionado
            textBoxIndice.Text = e.RowIndex.ToString();
            textBoxID.Text = Convert.ToString(row.Cells["id_producto"].Value);

            // Carga los datos del producto seleccionado
            textBoxCodigo.Text = Convert.ToString(row.Cells["codigo"].Value);
            textBoxNombre.Text = Convert.ToString(row.Cells["nombre"].Value);
            TextBoxDescripcion.Text = Convert.ToString(row.Cells["descripcion"].Value);
            textBoxPrecio.Text = Convert.ToString(row.Cells["precio"].Value);

            // Muestra imagen del producto
            PBFoto.Image = row.Cells["imagen_url"].Value as Image;
            PBFoto.SizeMode = PictureBoxSizeMode.Zoom;
            TBFotoPath.Clear();

            // Muestra los talles asociados al producto
            tablaTalles.Rows.Clear();
            int idProducto = Convert.ToInt32(row.Cells["id_producto"].Value);
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT talla, stock FROM talle_producto WHERE id_producto = @id", conn);
                cmd.Parameters.AddWithValue("@id", idProducto);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tablaTalles.Rows.Add(dr["talla"].ToString(), Convert.ToInt32(dr["stock"]));
                }
            }

            // Bloquea campos por defecto
            BloquearCamposProducto();
        }


        private void BloquearCamposProducto()
        {
            foreach (TextBoxBase tb in new TextBoxBase[]
            {
                textBoxCodigo,
                textBoxNombre,
                TextBoxDescripcion,  
                textBoxPrecio,
                TBFotoPath           
            })
            {
                tb.ReadOnly = true;
                tb.Cursor = Cursors.No;
            }

            comboBoxTalles.Enabled = false;
            textBoxStock.ReadOnly = true;
            btnAgregarTalle.Enabled = false;
            btnBorrarTalle.Enabled = false;
            btnAgregarImagen.Enabled = false;
        }




        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text) || textBoxID.Text == "0")
            {
                MessageBox.Show("Debe seleccionar un producto primero",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Habilita campos para edición
            foreach (TextBoxBase tb in new TextBoxBase[]
            {
        textBoxCodigo,
        textBoxNombre,
        TextBoxDescripcion,
        textBoxPrecio,
        TBFotoPath
            })
            {
                tb.ReadOnly = false;
                tb.Cursor = Cursors.IBeam;
            }

            comboBoxTalles.Enabled = true;
            textBoxStock.ReadOnly = false;
            btnAgregarTalle.Enabled = true;
            btnBorrarTalle.Enabled = true;
            btnAgregarImagen.Enabled = true;
        }


        private void iconButtonHabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text) || textBoxID.Text == "0")
            {
                MessageBox.Show("Debe seleccionar un producto primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Desea dar de alta al producto?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = string.Empty;
                Productos objProducto = new Productos()
                {
                    id_producto = Convert.ToInt32(textBoxID.Text)
                };

                bool respuesta = new CN_Producto().CambiarEstado(objProducto, "ALTA", out mensaje);

                if (respuesta)
                {
                    DataGridViewRow row = ProductosDGV.Rows[Convert.ToInt32(textBoxIndice.Text)];
                    row.Cells["activo"].Value = "1";
                    row.Cells["estado"].Value = "ACTIVO";

                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            LimpiarFormulario();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text) || textBoxID.Text == "0")
            {
                MessageBox.Show("Debe seleccionar un producto primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Desea dar de baja al producto?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = string.Empty;
                Productos objProducto = new Productos()
                {
                    id_producto = Convert.ToInt32(textBoxID.Text)
                };

                bool respuesta = new CN_Producto().CambiarEstado(objProducto, "BAJA", out mensaje);

                if (respuesta)
                {
                    DataGridViewRow row = ProductosDGV.Rows[Convert.ToInt32(textBoxIndice.Text)];
                    row.Cells["activo"].Value = "0";
                    row.Cells["estado"].Value = "NO ACTIVO";

                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            LimpiarFormulario();
        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            // Verifica que se haya seleccionado un campo
            if (comboBoxBusqueda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un campo para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verifica que haya texto escrito en el cuadro de búsqueda
            if (string.IsNullOrWhiteSpace(textBoxBusqueda.Text))
            {
                MessageBox.Show("Ingrese un texto para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtiene la columna seleccionada
            string columnaFiltro = ((OpcionCombo)comboBoxBusqueda.SelectedItem).Valor.ToString();
            string textoBuscado = RemoverAcentos(textBoxBusqueda.Text.Trim().ToUpper());

            // Recorre las filas del DataGridView
            if (ProductosDGV.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in ProductosDGV.Rows)
                {
                    if (row.Cells[columnaFiltro].Value != null)
                    {
                        string valorCelda = RemoverAcentos(row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper());

                        if (valorCelda.Contains(textoBuscado))
                            row.Visible = true;  // muestra la fila
                        else
                            row.Visible = false; // oculta la fila
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private string RemoverAcentos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            // Normaliza el texto para separar letras de sus acentos
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
            textBoxBusqueda.Text = ""; // limpia el cuadro de texto

            foreach (DataGridViewRow row in ProductosDGV.Rows)
            {
                row.Visible = true; // muestra todas las filas nuevamente
            }
        }

    }
}
