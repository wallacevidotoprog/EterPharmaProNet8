namespace EterPharmaPro.Views.IMPRESSOS
{
	partial class PromocaoTag
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
			toolStripButton_print = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripButton_clear = new ToolStripButton();
			groupBox1 = new GroupBox();
			ePictureBox_default = new EterPharmaPro.Utils.eControl.ePictureBox();
			ePictureBox_fidelidade = new EterPharmaPro.Utils.eControl.ePictureBox();
			splitContainer1 = new SplitContainer();
			groupBox = new GroupBox();
			panel1 = new Panel();
			ePictureBox_add = new EterPharmaPro.Utils.eControl.ePictureBox();
			groupBox2 = new GroupBox();
			label_LgValor2 = new Label();
			label_LgValor1 = new Label();
			label_valor2 = new Label();
			label_valor1 = new Label();
			label_nameProduct = new Label();
			pictureBox1 = new PictureBox();
			panel_listPrints = new Panel();
			toolStrip_topMenu.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_default).BeginInit();
			((System.ComponentModel.ISupportInitialize)ePictureBox_fidelidade).BeginInit();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			groupBox.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ePictureBox_add).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// toolStrip_topMenu
			// 
			toolStrip_topMenu.BackColor = Color.WhiteSmoke;
			toolStrip_topMenu.Dock = DockStyle.Right;
			toolStrip_topMenu.Items.AddRange(new ToolStripItem[] { toolStripButton_print, toolStripSeparator1, toolStripButton_clear });
			toolStrip_topMenu.Location = new Point(1293, 0);
			toolStrip_topMenu.Name = "toolStrip_topMenu";
			toolStrip_topMenu.RenderMode = ToolStripRenderMode.Professional;
			toolStrip_topMenu.Size = new Size(91, 714);
			toolStrip_topMenu.TabIndex = 11;
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
			toolStripButton_print.Tag = "";
			toolStripButton_print.Text = "IMPRIMIR";
			toolStripButton_print.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_print.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_print.ToolTipText = "Imprimir Tags de validade";
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
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(ePictureBox_default);
			groupBox1.Controls.Add(ePictureBox_fidelidade);
			groupBox1.Dock = DockStyle.Top;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1293, 114);
			groupBox1.TabIndex = 12;
			groupBox1.TabStop = false;
			// 
			// ePictureBox_default
			// 
			ePictureBox_default.Image = Properties.Resources.PromoOne;
			ePictureBox_default.Location = new Point(612, 22);
			ePictureBox_default.Name = "ePictureBox_default";
			ePictureBox_default.Size = new Size(100, 86);
			ePictureBox_default.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_default.TabIndex = 1;
			ePictureBox_default.TabStop = false;
			ePictureBox_default.ToolTipText = "Padrão Único";
			// 
			// ePictureBox_fidelidade
			// 
			ePictureBox_fidelidade.Image = Properties.Resources.PromoFd;
			ePictureBox_fidelidade.Location = new Point(506, 22);
			ePictureBox_fidelidade.Name = "ePictureBox_fidelidade";
			ePictureBox_fidelidade.Size = new Size(100, 86);
			ePictureBox_fidelidade.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_fidelidade.TabIndex = 0;
			ePictureBox_fidelidade.TabStop = false;
			ePictureBox_fidelidade.ToolTipText = "CLiente Fidelidade";
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 114);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(groupBox);
			splitContainer1.Panel1.Controls.Add(panel1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(groupBox2);
			splitContainer1.Size = new Size(1293, 600);
			splitContainer1.SplitterDistance = 430;
			splitContainer1.TabIndex = 13;
			// 
			// groupBox
			// 
			groupBox.Controls.Add(panel_listPrints);
			groupBox.Dock = DockStyle.Fill;
			groupBox.Location = new Point(0, 50);
			groupBox.Name = "groupBox";
			groupBox.Size = new Size(430, 550);
			groupBox.TabIndex = 1;
			groupBox.TabStop = false;
			groupBox.Text = "IMPRESSÕES";
			// 
			// panel1
			// 
			panel1.Controls.Add(ePictureBox_add);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(430, 50);
			panel1.TabIndex = 0;
			// 
			// ePictureBox_add
			// 
			ePictureBox_add.Dock = DockStyle.Left;
			ePictureBox_add.Image = Properties.Resources.arquivo__1_;
			ePictureBox_add.Location = new Point(0, 0);
			ePictureBox_add.Name = "ePictureBox_add";
			ePictureBox_add.Size = new Size(50, 50);
			ePictureBox_add.SizeMode = PictureBoxSizeMode.StretchImage;
			ePictureBox_add.TabIndex = 1;
			ePictureBox_add.TabStop = false;
			ePictureBox_add.ToolTipText = "Adicionar Página";
			ePictureBox_add.Click += ePictureBox_add_Click;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label_LgValor2);
			groupBox2.Controls.Add(label_LgValor1);
			groupBox2.Controls.Add(label_valor2);
			groupBox2.Controls.Add(label_valor1);
			groupBox2.Controls.Add(label_nameProduct);
			groupBox2.Controls.Add(pictureBox1);
			groupBox2.Location = new Point(3, 6);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(855, 579);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "MODELO VISUAL";
			// 
			// label_LgValor2
			// 
			label_LgValor2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label_LgValor2.AutoSize = true;
			label_LgValor2.BackColor = Color.Yellow;
			label_LgValor2.Font = new Font("Arial", 20F, FontStyle.Bold);
			label_LgValor2.Location = new Point(474, 397);
			label_LgValor2.Name = "label_LgValor2";
			label_LgValor2.Size = new Size(289, 32);
			label_LgValor2.TabIndex = 5;
			label_LgValor2.Text = "NOME DO PRODUTO";
			// 
			// label_LgValor1
			// 
			label_LgValor1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label_LgValor1.AutoSize = true;
			label_LgValor1.BackColor = Color.Yellow;
			label_LgValor1.Font = new Font("Arial", 20F, FontStyle.Bold);
			label_LgValor1.Location = new Point(73, 397);
			label_LgValor1.Name = "label_LgValor1";
			label_LgValor1.Size = new Size(289, 32);
			label_LgValor1.TabIndex = 6;
			label_LgValor1.Text = "NOME DO PRODUTO";
			// 
			// label_valor2
			// 
			label_valor2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label_valor2.AutoSize = true;
			label_valor2.BackColor = Color.Yellow;
			label_valor2.Font = new Font("Arial", 45F, FontStyle.Bold);
			label_valor2.Location = new Point(459, 327);
			label_valor2.Name = "label_valor2";
			label_valor2.Size = new Size(338, 70);
			label_valor2.TabIndex = 7;
			label_valor2.Text = "R$ 999,999";
			// 
			// label_valor1
			// 
			label_valor1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label_valor1.AutoSize = true;
			label_valor1.BackColor = Color.Yellow;
			label_valor1.Font = new Font("Arial", 45F, FontStyle.Bold);
			label_valor1.Location = new Point(52, 327);
			label_valor1.Name = "label_valor1";
			label_valor1.Size = new Size(338, 70);
			label_valor1.TabIndex = 8;
			label_valor1.Text = "R$ 999,999";
			// 
			// label_nameProduct
			// 
			label_nameProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label_nameProduct.AutoSize = true;
			label_nameProduct.BackColor = Color.Yellow;
			label_nameProduct.Font = new Font("Arial", 20F, FontStyle.Bold);
			label_nameProduct.Location = new Point(289, 217);
			label_nameProduct.Name = "label_nameProduct";
			label_nameProduct.Size = new Size(289, 32);
			label_nameProduct.TabIndex = 4;
			label_nameProduct.Text = "NOME DO PRODUTO";
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Image = Properties.Resources.PromoFd;
			pictureBox1.Location = new Point(3, 19);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(849, 557);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			// 
			// panel_listPrints
			// 
			panel_listPrints.AutoScroll = true;
			panel_listPrints.Dock = DockStyle.Fill;
			panel_listPrints.Location = new Point(3, 19);
			panel_listPrints.Name = "panel_listPrints";
			panel_listPrints.Size = new Size(424, 528);
			panel_listPrints.TabIndex = 0;
			// 
			// PromocaoTag
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1384, 714);
			Controls.Add(splitContainer1);
			Controls.Add(groupBox1);
			Controls.Add(toolStrip_topMenu);
			Name = "PromocaoTag";
			Text = "PromocaoTag";
			toolStrip_topMenu.ResumeLayout(false);
			toolStrip_topMenu.PerformLayout();
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)ePictureBox_default).EndInit();
			((System.ComponentModel.ISupportInitialize)ePictureBox_fidelidade).EndInit();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			groupBox.ResumeLayout(false);
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)ePictureBox_add).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip_topMenu;
		private ToolStripButton toolStripButton_print;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton toolStripButton_clear;
		private GroupBox groupBox1;
		private Utils.eControl.ePictureBox ePictureBox_fidelidade;
		private Utils.eControl.ePictureBox ePictureBox_default;
		private SplitContainer splitContainer1;
		private GroupBox groupBox2;
		private Label label_LgValor2;
		private Label label_LgValor1;
		private Label label_valor2;
		private Label label_valor1;
		private Label label_nameProduct;
		private PictureBox pictureBox1;
		private Panel panel1;
		private Utils.eControl.ePictureBox ePictureBox_add;
		private GroupBox groupBox;
		private Panel panel_listPrints;
	}
}