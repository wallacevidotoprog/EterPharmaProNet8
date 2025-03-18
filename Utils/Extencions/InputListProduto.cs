using EterPharmaPro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EterPharmaPro.Utils.Extencions
{
	public class InputListProduto : Form
	{
		private List<ProdutosModel> objectsList;

		private IContainer components = null;

		private Label label3;

		private TextBox textBox_busca;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewCheckBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridView dataGridView_dados;

		public static string inputIndex { get; private set; }

		public InputListProduto(List<ProdutosModel> objects, string title)
		{
			InitializeComponent();
			objectsList = objects;
			dataGridView_dados.DataSource = objects;
		}

		public static string Show(List<ProdutosModel> objects, string title)
		{
			using (InputListProduto inputBox = new InputListProduto(objects, title))
			{
				return (inputBox.ShowDialog() == DialogResult.OK) ? inputIndex : string.Empty;

			}
		}

		private void InputList_Load(object sender, EventArgs e)
		{
		}

		private async void textBox_busca_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(textBox_busca.Text))
				{
					dataGridView_dados.DataSource = objectsList;
					return;
				}
				string searchText = textBox_busca.Text.ToUpper();
				List<ProdutosModel> filteredList = await Task.Run(() => objectsList.Where((ProdutosModel x) => x.DESCRICAO_PRODUTO.ToUpper().Contains(searchText)).ToList());
				dataGridView_dados.DataSource = filteredList;
			}
			catch (Exception ex2)
			{
				Exception ex = ex2;
				ex.ErrorGet();
			}
		}

		private void dataGridView_dados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				inputIndex = dataGridView_dados.Rows[e.RowIndex].Cells[1].Value.ToString();
				base.DialogResult = DialogResult.OK;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			label3 = new Label();
			textBox_busca = new TextBox();
			dataGridView_dados = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewCheckBoxColumn();
			Column5 = new DataGridViewTextBoxColumn();
			Column6 = new DataGridViewTextBoxColumn();
			((ISupportInitialize)dataGridView_dados).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(14, 10);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(77, 25);
			label3.TabIndex = 14;
			label3.Text = "BUSCA:";
			// 
			// textBox_busca
			// 
			textBox_busca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_busca.CharacterCasing = CharacterCasing.Upper;
			textBox_busca.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_busca.Location = new Point(20, 43);
			textBox_busca.Margin = new Padding(4, 3, 4, 3);
			textBox_busca.Name = "textBox_busca";
			textBox_busca.Size = new Size(1156, 33);
			textBox_busca.TabIndex = 13;
			textBox_busca.TextChanged += textBox_busca_TextChanged;
			// 
			// dataGridView_dados
			// 
			dataGridView_dados.AllowUserToAddRows = false;
			dataGridView_dados.AllowUserToDeleteRows = false;
			dataGridView_dados.AllowUserToResizeColumns = false;
			dataGridView_dados.AllowUserToResizeRows = false;
			dataGridView_dados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView_dados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_dados.BackgroundColor = SystemColors.ButtonFace;
			dataGridView_dados.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
			dataGridView_dados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridView_dados.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
			dataGridView_dados.Cursor = Cursors.Hand;
			dataGridView_dados.GridColor = SystemColors.ActiveCaptionText;
			dataGridView_dados.Location = new Point(20, 88);
			dataGridView_dados.Margin = new Padding(4, 3, 4, 3);
			dataGridView_dados.MultiSelect = false;
			dataGridView_dados.Name = "dataGridView_dados";
			dataGridView_dados.ReadOnly = true;
			dataGridView_dados.RowHeadersVisible = false;
			dataGridView_dados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridView_dados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_dados.Size = new Size(1156, 387);
			dataGridView_dados.TabIndex = 15;
			dataGridView_dados.CellMouseDoubleClick += dataGridView_dados_CellMouseDoubleClick;
			// 
			// Column1
			// 
			Column1.DataPropertyName = "EAN";
			Column1.FillWeight = 68.96552F;
			Column1.HeaderText = "EAN";
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			Column1.Visible = false;
			// 
			// Column2
			// 
			Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			Column2.DataPropertyName = "COD_PRODUTO";
			Column2.HeaderText = "COD PRODUTO";
			Column2.Name = "Column2";
			Column2.ReadOnly = true;
			Column2.Width = 113;
			// 
			// Column3
			// 
			Column3.DataPropertyName = "DESCRICAO_PRODUTO";
			Column3.FillWeight = 193.1035F;
			Column3.HeaderText = "DESCRIÇÃO PRODUTO";
			Column3.Name = "Column3";
			Column3.ReadOnly = true;
			// 
			// Column4
			// 
			Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			Column4.DataPropertyName = "STATUS";
			Column4.HeaderText = "STATUS";
			Column4.Name = "Column4";
			Column4.ReadOnly = true;
			Column4.Resizable = DataGridViewTriState.True;
			Column4.Visible = false;
			// 
			// Column5
			// 
			Column5.DataPropertyName = "LABORATORIO";
			Column5.FillWeight = 68.96552F;
			Column5.HeaderText = "LABORATÓRIO";
			Column5.Name = "Column5";
			Column5.ReadOnly = true;
			Column5.Resizable = DataGridViewTriState.True;
			Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
			Column5.Visible = false;
			// 
			// Column6
			// 
			Column6.DataPropertyName = "GRUPO";
			Column6.FillWeight = 68.96552F;
			Column6.HeaderText = "GRUPO";
			Column6.Name = "Column6";
			Column6.ReadOnly = true;
			Column6.Resizable = DataGridViewTriState.True;
			Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
			Column6.Visible = false;
			// 
			// InputListProduto
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1190, 488);
			Controls.Add(dataGridView_dados);
			Controls.Add(label3);
			Controls.Add(textBox_busca);
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "InputListProduto";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "LISTA DE PRODUTOS";
			Load += InputList_Load;
			((ISupportInitialize)dataGridView_dados).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}
	}
}
