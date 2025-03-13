using EterPharmaPro.Utils.Events;
using System.Drawing.Printing;

namespace EterPharmaPro.Utils.Subclasse
{
	public class ePrintDocument : PrintDocument
	{
		public event EventHandler<CountPagesEventArgs> PagesCount;
		public int totalPages = 1;

		protected override void OnEndPrint(PrintEventArgs e)
		{
			base.OnEndPrint(e);

			PagesCount?.Invoke(this, new CountPagesEventArgs(totalPages));
		}
	}
}
	

