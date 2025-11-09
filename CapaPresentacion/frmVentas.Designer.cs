namespace CapaPresentacion
{
    partial class frmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelListaUsuarios = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxVendedor = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDNICliente = new System.Windows.Forms.TextBox();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.textBoxIDCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxIDTalle = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxIDProducto = new System.Windows.Forms.TextBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.comboBoxTalle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.textBoxCodigoP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VentaProductosDGV = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.comboBoxPagaCon = new System.Windows.Forms.ComboBox();
            this.labelCuotas = new System.Windows.Forms.Label();
            this.comboBoxCuotas = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaProductosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListaUsuarios
            // 
            this.labelListaUsuarios.BackColor = System.Drawing.Color.White;
            this.labelListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaUsuarios.Location = new System.Drawing.Point(28, 17);
            this.labelListaUsuarios.Name = "labelListaUsuarios";
            this.labelListaUsuarios.Size = new System.Drawing.Size(1038, 510);
            this.labelListaUsuarios.TabIndex = 26;
            this.labelListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Registrar Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textBoxVendedor);
            this.groupBox1.Controls.Add(this.textBoxFecha);
            this.groupBox1.Controls.Add(this.labelVendedor);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Location = new System.Drawing.Point(59, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(390, 72);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // textBoxVendedor
            // 
            this.textBoxVendedor.Location = new System.Drawing.Point(188, 32);
            this.textBoxVendedor.Name = "textBoxVendedor";
            this.textBoxVendedor.ReadOnly = true;
            this.textBoxVendedor.Size = new System.Drawing.Size(145, 20);
            this.textBoxVendedor.TabIndex = 87;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(26, 31);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(140, 20);
            this.textBoxFecha.TabIndex = 86;
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Location = new System.Drawing.Point(188, 15);
            this.labelVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(56, 13);
            this.labelVendedor.TabIndex = 29;
            this.labelVendedor.Text = "Vendedor:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(24, 15);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(40, 13);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número Documento:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.textBoxDNICliente);
            this.groupBox2.Controls.Add(this.textBoxNombreCliente);
            this.groupBox2.Controls.Add(this.textBoxIDCliente);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(666, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(371, 72);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Cliente";
            // 
            // textBoxDNICliente
            // 
            this.textBoxDNICliente.Location = new System.Drawing.Point(26, 32);
            this.textBoxDNICliente.Name = "textBoxDNICliente";
            this.textBoxDNICliente.ReadOnly = true;
            this.textBoxDNICliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNICliente.TabIndex = 88;
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(206, 32);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.ReadOnly = true;
            this.textBoxNombreCliente.Size = new System.Drawing.Size(147, 20);
            this.textBoxNombreCliente.TabIndex = 88;
            // 
            // textBoxIDCliente
            // 
            this.textBoxIDCliente.Location = new System.Drawing.Point(336, 10);
            this.textBoxIDCliente.Name = "textBoxIDCliente";
            this.textBoxIDCliente.Size = new System.Drawing.Size(28, 20);
            this.textBoxIDCliente.TabIndex = 30;
            this.textBoxIDCliente.Visible = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.IconSize = 16;
            this.btnBuscarCliente.Location = new System.Drawing.Point(131, 32);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(34, 18);
            this.btnBuscarCliente.TabIndex = 36;
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.textBoxIDTalle);
            this.groupBox3.Controls.Add(this.textBoxStock);
            this.groupBox3.Controls.Add(this.labelStock);
            this.groupBox3.Controls.Add(this.textBoxIDProducto);
            this.groupBox3.Controls.Add(this.numericUpDownCantidad);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxPrecio);
            this.groupBox3.Controls.Add(this.comboBoxTalle);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxProducto);
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.textBoxCodigoP);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(59, 164);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(756, 70);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Venta";
            // 
            // textBoxIDTalle
            // 
            this.textBoxIDTalle.Location = new System.Drawing.Point(402, -3);
            this.textBoxIDTalle.Name = "textBoxIDTalle";
            this.textBoxIDTalle.Size = new System.Drawing.Size(28, 20);
            this.textBoxIDTalle.TabIndex = 42;
            this.textBoxIDTalle.Visible = false;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(440, 31);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.ReadOnly = true;
            this.textBoxStock.Size = new System.Drawing.Size(51, 20);
            this.textBoxStock.TabIndex = 92;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(438, 15);
            this.labelStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(38, 13);
            this.labelStock.TabIndex = 91;
            this.labelStock.Text = "Stock:";
            // 
            // textBoxIDProducto
            // 
            this.textBoxIDProducto.Location = new System.Drawing.Point(138, -3);
            this.textBoxIDProducto.Name = "textBoxIDProducto";
            this.textBoxIDProducto.Size = new System.Drawing.Size(28, 20);
            this.textBoxIDProducto.TabIndex = 38;
            this.textBoxIDProducto.Visible = false;
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownCantidad.Enabled = false;
            this.numericUpDownCantidad.Location = new System.Drawing.Point(627, 31);
            this.numericUpDownCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.ReadOnly = true;
            this.numericUpDownCantidad.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownCantidad.TabIndex = 90;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.ValueChanged += new System.EventHandler(this.numericUpDownCantidad_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(624, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Precio:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(507, 31);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(109, 20);
            this.textBoxPrecio.TabIndex = 85;
            // 
            // comboBoxTalle
            // 
            this.comboBoxTalle.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxTalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTalle.FormattingEnabled = true;
            this.comboBoxTalle.Location = new System.Drawing.Point(350, 31);
            this.comboBoxTalle.Name = "comboBoxTalle";
            this.comboBoxTalle.Size = new System.Drawing.Size(80, 21);
            this.comboBoxTalle.TabIndex = 34;
            this.comboBoxTalle.SelectedIndexChanged += new System.EventHandler(this.comboBoxTalle_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Talle:";
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Location = new System.Drawing.Point(188, 31);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.ReadOnly = true;
            this.textBoxProducto.Size = new System.Drawing.Size(145, 20);
            this.textBoxProducto.TabIndex = 84;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 16;
            this.btnBuscarProducto.Location = new System.Drawing.Point(131, 31);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(34, 18);
            this.btnBuscarProducto.TabIndex = 37;
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // textBoxCodigoP
            // 
            this.textBoxCodigoP.Location = new System.Drawing.Point(26, 31);
            this.textBoxCodigoP.Name = "textBoxCodigoP";
            this.textBoxCodigoP.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoP.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cod. Producto:";
            // 
            // VentaProductosDGV
            // 
            this.VentaProductosDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VentaProductosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.VentaProductosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentaProductosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre,
            this.id_talle,
            this.talla,
            this.cantidad,
            this.precio_unitario,
            this.subtotal,
            this.btnEliminar});
            this.VentaProductosDGV.Location = new System.Drawing.Point(59, 241);
            this.VentaProductosDGV.Margin = new System.Windows.Forms.Padding(4);
            this.VentaProductosDGV.MultiSelect = false;
            this.VentaProductosDGV.Name = "VentaProductosDGV";
            this.VentaProductosDGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VentaProductosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VentaProductosDGV.RowHeadersWidth = 51;
            this.VentaProductosDGV.RowTemplate.Height = 28;
            this.VentaProductosDGV.Size = new System.Drawing.Size(756, 274);
            this.VentaProductosDGV.TabIndex = 31;
            this.VentaProductosDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VentaProductosDGV_CellContentClick);
            this.VentaProductosDGV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.VentaProductosDGV_CellPainting);
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "id_producto";
            this.id_producto.MinimumWidth = 6;
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Visible = false;
            this.id_producto.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Producto";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 170;
            // 
            // id_talle
            // 
            this.id_talle.HeaderText = "id talle";
            this.id_talle.MinimumWidth = 6;
            this.id_talle.Name = "id_talle";
            this.id_talle.ReadOnly = true;
            this.id_talle.Visible = false;
            this.id_talle.Width = 125;
            // 
            // talla
            // 
            this.talla.HeaderText = "Talle";
            this.talla.MinimumWidth = 6;
            this.talla.Name = "talla";
            this.talla.ReadOnly = true;
            this.talla.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 125;
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "Precio";
            this.precio_unitario.MinimumWidth = 6;
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            this.precio_unitario.Width = 125;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Sub Total";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 125;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEliminar.Width = 30;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(849, 410);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(188, 20);
            this.textBoxTotal.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(846, 394);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Total a Pagar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(846, 300);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Paga con:";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnRegistrarVenta.IconColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(849, 443);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(187, 72);
            this.btnRegistrarVenta.TabIndex = 37;
            this.btnRegistrarVenta.Text = "Crear Venta";
            this.btnRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Green;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(849, 169);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 65);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // comboBoxPagaCon
            // 
            this.comboBoxPagaCon.FormattingEnabled = true;
            this.comboBoxPagaCon.Location = new System.Drawing.Point(849, 315);
            this.comboBoxPagaCon.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPagaCon.Name = "comboBoxPagaCon";
            this.comboBoxPagaCon.Size = new System.Drawing.Size(188, 21);
            this.comboBoxPagaCon.TabIndex = 38;
            this.comboBoxPagaCon.SelectedIndexChanged += new System.EventHandler(this.comboBoxPagaCon_SelectedIndexChanged_1);
            // 
            // labelCuotas
            // 
            this.labelCuotas.AutoSize = true;
            this.labelCuotas.BackColor = System.Drawing.Color.White;
            this.labelCuotas.Location = new System.Drawing.Point(846, 347);
            this.labelCuotas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCuotas.Name = "labelCuotas";
            this.labelCuotas.Size = new System.Drawing.Size(43, 13);
            this.labelCuotas.TabIndex = 39;
            this.labelCuotas.Text = "Cuotas:";
            // 
            // comboBoxCuotas
            // 
            this.comboBoxCuotas.FormattingEnabled = true;
            this.comboBoxCuotas.Location = new System.Drawing.Point(849, 362);
            this.comboBoxCuotas.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCuotas.Name = "comboBoxCuotas";
            this.comboBoxCuotas.Size = new System.Drawing.Size(188, 21);
            this.comboBoxCuotas.TabIndex = 41;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1088, 544);
            this.Controls.Add(this.comboBoxCuotas);
            this.Controls.Add(this.labelCuotas);
            this.Controls.Add(this.comboBoxPagaCon);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.VentaProductosDGV);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelListaUsuarios);
            this.Name = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaProductosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListaUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxIDCliente;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCodigoP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxProducto;
        private System.Windows.Forms.ComboBox comboBoxTalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.DataGridView VentaProductosDGV;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnRegistrarVenta;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.TextBox textBoxVendedor;
        private System.Windows.Forms.TextBox textBoxIDProducto;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.TextBox textBoxDNICliente;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.ComboBox comboBoxPagaCon;
        private System.Windows.Forms.Label labelCuotas;
        private System.Windows.Forms.ComboBox comboBoxCuotas;
        private System.Windows.Forms.TextBox textBoxIDTalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_talle;
        private System.Windows.Forms.DataGridViewTextBoxColumn talla;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}