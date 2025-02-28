using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Drawing.Printing;

namespace EterPharmaPro.Infrastructure.Services.Prints
{
	public class TagPromotion
	{
		private PrintDocument printDocument = new PrintDocument();
		private PdfDocument pdfDocument;
		private XGraphics gfx;
		private XFont font_title = new XFont("Arial Black", 20); // Usando 1 para Bold
		private XFont font_price = new XFont("Arial Black", 45);  // Usando 1 para Bold
		private XFont font_subtitle = new XFont("Arial", 20); // Usando 1 para Bold

		public TagPromotion()
		{
			// Configurar o tamanho de página para A4
			printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // Dimensões em décimos de polegada (210mm x 297mm)

			// Definir as margens conforme especificado em cm (convertido para pontos)
			float superior = 2.54f * 72 / 2.54f;
			float esquerda = 3.17f * 72 / 2.54f;
			float inferior = 2.54f * 72 / 2.54f;
			float direita = 3.17f * 72 / 2.54f;

			printDocument.DefaultPageSettings.Margins = new Margins((int)esquerda, (int)superior, (int)direita, (int)inferior);

			// Registrar o evento PrintPage
			printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
		}

		public void PrintToPdf()
		{
			// Criar o documento PDF
			pdfDocument = new PdfDocument();
			pdfDocument.Info.Title = "ESC DENTAL AMIS TECH";

			// Criar uma página no PDF
			PdfPage pdfPage = pdfDocument.AddPage();
			gfx = XGraphics.FromPdfPage(pdfPage);

			// Gerar conteúdo e salvar como PDF
			PrintPage(null, null);

			// Caminho do arquivo PDF na área de trabalho
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string pdfFilePath = Path.Combine(desktopPath, "output2.pdf");

			// Salvar o PDF no caminho especificado
			pdfDocument.Save(pdfFilePath);

			// Opcional: Informar que o PDF foi gerado
			//MessageBox.Show("PDF salvo com sucesso em: " + pdfFilePath);
		}

		private void PrintPage(object sender, PrintPageEventArgs e)
		{
			float marginLeft = 50f;
			float marginTop = 50f;
			float spacing = 30;
			// Top section

			marginTop += 140f;
			string text1 = "ESC DENTAL AMIS TECH";
			gfx.DrawString(text1, font_title, XBrushes.Black, new XRect(marginLeft, marginTop, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);
			marginTop += spacing + 50f;
			string text2 = "*R$999,99";
			string text3 = "R$999,99" + "   " + text2;
			gfx.DrawString(text3, font_price, XBrushes.Black, new XRect(marginLeft, marginTop + 20, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);

			marginTop += spacing + 30;
			string text4 = "APARTIR DE" + "                     " + "APARTIR DE";
			gfx.DrawString(text4, font_subtitle, XBrushes.Black, new XRect(marginLeft, marginTop, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);

			// Bottom section
			marginTop += 290f;
			string text5 = "ESC DENTAL AMIS TECH";
			gfx.DrawString(text5, font_title, XBrushes.Black, new XRect(marginLeft, marginTop, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);

			marginTop += spacing + 20;
			string text6 = "*R$999,99";
			string text7 = "R$999,99" + "   " + text6;
			gfx.DrawString(text7, font_price, XBrushes.Black, new XRect(marginLeft, marginTop + 20, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);

			marginTop += spacing + 30;
			string text43 = "APARTIR DE" + "                   " + "APARTIR DE";
			gfx.DrawString(text43, font_subtitle, XBrushes.Black, new XRect(marginLeft, marginTop, pdfDocument.Pages[0].Width - 2 * marginLeft, 0), XStringFormats.Center);
		}

	}
}
