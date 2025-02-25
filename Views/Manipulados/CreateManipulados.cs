﻿using EterPharmaPro.Controllers.Manipulacao;
using EterPharmaPro.Enums;
using EterPharmaPro.Models;
using EterPharmaPro.Utils.Extencions;

namespace EterPharmaPro.Views.Manipulados
{
	public partial class CreateManipulados : Form
	{


		private ManipulacaoModel manipulados;

		private bool edit = false;

		private readonly ManipuladoController manipuladoController;
		public CreateManipulados()
		{
			manipuladoController = new ManipuladoController();
			InitializeComponent();
		}

		public CreateManipulados(ManipulacaoModel model)
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
			//comboBox_situacao.CBListProps<SituationDbModal>(EterCache.Instance.Situation);
			//comboBox_pag.CBListProps<PaymentDbModal>(EterCache.Instance.Paymente);
			//comboBox_modo.CBListProps<DeliveryMethodDbModal>(EterCache.Instance.DeliveryMethod);
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

		}

		private async void CreateManipulados_Load(object sender, EventArgs e)
		{
			//CleanAll(null, null);
			//await comboBox_user.CBListUserAsync(eterDb);
			//LoadDropDown();
			//comboBox_user.SelectedIndex = comboBox_user.ReturnIndexUserCB(eterDb.EterDbController.UserModelAcess.ID);

			//if (manipulados != null && edit)
			//{
			//	dateTimePicker_data.Value = (DateTime)manipulados.DADOSATENDIMENTO.DATA;
			//	textBox_atn.Text = manipulados?.DADOSATENDIMENTO.ATEN_MANI;
			//	comboBox_user.SelectedIndex = comboBox_user.ReturnIndexUserCB(manipulados.DADOSATENDIMENTO?.ATEN_LOJA.ToString());
			//	textBox_cpf.Text = ((ClienteDbModel)manipulados.DADOSCLIENTE)?.CPF.ReturnFormation(FormatationEnum.CPF);
			//	textBox_rg.Text = ((ClienteDbModel)manipulados.DADOSCLIENTE)?.RG.ReturnFormation(FormatationEnum.RG);
			//	textBox_nomeC.Text = ((ClienteDbModel)manipulados.DADOSCLIENTE)?.NOME;
			//	textBox5_tel.Text = ((ClienteDbModel)manipulados.DADOSCLIENTE)?.TELEFONE.ReturnFormation(FormatationEnum.TELEFONE);
			//	textBox_log.Text = ((EnderecoClienteDbModel)(((ClienteDbModel)manipulados.DADOSCLIENTE)?.ENDERECO)).ENDERECO;
			//	textBox_obsEnd.Text = ((EnderecoClienteDbModel)(((ClienteDbModel)manipulados.DADOSCLIENTE)?.ENDERECO)).OBSERVACAO;
			//	dataGridView_medicamentos.Rows.Clear();
			//	for (int i = 0; i < ((List<MedicamentosManipuladosDbModal>)manipulados.MEDICAMENTOS)?.Count; i++)
			//	{
			//		dataGridView_medicamentos.Rows.Add(((List<MedicamentosManipuladosDbModal>)manipulados.MEDICAMENTOS)[i].NAME_M.ToString());
			//	}
			//	textBox_obsGeral.Text = manipulados?.OBSGERAL;
			//	comboBox_situacao.SelectedIndex = comboBox_situacao.ReturnIndexPropsCB(manipulados.SITUCAO);
			//	comboBox_pag.SelectedIndex = comboBox_pag.ReturnIndexPropsCB(manipulados.FORMAPAGAMENTO);
			//	comboBox_modo.SelectedIndex = comboBox_modo.ReturnIndexPropsCB(manipulados.MODOENTREGA);
			//	textBox_valorT.Text = manipulados.VALORFINAL.ToString("F2");
			//}
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
			//List<ClienteDbModel> temp = null;
			//ClienteDbModel tempSelect = null;
			//try
			//{
			//	temp = ((textBox_cpf.Text != "") ? await manipuladoController.GetCliente(textBox_cpf.Text.ReturnInt(), TypeDoc.CPF) :
			//		(((textBox_rg.Text != "")) ? await manipuladoController.GetCliente(textBox_rg.Text.ReturnInt(), TypeDoc.RG) :
			//		 await manipuladoController.GetCliente()));

			//	if (temp.Count <= 0)
			//	{
			//		return;
			//	}
			//	tempSelect = temp.GetClienteArray();
			//	if (tempSelect is null)
			//	{
			//		return;
			//	}
			//	textBox_cpf.Text = tempSelect?.CPF.ReturnFormation(FormatationEnum.CPF);
			//	textBox_rg.Text = tempSelect?.RG.ReturnFormation(FormatationEnum.RG);
			//	textBox_nomeC.Text = tempSelect?.NOME;
			//	textBox5_tel.Text = tempSelect?.TELEFONE.ReturnFormation(FormatationEnum.TELEFONE);
			//	textBox_log.Text = ((EnderecoClienteDbModel)tempSelect?.ENDERECO)?.ENDERECO;
			//	textBox_obsEnd.Text = ((EnderecoClienteDbModel)tempSelect?.ENDERECO)?.OBSERVACAO;

			//}
			//catch (Exception ex)
			//{
			//	ex.ErrorGet();
			//}
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
				//List<MedicamentosManipuladosDbModal> list = new List<MedicamentosManipuladosDbModal>();
				//textBox_obsGeral.Focus();
				//for (int i = 0; i < dataGridView_medicamentos.Rows.Count; i++)
				//{
				//	if (dataGridView_medicamentos.Rows[i].Cells[0].Value != null && dataGridView_medicamentos.Rows[i].Cells[0].Value.ToString() != "")
				//	{
				//		list.Add(new MedicamentosManipuladosDbModal { NAME_M = dataGridView_medicamentos.Rows[i].Cells[0].Value.ToString().ToUpper() });
				//	}
				//}
				//ManipulacaoModel manipulacaoModel = new ManipulacaoModel
				//{
				//	ID = edit ? null : manipulados?.ID,
				//	DADOSATENDIMENTO = new DadosAtendimentoModel
				//	{
				//		ATEN_LOJA = Convert.ToInt32(comboBox_user.SelectedValue.ToString()),
				//		DATA = dateTimePicker_data.Value,
				//		ATEN_MANI = textBox_atn.Text
				//	},
				//	DADOSCLIENTE = new ClienteDbModel
				//	{
				//		ID = edit ? null : ((ClienteDbModel)manipulados?.DADOSCLIENTE)?.ID,
				//		CPF = textBox_cpf.Text.ReturnInt(),
				//		RG = textBox_rg.Text.ReturnInt(),
				//		NOME = textBox_nomeC.Text,
				//		TELEFONE = textBox5_tel.Text.ReturnInt(),
				//		ENDERECO = new EnderecoClienteDbModel
				//		{
				//			CLIENTE_ID = edit ? null : ((EnderecoClienteDbModel)((ClienteDbModel)manipulados?.DADOSCLIENTE)?.ENDERECO)?.CLIENTE_ID,
				//			ENDERECO = textBox_log.Text,
				//			OBSERVACAO = textBox_obsEnd.Text
				//		}
				//	},
				//	MEDICAMENTOS = list,
				//	OBSGERAL = textBox_obsGeral.Text,
				//	SITUCAO = Convert.ToInt32(comboBox_situacao.SelectedValue),
				//	FORMAPAGAMENTO = Convert.ToInt32(comboBox_pag.SelectedValue),
				//	MODOENTREGA = Convert.ToInt32(comboBox_modo.SelectedValue),
				//	VALORFINAL = Convert.ToDecimal(textBox_valorT.Text)
				//};


				//if (await manipuladoController.PrintDocManipulado(manipulacaoModel, EnumManipulado.P_80, edit))
				//{
				//	if (edit)
				//	{
				//		Close();
				//	}
				//	if (MessageBox.Show("TUDO OK!!\nDeseja limpar o formulário ?", "MANIPULAÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				//	{
				//		CleanAll(null, null);
				//	}
				//}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}
		}
	}
}
