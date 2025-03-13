using EterPharmaPro.Interfaces;
using EterPharmaPro.Utils.Events;
using EterPharmaPro.Utils.Subclasse;
using EterPharmaPro.Views;
using System.Drawing.Printing;

namespace EterPharmaPro.Infrastructure.Services.Prints
{
	public class PrintResopitoryGeneric : IPrint
	{
		public event EventHandler<CountPagesEventArgs> PagesCount;

		protected ePrintDocument printDocument;

		public int totalPages { get; set; }

		public PrintResopitoryGeneric()
		{
			printDocument = new ePrintDocument();

			printDocument.EndPrint += PrintDocument_EndPrint;

		}

		private void PrintDocument_EndPrint(object sender, PrintEventArgs e)
		{
			printDocument.totalPages = totalPages;
		}

		public void ShowPrintPreview()
		{
			PrintPreviewForm previewForm = new PrintPreviewForm(printDocument);
			previewForm.ShowDialog();
		}
		
	}
}
