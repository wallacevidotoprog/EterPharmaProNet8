using System.Drawing.Printing;

namespace EterPharmaPro.Utils.Events
{
	public class CountPagesEventArgs : PrintEventArgs
	{
		public int TotalPages { get; }

		public CountPagesEventArgs(int totalPages)
		{
			TotalPages = totalPages;
		}
	}
}
