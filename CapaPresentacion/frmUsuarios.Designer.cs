namespace CapaPresentacion
{
    partial class frmUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.labelCPasword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelRol = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.UsuariosDGV = new System.Windows.Forms.DataGridView();
            this.botonSeleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hash_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelListaUsuarios = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.comboBoxBusqueda = new System.Windows.Forms.ComboBox();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.iconButtonLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.textBoxIndice = new System.Windows.Forms.TextBox();
            this.iconButtonHabilitar = new FontAwesome.Sharp.IconButton();
            this.textBoxCPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 669);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nro Documento: ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(18, 113);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(59, 16);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.BackColor = System.Drawing.Color.White;
            this.labelApellido.Location = new System.Drawing.Point(170, 113);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(60, 16);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(21, 74);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(132, 22);
            this.textBoxDNI.TabIndex = 4;
            this.textBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNI_KeyPress);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(21, 135);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(132, 22);
            this.textBoxNombre.TabIndex = 5;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(173, 135);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(132, 22);
            this.textBoxApellido.TabIndex = 6;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(21, 190);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(132, 22);
            this.textBoxUser.TabIndex = 7;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(18, 167);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(57, 16);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "Usuario:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(18, 222);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(79, 16);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Contraseña:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(21, 244);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword.TabIndex = 9;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.BackColor = System.Drawing.Color.White;
            this.labelSexo.Location = new System.Drawing.Point(18, 389);
            this.labelSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(41, 16);
            this.labelSexo.TabIndex = 11;
            this.labelSexo.Text = "Sexo:";
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.BackColor = System.Drawing.Color.White;
            this.radioButtonFemenino.Checked = true;
            this.radioButtonFemenino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonFemenino.Location = new System.Drawing.Point(21, 411);
            this.radioButtonFemenino.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(88, 20);
            this.radioButtonFemenino.TabIndex = 11;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = false;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.BackColor = System.Drawing.Color.White;
            this.radioButtonMasculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMasculino.Location = new System.Drawing.Point(173, 409);
            this.radioButtonMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(89, 20);
            this.radioButtonMasculino.TabIndex = 12;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = false;
            // 
            // labelCPasword
            // 
            this.labelCPasword.AutoSize = true;
            this.labelCPasword.BackColor = System.Drawing.Color.White;
            this.labelCPasword.Location = new System.Drawing.Point(18, 277);
            this.labelCPasword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPasword.Name = "labelCPasword";
            this.labelCPasword.Size = new System.Drawing.Size(139, 16);
            this.labelCPasword.TabIndex = 14;
            this.labelCPasword.Text = "Confirmar Contraseña:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(170, 167);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 16);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(174, 190);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(132, 22);
            this.textBoxEmail.TabIndex = 8;
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.BackColor = System.Drawing.Color.White;
            this.labelRol.Location = new System.Drawing.Point(18, 446);
            this.labelRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(34, 16);
            this.labelRol.TabIndex = 18;
            this.labelRol.Text = "Rol: ";
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
            this.btnGuardar.Location = new System.Drawing.Point(19, 512);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(287, 28);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
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
            this.btnEditar.Location = new System.Drawing.Point(19, 548);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(287, 28);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(19, 583);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(287, 28);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Deshabilitar usuario";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.White;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(11, 4);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(268, 39);
            this.labelTitulo.TabIndex = 20;
            this.labelTitulo.Text = "Detalles Usuario";
            // 
            // UsuariosDGV
            // 
            this.UsuariosDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsuariosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.botonSeleccionar,
            this.id_usuario,
            this.dni,
            this.apellido,
            this.nombre,
            this.email,
            this.fecha_nacimiento,
            this.sexo,
            this.usuario,
            this.hash_password,
            this.id_rol,
            this.rol,
            this.activo,
            this.estado});
            this.UsuariosDGV.Location = new System.Drawing.Point(370, 113);
            this.UsuariosDGV.Margin = new System.Windows.Forms.Padding(5);
            this.UsuariosDGV.MultiSelect = false;
            this.UsuariosDGV.Name = "UsuariosDGV";
            this.UsuariosDGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsuariosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsuariosDGV.RowHeadersWidth = 51;
            this.UsuariosDGV.RowTemplate.Height = 28;
            this.UsuariosDGV.Size = new System.Drawing.Size(1170, 534);
            this.UsuariosDGV.TabIndex = 24;
            this.UsuariosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsuariosDGV_CellClick);
            this.UsuariosDGV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.UsuariosDGV_CellPainting);
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.HeaderText = "";
            this.botonSeleccionar.MinimumWidth = 6;
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.ReadOnly = true;
            this.botonSeleccionar.Width = 30;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "id_usuario";
            this.id_usuario.MinimumWidth = 6;
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Visible = false;
            this.id_usuario.Width = 125;
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
            // email
            // 
            this.email.HeaderText = "Correo";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.HeaderText = "Fecha de Nacimiento";
            this.fecha_nacimiento.MinimumWidth = 6;
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.ReadOnly = true;
            this.fecha_nacimiento.Width = 125;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.MinimumWidth = 6;
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 125;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            this.usuario.Width = 125;
            // 
            // hash_password
            // 
            this.hash_password.HeaderText = "hash_password";
            this.hash_password.MinimumWidth = 6;
            this.hash_password.Name = "hash_password";
            this.hash_password.ReadOnly = true;
            this.hash_password.Visible = false;
            this.hash_password.Width = 125;
            // 
            // id_rol
            // 
            this.id_rol.HeaderText = "id_rol";
            this.id_rol.MinimumWidth = 6;
            this.id_rol.Name = "id_rol";
            this.id_rol.ReadOnly = true;
            this.id_rol.Visible = false;
            this.id_rol.Width = 125;
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.MinimumWidth = 6;
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            this.rol.Width = 125;
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
            // labelListaUsuarios
            // 
            this.labelListaUsuarios.BackColor = System.Drawing.Color.White;
            this.labelListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaUsuarios.Location = new System.Drawing.Point(370, 23);
            this.labelListaUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListaUsuarios.Name = "labelListaUsuarios";
            this.labelListaUsuarios.Size = new System.Drawing.Size(1170, 62);
            this.labelListaUsuarios.TabIndex = 25;
            this.labelListaUsuarios.Text = "Lista de Usuarios:";
            this.labelListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(263, 50);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(41, 22);
            this.textBoxID.TabIndex = 15;
            this.textBoxID.Text = "0";
            // 
            // dateTimeNacimiento
            // 
            this.dateTimeNacimiento.Location = new System.Drawing.Point(21, 356);
            this.dateTimeNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNacimiento.MaxDate = new System.DateTime(2025, 9, 20, 0, 0, 0, 0);
            this.dateTimeNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeNacimiento.Name = "dateTimeNacimiento";
            this.dateTimeNacimiento.Size = new System.Drawing.Size(284, 22);
            this.dateTimeNacimiento.TabIndex = 26;
            this.dateTimeNacimiento.Value = new System.DateTime(2025, 9, 20, 0, 0, 0, 0);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(19, 334);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(138, 16);
            this.labelFecha.TabIndex = 27;
            this.labelFecha.Text = "Fecha de Nacimiento:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.Color.White;
            this.labelEstado.Location = new System.Drawing.Point(170, 446);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(119, 16);
            this.labelEstado.TabIndex = 28;
            this.labelEstado.Text = "Estado de usuario:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.Color.White;
            this.comboBoxEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(173, 468);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(132, 24);
            this.comboBoxEstado.TabIndex = 29;
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.BackColor = System.Drawing.Color.White;
            this.comboBoxRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(18, 468);
            this.comboBoxRoles.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(135, 24);
            this.comboBoxRoles.TabIndex = 30;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.BackColor = System.Drawing.Color.White;
            this.labelBuscar.Location = new System.Drawing.Point(891, 49);
            this.labelBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(76, 16);
            this.labelBuscar.TabIndex = 31;
            this.labelBuscar.Text = "Buscar Por:";
            // 
            // comboBoxBusqueda
            // 
            this.comboBoxBusqueda.BackColor = System.Drawing.Color.White;
            this.comboBoxBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusqueda.FormattingEnabled = true;
            this.comboBoxBusqueda.Location = new System.Drawing.Point(1003, 46);
            this.comboBoxBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBusqueda.Name = "comboBoxBusqueda";
            this.comboBoxBusqueda.Size = new System.Drawing.Size(165, 24);
            this.comboBoxBusqueda.TabIndex = 32;
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(1176, 46);
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(209, 22);
            this.textBoxBusqueda.TabIndex = 33;
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
            this.iconButtonLimpiar.Location = new System.Drawing.Point(1448, 46);
            this.iconButtonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonLimpiar.Name = "iconButtonLimpiar";
            this.iconButtonLimpiar.Size = new System.Drawing.Size(45, 22);
            this.iconButtonLimpiar.TabIndex = 34;
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
            this.iconButtonBuscar.Location = new System.Drawing.Point(1395, 46);
            this.iconButtonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.Size = new System.Drawing.Size(45, 22);
            this.iconButtonBuscar.TabIndex = 35;
            this.iconButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            this.iconButtonBuscar.Click += new System.EventHandler(this.iconButtonBuscar_Click);
            // 
            // textBoxIndice
            // 
            this.textBoxIndice.Location = new System.Drawing.Point(214, 50);
            this.textBoxIndice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIndice.Name = "textBoxIndice";
            this.textBoxIndice.Size = new System.Drawing.Size(41, 22);
            this.textBoxIndice.TabIndex = 36;
            this.textBoxIndice.Visible = false;
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
            this.iconButtonHabilitar.Location = new System.Drawing.Point(17, 619);
            this.iconButtonHabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonHabilitar.Name = "iconButtonHabilitar";
            this.iconButtonHabilitar.Size = new System.Drawing.Size(287, 28);
            this.iconButtonHabilitar.TabIndex = 37;
            this.iconButtonHabilitar.Text = "Habilitar usuario";
            this.iconButtonHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonHabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHabilitar.UseVisualStyleBackColor = false;
            this.iconButtonHabilitar.Click += new System.EventHandler(this.iconButtonHabilitar_Click);
            // 
            // textBoxCPassword
            // 
            this.textBoxCPassword.Location = new System.Drawing.Point(21, 299);
            this.textBoxCPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCPassword.Name = "textBoxCPassword";
            this.textBoxCPassword.PasswordChar = '*';
            this.textBoxCPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxCPassword.TabIndex = 10;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1579, 669);
            this.Controls.Add(this.iconButtonHabilitar);
            this.Controls.Add(this.textBoxIndice);
            this.Controls.Add(this.iconButtonLimpiar);
            this.Controls.Add(this.iconButtonBuscar);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.comboBoxBusqueda);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.dateTimeNacimiento);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelListaUsuarios);
            this.Controls.Add(this.UsuariosDGV);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxCPassword);
            this.Controls.Add(this.labelCPasword);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.radioButtonFemenino);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.Label labelCPasword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView UsuariosDGV;
        private System.Windows.Forms.Label labelListaUsuarios;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DateTimePicker dateTimeNacimiento;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.ComboBox comboBoxBusqueda;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private FontAwesome.Sharp.IconButton iconButtonLimpiar;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.TextBox textBoxIndice;
        private FontAwesome.Sharp.IconButton iconButtonHabilitar;
        private System.Windows.Forms.TextBox textBoxCPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn botonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn hash_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}