namespace CapaPresentacion
{
    partial class frmBackUp
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
            this.LDetallesBackup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCopiaDeSeguridad = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bElegirRuta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbRutaDeGuardado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LDetallesBackup
            // 
            this.LDetallesBackup.AutoSize = true;
            this.LDetallesBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetallesBackup.ForeColor = System.Drawing.Color.White;
            this.LDetallesBackup.Location = new System.Drawing.Point(18, 26);
            this.LDetallesBackup.Name = "LDetallesBackup";
            this.LDetallesBackup.Size = new System.Drawing.Size(111, 31);
            this.LDetallesBackup.TabIndex = 1;
            this.LDetallesBackup.Text = "Backup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta a guardar:";
            // 
            // bCopiaDeSeguridad
            // 
            this.bCopiaDeSeguridad.Location = new System.Drawing.Point(344, 100);
            this.bCopiaDeSeguridad.Name = "bCopiaDeSeguridad";
            this.bCopiaDeSeguridad.Size = new System.Drawing.Size(75, 23);
            this.bCopiaDeSeguridad.TabIndex = 5;
            this.bCopiaDeSeguridad.Text = "Guardar";
            this.bCopiaDeSeguridad.UseVisualStyleBackColor = true;
            this.bCopiaDeSeguridad.Click += new System.EventHandler(this.bCopiaDeSeguridad_Click);
            // 
            // bElegirRuta
            // 
            this.bElegirRuta.Location = new System.Drawing.Point(123, 138);
            this.bElegirRuta.Name = "bElegirRuta";
            this.bElegirRuta.Size = new System.Drawing.Size(183, 23);
            this.bElegirRuta.TabIndex = 6;
            this.bElegirRuta.Text = "Seleccionar Ruta";
            this.bElegirRuta.UseVisualStyleBackColor = true;
            this.bElegirRuta.Click += new System.EventHandler(this.bElegirRuta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.tbRutaDeGuardado);
            this.panel1.Controls.Add(this.LDetallesBackup);
            this.panel1.Controls.Add(this.bElegirRuta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bCopiaDeSeguridad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(386, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 226);
            this.panel1.TabIndex = 7;
            // 
            // tbRutaDeGuardado
            // 
            this.tbRutaDeGuardado.Location = new System.Drawing.Point(123, 100);
            this.tbRutaDeGuardado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRutaDeGuardado.Name = "tbRutaDeGuardado";
            this.tbRutaDeGuardado.Size = new System.Drawing.Size(184, 20);
            this.tbRutaDeGuardado.TabIndex = 7;
            // 
            // frmBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1184, 544);
            this.Controls.Add(this.panel1);
            this.Name = "frmBackUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LDetallesBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCopiaDeSeguridad;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button bElegirRuta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbRutaDeGuardado;
    }
}