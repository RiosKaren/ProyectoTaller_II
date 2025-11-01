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

        private bool _esNotaCredito;
        private decimal _importeTotalFactura;

        public void Cargar(int idFactura)
        {
            _idFactura = idFactura;

            DataSet ds = new CN_Venta().ObtenerVentaDS(idFactura);
            if (ds.Tables["Cabecera"].Rows.Count == 0)
            {
                MessageBox.Show("No se encontró la venta.");
                return;
            }

            var h = ds.Tables["Cabecera"].Rows[0];

            textBoxNroFactura.Text = Convert.ToString(h["nro_factura"]);
            textBoxFecha.Text = Convert.ToDateTime(h["fecha"]).ToString("dd/MM/yyyy HH:mm");
            textBoxVendedor.Text = Convert.ToString(h["vendedor"]);
            textBoxDNI.Text = Convert.ToString(h["dni"]);
            textBoxNombreCliente.Text = Convert.ToString(h["cliente"]);
            textBoxCorreo.Text = Convert.ToString(h["email"]);
            textBoxTelefono.Text = Convert.ToString(h["telefono"]);

            _importeTotalFactura = 0m;
            if (h["importe_total"] != DBNull.Value)
                _importeTotalFactura = Convert.ToDecimal(h["importe_total"]);
            textBoxMontoTotal.Text = _importeTotalFactura.ToString("0.00");

            // NC
            _esNotaCredito = _importeTotalFactura < 0m;
            if (!_esNotaCredito && ds.Tables["Cabecera"].Columns.Contains("id_factura_origen"))
                _esNotaCredito = h["id_factura_origen"] != DBNull.Value;

            // Detalle (solo visual)
            VerProductosDGV.Rows.Clear();
            var dtDet = ds.Tables["Detalle"];
            if (dtDet != null)
            {
                foreach (DataRow r in dtDet.Rows)
                {
                    VerProductosDGV.Rows.Add(
                        Convert.ToString(r["id_producto"]),
                        Convert.ToString(r["producto"]),
                        Convert.ToString(r["id_talle"]),
                        Convert.ToString(r["talla"]),
                        Convert.ToDecimal(r["precio_unitario"]).ToString("0.00"),
                        Convert.ToInt32(r["cantidad"]),
                        Convert.ToDecimal(r["subtotal"]).ToString("0.00")
                    );
                }
            }
            VerProductosDGV.ClearSelection();
        }


        private int ParsePuntoVentaDesdeNroFactura()
        {
            var txt = textBoxNroFactura.Text?.Trim(); // "A 0001-00000001"
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

        private void iconButtonDevolucion_Click(object sender, EventArgs e)
        {
            if (_esNotaCredito)
            {
                MessageBox.Show(
                    "No se puede realizar una devolución sobre una Nota de Crédito (ya es una devolución).",
                    "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }

            // Confirmación
            var resp = MessageBox.Show(
                this,
                "¿Seguro que querés realizar la devolución de la factura completa?",
                "Confirmar devolución total",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );
            if (resp != DialogResult.Yes) return;

            int puntoVenta = ParsePuntoVentaDesdeNroFactura();
            int idUsuarioActual = _idUsuarioActual;

            var cn = new CapaNegocio.CN_Venta();
            bool ok = cn.RegistrarDevolucionTotal(
                puntoVenta,
                _idFactura,
                idUsuarioActual,
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
                $"Devolución registrada.\nNota de crédito: {nroNC}.\nMonto a restar: -${_importeTotalFactura:0.00}",
                "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            this.DialogResult = DialogResult.OK; //refresca el grid
            this.Close();
        }

        private void iconButtonPDF_Click(object sender, EventArgs e)
        {

        }
    }
}
