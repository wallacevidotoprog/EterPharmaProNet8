using EterPharmaPro.Models;
using EterPharmaPro.Utils.Extencions;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
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
				$"REMANEJO {DateTime.Now:ddMMyyyy_HHmm}.pdf"
			);

			PdfWriter writer = new PdfWriter(filePath, new WriterProperties());
			PdfDocument pdfDocument = new PdfDocument(writer);
			Document document = new Document(pdfDocument);

			PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

			int tablesPerPage = 6; 
			int tablesInCurrentPage = 0;

			Table layoutTable = new Table(new float[] { 1, 1 });
			layoutTable.SetWidth(UnitValue.CreatePercentValue(100));

			int current = 1;
			float lastTableHeight = 0;

			for (int x = 0; x < remanejoMode.QTD; x++)
			{

				Table table = new Table(new float[] { 300f, 25f });
				table.SetWidth(UnitValue.CreatePercentValue(100));

				table.AddCell(CreateCell($"{remanejoMode.LOJA.ToUpper()}", font, 35, 2));
				table.AddCell(CreateCell($"N° REMANEJO: {remanejoMode.NUM.ToUpper()}", font, 20, 2));
				table.AddCell(CreateCell($"DATA: {remanejoMode.DATA.ToShortDateString()}", font, 20, 2));
				table.AddCell(CreateCell($"{current.ToString().PadLeft(3, '0')}/{remanejoMode.QTD.ToString().PadLeft(3, '0')}", font, 35, 2));

				if (!string.IsNullOrEmpty(remanejoMode.OBS))
				{
					table.AddCell(CreateCell($"OBSERVAÇÕES: {remanejoMode.OBS.ToUpper()}", font, 10, 2));
				}

				layoutTable.AddCell(new Cell().Add(table).SetBorder(iText.Layout.Borders.Border.NO_BORDER));

				if (x == remanejoMode.QTD - 1 && (x + 1) % 2 != 0)
				{

					layoutTable.AddCell(new Cell().Add(new Table(new float[] { 300f, 25f }).SetWidth(UnitValue.CreatePercentValue(100))).SetBorder(iText.Layout.Borders.Border.NO_BORDER));
					
				}

				
				tablesInCurrentPage++;

				
				if (tablesInCurrentPage == tablesPerPage || x == remanejoMode.QTD - 1)
				{
					document.Add(layoutTable);
					document.Add(new Paragraph("\n")); 

					
					layoutTable = new Table(new float[] { 1, 1 });
					layoutTable.SetWidth(UnitValue.CreatePercentValue(100));

					tablesInCurrentPage = 0; 
					if (x < remanejoMode.QTD - 1) document.Add(new AreaBreak()); 
				}

				current++;
			}

			document.Close();
			Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
		}

		private Cell CreateCell(string text, PdfFont font, float fontSize, int colspan)
		{
			return new Cell(1, colspan)
				.Add(new Paragraph(text).SetFont(font).SetFontSize(fontSize).SetFontColor(new DeviceRgb(0, 0, 0)))
				.SetTextAlignment(TextAlignment.CENTER)
				.SetVerticalAlignment(VerticalAlignment.MIDDLE)
				.SetPadding(5)
				.SetBorder(new iText.Layout.Borders.SolidBorder(1));
		}
	}
}
