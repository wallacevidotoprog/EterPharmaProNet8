using EterPharmaPro.Controllers.Configs;
using EterPharmaPro.Infrastructure.Services.Prints;
using EterPharmaPro.Models;
using EterPharmaPro.Utils.eControl;
using EterPharmaPro.Utils.Extencions;
using System.Globalization;

namespace EterPharmaPro.Views.IMPRESSOS
{
	public partial class PromocaoTag : Form
	{
		private ConfigsPageController configsPageController;

		private ImputTagPromocao ImputTagPromocao;
		private List<(ePanelPromocaoModel model, ePanelPromocaoControl control)> ePanelsList;
		private FieldPrintSchemeEnum fieldPrintScheme;
		private TagPromotionService tagPromotionService;
		public PromocaoTag()
		{
			configsPageController = new ConfigsPageController();
			InitializeComponent();

			ePanelsList = new List<(ePanelPromocaoModel model, ePanelPromocaoControl control)>();
		}

		private void ePictureBox_add_Click(object sender, EventArgs e)
		{
			ImputTagPromocao = new ImputTagPromocao(fieldPrintScheme);
			ImputTagPromocao.ShowDialog();

			ePanelPromocaoModel tempModel = ImputTagPromocao.ePanelPromocaoModel;

			if (tempModel is null) return;


			tempModel.eIndex = ePanelsList.Count;

			ePanelPromocaoControl tempControl = new ePanelPromocaoControl(tempModel);
			tempControl.Dock = DockStyle.Top;

			tempControl.Btn_delete += Temp_Btn_delete;
			tempControl.Btn_update += Temp_Btn_update;

			panel_listPrints.Controls.Add(tempControl);

			ePanelsList.Add((tempModel, tempControl));



			label_nameProduct.Text = tempModel.PRODUTO;
			label_valor1.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempModel.VALOR1)).ToUpper();
			label_LgValor1.Text = tempModel.DESC1;
			label_valor2.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempModel.VALOR2)).ToUpper();
			label_LgValor2.Text = tempModel.DESC2;
			CountControl();
		}

		private void Temp_Btn_update(object? sender, int e)
		{
			ImputTagPromocao = new ImputTagPromocao(fieldPrintScheme, ePanelsList[e].model);
			ImputTagPromocao.ShowDialog();

			ePanelPromocaoModel tempModel = ImputTagPromocao.ePanelPromocaoModel;

			if (tempModel is null) return;


			foreach (ePanelPromocaoControl item in panel_listPrints.Controls)
			{
				if (item.model.eIndex == e)
				{
					item.model = tempModel;
					item.Refresh();

					label_nameProduct.Text = tempModel.PRODUTO;
					label_valor1.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempModel.VALOR1)).ToUpper();
					label_LgValor1.Text = tempModel.DESC1;
					label_valor2.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(tempModel.VALOR2)).ToUpper();
					label_LgValor2.Text = tempModel.DESC2;

					break;

				}
			}
		}

		private void Refresh()
		{
			panel_listPrints.Controls.Clear();
			for (int i = ePanelsList.Count; i >= 0; i++)
			{
				var temp = ePanelsList[i].control;
				ePanelsList[i].model.eIndex = i;
				temp.model.eIndex = i;
				panel_listPrints.Controls.Add(temp);
			}
		}

		private void Temp_Btn_delete(object? sender, int e)
		{
			foreach (ePanelPromocaoControl item in panel_listPrints.Controls)
			{
				if (item.model.eIndex == e)
				{
					if (MessageBox.Show($"Deseja remover o item: {item.model.PRODUTO}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						panel_listPrints.Controls.Remove(item);
						ePanelsList.RemoveAt(e);
						Refresh();
						CountControl();
						break;
					}

				}
			}

		}

		private void CountControl()
		{
			int total = panel_listPrints.Controls.Count;
			decimal pages = Math.Ceiling(total / 2m);

			groupBox.Text = $"IMPRESSÕES - TOTAL: {total} | TOTAL DE PAGINAS: {pages}";

		}

		private void PromocaoTag_Load(object sender, EventArgs e)
		{

		}

		private void SetSchema(object sender, EventArgs e)
		{
			if (ePanelsList.Count > 0)
			{
				MessageBox.Show("Existe item no campo de impressões, para mudar o esquema você precisa limpar a lista.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
			switch (((ePictureBox)sender).Name)
			{
				case "ePictureBox_fidelidade":
					fieldPrintScheme = FieldPrintSchemeEnum.FIDELITY;
					splitContainer_Control.Enabled = true;
					label_valor2.Visible = true;
					label_LgValor2.Visible = true;
					label_valor1.Location = new Point(52, 327);
					label_LgValor1.Location = new Point(69, 400);
					pictureBox1.Image = Properties.Resources.PromoFd;
					break;
				case "ePictureBox_default":
					fieldPrintScheme = FieldPrintSchemeEnum.DEFAULT;
					splitContainer_Control.Enabled = true;
					label_valor2.Visible = false;
					label_LgValor2.Visible = false;
					label_valor1.Location = new Point(258, 327);
					label_LgValor1.Location = new Point(275, 400);
					pictureBox1.Image = Properties.Resources.PromoOne;
					break;
				default:
					break;
			}
		}

		private void toolStripButton_print_Click(object sender, EventArgs e)
		{
			if (ePanelsList.Count > 0 && fieldPrintScheme != null)
			{
				tagPromotionService = new TagPromotionService(ePanelsList.Select(x => x.model).ToList(), fieldPrintScheme);
				tagPromotionService.PrintToPdf();
			}
		}
	}




	public enum FieldPrintSchemeEnum
	{
		DEFAULT, FIDELITY
	}
}
