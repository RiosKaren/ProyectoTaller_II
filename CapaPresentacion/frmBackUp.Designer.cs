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
            this.SuspendLayout();
            // 
            // LDetallesBackup
            // 
            this.LDetallesBackup.AutoSize = true;
            this.LDetallesBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetallesBackup.Location = new System.Drawing.Point(42, 28);
            this.LDetallesBackup.Name = "LDetallesBackup";
            this.LDetallesBackup.Size = new System.Drawing.Size(105, 31);
            this.LDetallesBackup.TabIndex = 1;
            this.LDetallesBackup.Text = "Backup";
            this.LDetallesBackup.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta a guardar:";
            // 
            // CB_BDD
            // 
            this.CB_BDD.FormattingEnabled = true;
            this.CB_BDD.Location = new System.Drawing.Point(139, 103);
            this.CB_BDD.Name = "CB_BDD";
            this.CB_BDD.Size = new System.Drawing.Size(183, 21);
            this.CB_BDD.TabIndex = 4;
            // 
            // BConectar
            // 
            this.BConectar.Location = new System.Drawing.Point(367, 100);
            this.BConectar.Name = "BConectar";
            this.BConectar.Size = new System.Drawing.Size(75, 23);
            this.BConectar.TabIndex = 5;
            this.BConectar.Text = "Conectar";
            this.BConectar.UseVisualStyleBackColor = true;
            // 
            // frmBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 518);
            this.Controls.Add(this.BConectar);
            this.Controls.Add(this.CB_BDD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LDetallesBackup);
            this.Name = "frmBackUp";
            this.Text = "frmBackUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDetallesBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_BDD;
        private System.Windows.Forms.Button BConectar;
    }
}