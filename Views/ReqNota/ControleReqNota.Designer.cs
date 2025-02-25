﻿namespace EterPharmaPro.Views.ReqNota
{
	partial class ControleReqNota
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
			this.toolStrip_topMenu = new System.Windows.Forms.ToolStrip();
			this.toolStripButton_send = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_new_save = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_cancel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.groupBox_addReq = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView_reqs = new System.Windows.Forms.DataGridView();
			this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.ePictureBox_addR = new EterPharmaPro.Utils.eControl.ePictureBox();
			this.textBox_req = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox_vend = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox_user_red = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker_data = new System.Windows.Forms.DateTimePicker();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePicker_dataEnvio = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePicker_dataVenda = new System.Windows.Forms.DateTimePicker();
			this.dataGridView_resqDb = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REDIGENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VENDEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DATAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DATAE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REQS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.toolStrip_topMenu.SuspendLayout();
			this.groupBox_addReq.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_reqs)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ePictureBox_addR)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_resqDb)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip_topMenu
			// 
			this.toolStrip_topMenu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.toolStrip_topMenu.Dock = System.Windows.Forms.DockStyle.Right;
			this.toolStrip_topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_send,
            this.toolStripButton_new_save,
            this.toolStripButton_cancel,
            this.toolStripSeparator1});
			this.toolStrip_topMenu.Location = new System.Drawing.Point(978, 0);
			this.toolStrip_topMenu.Name = "toolStrip_topMenu";
			this.toolStrip_topMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip_topMenu.Size = new System.Drawing.Size(91, 839);
			this.toolStrip_topMenu.TabIndex = 8;
			this.toolStrip_topMenu.Text = "toolStrip1";
			// 
			// toolStripButton_send
			// 
			this.toolStripButton_send.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButton_send.AutoSize = false;
			this.toolStripButton_send.Font = new System.Drawing.Font("Segoe UI", 7F);
			this.toolStripButton_send.Image = global::EterPharmaPro.Properties.Resources.inserir;
			this.toolStripButton_send.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolStripButton_send.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton_send.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_send.Name = "toolStripButton_send";
			this.toolStripButton_send.Size = new System.Drawing.Size(90, 90);
			this.toolStripButton_send.Tag = "";
			this.toolStripButton_send.Text = "ENVIAR";
			this.toolStripButton_send.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolStripButton_send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolStripButton_send.ToolTipText = "Marcar como enviado";
			this.toolStripButton_send.Click += new System.EventHandler(this.toolStripButton_send_Click);
			// 
			// toolStripButton_new_save
			// 
			this.toolStripButton_new_save.AutoSize = false;
			this.toolStripButton_new_save.Font = new System.Drawing.Font("Segoe UI", 7F);
			this.toolStripButton_new_save.Image = global::EterPharmaPro.Properties.Resources.documento_new;
			this.toolStripButton_new_save.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolStripButton_new_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton_new_save.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_new_save.Name = "toolStripButton_new_save";
			this.toolStripButton_new_save.Size = new System.Drawing.Size(90, 90);
			this.toolStripButton_new_save.Tag = "";
			this.toolStripButton_new_save.Text = "NOVO";
			this.toolStripButton_new_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolStripButton_new_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolStripButton_new_save.ToolTipText = " ";
			this.toolStripButton_new_save.Click += new System.EventHandler(this.toolStripButton_new_save_Click);
			// 
			// toolStripButton_cancel
			// 
			this.toolStripButton_cancel.AutoSize = false;
			this.toolStripButton_cancel.Font = new System.Drawing.Font("Segoe UI", 7F);
			this.toolStripButton_cancel.Image = global::EterPharmaPro.Properties.Resources.cancelar;
			this.toolStripButton_cancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolStripButton_cancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton_cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_cancel.Name = "toolStripButton_cancel";
			this.toolStripButton_cancel.Size = new System.Drawing.Size(90, 90);
			this.toolStripButton_cancel.Tag = "";
			this.toolStripButton_cancel.Text = "CANCELAR";
			this.toolStripButton_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolStripButton_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolStripButton_cancel.ToolTipText = "Cancelar";
			this.toolStripButton_cancel.Visible = false;
			this.toolStripButton_cancel.Click += new System.EventHandler(this.toolStripButton_cancel_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(88, 6);
			// 
			// groupBox_addReq
			// 
			this.groupBox_addReq.Controls.Add(this.groupBox2);
			this.groupBox_addReq.Controls.Add(this.comboBox_vend);
			this.groupBox_addReq.Controls.Add(this.label3);
			this.groupBox_addReq.Controls.Add(this.label1);
			this.groupBox_addReq.Controls.Add(this.comboBox_user_red);
			this.groupBox_addReq.Controls.Add(this.label2);
			this.groupBox_addReq.Controls.Add(this.dateTimePicker_data);
			this.groupBox_addReq.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox_addReq.Location = new System.Drawing.Point(0, 0);
			this.groupBox_addReq.Name = "groupBox_addReq";
			this.groupBox_addReq.Size = new System.Drawing.Size(978, 364);
			this.groupBox_addReq.TabIndex = 9;
			this.groupBox_addReq.TabStop = false;
			this.groupBox_addReq.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.dataGridView_reqs);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Location = new System.Drawing.Point(6, 90);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(966, 268);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			// 
			// dataGridView_reqs
			// 
			this.dataGridView_reqs.AllowUserToAddRows = false;
			this.dataGridView_reqs.AllowUserToDeleteRows = false;
			this.dataGridView_reqs.AllowUserToResizeColumns = false;
			this.dataGridView_reqs.AllowUserToResizeRows = false;
			this.dataGridView_reqs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_reqs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView_reqs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView_reqs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView_reqs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this.dataGridViewTextBoxColumn2});
			this.dataGridView_reqs.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView_reqs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_reqs.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView_reqs.Location = new System.Drawing.Point(3, 112);
			this.dataGridView_reqs.MultiSelect = false;
			this.dataGridView_reqs.Name = "dataGridView_reqs";
			this.dataGridView_reqs.ReadOnly = true;
			this.dataGridView_reqs.RowHeadersVisible = false;
			this.dataGridView_reqs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView_reqs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_reqs.Size = new System.Drawing.Size(960, 153);
			this.dataGridView_reqs.TabIndex = 7;
			this.dataGridView_reqs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_reqs_KeyDown);
			// 
			// _id
			// 
			this._id.FillWeight = 20F;
			this._id.HeaderText = "ID";
			this._id.Name = "_id";
			this._id.ReadOnly = true;
			this._id.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
			this.dataGridViewTextBoxColumn2.FillWeight = 200F;
			this.dataGridViewTextBoxColumn2.HeaderText = "REQUISIÇÃO";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.ePictureBox_addR);
			this.groupBox3.Controls.Add(this.textBox_req);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Location = new System.Drawing.Point(3, 16);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(960, 96);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			// 
			// ePictureBox_addR
			// 
			this.ePictureBox_addR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ePictureBox_addR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ePictureBox_addR.Image = global::EterPharmaPro.Properties.Resources.arquivo__1_;
			this.ePictureBox_addR.Location = new System.Drawing.Point(887, 20);
			this.ePictureBox_addR.Name = "ePictureBox_addR";
			this.ePictureBox_addR.Size = new System.Drawing.Size(70, 70);
			this.ePictureBox_addR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ePictureBox_addR.TabIndex = 7;
			this.ePictureBox_addR.TabStop = false;
			this.ePictureBox_addR.ToolTipText = "Adicionar";
			this.ePictureBox_addR.Click += new System.EventHandler(this.ePictureBox_addR_Click);
			// 
			// textBox_req
			// 
			this.textBox_req.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_req.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox_req.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_req.ForeColor = System.Drawing.SystemColors.InfoText;
			this.textBox_req.Location = new System.Drawing.Point(6, 44);
			this.textBox_req.Name = "textBox_req";
			this.textBox_req.Size = new System.Drawing.Size(872, 33);
			this.textBox_req.TabIndex = 1;
			this.textBox_req.Text = "ADAS A";
			this.textBox_req.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_req_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "REQUISIÇÃO:";
			// 
			// comboBox_vend
			// 
			this.comboBox_vend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.comboBox_vend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBox_vend.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_vend.FormattingEnabled = true;
			this.comboBox_vend.Location = new System.Drawing.Point(269, 51);
			this.comboBox_vend.Name = "comboBox_vend";
			this.comboBox_vend.Size = new System.Drawing.Size(257, 33);
			this.comboBox_vend.TabIndex = 4;
			this.comboBox_vend.Text = " ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(527, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(167, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "DATA DA VENDA:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(267, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "VENDEDOR(A):";
			// 
			// comboBox_user_red
			// 
			this.comboBox_user_red.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.comboBox_user_red.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBox_user_red.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_user_red.FormattingEnabled = true;
			this.comboBox_user_red.Location = new System.Drawing.Point(6, 51);
			this.comboBox_user_red.Name = "comboBox_user_red";
			this.comboBox_user_red.Size = new System.Drawing.Size(257, 33);
			this.comboBox_user_red.TabIndex = 4;
			this.comboBox_user_red.Text = " ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "REDIGENTE:";
			// 
			// dateTimePicker_data
			// 
			this.dateTimePicker_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker_data.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker_data.Location = new System.Drawing.Point(532, 51);
			this.dateTimePicker_data.Name = "dateTimePicker_data";
			this.dateTimePicker_data.Size = new System.Drawing.Size(440, 33);
			this.dateTimePicker_data.TabIndex = 5;
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "ACTION";
			this.dataGridViewCheckBoxColumn1.FillWeight = 30F;
			this.dataGridViewCheckBoxColumn1.HeaderText = "";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn1.Width = 49;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.dateTimePicker_dataEnvio);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.dateTimePicker_dataVenda);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox4.Location = new System.Drawing.Point(3, 16);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(972, 63);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(516, 23);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(266, 25);
			this.label6.TabIndex = 10;
			this.label6.Text = "BUSCA POR DATA DE ENVIO:";
			// 
			// dateTimePicker_dataEnvio
			// 
			this.dateTimePicker_dataEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker_dataEnvio.CustomFormat = "MMMM/yyyy";
			this.dateTimePicker_dataEnvio.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker_dataEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_dataEnvio.Location = new System.Drawing.Point(788, 17);
			this.dateTimePicker_dataEnvio.Name = "dateTimePicker_dataEnvio";
			this.dateTimePicker_dataEnvio.Size = new System.Drawing.Size(181, 33);
			this.dateTimePicker_dataEnvio.TabIndex = 9;
			this.dateTimePicker_dataEnvio.ValueChanged += new System.EventHandler(this.dateTimePicker_dataEnvio_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(273, 25);
			this.label5.TabIndex = 8;
			this.label5.Text = "BUSCA POR DATA DE VENDA:";
			// 
			// dateTimePicker_dataVenda
			// 
			this.dateTimePicker_dataVenda.CustomFormat = "MMMM/yyyy";
			this.dateTimePicker_dataVenda.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker_dataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_dataVenda.Location = new System.Drawing.Point(285, 19);
			this.dateTimePicker_dataVenda.Name = "dateTimePicker_dataVenda";
			this.dateTimePicker_dataVenda.Size = new System.Drawing.Size(181, 33);
			this.dateTimePicker_dataVenda.TabIndex = 7;
			this.dateTimePicker_dataVenda.ValueChanged += new System.EventHandler(this.dateTimePicker_dataVenda_ValueChanged);
			// 
			// dataGridView_resqDb
			// 
			this.dataGridView_resqDb.AllowUserToAddRows = false;
			this.dataGridView_resqDb.AllowUserToDeleteRows = false;
			this.dataGridView_resqDb.AllowUserToResizeColumns = false;
			this.dataGridView_resqDb.AllowUserToResizeRows = false;
			this.dataGridView_resqDb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_resqDb.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView_resqDb.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView_resqDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView_resqDb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.REDIGENTE,
            this.VENDEDOR,
            this.DATAV,
            this.DATAE,
            this.REQS,
            this.Column1});
			this.dataGridView_resqDb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView_resqDb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_resqDb.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView_resqDb.Location = new System.Drawing.Point(3, 79);
			this.dataGridView_resqDb.MultiSelect = false;
			this.dataGridView_resqDb.Name = "dataGridView_resqDb";
			this.dataGridView_resqDb.ReadOnly = true;
			this.dataGridView_resqDb.RowHeadersVisible = false;
			this.dataGridView_resqDb.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView_resqDb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_resqDb.Size = new System.Drawing.Size(972, 393);
			this.dataGridView_resqDb.TabIndex = 12;
			this.dataGridView_resqDb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_resqDb_CellContentClick);
			this.dataGridView_resqDb.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_resqDb_CellDoubleClick);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.FillWeight = 50F;
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// REDIGENTE
			// 
			this.REDIGENTE.DataPropertyName = "REDIGENTE";
			this.REDIGENTE.FillWeight = 85.27919F;
			this.REDIGENTE.HeaderText = "REDIGENTE";
			this.REDIGENTE.Name = "REDIGENTE";
			this.REDIGENTE.ReadOnly = true;
			// 
			// VENDEDOR
			// 
			this.VENDEDOR.DataPropertyName = "VENDEDOR";
			this.VENDEDOR.FillWeight = 85.27919F;
			this.VENDEDOR.HeaderText = "VENDEDOR(A)";
			this.VENDEDOR.Name = "VENDEDOR";
			this.VENDEDOR.ReadOnly = true;
			// 
			// DATAV
			// 
			this.DATAV.DataPropertyName = "DATAV";
			this.DATAV.FillWeight = 85.27919F;
			this.DATAV.HeaderText = "DATA VENDA";
			this.DATAV.Name = "DATAV";
			this.DATAV.ReadOnly = true;
			// 
			// DATAE
			// 
			this.DATAE.DataPropertyName = "DATAE";
			this.DATAE.FillWeight = 85.27919F;
			this.DATAE.HeaderText = "DATA ENVIO";
			this.DATAE.Name = "DATAE";
			this.DATAE.ReadOnly = true;
			// 
			// REQS
			// 
			this.REQS.DataPropertyName = "REQS";
			this.REQS.FillWeight = 170.5584F;
			this.REQS.HeaderText = "REQUISIÇÕES";
			this.REQS.Name = "REQS";
			this.REQS.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "ACTION";
			this.Column1.FillWeight = 30F;
			this.Column1.HeaderText = "";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView_resqDb);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 364);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(978, 475);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// ControleReqNota
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 839);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox_addReq);
			this.Controls.Add(this.toolStrip_topMenu);
			this.Name = "ControleReqNota";
			this.Text = "ControleReqNota";
			this.Load += new System.EventHandler(this.ControleReqNota_LoadAsync);
			this.toolStrip_topMenu.ResumeLayout(false);
			this.toolStrip_topMenu.PerformLayout();
			this.groupBox_addReq.ResumeLayout(false);
			this.groupBox_addReq.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_reqs)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ePictureBox_addR)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_resqDb)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip_topMenu;
		private System.Windows.Forms.ToolStripButton toolStripButton_send;
		private System.Windows.Forms.GroupBox groupBox_addReq;
		private System.Windows.Forms.ComboBox comboBox_user_red;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker_data;
		private System.Windows.Forms.ComboBox comboBox_vend;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStripButton toolStripButton_cancel;
		private System.Windows.Forms.ToolStripButton toolStripButton_new_save;
		private System.Windows.Forms.DataGridView dataGridView_reqs;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox_req;
		private System.Windows.Forms.Label label4;
		private Utils.eControl.ePictureBox ePictureBox_addR;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.DataGridViewTextBoxColumn _id;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker_dataEnvio;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePicker_dataVenda;
		private System.Windows.Forms.DataGridView dataGridView_resqDb;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn REDIGENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn VENDEDOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn DATAV;
		private System.Windows.Forms.DataGridViewTextBoxColumn DATAE;
		private System.Windows.Forms.DataGridViewTextBoxColumn REQS;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}