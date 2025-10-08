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
            this.iconButtonHabilitar = new FontAwesome.Sharp.IconButton();
            this.textBoxIndice = new System.Windows.Forms.TextBox();
            this.iconButtonLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelListaProductos = new System.Windows.Forms.Label();
            this.ProductosDGV = new System.Windows.Forms.DataGridView();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelImagen = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelTalles = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxTalles = new System.Windows.Forms.ComboBox();
            this.btnAgregarTalle = new FontAwesome.Sharp.IconButton();
            this.dgvTalles = new System.Windows.Forms.DataGridView();
            this.btnBorrarTalle = new FontAwesome.Sharp.IconButton();
            this.botonSeleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalles)).BeginInit();
            this.SuspendLayout();
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
            this.iconButtonHabilitar.Location = new System.Drawing.Point(20, 655);
            this.iconButtonHabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonHabilitar.Name = "iconButtonHabilitar";
            this.iconButtonHabilitar.Size = new System.Drawing.Size(287, 28);
            this.iconButtonHabilitar.TabIndex = 75;
            this.iconButtonHabilitar.Text = "Habilitar Producto";
            this.iconButtonHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonHabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHabilitar.UseVisualStyleBackColor = false;
            // 
            // textBoxIndice
            // 
            this.textBoxIndice.Location = new System.Drawing.Point(216, 50);
            this.textBoxIndice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIndice.Name = "textBoxIndice";
            this.textBoxIndice.Size = new System.Drawing.Size(41, 22);
            this.textBoxIndice.TabIndex = 74;
            this.textBoxIndice.Visible = false;
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
            this.iconButtonLimpiar.Location = new System.Drawing.Point(1467, 47);
            this.iconButtonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonLimpiar.Name = "iconButtonLimpiar";
            this.iconButtonLimpiar.Size = new System.Drawing.Size(45, 22);
            this.iconButtonLimpiar.TabIndex = 72;
            this.iconButtonLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonLimpiar.UseVisualStyleBackColor = false;
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
            this.iconButtonBuscar.Location = new System.Drawing.Point(1413, 47);
            this.iconButtonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.Size = new System.Drawing.Size(45, 22);
            this.iconButtonBuscar.TabIndex = 73;
            this.iconButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(1195, 47);
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(209, 22);
            this.textBoxBusqueda.TabIndex = 71;
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.BackColor = System.Drawing.Color.White;
            this.comboBoxBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(1021, 47);
            this.comboBoxBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(165, 24);
            this.comboBoxBusqueda.TabIndex = 70;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.BackColor = System.Drawing.Color.White;
            this.labelBuscar.Location = new System.Drawing.Point(909, 50);
            this.labelBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(76, 16);
            this.labelBuscar.TabIndex = 69;
            this.labelBuscar.Text = "Buscar Por:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(265, 50);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(41, 22);
            this.textBoxID.TabIndex = 55;
            this.textBoxID.Text = "0";
            this.textBoxID.Visible = false;
            // 
            // labelListaProductos
            // 
            this.labelListaProductos.BackColor = System.Drawing.Color.White;
            this.labelListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaProductos.Location = new System.Drawing.Point(389, 25);
            this.labelListaProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListaProductos.Name = "labelListaProductos";
            this.labelListaProductos.Size = new System.Drawing.Size(1171, 62);
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
            this.image_url,
            this.nombre,
            this.descripcion,
            this.talle,
            this.stock,
            this.precio,
            this.activo,
            this.estado});
            this.ProductosDGV.Location = new System.Drawing.Point(389, 113);
            this.ProductosDGV.Margin = new System.Windows.Forms.Padding(5);
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
            this.ProductosDGV.Size = new System.Drawing.Size(1171, 534);
            this.ProductosDGV.TabIndex = 62;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.White;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(13, 4);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(286, 39);
            this.labelTitulo.TabIndex = 60;
            this.labelTitulo.Text = "Detalles Producto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 16;
            this.btnEliminar.Location = new System.Drawing.Point(21, 619);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(287, 28);
            this.btnEliminar.TabIndex = 57;
            this.btnEliminar.Text = "Deshabilitar Producto";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            this.btnEditar.Location = new System.Drawing.Point(21, 583);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(287, 28);
            this.btnEditar.TabIndex = 56;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.btnGuardar.Location = new System.Drawing.Point(21, 548);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(287, 28);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(154, 278);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(84, 22);
            this.textBoxStock.TabIndex = 50;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.Color.White;
            this.labelStock.Location = new System.Drawing.Point(150, 258);
            this.labelStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(44, 16);
            this.labelStock.TabIndex = 54;
            this.labelStock.Text = "Stock:";
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.BackColor = System.Drawing.Color.White;
            this.labelImagen.Location = new System.Drawing.Point(21, 450);
            this.labelImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(134, 16);
            this.labelImagen.TabIndex = 51;
            this.labelImagen.Text = "Imagen del Producto:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.BackColor = System.Drawing.Color.White;
            this.labelDescripcion.Location = new System.Drawing.Point(21, 160);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(82, 16);
            this.labelDescripcion.TabIndex = 47;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(24, 128);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(283, 22);
            this.textBoxNombre.TabIndex = 43;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(24, 74);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(132, 22);
            this.textBoxCodigo.TabIndex = 42;
            // 
            // labelTalles
            // 
            this.labelTalles.AutoSize = true;
            this.labelTalles.BackColor = System.Drawing.Color.White;
            this.labelTalles.Location = new System.Drawing.Point(21, 258);
            this.labelTalles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTalles.Name = "labelTalles";
            this.labelTalles.Size = new System.Drawing.Size(48, 16);
            this.labelTalles.TabIndex = 40;
            this.labelTalles.Text = "Talles:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(21, 106);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(59, 16);
            this.labelNombre.TabIndex = 39;
            this.labelNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Código: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 697);
            this.label1.TabIndex = 38;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 180);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(283, 74);
            this.richTextBox1.TabIndex = 76;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(25, 473);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 68);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxTalles
            // 
            this.comboBoxTalles.FormattingEnabled = true;
            this.comboBoxTalles.Location = new System.Drawing.Point(25, 278);
            this.comboBoxTalles.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTalles.Name = "comboBoxTalles";
            this.comboBoxTalles.Size = new System.Drawing.Size(115, 24);
            this.comboBoxTalles.TabIndex = 78;
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
            this.btnAgregarTalle.Location = new System.Drawing.Point(246, 278);
            this.btnAgregarTalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTalle.Name = "btnAgregarTalle";
            this.btnAgregarTalle.Size = new System.Drawing.Size(27, 25);
            this.btnAgregarTalle.TabIndex = 79;
            this.btnAgregarTalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarTalle.UseVisualStyleBackColor = false;
            this.btnAgregarTalle.Click += new System.EventHandler(this.btnAgregarTalle_Click);
            // 
            // dgvTalles
            // 
            this.dgvTalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTalles.Location = new System.Drawing.Point(27, 311);
            this.dgvTalles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTalles.Name = "dgvTalles";
            this.dgvTalles.RowHeadersWidth = 51;
            this.dgvTalles.Size = new System.Drawing.Size(283, 135);
            this.dgvTalles.TabIndex = 80;
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
            this.btnBorrarTalle.Location = new System.Drawing.Point(283, 278);
            this.btnBorrarTalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarTalle.Name = "btnBorrarTalle";
            this.btnBorrarTalle.Size = new System.Drawing.Size(27, 25);
            this.btnBorrarTalle.TabIndex = 81;
            this.btnBorrarTalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrarTalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarTalle.UseVisualStyleBackColor = false;
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
            // image_url
            // 
            this.image_url.HeaderText = "Imagen";
            this.image_url.MinimumWidth = 6;
            this.image_url.Name = "image_url";
            this.image_url.ReadOnly = true;
            this.image_url.Width = 125;
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
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1585, 697);
            this.Controls.Add(this.btnBorrarTalle);
            this.Controls.Add(this.dgvTalles);
            this.Controls.Add(this.btnAgregarTalle);
            this.Controls.Add(this.comboBoxTalles);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
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
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelTalles);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalles)).EndInit();
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
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelTalles;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxTalles;
        private FontAwesome.Sharp.IconButton btnAgregarTalle;
        private System.Windows.Forms.DataGridView dgvTalles;
        private FontAwesome.Sharp.IconButton btnBorrarTalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn botonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn image_url;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn talle;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}