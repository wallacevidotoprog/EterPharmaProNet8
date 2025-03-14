using EterPharmaPro.Models.Tag;
using EterPharmaPro.Utils.Extencions;
using System.Drawing.Printing;

namespace EterPharmaPro.Infrastructure.Services.Prints
{
	public class PrintTagValityService : PrintResopitoryGeneric
	{
		private List<PrintTagPriceModel> printTagPreceModel;
		private Font headerFont;
		private Font headerFont2;
		private Font cellFont;
		private Font cellFont2;
		private Font cellFontBold;
		private int currentItemIndex;
		private float tableWidth = 180;
		private float tableHeight = 190;
		private float marginX;
		private float marginY;
		private float pageWidth;
		private int tablesPerRow;

		public PrintTagValityService(List<PrintTagPriceModel> printTagPreceModel)
		{
			this.printTagPreceModel = printTagPreceModel;

			printDocument.PrintPage += PrintPage;
			currentItemIndex = 0;

			headerFont = new Font("Courier New", 9, FontStyle.Bold);
			headerFont2 = new Font("Courier New", 8, FontStyle.Bold);
			cellFont = new Font("Courier New", 9, FontStyle.Regular);
			cellFont2 = new Font("Courier New", 9, FontStyle.Strikeout);
			cellFontBold = new Font("Courier New", 8, FontStyle.Bold);



			printDocument.DefaultPageSettings.Margins = new Margins(20, 30, 20, 20);
			printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
			printDocument.DocumentName = $"TAG VALIDADE {DateTime.Now:dd-MM-yyyy HHmmss}";


		}

		private int CountPages(int values)
		{
			try
			{
				return (int)Math.Ceiling((double)values / 20);
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
			return 1;
		}

		private void PrintPage(object sender, PrintPageEventArgs e)
		{
			pageWidth = e.MarginBounds.Width;
			marginX = e.MarginBounds.Left;
			marginY = e.MarginBounds.Top;
			totalPages = CountPages(printTagPreceModel.Count);
			Graphics g = e.Graphics;

			tablesPerRow = (int)(pageWidth / (tableWidth + 10));
			float x = marginX, y = marginY;
			int tablesPrinted = 0;

			while (currentItemIndex < printTagPreceModel.Count)
			{
				DrawTable(g, printTagPreceModel[currentItemIndex], x, y);
				tablesPrinted++;
				x += tableWidth + 10;

				if (tablesPrinted % tablesPerRow == 0)
				{
					x = marginX;
					y += tableHeight + 20;
				}

				currentItemIndex++;

				if (y + tableHeight > e.PageBounds.Height - marginY)
				{
					e.HasMorePages = true;
					return;
				}
			}
			currentItemIndex = 0;
			e.HasMorePages = false;
		}

		private void DrawTable(Graphics g, PrintTagPriceModel model, float x, float y)
		{
			Pen borderPen = new Pen(Color.Black, 2);
			float cellHeight = 30;
			float cellPadding = 0;

			StringFormat centerFormat = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
			StringFormat LeftFormat = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Far };
			//RectangleF tableRect = new RectangleF(x, y, tableWidth, tableHeight);

			// Desenha a borda da tabela
			g.DrawRectangle(borderPen, x, y, tableWidth, tableHeight);


			y += 10;
			// Ajuste para quebra de linha
			RectangleF headerRect = new RectangleF(x, y, tableWidth, cellHeight);
			g.DrawString("PRODUTO COM DESCONTO ESPECIAL", headerFont, Brushes.Black, headerRect, centerFormat);

			y += 5;
			RectangleF subHeaderRect = new RectangleF(x, y + cellHeight, tableWidth, cellHeight);
			g.DrawString("(PRÓXIMO AO VENCIMENTO)", headerFont2, Brushes.Black, subHeaderRect, centerFormat);

			y += 5;
			RectangleF nameRect = new RectangleF(x, y + cellHeight * 2, tableWidth, cellHeight);
			g.DrawString(model.NAME_ITEM.ToUpper(), headerFont, Brushes.Black, nameRect, centerFormat);



			y += 20;


			g.DrawString("DE: R$", cellFont2, Brushes.Black, x + cellPadding, y + cellHeight * 3);
			g.DrawString(model.OLD_PRICE.ToString("F2"), cellFont2, Brushes.Red, x + tableWidth - 45, y + cellHeight * 3);
			y -= 10;

			g.DrawString("POR: R$", cellFont, Brushes.Black, x + cellPadding, y + cellHeight * 4);
			g.DrawString(model.NEW_PRICE.ToString("F2"), cellFontBold, Brushes.Red, x + tableWidth - 40, y + cellHeight * 4);
			y -= 10;
			g.DrawString("VALIDADE:", cellFont, Brushes.Black, x + cellPadding, y + cellHeight * 5);
			g.DrawString(model.DATE_VALITY.ToShortDateString(), cellFontBold, Brushes.Red, x + tableWidth - 75, y + cellHeight * 5);
		}
	}
}
