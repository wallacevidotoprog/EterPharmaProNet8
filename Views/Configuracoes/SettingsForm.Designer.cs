namespace EterPharmaPro.Views.Configuracoes
{
	partial class SettingsForm
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
			groupBox1 = new GroupBox();
			listBox_list = new ListBox();
			panel2 = new Panel();
			textBox_store = new TextBox();
			ePictureBox_saveNameStore = new EterPharmaPro.Utils.eControl.ePictureBox();
			label_store = new Label();
			panel1 = new Panel();
			ePictureBox_add = new EterPharmaPro.Utils.eControl.ePictureBox();
			ePictureBox_remove = new EterPharmaPro.Utils.eControl.ePictureBox();
			button_hostname = new Button();
			groupBox_config = new GroupBox();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			dataGridView_prints = new DataGridView();
			name = new DataGridViewTextBoxColumn();
			sets = new DataGridViewComboBoxColumn();
			tabPage2 = new TabPage();
			panel3 = new Panel();
			ePictureBox_save = new EterPharmaPro.Utils.eControl.ePictureBox();
			groupBox1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_saveNameStore).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_add).BeginInit();
			((System.ComponentModel.ISupportInitialize)ePictureBox_remove).BeginInit();
			groupBox_config.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_prints).BeginInit();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_save).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(listBox_list);
			groupBox1.Controls.Add(panel2);
			groupBox1.Controls.Add(panel1);
			groupBox1.Controls.Add(button_hostname);
			groupBox1.Dock = DockStyle.Left;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(350, 549);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Lista de Computadores";
			// 
			// listBox_list
			// 
			listBox_list.Dock = DockStyle.Fill;
			listBox_list.Font = new Font("Segoe UI", 15F);
			listBox_list.FormattingEnabled = true;
			listBox_list.ItemHeight = 28;
			listBox_list.Location = new Point(3, 67);
			listBox_list.Name = "listBox_list";
			listBox_list.Size = new Size(344, 429);
			listBox_list.TabIndex = 2;
			listBox_list.SelectedIndexChanged += listBox_list_SelectedIndexChanged_1;
			// 
			// panel2
			// 
			panel2.Controls.Add(textBox_store);
			panel2.Controls.Add(ePictureBox_saveNameStore);
			panel2.Controls.Add(label_store);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(3, 42);
			panel2.Name = "panel2";
			panel2.Size = new Size(344, 25);
			panel2.TabIndex = 4;
			// 
			// textBox_store
			// 
			textBox_store.Dock = DockStyle.Fill;
			textBox_store.Location = new Point(55, 0);
			textBox_store.Name = "textBox_store";
			textBox_store.Size = new Size(264, 23);
			textBox_store.TabIndex = 0;
			textBox_store.TextAlign = HorizontalAlignment.Center;
			textBox_store.Validating += TextBoxEdit;
			// 
			// ePictureBox_saveNameStore
			// 
			ePictureBox_saveNameStore.Cursor = Cursors.Hand;
			ePictureBox_saveNameStore.Dock = DockStyle.Right;
			ePictureBox_saveNameStore.Image = Properties.Resources.verificado;
			ePictureBox_saveNameStore.Location = new Point(319, 0);
			ePictureBox_saveNameStore.Name = "ePictureBox_saveNameStore";
			ePictureBox_saveNameStore.Size = new Size(25, 25);
			ePictureBox_saveNameStore.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_saveNameStore.TabIndex = 4;
			ePictureBox_saveNameStore.TabStop = false;
			ePictureBox_saveNameStore.ToolTipText = "Salvar nome da loja";
			ePictureBox_saveNameStore.Click += ePictureBox_saveNameStore_Click;
			// 
			// label_store
			// 
			label_store.AutoSize = true;
			label_store.Dock = DockStyle.Left;
			label_store.Font = new Font("Segoe UI", 13F);
			label_store.Location = new Point(0, 0);
			label_store.Name = "label_store";
			label_store.Size = new Size(55, 25);
			label_store.TabIndex = 3;
			label_store.Text = "LOJA:";
			// 
			// panel1
			// 
			panel1.Controls.Add(ePictureBox_add);
			panel1.Controls.Add(ePictureBox_remove);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(3, 496);
			panel1.Name = "panel1";
			panel1.Size = new Size(344, 50);
			panel1.TabIndex = 3;
			// 
			// ePictureBox_add
			// 
			ePictureBox_add.Cursor = Cursors.Hand;
			ePictureBox_add.Dock = DockStyle.Left;
			ePictureBox_add.Image = Properties.Resources.mais;
			ePictureBox_add.Location = new Point(0, 0);
			ePictureBox_add.Name = "ePictureBox_add";
			ePictureBox_add.Size = new Size(50, 50);
			ePictureBox_add.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_add.TabIndex = 1;
			ePictureBox_add.TabStop = false;
			ePictureBox_add.ToolTipText = "Adicionar";
			ePictureBox_add.Click += ePictureBox_add_Click;
			// 
			// ePictureBox_remove
			// 
			ePictureBox_remove.Cursor = Cursors.Hand;
			ePictureBox_remove.Dock = DockStyle.Right;
			ePictureBox_remove.Image = Properties.Resources.remover;
			ePictureBox_remove.Location = new Point(294, 0);
			ePictureBox_remove.Name = "ePictureBox_remove";
			ePictureBox_remove.Size = new Size(50, 50);
			ePictureBox_remove.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_remove.TabIndex = 0;
			ePictureBox_remove.TabStop = false;
			ePictureBox_remove.ToolTipText = "Remover";
			// 
			// button_hostname
			// 
			button_hostname.Cursor = Cursors.Hand;
			button_hostname.Dock = DockStyle.Top;
			button_hostname.FlatStyle = FlatStyle.Flat;
			button_hostname.Location = new Point(3, 19);
			button_hostname.Name = "button_hostname";
			button_hostname.Size = new Size(344, 23);
			button_hostname.TabIndex = 2;
			button_hostname.Text = "HOSTNAME:";
			button_hostname.UseVisualStyleBackColor = true;
			button_hostname.Click += button_hostname_Click;
			// 
			// groupBox_config
			// 
			groupBox_config.Controls.Add(tabControl1);
			groupBox_config.Controls.Add(panel3);
			groupBox_config.Dock = DockStyle.Fill;
			groupBox_config.Location = new Point(350, 0);
			groupBox_config.Name = "groupBox_config";
			groupBox_config.Size = new Size(726, 549);
			groupBox_config.TabIndex = 2;
			groupBox_config.TabStop = false;
			groupBox_config.Text = "CONFIGURAÇÕES";
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(3, 69);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(720, 477);
			tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(dataGridView_prints);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(712, 449);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "IMPRESSORAS";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView_prints
			// 
			dataGridView_prints.AllowUserToAddRows = false;
			dataGridView_prints.AllowUserToDeleteRows = false;
			dataGridView_prints.AllowUserToResizeColumns = false;
			dataGridView_prints.AllowUserToResizeRows = false;
			dataGridView_prints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_prints.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
			dataGridView_prints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView_prints.Columns.AddRange(new DataGridViewColumn[] { name, sets });
			dataGridView_prints.Dock = DockStyle.Fill;
			dataGridView_prints.Location = new Point(3, 3);
			dataGridView_prints.Name = "dataGridView_prints";
			dataGridView_prints.RowHeadersVisible = false;
			dataGridView_prints.ScrollBars = ScrollBars.Vertical;
			dataGridView_prints.Size = new Size(706, 443);
			dataGridView_prints.TabIndex = 5;
			dataGridView_prints.CellValueChanged += dataGridView_prints_CellValueChanged;
			dataGridView_prints.EditingControlShowing += dataGridView_prints_EditingControlShowing;
			// 
			// name
			// 
			name.FillWeight = 30F;
			name.HeaderText = "NAME";
			name.Name = "name";
			name.ReadOnly = true;
			// 
			// sets
			// 
			sets.HeaderText = "TIPOS";
			sets.Name = "sets";
			sets.Resizable = DataGridViewTriState.True;
			sets.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// tabPage2
			// 
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(712, 449);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "NONE";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			panel3.Controls.Add(ePictureBox_save);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(3, 19);
			panel3.Name = "panel3";
			panel3.Size = new Size(720, 50);
			panel3.TabIndex = 4;
			// 
			// ePictureBox_save
			// 
			ePictureBox_save.Cursor = Cursors.Hand;
			ePictureBox_save.Dock = DockStyle.Right;
			ePictureBox_save.Image = Properties.Resources.salve;
			ePictureBox_save.Location = new Point(670, 0);
			ePictureBox_save.Name = "ePictureBox_save";
			ePictureBox_save.Size = new Size(50, 50);
			ePictureBox_save.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_save.TabIndex = 0;
			ePictureBox_save.TabStop = false;
			ePictureBox_save.ToolTipText = "Remover";
			ePictureBox_save.Click += ePictureBox_saveNameStore_Click;
			// 
			// SettingsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1076, 549);
			Controls.Add(groupBox_config);
			Controls.Add(groupBox1);
			Name = "SettingsForm";
			Text = "SettingsForm";
			FormClosing += SettingsForm_FormClosing;
			Load += SettingsForm_Load;
			groupBox1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_saveNameStore).EndInit();
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)ePictureBox_add).EndInit();
			((System.ComponentModel.ISupportInitialize)ePictureBox_remove).EndInit();
			groupBox_config.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView_prints).EndInit();
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)ePictureBox_save).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private GroupBox groupBox1;
		private Button button_hostname;
		private ListBox listBox_list;
		private Panel panel1;
		private Utils.eControl.ePictureBox ePictureBox_remove;
		private Utils.eControl.ePictureBox ePictureBox_add;
		private Panel panel2;
		private TextBox textBox_store;
		private Label label_store;
		private Utils.eControl.ePictureBox ePictureBox_saveNameStore;
		private GroupBox groupBox_config;
		private Panel panel3;
		private Utils.eControl.ePictureBox ePictureBox_save;
		private DataGridView dataGridView_prints;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private DataGridViewTextBoxColumn name;
		private DataGridViewComboBoxColumn sets;
	}
}