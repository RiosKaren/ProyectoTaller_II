namespace CapaPresentacion
{
    partial class frmReportes
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
            this.PGenerar = new System.Windows.Forms.Panel();
            this.BGenerarReporte = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.LVendedor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LHasta = new System.Windows.Forms.Label();
            this.DTPReporteHasta = new System.Windows.Forms.DateTimePicker();
            this.DTPReporteDesde = new System.Windows.Forms.DateTimePicker();
            this.LDesde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LElegirFechas = new System.Windows.Forms.Label();
            this.BTotalVentas = new System.Windows.Forms.Button();
            this.BProductosMasVendidos = new System.Windows.Forms.Button();
            this.BRecaudacion = new System.Windows.Forms.Button();
            this.LGenerarReporte = new System.Windows.Forms.Label();
            this.PanelGenerarReporte = new System.Windows.Forms.Panel();
            this.PGenerar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelGenerarReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // PGenerar
            // 
            this.PGenerar.BackColor = System.Drawing.Color.DarkRed;
            this.PGenerar.Controls.Add(this.BGenerarReporte);
            this.PGenerar.Controls.Add(this.comboBox1);
            this.PGenerar.Controls.Add(this.bBuscar);
            this.PGenerar.Controls.Add(this.LVendedor);
            this.PGenerar.Location = new System.Drawing.Point(0, 320);
            this.PGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PGenerar.Name = "PGenerar";
            this.PGenerar.Size = new System.Drawing.Size(1580, 354);
            this.PGenerar.TabIndex = 6;
            // 
            // BGenerarReporte
            // 
            this.BGenerarReporte.Location = new System.Drawing.Point(1284, 263);
            this.BGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BGenerarReporte.Name = "BGenerarReporte";
            this.BGenerarReporte.Size = new System.Drawing.Size(250, 55);
            this.BGenerarReporte.TabIndex = 13;
            this.BGenerarReporte.Text = "Generar Reporte";
            this.BGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(264, 137);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(375, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(664, 137);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(100, 28);
            this.bBuscar.TabIndex = 11;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // LVendedor
            // 
            this.LVendedor.AutoSize = true;
            this.LVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVendedor.ForeColor = System.Drawing.Color.White;
            this.LVendedor.Location = new System.Drawing.Point(260, 91);
            this.LVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LVendedor.Name = "LVendedor";
            this.LVendedor.Size = new System.Drawing.Size(78, 17);
            this.LVendedor.TabIndex = 10;
            this.LVendedor.Text = "Vendedor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.LHasta);
            this.panel2.Controls.Add(this.DTPReporteHasta);
            this.panel2.Controls.Add(this.DTPReporteDesde);
            this.panel2.Controls.Add(this.LDesde);
            this.panel2.Location = new System.Drawing.Point(41, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 127);
            this.panel2.TabIndex = 10;
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.ForeColor = System.Drawing.Color.White;
            this.LHasta.Location = new System.Drawing.Point(272, 22);
            this.LHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(46, 16);
            this.LHasta.TabIndex = 5;
            this.LHasta.Text = "Hasta:";
            // 
            // DTPReporteHasta
            // 
            this.DTPReporteHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPReporteHasta.Location = new System.Drawing.Point(276, 55);
            this.DTPReporteHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPReporteHasta.Name = "DTPReporteHasta";
            this.DTPReporteHasta.Size = new System.Drawing.Size(175, 22);
            this.DTPReporteHasta.TabIndex = 3;
            // 
            // DTPReporteDesde
            // 
            this.DTPReporteDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPReporteDesde.Location = new System.Drawing.Point(28, 55);
            this.DTPReporteDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPReporteDesde.Name = "DTPReporteDesde";
            this.DTPReporteDesde.Size = new System.Drawing.Size(179, 22);
            this.DTPReporteDesde.TabIndex = 3;
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.ForeColor = System.Drawing.Color.White;
            this.LDesde.Location = new System.Drawing.Point(24, 22);
            this.LDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(51, 16);
            this.LDesde.TabIndex = 4;
            this.LDesde.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(713, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reportes";
            // 
            // LElegirFechas
            // 
            this.LElegirFechas.AutoSize = true;
            this.LElegirFechas.ForeColor = System.Drawing.Color.Black;
            this.LElegirFechas.Location = new System.Drawing.Point(37, 76);
            this.LElegirFechas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LElegirFechas.Name = "LElegirFechas";
            this.LElegirFechas.Size = new System.Drawing.Size(90, 16);
            this.LElegirFechas.TabIndex = 9;
            this.LElegirFechas.Text = "Elegir Fechas";
            // 
            // BTotalVentas
            // 
            this.BTotalVentas.Location = new System.Drawing.Point(435, 52);
            this.BTotalVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTotalVentas.Name = "BTotalVentas";
            this.BTotalVentas.Size = new System.Drawing.Size(193, 52);
            this.BTotalVentas.TabIndex = 11;
            this.BTotalVentas.Text = "Total Ventas";
            this.BTotalVentas.UseVisualStyleBackColor = true;
            // 
            // BProductosMasVendidos
            // 
            this.BProductosMasVendidos.Location = new System.Drawing.Point(224, 52);
            this.BProductosMasVendidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BProductosMasVendidos.Name = "BProductosMasVendidos";
            this.BProductosMasVendidos.Size = new System.Drawing.Size(188, 52);
            this.BProductosMasVendidos.TabIndex = 12;
            this.BProductosMasVendidos.Text = "Productos mas vendidos";
            this.BProductosMasVendidos.UseVisualStyleBackColor = true;
            // 
            // BRecaudacion
            // 
            this.BRecaudacion.Location = new System.Drawing.Point(13, 52);
            this.BRecaudacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BRecaudacion.Name = "BRecaudacion";
            this.BRecaudacion.Size = new System.Drawing.Size(191, 52);
            this.BRecaudacion.TabIndex = 13;
            this.BRecaudacion.Text = "Recaudacion";
            this.BRecaudacion.UseVisualStyleBackColor = true;
            // 
            // LGenerarReporte
            // 
            this.LGenerarReporte.AutoSize = true;
            this.LGenerarReporte.ForeColor = System.Drawing.Color.Black;
            this.LGenerarReporte.Location = new System.Drawing.Point(17, 17);
            this.LGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LGenerarReporte.Name = "LGenerarReporte";
            this.LGenerarReporte.Size = new System.Drawing.Size(128, 16);
            this.LGenerarReporte.TabIndex = 14;
            this.LGenerarReporte.Text = "Generar reporte por:";
            // 
            // PanelGenerarReporte
            // 
            this.PanelGenerarReporte.Controls.Add(this.BRecaudacion);
            this.PanelGenerarReporte.Controls.Add(this.LGenerarReporte);
            this.PanelGenerarReporte.Controls.Add(this.BTotalVentas);
            this.PanelGenerarReporte.Controls.Add(this.BProductosMasVendidos);
            this.PanelGenerarReporte.Location = new System.Drawing.Point(664, 114);
            this.PanelGenerarReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelGenerarReporte.Name = "PanelGenerarReporte";
            this.PanelGenerarReporte.Size = new System.Drawing.Size(644, 123);
            this.PanelGenerarReporte.TabIndex = 15;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1579, 669);
            this.Controls.Add(this.PanelGenerarReporte);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LElegirFechas);
            this.Controls.Add(this.PGenerar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.PGenerar.ResumeLayout(false);
            this.PGenerar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelGenerarReporte.ResumeLayout(false);
            this.PanelGenerarReporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PGenerar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.DateTimePicker DTPReporteHasta;
        private System.Windows.Forms.DateTimePicker DTPReporteDesde;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LElegirFechas;
        private System.Windows.Forms.Label LVendedor;
        private System.Windows.Forms.Button BTotalVentas;
        private System.Windows.Forms.Button BProductosMasVendidos;
        private System.Windows.Forms.Button BRecaudacion;
        private System.Windows.Forms.Button BGenerarReporte;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label LGenerarReporte;
        private System.Windows.Forms.Panel PanelGenerarReporte;
    }
}