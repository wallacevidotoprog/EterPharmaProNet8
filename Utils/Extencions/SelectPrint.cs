using EterPharmaPro.Enums;

namespace EterPharmaPro.Utils.Extencions
{
	public partial class SelectPrint : Form
	{
		private static EnumManipulado sta = EnumManipulado.NONE;
		public SelectPrint()
		{
			InitializeComponent();
		}

		public static new EnumManipulado Show()
		{

			using (SelectPrint inputDate = new SelectPrint())
			{
				return inputDate.ShowDialog() == DialogResult.OK ? sta : EnumManipulado.NONE;
			}
		}
		private void ePictureBox_termal_Click(object sender, EventArgs e)
		{
			this.Focus();

			sta = EnumManipulado.P_80;
			base.DialogResult = DialogResult.OK;
		}

		private void ePictureBox_default_Click(object sender, EventArgs e)
		{
			this.Focus();

			sta = EnumManipulado.A4;
			base.DialogResult = DialogResult.OK;
		}
	}
}
