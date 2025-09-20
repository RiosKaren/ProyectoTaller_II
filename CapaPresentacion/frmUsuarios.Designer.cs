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
            this.textBoxCPassword = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelRol = new System.Windows.Forms.Label();
            this.RolCBOX = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.UsuariosDGV = new System.Windows.Forms.DataGridView();
            this.DatagridviewcellStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hash_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelListaUsuarios = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 523);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nro Documento: ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(28, 111);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.BackColor = System.Drawing.Color.White;
            this.labelApellido.Location = new System.Drawing.Point(143, 111);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(31, 77);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 4;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            this.textBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNI_KeyPress);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(31, 127);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 5;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(146, 127);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 6;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(31, 177);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 7;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(29, 161);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(46, 13);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "Usuario:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(28, 212);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 13);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Contraseña:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(31, 228);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.BackColor = System.Drawing.Color.White;
            this.labelSexo.Location = new System.Drawing.Point(29, 314);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(34, 13);
            this.labelSexo.TabIndex = 11;
            this.labelSexo.Text = "Sexo:";
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.BackColor = System.Drawing.Color.White;
            this.radioButtonFemenino.Checked = true;
            this.radioButtonFemenino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonFemenino.Location = new System.Drawing.Point(31, 330);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(71, 17);
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
            this.radioButtonMasculino.Location = new System.Drawing.Point(146, 330);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 12;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = false;
            // 
            // labelCPasword
            // 
            this.labelCPasword.AutoSize = true;
            this.labelCPasword.BackColor = System.Drawing.Color.White;
            this.labelCPasword.Location = new System.Drawing.Point(29, 264);
            this.labelCPasword.Name = "labelCPasword";
            this.labelCPasword.Size = new System.Drawing.Size(111, 13);
            this.labelCPasword.TabIndex = 14;
            this.labelCPasword.Text = "Confirmar Contraseña:";
            // 
            // textBoxCPassword
            // 
            this.textBoxCPassword.Location = new System.Drawing.Point(31, 280);
            this.textBoxCPassword.Name = "textBoxCPassword";
            this.textBoxCPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxCPassword.TabIndex = 10;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(143, 161);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(146, 177);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 8;
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.BackColor = System.Drawing.Color.White;
            this.labelRol.Location = new System.Drawing.Point(28, 362);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(29, 13);
            this.labelRol.TabIndex = 18;
            this.labelRol.Text = "Rol: ";
            // 
            // RolCBOX
            // 
            this.RolCBOX.BackColor = System.Drawing.Color.White;
            this.RolCBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolCBOX.FormattingEnabled = true;
            this.RolCBOX.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Supervisor"});
            this.RolCBOX.Location = new System.Drawing.Point(31, 378);
            this.RolCBOX.Name = "RolCBOX";
            this.RolCBOX.Size = new System.Drawing.Size(100, 21);
            this.RolCBOX.TabIndex = 13;
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
            this.btnGuardar.Location = new System.Drawing.Point(31, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(215, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
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
            this.btnEditar.Location = new System.Drawing.Point(31, 445);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(215, 23);
            this.btnEditar.TabIndex = 15;
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
            this.btnEliminar.Location = new System.Drawing.Point(31, 474);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(215, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.White;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(25, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(214, 31);
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
            this.DatagridviewcellStyle,
            this.id_usuario,
            this.id_rol,
            this.dni,
            this.apellido,
            this.nombre,
            this.usuario,
            this.hash_password,
            this.fecha_nacimiento,
            this.Correo,
            this.Sexo,
            this.activo});
            this.UsuariosDGV.Location = new System.Drawing.Point(299, 123);
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
            this.UsuariosDGV.RowTemplate.Height = 28;
            this.UsuariosDGV.Size = new System.Drawing.Size(949, 154);
            this.UsuariosDGV.TabIndex = 24;
            // 
            // DatagridviewcellStyle
            // 
            this.DatagridviewcellStyle.HeaderText = "";
            this.DatagridviewcellStyle.Name = "DatagridviewcellStyle";
            this.DatagridviewcellStyle.ReadOnly = true;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "id_usuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Visible = false;
            // 
            // id_rol
            // 
            this.id_rol.HeaderText = "Rol";
            this.id_rol.Name = "id_rol";
            this.id_rol.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.HeaderText = "Nro DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 150;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // hash_password
            // 
            this.hash_password.HeaderText = "Contraseña";
            this.hash_password.Name = "hash_password";
            this.hash_password.ReadOnly = true;
            this.hash_password.Visible = false;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.HeaderText = "Fecha de Nacimiento";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.ReadOnly = true;
            this.fecha_nacimiento.Visible = false;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Genero";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 80;
            // 
            // activo
            // 
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Width = 50;
            // 
            // labelListaUsuarios
            // 
            this.labelListaUsuarios.BackColor = System.Drawing.Color.White;
            this.labelListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaUsuarios.Location = new System.Drawing.Point(294, 44);
            this.labelListaUsuarios.Name = "labelListaUsuarios";
            this.labelListaUsuarios.Size = new System.Drawing.Size(559, 39);
            this.labelListaUsuarios.TabIndex = 25;
            this.labelListaUsuarios.Text = "Lista de Usuarios:";
            this.labelListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(214, 58);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(32, 20);
            this.textBoxID.TabIndex = 15;
            this.textBoxID.Visible = false;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1270, 523);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelListaUsuarios);
            this.Controls.Add(this.UsuariosDGV);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.RolCBOX);
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
            this.Name = "frmUsuarios";
            this.Text = "1";
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
        private System.Windows.Forms.TextBox textBoxCPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.ComboBox RolCBOX;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView UsuariosDGV;
        private System.Windows.Forms.Label labelListaUsuarios;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatagridviewcellStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn hash_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
    }
}