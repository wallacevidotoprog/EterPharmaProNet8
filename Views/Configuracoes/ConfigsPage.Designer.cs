namespace EterPharmaPro.Views.Configuracoes
{
	partial class ConfigsPage
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
			toolStripButton_exit = new ToolStripButton();
			toolStripDropDownButton_produto = new ToolStripButton();
			toolStripButton_user = new ToolStripButton();
			panel_center = new Panel();
			toolStripButton_configs = new ToolStripButton();
			toolStrip_topMenu.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip_topMenu
			// 
			toolStrip_topMenu.BackColor = Color.WhiteSmoke;
			toolStrip_topMenu.Items.AddRange(new ToolStripItem[] { toolStripButton_exit, toolStripDropDownButton_produto, toolStripButton_user, toolStripButton_configs });
			toolStrip_topMenu.Location = new Point(0, 0);
			toolStrip_topMenu.Name = "toolStrip_topMenu";
			toolStrip_topMenu.RenderMode = ToolStripRenderMode.Professional;
			toolStrip_topMenu.Size = new Size(1423, 93);
			toolStrip_topMenu.TabIndex = 5;
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
			// toolStripDropDownButton_produto
			// 
			toolStripDropDownButton_produto.AutoSize = false;
			toolStripDropDownButton_produto.Font = new Font("Segoe UI", 8F);
			toolStripDropDownButton_produto.Image = Properties.Resources.inventario;
			toolStripDropDownButton_produto.ImageAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_produto.ImageScaling = ToolStripItemImageScaling.None;
			toolStripDropDownButton_produto.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton_produto.Name = "toolStripDropDownButton_produto";
			toolStripDropDownButton_produto.Size = new Size(90, 90);
			toolStripDropDownButton_produto.Tag = "";
			toolStripDropDownButton_produto.Text = "PRODUTOS";
			toolStripDropDownButton_produto.TextAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_produto.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripDropDownButton_produto.ToolTipText = "PRODUTOS";
			toolStripDropDownButton_produto.Click += toolStripDropDownButton_produto_Click;
			// 
			// toolStripButton_user
			// 
			toolStripButton_user.AutoSize = false;
			toolStripButton_user.Font = new Font("Segoe UI", 8F);
			toolStripButton_user.Image = Properties.Resources.user;
			toolStripButton_user.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton_user.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton_user.ImageTransparentColor = Color.Magenta;
			toolStripButton_user.Name = "toolStripButton_user";
			toolStripButton_user.Size = new Size(90, 90);
			toolStripButton_user.Tag = "";
			toolStripButton_user.Text = "USUÁRIO";
			toolStripButton_user.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_user.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_user.ToolTipText = "USUÁRIO";
			toolStripButton_user.Click += toolStripButton_user_Click;
			// 
			// panel_center
			// 
			panel_center.Dock = DockStyle.Fill;
			panel_center.Location = new Point(0, 93);
			panel_center.Margin = new Padding(4, 3, 4, 3);
			panel_center.Name = "panel_center";
			panel_center.Size = new Size(1423, 604);
			panel_center.TabIndex = 6;
			// 
			// toolStripButton_configs
			// 
			toolStripButton_configs.AutoSize = false;
			toolStripButton_configs.Font = new Font("Segoe UI", 8F);
			toolStripButton_configs.Image = Properties.Resources.settings;
			toolStripButton_configs.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton_configs.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton_configs.ImageTransparentColor = Color.Magenta;
			toolStripButton_configs.Name = "toolStripButton_configs";
			toolStripButton_configs.Size = new Size(90, 90);
			toolStripButton_configs.Tag = "";
			toolStripButton_configs.Text = "CONFIGS";
			toolStripButton_configs.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_configs.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_configs.ToolTipText = "USUÁRIO";
			toolStripButton_configs.Click += toolStripButton_configs_Click;
			// 
			// ConfigsPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1423, 697);
			Controls.Add(panel_center);
			Controls.Add(toolStrip_topMenu);
			Margin = new Padding(4, 3, 4, 3);
			Name = "ConfigsPage";
			Text = "Configs";
			Load += ConfigsPage_Load;
			toolStrip_topMenu.ResumeLayout(false);
			toolStrip_topMenu.PerformLayout();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip_topMenu;
		private System.Windows.Forms.ToolStripButton toolStripButton_exit;
		private System.Windows.Forms.ToolStripButton toolStripDropDownButton_produto;
		private System.Windows.Forms.ToolStripButton toolStripButton_user;
		private System.Windows.Forms.Panel panel_center;
		private ToolStripButton toolStripButton_configs;
	}
}