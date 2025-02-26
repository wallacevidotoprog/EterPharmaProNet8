namespace EterPharmaPro.Views
{
	partial class AcesUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcesUser));
			comboBox_user = new ComboBox();
			groupBox1 = new GroupBox();
			panel1 = new Panel();
			ePictureBox_close = new EterPharmaPro.Utils.eControl.ePictureBox();
			ePictureBox_acess = new EterPharmaPro.Utils.eControl.ePictureBox();
			textBox_pass = new TextBox();
			groupBox_pass = new GroupBox();
			groupBox1.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_close).BeginInit();
			((System.ComponentModel.ISupportInitialize)ePictureBox_acess).BeginInit();
			groupBox_pass.SuspendLayout();
			SuspendLayout();
			// 
			// comboBox_user
			// 
			comboBox_user.AutoCompleteMode = AutoCompleteMode.Append;
			comboBox_user.AutoCompleteSource = AutoCompleteSource.ListItems;
			comboBox_user.Dock = DockStyle.Top;
			comboBox_user.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
			comboBox_user.FormattingEnabled = true;
			comboBox_user.Location = new Point(4, 19);
			comboBox_user.Margin = new Padding(4, 3, 4, 3);
			comboBox_user.Name = "comboBox_user";
			comboBox_user.Size = new Size(382, 34);
			comboBox_user.TabIndex = 1;
			comboBox_user.Text = " ";
			comboBox_user.SelectedIndexChanged += comboBox_user_SelectedIndexChanged;
			comboBox_user.KeyDown += comboBox_user_KeyDown;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Transparent;
			groupBox1.Controls.Add(panel1);
			groupBox1.Controls.Add(groupBox_pass);
			groupBox1.Controls.Add(comboBox_user);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(390, 213);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "USUÁRIO";
			// 
			// panel1
			// 
			panel1.Controls.Add(ePictureBox_close);
			panel1.Controls.Add(ePictureBox_acess);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(4, 119);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(382, 82);
			panel1.TabIndex = 3;
			// 
			// ePictureBox_close
			// 
			ePictureBox_close.Cursor = Cursors.Hand;
			ePictureBox_close.Image = Properties.Resources.cancelar;
			ePictureBox_close.Location = new Point(298, 3);
			ePictureBox_close.Margin = new Padding(4, 3, 4, 3);
			ePictureBox_close.Name = "ePictureBox_close";
			ePictureBox_close.Size = new Size(64, 64);
			ePictureBox_close.SizeMode = PictureBoxSizeMode.AutoSize;
			ePictureBox_close.TabIndex = 4;
			ePictureBox_close.TabStop = false;
			ePictureBox_close.ToolTipText = "Clique aqui para acessar com sua ID de loja";
			ePictureBox_close.Click += ePictureBox_close_Click;
			// 
			// ePictureBox_acess
			// 
			ePictureBox_acess.Cursor = Cursors.Hand;
			ePictureBox_acess.Image = Properties.Resources.acesso;
			ePictureBox_acess.Location = new Point(10, 3);
			ePictureBox_acess.Margin = new Padding(4, 3, 4, 3);
			ePictureBox_acess.Name = "ePictureBox_acess";
			ePictureBox_acess.Size = new Size(75, 74);
			ePictureBox_acess.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_acess.TabIndex = 4;
			ePictureBox_acess.TabStop = false;
			ePictureBox_acess.ToolTipText = "Clique aqui para acessar com sua ID de loja";
			ePictureBox_acess.Click += ePictureBox_acess_Click;
			// 
			// textBox_pass
			// 
			textBox_pass.CharacterCasing = CharacterCasing.Upper;
			textBox_pass.Dock = DockStyle.Top;
			textBox_pass.Font = new Font("Microsoft Tai Le", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBox_pass.Location = new Point(4, 19);
			textBox_pass.Margin = new Padding(4, 3, 4, 3);
			textBox_pass.Name = "textBox_pass";
			textBox_pass.PasswordChar = '*';
			textBox_pass.Size = new Size(374, 33);
			textBox_pass.TabIndex = 1;
			textBox_pass.KeyDown += textBox_pass_KeyDown;
			// 
			// groupBox_pass
			// 
			groupBox_pass.Controls.Add(textBox_pass);
			groupBox_pass.Dock = DockStyle.Top;
			groupBox_pass.Location = new Point(4, 53);
			groupBox_pass.Margin = new Padding(4, 3, 4, 3);
			groupBox_pass.Name = "groupBox_pass";
			groupBox_pass.Padding = new Padding(4, 3, 4, 3);
			groupBox_pass.Size = new Size(382, 66);
			groupBox_pass.TabIndex = 2;
			groupBox_pass.TabStop = false;
			groupBox_pass.Text = "SENHA";
			groupBox_pass.Visible = false;
			// 
			// AcesUser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(390, 213);
			Controls.Add(groupBox1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AcesUser";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Acesso de Usuário";
			FormClosing += AcesUser_FormClosing;
			Load += AcesUser_LoadAsync;
			groupBox1.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_close).EndInit();
			((System.ComponentModel.ISupportInitialize)ePictureBox_acess).EndInit();
			groupBox_pass.ResumeLayout(false);
			groupBox_pass.PerformLayout();
			ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox_user;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private Utils.eControl.ePictureBox ePictureBox_acess;
		private Utils.eControl.ePictureBox ePictureBox_close;
		private GroupBox groupBox_pass;
		private TextBox textBox_pass;
	}
}