using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Models;

namespace EterPharmaPro.Utils.Extencions
{
	public partial class GetAddress : Form
	{

		private ValidatorFields validatorFields = new ValidatorFields();

		public static AddressClienteDbModel addressClienteDbModel { get; private set; }
		private AddressClienteDbModel tempAddressClienteDbModel;

		public GetAddress()
		{
			InitializeComponent();


			Clear();

			validatorFields.SetListControl(new List<Control> { comboBox_logadouro, comboBox_bairro, comboBox_cidade, comboBox_uf, textBox_number });

			if (addressClienteDbModel != null)
			{
				tempAddressClienteDbModel = addressClienteDbModel;

				comboBox_logadouro.Text = addressClienteDbModel?.PLACE;
				comboBox_bairro.Text = addressClienteDbModel?.ZONE;
				comboBox_cidade.Text = addressClienteDbModel?.CITY;
				comboBox_uf.Text = addressClienteDbModel?.UF;
				textBox_number.Text = addressClienteDbModel?.NUMBER.ToString();
				textBox_obs.Text = addressClienteDbModel?.OBSERVACAO;
			}

		}
		private void Clear()
		{
			comboBox_logadouro.Text = null;
			comboBox_bairro.Text = null;
			comboBox_cidade.Text = null;
			comboBox_uf.Text = null;
			textBox_number.Text = null;
			textBox_obs.Text = null;
		}
		public static new AddressClienteDbModel Show(AddressClienteDbModel addressCliente = null)
		{

			if (addressCliente != null)
			{
				addressClienteDbModel = addressCliente;
			}
			using (GetAddress inputDate = new GetAddress())
			{
				return inputDate.ShowDialog() == DialogResult.OK ? addressClienteDbModel : null;
			}
		}
		private void ePictureBox_termal_Click(object sender, EventArgs e)
		{
			this.Focus();


			base.DialogResult = DialogResult.OK;
		}

		private async void ePictureBox_default_ClickAsync(object sender, EventArgs e)
		{
			AddressHttpModel temResp = await ExtensionsDefault.BuscaCepAsync(textBox_cep.Text.ReturnInt().ToString());

			if (temResp != null)
			{
				comboBox_logadouro.Text = temResp.logradouro;
				comboBox_bairro.Text = temResp.bairro;
				comboBox_cidade.Text = temResp.localidade;
				comboBox_uf.Text = temResp.uf;
			}

		}

		private void ePictureBox_save_Click(object sender, EventArgs e)
		{
			if (validatorFields.ValidateFields())
			{

				addressClienteDbModel = new AddressClienteDbModel
				{
					ID = null,
					ZONE = comboBox_bairro.Text,
					CITY = comboBox_cidade.Text,
					UF = comboBox_uf.Text,
					PLACE = comboBox_logadouro.Text,
					NUMBER = Convert.ToInt32(textBox_number.Text.ReturnInt()),
					OBSERVACAO = textBox_obs.Text
				};
				if (tempAddressClienteDbModel != null && tempAddressClienteDbModel.ToString() == addressClienteDbModel.ToString())
				{
					addressClienteDbModel.ID = tempAddressClienteDbModel.ID;
				}
				base.DialogResult = DialogResult.OK;
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			addressClienteDbModel = null;
			base.OnFormClosing(e);
			this.Dispose();
		}

	}
}
