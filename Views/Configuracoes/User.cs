using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Controllers.Configs;
using EterPharmaPro.Core;
using EterPharmaPro.Models;
using EterPharmaPro.Properties;
using EterPharmaPro.Utils.Extencions;

namespace EterPharmaPro.Views.Configuracoes
{

	public partial class User : Form
	{
		private bool isNew = false;
		private bool isEdit;
		private UserDbModel userModel = null;
		private List<PositionDbModel> positionModel = null;

		private readonly ConfigsPageController configsPageController;
		public User(ConfigsPageController configsPageController)
		{
			this.configsPageController = configsPageController;
			InitializeComponent();
		}
		private void OpenSaveUp()
		{
			toolStripButton_new_save.Image = Resources.salve;
			toolStripButton_cancel.Visible = true;
			groupBox_create.Visible = true;
			toolStripButton_send.Visible = false;
		}

		private void ClearFieldReq()
		{
			groupBox_create.Visible = false;
		}
		private async void toolStripButton_new_save_Click(object sender, EventArgs e)
		{
			if (!isNew && !isEdit)
			{
				OpenSaveUp();
				isNew = true;
			}
			else
			{
				userModel = userModel ?? new UserDbModel();


				userModel.ID_LOJA = !string.IsNullOrEmpty(textBox_id.Text) ? Convert.ToUInt32(textBox_id.Text.ReturnInt()) : RenerateID();
				userModel.NOME = textBox_nome.Text.ToUpper();
				userModel.PASS = string.IsNullOrEmpty(textBox_pass.Text) ? null : textBox_pass.Text;
				userModel.ID_FUNCAO = positionModel.FirstOrDefault(x => x.ID == Convert.ToInt32(comboBox_funcao.SelectedValue)).ID;
				userModel.STATUS = eSwitchControl_stats.Checked;


				if (isEdit)
				{
					if (await configsPageController.UpdateUser(userModel))
					{
						isEdit = false;
					}
				}
				else
				{
					if (await configsPageController.CreateUser(userModel))
					{
						isNew = false;
					}
				}

				toolStripButton_cancel_Click(null, null);
				User_Load(null, null);
			}
		}

		private long? RenerateID()
		{
			List<long?> ids = EterCache.Instance.EterDb.UserService.GetAllAsync().Result.Select(x => x.ID_LOJA).ToList();


			while (true)
			{
				long? id = GeneteID();
				if (!ids.Contains(id))
				{
					return id;
				}
			}

		}
		private long? GeneteID()
		{
			Random random = new Random();
			return Convert.ToUInt32(random.Next(1, 9999));
		}

		private void toolStripButton_cancel_Click(object sender, EventArgs e)
		{
			userModel = null;
			toolStripButton_new_save.Image = Resources.documento_new;
			toolStripButton_cancel.Visible = false;
			toolStripButton_send.Visible = true;
			ClearFieldReq();
			isNew = false;
			isEdit = false;
		}

		private async void User_Load(object sender, EventArgs e)
		{
			positionModel = EterCache.Instance.EterDb.PositionService.GetAllAsync().Result.ToList();

			comboBox_funcao.CBListGeneric(positionModel.Select(x => new ViewCbModel { ID = x.ID, NAME = x.NOME ?? "Err" }).ToList());
			dataGridView_user.DataSource = await configsPageController.GetAllUser();
		}

		private async void dataGridView_user_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			userModel = await configsPageController.GetUser(Convert.ToUInt32(dataGridView_user.Rows[e.RowIndex].Cells[0].Value));

			if (userModel is null) { return; }

			textBox_id.Text = userModel.ID_LOJA.ToString();
			textBox_nome.Text = userModel.NOME;
			textBox_pass.Text = userModel.PASS;
			comboBox_funcao.SelectedIndex = comboBox_funcao.ReturnIndexCbGeneric(userModel.Position.ID);
			eSwitchControl_stats.Checked = userModel.STATUS;

			isEdit = true;

			OpenSaveUp();
		}
	}
}
