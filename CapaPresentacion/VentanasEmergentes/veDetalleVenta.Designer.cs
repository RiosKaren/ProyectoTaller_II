namespace CapaPresentacion
{
    partial class veDetalleVenta
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxVendedor = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VerProductosDGV = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.iconButtonPDF = new FontAwesome.Sharp.IconButton();
            this.textBoxNroFactura = new System.Windows.Forms.TextBox();
            this.iconButtonDevolucion = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerProductosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListaUsuarios
            // 
            this.labelListaUsuarios.BackColor = System.Drawing.Color.White;
            this.labelListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaUsuarios.Location = new System.Drawing.Point(11, 8);
            this.labelListaUsuarios.Name = "labelListaUsuarios";
            this.labelListaUsuarios.Size = new System.Drawing.Size(779, 545);
            this.labelListaUsuarios.TabIndex = 27;
            this.labelListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.White;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(46, 32);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(110, 25);
            this.labelTitulo.TabIndex = 28;
            this.labelTitulo.Text = "Factura Nº:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textBoxVendedor);
            this.groupBox1.Controls.Add(this.textBoxFecha);
            this.groupBox1.Controls.Add(this.labelVendedor);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Location = new System.Drawing.Point(51, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(610, 72);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // textBoxVendedor
            // 
            this.textBoxVendedor.Location = new System.Drawing.Point(355, 31);
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
            this.labelVendedor.Location = new System.Drawing.Point(354, 13);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxTelefono);
            this.groupBox2.Controls.Add(this.textBoxNombreCliente);
            this.groupBox2.Controls.Add(this.textBoxDNI);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxCorreo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(51, 170);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(610, 72);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Telefono:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(493, 34);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.ReadOnly = true;
            this.textBoxTelefono.Size = new System.Drawing.Size(105, 20);
            this.textBoxTelefono.TabIndex = 87;
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(149, 36);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.ReadOnly = true;
            this.textBoxNombreCliente.Size = new System.Drawing.Size(161, 20);
            this.textBoxNombreCliente.TabIndex = 89;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(21, 36);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.ReadOnly = true;
            this.textBoxDNI.Size = new System.Drawing.Size(112, 20);
            this.textBoxDNI.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nro. Documento:";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(327, 34);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.ReadOnly = true;
            this.textBoxCorreo.Size = new System.Drawing.Size(142, 20);
            this.textBoxCorreo.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Correo:";
            // 
            // VerProductosDGV
            // 
            this.VerProductosDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VerProductosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.VerProductosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerProductosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre,
            this.id_talle,
            this.talla,
            this.precio_unitario,
            this.cantidad,
            this.subtotal});
            this.VerProductosDGV.Location = new System.Drawing.Point(50, 254);
            this.VerProductosDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VerProductosDGV.MultiSelect = false;
            this.VerProductosDGV.Name = "VerProductosDGV";
            this.VerProductosDGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VerProductosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VerProductosDGV.RowHeadersWidth = 51;
            this.VerProductosDGV.RowTemplate.Height = 28;
            this.VerProductosDGV.Size = new System.Drawing.Size(723, 232);
            this.VerProductosDGV.TabIndex = 84;
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
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "Precio";
            this.precio_unitario.MinimumWidth = 6;
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            this.precio_unitario.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 125;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Sub Total";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 509);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Monto total:";
            // 
            // textBoxMontoTotal
            // 
            this.textBoxMontoTotal.Location = new System.Drawing.Point(110, 506);
            this.textBoxMontoTotal.Name = "textBoxMontoTotal";
            this.textBoxMontoTotal.ReadOnly = true;
            this.textBoxMontoTotal.Size = new System.Drawing.Size(87, 20);
            this.textBoxMontoTotal.TabIndex = 88;
            this.textBoxMontoTotal.Text = "0";
            // 
            // iconButtonPDF
            // 
            this.iconButtonPDF.BackColor = System.Drawing.Color.Green;
            this.iconButtonPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonPDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPDF.ForeColor = System.Drawing.Color.White;
            this.iconButtonPDF.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.iconButtonPDF.IconColor = System.Drawing.Color.White;
            this.iconButtonPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPDF.IconSize = 22;
            this.iconButtonPDF.Location = new System.Drawing.Point(664, 498);
            this.iconButtonPDF.Name = "iconButtonPDF";
            this.iconButtonPDF.Size = new System.Drawing.Size(108, 41);
            this.iconButtonPDF.TabIndex = 89;
            this.iconButtonPDF.Text = "Generar Comprobante";
            this.iconButtonPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPDF.UseVisualStyleBackColor = false;
            this.iconButtonPDF.Click += new System.EventHandler(this.iconButtonPDF_Click);
            // 
            // textBoxNroFactura
            // 
            this.textBoxNroFactura.Location = new System.Drawing.Point(152, 38);
            this.textBoxNroFactura.Name = "textBoxNroFactura";
            this.textBoxNroFactura.ReadOnly = true;
            this.textBoxNroFactura.Size = new System.Drawing.Size(112, 20);
            this.textBoxNroFactura.TabIndex = 90;
            // 
            // iconButtonDevolucion
            // 
            this.iconButtonDevolucion.BackColor = System.Drawing.Color.Crimson;
            this.iconButtonDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonDevolucion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDevolucion.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonDevolucion.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.iconButtonDevolucion.IconColor = System.Drawing.Color.White;
            this.iconButtonDevolucion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDevolucion.IconSize = 22;
            this.iconButtonDevolucion.Location = new System.Drawing.Point(550, 498);
            this.iconButtonDevolucion.Name = "iconButtonDevolucion";
            this.iconButtonDevolucion.Size = new System.Drawing.Size(108, 41);
            this.iconButtonDevolucion.TabIndex = 91;
            this.iconButtonDevolucion.Text = "Devolución";
            this.iconButtonDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonDevolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDevolucion.UseVisualStyleBackColor = false;
            this.iconButtonDevolucion.Click += new System.EventHandler(this.iconButtonDevolucion_Click);
            // 
            // veDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(799, 560);
            this.Controls.Add(this.iconButtonDevolucion);
            this.Controls.Add(this.textBoxNroFactura);
            this.Controls.Add(this.iconButtonPDF);
            this.Controls.Add(this.textBoxMontoTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VerProductosDGV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelListaUsuarios);
            this.Name = "veDetalleVenta";
            this.Text = "frmVerDetalle";
            this.Load += new System.EventHandler(this.frmVerDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerProductosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListaUsuarios;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxVendedor;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView VerProductosDGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMontoTotal;
        private FontAwesome.Sharp.IconButton iconButtonPDF;
        private System.Windows.Forms.TextBox textBoxNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_talle;
        private System.Windows.Forms.DataGridViewTextBoxColumn talla;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private FontAwesome.Sharp.IconButton iconButtonDevolucion;
    }
}