﻿using EterPharmaPro.Controllers.Configs;
using EterPharmaPro.Enums;
using EterPharmaPro.Models;
using EterPharmaPro.Views.Configuracoes;

namespace EterPharmaPro.Utils.Extencions
{
	public partial class ImputTagPromocao : Form
	{
		private ConfigsPageController configsPageController;
		private ProdutosModel produtoCurrent;
		public ePanelPromocaoModel ePanelPromocaoModel { get; set; }
		public ImputTagPromocao(ePanelPromocaoModel model = null)
		{
			configsPageController = new ConfigsPageController();
			InitializeComponent();

			if (model != null)
			{
				textBox_busca.Text = model.PRODUTO;
				textBox_V1.Text = model.VALOR1.ToString();
				comboBox_TV1.Text = model.DESC1;
				textBox_V2.Text = model.VALOR2.ToString() ;
				comboBox_TV2.Text = model.DESC2;

			}
		}

		private void textBox_busca_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{

				string codigo = string.Empty;

				if (textBox_busca.Text.Trim().Replace(" ", null) == "")
				{
					List<ProdutosModel> tempQuery = configsPageController.GetAllProdutos();

					string tempCod = tempQuery == null ? string.Empty : InputListProduto.Show(tempQuery, "Busca de Produtos").ToString();
					if (string.IsNullOrEmpty(tempCod)) return;


					produtoCurrent = configsPageController.GetProdutos(tempCod, QueryProdutoEnum.COD_INTERNO).FirstOrDefault();
					textBox_busca.Text = produtoCurrent?.DESCRICAO_PRODUTO;


				}
				else
				{
					produtoCurrent = configsPageController.GetProdutoCC(textBox_busca.Text.ReturnInt());


					textBox_busca.Text = produtoCurrent?.DESCRICAO_PRODUTO;
				}
				if (textBox_busca.Text.Trim().Replace(" ", null) == "")
				{
					return;
				}



			}
		}

		private void textBox_V1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
			{
				e.Handled = true;
			}
		}

		private void ePictureBox_send_Click(object sender, EventArgs e)
		{
			ePanelPromocaoModel = new ePanelPromocaoModel
			{
				PRODUTO = textBox_busca.Text,
				VALOR1 = Convert.ToDecimal(textBox_V1.Text),
				DESC1 = comboBox_TV1.Text,
				VALOR2 = Convert.ToDecimal(textBox_V2.Text),
				DESC2 = comboBox_TV2.Text,
			};

			this.Close();
		}
	}
}
