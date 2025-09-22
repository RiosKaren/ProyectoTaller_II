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
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(324, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 208);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // DGVProductos
            // 
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Location = new System.Drawing.Point(25, 41);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.Size = new System.Drawing.Size(1004, 226);
            this.DGVProductos.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.DGVProductos);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Location = new System.Drawing.Point(-6, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 289);
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
            this.btnEditar.Location = new System.Drawing.Point(853, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(176, 23);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.btnEliminar.Location = new System.Drawing.Point(624, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(215, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            this.btnGuardar.Location = new System.Drawing.Point(624, 39);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(215, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.TBTalle);
            this.panel2.Controls.Add(this.btnEliminar);
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
            this.panel2.Location = new System.Drawing.Point(112, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 255);
            this.panel2.TabIndex = 26;
            // 
            // TBTalle
            // 
            this.TBTalle.ForeColor = System.Drawing.Color.Black;
            this.TBTalle.Location = new System.Drawing.Point(148, 176);
            this.TBTalle.Name = "TBTalle";
            this.TBTalle.Size = new System.Drawing.Size(53, 20);
            this.TBTalle.TabIndex = 35;
            // 
            // LTalle
            // 
            this.LTalle.AutoSize = true;
            this.LTalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTalle.ForeColor = System.Drawing.Color.White;
            this.LTalle.Location = new System.Drawing.Point(66, 179);
            this.LTalle.Name = "LTalle";
            this.LTalle.Size = new System.Drawing.Size(44, 13);
            this.LTalle.TabIndex = 34;
            this.LTalle.Text = "Stock:";
            // 
            // LDetallesProductos
            // 
            this.LDetallesProductos.AutoSize = true;
            this.LDetallesProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetallesProductos.ForeColor = System.Drawing.Color.White;
            this.LDetallesProductos.Location = new System.Drawing.Point(30, 19);
            this.LDetallesProductos.Name = "LDetallesProductos";
            this.LDetallesProductos.Size = new System.Drawing.Size(246, 31);
            this.LDetallesProductos.TabIndex = 26;
            this.LDetallesProductos.Text = "Detalles Producto";
            // 
            // TBNombre
            // 
            this.TBNombre.ForeColor = System.Drawing.Color.Black;
            this.TBNombre.Location = new System.Drawing.Point(148, 78);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 20);
            this.TBNombre.TabIndex = 27;
            // 
            // BImagen
            // 
            this.BImagen.ForeColor = System.Drawing.Color.Black;
            this.BImagen.Location = new System.Drawing.Point(175, 214);
            this.BImagen.Name = "BImagen";
            this.BImagen.Size = new System.Drawing.Size(75, 23);
            this.BImagen.TabIndex = 33;
            this.BImagen.Text = "Imagen";
            this.BImagen.UseVisualStyleBackColor = true;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.White;
            this.LNombre.Location = new System.Drawing.Point(66, 81);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(54, 13);
            this.LNombre.TabIndex = 28;
            this.LNombre.Text = "Nombre:";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.ForeColor = System.Drawing.Color.White;
            this.LDescripcion.Location = new System.Drawing.Point(66, 112);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(78, 13);
            this.LDescripcion.TabIndex = 29;
            this.LDescripcion.Text = "Descripcion:";
            // 
            // TBPrecio
            // 
            this.TBPrecio.ForeColor = System.Drawing.Color.Black;
            this.TBPrecio.Location = new System.Drawing.Point(148, 141);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(100, 20);
            this.TBPrecio.TabIndex = 32;
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.ForeColor = System.Drawing.Color.White;
            this.LPrecio.Location = new System.Drawing.Point(66, 144);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(47, 13);
            this.LPrecio.TabIndex = 30;
            this.LPrecio.Text = "Precio:";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.ForeColor = System.Drawing.Color.Black;
            this.TBDescripcion.Location = new System.Drawing.Point(148, 109);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(100, 20);
            this.TBDescripcion.TabIndex = 31;
            // 
            // LCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private FontAwesome.Sharp.IconButton btnEliminar;
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
    }
}