namespace EterPharmaPro
{
	partial class MainWindow
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

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			toolStrip_menu = new ToolStrip();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripButton_manipulacao = new ToolStripDropDownButton();
			fORMUToolStripMenuItem = new ToolStripMenuItem();
			rELATÓRIOToolStripMenuItem1 = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			toolStripButton1 = new ToolStripDropDownButton();
			gERARVALIDADEDOMÊSToolStripMenuItem = new ToolStripMenuItem();
			rELATÓRIOToolStripMenuItem = new ToolStripMenuItem();
			toolStripButton_conf = new ToolStripButton();
			toolStripSeparator3 = new ToolStripSeparator();
			toolStripDropDownButton_impressos = new ToolStripButton();
			toolStripButton_delivery = new ToolStripButton();
			statusStrip_notify = new StatusStrip();
			toolStripProgressBar_status = new ToolStripProgressBar();
			panel_center = new Panel();
			toolStrip_menu.SuspendLayout();
			statusStrip_notify.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip_menu
			// 
			toolStrip_menu.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripButton_manipulacao, toolStripSeparator2, toolStripButton1, toolStripButton_conf, toolStripSeparator3, toolStripDropDownButton_impressos, toolStripButton_delivery });
			toolStrip_menu.Location = new Point(0, 0);
			toolStrip_menu.Name = "toolStrip_menu";
			toolStrip_menu.RenderMode = ToolStripRenderMode.Professional;
			toolStrip_menu.Size = new Size(1105, 93);
			toolStrip_menu.TabIndex = 3;
			toolStrip_menu.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 93);
			// 
			// toolStripButton_manipulacao
			// 
			toolStripButton_manipulacao.AutoSize = false;
			toolStripButton_manipulacao.DropDownItems.AddRange(new ToolStripItem[] { fORMUToolStripMenuItem, rELATÓRIOToolStripMenuItem1 });
			toolStripButton_manipulacao.Font = new Font("Segoe UI", 8F);
			toolStripButton_manipulacao.Image = Properties.Resources.farmaceutico;
			toolStripButton_manipulacao.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton_manipulacao.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton_manipulacao.ImageTransparentColor = Color.Magenta;
			toolStripButton_manipulacao.Name = "toolStripButton_manipulacao";
			toolStripButton_manipulacao.Size = new Size(90, 90);
			toolStripButton_manipulacao.Tag = "MANIPULAÇÃO";
			toolStripButton_manipulacao.Text = "MANIPULAÇÃO";
			toolStripButton_manipulacao.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_manipulacao.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_manipulacao.ToolTipText = "MANIPULAÇÃO";
			// 
			// fORMUToolStripMenuItem
			// 
			fORMUToolStripMenuItem.Image = Properties.Resources.seta_direita;
			fORMUToolStripMenuItem.Name = "fORMUToolStripMenuItem";
			fORMUToolStripMenuItem.Size = new Size(145, 22);
			fORMUToolStripMenuItem.Text = "FORMULÁRIO";
			fORMUToolStripMenuItem.Click += fORMUToolStripMenuItem_Click;
			// 
			// rELATÓRIOToolStripMenuItem1
			// 
			rELATÓRIOToolStripMenuItem1.Image = Properties.Resources.seta_direita;
			rELATÓRIOToolStripMenuItem1.Name = "rELATÓRIOToolStripMenuItem1";
			rELATÓRIOToolStripMenuItem1.Size = new Size(145, 22);
			rELATÓRIOToolStripMenuItem1.Text = "RELATÓRIO";
			rELATÓRIOToolStripMenuItem1.Click += rELATÓRIOToolStripMenuItem1_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 93);
			// 
			// toolStripButton1
			// 
			toolStripButton1.AutoSize = false;
			toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { gERARVALIDADEDOMÊSToolStripMenuItem, rELATÓRIOToolStripMenuItem });
			toolStripButton1.Image = Properties.Resources.expirado;
			toolStripButton1.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(90, 90);
			toolStripButton1.Tag = "VALIDADES";
			toolStripButton1.Text = "VALIDADES";
			toolStripButton1.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton1.ToolTipText = "VALIDADES";
			// 
			// gERARVALIDADEDOMÊSToolStripMenuItem
			// 
			gERARVALIDADEDOMÊSToolStripMenuItem.Image = Properties.Resources.seta_direita;
			gERARVALIDADEDOMÊSToolStripMenuItem.Name = "gERARVALIDADEDOMÊSToolStripMenuItem";
			gERARVALIDADEDOMÊSToolStripMenuItem.Size = new Size(212, 22);
			gERARVALIDADEDOMÊSToolStripMenuItem.Text = "GERAR VALIDADE DO MÊS";
			gERARVALIDADEDOMÊSToolStripMenuItem.Click += gERARVALIDADEDOMÊSToolStripMenuItem_Click;
			// 
			// rELATÓRIOToolStripMenuItem
			// 
			rELATÓRIOToolStripMenuItem.Image = Properties.Resources.seta_direita;
			rELATÓRIOToolStripMenuItem.Name = "rELATÓRIOToolStripMenuItem";
			rELATÓRIOToolStripMenuItem.Size = new Size(212, 22);
			rELATÓRIOToolStripMenuItem.Text = "RELATÓRIO";
			rELATÓRIOToolStripMenuItem.Click += rELATÓRIOToolStripMenuItem_Click;
			// 
			// toolStripButton_conf
			// 
			toolStripButton_conf.Alignment = ToolStripItemAlignment.Right;
			toolStripButton_conf.AutoSize = false;
			toolStripButton_conf.Font = new Font("Segoe UI", 7F);
			toolStripButton_conf.Image = Properties.Resources.configuracao;
			toolStripButton_conf.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton_conf.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton_conf.ImageTransparentColor = Color.Magenta;
			toolStripButton_conf.Name = "toolStripButton_conf";
			toolStripButton_conf.Size = new Size(90, 90);
			toolStripButton_conf.Tag = "CONFIGURAÇÕES";
			toolStripButton_conf.Text = "CONFIGURAÇÕES";
			toolStripButton_conf.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_conf.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_conf.ToolTipText = "CONFIGURAÇÕES";
			toolStripButton_conf.Click += toolStripButton_conf_Click;
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(6, 93);
			// 
			// toolStripDropDownButton_impressos
			// 
			toolStripDropDownButton_impressos.AutoSize = false;
			toolStripDropDownButton_impressos.Font = new Font("Segoe UI", 8F);
			toolStripDropDownButton_impressos.Image = Properties.Resources.papel_impresso;
			toolStripDropDownButton_impressos.ImageAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_impressos.ImageScaling = ToolStripItemImageScaling.None;
			toolStripDropDownButton_impressos.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton_impressos.Name = "toolStripDropDownButton_impressos";
			toolStripDropDownButton_impressos.Size = new Size(90, 90);
			toolStripDropDownButton_impressos.Tag = "IMPRESSOS";
			toolStripDropDownButton_impressos.Text = "IMPRESSOS";
			toolStripDropDownButton_impressos.TextAlign = ContentAlignment.BottomCenter;
			toolStripDropDownButton_impressos.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripDropDownButton_impressos.ToolTipText = "IMPRESSOS";
			toolStripDropDownButton_impressos.Click += toolStripDropDownButton_impressos_Click;
			// 
			// toolStripButton_delivery
			// 
			toolStripButton_delivery.AutoSize = false;
			toolStripButton_delivery.Enabled = false;
			toolStripButton_delivery.Font = new Font("Segoe UI", 8F);
			toolStripButton_delivery.Image = Properties.Resources.bicicleta_de_entrega;
			toolStripButton_delivery.ImageAlign = ContentAlignment.BottomCenter;
			toolStripButton_delivery.ImageScaling = ToolStripItemImageScaling.None;
			toolStripButton_delivery.ImageTransparentColor = Color.Magenta;
			toolStripButton_delivery.Name = "toolStripButton_delivery";
			toolStripButton_delivery.Size = new Size(90, 90);
			toolStripButton_delivery.Tag = "";
			toolStripButton_delivery.Text = "ENTREGA";
			toolStripButton_delivery.TextAlign = ContentAlignment.BottomCenter;
			toolStripButton_delivery.TextImageRelation = TextImageRelation.ImageAboveText;
			toolStripButton_delivery.ToolTipText = "ENTREGA";
			// 
			// statusStrip_notify
			// 
			statusStrip_notify.Items.AddRange(new ToolStripItem[] { toolStripProgressBar_status });
			statusStrip_notify.Location = new Point(0, 613);
			statusStrip_notify.Name = "statusStrip_notify";
			statusStrip_notify.Padding = new Padding(1, 0, 16, 0);
			statusStrip_notify.Size = new Size(1105, 27);
			statusStrip_notify.TabIndex = 5;
			statusStrip_notify.Text = "statusStrip1";
			// 
			// toolStripProgressBar_status
			// 
			toolStripProgressBar_status.Alignment = ToolStripItemAlignment.Right;
			toolStripProgressBar_status.Name = "toolStripProgressBar_status";
			toolStripProgressBar_status.Size = new Size(117, 21);
			// 
			// panel_center
			// 
			panel_center.Dock = DockStyle.Fill;
			panel_center.Location = new Point(0, 93);
			panel_center.Margin = new Padding(4, 3, 4, 3);
			panel_center.Name = "panel_center";
			panel_center.Size = new Size(1105, 520);
			panel_center.TabIndex = 6;
			// 
			// MainWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1105, 640);
			Controls.Add(panel_center);
			Controls.Add(statusStrip_notify);
			Controls.Add(toolStrip_menu);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			Name = "MainWindow";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ETER PHARMA PRO";
			WindowState = FormWindowState.Maximized;
			Load += MainWindow_Load;
			toolStrip_menu.ResumeLayout(false);
			toolStrip_menu.PerformLayout();
			statusStrip_notify.ResumeLayout(false);
			statusStrip_notify.PerformLayout();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip_menu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripButton_manipulacao;
		private System.Windows.Forms.ToolStripMenuItem fORMUToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rELATÓRIOToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem gERARVALIDADEDOMÊSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rELATÓRIOToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton_conf;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton toolStripDropDownButton_impressos;
		private System.Windows.Forms.StatusStrip statusStrip_notify;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_status;
		private System.Windows.Forms.Panel panel_center;
		private System.Windows.Forms.ToolStripButton toolStripButton_delivery;
	}
}

