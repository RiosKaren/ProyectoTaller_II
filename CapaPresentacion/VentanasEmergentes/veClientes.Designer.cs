namespace CapaPresentacion.VentanasEmergentes
{
    partial class veClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelListaClientes = new System.Windows.Forms.Label();
            this.ClientesDGV = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.iconButtonLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.btnAgregarCliente = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListaClientes
            // 
            this.labelListaClientes.BackColor = System.Drawing.Color.White;
            this.labelListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaClientes.Location = new System.Drawing.Point(24, 24);
            this.labelListaClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListaClientes.Name = "labelListaClientes";
            this.labelListaClientes.Size = new System.Drawing.Size(960, 62);
            this.labelListaClientes.TabIndex = 65;
            this.labelListaClientes.Text = "Lista de Clientes:";
            this.labelListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientesDGV
            // 
            this.ClientesDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ClientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.dni,
            this.apellido,
            this.nombre,
            this.activo});
            this.ClientesDGV.Location = new System.Drawing.Point(24, 104);
            this.ClientesDGV.Margin = new System.Windows.Forms.Padding(5);
            this.ClientesDGV.MultiSelect = false;
            this.ClientesDGV.Name = "ClientesDGV";
            this.ClientesDGV.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.ClientesDGV.RowHeadersWidth = 51;
            this.ClientesDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientesDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ClientesDGV.RowTemplate.Height = 28;
            this.ClientesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientesDGV.Size = new System.Drawing.Size(960, 347);
            this.ClientesDGV.TabIndex = 64;
            this.ClientesDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesDGV_CellDoubleClick);
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "id_cliente";
            this.id_cliente.MinimumWidth = 6;
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Visible = false;
            this.id_cliente.Width = 125;
            // 
            // dni
            // 
            this.dni.HeaderText = "Nro Documento";
            this.dni.MinimumWidth = 6;
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 170;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 170;
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
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(639, 40);
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(209, 22);
            this.textBoxBusqueda.TabIndex = 76;
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.BackColor = System.Drawing.Color.White;
            this.comboBoxBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(466, 40);
            this.comboBoxBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(165, 24);
            this.comboBoxBusqueda.TabIndex = 75;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.BackColor = System.Drawing.Color.White;
            this.labelBuscar.Location = new System.Drawing.Point(354, 43);
            this.labelBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(76, 16);
            this.labelBuscar.TabIndex = 74;
            this.labelBuscar.Text = "Buscar Por:";
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
            this.iconButtonLimpiar.Location = new System.Drawing.Point(911, 40);
            this.iconButtonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonLimpiar.Name = "iconButtonLimpiar";
            this.iconButtonLimpiar.Size = new System.Drawing.Size(45, 22);
            this.iconButtonLimpiar.TabIndex = 77;
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
            this.iconButtonBuscar.Location = new System.Drawing.Point(858, 40);
            this.iconButtonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.Size = new System.Drawing.Size(45, 22);
            this.iconButtonBuscar.TabIndex = 78;
            this.iconButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            this.iconButtonBuscar.Click += new System.EventHandler(this.iconButtonBuscar_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnAgregarCliente.IconColor = System.Drawing.Color.Black;
            this.btnAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCliente.IconSize = 16;
            this.btnAgregarCliente.Location = new System.Drawing.Point(824, 460);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(160, 28);
            this.btnAgregarCliente.TabIndex = 79;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // veClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1026, 508);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.iconButtonLimpiar);
            this.Controls.Add(this.iconButtonBuscar);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.comboBoxBusqueda);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.labelListaClientes);
            this.Controls.Add(this.ClientesDGV);
            this.Name = "veClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "veCliente";
            this.Load += new System.EventHandler(this.veCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListaClientes;
        private System.Windows.Forms.DataGridView ClientesDGV;
        private FontAwesome.Sharp.IconButton iconButtonLimpiar;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private FontAwesome.Sharp.IconButton btnAgregarCliente;
    }
}