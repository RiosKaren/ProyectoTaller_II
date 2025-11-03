using System;
using System.Data;
using System.IO;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace CapaPresentacion.Utilidades
{
    public static class PdfReporte
    {
        public static string GenerarDesdeDataTable(
            DataTable dt,
            string titulo = "Reporte",
            string carpetaDestino = null,
            byte[] grafico = null,
            string subtitulo = null)
        {
            if (dt == null)
                throw new ArgumentNullException(nameof(dt), "El DataTable viene nulo.");

            // carpeta destino
            if (string.IsNullOrWhiteSpace(carpetaDestino))
            {
                var docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                carpetaDestino = Path.Combine(docs, "Reportes");
            }
            if (!Directory.Exists(carpetaDestino))
                Directory.CreateDirectory(carpetaDestino);

            string nombreArchivo = $"{SanearNombre(titulo)}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string rutaFinal = Path.Combine(carpetaDestino, nombreArchivo);

            // ===== documento =====
            var doc = new Document();
            doc.Info.Title = titulo;

            // estilo base
            var normal = doc.Styles["Normal"];
            normal.Font.Name = "Arial";
            normal.Font.Size = 9;

            // ===== sección =====
            var section = doc.AddSection();
            section.PageSetup.LeftMargin = Unit.FromCentimeter(1.5);
            section.PageSetup.RightMargin = Unit.FromCentimeter(1.5);
            section.PageSetup.TopMargin = Unit.FromCentimeter(1.5);
            section.PageSetup.BottomMargin = Unit.FromCentimeter(1.5);

            // pie
            var footer = section.Footers.Primary.AddParagraph();
            footer.Format.Alignment = ParagraphAlignment.Right;
            footer.AddText("Página ");
            footer.AddPageField();
            footer.AddText(" de ");
            footer.AddNumPagesField();

            // si hay muchas columnas -> horizontal
            if (dt.Columns.Count > 6)
                section.PageSetup.Orientation = Orientation.Landscape;

            // ancho útil (lo usamos para el gráfico y para la tabla contenedora)
            Unit anchoUtil = section.PageSetup.PageWidth
                                - section.PageSetup.LeftMargin
                                - section.PageSetup.RightMargin;

            // ===== cabecera =====
            var pTitulo = section.AddParagraph(titulo);
            pTitulo.Format.Alignment = ParagraphAlignment.Center;
            pTitulo.Format.Font.Size = 16;
            pTitulo.Format.Font.Bold = true;
            pTitulo.Format.SpaceAfter = Unit.FromCentimeter(0.25);

            if (!string.IsNullOrWhiteSpace(subtitulo))
            {
                var pSub = section.AddParagraph(subtitulo);
                pSub.Format.Alignment = ParagraphAlignment.Center;
                pSub.Format.Font.Size = 9;
                pSub.Format.Font.Color = Colors.Gray;
                pSub.Format.SpaceAfter = Unit.FromCentimeter(0.2);
            }

            var pFecha = section.AddParagraph("Generado: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            pFecha.Format.Alignment = ParagraphAlignment.Right;
            pFecha.Format.Font.Size = 8;
            pFecha.Format.Font.Color = Colors.Gray;
            pFecha.Format.SpaceAfter = Unit.FromCentimeter(0.4);

            // =================================================================
            // 1) TABLA CONTENEDORA (para centrar)
            // =================================================================
            var cont = section.AddTable();
            cont.Borders.Visible = false;
            cont.AddColumn(anchoUtil); // ocupa todo el ancho útil

            var filaCont = cont.AddRow();
            var celdaCont = filaCont.Cells[0];
            celdaCont.Format.Alignment = ParagraphAlignment.Center; // lo que metas adentro queda centrado

            // =================================================================
            // 2) TABLA REAL (dentro del contenedor)
            // =================================================================
            var table = celdaCont.Elements.AddTable();
            table.Borders.Width = 0.5;

            // ======= AQUÍ CAMBIAMOS EL REPARTO DE ANCHO =======
            double anchoUtilCm = anchoUtil.Centimeter;

            bool esRecaudacionClasica =
                dt.Columns.Count == 5 &&
                dt.Columns[0].ColumnName.Equals("fecha", StringComparison.OrdinalIgnoreCase) &&
                dt.Columns[1].ColumnName.Equals("nro_factura", StringComparison.OrdinalIgnoreCase);

            bool esProductosMasVendidos =
                dt.Columns.Count >= 3 &&
                dt.Columns[0].ColumnName.Equals("codigo", StringComparison.OrdinalIgnoreCase) &&
                dt.Columns[1].ColumnName.Equals("nombre", StringComparison.OrdinalIgnoreCase);

            bool[] esNumero = new bool[dt.Columns.Count];
            bool[] esFecha = new bool[dt.Columns.Count];

            if (esRecaudacionClasica)
            {
                // Recaudación: fecha, nro_factura, vendedor, cliente, Importe
                table.AddColumn(Unit.FromCentimeter(3.0)); // fecha
                table.AddColumn(Unit.FromCentimeter(3.5)); // nro_factura
                table.AddColumn(Unit.FromCentimeter(3.5)); // vendedor
                table.AddColumn(Unit.FromCentimeter(4.5)); // cliente

                double usados = 3.0 + 3.5 + 3.5 + 4.5;
                double resto = Math.Max(2.3, anchoUtilCm - usados);
                table.AddColumn(Unit.FromCentimeter(resto)); // Importe total

                // marcamos tipos
                esFecha[0] = true;
                esNumero[4] = true;
            }
            else if (esProductosMasVendidos)
            {
                // Productos más vendidos: código, nombre, total_cantidad, total_importe
                table.AddColumn(Unit.FromCentimeter(3.0));  // código
                table.AddColumn(Unit.FromCentimeter(6.0));  // nombre
                table.AddColumn(Unit.FromCentimeter(3.0));  // cantidad
                double usados = 3.0 + 6.0 + 3.0;
                double resto = Math.Max(2.5, anchoUtilCm - usados);
                table.AddColumn(Unit.FromCentimeter(resto)); // importe

                esNumero[2] = true;
                esNumero[3] = true;
            }
            else
            {
                // modo genérico (lo de siempre)
                double anchoColCm = Math.Max(2.0, anchoUtilCm / Math.Max(1, dt.Columns.Count));

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    var col = dt.Columns[i];
                    var c = table.AddColumn(Unit.FromCentimeter(anchoColCm));

                    if (EsNumero(col.DataType))
                    {
                        esNumero[i] = true;
                        c.Format.Alignment = ParagraphAlignment.Right;
                    }
                    else if (col.DataType == typeof(DateTime))
                    {
                        esFecha[i] = true;
                        c.Format.Alignment = ParagraphAlignment.Center;
                    }
                    else
                    {
                        c.Format.Alignment = ParagraphAlignment.Left;
                    }
                }
            }

            // encabezado
            var header = table.AddRow();
            header.HeadingFormat = true;
            header.Shading.Color = Colors.LightGray;
            header.Format.Font.Bold = true;
            header.Format.Alignment = ParagraphAlignment.Center;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string nombreCol = EmbellecerNombreColumna(dt.Columns[i].ColumnName);
                header.Cells[i].AddParagraph(nombreCol);
            }

            // filas
            int fila = 0;
            foreach (DataRow row in dt.Rows)
            {
                var r = table.AddRow();
                if (fila++ % 2 == 1)
                    r.Shading.Color = Colors.WhiteSmoke;

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string texto;
                    if (esNumero[i])
                    {
                        // Verificar si es una columna de importe (NO cantidad)
                        string nombreCol = dt.Columns[i].ColumnName.ToLower();
                        bool esCantidad = nombreCol.Contains("cantidad") || nombreCol.Equals("total_cantidad");

                        if (esCantidad)
                        {
                            // Sin signo $ para cantidades
                            texto = FormatearNumero(row[i], false);
                        }
                        else
                        {
                            // Con signo $ para importes
                            texto = FormatearNumero(row[i], true);
                        }
                    }
                    else if (esFecha[i]) texto = FormatearFecha(row[i]);
                    else texto = Convert.ToString(row[i]);

                    r.Cells[i].AddParagraph(texto);
                }
            }

            // ===== gráfico centrado =====
            if (grafico != null && grafico.Length > 0)
            {
                var tGraf = section.AddParagraph("Gráfico");
                tGraf.Format.Alignment = ParagraphAlignment.Center;
                tGraf.Format.Font.Bold = true;
                tGraf.Format.SpaceBefore = Unit.FromCentimeter(0.5);
                tGraf.Format.SpaceAfter = Unit.FromCentimeter(0.2);

                string tmpImg = GuardarTemporalImagen(grafico);

                var pImg = section.AddParagraph();
                pImg.Format.Alignment = ParagraphAlignment.Center;

                var img = pImg.AddImage(tmpImg);
                img.LockAspectRatio = true;
                img.Width = Unit.FromCentimeter(16);
            }

            // ===== render =====
            var renderer = new PdfDocumentRenderer(unicode: true)
            {
                Document = doc
            };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(rutaFinal);

            return rutaFinal;
        }

        // helpers
        private static bool EsNumero(Type t) =>
            t == typeof(int) || t == typeof(long) || t == typeof(decimal) ||
            t == typeof(double) || t == typeof(float);

        private static string FormatearNumero(object o, bool agregarSignoPeso = true)
        {
            if (o == null || o == DBNull.Value) return "";
            if (o is IFormattable f)
            {
                string valor = f.ToString("#,0.##", System.Globalization.CultureInfo.InvariantCulture)
                                .Replace(".", ",");
                return agregarSignoPeso ? "$ " + valor : valor;
            }
            return Convert.ToString(o);
        }

        private static string FormatearFecha(object o)
        {
            if (o == null || o == DBNull.Value) return "";
            if (DateTime.TryParse(Convert.ToString(o), out var d))
                return d.ToString("dd/MM/yyyy HH:mm");
            return Convert.ToString(o);
        }

        private static string EmbellecerNombreColumna(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return nombre;

            // Casos especiales primero
            if (string.Equals(nombre, "nro_factura", StringComparison.OrdinalIgnoreCase))
                return "Nro. Factura";
            if (string.Equals(nombre, "importe_total", StringComparison.OrdinalIgnoreCase))
                return "Importe Total";
            if (string.Equals(nombre, "total_importe", StringComparison.OrdinalIgnoreCase))
                return "Importe Total";
            if (string.Equals(nombre, "total_cantidad", StringComparison.OrdinalIgnoreCase))
                return "Cantidad";

            // Capitalizar primera letra de cada palabra
            var palabras = nombre.Split('_');
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 0)
                {
                    palabras[i] = char.ToUpper(palabras[i][0]) +
                                  (palabras[i].Length > 1 ? palabras[i].Substring(1).ToLower() : "");
                }
            }

            return string.Join(" ", palabras);
        }

        private static string SanearNombre(string s)
        {
            foreach (var c in Path.GetInvalidFileNameChars())
                s = s.Replace(c, '_');
            return s.Replace(' ', '_');
        }

        private static string GuardarTemporalImagen(byte[] bytes)
        {
            string path = Path.Combine(Path.GetTempPath(), "graf_" + Guid.NewGuid().ToString("N") + ".png");
            File.WriteAllBytes(path, bytes);
            return path;
        }
    }
}