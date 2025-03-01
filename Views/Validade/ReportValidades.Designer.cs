namespace EterPharmaPro.Views.Validade
{
	partial class ReportValidades
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			toolStrip_topMenu = new ToolStrip();
			toolStripButton_exit = new ToolStripButton();
			toolStripButton_clear = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripButton_excel = new ToolStripButton();
			groupBox1 = new GroupBox();
			groupBox4 = new GroupBox();
			dataGridView_validadeFile = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			Action = new DataGridViewCheckBoxColumn();
			groupBox2 = new GroupBox();
			ePictureBox_busca = new EterPharmaPro.Utils.eControl.ePictureBox();
			dateTimePicker_dataBusca = new DateTimePicker();
			label6 = new Label();
			groupBox3 = new GroupBox();
			listView_produtos = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			columnHeader9 = new ColumnHeader();
			columnHeader10 = new ColumnHeader();
			columnHeader11 = new ColumnHeader();
			groupBox5 = new GroupBox();
			ePictureBox_import = new EterPharmaPro.Utils.eControl.ePictureBox();
			groupBox6 = new GroupBox();
			ePictureBox_export = new EterPharmaPro.Utils.eControl.ePictureBox();
			label2 = new Label();
			dateTimePicker_ate = new DateTimePicker();
			dateTimePicker_de = new DateTimePicker();
			label1 = new Label();
			toolStrip_topMenu.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_validadeFile).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_busca).BeginInit();
			groupBox3.SuspendLayout();
			groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_import).BeginInit();
			groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_export).BeginInit();
			SuspendLayout();
			// 
			// toolStrip_topMenu
			// 
			toolStrip_topMenu.BackColor = Color.WhiteSmoke;
			toolStrip_topMenu.Items.AddRange(new ToolStripItem[] { toolStripButton_exit, toolStripButton_clear, toolStripSeparator1, toolStripButton_excel });
			toolStrip_topMenu.Location = new Point(0, 0);
			toolStrip_topMenu.Name = "toolStrip_topMenu";
			toolStrip_topMenu.RenderMode = ToolStripRenderMode.Professional;
			toolStrip_topMenu.Size = new Size(1427, 93);
			toolStrip_topMenu.TabIndex = 5;
			toolStrip_topMenu.Text = "toolStrip1";
			// 
			// toolStripButton_exit
			// 
			toolStripButton_exit.Alignment = ToolStripItemAlignment.Right;
			toolStripButton_exit.AutoSize = false;
			toolStripButton_exit.Font = new Font("Segoe UI", 7F);
			toolStripButton_exit.Image = Properties.Resources.sair__1_;
			toolStripButton_exit.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton_exit.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton_exit.ImageTransparentColor = Color.Magenta;
			toolStripButton_exit.Name = "toolStripButton_exit";
			toolStripButton_exit.Size = new Size(90, 90);
			toolStripButton_exit.Tag = "SAIR";
			toolStripButton_exit.Text = "SAIR";
			toolStripButton_exit.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_exit.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_exit.ToolTipText = "SAIR";
			toolStripButton_exit.Click += toolStripButton_exit_Click;
			// 
			// toolStripButton_clear
			// 
			toolStripButton_clear.AutoSize = false;
			toolStripButton_clear.Font = new Font("Segoe UI", 8F);
			toolStripButton_clear.Image = Properties.Resources.limpar_limpo__1_;
			toolStripButton_clear.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton_clear.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton_clear.ImageTransparentColor = Color.Magenta;
			toolStripButton_clear.Name = "toolStripButton_clear";
			toolStripButton_clear.Size = new Size(90, 90);
			toolStripButton_clear.Tag = "";
			toolStripButton_clear.Text = "LIMPAR";
			toolStripButton_clear.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_clear.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_clear.ToolTipText = "Limpar formulário";
			toolStripButton_clear.Click += toolStripButton_clear_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 93);
			// 
			// toolStripButton_excel
			// 
			toolStripButton_excel.AutoSize = false;
			toolStripButton_excel.Font = new Font("Segoe UI", 8F);
			toolStripButton_excel.Image = Properties.Resources.excel;
			toolStripButton_excel.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton_excel.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton_excel.ImageTransparentColor = Color.Magenta;
			toolStripButton_excel.Name = "toolStripButton_excel";
			toolStripButton_excel.Size = new Size(90, 90);
			toolStripButton_excel.Tag = "";
			toolStripButton_excel.Text = "SALVAR EXCEL";
			toolStripButton_excel.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_excel.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_excel.ToolTipText = "Salvar documento em excel";
			toolStripButton_excel.Click += toolStripButton_excel_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(groupBox4);
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Dock = DockStyle.Left;
			groupBox1.Location = new Point(0, 93);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(353, 517);
			groupBox1.TabIndex = 12;
			groupBox1.TabStop = false;
			groupBox1.Text = "AÇÕES";
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(dataGridView_validadeFile);
			groupBox4.Dock = DockStyle.Fill;
			groupBox4.Location = new Point(4, 89);
			groupBox4.Margin = new Padding(4, 3, 4, 3);
			groupBox4.Name = "groupBox4";
			groupBox4.Padding = new Padding(4, 3, 4, 3);
			groupBox4.Size = new Size(345, 425);
			groupBox4.TabIndex = 3;
			groupBox4.TabStop = false;
			// 
			// dataGridView_validadeFile
			// 
			dataGridView_validadeFile.AllowUserToAddRows = false;
			dataGridView_validadeFile.AllowUserToDeleteRows = false;
			dataGridView_validadeFile.AllowUserToResizeColumns = false;
			dataGridView_validadeFile.AllowUserToResizeRows = false;
			dataGridView_validadeFile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_validadeFile.BackgroundColor = SystemColors.ButtonFace;
			dataGridView_validadeFile.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
			dataGridView_validadeFile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridView_validadeFile.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Action });
			dataGridView_validadeFile.Cursor = Cursors.Hand;
			dataGridView_validadeFile.Dock = DockStyle.Fill;
			dataGridView_validadeFile.GridColor = SystemColors.ActiveCaptionText;
			dataGridView_validadeFile.Location = new Point(4, 19);
			dataGridView_validadeFile.Margin = new Padding(4, 3, 4, 3);
			dataGridView_validadeFile.MultiSelect = false;
			dataGridView_validadeFile.Name = "dataGridView_validadeFile";
			dataGridView_validadeFile.ReadOnly = true;
			dataGridView_validadeFile.RowHeadersVisible = false;
			dataGridView_validadeFile.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridView_validadeFile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_validadeFile.Size = new Size(337, 403);
			dataGridView_validadeFile.TabIndex = 5;
			dataGridView_validadeFile.CellContentClick += dataGridView_validadeFile_CellContentClick;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			dataGridViewTextBoxColumn1.HeaderText = "ID";
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
			dataGridViewTextBoxColumn2.FillWeight = 200F;
			dataGridViewTextBoxColumn2.HeaderText = "NOME";
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewTextBoxColumn3.DataPropertyName = "Data";
			dataGridViewTextBoxColumn3.FillWeight = 193.1035F;
			dataGridViewTextBoxColumn3.HeaderText = "DATA";
			dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			dataGridViewTextBoxColumn3.ReadOnly = true;
			dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.NotSortable;
			// 
			// Action
			// 
			Action.FillWeight = 30F;
			Action.HeaderText = "";
			Action.Name = "Action";
			Action.ReadOnly = true;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(ePictureBox_busca);
			groupBox2.Controls.Add(dateTimePicker_dataBusca);
			groupBox2.Controls.Add(label6);
			groupBox2.Dock = DockStyle.Top;
			groupBox2.Location = new Point(4, 19);
			groupBox2.Margin = new Padding(4, 3, 4, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(4, 3, 4, 3);
			groupBox2.Size = new Size(345, 70);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			// 
			// ePictureBox_busca
			// 
			ePictureBox_busca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			ePictureBox_busca.Image = Properties.Resources.procurar;
			ePictureBox_busca.Location = new Point(291, 13);
			ePictureBox_busca.Margin = new Padding(4, 3, 4, 3);
			ePictureBox_busca.Name = "ePictureBox_busca";
			ePictureBox_busca.Size = new Size(47, 46);
			ePictureBox_busca.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_busca.TabIndex = 16;
			ePictureBox_busca.TabStop = false;
			ePictureBox_busca.ToolTipText = null;
			ePictureBox_busca.Click += ePictureBox_busca_ClickAsync;
			// 
			// dateTimePicker_dataBusca
			// 
			dateTimePicker_dataBusca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			dateTimePicker_dataBusca.CustomFormat = "MM/yyyy";
			dateTimePicker_dataBusca.Font = new Font("Microsoft Tai Le", 15F);
			dateTimePicker_dataBusca.Format = DateTimePickerFormat.Custom;
			dateTimePicker_dataBusca.Location = new Point(111, 18);
			dateTimePicker_dataBusca.Margin = new Padding(4, 3, 4, 3);
			dateTimePicker_dataBusca.Name = "dateTimePicker_dataBusca";
			dateTimePicker_dataBusca.ShowUpDown = true;
			dateTimePicker_dataBusca.Size = new Size(173, 33);
			dateTimePicker_dataBusca.TabIndex = 0;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.Location = new Point(4, 28);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(106, 25);
			label6.TabIndex = 12;
			label6.Text = "MÊS/ANO:";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(listView_produtos);
			groupBox3.Controls.Add(groupBox5);
			groupBox3.Dock = DockStyle.Fill;
			groupBox3.Location = new Point(353, 93);
			groupBox3.Margin = new Padding(4, 3, 4, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(4, 3, 4, 3);
			groupBox3.Size = new Size(1074, 517);
			groupBox3.TabIndex = 14;
			groupBox3.TabStop = false;
			// 
			// listView_produtos
			// 
			listView_produtos.Activation = ItemActivation.OneClick;
			listView_produtos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
			listView_produtos.Cursor = Cursors.Hand;
			listView_produtos.Dock = DockStyle.Fill;
			listView_produtos.FullRowSelect = true;
			listView_produtos.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			listView_produtos.HoverSelection = true;
			listView_produtos.Location = new Point(4, 134);
			listView_produtos.Margin = new Padding(4, 3, 4, 3);
			listView_produtos.Name = "listView_produtos";
			listView_produtos.Size = new Size(1066, 380);
			listView_produtos.TabIndex = 13;
			listView_produtos.UseCompatibleStateImageBehavior = false;
			listView_produtos.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "ID";
			columnHeader1.Width = 80;
			// 
			// columnHeader8
			// 
			columnHeader8.Text = "CÓDIGO";
			columnHeader8.Width = 115;
			// 
			// columnHeader9
			// 
			columnHeader9.Text = "DESCRIÇÃO";
			columnHeader9.Width = 300;
			// 
			// columnHeader10
			// 
			columnHeader10.Text = "QTD";
			columnHeader10.Width = 71;
			// 
			// columnHeader11
			// 
			columnHeader11.Text = "DATA VALIDADE";
			columnHeader11.Width = 200;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(ePictureBox_import);
			groupBox5.Controls.Add(groupBox6);
			groupBox5.Dock = DockStyle.Top;
			groupBox5.Location = new Point(4, 19);
			groupBox5.Margin = new Padding(4, 3, 4, 3);
			groupBox5.Name = "groupBox5";
			groupBox5.Padding = new Padding(4, 3, 4, 3);
			groupBox5.Size = new Size(1066, 115);
			groupBox5.TabIndex = 0;
			groupBox5.TabStop = false;
			groupBox5.Text = "IMPORTAÇÃO";
			// 
			// ePictureBox_import
			// 
			ePictureBox_import.Image = Properties.Resources.exportar;
			ePictureBox_import.Location = new Point(7, 22);
			ePictureBox_import.Margin = new Padding(4, 3, 4, 3);
			ePictureBox_import.Name = "ePictureBox_import";
			ePictureBox_import.Size = new Size(88, 87);
			ePictureBox_import.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_import.TabIndex = 15;
			ePictureBox_import.TabStop = false;
			ePictureBox_import.ToolTipText = "Importar validades selecionadas";
			ePictureBox_import.Click += ePictureBox_import_Click;
			// 
			// groupBox6
			// 
			groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			groupBox6.Controls.Add(ePictureBox_export);
			groupBox6.Controls.Add(label2);
			groupBox6.Controls.Add(dateTimePicker_ate);
			groupBox6.Controls.Add(dateTimePicker_de);
			groupBox6.Controls.Add(label1);
			groupBox6.Location = new Point(564, 18);
			groupBox6.Margin = new Padding(4, 3, 4, 3);
			groupBox6.Name = "groupBox6";
			groupBox6.Padding = new Padding(4, 3, 4, 3);
			groupBox6.Size = new Size(496, 78);
			groupBox6.TabIndex = 14;
			groupBox6.TabStop = false;
			groupBox6.Text = "Exportar Produtos Próximo da Validade";
			// 
			// ePictureBox_export
			// 
			ePictureBox_export.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			ePictureBox_export.Image = Properties.Resources.excel;
			ePictureBox_export.Location = new Point(442, 25);
			ePictureBox_export.Margin = new Padding(4, 3, 4, 3);
			ePictureBox_export.Name = "ePictureBox_export";
			ePictureBox_export.Size = new Size(47, 46);
			ePictureBox_export.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_export.TabIndex = 16;
			ePictureBox_export.TabStop = false;
			ePictureBox_export.ToolTipText = "Exportar validades selecionadas";
			ePictureBox_export.Click += ePictureBox_export_ClickAsync;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(212, 31);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(75, 31);
			label2.TabIndex = 18;
			label2.Text = "ATE:";
			// 
			// dateTimePicker_ate
			// 
			dateTimePicker_ate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			dateTimePicker_ate.CustomFormat = "MM/yyyy";
			dateTimePicker_ate.Font = new Font("Microsoft Tai Le", 15F);
			dateTimePicker_ate.Format = DateTimePickerFormat.Custom;
			dateTimePicker_ate.Location = new Point(307, 33);
			dateTimePicker_ate.Margin = new Padding(4, 3, 4, 3);
			dateTimePicker_ate.Name = "dateTimePicker_ate";
			dateTimePicker_ate.ShowUpDown = true;
			dateTimePicker_ate.Size = new Size(128, 33);
			dateTimePicker_ate.TabIndex = 17;
			dateTimePicker_ate.ValueChanged += dateTimePicker_de_ValueChanged;
			// 
			// dateTimePicker_de
			// 
			dateTimePicker_de.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			dateTimePicker_de.CustomFormat = "MM/yyyy";
			dateTimePicker_de.Font = new Font("Microsoft Tai Le", 15F);
			dateTimePicker_de.Format = DateTimePickerFormat.Custom;
			dateTimePicker_de.Location = new Point(77, 31);
			dateTimePicker_de.Margin = new Padding(4, 3, 4, 3);
			dateTimePicker_de.Name = "dateTimePicker_de";
			dateTimePicker_de.ShowUpDown = true;
			dateTimePicker_de.Size = new Size(128, 33);
			dateTimePicker_de.TabIndex = 17;
			dateTimePicker_de.ValueChanged += dateTimePicker_de_ValueChanged;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(0, 31);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(60, 31);
			label1.TabIndex = 16;
			label1.Text = "DE:";
			// 
			// ReportValidades
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1427, 610);
			Controls.Add(groupBox3);
			Controls.Add(groupBox1);
			Controls.Add(toolStrip_topMenu);
			Margin = new Padding(4, 3, 4, 3);
			Name = "ReportValidades";
			Text = "ReportMenipulados";
			Load += ReportValidades_Load;
			toolStrip_topMenu.ResumeLayout(false);
			toolStrip_topMenu.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView_validadeFile).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_busca).EndInit();
			groupBox3.ResumeLayout(false);
			groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)ePictureBox_import).EndInit();
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_export).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip_topMenu;
		private System.Windows.Forms.ToolStripButton toolStripButton_exit;
		private System.Windows.Forms.ToolStripButton toolStripButton_clear;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dataGridView_validadeFile;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker_dataBusca;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListView listView_produtos;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker_ate;
		private System.Windows.Forms.DateTimePicker dateTimePicker_de;
		private System.Windows.Forms.Label label1;
		private Utils.eControl.ePictureBox ePictureBox_import;
		private Utils.eControl.ePictureBox ePictureBox_busca;
		private Utils.eControl.ePictureBox ePictureBox_export;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Action;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton_excel;
	}
}