using EterPharmaPro.Controllers.Configs;
using EterPharmaPro.Models;
using EterPharmaPro.Utils.eControl;
using EterPharmaPro.Utils.Extencions;

namespace EterPharmaPro.Views.IMPRESSOS
{
	public partial class PromocaoTag : Form
	{
		private ConfigsPageController configsPageController;

		private ImputTagPromocao ImputTagPromocao;
		private List<(ePanelPromocaoModel model, ePanelPromocaoFd control)> ePanelsList;
		public PromocaoTag()
		{
			configsPageController = new ConfigsPageController();
			InitializeComponent();

			ePanelsList = new List<(ePanelPromocaoModel model, ePanelPromocaoFd control)>();
		}

		private void ePictureBox_add_Click(object sender, EventArgs e)
		{
			ImputTagPromocao = new ImputTagPromocao();
			ImputTagPromocao.ShowDialog();

			ePanelPromocaoModel tempModel = ImputTagPromocao.ePanelPromocaoModel;

			if (tempModel is null) return;


			tempModel.eIndex = ePanelsList.Count;

			ePanelPromocaoFd tempControl = new ePanelPromocaoFd(tempModel);
			tempControl.Dock = DockStyle.Top;

			tempControl.Btn_delete += Temp_Btn_delete;
			tempControl.Btn_update += Temp_Btn_update;

			panel_listPrints.Controls.Add(tempControl);

			ePanelsList.Add((tempModel, tempControl));
		}

		private void Temp_Btn_update(object? sender, int e)
		{
			ImputTagPromocao = new ImputTagPromocao(ePanelsList[e].model);
			ImputTagPromocao.ShowDialog();

			ePanelPromocaoModel tempModel = ImputTagPromocao.ePanelPromocaoModel;

			if (tempModel is null) return;


			foreach (ePanelPromocaoFd item in panel_listPrints.Controls)
			{
				if (item.model.eIndex == e)
				{
					item.model = tempModel;
					item.Refresh();

				}
			}
		}

		private void Refresh()
		{
			panel_listPrints.Controls.Clear();
			for (int i = ePanelsList.Count; i >= 0; i++)
			{
				var temp = ePanelsList[i].control;
				ePanelsList[i].model.eIndex= i;
				temp.model.eIndex = i;
				panel_listPrints.Controls.Add(temp);
			}
		}

		private void Temp_Btn_delete(object? sender, int e)
		{
			foreach (ePanelPromocaoFd item in panel_listPrints.Controls)
			{
				if (item.model.eIndex == e)
				{
					if (MessageBox.Show($"Deseja remover o item: {item.model.PRODUTO}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						panel_listPrints.Controls.Remove(item);
						ePanelsList.RemoveAt(e);
						Refresh();
						break;
					}

				}
			}

		}



	}
}
