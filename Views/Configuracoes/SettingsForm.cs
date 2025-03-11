using EterPharmaPro.Controllers.Configs;
using EterPharmaPro.Core;
using EterPharmaPro.Models;

namespace EterPharmaPro.Views.Configuracoes
{
	public partial class SettingsForm : Form
	{
		private readonly ConfigsPageController configsPageController;
		private int store_current = -1;
		private int selectedIndex = -1;
		public SettingsForm()
		{
			configsPageController = new ConfigsPageController();
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			button_hostname.Text = $"HOSTNAME: {System.Net.Dns.GetHostName()}";
			SetValue();
		}

		private void SetValue()
		{


			listBox_list.Items.Clear();

			textBox_store.Text = EterCache.Instance.SettingsApp?.NUMBERSTORE.ToString() ?? "0";

			if (EterCache.Instance.SettingsApp?.POINTS == null || EterCache.Instance.SettingsApp?.POINTS.Count <= 0)
			{
				return;
			}

			for (int i = 0; i < EterCache.Instance.SettingsApp?.POINTS.Count; i++)
			{
				SettingsPoint temp = EterCache.Instance.SettingsApp?.POINTS[i];


				if (temp.NAMEPC == EterCache.Instance.SettingsApp?.settingsPoint?.NAMEPC)
				{
					store_current = i;
				}
				listBox_list.Items.Add(temp.NAMEPC);
			}

			listBox_list.SelectedIndex = store_current;


		}

		private void ePictureBox_saveNameStore_Click(object sender, EventArgs e)
		{
			_ = EterCache.Instance.SettingsApp.SaveAsync();
		}

		private void button_hostname_Click(object sender, EventArgs e)
		{
			listBox_list.SelectedIndex = store_current;
		}
		private void GetPrints(int Index)
		{
			dataGridView_prints.Rows.Clear();

			List<string> prints = configsPageController.NamePrists();

			DataGridViewComboBoxCell dataGridViewComboBoxCell = new DataGridViewComboBoxCell();
			dataGridViewComboBoxCell.Items.AddRange(prints.ToArray());


			SettingsPoint tempS = EterCache.Instance.SettingsApp?.POINTS[Index];


			dataGridView_prints.Rows.Add(nameof(tempS.PRINT_DEFAULT));
			dataGridView_prints.Rows.Add(nameof(tempS.PRINT_TERMAL));



			foreach (DataGridViewRow row in dataGridView_prints.Rows)
			{
				if (!row.IsNewRow) // Evita a linha vazia no final do DataGridView
				{
					DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
					comboBoxCell.Items.AddRange(prints.ToArray());
					row.Cells[1] = comboBoxCell; // Substitua "1" pelo índice correto da coluna ComboBox
				}
			}

			foreach (DataGridViewRow row in dataGridView_prints.Rows)
			{
				if (!row.IsNewRow) // Evita a linha em branco no final do DataGridView
				{
					string nomeImpressora = row.Cells[0].Value?.ToString(); // Obtém o nome da impressora da primeira coluna

					// Determina o valor padrão com base no nome da impressora
					string valorPreSelecionado = nomeImpressora switch
					{
						"PRINT_DEFAULT" => EterCache.Instance.SettingsApp?.POINTS[Index].PRINT_DEFAULT,
						"PRINT_TERMAL" => EterCache.Instance.SettingsApp?.POINTS[Index].PRINT_TERMAL,
						_ => null // Se não corresponder, deixa sem seleção
					};

					DataGridViewComboBoxCell comboBoxCell = row.Cells[1] as DataGridViewComboBoxCell; // Índice 1 da coluna ComboBox

					if (!string.IsNullOrEmpty(valorPreSelecionado) && comboBoxCell != null && comboBoxCell.Items.Contains(valorPreSelecionado))
					{
						comboBoxCell.Value = valorPreSelecionado; // Define o valor pré-selecionado
					}
				}
			}

		}

		private void listBox_list_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			selectedIndex = listBox_list.SelectedIndex;
			if (selectedIndex != -1)
			{
				GetPrints(selectedIndex);
			}
		}

		private void dataGridView_prints_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.ColumnIndex > -1)
				{
					var data1 = dataGridView_prints.Rows[e.RowIndex];

					switch (data1.Cells[0].Value)
					{
						case "PRINT_DEFAULT":
							EterCache.Instance.SettingsApp.POINTS[listBox_list.SelectedIndex].PRINT_DEFAULT = data1.Cells[1].Value.ToString();
							break;
						case "PRINT_TERMAL":
							EterCache.Instance.SettingsApp.POINTS[listBox_list.SelectedIndex].PRINT_TERMAL = data1.Cells[1].Value.ToString();
							break;
						default:
							break;
					}
				}
			}
			catch (Exception)
			{


			}


		}
	}
}
