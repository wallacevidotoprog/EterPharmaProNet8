using EterPharmaPro.Core;
using EterPharmaPro.Infrastructure.Services.DbProdutos;
using EterPharmaPro.Utils.Extencions;
using EterPharmaPro.Views;
using EterPharmaPro.Views.Configuracoes;
using EterPharmaPro.Views.IMPRESSOES;
using EterPharmaPro.Views.Manipulados;
using EterPharmaPro.Views.Validade;

namespace EterPharmaPro
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();

			EterCache.Instance.DatabaseProdutosDb = new DatabaseProdutosDb(toolStripProgressBar_status);
		}
		private void MainWindow_Load(object sender, EventArgs e)
		{
			SetLogin();
		}

		private void SetLogin()
		{
			AcesUser acesUser = new AcesUser();
			acesUser.ShowDialog();

			if (acesUser.exit) this.Close();


			if (!acesUser.loginSucced) SetLogin();

			this.Text = $"ETER PHARMA PRO [ {EterCache.Instance.UserDbModel?.ID_LOJA?.ToString().PadRight(4, '0')} - {EterCache.Instance.UserDbModel?.NOME} - {EterCache.Instance.UserDbModel?.Position?.NOME} ]";
		}
		private void OpenForm(Form form)
		{
			try
			{
				if (panel_center.Controls.Count > 0)
				{
					panel_center.Controls.RemoveAt(0);
				}
				form.TopLevel = false;
				form.FormBorderStyle = FormBorderStyle.None;
				form.Dock = DockStyle.Fill;

				form.FormClosed += ChildForm_FormClosed;
				panel_center.Controls.Clear();
				panel_center.Controls.Add(form);
				form?.Show();
				toolStrip_menu.Visible = false;
			}
			catch (Exception ex)
			{
				ex.ErrorGet();

			}
		}


		private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			toolStrip_menu.Visible = true;
		}

		private void fORMUToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new CreateManipulados());

		private void gERARVALIDADEDOMÊSToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new CreateValidade());


		private void toolStripDropDownButton_impressos_Click(object sender, EventArgs e) => OpenForm(new IMPRESSOS());

		private void toolStripButton_conf_Click(object sender, EventArgs e) => OpenForm(new ConfigsPage());

		private void rELATÓRIOToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new ReportValidades());

		private void rELATÓRIOToolStripMenuItem1_Click(object sender, EventArgs e) => OpenForm(new ReportManipulacao());

		private void tAGToolStripMenuItem_Click(object sender, EventArgs e) => OpenForm(new TagViewer());

		private void toolStripButton2_Click(object sender, EventArgs e)
		{

		}
	}
}
