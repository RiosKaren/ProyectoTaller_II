namespace CapaPresentacion
{
    partial class LCategoria
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBTalle = new System.Windows.Forms.TextBox();
            this.LTalle = new System.Windows.Forms.Label();
            this.LDetallesProductos = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.BImagen = new System.Windows.Forms.Button();
            this.LNombre = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.LPrecio = new System.Windows.Forms.Label();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.btnHabilitar = new FontAwesome.Sharp.IconButton();
            this.btnDeshabilitar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(503, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 256);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DGVProductos
            // 
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Location = new System.Drawing.Point(33, 50);
            this.DGVProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.RowHeadersWidth = 51;
            this.DGVProductos.Size = new System.Drawing.Size(1523, 253);
            this.DGVProductos.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.DGVProductos);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Location = new System.Drawing.Point(-8, 336);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1594, 340);
            this.panel1.TabIndex = 20;
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
            this.btnEditar.Location = new System.Drawing.Point(1321, 14);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(235, 28);
            this.btnEditar.TabIndex = 21;
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
            this.btnGuardar.Location = new System.Drawing.Point(982, 36);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(287, 28);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.btnHabilitar);
            this.panel2.Controls.Add(this.btnDeshabilitar);
            this.panel2.Controls.Add(this.TBTalle);
            this.panel2.Controls.Add(this.LTalle);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.LDetallesProductos);
            this.panel2.Controls.Add(this.TBNombre);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BImagen);
            this.panel2.Controls.Add(this.LNombre);
            this.panel2.Controls.Add(this.LDescripcion);
            this.panel2.Controls.Add(this.TBPrecio);
            this.panel2.Controls.Add(this.LPrecio);
            this.panel2.Controls.Add(this.TBDescripcion);
            this.panel2.Location = new System.Drawing.Point(149, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 314);
            this.panel2.TabIndex = 26;
            // 
            // TBTalle
            // 
            this.TBTalle.ForeColor = System.Drawing.Color.Black;
            this.TBTalle.Location = new System.Drawing.Point(197, 217);
            this.TBTalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBTalle.Name = "TBTalle";
            this.TBTalle.Size = new System.Drawing.Size(69, 22);
            this.TBTalle.TabIndex = 35;
            // 
            // LTalle
            // 
            this.LTalle.AutoSize = true;
            this.LTalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTalle.ForeColor = System.Drawing.Color.White;
            this.LTalle.Location = new System.Drawing.Point(88, 220);
            this.LTalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTalle.Name = "LTalle";
            this.LTalle.Size = new System.Drawing.Size(53, 17);
            this.LTalle.TabIndex = 34;
            this.LTalle.Text = "Stock:";
            // 
            // LDetallesProductos
            // 
            this.LDetallesProductos.AutoSize = true;
            this.LDetallesProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetallesProductos.ForeColor = System.Drawing.Color.White;
            this.LDetallesProductos.Location = new System.Drawing.Point(84, 10);
            this.LDetallesProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDetallesProductos.Name = "LDetallesProductos";
            this.LDetallesProductos.Size = new System.Drawing.Size(303, 39);
            this.LDetallesProductos.TabIndex = 26;
            this.LDetallesProductos.Text = "Detalles Producto";
            // 
            // TBNombre
            // 
            this.TBNombre.ForeColor = System.Drawing.Color.Black;
            this.TBNombre.Location = new System.Drawing.Point(197, 96);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(132, 22);
            this.TBNombre.TabIndex = 27;
            // 
            // BImagen
            // 
            this.BImagen.ForeColor = System.Drawing.Color.Black;
            this.BImagen.Location = new System.Drawing.Point(229, 263);
            this.BImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BImagen.Name = "BImagen";
            this.BImagen.Size = new System.Drawing.Size(100, 28);
            this.BImagen.TabIndex = 33;
            this.BImagen.Text = "Imagen";
            this.BImagen.UseVisualStyleBackColor = true;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.White;
            this.LNombre.Location = new System.Drawing.Point(88, 100);
            this.LNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(69, 17);
            this.LNombre.TabIndex = 28;
            this.LNombre.Text = "Nombre:";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.ForeColor = System.Drawing.Color.White;
            this.LDescripcion.Location = new System.Drawing.Point(88, 138);
            this.LDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(98, 17);
            this.LDescripcion.TabIndex = 29;
            this.LDescripcion.Text = "Descripcion:";
            // 
            // TBPrecio
            // 
            this.TBPrecio.ForeColor = System.Drawing.Color.Black;
            this.TBPrecio.Location = new System.Drawing.Point(197, 174);
            this.TBPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(132, 22);
            this.TBPrecio.TabIndex = 32;
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.ForeColor = System.Drawing.Color.White;
            this.LPrecio.Location = new System.Drawing.Point(88, 177);
            this.LPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(59, 17);
            this.LPrecio.TabIndex = 30;
            this.LPrecio.Text = "Precio:";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.ForeColor = System.Drawing.Color.Black;
            this.TBDescripcion.Location = new System.Drawing.Point(197, 134);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(132, 22);
            this.TBDescripcion.TabIndex = 31;
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHabilitar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitar.ForeColor = System.Drawing.Color.White;
            this.btnHabilitar.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.btnHabilitar.IconColor = System.Drawing.Color.White;
            this.btnHabilitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHabilitar.IconSize = 16;
            this.btnHabilitar.Location = new System.Drawing.Point(982, 109);
            this.btnHabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(287, 28);
            this.btnHabilitar.TabIndex = 77;
            this.btnHabilitar.Text = "Habilitar producto";
            this.btnHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHabilitar.UseVisualStyleBackColor = false;
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
            this.btnDeshabilitar.Location = new System.Drawing.Point(984, 73);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(287, 28);
            this.btnDeshabilitar.TabIndex = 76;
            this.btnDeshabilitar.Text = "Deshabilitar producto";
            this.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeshabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            // 
            // LCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1579, 669);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LCategoria";
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBTalle;
        private System.Windows.Forms.Label LTalle;
        private System.Windows.Forms.Label LDetallesProductos;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Button BImagen;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.TextBox TBDescripcion;
        private FontAwesome.Sharp.IconButton btnHabilitar;
        private FontAwesome.Sharp.IconButton btnDeshabilitar;
    }
}