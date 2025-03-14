namespace EterPharmaPro.Views.IMPRESSOES
{
	partial class TagViewer
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
			toolStripButton_print = new ToolStripButton();
			toolStrip_topMenu = new ToolStrip();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripButton_clear = new ToolStripButton();
			groupBox1 = new GroupBox();
			groupBox3 = new GroupBox();
			dataGridView_validade = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			OLD_PRICE = new DataGridViewTextBoxColumn();
			NEW_PRICE = new DataGridViewTextBoxColumn();
			DATA_VALITY = new DataGridViewTextBoxColumn();
			DELETE = new DataGridViewButtonColumn();
			groupBox2 = new GroupBox();
			pictureBox_addItem = new EterPharmaPro.Utils.eControl.ePictureBox();
			numericUpDown_qtd = new NumericUpDown();
			label4 = new Label();
			textBox_new = new TextBox();
			label3 = new Label();
			textBox_old = new TextBox();
			label2 = new Label();
			dateTimePicker_data = new DateTimePicker();
			label1 = new Label();
			textBox_produto = new TextBox();
			label5 = new Label();
			toolStrip_topMenu.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_validade).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox_addItem).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_qtd).BeginInit();
			SuspendLayout();
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
			toolStripButton_print.Tag = "";
			toolStripButton_print.Text = "IMPRIMIR";
			toolStripButton_print.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_print.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_print.ToolTipText = "Imprimir Tags de validade";
			toolStripButton_print.Click += ePictureBox_gerar_Click;
			// 
			// toolStrip_topMenu
			// 
			toolStrip_topMenu.BackColor = Color.WhiteSmoke;
			toolStrip_topMenu.Dock = DockStyle.Right;
			toolStrip_topMenu.Items.AddRange(new ToolStripItem[] { toolStripButton_print, toolStripSeparator1, toolStripButton_clear });
			toolStrip_topMenu.Location = new Point(1047, 0);
			toolStrip_topMenu.Name = "toolStrip_topMenu";
			toolStrip_topMenu.RenderMode = ToolStripRenderMode.Professional;
			toolStrip_topMenu.Size = new Size(91, 519);
			toolStrip_topMenu.TabIndex = 10;
			toolStrip_topMenu.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(88, 6);
			// 
			// toolStripButton_clear
			// 
			toolStripButton_clear.AutoSize = false;
			toolStripButton_clear.Font = new Font("Segoe UI", 7F);
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
			toolStripButton_clear.ToolTipText = "LIMPAR";
			toolStripButton_clear.Click += toolStripButton_clear_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(groupBox3);
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(1047, 519);
			groupBox1.TabIndex = 13;
			groupBox1.TabStop = false;
			groupBox1.Text = "VALIDADES";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(dataGridView_validade);
			groupBox3.Dock = DockStyle.Fill;
			groupBox3.Location = new Point(4, 134);
			groupBox3.Margin = new Padding(4, 3, 4, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(4, 3, 4, 3);
			groupBox3.Size = new Size(1039, 382);
			groupBox3.TabIndex = 8;
			groupBox3.TabStop = false;
			// 
			// dataGridView_validade
			// 
			dataGridView_validade.AllowUserToAddRows = false;
			dataGridView_validade.AllowUserToDeleteRows = false;
			dataGridView_validade.AllowUserToResizeColumns = false;
			dataGridView_validade.AllowUserToResizeRows = false;
			dataGridView_validade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_validade.BackgroundColor = SystemColors.ButtonFace;
			dataGridView_validade.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
			dataGridView_validade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridView_validade.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, OLD_PRICE, NEW_PRICE, DATA_VALITY, DELETE });
			dataGridView_validade.Cursor = Cursors.Hand;
			dataGridView_validade.Dock = DockStyle.Fill;
			dataGridView_validade.GridColor = SystemColors.ActiveCaptionText;
			dataGridView_validade.Location = new Point(4, 19);
			dataGridView_validade.Margin = new Padding(4, 3, 4, 3);
			dataGridView_validade.MultiSelect = false;
			dataGridView_validade.Name = "dataGridView_validade";
			dataGridView_validade.RowHeadersVisible = false;
			dataGridView_validade.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridView_validade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_validade.Size = new Size(1031, 360);
			dataGridView_validade.TabIndex = 6;
			dataGridView_validade.CellContentClick += dataGridView_validade_CellContentClick;
			dataGridView_validade.RowValidated += dataGridView_validade_RowValidated;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			dataGridViewTextBoxColumn1.FillWeight = 68.96552F;
			dataGridViewTextBoxColumn1.HeaderText = "ID";
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Width = 43;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
			dataGridViewTextBoxColumn2.FillWeight = 200F;
			dataGridViewTextBoxColumn2.HeaderText = "NOME";
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// OLD_PRICE
			// 
			OLD_PRICE.HeaderText = "PREÇO ANTIGO";
			OLD_PRICE.Name = "OLD_PRICE";
			// 
			// NEW_PRICE
			// 
			NEW_PRICE.HeaderText = "NOVO PREÇO";
			NEW_PRICE.Name = "NEW_PRICE";
			// 
			// DATA_VALITY
			// 
			DATA_VALITY.HeaderText = "VALIDADE";
			DATA_VALITY.Name = "DATA_VALITY";
			DATA_VALITY.ReadOnly = true;
			// 
			// DELETE
			// 
			DELETE.FillWeight = 80F;
			DELETE.HeaderText = "DELETAR";
			DELETE.Name = "DELETE";
			DELETE.Text = "DELETAR";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(pictureBox_addItem);
			groupBox2.Controls.Add(numericUpDown_qtd);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(textBox_new);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(textBox_old);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(dateTimePicker_data);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(textBox_produto);
			groupBox2.Controls.Add(label5);
			groupBox2.Dock = DockStyle.Top;
			groupBox2.Location = new Point(4, 19);
			groupBox2.Margin = new Padding(4, 3, 4, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(4, 3, 4, 3);
			groupBox2.Size = new Size(1039, 115);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			// 
			// pictureBox_addItem
			// 
			pictureBox_addItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			pictureBox_addItem.Image = Properties.Resources.arquivo__1_;
			pictureBox_addItem.Location = new Point(956, 35);
			pictureBox_addItem.Margin = new Padding(4, 3, 4, 3);
			pictureBox_addItem.Name = "pictureBox_addItem";
			pictureBox_addItem.Size = new Size(75, 74);
			pictureBox_addItem.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox_addItem.TabIndex = 26;
			pictureBox_addItem.TabStop = false;
			pictureBox_addItem.ToolTipText = null;
			pictureBox_addItem.Click += pictureBox_addItem_Click;
			// 
			// numericUpDown_qtd
			// 
			numericUpDown_qtd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			numericUpDown_qtd.Font = new Font("Microsoft Tai Le", 15F);
			numericUpDown_qtd.Location = new Point(714, 59);
			numericUpDown_qtd.Margin = new Padding(4, 3, 4, 3);
			numericUpDown_qtd.Name = "numericUpDown_qtd";
			numericUpDown_qtd.Size = new Size(61, 33);
			numericUpDown_qtd.TabIndex = 3;
			numericUpDown_qtd.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(710, 28);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(55, 25);
			label4.TabIndex = 25;
			label4.Text = "QTD:";
			// 
			// textBox_new
			// 
			textBox_new.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			textBox_new.CharacterCasing = CharacterCasing.Upper;
			textBox_new.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_new.Location = new Point(547, 59);
			textBox_new.Margin = new Padding(4, 3, 4, 3);
			textBox_new.Name = "textBox_new";
			textBox_new.Size = new Size(159, 33);
			textBox_new.TabIndex = 2;
			textBox_new.KeyPress += textBox_old_KeyPress;
			textBox_new.Validated += textBox_old_Validated;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(541, 27);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(139, 25);
			label3.TabIndex = 22;
			label3.Text = "NOVO VALOR:";
			// 
			// textBox_old
			// 
			textBox_old.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			textBox_old.CharacterCasing = CharacterCasing.Upper;
			textBox_old.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_old.Location = new Point(378, 59);
			textBox_old.Margin = new Padding(4, 3, 4, 3);
			textBox_old.Name = "textBox_old";
			textBox_old.Size = new Size(162, 33);
			textBox_old.TabIndex = 1;
			textBox_old.KeyPress += textBox_old_KeyPress;
			textBox_old.Validated += textBox_old_Validated;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(375, 27);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(141, 25);
			label2.TabIndex = 22;
			label2.Text = "VALOR ATUAL:";
			// 
			// dateTimePicker_data
			// 
			dateTimePicker_data.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			dateTimePicker_data.CustomFormat = "dd/MM/yyyy";
			dateTimePicker_data.Font = new Font("Microsoft Tai Le", 15F);
			dateTimePicker_data.Format = DateTimePickerFormat.Custom;
			dateTimePicker_data.Location = new Point(787, 59);
			dateTimePicker_data.Margin = new Padding(4, 3, 4, 3);
			dateTimePicker_data.Name = "dateTimePicker_data";
			dateTimePicker_data.Size = new Size(162, 33);
			dateTimePicker_data.TabIndex = 4;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(781, 32);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(106, 25);
			label1.TabIndex = 20;
			label1.Text = "VALIDADE:";
			// 
			// textBox_produto
			// 
			textBox_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_produto.CharacterCasing = CharacterCasing.Upper;
			textBox_produto.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_produto.Location = new Point(16, 59);
			textBox_produto.Margin = new Padding(4, 3, 4, 3);
			textBox_produto.Name = "textBox_produto";
			textBox_produto.Size = new Size(354, 33);
			textBox_produto.TabIndex = 0;
			textBox_produto.KeyDown += textBox_produto_KeyDown;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(10, 27);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(107, 25);
			label5.TabIndex = 14;
			label5.Text = "PRODUTO:";
			// 
			// TagViewer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1138, 519);
			Controls.Add(groupBox1);
			Controls.Add(toolStrip_topMenu);
			Margin = new Padding(4, 3, 4, 3);
			Name = "TagViewer";
			Text = "TagViewer";
			toolStrip_topMenu.ResumeLayout(false);
			toolStrip_topMenu.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView_validade).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox_addItem).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_qtd).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripButton toolStripButton_print;
		private System.Windows.Forms.ToolStrip toolStrip_topMenu;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView_validade;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn OLD_PRICE;
		private System.Windows.Forms.DataGridViewTextBoxColumn NEW_PRICE;
		private System.Windows.Forms.DataGridViewTextBoxColumn DATA_VALITY;
		private System.Windows.Forms.DataGridViewButtonColumn DELETE;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown numericUpDown_qtd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_new;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_old;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker_data;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_produto;
		private System.Windows.Forms.Label label5;
		private Utils.eControl.ePictureBox pictureBox_addItem;
		private System.Windows.Forms.ToolStripButton toolStripButton_clear;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}