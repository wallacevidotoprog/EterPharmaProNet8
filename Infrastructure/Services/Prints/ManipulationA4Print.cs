using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Core;
using System.Drawing.Printing;
using System.Globalization;
using System.Text;

namespace EterPharmaPro.Infrastructure.Services.Prints
{
	public class ManipulationA4Print : PrintResopitoryGeneric
	{
		private readonly ManipulationDbModel model;

		public ManipulationA4Print(ManipulationDbModel model)
		{
			this.model = model;

			printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

			printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 810, 900);
			printDocument.DefaultPageSettings.Margins = new Margins(20, 30, 20, 20);
			printDocument.DocumentName = $"Manipulação {DateTime.Now.ToString("dd-MM-yyyy (HH mm ss)")}";
		}

		private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
		{

			Font font = new Font("Courier New", 10);
			Font headerFont = new Font("Courier New", 12, FontStyle.Bold);
			Font priceFont = new Font("Courier New", 20, FontStyle.Bold);
			Brush backgroundBrush = new SolidBrush(Color.LightGray);
			Brush textBrush = Brushes.Black;
			Pen borderPen = Pens.Black;

			float x = e.MarginBounds.Left;
			float y = e.MarginBounds.Top;
			float lineHeight = font.GetHeight(e.Graphics) + 4;
			float tableWidth = e.PageBounds.Width - 2 * e.MarginBounds.Left;
			float tableHeight = 20 + (lineHeight * 2) + (lineHeight * 10);
			float pageWidth = e.MarginBounds.Width;

			string tempString = string.Empty;
			SizeF stringSize;

			tempString = $"FORMULÁRIO DE MANIPULAÇÃO LOJA {EterCache.Instance.SettingsApp.NUMBERSTORE.ToString().PadLeft(2, '0')}";
			stringSize = e.Graphics.MeasureString(tempString, headerFont);
			// Desenha o fundo cinza claro
			e.Graphics.FillRectangle(backgroundBrush, x, y, tableWidth, stringSize.Height + 5);

			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height + 5);

			e.Graphics.DrawString(tempString, headerFont, textBrush, (x + (pageWidth - stringSize.Width) / 2), y + 3);

			y += lineHeight + 6f;

			tempString = $"VENDEDOR(A): {model.UserModel.ID_LOJA}-{model.UserModel.NOME}";
			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height + 3);
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			tempString = $"DATA: {model.DATA?.ToShortDateString()}";
			SizeF valueSizedATA = e.Graphics.MeasureString(tempString, font);
			e.Graphics.DrawString(tempString, font, textBrush, (x + (pageWidth - valueSizedATA.Width) / 2), y + 4);
			tempString = $"ATENDENTE: {model.ATEN_MANI ?? "NÃO INFORMADO"}";
			SizeF valueSize = e.Graphics.MeasureString(tempString, font);
			e.Graphics.DrawString(tempString, font, textBrush, e.MarginBounds.Right - valueSize.Width - 5, y + 4);
			y += lineHeight + 5f;

			tempString = "DADOS DO CLIENTE";
			stringSize = e.Graphics.MeasureString(tempString, headerFont);

			e.Graphics.FillRectangle(backgroundBrush, x, y, tableWidth, stringSize.Height + 5);

			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height + 5);

			e.Graphics.DrawString(tempString, headerFont, textBrush, (x + (pageWidth - stringSize.Width) / 2), y + 3);

			y += lineHeight + 6f;
			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height * 6);


			int pad = 10;
			char ch = '.';


			tempString = $"{"NOME:".PadRight(pad, ch)}{model.Client.NOME}";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			y += lineHeight + 5f;
			if (!string.IsNullOrEmpty(model.Client.CPF))
			{
				tempString = $"{"CPF:".PadRight(pad, ch)}{model.Client.CPF}";
				e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
				y += lineHeight + 5f;
			}
			if (!string.IsNullOrEmpty(model.Client.RG))
			{
				tempString = $"{"RG:".PadRight(pad, ch)}{model.Client.RG}";
				e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
				y += lineHeight + 5f;

			}
			tempString = $"{"TELEFONE:".PadRight(pad, ch)}{model.Client.PHONE}";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			y += lineHeight + 5f;

			#region ENDEREÇO
			tempString = $"{"ENDEREÇO:".PadRight(pad, ch)}{model.AddressCliente.ToStringDrop()}";

			List<string> tempC = BreakStringIntoLines(tempString, font, pageWidth - 20, e.Graphics);

			for (int i = 0; i < tempC.Count; i++)
			{
				if (i >= 1)
				{
					e.Graphics.DrawString($"{"".PadRight(10, ' ')}" + tempC[i], font, Brushes.Black, x + 2, y + 4);
					y += lineHeight + 6f;
				}
				else
				{

					e.Graphics.DrawString(tempC[i], font, Brushes.Black, x + 2, y + 4);
					y += lineHeight + 6f;
				}
			}

			#endregion

			if (model.MedManipulation != null || model?.MedManipulation?.Count < 0)
			{
				tempString = "MEDICAMENTOS/ORÇAMENTOS";
				stringSize = e.Graphics.MeasureString(tempString, headerFont);

				e.Graphics.FillRectangle(backgroundBrush, x, y, tableWidth, stringSize.Height + 5);

				e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height + 5);

				int totalMed = model.MedManipulation.Count;

				e.Graphics.DrawString(tempString, headerFont, textBrush, (x + (pageWidth - stringSize.Width) / 2), y + totalMed);

				y += lineHeight + 6f;
				e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, (stringSize.Height + 5) * totalMed);

				foreach (var item in model.MedManipulation)
				{
					tempString = $"{item.NAME_M}";
					e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
					y += lineHeight + 5f;
				}
			}

			if (!string.IsNullOrEmpty(model?.OBSGERAL))
			{
				tempString = "INFORMAÇÕES ADICIONAIS";
				stringSize = e.Graphics.MeasureString(tempString, headerFont);

				e.Graphics.FillRectangle(backgroundBrush, x, y, tableWidth, stringSize.Height + 5);
				e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height + 5);

				// Desenha o cabeçalho

				int tempObs = model.OBSGERAL.Split('\r').Length;

				e.Graphics.DrawString(tempString, headerFont, textBrush, (x + (pageWidth - stringSize.Width) / 2), y + tempObs);

				y += lineHeight + 6f;
				e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, (stringSize.Height + 5) * tempObs);

				tempString = $"{model.OBSGERAL}";
				e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
				y += (lineHeight + 5f) * tempObs;
			}



			tempString = "DADOS DE GERAIS";
			stringSize = e.Graphics.MeasureString(tempString, headerFont);
			// Desenha o fundo cinza claro
			e.Graphics.FillRectangle(backgroundBrush, x, y, tableWidth, stringSize.Height + 5);


			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, stringSize.Height + 5);


			e.Graphics.DrawString(tempString, headerFont, textBrush, (x + (pageWidth - stringSize.Width) / 2), y + 3);

			y += lineHeight + 6f;

			e.Graphics.DrawRectangle(borderPen, x, y, tableWidth, (stringSize.Height + 5) * 3);
			tempString = $"{"SITUAÇÃO:".PadRight(21, ch)}{model.Situation.NAME}";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			y += lineHeight + 5f;
			tempString = $"{"FORMA DE PAGAMENTO:".PadRight(21, ch)}{model.Payment.NAME}";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);

			tempString = $"VALOR: {string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(model.VALORFINAL))}";
			SizeF priceSize = e.Graphics.MeasureString(tempString, priceFont);
			e.Graphics.DrawString(tempString, priceFont, textBrush, e.MarginBounds.Right - priceSize.Width - 5, y + 4);
			y += lineHeight + 5f;

			tempString = $"{"MODO DE ENTREGA:".PadRight(21, ch)}{model.DeliveryMethod.NAME}";
			e.Graphics.DrawString(tempString, font, Brushes.Black, x + 2, y + 4);
			y += lineHeight + 5f;


		}
		private List<string> BreakStringIntoLines(string text, Font font, float maxWidth, Graphics eg)
		{
			List<string> lines = new List<string>();
			string[] words = (from x in text.Split(' ')
							  where x != string.Empty
							  select x).ToArray();
			StringBuilder line = new StringBuilder();
			float lineWidth = 0f;
			string[] array = words;
			foreach (string word in array)
			{
				SizeF wordSize = eg.MeasureString(word + " ", font);
				if (lineWidth + wordSize.Width > maxWidth)
				{
					lines.Add(line.ToString().TrimEnd());
					line.Clear();
					lineWidth = 0f;
				}
				line.Append(word + " ");
				lineWidth += wordSize.Width;
			}
			if (line.Length > 0)
			{
				lines.Add(line.ToString().TrimEnd());
			}
			return lines;
		}

	}
}
