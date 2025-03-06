using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Controllers.Manipulacao;
using EterPharmaPro.Core;
using EterPharmaPro.Models;
using EterPharmaPro.Utils.Extencions;
using System.Globalization;

namespace EterPharmaPro.Views.Manipulados
{
	public partial class ReportManipulacao : Form
	{

		private List<ManipulationDbModel> manipulacaoModelsBusca;
		private readonly ManipuladoController manipuladoController;

		public ReportManipulacao()
		{
			InitializeComponent();
			manipuladoController = new ManipuladoController();
		}

		private void toolStrip_topMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) => this.Close();

		private async void ReportManipulacao_Load(object sender, EventArgs e)
		{
			comboBox_user.CBListGeneric(EterCache.Instance.EterDb.UserService.GetAllAsync().Result.ToList().Select(x => new ViewCbModel { ID = x.ID, NAME = $"{x.ID_LOJA.ToString().PadLeft(4, '0')} - {x.NOME}" }).ToList());

		}

		private async void ePictureBox_seach_Click(object sender, EventArgs e)
		{
			this.Focus();
			manipulacaoModelsBusca = await manipuladoController.GetManipulacaoFromUser(Convert.ToUInt32(comboBox_user.SelectedValue));
			RefreshGrid(manipulacaoModelsBusca);
		}

		private void RefreshGrid(List<ManipulationDbModel> query)
		{
			ListViewItem item = null;
			listView1.Items.Clear();
			for (int i = 0; i < query.Count; i++)
			{

				item = new ListViewItem(query[i].ID.ToString());
				item.SubItems.Add(query[i].UserModel.ID_LOJA.ToString().PadLeft(4, '0') + " - " + query[i].UserModel.NOME);
				item.SubItems.Add(query[i].DATA?.ToShortDateString());
				item.SubItems.Add(query[i].Client.NOME);
				item.SubItems.Add(string.Format(CultureInfo.CurrentCulture, "{0:C2}", query[i].VALORFINAL));
				item.SubItems.Add(query[i].OBSGERAL.ToString());
				listView1.Items.Add(item);
			}

		}

		private void dateTimePicker_dataBusca_ValueChanged(object sender, EventArgs e)
		{
			RefreshGrid(manipulacaoModelsBusca.Where(x => x.DATA?.ToShortDateString() == dateTimePicker_dataBusca.Value.ToShortDateString()).ToList());
		}

		private async void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (listView1.SelectedItems.Count > 0)
				{
					var temp = (await manipuladoController.GetManipulacao(Convert.ToUInt32(listView1.SelectedItems[0].SubItems[0].Text)));

					(new CreateManipulados(temp)).ShowDialog();
					ePictureBox_seach_Click(null, null);
					//dateTimePicker_dataBusca_ValueChanged(null, null);

				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
		}

		private async void eXCLUIRToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (EterCache.Instance.EterDbController.PermissionHas(manipuladoController.permissoesReport, Enums.PermissionEnum.DELETE))
			{
				try
				{
					if (listView1.SelectedItems.Count <= 0)
					{
						return;
					}
					int temp = int.Parse(listView1.SelectedItems[0]?.SubItems[0].Text);
					if (MessageBox.Show("Deseja excluir esse item ?\n" + listView1.SelectedItems[0]?.SubItems[3].Text, "Excluir Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && temp >= 0)
					{
						if (await manipuladoController.DeleteManipulacao(temp))
						{
							ePictureBox_seach_Click(null, null);
							//dateTimePicker_dataBusca_ValueChanged(null, null);
						}

					}
				}
				catch (Exception ex)
				{
					ex.ErrorGet();
				}
			}
			else
			{
				MessageBox.Show("Você não tem permissão.");
			}
		}
	}
}
