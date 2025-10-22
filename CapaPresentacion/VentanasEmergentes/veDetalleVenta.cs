using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class veDetalleVenta : Form
    {
        private int _idFactura;
        private int _idUsuarioActual;
        public veDetalleVenta(int idUsuarioActual = 0)
        {
            _idUsuarioActual = idUsuarioActual;
            InitializeComponent();
            VerProductosDGV.MultiSelect = true;
            VerProductosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VerProductosDGV.ReadOnly = true;

        }

        private void frmVerDetalle_Load(object sender, EventArgs e)
        {

        }

        private bool _esNotaCredito;

        public void Cargar(int idFactura)
        {
            _idFactura = idFactura;

            DataSet ds = new CN_Venta().ObtenerVentaDS(idFactura); // ya lo tenés
            if (ds.Tables["Cabecera"].Rows.Count == 0)
            {
                MessageBox.Show("No se encontró la venta.");
                return;
            }

            var h = ds.Tables["Cabecera"].Rows[0];
            textBoxNroFactura.Text = h["nro_factura"].ToString(); // "A 0001-00000001"
            textBoxFecha.Text = Convert.ToDateTime(h["fecha"]).ToString("dd/MM/yyyy HH:mm");
            textBoxVendedor.Text = h["vendedor"].ToString();
            textBoxDNI.Text = h["dni"].ToString();
            textBoxNombreCliente.Text = h["cliente"].ToString();
            textBoxCorreo.Text = h["email"].ToString();
            textBoxTelefono.Text = h["telefono"].ToString();

            decimal importeTotal = 0m;
            if (h["importe_total"] != DBNull.Value)
                importeTotal = Convert.ToDecimal(h["importe_total"]);
            textBoxMontoTotal.Text = importeTotal.ToString("0.00");

            // es una Nota de Crédito (ya es devolución)
            _esNotaCredito = importeTotal < 0m;
            if (!_esNotaCredito && ds.Tables["Cabecera"].Columns.Contains("id_factura_origen"))
                _esNotaCredito = h["id_factura_origen"] != DBNull.Value;

            //Detalle
            VerProductosDGV.Rows.Clear();
            foreach (DataRow r in ds.Tables["Detalle"].Rows)
            {
                VerProductosDGV.Rows.Add(
                    r["id_producto"].ToString(),
                    r["producto"].ToString(),
                    r["id_talle"].ToString(),
                    r["talla"].ToString(),
                    Convert.ToDecimal(r["precio_unitario"]).ToString("0.00"),
                    Convert.ToInt32(r["cantidad"]),
                    Convert.ToDecimal(r["subtotal"]).ToString("0.00")
                );
            }
            VerProductosDGV.ClearSelection();
        }

        private int ParsePuntoVentaDesdeNroFactura()
        {
            var txt = textBoxNroFactura.Text?.Trim();
            if (string.IsNullOrEmpty(txt)) return 1;
            int sp = txt.IndexOf(' ');
            int guion = txt.IndexOf('-');
            if (sp >= 0 && guion > sp)
            {
                var pvStr = txt.Substring(sp + 1, guion - (sp + 1));
                if (int.TryParse(pvStr, out int pv)) return pv;
            }
            return 1;
        }

        private int PedirCantidad(int max)
        {
            using (var f = new Form())
            using (var nud = new NumericUpDown())
            using (var ok = new Button())
            using (var cancel = new Button())
            {
                f.Text = "Cantidad a devolver";
                f.FormBorderStyle = FormBorderStyle.FixedDialog;
                f.StartPosition = FormStartPosition.CenterParent;
                f.ClientSize = new System.Drawing.Size(240, 95);
                f.MinimizeBox = false; f.MaximizeBox = false; f.ShowInTaskbar = false;

                var lbl = new Label() { Text = $"Máximo {max}", AutoSize = true, Left = 12, Top = 10 };
                nud.Left = 12; nud.Top = 30; nud.Width = 100;
                nud.Minimum = 1; nud.Maximum = max; nud.Value = 1;

                ok.Text = "OK"; ok.Left = 130; ok.Top = 25; ok.DialogResult = DialogResult.OK;
                cancel.Text = "Cancelar"; cancel.Left = 130; cancel.Top = 55; cancel.DialogResult = DialogResult.Cancel;

                f.Controls.Add(lbl); f.Controls.Add(nud); f.Controls.Add(ok); f.Controls.Add(cancel);
                f.AcceptButton = ok; f.CancelButton = cancel;

                return f.ShowDialog(this) == DialogResult.OK ? (int)nud.Value : 0;
            }
        }

        private void iconButtonDevolucion_Click(object sender, EventArgs e)
        {
            if (_esNotaCredito)
            {
                MessageBox.Show(
                    "No se puede realizar una devolución sobre una Nota de Crédito.",
                    "Devolución",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // Debe haber filas seleccionadas
            if (VerProductosDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná uno o más renglones para devolver.", "Devolución",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // confirmacion previa
            var resp = MessageBox.Show(
                this,
                "¿Desea realizar la devolución del producto seleccionado?",
                "Confirmar devolución",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );
            if (resp != DialogResult.Yes) return;


            var dt = CapaDatos.CD_Venta.NuevaTablaDevolucion();
            decimal totalADevolver = 0m;

            foreach (DataGridViewRow row in VerProductosDGV.SelectedRows)
            {
                int idTalle = Convert.ToInt32(row.Cells["id_talle"].Value);
                int cantVendida = Convert.ToInt32(row.Cells["cantidad"].Value);
                decimal precio = Convert.ToDecimal(row.Cells["precio_unitario"].Value);

                int cantDev = 1;
                if (cantVendida > 1)
                {
                    cantDev = PedirCantidad(cantVendida);
                    if (cantDev == 0) continue;
                }

                dt.Rows.Add(idTalle, cantDev);
                totalADevolver += (precio * cantDev);
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se seleccionó ninguna cantidad válida.", "Devolución",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int puntoVenta = ParsePuntoVentaDesdeNroFactura();
            int idUsuarioActual = _idUsuarioActual;

            var cn = new CapaNegocio.CN_Venta();
            bool ok = cn.RegistrarDevolucion(
                puntoVenta,
                _idFactura,
                idUsuarioActual,
                dt,
                out int idFacturaNC,
                out string nroNC,
                out string mensaje
            );

            if (!ok)
            {
                MessageBox.Show("No se pudo registrar la devolución.\n" + mensaje,
                    "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(
                $"Devolución registrada.\nNota de crédito: {nroNC}\nMonto a restar: -${totalADevolver:0.00}",
                "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            this.DialogResult = DialogResult.OK; 
            this.Close();

        }

        private void iconButtonPDF_Click(object sender, EventArgs e)
        {

        }
    }
}
