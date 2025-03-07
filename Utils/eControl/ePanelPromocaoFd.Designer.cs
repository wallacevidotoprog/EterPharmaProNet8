namespace EterPharmaPro.Utils.eControl
{
	partial class ePanelPromocaoControl
	{
		/// <summary> 
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Designer de Componentes

		/// <summary> 
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			ePictureBox_delete = new ePictureBox();
			textBox_TV2 = new TextBox();
			ePictureBox_update = new ePictureBox();
			textBox_V2 = new TextBox();
			textBox_TV1 = new TextBox();
			textBox_V1 = new TextBox();
			textBox_name = new TextBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_delete).BeginInit();
			((System.ComponentModel.ISupportInitialize)ePictureBox_update).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(ePictureBox_delete);
			panel1.Controls.Add(textBox_TV2);
			panel1.Controls.Add(ePictureBox_update);
			panel1.Controls.Add(textBox_V2);
			panel1.Controls.Add(textBox_TV1);
			panel1.Controls.Add(textBox_V1);
			panel1.Controls.Add(textBox_name);
			panel1.Location = new Point(2, 1);
			panel1.Name = "panel1";
			panel1.Size = new Size(469, 97);
			panel1.TabIndex = 0;
			// 
			// ePictureBox_delete
			// 
			ePictureBox_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			ePictureBox_delete.Image = Properties.Resources.arquivo__;
			ePictureBox_delete.Location = new Point(424, 52);
			ePictureBox_delete.Name = "ePictureBox_delete";
			ePictureBox_delete.Size = new Size(40, 40);
			ePictureBox_delete.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_delete.TabIndex = 1;
			ePictureBox_delete.TabStop = false;
			ePictureBox_delete.ToolTipText = "Deletar";
			// 
			// textBox_TV2
			// 
			textBox_TV2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			textBox_TV2.Location = new Point(213, 61);
			textBox_TV2.Name = "textBox_TV2";
			textBox_TV2.ReadOnly = true;
			textBox_TV2.Size = new Size(200, 23);
			textBox_TV2.TabIndex = 1;
			textBox_TV2.TextAlign = HorizontalAlignment.Center;
			// 
			// ePictureBox_update
			// 
			ePictureBox_update.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			ePictureBox_update.Image = Properties.Resources.arquivo_update;
			ePictureBox_update.Location = new Point(424, 1);
			ePictureBox_update.Name = "ePictureBox_update";
			ePictureBox_update.Size = new Size(40, 40);
			ePictureBox_update.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_update.TabIndex = 1;
			ePictureBox_update.TabStop = false;
			ePictureBox_update.ToolTipText = "Modificar";
			// 
			// textBox_V2
			// 
			textBox_V2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			textBox_V2.Location = new Point(213, 32);
			textBox_V2.Name = "textBox_V2";
			textBox_V2.ReadOnly = true;
			textBox_V2.Size = new Size(200, 23);
			textBox_V2.TabIndex = 1;
			textBox_V2.TextAlign = HorizontalAlignment.Center;
			// 
			// textBox_TV1
			// 
			textBox_TV1.Location = new Point(3, 61);
			textBox_TV1.Name = "textBox_TV1";
			textBox_TV1.ReadOnly = true;
			textBox_TV1.Size = new Size(200, 23);
			textBox_TV1.TabIndex = 1;
			textBox_TV1.TextAlign = HorizontalAlignment.Center;
			// 
			// textBox_V1
			// 
			textBox_V1.Location = new Point(3, 32);
			textBox_V1.Name = "textBox_V1";
			textBox_V1.ReadOnly = true;
			textBox_V1.Size = new Size(200, 23);
			textBox_V1.TabIndex = 1;
			textBox_V1.TextAlign = HorizontalAlignment.Center;
			// 
			// textBox_name
			// 
			textBox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox_name.Location = new Point(3, 3);
			textBox_name.Name = "textBox_name";
			textBox_name.ReadOnly = true;
			textBox_name.Size = new Size(410, 23);
			textBox_name.TabIndex = 0;
			textBox_name.TextAlign = HorizontalAlignment.Center;
			// 
			// ePanelPromocaoFd
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel1);
			Name = "ePanelPromocaoFd";
			Size = new Size(474, 100);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_delete).EndInit();
			((System.ComponentModel.ISupportInitialize)ePictureBox_update).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private TextBox textBox_name;
		private TextBox textBox_V1;
		private TextBox textBox_TV2;
		private TextBox textBox_V2;
		private TextBox textBox_TV1;
		private ePictureBox ePictureBox_update;
		private ePictureBox ePictureBox_delete;
	}
}
