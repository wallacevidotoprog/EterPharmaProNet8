using EterPharmaPro.Models;
using EterPharmaPro.Views.IMPRESSOS;
using PdfSharp.Drawing;
using System.Drawing.Printing;
using System.Globalization;

namespace EterPharmaPro.Infrastructure.Services.Prints
{
	//public class TagPromotionService
	//{
	//	private PrintDocument printDocument = new PrintDocument();
	//	private PdfDocument pdfDocument;
	//	private XGraphics gfx;
	//	private XFont font_title = new XFont("Arial Black", 20);
	//	private XFont font_price = new XFont("Arial Black", 45);
	//	private XFont font_subtitle = new XFont("Arial", 20);
	//	private readonly List<ePanelPromocaoModel> model;
	//	private readonly FieldPrintSchemeEnum printSchemeEnum;
	//	private ePanelPromocaoModel[] tempCurrent = null;


	//	public TagPromotionService(List<ePanelPromocaoModel> model, FieldPrintSchemeEnum printSchemeEnum)
	//	{
	//		this.model = model;
	//		this.printSchemeEnum = printSchemeEnum;
	//		SetPaper();
	//	}

	//	public void ShowPrintPreview()
	//	{
	//		using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
	//		{
	//			previewDialog.Document = printDocument;
	//			previewDialog.WindowState = FormWindowState.Maximized; // Abre em tela cheia
	//			previewDialog.ShowDialog();
	//		}
	//	}

	//	private void SetPaper()
	//	{

	//		printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);

	//		float superior = 2.54f * 72 / 2.54f;
	//		float esquerda = 3.17f * 72 / 2.54f;
	//		float inferior = 2.54f * 72 / 2.54f;
	//		float direita = 3.17f * 72 / 2.54f;

	//		printDocument.DefaultPageSettings.Margins = new Margins((int)esquerda, (int)superior, (int)direita, (int)inferior);


	//		printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
	//	}

	//	public void PrintToPdf()
	//	{
	//		if (model == null)
	//		{
	//			throw new ArgumentNullException("Model Nula: EterPharmaPro.Infrastructure.Services.Prints.TagPromotionService.PrintToPdf");
	//			return;
	//		}

	//		pdfDocument = new PdfDocument();
	//		pdfDocument.Info.Title = $"TAG PROMOÇÃO {DateTime.Now.ToString("dd-MM-yyyyy HHmmss")}";

	//		int itemsPerPage = 2;
	//		int totalPages = (int)Math.Ceiling((double)model.Count / itemsPerPage);
	//		int modelCount = model.Count - 1;
	//		int modelCurrent = 0;

	//		for (int i = 0; i < totalPages; i++)
	//		{
	//			tempCurrent = new ePanelPromocaoModel[2];
	//			tempCurrent[0] = modelCurrent <= modelCount ? model[modelCurrent] : null;
	//			modelCurrent++;
	//			tempCurrent[1] = modelCurrent <= modelCount ? model[modelCurrent] : null;
	//			modelCurrent++;


	//			PdfPage pdfPage = pdfDocument.AddPage();
	//			gfx = XGraphics.FromPdfPage(pdfPage);


	//			PrintPage(null, null);
	//			tempCurrent = null;
	//		}

	//		string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	//		string pdfFilePath = Path.Combine(desktopPath, $"{pdfDocument.Info.Title}.pdf");

	//		pdfDocument.Save(pdfFilePath);

	//		Process.Start(new ProcessStartInfo(pdfFilePath) { UseShellExecute = true });
	//	}

	//	private void PrintPage(object sender, PrintPageEventArgs e)
	//	{
	//		if (tempCurrent[0] == null)
	//		{
	//			return;
	//		}
	//		float marginLeft = 50f;
	//		float marginTop = 50f;
	//		float spacing = 30;
	//		// Top section

	//		marginTop += 140f;
	//		string text1 = tempCurrent[0].PRODUTO;
	//		gfx.DrawString(text1, font_title, XBrushes.Black, new XRect(marginLeft, marginTop, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);
	//		marginTop += spacing + 50f;

	//		string text3 = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT ?
	//			string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempCurrent[0].VALOR1)).ToUpper() :
	//			$"{string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempCurrent[0].VALOR1)).ToUpper()}   " +
	//			$"{string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempCurrent[0].VALOR2)).ToUpper()}";

	//		gfx.DrawString(text3, font_price, XBrushes.Black, new XRect(marginLeft, marginTop + 20, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);

	//		marginTop += spacing + 30;

	//		string text4 = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT ?
	//			$"{tempCurrent[0].DESC1}" :
	//			$"{tempCurrent[0].DESC1}                      {tempCurrent[0].DESC2}";

	//		gfx.DrawString(text4, font_subtitle, XBrushes.Black, new XRect(marginLeft, marginTop, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);

	//		if (tempCurrent[1] == null)
	//		{
	//			return;
	//		}
	//		marginTop += 290f;
	//		string text5 = tempCurrent[1].PRODUTO;
	//		gfx.DrawString(text5, font_title, XBrushes.Black, new XRect(marginLeft, marginTop, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);

	//		marginTop += spacing + 20;
	//		string text6 = "*R$999,99";
	//		string text7 = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT ?
	//			string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempCurrent[1].VALOR1)).ToUpper() :
	//			$"{string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempCurrent[1].VALOR1)).ToUpper()}   " +
	//			$"{string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempCurrent[1].VALOR2)).ToUpper()}";
	//		gfx.DrawString(text7, font_price, XBrushes.Black, new XRect(marginLeft, marginTop + 20, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);

	//		marginTop += spacing + 30;
	//		string text43 = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT ?
	//			$"{tempCurrent[1].DESC1}" :
	//			$"{tempCurrent[1].DESC1}                      {tempCurrent[1].DESC2}";
	//		gfx.DrawString(text43, font_subtitle, XBrushes.Black, new XRect(marginLeft, marginTop, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);
	//	}

	//}

	public class TagPromotionService2 : PrintResopitoryGeneric
	{
		private readonly List<ePanelPromocaoModel> model;
		private readonly FieldPrintSchemeEnum printSchemeEnum;
		private ePanelPromocaoModel[] tempCurrent = null;
		private int modelCurrent = 0;

		public TagPromotionService2(List<ePanelPromocaoModel> model, FieldPrintSchemeEnum printSchemeEnum)
		{
			this.model = model;
			this.printSchemeEnum = printSchemeEnum;
			SetPaper();
		}

		private void SetPaper()
		{
			float superior = 2.54f * 72 / 2.54f;
			float esquerda = 3.17f * 72 / 2.54f;
			float inferior = 2.54f * 72 / 2.54f;
			float direita = 3.17f * 72 / 2.54f;

			printDocument.DefaultPageSettings.Margins = new Margins((int)esquerda, (int)superior, (int)direita, (int)inferior);
			printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
			printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
		}

		public void Print()
		{
			modelCurrent = 0;
			printDocument.Print();
		}

		private void PrintPage(object sender, PrintPageEventArgs e)
		{

			if (model == null)
			{
				throw new ArgumentNullException("Model Nula: EterPharmaPro.Infrastructure.Services.Prints.TagPromotionService.PrintToPdf");
				return;
			}

			printDocument.DocumentName = $"TAG PROMOÇÃO {DateTime.Now.ToString("dd-MM-yyyyy HHmmss")}";

			int itemsPerPage = 2;
			int totalPages = (int)Math.Ceiling((double)model.Count / itemsPerPage);
			int currentPage = 1;
			int modelCount = model.Count - 1;
			int modelCurrent = 0;

			float marginLeft = 50f;
			float marginTop = 50f;
			float spacing = 30;


			Graphics gfx = e.Graphics;
			Font font_title = new Font("Arial Black", 20);
			Font font_price = new Font("Arial Black", 45);
			Font font_subtitle = new Font("Arial", 20);

			for (int i = 0; i < totalPages; i++)
			{
				tempCurrent = new ePanelPromocaoModel[2];
				tempCurrent[0] = modelCurrent <= modelCount ? model[modelCurrent] : null;
				modelCurrent++;
				tempCurrent[1] = modelCurrent <= modelCount ? model[modelCurrent] : null;
				modelCurrent++;

#region TOP

				if (tempCurrent[0] == null)
				{
					return;
				}

				marginTop += 140f;

				string text1 = tempCurrent[0].PRODUTO;
				gfx.DrawString(text1, font_title, Brushes.Black, marginLeft, marginTop, XStringFormats.Center);
				marginTop += spacing + 50f;

				string text3 = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT ?
					string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempCurrent[0].VALOR1)).ToUpper() :
					$"{string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempCurrent[0].VALOR1)).ToUpper()}   " +
					$"{string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempCurrent[0].VALOR2)).ToUpper()}";

				gfx.DrawString(text3, font_price, XBrushes.Black, new XRect(marginLeft, marginTop + 20, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);

				marginTop += spacing + 30;

				string text4 = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT ?
					$"{tempCurrent[0].DESC1}" :
					$"{tempCurrent[0].DESC1}                      {tempCurrent[0].DESC2}";

				gfx.DrawString(text4, font_subtitle, XBrushes.Black, new XRect(marginLeft, marginTop, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);
#endregion

#region BOTTOM
				if (tempCurrent[1] == null)
				{
					return;
				}
				marginTop += 290f;
				string text5 = tempCurrent[1].PRODUTO;
				gfx.DrawString(text5, font_title, XBrushes.Black, new XRect(marginLeft, marginTop, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);

				marginTop += spacing + 20;
				string text6 = "*R$999,99";
				string text7 = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT ?
					string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempCurrent[1].VALOR1)).ToUpper() :
					$"{string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempCurrent[1].VALOR1)).ToUpper()}   " +
					$"{string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempCurrent[1].VALOR2)).ToUpper()}";
				gfx.DrawString(text7, font_price, XBrushes.Black, new XRect(marginLeft, marginTop + 20, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);

				marginTop += spacing + 30;
				string text43 = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT ?
					$"{tempCurrent[1].DESC1}" :
					$"{tempCurrent[1].DESC1}                      {tempCurrent[1].DESC2}";
				gfx.DrawString(text43, font_subtitle, XBrushes.Black, new XRect(marginLeft, marginTop, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);
#endregion







				//PdfPage pdfPage = pdfDocument.AddPage();
				//gfx = XGraphics.FromPdfPage(pdfPage);


				//PrintPage(null, null);
				tempCurrent = null;


				// Verifica se há mais páginas
				if (currentPage < totalPages)
				{
					currentPage++;
					e.HasMorePages = true; // Sinaliza que há mais páginas
				}
				else
				{
					e.HasMorePages = false; // Fim da impressão
				}
			}























			//int count = 0;

			//while (modelCurrent < model.Count && count < itemsPerPage)
			//{
			//	ePanelPromocaoModel item = model[modelCurrent];
			//	modelCurrent++;
			//	count++;

			//	gfx.DrawString(item.PRODUTO, fontTitle, Brushes.Black, marginLeft, marginTop);
			//	marginTop += spacing + 50;

			//	string textPrice = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT ?
			//		string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(item.VALOR1)) :
			//		$"{string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(item.VALOR1))}   " +
			//		$"{string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(item.VALOR2))}";
			//	gfx.DrawString(textPrice, fontPrice, Brushes.Black, marginLeft, marginTop);
			//	marginTop += spacing + 30;

			//	string textDesc = printSchemeEnum == FieldPrintSchemeEnum.DEFAULT ?
			//		item.DESC1 :
			//		$"{item.DESC1}                      {item.DESC2}";
			//	gfx.DrawString(textDesc, fontSubtitle, Brushes.Black, marginLeft, marginTop);
			//	marginTop += 290;
			//}

			//e.HasMorePages = modelCurrent < model.Count;
		}
	}
}
