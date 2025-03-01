using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Controllers.CarimboLoteValidade;
using EterPharmaPro.Enums;
using EterPharmaPro.Models;
using EterPharmaPro.Utils;
using EterPharmaPro.Utils.Extencions;
using System.Text.RegularExpressions;

namespace EterPharmaPro.Views.LoteControlado
{
	public partial class CreateLoteControlados : Form
	{
		private readonly CreateLoteControladosController controladosController;
		private List<MedControlDbModel> medicamentosControladoDbModels;
		private ProdutosModel tempProdutosModel;
		private ClientDbModel ClienteModel;
		private AddressClienteDbModel AddressClienteDbModel;
		private ValidatorFields validatorFields;
		private ValidatorFields validatorFieldsLot;
		private bool isClienteSelected = false;

		private void CreateLoteControlados_Load(object sender, EventArgs e)
		{
			validatorFields = new ValidatorFields();
			validatorFieldsLot = new ValidatorFields();
			validatorFields.SetListControl(new List<Control> { textBox_rg.ReturnTexBox(), textBox_nome, textBox_end, textBox_cel });
			validatorFieldsLot.SetListControl(new List<Control> { textBox_medicamento, textBox_lote });
		}
		public CreateLoteControlados()
		{
			controladosController = new CreateLoteControladosController();
			InitializeComponent();
			numericUpDown_qtd.Value = 1m;


		}

		private async void textBox_end_KeyDownAsync(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F10)
			{
				string tempCEP = InputBox.Show("Digite o CEP:", "Buscar endereço por CEP");
				if (tempCEP != string.Empty)
				{
					AddressHttpModel temResp = await ExtensionsDefault.BuscaCepAsync(tempCEP);
					textBox_end.Text = ((temResp != null) ? (temResp.logradouro + ", N°: ," + temResp.bairro + ", " + temResp.localidade + "-" + temResp.uf) : "Endereço não encontrado.");

					if (temResp != null)
					{
						AddressClienteDbModel = new AddressClienteDbModel
						{
							PLACE = temResp.logradouro,
							ZONE = temResp.bairro,
							CITY = temResp.localidade,
							UF = temResp.uf

						};
					}

				}
			}
		}

		private static string ExtrairNumero(string input)
		{
			Match match = Regex.Match(input, @"N°:\s*(.*?),");
			return match.Success ? match.Groups[1].Value.Trim() : string.Empty;
		}
		private void textBox_medicamento_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (!controladosController.CheckingLoadDbProd())
				{
					string codigo = string.Empty;

					if (textBox_medicamento.Text.Trim().Replace(" ", null) == "")
					{
						List<ProdutosModel> tempQuery = controladosController.GetAllProdutos();
						textBox_medicamento.Text = tempQuery == null ? string.Empty : InputListProduto.Show(tempQuery, "Busca de Produtos").ToString();
					}
					if (textBox_medicamento.Text.Trim().Replace(" ", null) == "")
					{
						return;
					}
					tempProdutosModel = controladosController.GetProduto(textBox_medicamento.Text.Trim());
					textBox_medicamento.Clear();

					textBox_medicamento.Text = (tempProdutosModel is null) ? string.Empty : tempProdutosModel.DESCRICAO_PRODUTO;
					textBox_lote.Focus();

				}
				else
				{

				}
			}
		}

		private void ePictureBox1_Click(object sender, EventArgs e)
		{
			if (validatorFieldsLot.ValidateFields())
			{
				medicamentosControladoDbModels = medicamentosControladoDbModels ?? new List<MedControlDbModel>();

				MedControlDbModel med = new MedControlDbModel
				{
					CODIGO = (tempProdutosModel is null) ? 0 : Convert.ToInt32(tempProdutosModel?.COD_PRODUTO),
					NAME_M = textBox_medicamento.Text.ToUpper(),
					QTD = (int)numericUpDown_qtd.Value,
					VALIDADE = dateTimePicker_validade.Value,
					LOTE = textBox_lote.Text.ToUpper()
				};
				medicamentosControladoDbModels.Add(med);
				RefreshListViwe(med, ListViewActionsEnum.ADD);
				tempProdutosModel = null;
				ClearInserMedicamento();
			}

		}

		private void toolStripDropDownButton_clear_Click(object sender, EventArgs e)
		{
			textBox_nome.Clear();
			textBox_end.Clear();
			textBox_rg.Clear();
			textBox_rg.ButtonVisible = false;
			textBox_cel.Clear();
			textBox_medicamento.Clear();
			numericUpDown_qtd.Value = 1m;
			dateTimePicker_validade.Value = DateTime.Today;
			textBox_lote.Clear();
			listView1.Items.Clear();
			medicamentosControladoDbModels = null;
		}

		private async void toolStripButton_print_Click(object sender, EventArgs e)
		{
			if (validatorFields.ValidateFields())
			{

				if (medicamentosControladoDbModels is null)
				{
					listView1.StartVFD();
					return;
				}

				if (AddressClienteDbModel != null)
				{
					AddressClienteDbModel.NUMBER = Convert.ToInt32(ExtensionsDefault.ReturnInt(ExtrairNumero(textBox_end.Text)));
				}
				else
				{
					AddressClienteDbModel = new AddressClienteDbModel
					{
						PLACE = textBox_end.Text
					};
				}

				if (ClienteModel is null)
				{
					ClienteModel = new ClientDbModel
					{
						RG = textBox_rg.GetText.ReturnInt(),
						NOME = textBox_nome.Text,
						PHONE = textBox_cel.Text.ReturnInt(),

						AddressCliente = new List<AddressClienteDbModel> { AddressClienteDbModel },
					};
				}
				//if (ClienteModel.ENDERECO is null || ((EnderecoClienteDbModel)ClienteModel.ENDERECO).ENDERECO.Trim().Replace(" ", null) != textBox_end.Text.Trim().Replace(" ", null))
				//{
				//	ClienteModel.ENDERECO = new EnderecoClienteDbModel
				//	{
				//		ENDERECO = textBox_end.Text
				//	};
				//}

				if (await controladosController.FinishAsync(ClienteModel))
				{
					if (MessageBox.Show("TUDO OK!!\nDeseja limpar o formulário ?", "LOTE VALIDADE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						toolStripDropDownButton_clear_Click(null, null);
					}
				}
				;
			}
		}

		private void eXCLUIRToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (listView1.SelectedItems.Count > 0)
				{
					int temp = listView1.SelectedItems[0].Index;
					if (MessageBox.Show("Deseja excluir esse item ?\n" + listView1.SelectedItems[0]?.SubItems[0].Text, "Excluir Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && temp >= 0)
					{
						medicamentosControladoDbModels.RemoveAt(temp);
						RefreshListViwe(temp, ListViewActionsEnum.REMOVE);
					}
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
		}

		public void RefreshListViwe(object data, ListViewActionsEnum listViewActionsEnum = ListViewActionsEnum.NONE)
		{
			switch (listViewActionsEnum)
			{
				case ListViewActionsEnum.ADD:
					MedControlDbModel tempDataAdd = data as MedControlDbModel;

					ListViewItem item = new ListViewItem(tempDataAdd.CODIGO?.ToString());
					item.SubItems.Add(tempDataAdd.NAME_M);
					item.SubItems.Add(tempDataAdd.QTD.ToString());
					item.SubItems.Add(tempDataAdd.VALIDADE?.ToShortDateString());
					item.SubItems.Add(tempDataAdd.LOTE);
					listView1.Items.Add(item);
					break;
				case ListViewActionsEnum.REMOVE:
					int tempDataDel = (int)data;
					listView1.Items.Remove(listView1.SelectedItems[0]);
					break;
			}
		}

		public void ClearInserMedicamento()
		{
			textBox_medicamento.Clear();
			numericUpDown_qtd.Value = 1m;
			dateTimePicker_validade.Value = DateTime.Today;
			textBox_lote.Clear();
			textBox_medicamento.Focus();
		}

		private void textBox_rg_ButtonClick(object sender, EventArgs e)
		{
			if (!(ClienteModel is null))
			{
				textBox_nome.Text = ClienteModel.NOME;
				textBox_cel.Text = ClienteModel.PHONE.ReturnFormation(FormatationEnum.TELEFONE);

				if (ClienteModel.AddressCliente is null)
				{
					return;
				}


				//textBox_end.Text = ((List<EnderecoClienteDbModel>)ClienteModel.ENDERECO).GetEnderecoArray(out int indexSelect);

				//ClienteModel.ENDERECO = indexSelect != -1 ? ((List<EnderecoClienteDbModel>)ClienteModel?.ENDERECO)[indexSelect] : null;

				isClienteSelected = true;
			}
		}

		private async void textBox_rg_TexBoxValidated(object sender, EventArgs e)
		{
			textBox_rg.GetText = textBox_rg.GetText.ReturnFormation(FormatationEnum.RG);
			ClienteModel = (textBox_rg.GetText.Trim().Replace(" ", null) != string.Empty) ? await controladosController.GetCliente(textBox_rg.GetText.ReturnInt()) : null;
			textBox_rg.ButtonVisible = (!(ClienteModel is null)) ? true : false;
		}

		private void textBox_cel_Validated(object sender, EventArgs e) => textBox_cel.Text = textBox_cel.Text.ReturnFormation(FormatationEnum.TELEFONE);

		private void textBox_lote_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ePictureBox1_Click(null, null);
			}
		}
	}
}
