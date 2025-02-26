using System.Runtime.InteropServices;

namespace EterPharmaPro.Utils
{
	public static class ToastNotificationService
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

		public static void ShowToast(string text, string caption)
		{
			MessageBox(IntPtr.Zero, text, caption, 0);
		}
	}
}


