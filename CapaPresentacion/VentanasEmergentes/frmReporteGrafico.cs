using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.VentanasEmergentes
{
    public partial class frmReporteGrafico : Form
    {
        public frmReporteGrafico()
        {
            InitializeComponent();
        }

        // CARGA DEL GRÁFICO
        public void Cargar(DataTable dt, string titulo)
        {
            Text = "Gráfico - " + titulo;

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            var area = new ChartArea("main");
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart1.ChartAreas.Add(area);

            chart1.Titles.Add(titulo);

            var t = (titulo ?? "").ToUpperInvariant();

            if (t.Contains("PRODUCTO"))
            {
                GraficoProductosMasVendidos(dt);
            }
            else if (t.Contains("TOTAL"))
            {
                GraficoTotalVentas(dt);
            }
            else if (t.Contains("RECAUD"))
            {
                GraficoRecaudacion(dt);
            }
            else
            {
                GraficoGenerico(dt);
            }
        }

        private void GraficoProductosMasVendidos(DataTable dt)
        {
            string colNombre = Col(dt, "nombre");
            string colCant = Col(dt, "total_cantidad");

            var s = new Series("Ventas")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "main",
                IsValueShownAsLabel = true
            };

            foreach (DataRow r in dt.Rows.Cast<DataRow>()
                                          .OrderByDescending(r => ToInt(r[colCant]))
                                          .Take(10))
            {
                s.Points.AddXY(Convert.ToString(r[colNombre]), ToInt(r[colCant]));
            }

            chart1.Series.Add(s);
        }

        private void GraficoTotalVentas(DataTable dt)
        {
            string colVend = Col(dt, "vendedor");
            string colVal =
                dt.Columns.Contains("total_facturado") ? "total_facturado" :
                dt.Columns.Contains("cant_ventas") ? "cant_ventas" :
                Col(dt, "total");

            var s = new Series("Total")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "main",
                IsValueShownAsLabel = true,
                Label = "#VALX\n#PERCENT{P0}"
            };

            foreach (DataRow r in dt.Rows)
            {
                double y = ToDouble(r[colVal]);
                if (y > 0)
                    s.Points.AddXY(Convert.ToString(r[colVend]), y);
            }

            chart1.Series.Add(s);
        }

        private void GraficoRecaudacion(DataTable dt)
        {
            string colFecha = Col(dt, "fecha");
            string colImporte = dt.Columns.Contains("importe_total")
                                ? "importe_total"
                                : Col(dt, "importe");

            var diario = dt.Rows.Cast<DataRow>()
                .GroupBy(r => ToDate(r[colFecha]).Date)
                .OrderBy(g => g.Key)
                .Select(g => new
                {
                    Fecha = g.Key,
                    Total = g.Sum(r => ToDouble(r[colImporte]))
                })
                .ToList();

            if (diario.Count == 0)
                return;

            bool usarColumn = diario.Count <= 1;

            var s = new Series(usarColumn ? "Recaudación" : "Recaudación diaria")
            {
                ChartType = usarColumn ? SeriesChartType.Column : SeriesChartType.Line,
                ChartArea = "main",
                IsValueShownAsLabel = true,
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                XValueType = ChartValueType.Date
            };

            foreach (var p in diario)
                s.Points.AddXY(p.Fecha, p.Total);

            chart1.Series.Add(s);

            var ax = chart1.ChartAreas["main"].AxisX;
            ax.LabelStyle.Format = "dd/MM";
            ax.MajorGrid.Enabled = false;

            var ay = chart1.ChartAreas["main"].AxisY;
            ay.Minimum = 0;
            ay.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
        }

        private void GraficoGenerico(DataTable dt)
        {
            if (dt.Columns.Count < 2)
                return;

            int colY = Enumerable.Range(0, dt.Columns.Count)
                                 .FirstOrDefault(i => EsNumero(dt.Columns[i].DataType));
            int colX = colY == 0 ? 1 : 0;

            var s = new Series("Datos")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "main",
                IsValueShownAsLabel = true
            };

            foreach (DataRow r in dt.Rows)
                s.Points.AddXY(Convert.ToString(r[colX]), ToDouble(r[colY]));

            chart1.Series.Add(s);
        }

        public byte[] ExportarComoImagen(int width = 2000, int height = 1100)
        {
            using (var bmp = new Bitmap(width, height))
            {
                chart1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

                using (var ms = new MemoryStream())
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }

        // helpers
        private static string Col(DataTable dt, string name)
        {
            var n = name.ToUpperInvariant();
            foreach (DataColumn c in dt.Columns)
            {
                var cn = c.ColumnName.ToUpperInvariant();
                if (cn == n || cn.Contains(n))
                    return c.ColumnName;
            }
            return dt.Columns[0].ColumnName;
        }

        private static bool EsNumero(Type t) =>
            t == typeof(int) || t == typeof(long) || t == typeof(decimal) ||
            t == typeof(double) || t == typeof(float);

        private static int ToInt(object o)
        {
            int.TryParse(Convert.ToString(o), out int v);
            return v;
        }

        private static double ToDouble(object o)
        {
            double.TryParse(Convert.ToString(o), out double v);
            return v;
        }

        private static DateTime ToDate(object o)
        {
            DateTime.TryParse(Convert.ToString(o), out DateTime d);
            return d;
        }

    }
}
