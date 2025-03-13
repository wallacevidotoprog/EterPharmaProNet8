namespace EterPharmaPro.Views.LoteControlado
{
	partial class CreateLoteControlados
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
			components = new System.ComponentModel.Container();
			toolStrip_topMenu = new ToolStrip();
			toolStripButton_print = new ToolStripButton();
			toolStripDropDownButton_clear = new ToolStripButton();
			groupBox1 = new GroupBox();
			textBox_rg = new EterPharmaPro.Utils.eControl.eTextBoxWithButton();
			textBox_cel = new TextBox();
			textBox_end = new TextBox();
			label3 = new Label();
			textBox_nome = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label6 = new Label();
			groupBox2 = new GroupBox();
			ePictureBox1 = new EterPharmaPro.Utils.eControl.ePictureBox();
			numericUpDown_qtd = new NumericUpDown();
			dateTimePicker_validade = new DateTimePicker();
			label8 = new Label();
			groupBox3 = new GroupBox();
			listView1 = new ListView();
			cod = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			columnHeader9 = new ColumnHeader();
			columnHeader10 = new ColumnHeader();
			contextMenuStrip_produtos = new ContextMenuStrip(components);
			eXCLUIRToolStripMenuItem = new ToolStripMenuItem();
			textBox_lote = new TextBox();
			label9 = new Label();
			label7 = new Label();
			textBox_medicamento = new TextBox();
			label5 = new Label();
			toolStrip_topMenu.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_qtd).BeginInit();
			groupBox3.SuspendLayout();
			contextMenuStrip_produtos.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip_topMenu
			// 
			toolStrip_topMenu.BackColor = Color.WhiteSmoke;
			toolStrip_topMenu.Dock = DockStyle.Right;
			toolStrip_topMenu.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip_topMenu.Items.AddRange(new ToolStripItem[] { toolStripButton_print, toolStripDropDownButton_clear });
			toolStrip_topMenu.Location = new Point(988, 0);
			toolStrip_topMenu.Name = "toolStrip_topMenu";
			toolStrip_topMenu.RenderMode = ToolStripRenderMode.Professional;
			toolStrip_topMenu.Size = new Size(91, 788);
			toolStrip_topMenu.TabIndex = 7;
			toolStrip_topMenu.Text = "toolStrip1";
			// 
			// toolStripButton_print
			// 
			toolStripButton_print.Alignment = ToolStripItemAlignment.Right;
			toolStripButton_print.AutoSize = false;
			toolStripButton_print.Font = new Font("Segoe UI", 7F);
			toolStripButton_print.Image = Properties.Resources.download__1_;
			toolStripButton_print.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton_print.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton_print.ImageTransparentColor = Color.Magenta;
			toolStripButton_print.Name = "toolStripButton_print";
			toolStripButton_print.Size = new Size(90, 90);
			toolStripButton_print.Tag = "IMPRIMIR";
			toolStripButton_print.Text = "IMPRIMIR";
			toolStripButton_print.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_print.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_print.ToolTipText = "IMPRIMIR";
			toolStripButton_print.Click += toolStripButton_print_Click;
			// 
			// toolStripDropDownButton_clear
			// 
			toolStripDropDownButton_clear.AutoSize = false;
			toolStripDropDownButton_clear.Font = new Font("Segoe UI", 8F);
			toolStripDropDownButton_clear.Image = Properties.Resources.limpar_limpo__1_;
			toolStripDropDownButton_clear.ImageAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_clear.ImageScaling = ToolStripItemImageScaling.None;
			toolStripDropDownButton_clear.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton_clear.Name = "toolStripDropDownButton_clear";
			toolStripDropDownButton_clear.Size = new Size(90, 90);
			toolStripDropDownButton_clear.Tag = "";
			toolStripDropDownButton_clear.Text = "LIMPAR";
			toolStripDropDownButton_clear.TextAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_clear.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripDropDownButton_clear.ToolTipText = "Limpar Formulário";
			toolStripDropDownButton_clear.Click += toolStripDropDownButton_clear_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(textBox_rg);
			groupBox1.Controls.Add(textBox_cel);
			groupBox1.Controls.Add(textBox_end);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(textBox_nome);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label6);
			groupBox1.Dock = DockStyle.Top;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(988, 268);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "DADOS DO CLIENTE";
			// 
			// textBox_rg
			// 
			textBox_rg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_rg.ButtonText = "CLIENTE EXISTENTE";
			textBox_rg.ButtonVisible = false;
			textBox_rg.Font = new Font("Microsoft Tai Le", 15F);
			textBox_rg.GetText = "";
			textBox_rg.Location = new Point(224, 14);
			textBox_rg.Margin = new Padding(4, 3, 4, 3);
			textBox_rg.Name = "textBox_rg";
			textBox_rg.Size = new Size(743, 39);
			textBox_rg.TabIndex = 0;
			textBox_rg.ButtonClick += textBox_rg_ButtonClick;
			textBox_rg.TexBoxValidated += textBox_rg_TexBoxValidated;
			// 
			// textBox_cel
			// 
			textBox_cel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBox_cel.CharacterCasing = CharacterCasing.Upper;
			textBox_cel.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_cel.Location = new Point(224, 215);
			textBox_cel.Margin = new Padding(4, 3, 4, 3);
			textBox_cel.Name = "textBox_cel";
			textBox_cel.Size = new Size(742, 33);
			textBox_cel.TabIndex = 3;
			textBox_cel.Validated += textBox_cel_Validated;
			// 
			// textBox_end
			// 
			textBox_end.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBox_end.CharacterCasing = CharacterCasing.Upper;
			textBox_end.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_end.Location = new Point(224, 115);
			textBox_end.Margin = new Padding(4, 3, 4, 3);
			textBox_end.Multiline = true;
			textBox_end.Name = "textBox_end";
			textBox_end.Size = new Size(742, 92);
			textBox_end.TabIndex = 2;
			textBox_end.KeyDown += textBox_end_KeyDownAsync;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(168, 24);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(42, 25);
			label3.TabIndex = 12;
			label3.Text = "RG:";
			// 
			// textBox_nome
			// 
			textBox_nome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBox_nome.CharacterCasing = CharacterCasing.Upper;
			textBox_nome.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_nome.Location = new Point(224, 60);
			textBox_nome.Margin = new Padding(4, 3, 4, 3);
			textBox_nome.Name = "textBox_nome";
			textBox_nome.Size = new Size(742, 33);
			textBox_nome.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(84, 115);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(114, 25);
			label1.TabIndex = 12;
			label1.Text = "ENDEREÇO:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(94, 218);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(105, 25);
			label2.TabIndex = 12;
			label2.Text = "TELEFONE:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.Location = new Point(2, 69);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(184, 25);
			label6.TabIndex = 12;
			label6.Text = "NOME DO CLIENTE:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(ePictureBox1);
			groupBox2.Controls.Add(numericUpDown_qtd);
			groupBox2.Controls.Add(dateTimePicker_validade);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(groupBox3);
			groupBox2.Controls.Add(textBox_lote);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(textBox_medicamento);
			groupBox2.Controls.Add(label5);
			groupBox2.Dock = DockStyle.Fill;
			groupBox2.Location = new Point(0, 268);
			groupBox2.Margin = new Padding(4, 3, 4, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(4, 3, 4, 3);
			groupBox2.Size = new Size(988, 520);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "DADOS DO MEDICAMENTO";
			// 
			// ePictureBox1
			// 
			ePictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			ePictureBox1.Image = Properties.Resources.arquivo__1_;
			ePictureBox1.Location = new Point(888, 75);
			ePictureBox1.Margin = new Padding(4, 3, 4, 3);
			ePictureBox1.Name = "ePictureBox1";
			ePictureBox1.Size = new Size(76, 75);
			ePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox1.TabIndex = 21;
			ePictureBox1.TabStop = false;
			ePictureBox1.ToolTipText = null;
			ePictureBox1.Click += ePictureBox1_Click;
			// 
			// numericUpDown_qtd
			// 
			numericUpDown_qtd.Font = new Font("Microsoft Tai Le", 15F);
			numericUpDown_qtd.Location = new Point(224, 67);
			numericUpDown_qtd.Margin = new Padding(4, 3, 4, 3);
			numericUpDown_qtd.Name = "numericUpDown_qtd";
			numericUpDown_qtd.Size = new Size(294, 33);
			numericUpDown_qtd.TabIndex = 1;
			// 
			// dateTimePicker_validade
			// 
			dateTimePicker_validade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			dateTimePicker_validade.CustomFormat = "dd/MM/yyyy";
			dateTimePicker_validade.Font = new Font("Microsoft Tai Le", 15F);
			dateTimePicker_validade.Format = DateTimePickerFormat.Custom;
			dateTimePicker_validade.Location = new Point(671, 67);
			dateTimePicker_validade.Margin = new Padding(4, 3, 4, 3);
			dateTimePicker_validade.Name = "dateTimePicker_validade";
			dateTimePicker_validade.Size = new Size(162, 33);
			dateTimePicker_validade.TabIndex = 2;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label8.Location = new Point(525, 74);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(106, 25);
			label8.TabIndex = 20;
			label8.Text = "VALIDADE:";
			// 
			// groupBox3
			// 
			groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox3.Controls.Add(listView1);
			groupBox3.Location = new Point(13, 157);
			groupBox3.Margin = new Padding(4, 3, 4, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(4, 3, 4, 3);
			groupBox3.Size = new Size(954, 357);
			groupBox3.TabIndex = 14;
			groupBox3.TabStop = false;
			groupBox3.Text = "MEDICAMENTOS";
			// 
			// listView1
			// 
			listView1.Activation = ItemActivation.OneClick;
			listView1.Columns.AddRange(new ColumnHeader[] { cod, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
			listView1.ContextMenuStrip = contextMenuStrip_produtos;
			listView1.Cursor = Cursors.Hand;
			listView1.Dock = DockStyle.Fill;
			listView1.FullRowSelect = true;
			listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			listView1.HoverSelection = true;
			listView1.Location = new Point(4, 19);
			listView1.Margin = new Padding(4, 3, 4, 3);
			listView1.Name = "listView1";
			listView1.Size = new Size(946, 335);
			listView1.TabIndex = 13;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			// 
			// cod
			// 
			cod.Text = "CÓDIGO";
			cod.Width = 95;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "MEDICAMENTO";
			columnHeader7.Width = 262;
			// 
			// columnHeader8
			// 
			columnHeader8.Text = "QTD";
			columnHeader8.Width = 43;
			// 
			// columnHeader9
			// 
			columnHeader9.Text = "VALIDADE";
			columnHeader9.Width = 131;
			// 
			// columnHeader10
			// 
			columnHeader10.Text = "LOTE";
			columnHeader10.Width = 240;
			// 
			// contextMenuStrip_produtos
			// 
			contextMenuStrip_produtos.Items.AddRange(new ToolStripItem[] { eXCLUIRToolStripMenuItem });
			contextMenuStrip_produtos.Name = "contextMenuStrip1";
			contextMenuStrip_produtos.Size = new Size(120, 26);
			// 
			// eXCLUIRToolStripMenuItem
			// 
			eXCLUIRToolStripMenuItem.Image = Properties.Resources.arquivo__;
			eXCLUIRToolStripMenuItem.Name = "eXCLUIRToolStripMenuItem";
			eXCLUIRToolStripMenuItem.Size = new Size(119, 22);
			eXCLUIRToolStripMenuItem.Text = "EXCLUIR";
			eXCLUIRToolStripMenuItem.Click += eXCLUIRToolStripMenuItem_Click;
			// 
			// textBox_lote
			// 
			textBox_lote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_lote.CharacterCasing = CharacterCasing.Upper;
			textBox_lote.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_lote.Location = new Point(224, 112);
			textBox_lote.Margin = new Padding(4, 3, 4, 3);
			textBox_lote.Name = "textBox_lote";
			textBox_lote.Size = new Size(608, 33);
			textBox_lote.TabIndex = 2;
			textBox_lote.KeyDown += textBox_lote_KeyDown;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label9.Location = new Point(55, 67);
			label9.Margin = new Padding(4, 0, 4, 0);
			label9.Name = "label9";
			label9.Size = new Size(139, 25);
			label9.TabIndex = 12;
			label9.Text = "QUANTIDADE:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.Location = new Point(147, 121);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(60, 25);
			label7.TabIndex = 12;
			label7.Text = "LOTE:";
			// 
			// textBox_medicamento
			// 
			textBox_medicamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_medicamento.CharacterCasing = CharacterCasing.Upper;
			textBox_medicamento.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_medicamento.Location = new Point(224, 13);
			textBox_medicamento.Margin = new Padding(4, 3, 4, 3);
			textBox_medicamento.Name = "textBox_medicamento";
			textBox_medicamento.Size = new Size(608, 33);
			textBox_medicamento.TabIndex = 0;
			textBox_medicamento.KeyDown += textBox_medicamento_KeyDown;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(35, 22);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(156, 25);
			label5.TabIndex = 12;
			label5.Text = "MEDICAMENTO:";
			// 
			// CreateLoteControlados
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1079, 788);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(toolStrip_topMenu);
			Margin = new Padding(4, 3, 4, 3);
			Name = "CreateLoteControlados";
			Text = "CreateLoteControlados";
			Load += CreateLoteControlados_Load;
			toolStrip_topMenu.ResumeLayout(false);
			toolStrip_topMenu.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_qtd).EndInit();
			groupBox3.ResumeLayout(false);
			contextMenuStrip_produtos.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip_topMenu;
		private System.Windows.Forms.ToolStripButton toolStripButton_print;
		private System.Windows.Forms.ToolStripButton toolStripDropDownButton_clear;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox_cel;
		private System.Windows.Forms.TextBox textBox_end;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_nome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown numericUpDown_qtd;
		private System.Windows.Forms.DateTimePicker dateTimePicker_validade;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.TextBox textBox_lote;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox_medicamento;
		private System.Windows.Forms.Label label5;
		private Utils.eControl.ePictureBox ePictureBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_produtos;
		private System.Windows.Forms.ToolStripMenuItem eXCLUIRToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader cod;
		private Utils.eControl.eTextBoxWithButton textBox_rg;
	}
}