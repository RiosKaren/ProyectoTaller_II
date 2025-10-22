using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmVerVentas : Form
    {
        public FrmVerVentas()
        {
            InitializeComponent();
        }

        private void FrmVerVentas_Load(object sender, EventArgs e)
        {
            // llenar combo de búsqueda
            comboBoxBusqueda.Items.Clear();
            comboBoxBusqueda.Items.Add(new OpcionCombo { Valor = "id_factura", Texto = "N° Factura" });
            comboBoxBusqueda.Items.Add(new OpcionCombo { Valor = "dni", Texto = "DNI Cliente" });
            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";
            comboBoxBusqueda.SelectedIndex = 0; 
            
            // limpiar y cargar ventas
            VentasDGV.Rows.Clear();

            List<Factura> listaVentas = new CN_Venta().ListarVentas();

            foreach (Factura f in listaVentas)
            {
                VentasDGV.Rows.Add(new object[]
                {
                    f.id_factura,
                    f.fecha.ToString("dd/MM/yyyy HH:mm:ss"),
                    f.id_cliente,
                    f.id_cliente.dni,
                    f.importe_total.ToString("0.00")
                });
            }

            VentasDGV.ClearSelection();
        }


        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBusqueda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un campo para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxBusqueda.Text))
            {
                MessageBox.Show("Ingrese un texto para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string columnaFiltro = ((OpcionCombo)comboBoxBusqueda.SelectedItem).Valor.ToString();
            string textoBuscado = RemoverAcentos(textBoxBusqueda.Text.Trim().ToUpper());

            foreach (DataGridViewRow row in VentasDGV.Rows)
            {
                if (row.Cells[columnaFiltro].Value != null)
                {
                    string valorCelda = RemoverAcentos(row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper());

                    if (valorCelda.Contains(textoBuscado))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private string RemoverAcentos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            // Normaliza los caracteres a su forma base
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in textoNormalizado)
            {
                UnicodeCategory categoria = CharUnicodeInfo.GetUnicodeCategory(c);
                if (categoria != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        private void iconButtonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Text = "";
            foreach (DataGridViewRow row in VentasDGV.Rows)
            {
                row.Visible = true;
            }
        }




    }
}
