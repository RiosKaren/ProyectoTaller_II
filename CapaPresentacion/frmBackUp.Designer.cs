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
            this.CB_BDD = new System.Windows.Forms.ComboBox();
            this.BConectar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BSeleccionarRuta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LDetallesBackup
            // 
            this.LDetallesBackup.AutoSize = true;
            this.LDetallesBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetallesBackup.ForeColor = System.Drawing.Color.White;
            this.LDetallesBackup.Location = new System.Drawing.Point(24, 32);
            this.LDetallesBackup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDetallesBackup.Name = "LDetallesBackup";
            this.LDetallesBackup.Size = new System.Drawing.Size(137, 39);
            this.LDetallesBackup.TabIndex = 1;
            this.LDetallesBackup.Text = "Backup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta a guardar:";
            // 
            // CB_BDD
            // 
            this.CB_BDD.FormattingEnabled = true;
            this.CB_BDD.Location = new System.Drawing.Point(164, 123);
            this.CB_BDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_BDD.Name = "CB_BDD";
            this.CB_BDD.Size = new System.Drawing.Size(243, 24);
            this.CB_BDD.TabIndex = 4;
            // 
            // BConectar
            // 
            this.BConectar.Location = new System.Drawing.Point(459, 123);
            this.BConectar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BConectar.Name = "BConectar";
            this.BConectar.Size = new System.Drawing.Size(100, 28);
            this.BConectar.TabIndex = 5;
            this.BConectar.Text = "Conectar";
            this.BConectar.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // BSeleccionarRuta
            // 
            this.BSeleccionarRuta.Location = new System.Drawing.Point(164, 170);
            this.BSeleccionarRuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BSeleccionarRuta.Name = "BSeleccionarRuta";
            this.BSeleccionarRuta.Size = new System.Drawing.Size(244, 28);
            this.BSeleccionarRuta.TabIndex = 6;
            this.BSeleccionarRuta.Text = "Seleccionar Ruta";
            this.BSeleccionarRuta.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.LDetallesBackup);
            this.panel1.Controls.Add(this.BSeleccionarRuta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BConectar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CB_BDD);
            this.panel1.Location = new System.Drawing.Point(528, 289);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 278);
            this.panel1.TabIndex = 7;
            // 
            // frmBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1579, 669);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBackUp";
            this.Text = "frmBackUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LDetallesBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_BDD;
        private System.Windows.Forms.Button BConectar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BSeleccionarRuta;
        private System.Windows.Forms.Panel panel1;
    }
}