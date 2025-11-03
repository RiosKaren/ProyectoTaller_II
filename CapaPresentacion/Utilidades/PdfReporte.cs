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
        // genera un pdf "genérico" con una tabla a partir de un DataTable
        public static string GenerarDesdeDataTable(
            DataTable dt,
            string titulo = "Reporte",
            string carpetaDestino = null)
        {
            if (dt == null)
                throw new ArgumentNullException(nameof(dt), "El DataTable viene nulo.");

            // carpeta por defecto: Mis documentos\Reportes
            if (string.IsNullOrWhiteSpace(carpetaDestino))
            {
                var docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                carpetaDestino = Path.Combine(docs, "Reportes");
            }

            if (!Directory.Exists(carpetaDestino))
                Directory.CreateDirectory(carpetaDestino);

            string nombreArchivo = $"{titulo.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string rutaFinal = Path.Combine(carpetaDestino, nombreArchivo);

            // 1) documento
            var doc = new Document();
            doc.Info.Title = titulo;

            var section = doc.AddSection();
            section.PageSetup.LeftMargin = Unit.FromCentimeter(1.5);
            section.PageSetup.RightMargin = Unit.FromCentimeter(1.5);

            // 2) título
            var p = section.AddParagraph(titulo);
            p.Format.Font.Size = 14;
            p.Format.Font.Bold = true;
            p.Format.SpaceAfter = Unit.FromCentimeter(0.4);

            // 3) fecha de generación
            var pinfo = section.AddParagraph("Generado: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            pinfo.Format.Font.Size = 8;
            pinfo.Format.SpaceAfter = Unit.FromCentimeter(0.4);

            // 4) tabla
            var table = section.AddTable();
            table.Borders.Width = 0.5;

            // ancho dinámico: 16 cm aprox dividido por cantidad de columnas
            double anchoCol = 16.0 / Math.Max(1, dt.Columns.Count);

            foreach (DataColumn col in dt.Columns)
            {
                var c = table.AddColumn(Unit.FromCentimeter(anchoCol));
                c.Format.Alignment = ParagraphAlignment.Left;
            }

            // encabezado
            var header = table.AddRow();
            header.HeadingFormat = true;
            header.Shading.Color = Colors.LightGray;
            header.Format.Font.Bold = true;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                header.Cells[i].AddParagraph(dt.Columns[i].ColumnName);
                header.Cells[i].Format.Alignment = ParagraphAlignment.Left;
            }

            // filas
            foreach (DataRow row in dt.Rows)
            {
                var r = table.AddRow();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    r.Cells[i].AddParagraph(Convert.ToString(row[i]));
                }
            }

            // 5) render
            var renderer = new PdfDocumentRenderer(true)
            {
                Document = doc
            };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(rutaFinal);

            return rutaFinal;
        }
    }
}
