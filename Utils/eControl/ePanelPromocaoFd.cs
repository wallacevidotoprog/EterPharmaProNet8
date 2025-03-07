using EterPharmaPro.Models;
using System.ComponentModel;
using System.Globalization;

namespace EterPharmaPro.Utils.eControl
{
	public partial class ePanelPromocaoFd : UserControl
	{
		public event EventHandler<int> Btn_update;
		public event EventHandler<int> Btn_delete;

		public ePanelPromocaoModel model;
		public ePanelPromocaoFd(ePanelPromocaoModel model)
		{
			this.model = model;
			InitializeComponent();

			ePictureBox_update.Click += EPictureBox_update_Click;
			ePictureBox_delete.Click += EPictureBox_delete_Click;


			Refresh();

		}

		public void Refresh()
		{
			textBox_name.Text = model.PRODUTO;
			textBox_V1.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(model.VALOR1)).ToUpper();
			textBox_TV1.Text = model.DESC1;
			textBox_V2.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(model.VALOR2)).ToUpper();
			textBox_TV2.Text = model.DESC2;
		}

		[Browsable(true)]
		[Category("Custom")]
		private void EPictureBox_delete_Click(object? sender, EventArgs e)
		{
			Btn_delete.Invoke(this, model.eIndex);
		}

		[Browsable(true)]
		[Category("Custom")]
		private void EPictureBox_update_Click(object? sender, EventArgs e)
		{
			Btn_update.Invoke(this, model.eIndex);
		}
	}
}
