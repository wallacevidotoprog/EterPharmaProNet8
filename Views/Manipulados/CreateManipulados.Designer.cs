namespace EterPharmaPro.Views.Manipulados
{
	partial class CreateManipulados
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
			toolStripDropDownButton_print = new ToolStripButton();
			toolStripButton_clear = new ToolStripButton();
			panel_center = new Panel();
			groupBox7 = new GroupBox();
			groupBox8 = new GroupBox();
			textBox_valorT = new TextBox();
			comboBox_modo = new ComboBox();
			label13 = new Label();
			comboBox_pag = new ComboBox();
			label12 = new Label();
			comboBox_situacao = new ComboBox();
			label11 = new Label();
			groupBox1 = new GroupBox();
			groupBox6 = new GroupBox();
			textBox_obsGeral = new TextBox();
			groupBox5 = new GroupBox();
			dataGridView_medicamentos = new DataGridView();
			DADOS = new DataGridViewTextBoxColumn();
			groupBox3 = new GroupBox();
			ePictureBox_search = new EterPharmaPro.Utils.eControl.ePictureBox();
			groupBox4 = new GroupBox();
			button_getAddress = new Button();
			textBox_obsEnd = new TextBox();
			label10 = new Label();
			textBox_log = new TextBox();
			label5 = new Label();
			textBox5_tel = new TextBox();
			textBox_nomeC = new TextBox();
			label7 = new Label();
			label4 = new Label();
			textBox_rg = new TextBox();
			label14 = new Label();
			textBox_cpf = new TextBox();
			label6 = new Label();
			groupBox2 = new GroupBox();
			comboBox_user = new ComboBox();
			textBox_atn = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			dateTimePicker_data = new DateTimePicker();
			toolStrip_topMenu.SuspendLayout();
			panel_center.SuspendLayout();
			groupBox7.SuspendLayout();
			groupBox8.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox6.SuspendLayout();
			groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_medicamentos).BeginInit();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_search).BeginInit();
			groupBox4.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip_topMenu
			// 
			toolStrip_topMenu.BackColor = Color.WhiteSmoke;
			toolStrip_topMenu.Items.AddRange(new ToolStripItem[] { toolStripButton_exit, toolStripDropDownButton_print, toolStripButton_clear });
			toolStrip_topMenu.Location = new Point(0, 0);
			toolStrip_topMenu.Name = "toolStrip_topMenu";
			toolStrip_topMenu.RenderMode = ToolStripRenderMode.Professional;
			toolStrip_topMenu.Size = new Size(1283, 93);
			toolStrip_topMenu.TabIndex = 4;
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
			toolStripButton_exit.Click += toolStripButton_sair_Click;
			// 
			// toolStripDropDownButton_print
			// 
			toolStripDropDownButton_print.AutoSize = false;
			toolStripDropDownButton_print.Font = new Font("Segoe UI", 8F);
			toolStripDropDownButton_print.Image = Properties.Resources.download__1_;
			toolStripDropDownButton_print.ImageAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_print.ImageScaling = ToolStripItemImageScaling.None;
			toolStripDropDownButton_print.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton_print.Name = "toolStripDropDownButton_print";
			toolStripDropDownButton_print.Size = new Size(90, 90);
			toolStripDropDownButton_print.Tag = "";
			toolStripDropDownButton_print.Text = "IMPRIMIR";
			toolStripDropDownButton_print.TextAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_print.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripDropDownButton_print.ToolTipText = "IMPRIMIR";
			toolStripDropDownButton_print.Click += SavePrint;
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
			toolStripButton_clear.Click += CleanAll;
			// 
			// panel_center
			// 
			panel_center.AutoScroll = true;
			panel_center.BackColor = Color.WhiteSmoke;
			panel_center.Controls.Add(groupBox7);
			panel_center.Controls.Add(groupBox1);
			panel_center.Controls.Add(groupBox3);
			panel_center.Controls.Add(groupBox2);
			panel_center.Dock = DockStyle.Fill;
			panel_center.Location = new Point(0, 93);
			panel_center.Margin = new Padding(4, 3, 4, 3);
			panel_center.Name = "panel_center";
			panel_center.Size = new Size(1283, 656);
			panel_center.TabIndex = 5;
			// 
			// groupBox7
			// 
			groupBox7.Controls.Add(groupBox8);
			groupBox7.Controls.Add(comboBox_modo);
			groupBox7.Controls.Add(label13);
			groupBox7.Controls.Add(comboBox_pag);
			groupBox7.Controls.Add(label12);
			groupBox7.Controls.Add(comboBox_situacao);
			groupBox7.Controls.Add(label11);
			groupBox7.Dock = DockStyle.Top;
			groupBox7.Location = new Point(0, 598);
			groupBox7.Margin = new Padding(4, 3, 4, 3);
			groupBox7.Name = "groupBox7";
			groupBox7.Padding = new Padding(4, 3, 4, 3);
			groupBox7.Size = new Size(1266, 105);
			groupBox7.TabIndex = 5;
			groupBox7.TabStop = false;
			groupBox7.Text = "INFORMAÇÕES DE PAGAMENTO";
			// 
			// groupBox8
			// 
			groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			groupBox8.Controls.Add(textBox_valorT);
			groupBox8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox8.Location = new Point(979, 20);
			groupBox8.Margin = new Padding(4, 3, 4, 3);
			groupBox8.Name = "groupBox8";
			groupBox8.Padding = new Padding(4, 3, 4, 3);
			groupBox8.Size = new Size(280, 81);
			groupBox8.TabIndex = 10;
			groupBox8.TabStop = false;
			groupBox8.Text = "VALOR";
			// 
			// textBox_valorT
			// 
			textBox_valorT.Dock = DockStyle.Fill;
			textBox_valorT.Font = new Font("Microsoft Tai Le", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBox_valorT.Location = new Point(4, 17);
			textBox_valorT.Margin = new Padding(4, 3, 4, 3);
			textBox_valorT.Multiline = true;
			textBox_valorT.Name = "textBox_valorT";
			textBox_valorT.Size = new Size(272, 61);
			textBox_valorT.TabIndex = 0;
			textBox_valorT.Text = "999.99";
			textBox_valorT.TextAlign = HorizontalAlignment.Center;
			// 
			// comboBox_modo
			// 
			comboBox_modo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			comboBox_modo.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_modo.FlatStyle = FlatStyle.System;
			comboBox_modo.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comboBox_modo.FormattingEnabled = true;
			comboBox_modo.Location = new Point(468, 52);
			comboBox_modo.Margin = new Padding(4, 3, 4, 3);
			comboBox_modo.Name = "comboBox_modo";
			comboBox_modo.Size = new Size(504, 33);
			comboBox_modo.TabIndex = 2;
			// 
			// label13
			// 
			label13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label13.AutoSize = true;
			label13.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label13.Location = new Point(462, 20);
			label13.Margin = new Padding(4, 0, 4, 0);
			label13.Name = "label13";
			label13.Size = new Size(196, 25);
			label13.TabIndex = 9;
			label13.Text = "MODO DE ENTREGA:";
			// 
			// comboBox_pag
			// 
			comboBox_pag.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_pag.FlatStyle = FlatStyle.System;
			comboBox_pag.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comboBox_pag.FormattingEnabled = true;
			comboBox_pag.Location = new Point(195, 52);
			comboBox_pag.Margin = new Padding(4, 3, 4, 3);
			comboBox_pag.Name = "comboBox_pag";
			comboBox_pag.Size = new Size(265, 33);
			comboBox_pag.TabIndex = 1;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label12.Location = new Point(189, 20);
			label12.Margin = new Padding(4, 0, 4, 0);
			label12.Name = "label12";
			label12.Size = new Size(237, 25);
			label12.TabIndex = 7;
			label12.Text = "FORMA DE PAGAMENTO:";
			// 
			// comboBox_situacao
			// 
			comboBox_situacao.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_situacao.FlatStyle = FlatStyle.System;
			comboBox_situacao.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comboBox_situacao.FormattingEnabled = true;
			comboBox_situacao.Location = new Point(7, 52);
			comboBox_situacao.Margin = new Padding(4, 3, 4, 3);
			comboBox_situacao.Name = "comboBox_situacao";
			comboBox_situacao.Size = new Size(180, 33);
			comboBox_situacao.TabIndex = 0;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label11.Location = new Point(1, 20);
			label11.Margin = new Padding(4, 0, 4, 0);
			label11.Name = "label11";
			label11.Size = new Size(109, 25);
			label11.TabIndex = 5;
			label11.Text = "SITUAÇÃO:";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(groupBox6);
			groupBox1.Controls.Add(groupBox5);
			groupBox1.Dock = DockStyle.Top;
			groupBox1.Location = new Point(0, 395);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(1266, 203);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			// 
			// groupBox6
			// 
			groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox6.Controls.Add(textBox_obsGeral);
			groupBox6.Location = new Point(603, 22);
			groupBox6.Margin = new Padding(4, 3, 4, 3);
			groupBox6.Name = "groupBox6";
			groupBox6.Padding = new Padding(4, 3, 4, 3);
			groupBox6.Size = new Size(649, 175);
			groupBox6.TabIndex = 5;
			groupBox6.TabStop = false;
			groupBox6.Text = "OBSERVAÇÕES GERAIS";
			// 
			// textBox_obsGeral
			// 
			textBox_obsGeral.Dock = DockStyle.Fill;
			textBox_obsGeral.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_obsGeral.Location = new Point(4, 19);
			textBox_obsGeral.Margin = new Padding(4, 3, 4, 3);
			textBox_obsGeral.Multiline = true;
			textBox_obsGeral.Name = "textBox_obsGeral";
			textBox_obsGeral.Size = new Size(641, 153);
			textBox_obsGeral.TabIndex = 0;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(dataGridView_medicamentos);
			groupBox5.Location = new Point(14, 22);
			groupBox5.Margin = new Padding(4, 3, 4, 3);
			groupBox5.Name = "groupBox5";
			groupBox5.Padding = new Padding(4, 3, 4, 3);
			groupBox5.Size = new Size(582, 175);
			groupBox5.TabIndex = 4;
			groupBox5.TabStop = false;
			groupBox5.Text = "MANIPULADO";
			// 
			// dataGridView_medicamentos
			// 
			dataGridView_medicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_medicamentos.BackgroundColor = SystemColors.ButtonFace;
			dataGridView_medicamentos.BorderStyle = BorderStyle.Fixed3D;
			dataGridView_medicamentos.ColumnHeadersVisible = false;
			dataGridView_medicamentos.Columns.AddRange(new DataGridViewColumn[] { DADOS });
			dataGridView_medicamentos.Dock = DockStyle.Fill;
			dataGridView_medicamentos.Location = new Point(4, 19);
			dataGridView_medicamentos.Margin = new Padding(4, 3, 4, 3);
			dataGridView_medicamentos.MultiSelect = false;
			dataGridView_medicamentos.Name = "dataGridView_medicamentos";
			dataGridView_medicamentos.RowHeadersVisible = false;
			dataGridView_medicamentos.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dataGridView_medicamentos.Size = new Size(574, 153);
			dataGridView_medicamentos.TabIndex = 0;
			// 
			// DADOS
			// 
			DADOS.HeaderText = "Column1";
			DADOS.Name = "DADOS";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(ePictureBox_search);
			groupBox3.Controls.Add(groupBox4);
			groupBox3.Controls.Add(textBox5_tel);
			groupBox3.Controls.Add(textBox_nomeC);
			groupBox3.Controls.Add(label7);
			groupBox3.Controls.Add(label4);
			groupBox3.Controls.Add(textBox_rg);
			groupBox3.Controls.Add(label14);
			groupBox3.Controls.Add(textBox_cpf);
			groupBox3.Controls.Add(label6);
			groupBox3.Dock = DockStyle.Top;
			groupBox3.Location = new Point(0, 115);
			groupBox3.Margin = new Padding(4, 3, 4, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(4, 3, 4, 3);
			groupBox3.Size = new Size(1266, 280);
			groupBox3.TabIndex = 0;
			groupBox3.TabStop = false;
			groupBox3.Text = "DADOS DO CLIENTE";
			// 
			// ePictureBox_search
			// 
			ePictureBox_search.Cursor = Cursors.Hand;
			ePictureBox_search.Image = Properties.Resources.lupa;
			ePictureBox_search.Location = new Point(450, 44);
			ePictureBox_search.Margin = new Padding(4, 3, 4, 3);
			ePictureBox_search.Name = "ePictureBox_search";
			ePictureBox_search.Size = new Size(37, 38);
			ePictureBox_search.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_search.TabIndex = 15;
			ePictureBox_search.TabStop = false;
			ePictureBox_search.ToolTipText = "Buscar Cliente";
			ePictureBox_search.Click += BuscaCliente_Click;
			// 
			// groupBox4
			// 
			groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox4.Controls.Add(button_getAddress);
			groupBox4.Controls.Add(textBox_obsEnd);
			groupBox4.Controls.Add(label10);
			groupBox4.Controls.Add(textBox_log);
			groupBox4.Controls.Add(label5);
			groupBox4.Location = new Point(7, 96);
			groupBox4.Margin = new Padding(4, 3, 4, 3);
			groupBox4.Name = "groupBox4";
			groupBox4.Padding = new Padding(4, 3, 4, 3);
			groupBox4.Size = new Size(1252, 177);
			groupBox4.TabIndex = 14;
			groupBox4.TabStop = false;
			groupBox4.Text = "ENDEREÇO DO CLIENTE";
			// 
			// button_getAddress
			// 
			button_getAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button_getAddress.Font = new Font("Microsoft Tai Le", 15F);
			button_getAddress.Location = new Point(1038, 50);
			button_getAddress.Name = "button_getAddress";
			button_getAddress.Size = new Size(203, 33);
			button_getAddress.TabIndex = 16;
			button_getAddress.Text = "Buscar Endereço";
			button_getAddress.UseVisualStyleBackColor = true;
			button_getAddress.Click += button_getAddress_Click;
			// 
			// textBox_obsEnd
			// 
			textBox_obsEnd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_obsEnd.CharacterCasing = CharacterCasing.Upper;
			textBox_obsEnd.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_obsEnd.Location = new Point(7, 125);
			textBox_obsEnd.Margin = new Padding(4, 3, 4, 3);
			textBox_obsEnd.Name = "textBox_obsEnd";
			textBox_obsEnd.ReadOnly = true;
			textBox_obsEnd.Size = new Size(1238, 33);
			textBox_obsEnd.TabIndex = 1;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label10.Location = new Point(7, 92);
			label10.Margin = new Padding(4, 0, 4, 0);
			label10.Name = "label10";
			label10.Size = new Size(140, 25);
			label10.TabIndex = 15;
			label10.Text = "OBSERVAÇÃO:";
			// 
			// textBox_log
			// 
			textBox_log.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_log.CharacterCasing = CharacterCasing.Upper;
			textBox_log.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_log.Location = new Point(7, 51);
			textBox_log.Margin = new Padding(4, 3, 4, 3);
			textBox_log.Name = "textBox_log";
			textBox_log.ReadOnly = true;
			textBox_log.Size = new Size(1024, 33);
			textBox_log.TabIndex = 0;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(7, 18);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(114, 25);
			label5.TabIndex = 8;
			label5.Text = "ENDEREÇO:";
			// 
			// textBox5_tel
			// 
			textBox5_tel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			textBox5_tel.CharacterCasing = CharacterCasing.Upper;
			textBox5_tel.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox5_tel.Location = new Point(878, 51);
			textBox5_tel.Margin = new Padding(4, 3, 4, 3);
			textBox5_tel.Name = "textBox5_tel";
			textBox5_tel.Size = new Size(381, 33);
			textBox5_tel.TabIndex = 3;
			textBox5_tel.Validated += textBox5_tel_Validated;
			// 
			// textBox_nomeC
			// 
			textBox_nomeC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_nomeC.CharacterCasing = CharacterCasing.Upper;
			textBox_nomeC.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_nomeC.Location = new Point(495, 51);
			textBox_nomeC.Margin = new Padding(4, 3, 4, 3);
			textBox_nomeC.Name = "textBox_nomeC";
			textBox_nomeC.Size = new Size(375, 33);
			textBox_nomeC.TabIndex = 2;
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label7.AutoSize = true;
			label7.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.Location = new Point(888, 18);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(105, 25);
			label7.TabIndex = 12;
			label7.Text = "TELEFONE:";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(489, 18);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(74, 25);
			label4.TabIndex = 6;
			label4.Text = "NOME:";
			// 
			// textBox_rg
			// 
			textBox_rg.CharacterCasing = CharacterCasing.Upper;
			textBox_rg.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_rg.Location = new Point(229, 51);
			textBox_rg.Margin = new Padding(4, 3, 4, 3);
			textBox_rg.Name = "textBox_rg";
			textBox_rg.Size = new Size(214, 33);
			textBox_rg.TabIndex = 1;
			textBox_rg.Validated += textBox_rg_Validated;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label14.Location = new Point(229, 18);
			label14.Margin = new Padding(4, 0, 4, 0);
			label14.Name = "label14";
			label14.Size = new Size(42, 25);
			label14.TabIndex = 10;
			label14.Text = "RG:";
			// 
			// textBox_cpf
			// 
			textBox_cpf.CharacterCasing = CharacterCasing.Upper;
			textBox_cpf.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_cpf.Location = new Point(7, 51);
			textBox_cpf.Margin = new Padding(4, 3, 4, 3);
			textBox_cpf.Name = "textBox_cpf";
			textBox_cpf.Size = new Size(214, 33);
			textBox_cpf.TabIndex = 0;
			textBox_cpf.Validated += textBox_cpf_Validated;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.Location = new Point(7, 18);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(49, 25);
			label6.TabIndex = 10;
			label6.Text = "CPF:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(comboBox_user);
			groupBox2.Controls.Add(textBox_atn);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(dateTimePicker_data);
			groupBox2.Dock = DockStyle.Top;
			groupBox2.Location = new Point(0, 0);
			groupBox2.Margin = new Padding(4, 3, 4, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(4, 3, 4, 3);
			groupBox2.Size = new Size(1266, 115);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			// 
			// comboBox_user
			// 
			comboBox_user.AutoCompleteMode = AutoCompleteMode.Append;
			comboBox_user.AutoCompleteSource = AutoCompleteSource.ListItems;
			comboBox_user.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comboBox_user.FormattingEnabled = true;
			comboBox_user.Location = new Point(9, 51);
			comboBox_user.Margin = new Padding(4, 3, 4, 3);
			comboBox_user.Name = "comboBox_user";
			comboBox_user.Size = new Size(299, 33);
			comboBox_user.TabIndex = 0;
			comboBox_user.Text = " ";
			// 
			// textBox_atn
			// 
			textBox_atn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			textBox_atn.CharacterCasing = CharacterCasing.Upper;
			textBox_atn.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_atn.Location = new Point(888, 51);
			textBox_atn.Margin = new Padding(4, 3, 4, 3);
			textBox_atn.Name = "textBox_atn";
			textBox_atn.Size = new Size(370, 33);
			textBox_atn.TabIndex = 2;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(888, 18);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(298, 25);
			label3.TabIndex = 4;
			label3.Text = "ATENDENTE DA MANIPULAÇÃO:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(7, 18);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(143, 25);
			label2.TabIndex = 3;
			label2.Text = "VENDEDOR(A):";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(310, 18);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(66, 25);
			label1.TabIndex = 1;
			label1.Text = "DATA:";
			// 
			// dateTimePicker_data
			// 
			dateTimePicker_data.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			dateTimePicker_data.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dateTimePicker_data.Location = new Point(316, 51);
			dateTimePicker_data.Margin = new Padding(4, 3, 4, 3);
			dateTimePicker_data.Name = "dateTimePicker_data";
			dateTimePicker_data.Size = new Size(565, 33);
			dateTimePicker_data.TabIndex = 1;
			// 
			// CreateManipulados
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(1283, 749);
			Controls.Add(panel_center);
			Controls.Add(toolStrip_topMenu);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(4, 3, 4, 3);
			Name = "CreateManipulados";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Load += CreateManipulados_Load;
			toolStrip_topMenu.ResumeLayout(false);
			toolStrip_topMenu.PerformLayout();
			panel_center.ResumeLayout(false);
			groupBox7.ResumeLayout(false);
			groupBox7.PerformLayout();
			groupBox8.ResumeLayout(false);
			groupBox8.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView_medicamentos).EndInit();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_search).EndInit();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip_topMenu;
		private System.Windows.Forms.ToolStripButton toolStripButton_exit;
		private System.Windows.Forms.ToolStripButton toolStripDropDownButton_print;
		private System.Windows.Forms.Panel panel_center;
		private System.Windows.Forms.ToolStripButton toolStripButton_clear;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox comboBox_user;
		private System.Windows.Forms.TextBox textBox_atn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker_data;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBox_obsEnd;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox_log;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox5_tel;
		private System.Windows.Forms.TextBox textBox_nomeC;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_rg;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox_cpf;
		private System.Windows.Forms.Label label6;
		private Utils.eControl.ePictureBox ePictureBox_search;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox textBox_obsGeral;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.DataGridView dataGridView_medicamentos;
		private System.Windows.Forms.DataGridViewTextBoxColumn DADOS;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.TextBox textBox_valorT;
		private System.Windows.Forms.ComboBox comboBox_modo;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox comboBox_pag;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox comboBox_situacao;
		private System.Windows.Forms.Label label11;
		private Button button_getAddress;
	}
}