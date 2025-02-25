//using EterPharmaPro.Models;
//using EterPharmaPro.Utils.Extencions;
//using System.Diagnostics;

//namespace EterPharmaPro.Controllers.Impressos
//{
//	public class RemanejoController
//	{
//		public bool Print(RemanejoModel remanejoModel)
//		{
//			try
//			{
//				PrintPDF(remanejoModel);
//			}
//			catch (Exception ex)
//			{
//				ex.ErrorGet();
//			}
//			return false;
//		}
//		private void PrintPDF(RemanejoModel remanejoMode)
//		{
//			Font cellFon = new Font(Font.FontFamily.COURIER, 8, 1, BaseColor.BLACK);

//			string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\REMANEJO" + DateTime.Now.ToString("ddddMMMMyyyyyHHmm") + ".pdf";
//			Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
//			PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
//			document.Open();

//			float tableWidth = 250;
//			float spaceBetweenTables = 3;
//			float marginLeft = document.LeftMargin;
//			float marginRight = document.RightMargin;
//			float pageWidth = PageSize.A4.Width;
//			float pageHeight = PageSize.A4.Height;
//			int tablesPerRow = (int)((pageWidth - marginLeft - marginRight) / (tableWidth + spaceBetweenTables));
//			float yPosition = document.PageSize.Height - document.TopMargin;
//			float minYPosition = document.BottomMargin;

//			int current = 1;

//			for (int x = 0; x < remanejoMode.QTD; x++)
//			{
//				PdfPTable table = new PdfPTable(2);
//				table.SetWidths(new float[] { 300f, 25 });
//				table.WidthPercentage = 100f;

//				PdfPCell cell = new PdfPCell(new Phrase($"{remanejoMode.LOJA.ToUpper()}", new Font(Font.FontFamily.HELVETICA, 35, 1, BaseColor.BLACK)))
//				{
//					Colspan = 2,
//					FixedHeight = 50f,
//					HorizontalAlignment = 1,
//					VerticalAlignment = 5,
//					BorderWidth = 1f,
//					NoWrap = false
//				};
//				table.AddCell(cell);

//				PdfPCell cell2 = new PdfPCell(new Phrase($"N° REMANEJO: {remanejoMode.NUM.ToUpper()}", new Font(Font.FontFamily.HELVETICA, 20, 1, BaseColor.BLACK)))
//				{
//					Colspan = 2,
//					FixedHeight = 50f,
//					HorizontalAlignment = 1,
//					VerticalAlignment = 5,
//					BorderWidth = 1f,
//					NoWrap = false
//				};
//				table.AddCell(cell2);

//				PdfPCell cell3 = new PdfPCell(new Phrase($"DATA: {remanejoMode.DATA.ToShortDateString()}", new Font(Font.FontFamily.HELVETICA, 20, 1, BaseColor.BLACK)))
//				{
//					Colspan = 2,
//					FixedHeight = 50f,
//					HorizontalAlignment = 1,
//					VerticalAlignment = 5,
//					BorderWidth = 1f,
//					NoWrap = false
//				};
//				table.AddCell(cell3);

//				PdfPCell cell4 = new PdfPCell(new Phrase($"{current.ToString().PadLeft(3, '0')}/{remanejoMode.QTD.ToString().PadLeft(3, '0')}", new Font(Font.FontFamily.HELVETICA, 35, 1, BaseColor.BLACK)))
//				{
//					Colspan = 2,
//					FixedHeight = 50f,
//					HorizontalAlignment = 1,
//					VerticalAlignment = 5,
//					BorderWidth = 1f,
//					NoWrap = false
//				};
//				table.AddCell(cell4);
//				if (!string.IsNullOrEmpty(remanejoMode.OBS))
//				{
//					PdfPCell cell5 = new PdfPCell(new Phrase($"OBSERVAÇÕES: {remanejoMode.OBS.ToUpper()}", new Font(Font.FontFamily.HELVETICA, 10, 1, BaseColor.BLACK)))
//					{
//						Colspan = 2,
//						FixedHeight = 50f,
//						HorizontalAlignment = 1,
//						VerticalAlignment = 5,
//						BorderWidth = 1f,
//						NoWrap = false
//					};
//					table.AddCell(cell5);
//				}






//				table.TotalWidth = tableWidth;
//				table.WidthPercentage = 100f;
//				float xPosition = marginLeft + (float)(x % tablesPerRow) * (tableWidth + spaceBetweenTables);
//				if (x > 0 && x % tablesPerRow == 0)
//				{
//					yPosition -= table.TotalHeight + 10f;
//					if (yPosition - table.TotalHeight < minYPosition)
//					{
//						document.NewPage();
//						yPosition = document.PageSize.Height - document.TopMargin;
//					}
//				}
//				table.WriteSelectedRows(0, -1, xPosition, yPosition, writer.DirectContent);
//				current++;
//			}

//			document.Close();
//			Process.Start(new ProcessStartInfo(filePath)
//			{
//				UseShellExecute = true
//			});
//		}
//	}
//}
using EterPharmaPro.Models;
using EterPharmaPro.Utils.Extencions;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Diagnostics;

namespace EterPharmaPro.Controllers.Impressos
{
	public class RemanejoController
	{
		public bool Print(RemanejoModel remanejoModel)
		{
			try
			{
				PrintPDF(remanejoModel);
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
			return false;
		}

		private void PrintPDF(RemanejoModel remanejoMode)
		{
			string filePath = Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
				$"REMANEJO_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
			);

			using (PdfWriter writer = new PdfWriter(filePath))
			using (PdfDocument pdf = new PdfDocument(writer))
			using (Document document = new Document(pdf))
			{
				PdfFont font = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA);
				PdfFont boldFont = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD);

				float tableWidth = 250f;
				float spaceBetweenTables = 3f;
				float marginLeft = document.GetLeftMargin();
				float marginRight = document.GetRightMargin();
				float pageWidth = pdf.GetDefaultPageSize().GetWidth();
				int tablesPerRow = (int)((pageWidth - marginLeft - marginRight) / (tableWidth + spaceBetweenTables));

				int current = 1;

				for (int x = 0; x < remanejoMode.QTD; x++)
				{
					Table table = new Table(2).UseAllAvailableWidth();

					table.AddCell(CreateCell(remanejoMode.LOJA.ToUpper(), boldFont, 35, 2, TextAlignment.CENTER));
					table.AddCell(CreateCell($"N° REMANEJO: {remanejoMode.NUM.ToUpper()}", boldFont, 20, 2, TextAlignment.CENTER));
					table.AddCell(CreateCell($"DATA: {remanejoMode.DATA:dd/MM/yyyy}", boldFont, 20, 2, TextAlignment.CENTER));
					table.AddCell(CreateCell($"{current.ToString().PadLeft(3, '0')}/{remanejoMode.QTD.ToString().PadLeft(3, '0')}", boldFont, 35, 2, TextAlignment.CENTER));

					if (!string.IsNullOrEmpty(remanejoMode.OBS))
					{
						table.AddCell(CreateCell($"OBSERVAÇÕES: {remanejoMode.OBS.ToUpper()}", font, 10, 2, TextAlignment.CENTER));
					}

					document.Add(table);
					document.Add(new Paragraph("\n")); // Adiciona um espaço entre as tabelas
					current++;
				}
			}

			Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
		}

		private Cell CreateCell(string text, PdfFont font, float fontSize, int colspan, TextAlignment alignment)
		{
			return new Cell(1, colspan)
				.Add(new Paragraph(text).SetFont(font).SetFontSize(fontSize))
				.SetTextAlignment(alignment)
				.SetBorder(iText.Layout.Borders.Border.NO_BORDER);
		}
	}
}
