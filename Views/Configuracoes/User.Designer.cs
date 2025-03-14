namespace EterPharmaPro.Views.Configuracoes
{
	partial class User
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
			toolStripButton_new_save = new ToolStripButton();
			toolStripButton_cancel = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			groupBox_create = new GroupBox();
			label2 = new Label();
			eSwitchControl_stats = new EterPharmaPro.Utils.eControl.eSwitchControl();
			label3 = new Label();
			comboBox_funcao = new ComboBox();
			textBox_id = new TextBox();
			label6 = new Label();
			textBox_pass = new TextBox();
			label1 = new Label();
			textBox_nome = new TextBox();
			label4 = new Label();
			dataGridView_user = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			ID_LOJA = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			stats = new EterPharmaPro.Utils.Extencions.DataGridViewCheckBoxImageColumn();
			criado = new DataGridViewTextBoxColumn();
			ATT = new DataGridViewTextBoxColumn();
			dataGridViewCheckBoxImageColumn1 = new EterPharmaPro.Utils.Extencions.DataGridViewCheckBoxImageColumn();
			toolStrip_topMenu.SuspendLayout();
			groupBox_create.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_user).BeginInit();
			SuspendLayout();
			// 
			// toolStrip_topMenu
			// 
			toolStrip_topMenu.BackColor = Color.WhiteSmoke;
			toolStrip_topMenu.Dock = DockStyle.Right;
			toolStrip_topMenu.Items.AddRange(new ToolStripItem[] { toolStripButton_new_save, toolStripButton_cancel, toolStripSeparator1 });
			toolStrip_topMenu.Location = new Point(1076, 0);
			toolStrip_topMenu.Name = "toolStrip_topMenu";
			toolStrip_topMenu.RenderMode = ToolStripRenderMode.Professional;
			toolStrip_topMenu.Size = new Size(91, 673);
			toolStrip_topMenu.TabIndex = 9;
			toolStrip_topMenu.Text = "toolStrip1";
			// 
			// toolStripButton_new_save
			// 
			toolStripButton_new_save.AutoSize = false;
			toolStripButton_new_save.Font = new Font("Segoe UI", 7F);
			toolStripButton_new_save.Image = Properties.Resources.documento_new;
			toolStripButton_new_save.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton_new_save.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton_new_save.ImageTransparentColor = Color.Magenta;
			toolStripButton_new_save.Name = "toolStripButton_new_save";
			toolStripButton_new_save.Size = new Size(90, 90);
			toolStripButton_new_save.Tag = "";
			toolStripButton_new_save.Text = "NOVO";
			toolStripButton_new_save.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_new_save.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_new_save.ToolTipText = " ";
			toolStripButton_new_save.Click += toolStripButton_new_save_Click;
			// 
			// toolStripButton_cancel
			// 
			toolStripButton_cancel.AutoSize = false;
			toolStripButton_cancel.Font = new Font("Segoe UI", 7F);
			toolStripButton_cancel.Image = Properties.Resources.cancelar;
			toolStripButton_cancel.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton_cancel.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton_cancel.ImageTransparentColor = Color.Magenta;
			toolStripButton_cancel.Name = "toolStripButton_cancel";
			toolStripButton_cancel.Size = new Size(90, 90);
			toolStripButton_cancel.Tag = "";
			toolStripButton_cancel.Text = "CANCELAR";
			toolStripButton_cancel.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_cancel.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_cancel.ToolTipText = "Cancelar";
			toolStripButton_cancel.Visible = false;
			toolStripButton_cancel.Click += toolStripButton_cancel_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(88, 6);
			// 
			// groupBox_create
			// 
			groupBox_create.Controls.Add(label2);
			groupBox_create.Controls.Add(eSwitchControl_stats);
			groupBox_create.Controls.Add(label3);
			groupBox_create.Controls.Add(comboBox_funcao);
			groupBox_create.Controls.Add(textBox_id);
			groupBox_create.Controls.Add(label6);
			groupBox_create.Controls.Add(textBox_pass);
			groupBox_create.Controls.Add(label1);
			groupBox_create.Controls.Add(textBox_nome);
			groupBox_create.Controls.Add(label4);
			groupBox_create.Dock = DockStyle.Top;
			groupBox_create.Location = new Point(0, 0);
			groupBox_create.Margin = new Padding(4, 3, 4, 3);
			groupBox_create.Name = "groupBox_create";
			groupBox_create.Padding = new Padding(4, 3, 4, 3);
			groupBox_create.Size = new Size(1076, 325);
			groupBox_create.TabIndex = 25;
			groupBox_create.TabStop = false;
			groupBox_create.Visible = false;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(961, 246);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(71, 25);
			label2.TabIndex = 25;
			label2.Text = "STATS:";
			// 
			// eSwitchControl_stats
			// 
			eSwitchControl_stats.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			eSwitchControl_stats.AutoSize = true;
			eSwitchControl_stats.Checked = true;
			eSwitchControl_stats.CheckState = CheckState.Checked;
			eSwitchControl_stats.Cursor = Cursors.Hand;
			eSwitchControl_stats.FlatStyle = FlatStyle.Flat;
			eSwitchControl_stats.Location = new Point(980, 278);
			eSwitchControl_stats.Margin = new Padding(4, 3, 4, 3);
			eSwitchControl_stats.MinimumSize = new Size(52, 25);
			eSwitchControl_stats.Name = "eSwitchControl_stats";
			eSwitchControl_stats.OffBackColor = Color.Black;
			eSwitchControl_stats.OffToggleColor = Color.White;
			eSwitchControl_stats.OnBackColor = Color.SeaGreen;
			eSwitchControl_stats.OnToggleColor = Color.White;
			eSwitchControl_stats.Size = new Size(52, 25);
			eSwitchControl_stats.TabIndex = 24;
			eSwitchControl_stats.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(7, 18);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(35, 25);
			label3.TabIndex = 17;
			label3.Text = "ID:";
			// 
			// comboBox_funcao
			// 
			comboBox_funcao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			comboBox_funcao.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_funcao.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comboBox_funcao.FormattingEnabled = true;
			comboBox_funcao.Items.AddRange(new object[] { "EAN", "COD INTERNO" });
			comboBox_funcao.Location = new Point(13, 272);
			comboBox_funcao.Margin = new Padding(4, 3, 4, 3);
			comboBox_funcao.Name = "comboBox_funcao";
			comboBox_funcao.Size = new Size(930, 33);
			comboBox_funcao.TabIndex = 22;
			// 
			// textBox_id
			// 
			textBox_id.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_id.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_id.Location = new Point(13, 51);
			textBox_id.Margin = new Padding(4, 3, 4, 3);
			textBox_id.MaxLength = 4;
			textBox_id.Name = "textBox_id";
			textBox_id.Size = new Size(1057, 33);
			textBox_id.TabIndex = 16;
			textBox_id.TextAlign = HorizontalAlignment.Center;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.Location = new Point(7, 240);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(91, 25);
			label6.TabIndex = 23;
			label6.Text = "FUNÇÃO";
			// 
			// textBox_pass
			// 
			textBox_pass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_pass.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_pass.Location = new Point(13, 198);
			textBox_pass.Margin = new Padding(4, 3, 4, 3);
			textBox_pass.Name = "textBox_pass";
			textBox_pass.PasswordChar = '*';
			textBox_pass.Size = new Size(1057, 33);
			textBox_pass.TabIndex = 18;
			textBox_pass.TextAlign = HorizontalAlignment.Center;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(7, 166);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(79, 25);
			label1.TabIndex = 19;
			label1.Text = "SENHA:";
			// 
			// textBox_nome
			// 
			textBox_nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_nome.CharacterCasing = CharacterCasing.Upper;
			textBox_nome.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_nome.Location = new Point(13, 125);
			textBox_nome.Margin = new Padding(4, 3, 4, 3);
			textBox_nome.Name = "textBox_nome";
			textBox_nome.Size = new Size(1057, 33);
			textBox_nome.TabIndex = 18;
			textBox_nome.TextAlign = HorizontalAlignment.Center;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(7, 92);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(74, 25);
			label4.TabIndex = 19;
			label4.Text = "NOME:";
			// 
			// dataGridView_user
			// 
			dataGridView_user.AllowUserToAddRows = false;
			dataGridView_user.AllowUserToDeleteRows = false;
			dataGridView_user.AllowUserToResizeColumns = false;
			dataGridView_user.AllowUserToResizeRows = false;
			dataGridView_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_user.BackgroundColor = SystemColors.ButtonFace;
			dataGridView_user.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dataGridView_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridView_user.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, ID_LOJA, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, stats, criado, ATT });
			dataGridView_user.Cursor = Cursors.Hand;
			dataGridView_user.Dock = DockStyle.Fill;
			dataGridView_user.GridColor = SystemColors.ActiveCaptionText;
			dataGridView_user.Location = new Point(0, 325);
			dataGridView_user.Margin = new Padding(4, 3, 4, 3);
			dataGridView_user.MultiSelect = false;
			dataGridView_user.Name = "dataGridView_user";
			dataGridView_user.ReadOnly = true;
			dataGridView_user.RowHeadersVisible = false;
			dataGridView_user.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridView_user.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView_user.Size = new Size(1076, 348);
			dataGridView_user.TabIndex = 26;
			dataGridView_user.CellDoubleClick += dataGridView_user_CellDoubleClick;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			dataGridViewTextBoxColumn1.FillWeight = 68.96552F;
			dataGridViewTextBoxColumn1.HeaderText = "ID";
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Visible = false;
			// 
			// ID_LOJA
			// 
			ID_LOJA.DataPropertyName = "ID_LOJA";
			ID_LOJA.FillWeight = 50F;
			ID_LOJA.HeaderText = "ID LOJA";
			ID_LOJA.Name = "ID_LOJA";
			ID_LOJA.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.DataPropertyName = "NOME";
			dataGridViewTextBoxColumn2.FillWeight = 200F;
			dataGridViewTextBoxColumn2.HeaderText = "NOME";
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewTextBoxColumn3.DataPropertyName = "FUNCAO";
			dataGridViewTextBoxColumn3.FillWeight = 193.1035F;
			dataGridViewTextBoxColumn3.HeaderText = "FUNÇÃO";
			dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// stats
			// 
			stats.DataPropertyName = "STATS";
			stats.FillWeight = 30F;
			stats.HeaderText = "STATS";
			stats.Name = "stats";
			stats.ReadOnly = true;
			// 
			// criado
			// 
			criado.DataPropertyName = "CREATE";
			criado.FillWeight = 50F;
			criado.HeaderText = "CRIAÇÃO";
			criado.Name = "criado";
			criado.ReadOnly = true;
			// 
			// ATT
			// 
			ATT.DataPropertyName = "UPDATE";
			ATT.FillWeight = 50F;
			ATT.HeaderText = "ATUALIZAÇÃO";
			ATT.Name = "ATT";
			ATT.ReadOnly = true;
			// 
			// dataGridViewCheckBoxImageColumn1
			// 
			dataGridViewCheckBoxImageColumn1.DataPropertyName = "STATS";
			dataGridViewCheckBoxImageColumn1.FillWeight = 25F;
			dataGridViewCheckBoxImageColumn1.HeaderText = "STATS";
			dataGridViewCheckBoxImageColumn1.Name = "dataGridViewCheckBoxImageColumn1";
			dataGridViewCheckBoxImageColumn1.Width = 46;
			// 
			// User
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1167, 673);
			Controls.Add(dataGridView_user);
			Controls.Add(groupBox_create);
			Controls.Add(toolStrip_topMenu);
			Margin = new Padding(4, 3, 4, 3);
			Name = "User";
			Text = "User";
			Load += User_Load;
			toolStrip_topMenu.ResumeLayout(false);
			toolStrip_topMenu.PerformLayout();
			groupBox_create.ResumeLayout(false);
			groupBox_create.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_user).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip_topMenu;
		private System.Windows.Forms.ToolStripButton toolStripButton_new_save;
		private System.Windows.Forms.ToolStripButton toolStripButton_cancel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.GroupBox groupBox_create;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox_funcao;
		private System.Windows.Forms.TextBox textBox_id;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox_nome;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_pass;
		private System.Windows.Forms.Label label1;
		private Utils.eControl.eSwitchControl eSwitchControl_stats;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView_user;
		private Utils.Extencions.DataGridViewCheckBoxImageColumn dataGridViewCheckBoxImageColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_LOJA;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private Utils.Extencions.DataGridViewCheckBoxImageColumn stats;
		private System.Windows.Forms.DataGridViewTextBoxColumn criado;
		private System.Windows.Forms.DataGridViewTextBoxColumn ATT;
	}
}