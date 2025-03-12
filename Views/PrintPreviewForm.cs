using EterPharmaPro.Core;
using System.Drawing.Printing;

namespace EterPharmaPro.Views
{
	public partial class PrintPreviewForm : Form
	{
		private readonly PrintDocument printDocument;
		public readonly object dados;
		private TrackBar trackBar_zoom = new TrackBar();
		public PrintPreviewForm(PrintDocument printDocument, object dados)
		{
			InitializeComponent();
			this.dados = dados;
			this.printDocument = printDocument;
			printPreviewControl_preview.Document = printDocument;
			printPreviewControl_preview.Zoom = 3f;
		}



		public PrintPreviewForm(PrintDocument printDocument)
		{
			InitializeComponent();
			this.printDocument = printDocument;
			printPreviewControl_preview.Document = printDocument;
			printPreviewControl_preview.Zoom = 1f;
		}

		private void toolStripButton_save_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveDialog = new SaveFileDialog
			{
				Filter = "PDF Files|*.pdf",
				Title = "Salvar como PDF",
				FileName = printDocument.DocumentName
			};

			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				using (PrintDialog pd = new PrintDialog())
				{
					pd.Document = printDocument;
					pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
					pd.PrinterSettings.PrintFileName = saveDialog.FileName;
					pd.PrinterSettings.PrintToFile = true;

					printDocument.Print();
				}
			}
		}

		private void toolStripButton_print_Click(object sender, EventArgs e)
		{
			try
			{
				printDocument.PrinterSettings.PrinterName = EterCache.Instance.SettingsApp.settingsPoint.PRINT_DEFAULT;

				if (printDocument.PrinterSettings.IsValid)
				{
					printDocument.Print();
					MessageBox.Show("Impressão enviada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Erro: Impressora não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro ao imprimir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
