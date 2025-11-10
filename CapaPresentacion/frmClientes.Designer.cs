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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.textBoxIndice = new System.Windows.Forms.TextBox();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelListaClientes = new System.Windows.Forms.Label();
            this.ClientesDGV = new System.Windows.Forms.DataGridView();
            this.botonSeleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.labelSexo = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHabilitarCliente = new FontAwesome.Sharp.IconButton();
            this.iconButtonLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.btnEliminarCliente = new FontAwesome.Sharp.IconButton();
            this.btnEditarCliente = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCliente = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIndice
            // 
            this.textBoxIndice.Location = new System.Drawing.Point(160, 41);
            this.textBoxIndice.Name = "textBoxIndice";
            this.textBoxIndice.Size = new System.Drawing.Size(32, 20);
            this.textBoxIndice.TabIndex = 74;
            this.textBoxIndice.Visible = false;
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(896, 37);
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
            this.comboBoxBusqueda.Location = new System.Drawing.Point(766, 37);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(125, 21);
            this.comboBoxBusqueda.TabIndex = 70;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.BackColor = System.Drawing.Color.White;
            this.labelBuscar.Location = new System.Drawing.Point(682, 40);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(62, 13);
            this.labelBuscar.TabIndex = 69;
            this.labelBuscar.Text = "Buscar Por:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.Color.White;
            this.comboBoxEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(130, 304);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEstado.TabIndex = 67;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.Color.White;
            this.labelEstado.Location = new System.Drawing.Point(128, 286);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(93, 13);
            this.labelEstado.TabIndex = 66;
            this.labelEstado.Text = "Estado de Cliente:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(197, 41);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(32, 20);
            this.textBoxID.TabIndex = 55;
            this.textBoxID.Text = "0";
            this.textBoxID.Visible = false;
            // 
            // labelListaClientes
            // 
            this.labelListaClientes.BackColor = System.Drawing.Color.White;
            this.labelListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaClientes.Location = new System.Drawing.Point(292, 19);
            this.labelListaClientes.Name = "labelListaClientes";
            this.labelListaClientes.Size = new System.Drawing.Size(878, 50);
            this.labelListaClientes.TabIndex = 63;
            this.labelListaClientes.Text = "Lista de Clientes:";
            this.labelListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientesDGV
            // 
            this.ClientesDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.botonSeleccionar,
            this.id_cliente,
            this.dni,
            this.apellido,
            this.nombre,
            this.telefono,
            this.email,
            this.direccion,
            this.sexo,
            this.activo,
            this.estado});
            this.ClientesDGV.Location = new System.Drawing.Point(292, 92);
            this.ClientesDGV.Margin = new System.Windows.Forms.Padding(4);
            this.ClientesDGV.MultiSelect = false;
            this.ClientesDGV.Name = "ClientesDGV";
            this.ClientesDGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientesDGV.RowHeadersWidth = 51;
            this.ClientesDGV.RowTemplate.Height = 28;
            this.ClientesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientesDGV.Size = new System.Drawing.Size(878, 434);
            this.ClientesDGV.TabIndex = 62;
            this.ClientesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesDGV_CellClick);
            this.ClientesDGV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ClientesDGV_CellPainting);
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.HeaderText = "";
            this.botonSeleccionar.MinimumWidth = 6;
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.ReadOnly = true;
            this.botonSeleccionar.Width = 30;
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
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Correo";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.MinimumWidth = 6;
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 125;
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
            this.labelTitulo.Location = new System.Drawing.Point(8, 3);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(205, 31);
            this.labelTitulo.TabIndex = 60;
            this.labelTitulo.Text = "Detalles Cliente";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(130, 154);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 46;
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(128, 136);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 13);
            this.labelEmail.TabIndex = 61;
            this.labelEmail.Text = "Correo:";
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.BackColor = System.Drawing.Color.White;
            this.radioButtonMasculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMasculino.Location = new System.Drawing.Point(130, 251);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 53;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = false;
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.BackColor = System.Drawing.Color.White;
            this.radioButtonFemenino.Checked = true;
            this.radioButtonFemenino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonFemenino.Location = new System.Drawing.Point(16, 251);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFemenino.TabIndex = 52;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = false;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.BackColor = System.Drawing.Color.White;
            this.labelSexo.Location = new System.Drawing.Point(14, 233);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(34, 13);
            this.labelSexo.TabIndex = 51;
            this.labelSexo.Text = "Sexo:";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(16, 198);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(213, 20);
            this.textBoxDireccion.TabIndex = 49;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.BackColor = System.Drawing.Color.White;
            this.labelDireccion.Location = new System.Drawing.Point(14, 180);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 48;
            this.labelDireccion.Text = "Dirección:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.BackColor = System.Drawing.Color.White;
            this.labelTelefono.Location = new System.Drawing.Point(14, 136);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 47;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(16, 154);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 45;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(130, 110);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 44;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(16, 110);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 43;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(16, 60);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 42;
            this.textBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNI_KeyPress);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.BackColor = System.Drawing.Color.White;
            this.labelApellido.Location = new System.Drawing.Point(128, 92);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 40;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(14, 92);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 39;
            this.labelNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nro Documento: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 544);
            this.label1.TabIndex = 38;
            // 
            // btnHabilitarCliente
            // 
            this.btnHabilitarCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHabilitarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHabilitarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHabilitarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitarCliente.ForeColor = System.Drawing.Color.White;
            this.btnHabilitarCliente.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.btnHabilitarCliente.IconColor = System.Drawing.Color.White;
            this.btnHabilitarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHabilitarCliente.IconSize = 16;
            this.btnHabilitarCliente.Location = new System.Drawing.Point(13, 503);
            this.btnHabilitarCliente.Name = "btnHabilitarCliente";
            this.btnHabilitarCliente.Size = new System.Drawing.Size(215, 23);
            this.btnHabilitarCliente.TabIndex = 75;
            this.btnHabilitarCliente.Text = "Habilitar Cliente";
            this.btnHabilitarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHabilitarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHabilitarCliente.UseVisualStyleBackColor = false;
            this.btnHabilitarCliente.Click += new System.EventHandler(this.btnHabilitarCliente_Click);
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
            this.iconButtonLimpiar.Location = new System.Drawing.Point(1100, 37);
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
            this.iconButtonBuscar.Location = new System.Drawing.Point(1060, 37);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.Size = new System.Drawing.Size(34, 18);
            this.iconButtonBuscar.TabIndex = 73;
            this.iconButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            this.iconButtonBuscar.Click += new System.EventHandler(this.iconButtonBuscar_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnEliminarCliente.IconColor = System.Drawing.Color.White;
            this.btnEliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCliente.IconSize = 16;
            this.btnEliminarCliente.Location = new System.Drawing.Point(14, 474);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(215, 23);
            this.btnEliminarCliente.TabIndex = 57;
            this.btnEliminarCliente.Text = "Deshabilitar Cliente";
            this.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEditarCliente.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarCliente.IconColor = System.Drawing.Color.White;
            this.btnEditarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarCliente.IconSize = 16;
            this.btnEditarCliente.Location = new System.Drawing.Point(14, 445);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(215, 23);
            this.btnEditarCliente.TabIndex = 56;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCliente.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCliente.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarCliente.IconColor = System.Drawing.Color.White;
            this.btnGuardarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCliente.IconSize = 16;
            this.btnGuardarCliente.Location = new System.Drawing.Point(14, 416);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(215, 23);
            this.btnGuardarCliente.TabIndex = 58;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCliente.UseVisualStyleBackColor = false;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1184, 544);
            this.Controls.Add(this.btnHabilitarCliente);
            this.Controls.Add(this.textBoxIndice);
            this.Controls.Add(this.iconButtonLimpiar);
            this.Controls.Add(this.iconButtonBuscar);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.comboBoxBusqueda);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelListaClientes);
            this.Controls.Add(this.ClientesDGV);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.radioButtonFemenino);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnHabilitarCliente;
        private System.Windows.Forms.TextBox textBoxIndice;
        private FontAwesome.Sharp.IconButton iconButtonLimpiar;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelListaClientes;
        private System.Windows.Forms.DataGridView ClientesDGV;
        private System.Windows.Forms.Label labelTitulo;
        private FontAwesome.Sharp.IconButton btnEliminarCliente;
        private FontAwesome.Sharp.IconButton btnEditarCliente;
        private FontAwesome.Sharp.IconButton btnGuardarCliente;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn botonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}