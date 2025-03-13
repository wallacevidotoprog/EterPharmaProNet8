using EterPharmaPro.Interfaces;
using EterPharmaPro.Views;
using System.Drawing.Printing;

namespace EterPharmaPro.Infrastructure.Services.Prints
{
	public class PrintResopitoryGeneric : IPrint
	{
		protected PrintDocument printDocument;

		public PrintResopitoryGeneric()
		{
			printDocument = new PrintDocument();
		}
		public void ShowPrintPreview()
		{
			PrintPreviewForm previewForm = new PrintPreviewForm(printDocument);
			previewForm.ShowDialog();
		}
	}
}
