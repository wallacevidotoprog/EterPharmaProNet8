namespace EterPharmaPro.Views.IMPRESSOES
{
	partial class IMPRESSOS
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMPRESSOS));
			toolStrip_topMenu = new ToolStrip();
			toolStripButton_exit = new ToolStripButton();
			toolStripDropDownButton_carimbos = new ToolStripDropDownButton();
			toolStripMenuItem1 = new ToolStripMenuItem();
			toolStripDropDownButton_impressoes = new ToolStripDropDownButton();
			lOTEVALIDAEToolStripMenuItem = new ToolStripMenuItem();
			pROMOÇÃOToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem_remanejo = new ToolStripMenuItem();
			toolStripDropDownButton_gerencial = new ToolStripDropDownButton();
			cONTROLEDEREQNOTAToolStripMenuItem = new ToolStripMenuItem();
			panel_center = new Panel();
			toolStrip_topMenu.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip_topMenu
			// 
			toolStrip_topMenu.BackColor = Color.WhiteSmoke;
			toolStrip_topMenu.Items.AddRange(new ToolStripItem[] { toolStripButton_exit, toolStripDropDownButton_carimbos, toolStripDropDownButton_impressoes, toolStripDropDownButton_gerencial });
			toolStrip_topMenu.Location = new Point(0, 0);
			toolStrip_topMenu.Name = "toolStrip_topMenu";
			toolStrip_topMenu.RenderMode = ToolStripRenderMode.Professional;
			toolStrip_topMenu.Size = new Size(1272, 93);
			toolStrip_topMenu.TabIndex = 6;
			toolStrip_topMenu.Text = "toolStrip1";
			// 
			// toolStripButton_exit
			// 
			toolStripButton_exit.Alignment = ToolStripItemAlignment.Right;
			toolStripButton_exit.AutoSize = false;
			toolStripButton_exit.Font = new Font("Segoe UI", 7F);
			toolStripButton_exit.Image = Properties.Resources.sair__1_;
			toolStripButton_exit.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton_exit.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton_exit.ImageTransparentColor = Color.Magenta;
			toolStripButton_exit.Name = "toolStripButton_exit";
			toolStripButton_exit.Size = new Size(90, 90);
			toolStripButton_exit.Tag = "SAIR";
			toolStripButton_exit.Text = "SAIR";
			toolStripButton_exit.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_exit.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_exit.ToolTipText = "SAIR";
			toolStripButton_exit.Click += toolStripButton_exit_Click;
			// 
			// toolStripDropDownButton_carimbos
			// 
			toolStripDropDownButton_carimbos.AutoSize = false;
			toolStripDropDownButton_carimbos.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
			toolStripDropDownButton_carimbos.Font = new Font("Segoe UI", 8F);
			toolStripDropDownButton_carimbos.Image = Properties.Resources.carimboS;
			toolStripDropDownButton_carimbos.ImageAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_carimbos.ImageScaling = ToolStripItemImageScaling.None;
			toolStripDropDownButton_carimbos.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton_carimbos.Name = "toolStripDropDownButton_carimbos";
			toolStripDropDownButton_carimbos.Size = new Size(90, 90);
			toolStripDropDownButton_carimbos.Tag = "";
			toolStripDropDownButton_carimbos.Text = "CARIMBO";
			toolStripDropDownButton_carimbos.TextAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_carimbos.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripDropDownButton_carimbos.ToolTipText = "CARIMBOS";
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Image = Properties.Resources.seta_direita;
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(145, 22);
			toolStripMenuItem1.Text = "LOTE VALIDAE";
			toolStripMenuItem1.Click += lOTEVALIDAEToolStripMenuItem_Click;
			// 
			// toolStripDropDownButton_impressoes
			// 
			toolStripDropDownButton_impressoes.AutoSize = false;
			toolStripDropDownButton_impressoes.DropDownItems.AddRange(new ToolStripItem[] { lOTEVALIDAEToolStripMenuItem, pROMOÇÃOToolStripMenuItem, toolStripMenuItem_remanejo });
			toolStripDropDownButton_impressoes.Font = new Font("Segoe UI", 8F);
			toolStripDropDownButton_impressoes.Image = Properties.Resources.printer;
			toolStripDropDownButton_impressoes.ImageAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_impressoes.ImageScaling = ToolStripItemImageScaling.None;
			toolStripDropDownButton_impressoes.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton_impressoes.Name = "toolStripDropDownButton_impressoes";
			toolStripDropDownButton_impressoes.Size = new Size(90, 90);
			toolStripDropDownButton_impressoes.Tag = "";
			toolStripDropDownButton_impressoes.Text = "IMPRESSÕES";
			toolStripDropDownButton_impressoes.TextAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_impressoes.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripDropDownButton_impressoes.ToolTipText = "CARIMBOS";
			// 
			// lOTEVALIDAEToolStripMenuItem
			// 
			lOTEVALIDAEToolStripMenuItem.Image = Properties.Resources.seta_direita;
			lOTEVALIDAEToolStripMenuItem.Name = "lOTEVALIDAEToolStripMenuItem";
			lOTEVALIDAEToolStripMenuItem.Size = new Size(180, 22);
			lOTEVALIDAEToolStripMenuItem.Text = "TAG VALIDADE";
			lOTEVALIDAEToolStripMenuItem.Click += TagValidade;
			// 
			// pROMOÇÃOToolStripMenuItem
			// 
			pROMOÇÃOToolStripMenuItem.Image = Properties.Resources.seta_direita;
			pROMOÇÃOToolStripMenuItem.Name = "pROMOÇÃOToolStripMenuItem";
			pROMOÇÃOToolStripMenuItem.Size = new Size(180, 22);
			pROMOÇÃOToolStripMenuItem.Text = "PROMOÇÃO";
			pROMOÇÃOToolStripMenuItem.Click += pROMOÇÃOToolStripMenuItem_Click;
			// 
			// toolStripMenuItem_remanejo
			// 
			toolStripMenuItem_remanejo.Image = (Image)resources.GetObject("toolStripMenuItem_remanejo.Image");
			toolStripMenuItem_remanejo.Name = "toolStripMenuItem_remanejo";
			toolStripMenuItem_remanejo.Size = new Size(180, 22);
			toolStripMenuItem_remanejo.Text = "REMANEJO";
			toolStripMenuItem_remanejo.Click += toolStripMenuItem_remanejo_Click;
			// 
			// toolStripDropDownButton_gerencial
			// 
			toolStripDropDownButton_gerencial.AutoSize = false;
			toolStripDropDownButton_gerencial.DropDownItems.AddRange(new ToolStripItem[] { cONTROLEDEREQNOTAToolStripMenuItem });
			toolStripDropDownButton_gerencial.Font = new Font("Segoe UI", 8F);
			toolStripDropDownButton_gerencial.Image = Properties.Resources.gerenciamento;
			toolStripDropDownButton_gerencial.ImageAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_gerencial.ImageScaling = ToolStripItemImageScaling.None;
			toolStripDropDownButton_gerencial.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton_gerencial.Name = "toolStripDropDownButton_gerencial";
			toolStripDropDownButton_gerencial.Size = new Size(90, 90);
			toolStripDropDownButton_gerencial.Tag = "";
			toolStripDropDownButton_gerencial.Text = "GERENCIAL";
			toolStripDropDownButton_gerencial.TextAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_gerencial.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripDropDownButton_gerencial.ToolTipText = "GERENCIAL";
			// 
			// cONTROLEDEREQNOTAToolStripMenuItem
			// 
			cONTROLEDEREQNOTAToolStripMenuItem.Image = (Image)resources.GetObject("cONTROLEDEREQNOTAToolStripMenuItem.Image");
			cONTROLEDEREQNOTAToolStripMenuItem.Name = "cONTROLEDEREQNOTAToolStripMenuItem";
			cONTROLEDEREQNOTAToolStripMenuItem.Size = new Size(207, 22);
			cONTROLEDEREQNOTAToolStripMenuItem.Text = "CONTROLE DE REQ. NOTA";
			cONTROLEDEREQNOTAToolStripMenuItem.Click += cONTROLEDEREQNOTAToolStripMenuItem_Click;
			// 
			// panel_center
			// 
			panel_center.Dock = DockStyle.Fill;
			panel_center.Location = new Point(0, 93);
			panel_center.Margin = new Padding(4, 3, 4, 3);
			panel_center.Name = "panel_center";
			panel_center.Size = new Size(1272, 478);
			panel_center.TabIndex = 7;
			// 
			// IMPRESSOS
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1272, 571);
			Controls.Add(panel_center);
			Controls.Add(toolStrip_topMenu);
			Margin = new Padding(4, 3, 4, 3);
			Name = "IMPRESSOS";
			Text = "IMPRESSOS";
			Load += IMPRESSOS_Load;
			toolStrip_topMenu.ResumeLayout(false);
			toolStrip_topMenu.PerformLayout();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip_topMenu;
		private System.Windows.Forms.ToolStripButton toolStripButton_exit;
		private System.Windows.Forms.Panel panel_center;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_impressoes;
		private System.Windows.Forms.ToolStripMenuItem lOTEVALIDAEToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_gerencial;
		private System.Windows.Forms.ToolStripMenuItem cONTROLEDEREQNOTAToolStripMenuItem;
		private ToolStripDropDownButton toolStripDropDownButton_carimbos;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem pROMOÇÃOToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItem_remanejo;
	}
}