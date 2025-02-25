//using EterPharmaPro.Enums;
//using EterPharmaPro.Models.Tag;
//using iText.Kernel.Pdf;
//using iText.Layout;
//using System.Diagnostics;

//namespace EterPharmaPro.Infrastructure.Services
//{
//	public class PrintTagValityService
//	{
//		private TableTagValidityModal tableTagV;

//		private List<PrintTagPriceModel> printTagPreceModel;

//		private Font headerFont;

//		private Font cellFont;

//		private Font cellFontatik;

//		private Font rcellFont;

//		private Font rcellFontatik;

//		public PrintTagValityService()
//		{
//			printTagPreceModel = new List<PrintTagPriceModel>();
//		}

//		public void Add(PrintTagPriceModel model)
//		{
//			printTagPreceModel.Add(model);
//		}

//		public void Print()
//		{
//			string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\PriceVality" + DateTime.Now.ToString("ddddMMMMyyyyyHHmm") + ".pdf";
//			Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
//			PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
//			document.Open();
//			tableTagV = new TableTagValidityModal(SizeTableTagEnum.PEQUENA);
//			headerFont = new Font(Font.FontFamily.COURIER, tableTagV.headerFont, 1, BaseColor.BLACK);
//			cellFont = new Font(Font.FontFamily.COURIER, tableTagV.cellFont, 2, BaseColor.BLACK);
//			cellFontatik = new Font(Font.FontFamily.COURIER, tableTagV.cellFont, 8, BaseColor.BLACK);
//			rcellFont = new Font(Font.FontFamily.COURIER, tableTagV.cellFont, 2, BaseColor.RED);
//			rcellFontatik = new Font(Font.FontFamily.COURIER, tableTagV.cellFont, 8, BaseColor.RED);
//			float tableWidth = tableTagV.tableWidth;
//			float spaceBetweenTables = tableTagV.spaceBetweenTables;
//			float marginLeft = document.LeftMargin;
//			float marginRight = document.RightMargin;
//			float pageWidth = PageSize.A4.Width;
//			float pageHeight = PageSize.A4.Height;
//			int tablesPerRow = (int)((pageWidth - marginLeft - marginRight) / (tableWidth + spaceBetweenTables));
//			float yPosition = document.PageSize.Height - document.TopMargin;
//			float minYPosition = document.BottomMargin;


//			for (int x = 0; x < printTagPreceModel.Count; x++)
//			{
//				PdfPTable table = CreateTable(printTagPreceModel[x]);
//				table.TotalWidth = tableWidth;
//				table.WidthPercentage = tableTagV.widthPercentage;
//				float xPosition = marginLeft + x % tablesPerRow * (tableWidth + spaceBetweenTables);
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
//			}
//			document.Close();
//			Process.Start(new ProcessStartInfo(filePath)
//			{
//				UseShellExecute = true
//			});
//		}

//		private PdfPTable CreateTable(PrintTagPriceModel model)
//		{
//			PdfPTable table = new PdfPTable(2);
//			table.SetWidths(tableTagV.setWidths);
//			table.WidthPercentage = tableTagV.tableWidthPercentage;
//			AddMergedCell(table, "PRODUTO COM DESCONTO ESPECIAL");
//			AddMergedCell(table, "(PRÓXIMO AO VENCIMENTO)");
//			AddMergedCell(table, model.NAME_ITEM.ToUpper());
//			AddCell(table, "DE: R$", 0, 5, leftR: true, right: false, cellFontatik);
//			AddCell(table, model.OLD_PRICE.ToString("F2"), 2, 5, leftR: false, right: true, rcellFontatik);
//			AddCell(table, "POR: R$ ", 0, 5, leftR: true, right: false, cellFont);
//			AddCell(table, model.NEW_PRICE.ToString("F2"), 2, 5, leftR: false, right: true, rcellFont);
//			AddCell(table, "VALIDADE:", 0, 5, leftR: true, right: false, cellFont);
//			AddCell(table, model.DATE_VALITY.ToShortDateString(), 2, 5, leftR: false, right: true, rcellFont);
//			return table;
//		}

//		private void AddMergedCell(PdfPTable table, string text, bool notB = false)
//		{
//			PdfPCell cell = new PdfPCell(new Phrase(text, headerFont))
//			{
//				Colspan = 2,
//				FixedHeight = tableTagV.tableFixedHeightHeader,
//				HorizontalAlignment = 1,
//				VerticalAlignment = 5,
//				BorderWidth = 1f,
//				NoWrap = false
//			};
//			if (notB)
//			{
//				cell.Border = 13;
//			}
//			table.AddCell(cell);
//		}

//		private void AddCell(PdfPTable table, string text, int hAlign, int vAlign, bool leftR, bool right, Font font)
//		{
//			PdfPCell cell = new PdfPCell(new Phrase(text, font))
//			{
//				FixedHeight = tableTagV.tableFixedHeightCell,
//				HorizontalAlignment = hAlign,
//				VerticalAlignment = vAlign,
//				BorderWidth = 1f
//			};
//			if (leftR)
//			{
//				cell.Border = 7;
//			}
//			if (right)
//			{
//				cell.Border = 11;
//			}
//			table.AddCell(cell);
//		}
//	}
//}
using EterPharmaPro.Models.Tag;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Diagnostics;
using Color = iText.Kernel.Colors.Color;

namespace EterPharmaPro.Infrastructure.Services
{
	public class PrintTagValityService
	{
		private List<PrintTagPriceModel> printTagPreceModel;

		private PdfFont headerFont;
		private PdfFont cellFont;
		private PdfFont cellFontBold;

		public PrintTagValityService()
		{
			printTagPreceModel = new List<PrintTagPriceModel>();

			// Definir fontes
			headerFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
			cellFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
			cellFontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
		}

		public void Add(PrintTagPriceModel model)
		{
			printTagPreceModel.Add(model);
		}

		public void Print()
		{
			string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
				$"PriceVality_{DateTime.Now:yyyyMMdd_HHmm}.pdf");

			using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
			{
				PdfWriter writer = new PdfWriter(fs);
				PdfDocument pdf = new PdfDocument(writer);
				Document document = new Document(pdf);

				foreach (var model in printTagPreceModel)
				{
					Table table = CreateTable(model);
					document.Add(table);
					document.Add(new Paragraph("\n"));
				}

				document.Close();
			}

			Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
		}

		private Table CreateTable(PrintTagPriceModel model)
		{
			Table table = new Table(2);
			table.SetWidth(UnitValue.CreatePercentValue(100));

			AddMergedCell(table, "PRODUTO COM DESCONTO ESPECIAL", headerFont, ColorConstants.BLACK);
			AddMergedCell(table, "(PRÓXIMO AO VENCIMENTO)", headerFont, ColorConstants.RED);
			AddMergedCell(table, model.NAME_ITEM.ToUpper(), cellFontBold, ColorConstants.BLACK);

			AddCell(table, "DE: R$", cellFont, ColorConstants.BLACK);
			AddCell(table, model.OLD_PRICE.ToString("F2"), cellFontBold, ColorConstants.RED);

			AddCell(table, "POR: R$ ", cellFont, ColorConstants.BLACK);
			AddCell(table, model.NEW_PRICE.ToString("F2"), cellFontBold, ColorConstants.RED);

			AddCell(table, "VALIDADE:", cellFont, ColorConstants.BLACK);
			AddCell(table, model.DATE_VALITY.ToShortDateString(), cellFontBold, ColorConstants.RED);

			return table;
		}

		private void AddMergedCell(Table table, string text, PdfFont font, Color color)
		{
			Cell cell = new Cell(1, 2)
		.Add(new Paragraph(text).SetFont(font).SetFontColor(color))
		.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
		.SetBackgroundColor(ColorConstants.LIGHT_GRAY);

			table.AddCell(cell);
			//Cell cell = new Cell(1, 2)
			//	.Add(new Paragraph(text).SetFont(font).SetFontColor(color))
			//	.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
			//	//.SetBold()
			//	.SetBackgroundColor(ColorConstants.LIGHT_GRAY);

			//table.AddCell(cell);
		}

		private void AddCell(Table table, string text, PdfFont font, Color color)
		{
			Cell cell = new Cell()
				.Add(new Paragraph(text).SetFont(font).SetFontColor(color))
				.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);

			table.AddCell(cell);
		}
	}
}
