using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Controllers.Manipulacao;
using EterPharmaPro.Core;
using EterPharmaPro.Enums;
using EterPharmaPro.Models;
using EterPharmaPro.Utils.Extencions;

namespace EterPharmaPro.Views.Manipulados
{
	public partial class CreateManipulados : Form
	{


		private ManipulationDbModel manipulados;
		private List<ClientDbModel> clientDbModels;
		private ClientDbModel clientSearch;
		private AddressClienteDbModel addressClienteDbModel;

		private bool edit = false;

		private readonly ManipuladoController manipuladoController;
		public CreateManipulados()
		{
			manipuladoController = new ManipuladoController();
			InitializeComponent();
		}

		public CreateManipulados(ManipulationDbModel model)
		{

			manipuladoController = new ManipuladoController();

			InitializeComponent();

			if (model != null)
			{
				edit = true;
				manipulados = model;
			}
		}

		private void LoadDropDown()
		{
			comboBox_user.CBListGeneric(EterCache.Instance.EterDb.UserService.GetAllAsync().Result.ToList().Select(x => new ViewCbModel { ID = x.ID, NAME = $"{x.ID_LOJA.ToString().PadLeft(4, '0')} - {x.NOME}" }).ToList());

			comboBox_situacao.CBListGeneric(EterCache.Instance.EterDbController.SituationDbs.Select(x => new ViewCbModel { ID = x.ID, NAME = x.NAME }).ToList());
			comboBox_pag.CBListGeneric(EterCache.Instance.EterDbController.PaymentDbs.Select(x => new ViewCbModel { ID = x.ID, NAME = x.NAME }).ToList());
			comboBox_modo.CBListGeneric(EterCache.Instance.EterDbController.DeliveryMethodDbs.Select(x => new ViewCbModel { ID = x.ID, NAME = x.NAME }).ToList());
		}

		private void toolStripButton_sair_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja sair o formulário ?", base.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void CleanAll(object sender, EventArgs e)
		{
			dateTimePicker_data.Value = DateTime.Now;
			textBox_atn.Clear();
			textBox_cpf.Clear();
			textBox_rg.Clear();
			textBox_nomeC.Clear();
			textBox5_tel.Clear();
			textBox_log.Clear();
			textBox_obsEnd.Clear();
			dataGridView_medicamentos.Rows.Clear();
			textBox_obsGeral.Clear();
			comboBox_situacao.SelectedIndex = -1;
			comboBox_pag.SelectedIndex = -1;
			comboBox_modo.SelectedIndex = -1;
			textBox_valorT.Text = "0,00";

			clientSearch = null;
			//clientDbModels = null;
			addressClienteDbModel = null;

		}

		private async void CreateManipulados_Load(object sender, EventArgs e)
		{

			//clientDbModels = await manipuladoController.GetAllClient();

			CleanAll(null, null);

			LoadDropDown();

			comboBox_user.SelectedIndex = comboBox_user.ReturnIndexCbGeneric(EterCache.Instance.UserDbModel.ID);

			if (manipulados != null && edit)
			{
				dateTimePicker_data.Value = (DateTime)manipulados.DATA;
				textBox_atn.Text = manipulados.ATEN_MANI;
				comboBox_user.SelectedIndex = comboBox_user.ReturnIndexCbGeneric(manipulados.ATEN_LOJA);
				textBox_cpf.Text = manipulados.Client.CPF.ReturnFormation(FormatationEnum.CPF);
				textBox_rg.Text = manipulados.Client.RG.ReturnFormation(FormatationEnum.RG);
				textBox_nomeC.Text = manipulados.Client.NOME;
				textBox5_tel.Text = manipulados.Client.PHONE.ReturnFormation(FormatationEnum.TELEFONE);

				addressClienteDbModel = manipulados?.AddressCliente;

				textBox_log.Text = addressClienteDbModel?.ToString();
				textBox_obsEnd.Text = addressClienteDbModel?.OBSERVACAO;

				//textBox_log.Text = manipulados.Client.AddressCliente.FirstOrDefault()?.ToString() ?? string.Empty;
				//textBox_obsEnd.Text = manipulados.Client.AddressCliente.FirstOrDefault()?.OBSERVACAO ?? string.Empty;


				dataGridView_medicamentos.Rows.Clear();
				foreach (var item in manipulados.MedManipulation)
				{
					dataGridView_medicamentos.Rows.Add(item.NAME_M);
				}
				textBox_obsGeral.Text = manipulados?.OBSGERAL;
				comboBox_situacao.SelectedIndex = comboBox_situacao.ReturnIndexCbGeneric(manipulados.ID_SITUCAO);
				comboBox_pag.SelectedIndex = comboBox_pag.ReturnIndexCbGeneric(manipulados.ID_FORMAPAGAMENTO);
				comboBox_modo.SelectedIndex = comboBox_modo.ReturnIndexCbGeneric(manipulados.ID_MODOENTREGA);
				textBox_valorT.Text = manipulados.VALORFINAL?.ToString("F2");

				if (true)
				{
					comboBox_user.SelectedIndex = comboBox_user.ReturnIndexCbGeneric(manipulados.ATEN_LOJA);
				}
			}
		}

		private bool Validade()
		{
			return textBox_nomeC.Text != "" && textBox5_tel.Text != "" && textBox_log.Text != "" && comboBox_situacao.SelectedIndex != -1 && comboBox_pag.SelectedIndex != -1 && comboBox_modo.SelectedIndex != -1 && Convert.ToDecimal(textBox_valorT.Text) > 0m;
		}

		private async void textBox_log_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F10)
			{
				string tempCEP = InputBox.Show("Digite o CEP:", "Buscar endereço por CEP");
				if (tempCEP != string.Empty)
				{
					AddressHttpModel temResp = await ExtensionsDefault.BuscaCepAsync(tempCEP);
					textBox_log.Text = ((temResp != null) ? (temResp.logradouro + ", N°: ," + temResp.bairro + ", " + temResp.localidade + "-" + temResp.uf) : string.Empty);
				}
			}
		}

		private async void BuscaCliente_Click(object sender, EventArgs e)
		{
			List<ClientDbModel> temp = null;
			ClientDbModel tempSelect = null;
			try
			{
				temp = ((textBox_cpf.Text != "") ? await manipuladoController.GetCliente(textBox_cpf.Text.ReturnInt()) :
					(((textBox_rg.Text != "")) ? await manipuladoController.GetCliente(textBox_rg.Text.ReturnInt()) :
					 await manipuladoController.GetCliente(null)));

				if (temp.Count <= 0)
				{
					return;
				}
				tempSelect = temp.GetClienteArray();
				if (tempSelect is null)
				{
					return;
				}
				clientSearch = tempSelect;
				addressClienteDbModel = tempSelect.AddressCliente?.FirstOrDefault();

				textBox_cpf.Text = tempSelect?.CPF.ReturnFormation(FormatationEnum.CPF);
				textBox_rg.Text = tempSelect?.RG.ReturnFormation(FormatationEnum.RG);
				textBox_nomeC.Text = tempSelect?.NOME;
				textBox5_tel.Text = tempSelect?.PHONE.ReturnFormation(FormatationEnum.TELEFONE);
				textBox_log.Text = tempSelect.AddressCliente?.FirstOrDefault()?.ToString() ?? string.Empty;
				textBox_obsEnd.Text = tempSelect.AddressCliente?.FirstOrDefault()?.OBSERVACAO ?? string.Empty;

			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
		}

		private void textBox_cpf_Validated(object sender, EventArgs e)
		{
			textBox_cpf.Text = textBox_cpf.Text.ReturnFormation(FormatationEnum.CPF);
		}

		private void textBox_rg_Validated(object sender, EventArgs e)
		{
			textBox_rg.Text = textBox_rg.Text.ReturnFormation(FormatationEnum.RG);
		}

		private void textBox5_tel_Validated(object sender, EventArgs e)
		{
			textBox5_tel.Text = textBox5_tel.Text.ReturnFormation(FormatationEnum.TELEFONE);
		}

		private void textBox_valorT_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
			{
				e.Handled = true;
			}
		}

		private async void SavePrint(object sender, EventArgs e)
		{
			this.Focus();
			if (!Validade())
			{
				MessageBox.Show("Falta Preencher Algo.", "VALIDAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}


			try
			{
				List<MedManipulationDbModal> list = new List<MedManipulationDbModal>();
				textBox_obsGeral.Focus();
				for (int i = 0; i < dataGridView_medicamentos.Rows.Count; i++)
				{
					if (dataGridView_medicamentos.Rows[i].Cells[0].Value != null && dataGridView_medicamentos.Rows[i].Cells[0].Value.ToString() != "")
					{
						list.Add(new MedManipulationDbModal { NAME_M = dataGridView_medicamentos.Rows[i].Cells[0].Value.ToString().ToUpper() });
					}
				}
				ManipulationDbModel manipulacaoModel = new ManipulationDbModel
				{
					ID = edit ? manipulados?.ID : null,


					ATEN_LOJA = Convert.ToInt32(comboBox_user.SelectedValue.ToString()),
					DATA = dateTimePicker_data.Value,
					ATEN_MANI = textBox_atn.Text
					,
					Client = new ClientDbModel
					{
						ID = edit ? manipulados.Client.ID : clientSearch != null ? clientSearch.ID : null,
						CPF = textBox_cpf.Text.ReturnInt(),
						RG = textBox_rg.Text.ReturnInt(),
						NOME = textBox_nomeC.Text,
						PHONE = textBox5_tel.Text.ReturnInt(),
						//AddressCliente = new List<AddressClienteDbModel> { addressClienteDbModel }
					},
					AddressCliente = addressClienteDbModel,
					MedManipulation = list,
					OBSGERAL = textBox_obsGeral.Text,
					ID_SITUCAO = Convert.ToUInt32(comboBox_situacao.SelectedValue),
					ID_FORMAPAGAMENTO = Convert.ToUInt32(comboBox_pag.SelectedValue),
					ID_MODOENTREGA = Convert.ToUInt32(comboBox_modo.SelectedValue),
					VALORFINAL = Convert.ToDecimal(textBox_valorT.Text)
				};

				EnumManipulado enumManipulado = SelectPrint.Show();
				// if (enumManipulado == EnumManipulado.NONE) return;

				if (await manipuladoController.PrintDocManipulado(manipulacaoModel, enumManipulado, edit))
				{
					if (edit)
					{
						Close();
					}
					if (MessageBox.Show("TUDO OK!!\nDeseja limpar o formulário ?", "MANIPULAÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						CleanAll(null, null);
					}
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
		}

		private void button_getAddress_Click(object sender, EventArgs e)
		{

			var temp = GetAddress.Show(addressClienteDbModel);

			if (temp != null)
			{
				textBox_log.Text = temp.ToString();
				textBox_obsEnd.Text = temp.OBSERVACAO;
				addressClienteDbModel = temp;
			}
		}
	}
}
