﻿using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Controllers.Validade;
using EterPharmaPro.Core;
using EterPharmaPro.Enums;
using EterPharmaPro.Models;
using EterPharmaPro.Properties;
using EterPharmaPro.Utils.Extencions;

namespace EterPharmaPro.Views.Validade
{
	public partial class CreateValidade : Form
	{
		private List<UserDbModel> userModels;
		private List<ViewCbModel> userViewModels;

		private readonly ValidadeController validadeController;

		private SetValityModel setValityModel;

		bool isActionValidade = false;
		bool isEditProduto = false;
		int indexEditLv = -1;


		public CreateValidade()
		{
			InitializeComponent();

			validadeController = new ValidadeController();
		}

		private async void CreateValidade_LoadAsync(object sender, EventArgs e)
		{
			userModels = (await EterCache.Instance.EterDb.UserService.GetAllIncudeAsync()).ToList().Where(x => x.STATUS == true).ToList();
			userViewModels = userModels.Select(x => new ViewCbModel { ID = x.ID, NAME = $"{x.ID_LOJA.ToString().PadRight(4, '0')} - {x.NOME}" }).ToList();

			contextMenuStrip_produtos.Enabled = false;
			dateTimePicker_dataBusca.Value = DateTime.Now.DateTimeDay();
			comboBox_user.CBListGeneric(userViewModels);
		}

		private void toolStripButton_exit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja sair o formulário ?", base.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void VisibleHeaderDoc(bool state)
		{
			groupBox_ne.Visible = state;
			comboBox_user.Enabled = state;

			dateTimePicker_dataD.Enabled = state;
			dateTimePicker_dataD.Value = DateTime.Now;


			groupBox_ne.Size = state ? new Size(566, 88) : new Size(566, 350);
			comboBox_user.Enabled = state;
			dateTimePicker_dataD.Enabled = state;
		}

		private void VisibleBodyDoc(bool state)
		{
			groupBox_ne.Size = state ? new Size(566, 350) : new Size(566, 88);
			groupBox_insert.Visible = state;
			comboBox_user.Enabled = !state;
			dateTimePicker_dataD.Enabled = !state;
			contextMenuStrip_produtos.Enabled = state;
			listView1.Items.Clear();
		}

		private void NewDocValidade(bool stats)
		{
			VisibleHeaderDoc(stats);
			VisibleBodyDoc(!stats);
		}

		private void toolStripDropDownButton_new_Click(object sender, EventArgs e)
		{
			if (isActionValidade)
			{
				if (MessageBox.Show("Existe um arquivo aberto, deseja fecha-lo ?\n(As alterações serão salvas)", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
				{
					return;
				}
			}
			toolStripButton_clear_Click(null, null);
			NewDocValidade(true);
			comboBox_user.SelectedIndex = comboBox_user.ReturnIndexCbGeneric(EterCache.Instance.UserDbModel.ID);

		}

		private async Task RefreshCbC()
		{

			List<ViewCbModel> temoC = (await EterCache.Instance.EterDb.UserService.GetByAsync(f => f.ID == setValityModel.user_id, i => i.Category))
				.Category.Select(x => new ViewCbModel { ID = x.ID, NAME = x.NAME ?? string.Empty })
				.ToList();

			temoC.Add(new ViewCbModel { ID = 1, NAME = "SEM CATEGORIA" });

			comboBox_categoria.CBListGeneric(temoC);
		}
		private async void ePictureBox_create_Click(object sender, EventArgs e)
		{
			if (isActionValidade)
			{
				toolStripDropDownButton_new_Click(null, null);
				return;
			}
			VisibleBodyDoc(true);
			isActionValidade = true;
			ePictureBox_sava_up.Image = Resources.arquivo__1_;
			this.Focus();


			setValityModel = new SetValityModel();
			setValityModel.user_id = Convert.ToUInt32(comboBox_user.SelectedValue);
			setValityModel.dataCreate = Convert.ToDateTime(dateTimePicker_dataD.Value);

			setValityModel.vality_id = await validadeController.CreateNewDocVality(setValityModel);

			RefreshCbC();

			RefreshCategoryAsync(null, ListViewActionsEnum.INIT);
			ePictureBox_seach_Click(null, null);
		}


		private async void ePictureBox_addCat_ClickAsync(object sender, EventArgs e)
		{
			string result = InputBox.Show("Por favor, insira a categoria:", "Categoria");
			if (!string.IsNullOrEmpty(result))
			{
				long? resulAddCat = await validadeController.CreateCategory(setValityModel.user_id, result);
				if (resulAddCat > 0)
				{
					RefreshCbC();
					RefreshCategoryAsync((resulAddCat, result), ListViewActionsEnum.ADD);
				}
			}

		}

		private async void ePictureBox_removeCat_ClickAsync(object sender, EventArgs e)
		{
			if (comboBox_categoria.SelectedIndex == 0)
			{
				return;
			}
			int tempRemove = Convert.ToInt32(comboBox_categoria.SelectedValue);
			string tempName = comboBox_categoria.Text;
			if (MessageBox.Show("Deseja excluir esse categoria ?\n" + comboBox_categoria.Text + "\nAo deletar essa categoria você pode alterar outros formulários que já foram lançados.", "Excluir Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				if (await validadeController.DeleteCategory(tempRemove))
				{
					RefreshCbC();
				}
			}

		}


		private async void RefreshCategoryAsync((long? id, string namec)? cat, ListViewActionsEnum actionsEnum = ListViewActionsEnum.NONE)
		{
			var tempCat = await validadeController.GetCategoryUser();
			switch (actionsEnum)
			{
				case ListViewActionsEnum.INIT:
					listView1.Groups.Add(new ListViewGroup(1.ToString(), "SEM CATEGORIA"));
					for (int i = 0; i < tempCat.Count; i++)
					{
						var groupAd = listView1.Groups.Cast<ListViewGroup>().Where(x => x.Header == tempCat[i].NAME).FirstOrDefault();
						if (groupAd is null)
						{
							listView1.Groups.Add(new ListViewGroup(tempCat[i].ID.ToString(), tempCat[i].NAME));
						}
					}
					break;
				case ListViewActionsEnum.ADD:
					listView1.Groups.Add(new ListViewGroup(cat.Value.id.ToString(), cat.Value.namec));
					break;
				case ListViewActionsEnum.UPDATE:
					break;
				case ListViewActionsEnum.REMOVE:
					ListViewGroup novoGrupo = listView1.Groups.Cast<ListViewGroup>()
					 .FirstOrDefault(g => g.Name == 1.ToString());

					foreach (ListViewItem item in listView1.Items)
					{
						if (item.Group.Header == cat.Value.namec.ToString())
						{
							item.Group = novoGrupo;
						}
					}
					break;
			}



		}

		private void textBox_codigo_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				bool inLoadProd = false;
				if (textBox_codigo.Text.Trim().Replace(" ", null) == "")
				{
					List<ProdutosModel> tempQuery = validadeController.GetAllProdutos(out inLoadProd);
					textBox_codigo.Text = tempQuery == null ? string.Empty : InputListProduto.Show(tempQuery, "Busca de Produtos").ToString().PadLeft(6, '0'); ;
				}
				if (!inLoadProd)
				{
					GetProduct();
				}

			}
		}
		private bool GetProduct()
		{
			bool tempBool = false;
			try
			{
				ProdutosModel tempProdutos = validadeController.GetProduto(textBox_codigo.Text, out bool inLoad);

				if (inLoad)
				{
					return false;
				}

				if (tempProdutos != null)
				{
					textBox_nproduto.Text = tempProdutos.DESCRICAO_PRODUTO;

					tempBool = (textBox_nproduto.ReadOnly = true);
					numericUpDown_qtd.Focus();
				}
				else
				{
					MessageBox.Show("Código não encontrado.\nDigite o nome do produto no campo a baixo do código.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					textBox_nproduto.ReadOnly = false;
					textBox_nproduto.Focus();
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
			return tempBool;
		}

		private async void ePictureBox_sava_up_Click(object sender, EventArgs e)
		{
			this.Focus();

			try
			{

				setValityModel.produto = setValityModel.produto ?? new ProdutoSetValityModel();

				ProdutosModel tempProdutos = validadeController.GetProduto(textBox_codigo.Text, out bool inLoad);
				if (inLoad)
				{
					return;
				}

				setValityModel.produto.codigo = tempProdutos is null ? Convert.ToInt32(textBox_codigo.Text) : Convert.ToInt32(tempProdutos.COD_PRODUTO);
				setValityModel.produto.descricao = tempProdutos is null ? textBox_nproduto.Text : tempProdutos.DESCRICAO_PRODUTO;
				setValityModel.produto.quantidade = (int)numericUpDown_qtd.Value;
				setValityModel.produto.dateVality = dateTimePicker_data.Value;
				setValityModel.produto.category_id = Convert.ToInt32(comboBox_categoria.SelectedValue);

				bool isSetClear = false;

				if (!isEditProduto)
				{
					(bool result, long? id) = await validadeController.CreateProdutoVality(setValityModel);
					if (result)
					{
						setValityModel.produto.id = id;

						ListViewAction(setValityModel.produto, ListViewActionsEnum.ADD);
					}

					isSetClear = result;
				}
				else if (isEditProduto)
				{

					isSetClear = await validadeController.UpdateProdutoVality(setValityModel);
					isEditProduto = false;
					if (isSetClear)
					{
						ListViewAction((indexEditLv, setValityModel.produto), ListViewActionsEnum.UPDATE);
					}
				}


				if (isSetClear)
				{
					indexEditLv = -1;
					setValityModel.produto = null;
					textBox_codigo.Clear();
					textBox_nproduto.Clear();
					textBox_nproduto.ReadOnly = true;
					numericUpDown_qtd.Value = 1;
					dateTimePicker_data.Value = DateTime.Today;
					ePictureBox_sava_up.Image = Resources.arquivo__1_;
				}
				textBox_codigo.Focus();

			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
		}

		private void toolStripButton_clear_Click(object sender, EventArgs e)
		{
			isActionValidade = false;
			setValityModel = null;
			textBox_codigo.Clear();
			textBox_nproduto.Clear();
			textBox_nproduto.ReadOnly = true;
			numericUpDown_qtd.Value = 1;
			dateTimePicker_data.Value = DateTime.Today;
			contextMenuStrip_produtos.Enabled = false;
			NewDocValidade(false);

		}

		private async void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (listView1.SelectedItems.Count > 0)
				{
					ProductValidadeDbModal tempProduto = await validadeController.GetProdutoDb(listView1.SelectedItems[0].SubItems[0].Text);
					if (tempProduto != null)
					{
						isEditProduto = true;
						setValityModel.produto = new ProdutoSetValityModel();
						indexEditLv = Convert.ToInt32(listView1.SelectedItems[0].Index);
						setValityModel.produto.id = tempProduto.ID;
						textBox_codigo.Text = (setValityModel.produto.codigo = tempProduto.PRODUTO_CODIGO).ToString().PadLeft(6, '0');
						textBox_nproduto.Text = setValityModel.produto.descricao = tempProduto.PRODUTO_DESCRICAO;
						setValityModel.produto.quantidade = tempProduto.QUANTIDADE;
						numericUpDown_qtd.Value = (decimal)tempProduto.QUANTIDADE;
						setValityModel.produto.dateVality = tempProduto.DATA_VALIDADE;
						dateTimePicker_data.Value = (DateTime)tempProduto.DATA_VALIDADE;
						setValityModel.produto.category_id = Convert.ToInt32(tempProduto.ID_CATEGORIA);
						comboBox_categoria.SelectedIndex = comboBox_categoria.ReturnIndexCbGeneric(setValityModel.produto.category_id);

						ePictureBox_sava_up.Image = Resources.arquivo_update;
					}

				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
		}

		private async void eXCLUIRToolStripMenuItem_ClickAsync(object sender, EventArgs e)
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
					if (await validadeController.DeleteProduto(temp))
					{
						ListViewAction(listView1.SelectedItems[0], ListViewActionsEnum.REMOVE);
					}

				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
		}

		private async void ListViewAction(object action, ListViewActionsEnum actionsEnum = ListViewActionsEnum.NONE)
		{
			ListViewItem item = null;
			try
			{
				switch (actionsEnum)
				{
					case ListViewActionsEnum.ADD:
						ProdutoSetValityModel tempObjAd = (ProdutoSetValityModel)action;

						string getcat = validadeController.GetCategory(tempObjAd.category_id);

						var groupAd = listView1.Groups.Cast<ListViewGroup>().Where(x => x.Header == getcat).FirstOrDefault();//se não tiver add

						groupAd = groupAd ?? listView1.Groups.Cast<ListViewGroup>().Where(x => x.Header == "SEM CATEGORIA").FirstOrDefault();



						item = new ListViewItem(tempObjAd.id.ToString());
						item.SubItems.Add(tempObjAd.codigo.ToString().PadLeft(6, '0'));
						item.SubItems.Add(tempObjAd.descricao);
						item.SubItems.Add(tempObjAd.quantidade.ToString());
						item.SubItems.Add(tempObjAd.dateVality?.ToShortDateString());
						item.Group = groupAd;
						listView1.Items.Add(item);
						listView1.Refresh();

						break;
					case ListViewActionsEnum.UPDATE:
						(int indexUp, ProdutoSetValityModel newUp) tempObjUp = ((int indexUp, ProdutoSetValityModel newUp))action;
						listView1.Items[tempObjUp.indexUp].Text = tempObjUp.newUp.id.ToString();
						listView1.Items[tempObjUp.indexUp].SubItems[1].Text = tempObjUp.newUp.codigo.ToString().PadLeft(6, '0');
						listView1.Items[tempObjUp.indexUp].SubItems[2].Text = tempObjUp.newUp.descricao.ToString();
						listView1.Items[tempObjUp.indexUp].SubItems[3].Text = tempObjUp.newUp.quantidade.ToString();
						listView1.Items[tempObjUp.indexUp].SubItems[4].Text = tempObjUp.newUp.dateVality?.ToShortDateString();
						listView1.Items[tempObjUp.indexUp].Group = listView1.Groups.Cast<ListViewGroup>().Where(x => x.Name == tempObjUp.newUp.category_id.ToString()).FirstOrDefault();
						break;
					case ListViewActionsEnum.REMOVE:
						listView1.Items.Remove((ListViewItem)action);//listView1.Items[0]
						break;

					case ListViewActionsEnum.UPGRADE:
						List<ProductValidadeDbModal> tempObjUg = (List<ProductValidadeDbModal>)action;

						List<(long? cat_id, string cat_name)> tempCategoriasSelect = await validadeController.GetCategoryList(tempObjUg.GroupBy(p => p.ID_CATEGORIA).Select(g => g.Key).ToList());


						for (int i = 0; i < tempCategoriasSelect.Count; i++)
						{
							ListViewGroup groupUp = new ListViewGroup(tempCategoriasSelect[i].cat_name, HorizontalAlignment.Left);
							listView1.Groups.Add(groupUp);

							List<ProductValidadeDbModal> tp = tempObjUg.Where(x => x.ID_CATEGORIA == tempCategoriasSelect[i].cat_id).ToList();

							for (int x = 0; x < tp.Count; x++)
							{
								item = new ListViewItem(tp[x].ID.ToString());
								item.SubItems.Add(tp[x].PRODUTO_CODIGO.ToString().PadLeft(6, '0'));
								item.SubItems.Add(tp[x].PRODUTO_DESCRICAO);
								item.SubItems.Add(tp[x].QUANTIDADE.ToString());
								item.SubItems.Add(tp[x].DATA_VALIDADE?.ToString("dd/MM/yyyy"));
								item.Group = groupUp;
								listView1.Items.Add(item);
							}
						}
						break;
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}

		}

		private async void ePictureBox_seach_Click(object sender, EventArgs e)
		{
			var t = await validadeController.GetValityDate(dateTimePicker_dataBusca.Value);
			if (t != null)
			{
				dataGridView_validadeFile.Rows.Clear();
				for (int i = 0; i < t.Count; i++)
				{
					dataGridView_validadeFile.Rows.Add(new string[]
					{
						t[i].id.ToString(),
						t[i].nameUser,
						t[i].date
					});
				}
			}
		}

		private async void dataGridView_validadeFile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int idVality = -1;
			try
			{
				idVality = Convert.ToInt32(dataGridView_validadeFile.Rows[e.RowIndex].Cells[0].Value);
			}
			catch (Exception)
			{
			}

			if (idVality == -1)
			{
				return;
			}
			if (isActionValidade)
			{
				switch (MessageBox.Show("Há um documento em aberto, deseja fecha-lo ?\nOs dados seram salvos.", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
				{
					case DialogResult.OK:
						toolStripButton_save_Click(null, null);
						break;
					case DialogResult.Cancel:
						return;
				}
			}

			try
			{
				var tempEditVality = await validadeController.GetEditVality(idVality);

				if (tempEditVality.v is null)
				{
					return;
				}

				isActionValidade = true;
				VisibleHeaderDoc(true);
				VisibleBodyDoc(true);

				setValityModel = new SetValityModel
				{
					isEdit = true,
					dataCreate = tempEditVality.v.DATE ?? DateTime.Now,
					vality_id = tempEditVality.v.ID,
					user_id = tempEditVality.v.ID_USER
				};

				comboBox_user.SelectedIndex = comboBox_user.ReturnIndexCbGeneric(setValityModel.user_id);
				dateTimePicker_dataD.Value = setValityModel.dataCreate ?? DateTime.Now;

				if (tempEditVality.p is null)
				{
					return;
				}

				RefreshCategoryAsync(null, ListViewActionsEnum.INIT);
				ListViewAction(tempEditVality.p, ListViewActionsEnum.UPGRADE);


				UserDbModel tempUserSelected = await EterCache.Instance.EterDb.UserService.GetByAsync(u => u.ID == setValityModel.user_id, i => i.Category);

				List<ViewCbModel> temoC = tempUserSelected.Category.Select(x => new ViewCbModel { ID = x.ID, NAME = x.NAME ?? string.Empty }).ToList();
				temoC.Add(new ViewCbModel { ID = 1, NAME = "SEM CATEGORIA" });

				comboBox_categoria.CBListGeneric(temoC);

				// ATUAL comboBox_categoria.CBListGeneric(validadeController.GetCategoryUser().Result.Select(x => new ViewCbModel { ID = x.ID, NAME = x.NAME ?? string.Empty }).ToList());

			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}

		}

		private void toolStripButton_save_Click(object sender, EventArgs e)
		{
			isActionValidade = false;
			toolStripButton_clear_Click(null, null);
			NewDocValidade(false);
		}

		private async void toolStripButton_excel_Click(object sender, EventArgs e)
		{
			try
			{
				if (setValityModel == null)
				{
					return;
				}
				SaveFileDialog op = new SaveFileDialog();
				try
				{
					op.FileName = string.Format("{0} ({1}-{2}).xlsx",
						(await EterCache.Instance.EterDb.UserService.GetByAsync(u => u.ID == setValityModel.user_id)).NOME,
						setValityModel.dataCreate?.ToString("MMMM"),
						setValityModel.dataCreate?.Year);
					op.Filter = "Excel Files|*.xlsx";
					op.Title = "Save an Excel File";
					if (op.ShowDialog() == DialogResult.OK)
					{
						await validadeController.ExportValityXLSX(setValityModel.vality_id, op.FileName);
					}
				}
				finally
				{
					if (op != null)
					{
						((IDisposable)op).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
		}

		private async void iMPORTARPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DateTime? dateTimeQuery = InputDate.Show();
			if (dateTimeQuery is null)
			{
				return;
			}

			var tempImport = await validadeController.ImportProdutos(dateTimeQuery, setValityModel.user_id, setValityModel.vality_id);
			if (tempImport is null)
				return;

			for (int i = 0; i < tempImport.Count; i++)
			{
				ListViewAction(tempImport[i], ListViewActionsEnum.ADD);
			}

		}
	}
}
