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
            this.LVentas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBVendedorApellido = new System.Windows.Forms.TextBox();
            this.TBVendedorNombre = new System.Windows.Forms.TextBox();
            this.LVendedor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBClienteApellido = new System.Windows.Forms.TextBox();
            this.TBClienteNombre = new System.Windows.Forms.TextBox();
            this.LCliente = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LPrecioDeVenta = new System.Windows.Forms.Label();
            this.LStock = new System.Windows.Forms.Label();
            this.LTalle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LProducto = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DTPFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.CBTipoFactura = new System.Windows.Forms.ComboBox();
            this.LTipoFactura = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LVentas
            // 
            this.LVentas.AutoSize = true;
            this.LVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVentas.Location = new System.Drawing.Point(479, 9);
            this.LVentas.Name = "LVentas";
            this.LVentas.Size = new System.Drawing.Size(99, 31);
            this.LVentas.TabIndex = 1;
            this.LVentas.Text = "Ventas";
            this.LVentas.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.TBVendedorApellido);
            this.panel1.Controls.Add(this.TBVendedorNombre);
            this.panel1.Controls.Add(this.LVendedor);
            this.panel1.Location = new System.Drawing.Point(18, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 104);
            this.panel1.TabIndex = 2;
            // 
            // TBVendedorApellido
            // 
            this.TBVendedorApellido.Location = new System.Drawing.Point(277, 64);
            this.TBVendedorApellido.Name = "TBVendedorApellido";
            this.TBVendedorApellido.Size = new System.Drawing.Size(224, 20);
            this.TBVendedorApellido.TabIndex = 6;
            // 
            // TBVendedorNombre
            // 
            this.TBVendedorNombre.Location = new System.Drawing.Point(18, 64);
            this.TBVendedorNombre.Name = "TBVendedorNombre";
            this.TBVendedorNombre.Size = new System.Drawing.Size(231, 20);
            this.TBVendedorNombre.TabIndex = 6;
            // 
            // LVendedor
            // 
            this.LVendedor.AutoSize = true;
            this.LVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVendedor.ForeColor = System.Drawing.Color.White;
            this.LVendedor.Location = new System.Drawing.Point(15, 23);
            this.LVendedor.Name = "LVendedor";
            this.LVendedor.Size = new System.Drawing.Size(61, 13);
            this.LVendedor.TabIndex = 4;
            this.LVendedor.Text = "Vendedor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.TBClienteApellido);
            this.panel2.Controls.Add(this.TBClienteNombre);
            this.panel2.Controls.Add(this.LCliente);
            this.panel2.Location = new System.Drawing.Point(562, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 104);
            this.panel2.TabIndex = 3;
            // 
            // TBClienteApellido
            // 
            this.TBClienteApellido.Location = new System.Drawing.Point(310, 64);
            this.TBClienteApellido.Name = "TBClienteApellido";
            this.TBClienteApellido.Size = new System.Drawing.Size(157, 20);
            this.TBClienteApellido.TabIndex = 7;
            // 
            // TBClienteNombre
            // 
            this.TBClienteNombre.Location = new System.Drawing.Point(18, 64);
            this.TBClienteNombre.Name = "TBClienteNombre";
            this.TBClienteNombre.Size = new System.Drawing.Size(244, 20);
            this.TBClienteNombre.TabIndex = 7;
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCliente.ForeColor = System.Drawing.Color.White;
            this.LCliente.Location = new System.Drawing.Point(27, 23);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(46, 13);
            this.LCliente.TabIndex = 5;
            this.LCliente.Text = "Cliente";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.LCantidad);
            this.panel3.Controls.Add(this.LPrecioDeVenta);
            this.panel3.Controls.Add(this.LStock);
            this.panel3.Controls.Add(this.LTalle);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.LProducto);
            this.panel3.Location = new System.Drawing.Point(18, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 104);
            this.panel3.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(317, 68);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(115, 20);
            this.textBox5.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(519, 68);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(98, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(683, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(98, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(570, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.ForeColor = System.Drawing.Color.White;
            this.LCantidad.Location = new System.Drawing.Point(464, 71);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(57, 13);
            this.LCantidad.TabIndex = 10;
            this.LCantidad.Text = "Cantidad";
            // 
            // LPrecioDeVenta
            // 
            this.LPrecioDeVenta.AutoSize = true;
            this.LPrecioDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioDeVenta.ForeColor = System.Drawing.Color.White;
            this.LPrecioDeVenta.Location = new System.Drawing.Point(220, 71);
            this.LPrecioDeVenta.Name = "LPrecioDeVenta";
            this.LPrecioDeVenta.Size = new System.Drawing.Size(100, 13);
            this.LPrecioDeVenta.TabIndex = 9;
            this.LPrecioDeVenta.Text = "Precio De Venta";
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.ForeColor = System.Drawing.Color.White;
            this.LStock.Location = new System.Drawing.Point(15, 71);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(40, 13);
            this.LStock.TabIndex = 8;
            this.LStock.Text = "Stock";
            // 
            // LTalle
            // 
            this.LTalle.AutoSize = true;
            this.LTalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTalle.ForeColor = System.Drawing.Color.White;
            this.LTalle.Location = new System.Drawing.Point(647, 16);
            this.LTalle.Name = "LTalle";
            this.LTalle.Size = new System.Drawing.Size(35, 13);
            this.LTalle.TabIndex = 7;
            this.LTalle.Text = "Talle";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 6;
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProducto.ForeColor = System.Drawing.Color.White;
            this.LProducto.Location = new System.Drawing.Point(15, 16);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(58, 13);
            this.LProducto.TabIndex = 4;
            this.LProducto.Text = "Producto";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkRed;
            this.panel4.Controls.Add(this.DTPFechaVenta);
            this.panel4.Controls.Add(this.CBTipoFactura);
            this.panel4.Controls.Add(this.LTipoFactura);
            this.panel4.Controls.Add(this.LFecha);
            this.panel4.Location = new System.Drawing.Point(872, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 104);
            this.panel4.TabIndex = 7;
            // 
            // DTPFechaVenta
            // 
            this.DTPFechaVenta.Location = new System.Drawing.Point(6, 24);
            this.DTPFechaVenta.Name = "DTPFechaVenta";
            this.DTPFechaVenta.Size = new System.Drawing.Size(179, 20);
            this.DTPFechaVenta.TabIndex = 8;
            // 
            // CBTipoFactura
            // 
            this.CBTipoFactura.FormattingEnabled = true;
            this.CBTipoFactura.Location = new System.Drawing.Point(6, 71);
            this.CBTipoFactura.Name = "CBTipoFactura";
            this.CBTipoFactura.Size = new System.Drawing.Size(151, 21);
            this.CBTipoFactura.TabIndex = 13;
            // 
            // LTipoFactura
            // 
            this.LTipoFactura.AutoSize = true;
            this.LTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoFactura.ForeColor = System.Drawing.Color.White;
            this.LTipoFactura.Location = new System.Drawing.Point(3, 55);
            this.LTipoFactura.Name = "LTipoFactura";
            this.LTipoFactura.Size = new System.Drawing.Size(97, 13);
            this.LTipoFactura.TabIndex = 7;
            this.LTipoFactura.Text = "Tipo de Factura";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.Color.White;
            this.LFecha.Location = new System.Drawing.Point(3, 8);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(42, 13);
            this.LFecha.TabIndex = 4;
            this.LFecha.Text = "Fecha";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkRed;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.btnGuardar);
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Location = new System.Drawing.Point(18, 284);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1054, 265);
            this.panel5.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(887, 209);
            this.dataGridView1.TabIndex = 47;
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
            this.btnGuardar.Location = new System.Drawing.Point(911, 29);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 23);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 16;
            this.btnEliminar.Location = new System.Drawing.Point(911, 58);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 23);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LVentas);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBVendedorNombre;
        private System.Windows.Forms.Label LVendedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LTalle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LTipoFactura;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label LPrecioDeVenta;
        private System.Windows.Forms.Label LStock;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox TBVendedorApellido;
        private System.Windows.Forms.TextBox TBClienteApellido;
        private System.Windows.Forms.TextBox TBClienteNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DTPFechaVenta;
        private System.Windows.Forms.ComboBox CBTipoFactura;
    }
}