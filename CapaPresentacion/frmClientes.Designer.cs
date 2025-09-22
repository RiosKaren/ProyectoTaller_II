namespace CapaPresentacion
{
    partial class frmClientes
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
            this.LDni = new System.Windows.Forms.Label();
            this.LDetallesProductos = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LFecha_Nacimiento = new System.Windows.Forms.Label();
            this.LSexo = new System.Windows.Forms.Label();
            this.LActivo = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBDNI = new System.Windows.Forms.TextBox();
            this.RBClienteFemenino = new System.Windows.Forms.RadioButton();
            this.RBClienteMasculino = new System.Windows.Forms.RadioButton();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RBActivoNo = new System.Windows.Forms.RadioButton();
            this.RBActivoSI = new System.Windows.Forms.RadioButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.DTPFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.White;
            this.LDni.Location = new System.Drawing.Point(33, 165);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(33, 13);
            this.LDni.TabIndex = 34;
            this.LDni.Text = "DNI:";
            this.LDni.Click += new System.EventHandler(this.LDni_Click);
            // 
            // LDetallesProductos
            // 
            this.LDetallesProductos.AutoSize = true;
            this.LDetallesProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetallesProductos.ForeColor = System.Drawing.Color.White;
            this.LDetallesProductos.Location = new System.Drawing.Point(30, 21);
            this.LDetallesProductos.Name = "LDetallesProductos";
            this.LDetallesProductos.Size = new System.Drawing.Size(219, 31);
            this.LDetallesProductos.TabIndex = 26;
            this.LDetallesProductos.Text = "Detalles Clientes";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.White;
            this.LNombre.Location = new System.Drawing.Point(33, 70);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(54, 13);
            this.LNombre.TabIndex = 28;
            this.LNombre.Text = "Nombre:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.ForeColor = System.Drawing.Color.White;
            this.LEmail.Location = new System.Drawing.Point(33, 134);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(41, 13);
            this.LEmail.TabIndex = 29;
            this.LEmail.Text = "Email:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.Color.White;
            this.LApellido.Location = new System.Drawing.Point(33, 102);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(56, 13);
            this.LApellido.TabIndex = 37;
            this.LApellido.Text = "Apellido:";
            // 
            // LFecha_Nacimiento
            // 
            this.LFecha_Nacimiento.AutoSize = true;
            this.LFecha_Nacimiento.ForeColor = System.Drawing.Color.White;
            this.LFecha_Nacimiento.Location = new System.Drawing.Point(235, 102);
            this.LFecha_Nacimiento.Name = "LFecha_Nacimiento";
            this.LFecha_Nacimiento.Size = new System.Drawing.Size(114, 13);
            this.LFecha_Nacimiento.TabIndex = 38;
            this.LFecha_Nacimiento.Text = "Fecha de Nacimiento: ";
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.ForeColor = System.Drawing.Color.White;
            this.LSexo.Location = new System.Drawing.Point(235, 134);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(34, 13);
            this.LSexo.TabIndex = 39;
            this.LSexo.Text = "Sexo:";
            // 
            // LActivo
            // 
            this.LActivo.AutoSize = true;
            this.LActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LActivo.ForeColor = System.Drawing.Color.White;
            this.LActivo.Location = new System.Drawing.Point(55, 19);
            this.LActivo.Name = "LActivo";
            this.LActivo.Size = new System.Drawing.Size(43, 13);
            this.LActivo.TabIndex = 41;
            this.LActivo.Text = "Activo";
            this.LActivo.Click += new System.EventHandler(this.LActivo_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(881, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(215, 23);
            this.btnEliminar.TabIndex = 43;
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
            this.btnGuardar.Location = new System.Drawing.Point(231, 160);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(215, 23);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(92, 67);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(100, 20);
            this.TBNombre.TabIndex = 45;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(92, 99);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(100, 20);
            this.TBApellido.TabIndex = 46;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(92, 131);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(100, 20);
            this.TBEmail.TabIndex = 47;
            // 
            // TBDNI
            // 
            this.TBDNI.Location = new System.Drawing.Point(92, 162);
            this.TBDNI.Name = "TBDNI";
            this.TBDNI.Size = new System.Drawing.Size(100, 20);
            this.TBDNI.TabIndex = 48;
            // 
            // RBClienteFemenino
            // 
            this.RBClienteFemenino.AutoSize = true;
            this.RBClienteFemenino.ForeColor = System.Drawing.Color.White;
            this.RBClienteFemenino.Location = new System.Drawing.Point(282, 130);
            this.RBClienteFemenino.Name = "RBClienteFemenino";
            this.RBClienteFemenino.Size = new System.Drawing.Size(71, 17);
            this.RBClienteFemenino.TabIndex = 49;
            this.RBClienteFemenino.TabStop = true;
            this.RBClienteFemenino.Text = "Femenino";
            this.RBClienteFemenino.UseVisualStyleBackColor = true;
            // 
            // RBClienteMasculino
            // 
            this.RBClienteMasculino.AutoSize = true;
            this.RBClienteMasculino.ForeColor = System.Drawing.Color.White;
            this.RBClienteMasculino.Location = new System.Drawing.Point(373, 130);
            this.RBClienteMasculino.Name = "RBClienteMasculino";
            this.RBClienteMasculino.Size = new System.Drawing.Size(73, 17);
            this.RBClienteMasculino.TabIndex = 49;
            this.RBClienteMasculino.TabStop = true;
            this.RBClienteMasculino.Text = "Masculino";
            this.RBClienteMasculino.UseVisualStyleBackColor = true;
            // 
            // DGVProductos
            // 
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Location = new System.Drawing.Point(36, 57);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.Size = new System.Drawing.Size(1060, 241);
            this.DGVProductos.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.RBActivoNo);
            this.panel1.Controls.Add(this.RBActivoSI);
            this.panel1.Controls.Add(this.DGVProductos);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.LActivo);
            this.panel1.Location = new System.Drawing.Point(-24, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 315);
            this.panel1.TabIndex = 50;
            // 
            // RBActivoNo
            // 
            this.RBActivoNo.AutoSize = true;
            this.RBActivoNo.ForeColor = System.Drawing.Color.White;
            this.RBActivoNo.Location = new System.Drawing.Point(155, 17);
            this.RBActivoNo.Name = "RBActivoNo";
            this.RBActivoNo.Size = new System.Drawing.Size(39, 17);
            this.RBActivoNo.TabIndex = 44;
            this.RBActivoNo.Text = "No";
            this.RBActivoNo.UseVisualStyleBackColor = true;
            // 
            // RBActivoSI
            // 
            this.RBActivoSI.AutoSize = true;
            this.RBActivoSI.Checked = true;
            this.RBActivoSI.ForeColor = System.Drawing.Color.White;
            this.RBActivoSI.Location = new System.Drawing.Point(115, 17);
            this.RBActivoSI.Name = "RBActivoSI";
            this.RBActivoSI.Size = new System.Drawing.Size(34, 17);
            this.RBActivoSI.TabIndex = 44;
            this.RBActivoSI.TabStop = true;
            this.RBActivoSI.Text = "Si";
            this.RBActivoSI.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(660, 17);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(215, 23);
            this.iconButton1.TabIndex = 21;
            this.iconButton1.Text = "Editar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // DTPFechaNacimiento
            // 
            this.DTPFechaNacimiento.CalendarTitleForeColor = System.Drawing.Color.Peru;
            this.DTPFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaNacimiento.Location = new System.Drawing.Point(362, 99);
            this.DTPFechaNacimiento.Name = "DTPFechaNacimiento";
            this.DTPFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DTPFechaNacimiento.Size = new System.Drawing.Size(91, 20);
            this.DTPFechaNacimiento.TabIndex = 51;
            this.DTPFechaNacimiento.ValueChanged += new System.EventHandler(this.DTPFechaNacimiento_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.LDetallesProductos);
            this.panel2.Controls.Add(this.DTPFechaNacimiento);
            this.panel2.Controls.Add(this.LEmail);
            this.panel2.Controls.Add(this.LNombre);
            this.panel2.Controls.Add(this.RBClienteMasculino);
            this.panel2.Controls.Add(this.LDni);
            this.panel2.Controls.Add(this.RBClienteFemenino);
            this.panel2.Controls.Add(this.LApellido);
            this.panel2.Controls.Add(this.TBDNI);
            this.panel2.Controls.Add(this.LFecha_Nacimiento);
            this.panel2.Controls.Add(this.TBEmail);
            this.panel2.Controls.Add(this.LSexo);
            this.panel2.Controls.Add(this.TBApellido);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.TBNombre);
            this.panel2.Location = new System.Drawing.Point(-1, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 220);
            this.panel2.TabIndex = 52;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LDetallesProductos;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LFecha_Nacimiento;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.Label LActivo;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBDNI;
        private System.Windows.Forms.RadioButton RBClienteFemenino;
        private System.Windows.Forms.RadioButton RBClienteMasculino;
        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.RadioButton RBActivoSI;
        private System.Windows.Forms.RadioButton RBActivoNo;
        private System.Windows.Forms.DateTimePicker DTPFechaNacimiento;
        private System.Windows.Forms.Panel panel2;
    }
}