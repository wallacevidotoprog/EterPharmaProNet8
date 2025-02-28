using System.Drawing.Printing;

namespace EterPharmaPro.Infrastructure.Services.Prints
{
	public class ManipulationA4Print
	{
		private PrintDocument printDocument;
		private PrintPreviewDialog printPreviewDialog;

		public ManipulationA4Print()
		{
			printDocument = new PrintDocument();
			printPreviewDialog = new PrintPreviewDialog
			{
				Document = printDocument
			};

			printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
			printPreviewDialog.Document = printDocument;

			printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 810, 900);
			printDocument.DefaultPageSettings.Margins = new Margins(20, 30, 20, 20);
		}

		private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			// Definições básicas
			Font font = new Font("Arial", 10);
			Font headerFont = new Font("Arial", 12, FontStyle.Bold);
			Brush backgroundBrush = new SolidBrush(Color.LightGray);
			Brush textBrush = Brushes.Black;
			Pen borderPen = Pens.Black;

			float x = e.MarginBounds.Left;
			float y = e.MarginBounds.Top;
			float lineHeight = font.GetHeight(e.Graphics) + 4;
			float tableWidth = e.PageBounds.Width - 2 * e.MarginBounds.Left;
			float tableHeight = 20 + (lineHeight * 2) + (lineHeight * 10); // Ajustar altura da tabela
			float pageWidth = e.MarginBounds.Width;

			string tempString = string.Empty;
			SizeF stringSize;

			tempString = "FORMULÁRIO DE MANIPULAÇÃO";
			stringSize = e.Graphics.MeasureString(tempString, headerFont);
			// Desenha o fundo cinza claro
			e.Graphics.FillRectangle(backgroundBrush, x, y, tableWidth, stringSize.Height + 5);
			//e.Graphics.FillRectangle(backgroundBrush, e.MarginBounds.Left, e.MarginBounds.Top, tableWidth, tableHeight);
			// Desenha o retângulo para a tabela
			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height + 5);
			//e.Graphics.DrawRectangle(borderPen, e.MarginBounds.Left, e.MarginBounds.Top, tableWidth, tableHeight);
			// Desenha o cabeçalho
			e.Graphics.DrawString(tempString, headerFont, textBrush, (x + (pageWidth - stringSize.Width) / 2), y + 3);
			//y += (font.GetHeight(e.Graphics) + 4) * 2; // Espaço após o cabeçalho
			y += lineHeight + 6f;

			tempString = "VENDEDOR(A): WALLACE";
			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height + 3);
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			tempString = $"DATA: {DateTime.Now.ToShortDateString()}";
			SizeF valueSizedATA = e.Graphics.MeasureString(tempString, font);
			e.Graphics.DrawString(tempString, font, textBrush, (x + (pageWidth - valueSizedATA.Width) / 2), y + 4);
			tempString = $"ATENDENTE: JOACIR CAMPOS";
			SizeF valueSize = e.Graphics.MeasureString(tempString, font);
			e.Graphics.DrawString(tempString, font, textBrush, e.MarginBounds.Right - valueSize.Width - 5, y + 4);
			y += lineHeight + 5f;

			tempString = "DADOS DO CLIENTE";
			stringSize = e.Graphics.MeasureString(tempString, headerFont);
			// Desenha o fundo cinza claro
			e.Graphics.FillRectangle(backgroundBrush, x, y, tableWidth, stringSize.Height + 5);
			//e.Graphics.FillRectangle(backgroundBrush, e.MarginBounds.Left, e.MarginBounds.Top, tableWidth, tableHeight);
			// Desenha o retângulo para a tabela
			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height + 5);
			//e.Graphics.DrawRectangle(borderPen, e.MarginBounds.Left, e.MarginBounds.Top, tableWidth, tableHeight);
			// Desenha o cabeçalho
			e.Graphics.DrawString(tempString, headerFont, textBrush, (x + (pageWidth - stringSize.Width) / 2), y + 3);
			//y += (font.GetHeight(e.Graphics) + 4) * 2; // Espaço após o cabeçalho
			y += lineHeight + 6f;
			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height * 6);

			tempString = "NOME.........: WALLACE VIDOTO DE MIRANDA";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			y += lineHeight + 5f;
			tempString = "CPF...........: 555.555.555-55";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			y += lineHeight + 5f;
			tempString = "RG............: 55.555.555-2";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			y += lineHeight + 5f;
			tempString = "TELEFONE......: (17) 9 9999-9999";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			y += lineHeight + 5f;
			tempString = "ENDEREÇO.: RUA PROJETADA 2 NUMERO 72 ESTANCIA BELA VISTA SÃO JOSÉ DO RIO PRETO -SP";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			y += lineHeight + 7f;

			tempString = "MEDICAMENTOS";
			stringSize = e.Graphics.MeasureString(tempString, headerFont);
			// Desenha o fundo cinza claro
			e.Graphics.FillRectangle(backgroundBrush, x, y, tableWidth, stringSize.Height + 5);

			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height + 5);

			e.Graphics.DrawString(tempString, headerFont, textBrush, (x + (pageWidth - stringSize.Width) / 2), y + 3);

			y += lineHeight + 6f;
			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, (stringSize.Height + 5) * 3);
			for (int i = 0; i < 3; i++)
			{
				tempString = $"MEDICAMENTO {i}";
				e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
				y += lineHeight + 5f;
			}

			tempString = "INFORMAÇÕES ADICIONAIS";
			stringSize = e.Graphics.MeasureString(tempString, headerFont);

			e.Graphics.FillRectangle(backgroundBrush, x, y, tableWidth, stringSize.Height + 5);


			// Desenha o cabeçalho
			e.Graphics.DrawString(tempString, headerFont, textBrush, (x + (pageWidth - stringSize.Width) / 2), y + 3);

			y += lineHeight + 6f;
			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, (stringSize.Height + 5) * 3);
			for (int i = 0; i < 3; i++)
			{
				tempString = $"RECEITA {i}";
				e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
				y += lineHeight + 5f;
			}


			tempString = "DADOS DE GERAIS";
			stringSize = e.Graphics.MeasureString(tempString, headerFont);
			// Desenha o fundo cinza claro
			e.Graphics.FillRectangle(backgroundBrush, x, y, tableWidth, stringSize.Height + 5);


			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height + 5);


			e.Graphics.DrawString(tempString, headerFont, textBrush, (x + (pageWidth - stringSize.Width) / 2), y + 3);

			y += lineHeight + 6f;

			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, (stringSize.Height + 5) * 3);
			tempString = "SITUAÇÃO: ESTÁ PAGO";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			y += lineHeight + 5f;
			tempString = "FORMA DE PAGAMENTO:   DINHEIRO";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);

			tempString = "VALOR: R$ 555,99";
			SizeF priceSize = e.Graphics.MeasureString(tempString, font);
			e.Graphics.DrawString(tempString, font, textBrush, e.MarginBounds.Right - priceSize.Width - 5, y + 4);
			y += lineHeight + 5f;

			tempString = "MODO DE ENTREGA:  ENTREGAR NA RESIDENCIA DO CLIENTE";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			y += lineHeight + 5f;


		}
	}
}
