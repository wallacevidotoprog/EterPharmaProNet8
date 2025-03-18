namespace EterPharmaPro.Utils.Extencions
{
	partial class GetAddress
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
			ePictureBox_save = new EterPharmaPro.Utils.eControl.ePictureBox();
			label3 = new Label();
			textBox_cep = new TextBox();
			groupBox1 = new GroupBox();
			comboBox_uf = new ComboBox();
			ePictureBox_search = new EterPharmaPro.Utils.eControl.ePictureBox();
			comboBox_cidade = new ComboBox();
			comboBox_bairro = new ComboBox();
			label5 = new Label();
			comboBox_logadouro = new ComboBox();
			label2 = new Label();
			label1 = new Label();
			label4 = new Label();
			textBox_number = new TextBox();
			textBox_obs = new TextBox();
			label7 = new Label();
			label6 = new Label();
			((System.ComponentModel.ISupportInitialize)ePictureBox_save).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_search).BeginInit();
			SuspendLayout();
			// 
			// ePictureBox_save
			// 
			ePictureBox_save.Image = Properties.Resources.salve;
			ePictureBox_save.Location = new Point(775, 367);
			ePictureBox_save.Name = "ePictureBox_save";
			ePictureBox_save.Size = new Size(60, 60);
			ePictureBox_save.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_save.TabIndex = 0;
			ePictureBox_save.TabStop = false;
			ePictureBox_save.ToolTipText = null;
			ePictureBox_save.Click += ePictureBox_save_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(7, 30);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(49, 25);
			label3.TabIndex = 16;
			label3.Text = "CEP:";
			// 
			// textBox_cep
			// 
			textBox_cep.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_cep.CharacterCasing = CharacterCasing.Upper;
			textBox_cep.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_cep.Location = new Point(7, 58);
			textBox_cep.Margin = new Padding(4, 3, 4, 3);
			textBox_cep.Name = "textBox_cep";
			textBox_cep.Size = new Size(385, 33);
			textBox_cep.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(comboBox_uf);
			groupBox1.Controls.Add(ePictureBox_search);
			groupBox1.Controls.Add(comboBox_cidade);
			groupBox1.Controls.Add(comboBox_bairro);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(comboBox_logadouro);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(textBox_number);
			groupBox1.Controls.Add(textBox_obs);
			groupBox1.Controls.Add(textBox_cep);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label3);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(757, 415);
			groupBox1.TabIndex = 17;
			groupBox1.TabStop = false;
			groupBox1.Text = "Endereço";
			// 
			// comboBox_uf
			// 
			comboBox_uf.Font = new Font("Microsoft Tai Le", 15F);
			comboBox_uf.FormattingEnabled = true;
			comboBox_uf.Location = new Point(650, 274);
			comboBox_uf.Name = "comboBox_uf";
			comboBox_uf.Size = new Size(100, 33);
			comboBox_uf.TabIndex = 5;
			// 
			// ePictureBox_search
			// 
			ePictureBox_search.Cursor = Cursors.Hand;
			ePictureBox_search.Image = Properties.Resources.www;
			ePictureBox_search.Location = new Point(399, 43);
			ePictureBox_search.Name = "ePictureBox_search";
			ePictureBox_search.Size = new Size(64, 64);
			ePictureBox_search.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_search.TabIndex = 0;
			ePictureBox_search.TabStop = false;
			ePictureBox_search.ToolTipText = null;
			ePictureBox_search.Click += ePictureBox_default_ClickAsync;
			// 
			// comboBox_cidade
			// 
			comboBox_cidade.Font = new Font("Microsoft Tai Le", 15F);
			comboBox_cidade.FormattingEnabled = true;
			comboBox_cidade.Location = new Point(7, 274);
			comboBox_cidade.Name = "comboBox_cidade";
			comboBox_cidade.Size = new Size(637, 33);
			comboBox_cidade.TabIndex = 4;
			// 
			// comboBox_bairro
			// 
			comboBox_bairro.Font = new Font("Microsoft Tai Le", 15F);
			comboBox_bairro.FormattingEnabled = true;
			comboBox_bairro.Location = new Point(7, 210);
			comboBox_bairro.Name = "comboBox_bairro";
			comboBox_bairro.Size = new Size(743, 33);
			comboBox_bairro.TabIndex = 3;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(7, 246);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(84, 25);
			label5.TabIndex = 16;
			label5.Text = "CIDADE:";
			// 
			// comboBox_logadouro
			// 
			comboBox_logadouro.Font = new Font("Microsoft Tai Le", 15F);
			comboBox_logadouro.FormattingEnabled = true;
			comboBox_logadouro.Location = new Point(7, 144);
			comboBox_logadouro.Name = "comboBox_logadouro";
			comboBox_logadouro.Size = new Size(636, 33);
			comboBox_logadouro.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(7, 188);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(84, 25);
			label2.TabIndex = 16;
			label2.Text = "BAIRRO:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(7, 116);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(137, 25);
			label1.TabIndex = 16;
			label1.Text = "LOGADOURO:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(650, 246);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(40, 25);
			label4.TabIndex = 16;
			label4.Text = "UF:";
			// 
			// textBox_number
			// 
			textBox_number.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_number.CharacterCasing = CharacterCasing.Upper;
			textBox_number.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_number.Location = new Point(650, 144);
			textBox_number.Margin = new Padding(4, 3, 4, 3);
			textBox_number.Name = "textBox_number";
			textBox_number.Size = new Size(100, 33);
			textBox_number.TabIndex = 2;
			// 
			// textBox_obs
			// 
			textBox_obs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_obs.CharacterCasing = CharacterCasing.Upper;
			textBox_obs.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox_obs.Location = new Point(7, 349);
			textBox_obs.Margin = new Padding(4, 3, 4, 3);
			textBox_obs.Multiline = true;
			textBox_obs.Name = "textBox_obs";
			textBox_obs.Size = new Size(743, 60);
			textBox_obs.TabIndex = 6;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.Location = new Point(7, 321);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(140, 25);
			label7.TabIndex = 16;
			label7.Text = "OBSERVAÇÃO:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.Location = new Point(650, 116);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(100, 25);
			label6.TabIndex = 16;
			label6.Text = "NÚMERO:";
			// 
			// GetAddress
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(842, 433);
			Controls.Add(groupBox1);
			Controls.Add(ePictureBox_save);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "GetAddress";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "BUSCA DE ENDEREÇO";
			((System.ComponentModel.ISupportInitialize)ePictureBox_save).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_search).EndInit();
			ResumeLayout(false);

		}

		#endregion
		private eControl.ePictureBox ePictureBox_save;
		private Label label3;
		private TextBox textBox_cep;
		private GroupBox groupBox1;
		private Label label2;
		private Label label1;
		private  ComboBox comboBox_logadouro;
		private  ComboBox comboBox_bairro;
		private Label label4;
		private  ComboBox comboBox_cidade;
		private Label label5;
		private  ComboBox comboBox_uf;
		private  TextBox textBox_number;
		private Label label6;
		private eControl.ePictureBox ePictureBox_search;
		private  TextBox textBox_obs;
		private Label label7;
	}
}