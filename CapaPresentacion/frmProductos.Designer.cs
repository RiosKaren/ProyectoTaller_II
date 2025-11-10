namespace CapaPresentacion
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.textBoxIndice = new System.Windows.Forms.TextBox();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelListaProductos = new System.Windows.Forms.Label();
            this.ProductosDGV = new System.Windows.Forms.DataGridView();
            this.botonSeleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen_url = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelTalles = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.TallesDGV = new System.Windows.Forms.DataGridView();
            this.TBFotoPath = new System.Windows.Forms.TextBox();
            this.btnBorrarTalle = new FontAwesome.Sharp.IconButton();
            this.btnAgregarTalle = new FontAwesome.Sharp.IconButton();
            this.PBFoto = new System.Windows.Forms.PictureBox();
            this.iconButtonHabilitar = new FontAwesome.Sharp.IconButton();
            this.iconButtonLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.btnDeshabilitar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnAgregarImagen = new FontAwesome.Sharp.IconButton();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.comboBoxTalles = new System.Windows.Forms.ComboBox();
            this.textBoxStock = new System.Windows.Forms.NumericUpDown();
            this.btnReporteStock = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TallesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxStock)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIndice
            // 
            this.textBoxIndice.Location = new System.Drawing.Point(162, 41);
            this.textBoxIndice.Name = "textBoxIndice";
            this.textBoxIndice.Size = new System.Drawing.Size(32, 20);
            this.textBoxIndice.TabIndex = 74;
            this.textBoxIndice.Visible = false;
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(896, 38);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(158, 20);
            this.textBoxBusqueda.TabIndex = 71;
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.BackColor = System.Drawing.Color.White;
            this.comboBoxBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(766, 38);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(125, 21);
            this.comboBoxBusqueda.TabIndex = 70;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.BackColor = System.Drawing.Color.White;
            this.labelBuscar.Location = new System.Drawing.Point(682, 41);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(62, 13);
            this.labelBuscar.TabIndex = 69;
            this.labelBuscar.Text = "Buscar Por:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(199, 41);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(32, 20);
            this.textBoxID.TabIndex = 55;
            this.textBoxID.Text = "0";
            this.textBoxID.Visible = false;
            // 
            // labelListaProductos
            // 
            this.labelListaProductos.BackColor = System.Drawing.Color.White;
            this.labelListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaProductos.Location = new System.Drawing.Point(292, 20);
            this.labelListaProductos.Name = "labelListaProductos";
            this.labelListaProductos.Size = new System.Drawing.Size(878, 50);
            this.labelListaProductos.TabIndex = 63;
            this.labelListaProductos.Text = "Lista de Productos:";
            this.labelListaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductosDGV
            // 
            this.ProductosDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.botonSeleccionar,
            this.id_producto,
            this.codigo,
            this.imagen_url,
            this.nombre,
            this.descripcion,
            this.talle,
            this.stock,
            this.precio,
            this.activo,
            this.estado});
            this.ProductosDGV.Location = new System.Drawing.Point(292, 92);
            this.ProductosDGV.Margin = new System.Windows.Forms.Padding(4);
            this.ProductosDGV.MultiSelect = false;
            this.ProductosDGV.Name = "ProductosDGV";
            this.ProductosDGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductosDGV.RowHeadersWidth = 51;
            this.ProductosDGV.RowTemplate.Height = 28;
            this.ProductosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductosDGV.Size = new System.Drawing.Size(878, 423);
            this.ProductosDGV.TabIndex = 62;
            this.ProductosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductosDGV_CellClick);
            this.ProductosDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductosDGV_CellFormatting);
            this.ProductosDGV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ProductosDGV_CellPainting);
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.HeaderText = "";
            this.botonSeleccionar.MinimumWidth = 6;
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.ReadOnly = true;
            this.botonSeleccionar.Width = 30;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID";
            this.id_producto.MinimumWidth = 6;
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Visible = false;
            this.id_producto.Width = 125;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // imagen_url
            // 
            this.imagen_url.FillWeight = 400F;
            this.imagen_url.HeaderText = "Imagen";
            this.imagen_url.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imagen_url.MinimumWidth = 6;
            this.imagen_url.Name = "imagen_url";
            this.imagen_url.ReadOnly = true;
            this.imagen_url.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.imagen_url.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 170;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 125;
            // 
            // talle
            // 
            this.talle.HeaderText = "Talles";
            this.talle.MinimumWidth = 6;
            this.talle.Name = "talle";
            this.talle.ReadOnly = true;
            this.talle.Width = 140;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock total";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 125;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 125;
            // 
            // activo
            // 
            this.activo.HeaderText = "activo";
            this.activo.MinimumWidth = 6;
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Visible = false;
            this.activo.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 125;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.White;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(10, 3);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(229, 31);
            this.labelTitulo.TabIndex = 60;
            this.labelTitulo.Text = "Detalles Producto";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.Color.White;
            this.labelStock.Location = new System.Drawing.Point(90, 210);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(38, 13);
            this.labelStock.TabIndex = 54;
            this.labelStock.Text = "Stock:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.BackColor = System.Drawing.Color.White;
            this.labelDescripcion.Location = new System.Drawing.Point(16, 130);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 47;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(18, 104);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(216, 20);
            this.textBoxNombre.TabIndex = 43;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(18, 60);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 42;
            // 
            // labelTalles
            // 
            this.labelTalles.AutoSize = true;
            this.labelTalles.BackColor = System.Drawing.Color.White;
            this.labelTalles.Location = new System.Drawing.Point(16, 210);
            this.labelTalles.Name = "labelTalles";
            this.labelTalles.Size = new System.Drawing.Size(38, 13);
            this.labelTalles.TabIndex = 40;
            this.labelTalles.Text = "Talles:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(16, 86);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 39;
            this.labelNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Código: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 566);
            this.label1.TabIndex = 38;
            // 
            // TextBoxDescripcion
            // 
            this.TextBoxDescripcion.Location = new System.Drawing.Point(19, 146);
            this.TextBoxDescripcion.Name = "TextBoxDescripcion";
            this.TextBoxDescripcion.Size = new System.Drawing.Size(215, 28);
            this.TextBoxDescripcion.TabIndex = 76;
            this.TextBoxDescripcion.Text = "";
            // 
            // TallesDGV
            // 
            this.TallesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TallesDGV.Location = new System.Drawing.Point(19, 253);
            this.TallesDGV.Name = "TallesDGV";
            this.TallesDGV.RowHeadersWidth = 51;
            this.TallesDGV.Size = new System.Drawing.Size(214, 110);
            this.TallesDGV.TabIndex = 80;
            this.TallesDGV.SelectionChanged += new System.EventHandler(this.TallesDGV_SelectionChanged);
            // 
            // TBFotoPath
            // 
            this.TBFotoPath.Location = new System.Drawing.Point(19, 418);
            this.TBFotoPath.Name = "TBFotoPath";
            this.TBFotoPath.ReadOnly = true;
            this.TBFotoPath.Size = new System.Drawing.Size(145, 20);
            this.TBFotoPath.TabIndex = 83;
            // 
            // btnBorrarTalle
            // 
            this.btnBorrarTalle.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrarTalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarTalle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTalle.ForeColor = System.Drawing.Color.White;
            this.btnBorrarTalle.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnBorrarTalle.IconColor = System.Drawing.Color.White;
            this.btnBorrarTalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrarTalle.IconSize = 16;
            this.btnBorrarTalle.Location = new System.Drawing.Point(212, 226);
            this.btnBorrarTalle.Name = "btnBorrarTalle";
            this.btnBorrarTalle.Size = new System.Drawing.Size(20, 20);
            this.btnBorrarTalle.TabIndex = 81;
            this.btnBorrarTalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrarTalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarTalle.UseVisualStyleBackColor = false;
            this.btnBorrarTalle.Click += new System.EventHandler(this.btnBorrarTalle_Click);
            // 
            // btnAgregarTalle
            // 
            this.btnAgregarTalle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarTalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTalle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTalle.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTalle.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregarTalle.IconColor = System.Drawing.Color.White;
            this.btnAgregarTalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarTalle.IconSize = 16;
            this.btnAgregarTalle.Location = new System.Drawing.Point(186, 225);
            this.btnAgregarTalle.Name = "btnAgregarTalle";
            this.btnAgregarTalle.Size = new System.Drawing.Size(20, 20);
            this.btnAgregarTalle.TabIndex = 79;
            this.btnAgregarTalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarTalle.UseVisualStyleBackColor = false;
            this.btnAgregarTalle.Click += new System.EventHandler(this.btnAgregarTalle_Click);
            // 
            // PBFoto
            // 
            this.PBFoto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PBFoto.Image = global::CapaPresentacion.Properties.Resources.c865;
            this.PBFoto.Location = new System.Drawing.Point(169, 367);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(65, 69);
            this.PBFoto.TabIndex = 77;
            this.PBFoto.TabStop = false;
            // 
            // iconButtonHabilitar
            // 
            this.iconButtonHabilitar.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonHabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonHabilitar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHabilitar.ForeColor = System.Drawing.Color.White;
            this.iconButtonHabilitar.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.iconButtonHabilitar.IconColor = System.Drawing.Color.White;
            this.iconButtonHabilitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHabilitar.IconSize = 16;
            this.iconButtonHabilitar.Location = new System.Drawing.Point(19, 532);
            this.iconButtonHabilitar.Name = "iconButtonHabilitar";
            this.iconButtonHabilitar.Size = new System.Drawing.Size(212, 23);
            this.iconButtonHabilitar.TabIndex = 75;
            this.iconButtonHabilitar.Text = "Habilitar Producto";
            this.iconButtonHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonHabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHabilitar.UseVisualStyleBackColor = false;
            this.iconButtonHabilitar.Click += new System.EventHandler(this.iconButtonHabilitar_Click);
            // 
            // iconButtonLimpiar
            // 
            this.iconButtonLimpiar.BackColor = System.Drawing.Color.White;
            this.iconButtonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLimpiar.ForeColor = System.Drawing.Color.White;
            this.iconButtonLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButtonLimpiar.IconColor = System.Drawing.Color.Black;
            this.iconButtonLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLimpiar.IconSize = 18;
            this.iconButtonLimpiar.Location = new System.Drawing.Point(1100, 38);
            this.iconButtonLimpiar.Name = "iconButtonLimpiar";
            this.iconButtonLimpiar.Size = new System.Drawing.Size(34, 18);
            this.iconButtonLimpiar.TabIndex = 72;
            this.iconButtonLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonLimpiar.UseVisualStyleBackColor = false;
            this.iconButtonLimpiar.Click += new System.EventHandler(this.iconButtonLimpiar_Click);
            // 
            // iconButtonBuscar
            // 
            this.iconButtonBuscar.BackColor = System.Drawing.Color.White;
            this.iconButtonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBuscar.ForeColor = System.Drawing.Color.White;
            this.iconButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButtonBuscar.IconColor = System.Drawing.Color.Black;
            this.iconButtonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBuscar.IconSize = 16;
            this.iconButtonBuscar.Location = new System.Drawing.Point(1060, 38);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.Size = new System.Drawing.Size(34, 18);
            this.iconButtonBuscar.TabIndex = 73;
            this.iconButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            this.iconButtonBuscar.Click += new System.EventHandler(this.iconButtonBuscar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeshabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshabilitar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitar.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnDeshabilitar.IconColor = System.Drawing.Color.White;
            this.btnDeshabilitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeshabilitar.IconSize = 16;
            this.btnDeshabilitar.Location = new System.Drawing.Point(19, 503);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(212, 23);
            this.btnDeshabilitar.TabIndex = 57;
            this.btnDeshabilitar.Text = "Deshabilitar Producto";
            this.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeshabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 16;
            this.btnEditar.Location = new System.Drawing.Point(19, 474);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(212, 23);
            this.btnEditar.TabIndex = 56;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Location = new System.Drawing.Point(19, 445);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(212, 23);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImagen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.White;
            this.btnAgregarImagen.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgregarImagen.IconColor = System.Drawing.Color.White;
            this.btnAgregarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarImagen.IconSize = 16;
            this.btnAgregarImagen.Location = new System.Drawing.Point(19, 376);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(144, 36);
            this.btnAgregarImagen.TabIndex = 84;
            this.btnAgregarImagen.Text = "Seleccionar Imagen";
            this.btnAgregarImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(16, 184);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 13);
            this.labelPrecio.TabIndex = 85;
            this.labelPrecio.Text = "Precio:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(82, 182);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(64, 20);
            this.textBoxPrecio.TabIndex = 86;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.BackColor = System.Drawing.Color.White;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(68, 183);
            this.labelPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(14, 15);
            this.labelPeso.TabIndex = 87;
            this.labelPeso.Text = "$";
            // 
            // comboBoxTalles
            // 
            this.comboBoxTalles.BackColor = System.Drawing.Color.White;
            this.comboBoxTalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTalles.FormattingEnabled = true;
            this.comboBoxTalles.Location = new System.Drawing.Point(19, 227);
            this.comboBoxTalles.Name = "comboBoxTalles";
            this.comboBoxTalles.Size = new System.Drawing.Size(62, 21);
            this.comboBoxTalles.TabIndex = 88;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxStock.Location = new System.Drawing.Point(92, 228);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(87, 20);
            this.textBoxStock.TabIndex = 89;
            this.textBoxStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnReporteStock
            // 
            this.btnReporteStock.BackColor = System.Drawing.Color.SlateGray;
            this.btnReporteStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteStock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReporteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteStock.ForeColor = System.Drawing.Color.White;
            this.btnReporteStock.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnReporteStock.IconColor = System.Drawing.Color.White;
            this.btnReporteStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporteStock.IconSize = 16;
            this.btnReporteStock.Location = new System.Drawing.Point(958, 532);
            this.btnReporteStock.Name = "btnReporteStock";
            this.btnReporteStock.Size = new System.Drawing.Size(212, 23);
            this.btnReporteStock.TabIndex = 90;
            this.btnReporteStock.Text = "Generar reporte Stock";
            this.btnReporteStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteStock.UseVisualStyleBackColor = false;
            this.btnReporteStock.Click += new System.EventHandler(this.btnReporteStock_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1189, 566);
            this.Controls.Add(this.btnReporteStock);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.comboBoxTalles);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.TBFotoPath);
            this.Controls.Add(this.btnBorrarTalle);
            this.Controls.Add(this.TallesDGV);
            this.Controls.Add(this.btnAgregarTalle);
            this.Controls.Add(this.PBFoto);
            this.Controls.Add(this.TextBoxDescripcion);
            this.Controls.Add(this.iconButtonHabilitar);
            this.Controls.Add(this.textBoxIndice);
            this.Controls.Add(this.iconButtonLimpiar);
            this.Controls.Add(this.iconButtonBuscar);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.comboBoxBusqueda);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelListaProductos);
            this.Controls.Add(this.ProductosDGV);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelTalles);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TallesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonHabilitar;
        private System.Windows.Forms.TextBox textBoxIndice;
        private FontAwesome.Sharp.IconButton iconButtonLimpiar;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelListaProductos;
        private System.Windows.Forms.DataGridView ProductosDGV;
        private System.Windows.Forms.Label labelTitulo;
        private FontAwesome.Sharp.IconButton btnDeshabilitar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelTalles;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TextBoxDescripcion;
        private System.Windows.Forms.PictureBox PBFoto;
        private FontAwesome.Sharp.IconButton btnAgregarTalle;
        private System.Windows.Forms.DataGridView TallesDGV;
        private FontAwesome.Sharp.IconButton btnBorrarTalle;
        private System.Windows.Forms.TextBox TBFotoPath;
        private FontAwesome.Sharp.IconButton btnAgregarImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn botonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewImageColumn imagen_url;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn talle;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.ComboBox comboBoxTalles;
        private System.Windows.Forms.NumericUpDown textBoxStock;
        private FontAwesome.Sharp.IconButton btnReporteStock;
    }
}