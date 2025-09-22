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
            this.LVentas.Location = new System.Drawing.Point(727, 23);
            this.LVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LVentas.Name = "LVentas";
            this.LVentas.Size = new System.Drawing.Size(123, 39);
            this.LVentas.TabIndex = 1;
            this.LVentas.Text = "Ventas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.TBVendedorApellido);
            this.panel1.Controls.Add(this.TBVendedorNombre);
            this.panel1.Controls.Add(this.LVendedor);
            this.panel1.Location = new System.Drawing.Point(24, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 128);
            this.panel1.TabIndex = 2;
            // 
            // TBVendedorApellido
            // 
            this.TBVendedorApellido.Location = new System.Drawing.Point(369, 79);
            this.TBVendedorApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBVendedorApellido.Name = "TBVendedorApellido";
            this.TBVendedorApellido.Size = new System.Drawing.Size(297, 22);
            this.TBVendedorApellido.TabIndex = 6;
            // 
            // TBVendedorNombre
            // 
            this.TBVendedorNombre.Location = new System.Drawing.Point(24, 79);
            this.TBVendedorNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBVendedorNombre.Name = "TBVendedorNombre";
            this.TBVendedorNombre.Size = new System.Drawing.Size(307, 22);
            this.TBVendedorNombre.TabIndex = 6;
            // 
            // LVendedor
            // 
            this.LVendedor.AutoSize = true;
            this.LVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVendedor.ForeColor = System.Drawing.Color.White;
            this.LVendedor.Location = new System.Drawing.Point(20, 28);
            this.LVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LVendedor.Name = "LVendedor";
            this.LVendedor.Size = new System.Drawing.Size(78, 17);
            this.LVendedor.TabIndex = 4;
            this.LVendedor.Text = "Vendedor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.TBClienteApellido);
            this.panel2.Controls.Add(this.TBClienteNombre);
            this.panel2.Controls.Add(this.LCliente);
            this.panel2.Location = new System.Drawing.Point(806, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 128);
            this.panel2.TabIndex = 3;
            // 
            // TBClienteApellido
            // 
            this.TBClienteApellido.Location = new System.Drawing.Point(413, 79);
            this.TBClienteApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBClienteApellido.Name = "TBClienteApellido";
            this.TBClienteApellido.Size = new System.Drawing.Size(208, 22);
            this.TBClienteApellido.TabIndex = 7;
            // 
            // TBClienteNombre
            // 
            this.TBClienteNombre.Location = new System.Drawing.Point(24, 79);
            this.TBClienteNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBClienteNombre.Name = "TBClienteNombre";
            this.TBClienteNombre.Size = new System.Drawing.Size(324, 22);
            this.TBClienteNombre.TabIndex = 7;
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCliente.ForeColor = System.Drawing.Color.White;
            this.LCliente.Location = new System.Drawing.Point(36, 28);
            this.LCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(58, 17);
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
            this.panel3.Location = new System.Drawing.Point(24, 214);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1130, 128);
            this.panel3.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(423, 84);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(152, 22);
            this.textBox5.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(692, 84);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(129, 24);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(911, 16);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(129, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(759, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.ForeColor = System.Drawing.Color.White;
            this.LCantidad.Location = new System.Drawing.Point(619, 87);
            this.LCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(72, 17);
            this.LCantidad.TabIndex = 10;
            this.LCantidad.Text = "Cantidad";
            // 
            // LPrecioDeVenta
            // 
            this.LPrecioDeVenta.AutoSize = true;
            this.LPrecioDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioDeVenta.ForeColor = System.Drawing.Color.White;
            this.LPrecioDeVenta.Location = new System.Drawing.Point(293, 87);
            this.LPrecioDeVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPrecioDeVenta.Name = "LPrecioDeVenta";
            this.LPrecioDeVenta.Size = new System.Drawing.Size(126, 17);
            this.LPrecioDeVenta.TabIndex = 9;
            this.LPrecioDeVenta.Text = "Precio De Venta";
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStock.ForeColor = System.Drawing.Color.White;
            this.LStock.Location = new System.Drawing.Point(20, 87);
            this.LStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(48, 17);
            this.LStock.TabIndex = 8;
            this.LStock.Text = "Stock";
            // 
            // LTalle
            // 
            this.LTalle.AutoSize = true;
            this.LTalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTalle.ForeColor = System.Drawing.Color.White;
            this.LTalle.Location = new System.Drawing.Point(863, 20);
            this.LTalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTalle.Name = "LTalle";
            this.LTalle.Size = new System.Drawing.Size(44, 17);
            this.LTalle.TabIndex = 7;
            this.LTalle.Text = "Talle";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 6;
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProducto.ForeColor = System.Drawing.Color.White;
            this.LProducto.Location = new System.Drawing.Point(20, 20);
            this.LProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(73, 17);
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
            this.panel4.Location = new System.Drawing.Point(1184, 214);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 128);
            this.panel4.TabIndex = 7;
            // 
            // DTPFechaVenta
            // 
            this.DTPFechaVenta.Location = new System.Drawing.Point(8, 30);
            this.DTPFechaVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPFechaVenta.Name = "DTPFechaVenta";
            this.DTPFechaVenta.Size = new System.Drawing.Size(237, 22);
            this.DTPFechaVenta.TabIndex = 8;
            // 
            // CBTipoFactura
            // 
            this.CBTipoFactura.FormattingEnabled = true;
            this.CBTipoFactura.Location = new System.Drawing.Point(8, 87);
            this.CBTipoFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBTipoFactura.Name = "CBTipoFactura";
            this.CBTipoFactura.Size = new System.Drawing.Size(200, 24);
            this.CBTipoFactura.TabIndex = 13;
            // 
            // LTipoFactura
            // 
            this.LTipoFactura.AutoSize = true;
            this.LTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoFactura.ForeColor = System.Drawing.Color.White;
            this.LTipoFactura.Location = new System.Drawing.Point(4, 68);
            this.LTipoFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTipoFactura.Name = "LTipoFactura";
            this.LTipoFactura.Size = new System.Drawing.Size(123, 17);
            this.LTipoFactura.TabIndex = 7;
            this.LTipoFactura.Text = "Tipo de Factura";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.Color.White;
            this.LFecha.Location = new System.Drawing.Point(4, 10);
            this.LFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(52, 17);
            this.LFecha.TabIndex = 4;
            this.LFecha.Text = "Fecha";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkRed;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.btnGuardar);
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Location = new System.Drawing.Point(24, 350);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1531, 306);
            this.panel5.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 257);
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
            this.btnGuardar.Location = new System.Drawing.Point(1215, 18);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(187, 28);
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
            this.btnEliminar.Location = new System.Drawing.Point(1215, 54);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(187, 28);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 669);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LVentas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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