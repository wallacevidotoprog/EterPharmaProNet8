namespace EterPharmaPro.Utils.Extencions
{
	partial class ImputTagPromocao
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
			label3 = new Label();
			textBox_busca = new TextBox();
			groupBox1 = new GroupBox();
			ePictureBox_send = new EterPharmaPro.Utils.eControl.ePictureBox();
			comboBox_TV2 = new ComboBox();
			comboBox_TV1 = new ComboBox();
			textBox_V2 = new TextBox();
			label2 = new Label();
			label5 = new Label();
			textBox_V1 = new TextBox();
			label4 = new Label();
			label1 = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_send).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(7, 15);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(107, 25);
			label3.TabIndex = 16;
			label3.Text = "PRODUTO:";
			// 
			// textBox_busca
			// 
			textBox_busca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_busca.CharacterCasing = CharacterCasing.Upper;
			textBox_busca.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_busca.Location = new Point(7, 43);
			textBox_busca.Margin = new Padding(4, 3, 4, 3);
			textBox_busca.Name = "textBox_busca";
			textBox_busca.Size = new Size(780, 33);
			textBox_busca.TabIndex = 0;
			textBox_busca.KeyDown += textBox_busca_KeyDown;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(ePictureBox_send);
			groupBox1.Controls.Add(comboBox_TV2);
			groupBox1.Controls.Add(comboBox_TV1);
			groupBox1.Controls.Add(textBox_V2);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(textBox_V1);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(textBox_busca);
			groupBox1.Controls.Add(label3);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(800, 327);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			// 
			// ePictureBox_send
			// 
			ePictureBox_send.Image = Properties.Resources.arquivo__1_;
			ePictureBox_send.Location = new Point(717, 251);
			ePictureBox_send.Name = "ePictureBox_send";
			ePictureBox_send.Size = new Size(70, 70);
			ePictureBox_send.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_send.TabIndex = 18;
			ePictureBox_send.TabStop = false;
			ePictureBox_send.ToolTipText = "Adicionar";
			ePictureBox_send.Click += ePictureBox_send_Click;
			// 
			// comboBox_TV2
			// 
			comboBox_TV2.AutoCompleteMode = AutoCompleteMode.Append;
			comboBox_TV2.AutoCompleteSource = AutoCompleteSource.ListItems;
			comboBox_TV2.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_TV2.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comboBox_TV2.FormattingEnabled = true;
			comboBox_TV2.Items.AddRange(new object[] { "APARTIR DE", "DE", "POR", "APENAS" });
			comboBox_TV2.Location = new Point(407, 212);
			comboBox_TV2.Margin = new Padding(4, 3, 4, 3);
			comboBox_TV2.Name = "comboBox_TV2";
			comboBox_TV2.Size = new Size(380, 33);
			comboBox_TV2.TabIndex = 4;
			// 
			// comboBox_TV1
			// 
			comboBox_TV1.AutoCompleteMode = AutoCompleteMode.Append;
			comboBox_TV1.AutoCompleteSource = AutoCompleteSource.ListItems;
			comboBox_TV1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox_TV1.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comboBox_TV1.FormattingEnabled = true;
			comboBox_TV1.Items.AddRange(new object[] { "APARTIR DE", "DE", "POR", "APENAS" });
			comboBox_TV1.Location = new Point(7, 212);
			comboBox_TV1.Margin = new Padding(4, 3, 4, 3);
			comboBox_TV1.Name = "comboBox_TV1";
			comboBox_TV1.Size = new Size(380, 33);
			comboBox_TV1.TabIndex = 3;
			// 
			// textBox_V2
			// 
			textBox_V2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_V2.CharacterCasing = CharacterCasing.Upper;
			textBox_V2.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_V2.Location = new Point(407, 123);
			textBox_V2.Margin = new Padding(4, 3, 4, 3);
			textBox_V2.Name = "textBox_V2";
			textBox_V2.Size = new Size(380, 33);
			textBox_V2.TabIndex = 2;
			textBox_V2.KeyPress += textBox_V1_KeyPress;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(407, 95);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(93, 25);
			label2.TabIndex = 16;
			label2.Text = "VALOR 2:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(407, 184);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(117, 25);
			label5.TabIndex = 16;
			label5.Text = "LEGENDA 1:";
			// 
			// textBox_V1
			// 
			textBox_V1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_V1.CharacterCasing = CharacterCasing.Upper;
			textBox_V1.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_V1.Location = new Point(7, 123);
			textBox_V1.Margin = new Padding(4, 3, 4, 3);
			textBox_V1.Name = "textBox_V1";
			textBox_V1.Size = new Size(380, 33);
			textBox_V1.TabIndex = 1;
			textBox_V1.KeyPress += textBox_V1_KeyPress;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(7, 184);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(117, 25);
			label4.TabIndex = 16;
			label4.Text = "LEGENDA 1:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(7, 95);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(93, 25);
			label1.TabIndex = 16;
			label1.Text = "VALOR 1:";
			// 
			// ImputTagPromocao
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 327);
			Controls.Add(groupBox1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ImputTagPromocao";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_send).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label label3;
		private TextBox textBox_busca;
		private GroupBox groupBox1;
		private TextBox textBox_V1;
		private Label label1;
		private TextBox textBox_V2;
		private Label label2;
		private ComboBox comboBox_TV1;
		private Label label4;
		private ComboBox comboBox_TV2;
		private Label label5;
		private eControl.ePictureBox ePictureBox_send;
	}
}