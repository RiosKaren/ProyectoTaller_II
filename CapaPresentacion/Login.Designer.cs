namespace CapaPresentacion
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.iconButtonIngresar = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 375);
            this.label1.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.DarkRed;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(60, 294);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(214, 29);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Sistema de Venta";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 161;
            this.iconPictureBox1.Location = new System.Drawing.Point(83, 57);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(175, 161);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(388, 70);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(57, 16);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "Usuario:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(388, 105);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(275, 22);
            this.textBoxUser.TabIndex = 7;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(388, 149);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(79, 16);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Contraseña:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(388, 180);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(275, 22);
            this.textBoxPassword.TabIndex = 9;
            // 
            // iconButtonIngresar
            // 
            this.iconButtonIngresar.BackColor = System.Drawing.Color.DarkGray;
            this.iconButtonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.iconButtonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonIngresar.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.iconButtonIngresar.IconColor = System.Drawing.Color.DimGray;
            this.iconButtonIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonIngresar.IconSize = 21;
            this.iconButtonIngresar.Location = new System.Drawing.Point(392, 238);
            this.iconButtonIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonIngresar.Name = "iconButtonIngresar";
            this.iconButtonIngresar.Size = new System.Drawing.Size(272, 32);
            this.iconButtonIngresar.TabIndex = 10;
            this.iconButtonIngresar.Text = "Ingresar";
            this.iconButtonIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonIngresar.UseVisualStyleBackColor = false;
            this.iconButtonIngresar.Click += new System.EventHandler(this.iconButtonIngresar_Click);
            // 
            // iconButtonCancelar
            // 
            this.iconButtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCancelar.FlatAppearance.BorderSize = 0;
            this.iconButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonCancelar.IconColor = System.Drawing.Color.Black;
            this.iconButtonCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCancelar.Location = new System.Drawing.Point(481, 277);
            this.iconButtonCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonCancelar.Name = "iconButtonCancelar";
            this.iconButtonCancelar.Size = new System.Drawing.Size(100, 28);
            this.iconButtonCancelar.TabIndex = 11;
            this.iconButtonCancelar.Text = "Cancelar";
            this.iconButtonCancelar.UseVisualStyleBackColor = true;
            this.iconButtonCancelar.Click += new System.EventHandler(this.iconButtonCancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 375);
            this.Controls.Add(this.iconButtonCancelar);
            this.Controls.Add(this.iconButtonIngresar);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitulo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private FontAwesome.Sharp.IconButton iconButtonIngresar;
        private FontAwesome.Sharp.IconButton iconButtonCancelar;
    }
}