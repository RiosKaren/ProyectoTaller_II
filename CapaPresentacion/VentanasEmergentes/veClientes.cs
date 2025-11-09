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

namespace CapaPresentacion.VentanasEmergentes
{
    public partial class veClientes : Form
    {
        public Clientes _Cliente { get; set; }

        public veClientes()
        {
            InitializeComponent();
        }

        private void veCliente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in ClientesDGV.Columns)
            {
                if (columna.Visible == true)
                {
                    comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";

            ClientesDGV.Rows.Clear();

            List<Clientes> listaClientes = new CN_Cliente().ListarActivos();

            foreach (Clientes item in listaClientes)
            {
                ClientesDGV.Rows.Add(new object[]
                {
                    item.id_cliente, item.dni, item.apellido, item.nombre, item.activo
                });
            }


        }

        private void ClientesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;  
            int iColum = e.ColumnIndex;

            if(iRow >= 0 && iColum > 0)
            {
                _Cliente = new Clientes()
                {
                    id_cliente = Convert.ToInt32(ClientesDGV.Rows[iRow].Cells["id_cliente"].Value),
                    dni = Convert.ToInt32(ClientesDGV.Rows[iRow].Cells["dni"].Value),
                    apellido = ClientesDGV.Rows[iRow].Cells["apellido"].Value.ToString(),
                    nombre = ClientesDGV.Rows[iRow].Cells["nombre"].Value.ToString(),
                    activo = Convert.ToBoolean(ClientesDGV.Rows[iRow].Cells["activo"].Value)
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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

            foreach (DataGridViewRow row in ClientesDGV.Rows)
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
            foreach (DataGridViewRow row in ClientesDGV.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            using (var ven = new veAgregarCliente())
            {
                var r = ven.ShowDialog(this);
                if (r == DialogResult.OK && ven.ClienteCreado != null)
                {
                    _Cliente = ven.ClienteCreado;     
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
