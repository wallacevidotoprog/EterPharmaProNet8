using EterPharmaPro.Models;
using EterPharmaPro.Views.IMPRESSOS;
using System.Drawing.Printing;
using System.Globalization;

namespace EterPharmaPro.Infrastructure.Services.Prints
{
	public class TagPromotionService : PrintResopitoryGeneric
	{
		private readonly List<ePanelPromocaoModel> model;
		private readonly FieldPrintSchemeEnum printSchemeEnum;
		private ePanelPromocaoModel[] tempCurrent = null;
		private int modelCurrent = 0;
		private int currentPage = 1;
		private int itemsPerPage = 2;

		public TagPromotionService(List<ePanelPromocaoModel> model, FieldPrintSchemeEnum printSchemeEnum)
		{
			this.model = model;
			this.printSchemeEnum = printSchemeEnum;
			SetPaper();
		}

		private void SetPaper()
		{

			printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
			printDocument.DefaultPageSettings.Margins = new Margins(20, 30, 20, 20);
			printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
			printDocument.DocumentName = $"TAG PROMOÇÃO {DateTime.Now:dd-MM-yyyy HHmmss}";


		}

		private void PrintPage(object sender, PrintPageEventArgs e)
		{
			if (totalPages < currentPage)
			{
				currentPage = 1;
				modelCurrent = 0;
				e.HasMorePages = false;
			}
			totalPages = (int)Math.Ceiling((double)model.Count / 2);


			float spacing = 30;
			float pageWidth = e.MarginBounds.Width;
			float x = e.MarginBounds.Left;
			float y = e.MarginBounds.Top;

			Graphics gfx = e.Graphics;
			Font font_title = new Font("Arial Black", 20);
			Font font_price = new Font("Arial Black", 45);
			Font font_subtitle = new Font("Arial", 20);
			StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
			SizeF stringSize;


			tempCurrent = new ePanelPromocaoModel[2];
			tempCurrent[0] = modelCurrent < model.Count ? model[modelCurrent] ?? null : null;
			modelCurrent++;
			tempCurrent[1] = modelCurrent < model.Count ? model[modelCurrent] ?? null : null;
			modelCurrent++;

			// --- IMPRIMINDO PRIMEIRO PRODUTO ---
			if (tempCurrent[0] != null)
			{
				y += 200;

				stringSize = gfx.MeasureString(tempCurrent[0].PRODUTO, font_title);

				//gfx.DrawString(tempCurrent[0].PRODUTO, font_title, Brushes.Black, (x + (pageWidth - stringSize.Width) / 2), y);
				gfx.DrawString(tempCurrent[0].PRODUTO, font_title, Brushes.Black, new RectangleF(x, y, pageWidth, 100), format);

				y += spacing + 90;

				string text3 = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT
					? $"{Convert.ToDecimal(tempCurrent[0].VALOR1):C2}".ToUpper()
					: $"{Convert.ToDecimal(tempCurrent[0].VALOR1):C2}   *{Convert.ToDecimal(tempCurrent[0].VALOR2):C2}".ToUpper();




				gfx.DrawString(text3, font_price, Brushes.Black, new RectangleF(x, y, pageWidth, 100), format);

				y += spacing + 50;
				string text4 = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT
					? $"{tempCurrent[0].DESC1}"
					: $"{tempCurrent[0].DESC1}                      {tempCurrent[0].DESC2}";

				gfx.DrawString(text4, font_subtitle, Brushes.Black, new RectangleF(x, y, pageWidth, 100), format);
			}

			// --- IMPRIMINDO SEGUNDO PRODUTO ---
			if (tempCurrent[1] != null)
			{
				y += 395;
				gfx.DrawString(tempCurrent[1].PRODUTO, font_title, Brushes.Black, new RectangleF(x, y, pageWidth, 100), format);

				y += spacing + 90;
				string text7 = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT
					? $"{Convert.ToDecimal(tempCurrent[1].VALOR1):C2}".ToUpper()
					: $"{Convert.ToDecimal(tempCurrent[1].VALOR1):C2}   *{Convert.ToDecimal(tempCurrent[1].VALOR2):C2}".ToUpper();

				gfx.DrawString(text7, font_price, Brushes.Black, new RectangleF(x, y, pageWidth, 100), format);

				y += spacing + 50;
				string text43 = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT
					? $"{tempCurrent[1].DESC1}"
					: $"{tempCurrent[1].DESC1}                      {tempCurrent[1].DESC2}";

				gfx.DrawString(text43, font_subtitle, Brushes.Black, new RectangleF(x, y, pageWidth, 100), format);
			}

			// Configura a próxima página se houver mais itens a imprimir
			if (totalPages > currentPage)
			{
				currentPage++;
				//modelCurrent++;
				e.HasMorePages = true;
			}
			else
			{
				currentPage = 1;
				modelCurrent = 0;
				e.HasMorePages = false;
			}
		}
	}

}
