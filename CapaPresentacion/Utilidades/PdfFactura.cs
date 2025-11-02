using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using MD = MigraDoc.DocumentObjectModel;

namespace CapaPresentacion.Utilidades
{
    public static class PdfFactura
    {
        public static string GenerarDesdeVentaDS(
            DataSet ds,
            decimal? ivaPorcentaje = null,
            string carpetaDestino = null,
            string nombreEmpresa = "Pluto Sneakers",
            string cuit = null,
            string leyendaContacto = "Por consultas sobre cambios escribinos por correo plutosneakers@gmail.com")
        {
            if (ds == null || ds.Tables["Cabecera"] == null || ds.Tables["Detalle"] == null)
                throw new InvalidOperationException("DS de factura inválido.");

            var h = ds.Tables["Cabecera"].Rows[0];

            string nro = Convert.ToString(h["nro_factura"]);
            DateTime fecha = Convert.ToDateTime(h["fecha"]);
            string vendedor = Convert.ToString(h["vendedor"]);
            string cliente = Convert.ToString(h["cliente"]);
            string dni = Convert.ToString(h["dni"]);
            string email = Convert.ToString(h["email"]);
            string telefono = Convert.ToString(h["telefono"]);
            decimal totalDb = Convert.ToDecimal(h["importe_total"]);
            bool esNC = totalDb < 0m;

            // Carpeta + archivo
            string carpeta = carpetaDestino ?? Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Facturas");
            Directory.CreateDirectory(carpeta);
            string ruta = Path.Combine(carpeta, nro.Replace(' ', '_') + ".pdf");

            // Documento
            var doc = new Document();
            doc.Info.Title = esNC ? $"Nota de Crédito {nro}" : $"Factura {nro}";

            var section = doc.AddSection();
            section.PageSetup.PageFormat = PageFormat.A4;
            section.PageSetup.TopMargin = "1.2cm";
            section.PageSetup.LeftMargin = "1.2cm";
            section.PageSetup.RightMargin = "1.2cm";
            section.PageSetup.BottomMargin = "1.2cm";

            // ENCABEZADO (3 columnas; caja "A/NC" centrada) ===
            // Total 17.5 cm para alinear con la grilla del detalle.
            var head = section.AddTable();
            head.Borders.Width = 0;
            head.Rows.LeftIndent = 0;

            head.AddColumn("7.75cm"); // izquierda (nombre)
            head.AddColumn("2.00cm"); // centro (caja A/NC) — 
            head.AddColumn("7.75cm"); // derecha (título + N°/Fecha [+ CUIT])  => 7.75+2+7.75 = 17.5

            var hr = head.AddRow();
            hr.Height = "1.40cm";
            hr.TopPadding = "0.05cm";
            hr.BottomPadding = "0.05cm";

            var pName = hr.Cells[0].AddParagraph(nombreEmpresa);
            pName.Format.Font.Size = 14;
            pName.Format.Font.Bold = true;

            // Centro: caja “A/NC” centrada
            var tf = hr.Cells[1].AddTextFrame();
            tf.Width = "1.60cm";
            tf.Height = "1.00cm";
            tf.Left = ShapePosition.Center;
            tf.Top = "0.20cm";               
            tf.LineFormat.Width = 1;
            tf.LineFormat.Color = MD.Colors.Black;
            var pTipo = tf.AddParagraph(esNC ? "NC" : "A");
            pTipo.Format.Alignment = ParagraphAlignment.Center;
            pTipo.Format.Font.Bold = true;
            pTipo.Format.Font.Size = 14;

            // Derecha: título + datos
            var pTit = hr.Cells[2].AddParagraph(esNC ? "Factura (NC)" : "Factura");
            pTit.Format.Alignment = ParagraphAlignment.Right;
            pTit.Format.Font.Size = 14;
            pTit.Format.Font.Bold = true;

            var pData = hr.Cells[2].AddParagraph();
            pData.Format.Alignment = ParagraphAlignment.Right;
            pData.AddFormattedText("N° Factura: ", TextFormat.Bold); pData.AddText(nro); pData.AddLineBreak();
            pData.AddFormattedText("Fecha: ", TextFormat.Bold); pData.AddText($"{fecha:dd/MM/yyyy HH:mm}");
            if (!string.IsNullOrWhiteSpace(cuit))
            {
                pData.AddLineBreak();
                pData.AddFormattedText("CUIT: ", TextFormat.Bold); pData.AddText(cuit);
            }

            section.AddParagraph().AddLineBreak();

            // DATOS DEL CLIENTE
            string rightColumnStart = "12.5cm";

            Paragraph p = section.AddParagraph();
            p.Format.TabStops.AddTabStop(rightColumnStart, TabAlignment.Left);
            p.AddFormattedText("Cliente: ", TextFormat.Bold); p.AddText(cliente);
            p.AddTab();
            p.AddFormattedText("DNI: ", TextFormat.Bold); p.AddText(dni);

            p = section.AddParagraph();
            p.Format.TabStops.AddTabStop(rightColumnStart, TabAlignment.Left);
            p.AddFormattedText("Domicilio: ", TextFormat.Bold); p.AddText(""); // no disponible en DS
            p.AddTab();
            p.AddFormattedText("Teléfono: ", TextFormat.Bold); p.AddText(telefono);

            p = section.AddParagraph();
            p.Format.TabStops.AddTabStop(rightColumnStart, TabAlignment.Left);
            p.AddText("");
            p.AddTab();
            p.AddFormattedText("Correo: ", TextFormat.Bold); p.AddText(email);

            var pVend = section.AddParagraph();
            pVend.AddFormattedText("Vendedor: ", TextFormat.Bold); pVend.AddText(vendedor);

            section.AddParagraph().AddLineBreak();

            // DETALLE
            var tbl = section.AddTable();
            tbl.Borders.Width = 0.5;
            tbl.Format.Font.Size = 10;

            // 2.2 + 2.0 + 8.3 + 2.3 + 2.7 = 17.5 cm
            tbl.AddColumn("2.20cm"); // Código
            tbl.AddColumn("2.00cm"); // Cantidad
            tbl.AddColumn("8.30cm"); // Descripción
            tbl.AddColumn("2.30cm"); // Precio Unitario
            tbl.AddColumn("2.70cm"); // Subtotal

            var th = tbl.AddRow();
            th.Shading.Color = MD.Colors.LightGray;
            th.Format.Font.Bold = true;
            th.Cells[0].AddParagraph("Código");
            th.Cells[1].AddParagraph("Cantidad");
            th.Cells[2].AddParagraph("Descripción");
            th.Cells[3].AddParagraph("Precio\nUnitario");
            th.Cells[4].AddParagraph("Subtotal");

            decimal subtotal = 0m;

            foreach (DataRow d in ds.Tables["Detalle"].Rows)
            {
                string codigo = d.Table.Columns.Contains("codigo") ? Convert.ToString(d["codigo"])
                              : d.Table.Columns.Contains("id_producto") ? Convert.ToString(d["id_producto"])
                              : "";

                string prod = Convert.ToString(d["producto"]);
                string talla = d.Table.Columns.Contains("talla") ? Convert.ToString(d["talla"]) : "";
                decimal pu = Convert.ToDecimal(d["precio_unitario"]);
                int cant = Convert.ToInt32(d["cantidad"]);
                decimal line = Convert.ToDecimal(d["subtotal"]);
                subtotal += line;

                var row = tbl.AddRow();
                row.Cells[0].AddParagraph(codigo);
                row.Cells[1].AddParagraph($"{cant}");
                row.Cells[2].AddParagraph(string.IsNullOrEmpty(talla) ? prod : $"{prod} (Talle: {talla})");
                row.Cells[3].AddParagraph($"${pu:0.00}");
                row.Cells[4].AddParagraph($"${line:0.00}");
            }

            // Espaciador breve antes de totales
            var spTot = section.AddParagraph();
            spTot.Format.SpaceBefore = "0.25cm";

            // TOTALES (grilla alineada a la del detalle) 
            var tot = section.AddTable();
            tot.Borders.Width = 0;
            tot.AddColumn("2.20cm");
            tot.AddColumn("2.00cm");
            tot.AddColumn("8.30cm");
            tot.AddColumn("2.30cm");
            tot.AddColumn("2.70cm");

            if (ivaPorcentaje.HasValue)
            {
                decimal iva = Math.Round(subtotal * ivaPorcentaje.Value, 2);
                decimal totalCalc = esNC ? -(subtotal + iva) : (subtotal + iva);

                var r1 = tot.AddRow();
                r1.Cells[0].MergeRight = 2;
                r1.Cells[3].AddParagraph("Subtotal:").Format.Alignment = ParagraphAlignment.Right;
                r1.Cells[4].AddParagraph($"${(esNC ? -subtotal : subtotal):0.00}")
                           .Format.Alignment = ParagraphAlignment.Right;

                var r2 = tot.AddRow();
                r2.Cells[0].MergeRight = 2;
                r2.Cells[3].AddParagraph($"IVA ({ivaPorcentaje:P0}):").Format.Alignment = ParagraphAlignment.Right;
                r2.Cells[4].AddParagraph($"${(esNC ? -iva : iva):0.00}")
                           .Format.Alignment = ParagraphAlignment.Right;

                var r3 = tot.AddRow();
                r3.Cells[0].MergeRight = 2;
                r3.Cells[3].AddParagraph(esNC ? "Total a devolver:" : "Total a pagar:")
                           .Format.Font.Bold = true;
                r3.Cells[3].Format.Alignment = ParagraphAlignment.Right;
                r3.Cells[4].AddParagraph($"${totalCalc:0.00}")
                           .Format.Alignment = ParagraphAlignment.Right;
                r3.Cells[4].Format.Font.Bold = true;
            }
            else
            {
                var r = tot.AddRow();
                r.Cells[0].MergeRight = 2; 
                r.Cells[3].AddParagraph("TOTAL:").Format.Font.Bold = true;
                r.Cells[3].Format.Alignment = ParagraphAlignment.Right;
                r.Cells[4].AddParagraph($"${(esNC ? -Math.Abs(totalDb) : Math.Abs(totalDb)):0.00}")
                          .Format.Alignment = ParagraphAlignment.Right;
                r.Cells[4].Format.Font.Bold = true;
            }

            
            var spPie = section.AddParagraph();
            spPie.Format.SpaceBefore = "0.60cm";

            // PIE 
            if (!string.IsNullOrWhiteSpace(leyendaContacto))
            {
                var pLey = section.AddParagraph(leyendaContacto);
                pLey.Format.Font.Size = 9;
                pLey.Format.Font.Color = MD.Colors.Gray;
            }
            var pGracias = section.AddParagraph("¡Gracias por su compra!");
            pGracias.Format.Font.Size = 9;
            pGracias.Format.Font.Color = MD.Colors.Gray;

            // Render y guardar
            var renderer = new PdfDocumentRenderer();
            renderer.Document = doc;
            renderer.RenderDocument();
            renderer.Save(ruta);

            return ruta;
        }

        public static void Abrir(string ruta)
        {
            if (File.Exists(ruta))
                Process.Start(new ProcessStartInfo(ruta) { UseShellExecute = true });
        }

    }
}
