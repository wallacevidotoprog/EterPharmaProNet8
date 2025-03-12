namespace EterPharmaPro.Utils.Extencions
{
	partial class SelectPrint
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
			ePictureBox_termal = new EterPharmaPro.Utils.eControl.ePictureBox();
			ePictureBox_default = new EterPharmaPro.Utils.eControl.ePictureBox();
			((System.ComponentModel.ISupportInitialize)ePictureBox_termal).BeginInit();
			((System.ComponentModel.ISupportInitialize)ePictureBox_default).BeginInit();
			SuspendLayout();
			// 
			// ePictureBox_termal
			// 
			ePictureBox_termal.Image = Properties.Resources.pngegg;
			ePictureBox_termal.Location = new Point(150, 24);
			ePictureBox_termal.Name = "ePictureBox_termal";
			ePictureBox_termal.Size = new Size(100, 100);
			ePictureBox_termal.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_termal.TabIndex = 0;
			ePictureBox_termal.TabStop = false;
			ePictureBox_termal.ToolTipText = "Impressora termica";
			ePictureBox_termal.Click += ePictureBox_termal_Click;
			// 
			// ePictureBox_default
			// 
			ePictureBox_default.Image = Properties.Resources.inkjet_printer;
			ePictureBox_default.Location = new Point(333, 24);
			ePictureBox_default.Name = "ePictureBox_default";
			ePictureBox_default.Size = new Size(100, 100);
			ePictureBox_default.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_default.TabIndex = 0;
			ePictureBox_default.TabStop = false;
			ePictureBox_default.ToolTipText = null;
			ePictureBox_default.Click += ePictureBox_default_Click;
			// 
			// SelectPrint
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(582, 136);
			Controls.Add(ePictureBox_default);
			Controls.Add(ePictureBox_termal);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SelectPrint";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SELECIONE O MODO DE IMPRESSÃO";
			((System.ComponentModel.ISupportInitialize)ePictureBox_termal).EndInit();
			((System.ComponentModel.ISupportInitialize)ePictureBox_default).EndInit();
			ResumeLayout(false);

		}

		#endregion

		private eControl.ePictureBox ePictureBox_termal;
		private eControl.ePictureBox ePictureBox_default;
	}
}