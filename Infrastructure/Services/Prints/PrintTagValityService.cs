using EterPharmaPro.Models.Tag;
using System.Drawing.Printing;

namespace EterPharmaPro.Infrastructure.Services.Prints
{
	public class PrintTagValityService : PrintResopitoryGeneric
	{
		private List<PrintTagPriceModel> printTagPreceModel;
		private Font headerFont;
		private Font cellFont;
		private Font cellFontBold;
		private int currentItemIndex;
		private float tableWidth = 200;
		private float tableHeight = 160;
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
			cellFont = new Font("Courier New", 9, FontStyle.Regular);
			cellFontBold = new Font("Courier New", 8, FontStyle.Bold);


			printDocument.DefaultPageSettings.Margins = new Margins(20, 30, 20, 20);
			printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
			printDocument.DocumentName = $"TAG VALIDADE {DateTime.Now:dd-MM-yyyy HHmmss}";


		}

		private void PrintPage(object sender, PrintPageEventArgs e)
		{
			pageWidth = e.MarginBounds.Width;
			marginX = e.MarginBounds.Left;
			marginY = e.MarginBounds.Top;
			totalPages = 1;
			Graphics g = e.Graphics;
			//float pageWidth = e.PageBounds.Width - marginX * 2;
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
			float cellHeight = 18;
			float cellPadding = 1;
			y += 10;
			StringFormat centerFormat = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
			StringFormat LeftFormat = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Far };
			RectangleF tableRect = new RectangleF(x, y, tableWidth, tableHeight);

			// Desenha a borda da tabela
			g.DrawRectangle(borderPen, x, y, tableWidth, tableHeight);

			// Ajuste para quebra de linha
			RectangleF headerRect = new RectangleF(x, y, tableWidth, cellHeight);
			g.DrawString("PRODUTO COM DESCONTO ESPECIAL", headerFont, Brushes.Black, headerRect, centerFormat);

			RectangleF subHeaderRect = new RectangleF(x, y + cellHeight, tableWidth, cellHeight);
			g.DrawString("(PRÓXIMO AO VENCIMENTO)", headerFont, Brushes.Black, subHeaderRect, centerFormat);

			RectangleF nameRect = new RectangleF(x, y + cellHeight * 2, tableWidth, cellHeight);
			g.DrawString(model.PRODUTO.DESCRICAO_PRODUTO.ToUpper(), headerFont, Brushes.Black, nameRect, centerFormat);


			//RectangleF oldPriceLabelRect = new RectangleF(x, y + cellHeight * 3, tableWidth, cellHeight);
			//g.DrawString("DE: R$", cellFont, Brushes.Black, oldPriceLabelRect, LeftFormat);

			//RectangleF oldPriceValueRect = new RectangleF(x + tableWidth, y + cellHeight * 3, tableWidth, cellHeight);
			//g.DrawString(model.OLD_PRICE.ToString("F2"), cellFontBold, Brushes.Red, oldPriceValueRect, LeftFormat);

			//RectangleF newPriceLabelRect = new RectangleF(x, y + cellHeight * 4, tableWidth, cellHeight);
			//g.DrawString("POR: R$", cellFont, Brushes.Black, newPriceLabelRect, LeftFormat);

			//RectangleF newPriceValueRect = new RectangleF(x + tableWidth, y + cellHeight * 4, tableWidth, cellHeight);
			//g.DrawString(model.NEW_PRICE.ToString("F2"), cellFontBold, Brushes.Red, newPriceValueRect, LeftFormat);

			//RectangleF validityLabelRect = new RectangleF(x, y + cellHeight * 5, tableWidth, cellHeight);
			//g.DrawString("VALIDADE:", cellFont, Brushes.Black, validityLabelRect, LeftFormat);

			//RectangleF validityValueRect = new RectangleF(x + tableWidth, y + cellHeight * 5, tableWidth, cellHeight);
			//g.DrawString(model.DATE_VALITY.ToShortDateString(), cellFontBold, Brushes.Red, validityValueRect, LeftFormat);


			g.DrawString("DE: R$", cellFont, Brushes.Black, x + cellPadding, y + cellHeight * 3);
			g.DrawString(model.OLD_PRICE.ToString("F2"), cellFontBold, Brushes.Red, x + tableWidth - 50, y + cellHeight * 3);

			g.DrawString("POR: R$", cellFont, Brushes.Black, x + cellPadding, y + cellHeight * 4);
			g.DrawString(model.NEW_PRICE.ToString("F2"), cellFontBold, Brushes.Red, x + tableWidth - 50, y + cellHeight * 4);

			g.DrawString("VALIDADE:", cellFont, Brushes.Black, x + cellPadding, y + cellHeight * 5);
			g.DrawString(model.DATE_VALITY.ToShortDateString(), cellFontBold, Brushes.Red, x + tableWidth - 70, y + cellHeight * 5);
		}
	}
}
