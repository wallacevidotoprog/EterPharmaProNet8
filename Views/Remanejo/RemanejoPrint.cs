using EterPharmaPro.Controllers.Impressos;
using EterPharmaPro.Core;
using EterPharmaPro.Models;

namespace EterPharmaPro.Views.Remanejo
{
	public partial class RemanejoPrint : Form
	{
		private readonly RemanejoController controller;
		public RemanejoPrint()
		{
			InitializeComponent();
			controller = new RemanejoController();
		}

		private void toolStripButton1_Click(object sender, EventArgs e) => this.Close();

		private void toolStripButton_print_Click(object sender, EventArgs e)
		{
			controller.Print(new RemanejoModel { LOJA = $"LOJA {EterCache.Instance.SettingsApp?.NUMBERSTORE}", DATA = dateTimePicker_data.Value, QTD = (int)numericUpDown_qtd.Value, OBS = textBox_obs.Text, NUM = textBox_num.Text });
		}
	}
}
