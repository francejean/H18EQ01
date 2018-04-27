namespace PrjEq01_Application.Tabs
{
	partial class UC_Chambre
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Chambre));
			this.lb_noCham = new System.Windows.Forms.Label();
			this.lb_etage = new System.Windows.Forms.Label();
			this.tb_etage = new System.Windows.Forms.TextBox();
			this.lb_etat = new System.Windows.Forms.Label();
			this.tb_etat = new System.Windows.Forms.TextBox();
			this.lb_codeType = new System.Windows.Forms.Label();
			this.lb_codeLoc = new System.Windows.Forms.Label();
			this.dgv_commodite = new System.Windows.Forms.DataGridView();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BS_AYANT = new System.Windows.Forms.BindingSource(this.components);
			this.tb_noCham = new System.Windows.Forms.TextBox();
			this.lb_prix = new System.Windows.Forms.Label();
			this.lb_descLoc = new System.Windows.Forms.Label();
			this.lb_descType = new System.Windows.Forms.Label();
			this.lb_memo = new System.Windows.Forms.Label();
			this.tb_codeLoc = new System.Windows.Forms.TextBox();
			this.tb_codeType = new System.Windows.Forms.TextBox();
			this.tb_descLoc = new System.Windows.Forms.TextBox();
			this.tb_descType = new System.Windows.Forms.TextBox();
			this.tb_memo = new System.Windows.Forms.TextBox();
			this.mtb_prix = new System.Windows.Forms.MaskedTextBox();
			this.gb_infoChambre = new System.Windows.Forms.GroupBox();
			this.bt_listCodeLoc = new PrjEq01_CommonForm.Controls.Button_List();
			this.bt_listCodeType = new PrjEq01_CommonForm.Controls.Button_List();
			this.bt_listNoChambre = new PrjEq01_CommonForm.Controls.Button_List();
			this.gb_commodite = new System.Windows.Forms.GroupBox();
			this.bt_deleteCommodite = new PrjEq01_CommonForm.Controls.Button_List();
			this.bt_listCommodite = new PrjEq01_CommonForm.Controls.Button_List();
			this.BS_CHAMBRE = new System.Windows.Forms.BindingSource(this.components);
			this.BS_COMMODITE = new System.Windows.Forms.BindingSource(this.components);
			this.BS_TYPECHAM = new System.Windows.Forms.BindingSource(this.components);
			this.BS_LOCALISATION = new System.Windows.Forms.BindingSource(this.components);
			this.BS_BK_COMMODITE = new System.Windows.Forms.BindingSource(this.components);
			this.dS_Master = new PrjEq01_Application.DS_Master();
			this.TA_CHAMBRE = new PrjEq01_Application.DS_MasterTableAdapters.CHAMBRETableAdapter();
			this.TA_COMMODITE = new PrjEq01_Application.DS_MasterTableAdapters.COMMODITETableAdapter();
			this.TA_TYPECHAM = new PrjEq01_Application.DS_MasterTableAdapters.TYPECHAMTableAdapter();
			this.TA_LOCALISATION = new PrjEq01_Application.DS_MasterTableAdapters.LOCALISATIONTableAdapter();
			this.TA_AYANT = new PrjEq01_Application.DS_MasterTableAdapters.AYANTTableAdapter();
			this.TA_BK_COMMODITE = new PrjEq01_Application.DS_MasterTableAdapters.BK_COMMODITETableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dgv_commodite)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_AYANT)).BeginInit();
			this.gb_infoChambre.SuspendLayout();
			this.gb_commodite.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_COMMODITE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_TYPECHAM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_LOCALISATION)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_BK_COMMODITE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dS_Master)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_noCham
			// 
			this.lb_noCham.AutoSize = true;
			this.lb_noCham.Location = new System.Drawing.Point(5, 27);
			this.lb_noCham.Name = "lb_noCham";
			this.lb_noCham.Size = new System.Drawing.Size(78, 17);
			this.lb_noCham.TabIndex = 0;
			this.lb_noCham.Text = "No. Cham :";
			// 
			// lb_etage
			// 
			this.lb_etage.AutoSize = true;
			this.lb_etage.Location = new System.Drawing.Point(5, 78);
			this.lb_etage.Name = "lb_etage";
			this.lb_etage.Size = new System.Drawing.Size(53, 17);
			this.lb_etage.TabIndex = 2;
			this.lb_etage.Text = "Étage :";
			// 
			// tb_etage
			// 
			this.tb_etage.Location = new System.Drawing.Point(64, 75);
			this.tb_etage.MaxLength = 2;
			this.tb_etage.Name = "tb_etage";
			this.tb_etage.ReadOnly = true;
			this.tb_etage.Size = new System.Drawing.Size(108, 22);
			this.tb_etage.TabIndex = 3;
			this.tb_etage.Validating += new System.ComponentModel.CancelEventHandler(this.tb_etage_Validating);
			// 
			// lb_etat
			// 
			this.lb_etat.AutoSize = true;
			this.lb_etat.Location = new System.Drawing.Point(5, 128);
			this.lb_etat.Name = "lb_etat";
			this.lb_etat.Size = new System.Drawing.Size(41, 17);
			this.lb_etat.TabIndex = 4;
			this.lb_etat.Text = "État :";
			// 
			// tb_etat
			// 
			this.tb_etat.Location = new System.Drawing.Point(64, 125);
			this.tb_etat.MaxLength = 1;
			this.tb_etat.Name = "tb_etat";
			this.tb_etat.ReadOnly = true;
			this.tb_etat.Size = new System.Drawing.Size(108, 22);
			this.tb_etat.TabIndex = 5;
			this.tb_etat.Validating += new System.ComponentModel.CancelEventHandler(this.tb_etat_Validating);
			// 
			// lb_codeType
			// 
			this.lb_codeType.AutoSize = true;
			this.lb_codeType.Location = new System.Drawing.Point(234, 27);
			this.lb_codeType.Name = "lb_codeType";
			this.lb_codeType.Size = new System.Drawing.Size(85, 17);
			this.lb_codeType.TabIndex = 6;
			this.lb_codeType.Text = "Code Type :";
			// 
			// lb_codeLoc
			// 
			this.lb_codeLoc.AutoSize = true;
			this.lb_codeLoc.Location = new System.Drawing.Point(234, 78);
			this.lb_codeLoc.Name = "lb_codeLoc";
			this.lb_codeLoc.Size = new System.Drawing.Size(128, 17);
			this.lb_codeLoc.TabIndex = 7;
			this.lb_codeLoc.Text = "Code Localisation :";
			// 
			// dgv_commodite
			// 
			this.dgv_commodite.AllowUserToAddRows = false;
			this.dgv_commodite.AllowUserToDeleteRows = false;
			this.dgv_commodite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_commodite.AutoGenerateColumns = false;
			this.dgv_commodite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_commodite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Description});
			this.dgv_commodite.DataSource = this.BS_AYANT;
			this.dgv_commodite.Location = new System.Drawing.Point(39, 21);
			this.dgv_commodite.Name = "dgv_commodite";
			this.dgv_commodite.ReadOnly = true;
			this.dgv_commodite.RowHeadersVisible = false;
			this.dgv_commodite.RowTemplate.Height = 24;
			this.dgv_commodite.Size = new System.Drawing.Size(925, 301);
			this.dgv_commodite.TabIndex = 8;
			this.dgv_commodite.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_commodite_RowsAdded);
			this.dgv_commodite.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_commodite_RowsRemoved);
			this.dgv_commodite.Validating += new System.ComponentModel.CancelEventHandler(this.dgv_commodite_Validating);
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "NoCham";
			this.Column2.HeaderText = "No. Cham";
			this.Column2.MinimumWidth = 50;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 99;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "CodCom";
			this.Column1.HeaderText = "CODCOM";
			this.Column1.MinimumWidth = 75;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 98;
			// 
			// Description
			// 
			this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Description.DataPropertyName = "DescCom";
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			// 
			// tb_noCham
			// 
			this.tb_noCham.Location = new System.Drawing.Point(82, 22);
			this.tb_noCham.Margin = new System.Windows.Forms.Padding(4);
			this.tb_noCham.MaxLength = 3;
			this.tb_noCham.Name = "tb_noCham";
			this.tb_noCham.ReadOnly = true;
			this.tb_noCham.Size = new System.Drawing.Size(90, 22);
			this.tb_noCham.TabIndex = 14;
			this.tb_noCham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_noCham_KeyDown);
			this.tb_noCham.Validating += new System.ComponentModel.CancelEventHandler(this.tb_noCham_Validating);
			// 
			// lb_prix
			// 
			this.lb_prix.AutoSize = true;
			this.lb_prix.Location = new System.Drawing.Point(234, 128);
			this.lb_prix.Name = "lb_prix";
			this.lb_prix.Size = new System.Drawing.Size(31, 17);
			this.lb_prix.TabIndex = 15;
			this.lb_prix.Text = "Prix";
			// 
			// lb_descLoc
			// 
			this.lb_descLoc.AutoSize = true;
			this.lb_descLoc.Location = new System.Drawing.Point(511, 78);
			this.lb_descLoc.Name = "lb_descLoc";
			this.lb_descLoc.Size = new System.Drawing.Size(87, 17);
			this.lb_descLoc.TabIndex = 16;
			this.lb_descLoc.Text = "Description :";
			// 
			// lb_descType
			// 
			this.lb_descType.AutoSize = true;
			this.lb_descType.Location = new System.Drawing.Point(511, 27);
			this.lb_descType.Name = "lb_descType";
			this.lb_descType.Size = new System.Drawing.Size(87, 17);
			this.lb_descType.TabIndex = 17;
			this.lb_descType.Text = "Description :";
			// 
			// lb_memo
			// 
			this.lb_memo.AutoSize = true;
			this.lb_memo.Location = new System.Drawing.Point(395, 128);
			this.lb_memo.Name = "lb_memo";
			this.lb_memo.Size = new System.Drawing.Size(54, 17);
			this.lb_memo.TabIndex = 18;
			this.lb_memo.Text = "Mémo :";
			// 
			// tb_codeLoc
			// 
			this.tb_codeLoc.Location = new System.Drawing.Point(368, 75);
			this.tb_codeLoc.Name = "tb_codeLoc";
			this.tb_codeLoc.ReadOnly = true;
			this.tb_codeLoc.Size = new System.Drawing.Size(91, 22);
			this.tb_codeLoc.TabIndex = 19;
			this.tb_codeLoc.Validating += new System.ComponentModel.CancelEventHandler(this.tb_codeLoc_Validating);
			// 
			// tb_codeType
			// 
			this.tb_codeType.Location = new System.Drawing.Point(325, 22);
			this.tb_codeType.Name = "tb_codeType";
			this.tb_codeType.ReadOnly = true;
			this.tb_codeType.Size = new System.Drawing.Size(134, 22);
			this.tb_codeType.TabIndex = 20;
			this.tb_codeType.Validating += new System.ComponentModel.CancelEventHandler(this.tb_codeType_Validating);
			// 
			// tb_descLoc
			// 
			this.tb_descLoc.Location = new System.Drawing.Point(604, 73);
			this.tb_descLoc.Name = "tb_descLoc";
			this.tb_descLoc.ReadOnly = true;
			this.tb_descLoc.Size = new System.Drawing.Size(360, 22);
			this.tb_descLoc.TabIndex = 21;
			// 
			// tb_descType
			// 
			this.tb_descType.Location = new System.Drawing.Point(604, 24);
			this.tb_descType.Name = "tb_descType";
			this.tb_descType.ReadOnly = true;
			this.tb_descType.Size = new System.Drawing.Size(360, 22);
			this.tb_descType.TabIndex = 22;
			// 
			// tb_memo
			// 
			this.tb_memo.Location = new System.Drawing.Point(455, 125);
			this.tb_memo.Name = "tb_memo";
			this.tb_memo.ReadOnly = true;
			this.tb_memo.Size = new System.Drawing.Size(509, 22);
			this.tb_memo.TabIndex = 23;
			// 
			// mtb_prix
			// 
			this.mtb_prix.Location = new System.Drawing.Point(271, 125);
			this.mtb_prix.Mask = "000.00$";
			this.mtb_prix.Name = "mtb_prix";
			this.mtb_prix.ReadOnly = true;
			this.mtb_prix.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.mtb_prix.Size = new System.Drawing.Size(72, 22);
			this.mtb_prix.TabIndex = 24;
			this.mtb_prix.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.mtb_prix.TextChanged += new System.EventHandler(this.mtb_prix_TextChanged);
			this.mtb_prix.Validating += new System.ComponentModel.CancelEventHandler(this.mtb_prix_Validating);
			// 
			// gb_infoChambre
			// 
			this.gb_infoChambre.Controls.Add(this.bt_listCodeLoc);
			this.gb_infoChambre.Controls.Add(this.bt_listCodeType);
			this.gb_infoChambre.Controls.Add(this.bt_listNoChambre);
			this.gb_infoChambre.Controls.Add(this.tb_noCham);
			this.gb_infoChambre.Controls.Add(this.mtb_prix);
			this.gb_infoChambre.Controls.Add(this.lb_noCham);
			this.gb_infoChambre.Controls.Add(this.tb_memo);
			this.gb_infoChambre.Controls.Add(this.lb_etage);
			this.gb_infoChambre.Controls.Add(this.tb_descType);
			this.gb_infoChambre.Controls.Add(this.tb_etage);
			this.gb_infoChambre.Controls.Add(this.tb_descLoc);
			this.gb_infoChambre.Controls.Add(this.lb_etat);
			this.gb_infoChambre.Controls.Add(this.tb_codeType);
			this.gb_infoChambre.Controls.Add(this.tb_etat);
			this.gb_infoChambre.Controls.Add(this.tb_codeLoc);
			this.gb_infoChambre.Controls.Add(this.lb_codeType);
			this.gb_infoChambre.Controls.Add(this.lb_memo);
			this.gb_infoChambre.Controls.Add(this.lb_codeLoc);
			this.gb_infoChambre.Controls.Add(this.lb_descType);
			this.gb_infoChambre.Controls.Add(this.lb_prix);
			this.gb_infoChambre.Controls.Add(this.lb_descLoc);
			this.gb_infoChambre.Location = new System.Drawing.Point(3, 3);
			this.gb_infoChambre.Name = "gb_infoChambre";
			this.gb_infoChambre.Size = new System.Drawing.Size(985, 178);
			this.gb_infoChambre.TabIndex = 25;
			this.gb_infoChambre.TabStop = false;
			this.gb_infoChambre.Text = "Information sur la chambre";
			// 
			// bt_listCodeLoc
			// 
			this.bt_listCodeLoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_listCodeLoc.BackgroundImage")));
			this.bt_listCodeLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bt_listCodeLoc.Enabled = false;
			this.bt_listCodeLoc.Location = new System.Drawing.Point(465, 72);
			this.bt_listCodeLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_listCodeLoc.Name = "bt_listCodeLoc";
			this.bt_listCodeLoc.Size = new System.Drawing.Size(27, 25);
			this.bt_listCodeLoc.TabIndex = 27;
			this.bt_listCodeLoc.UseVisualStyleBackColor = true;
			this.bt_listCodeLoc.Click += new System.EventHandler(this.bt_listCodeLoc_Click);
			// 
			// bt_listCodeType
			// 
			this.bt_listCodeType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_listCodeType.BackgroundImage")));
			this.bt_listCodeType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bt_listCodeType.Enabled = false;
			this.bt_listCodeType.Location = new System.Drawing.Point(465, 19);
			this.bt_listCodeType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_listCodeType.Name = "bt_listCodeType";
			this.bt_listCodeType.Size = new System.Drawing.Size(27, 25);
			this.bt_listCodeType.TabIndex = 26;
			this.bt_listCodeType.UseVisualStyleBackColor = true;
			this.bt_listCodeType.Click += new System.EventHandler(this.bt_listCodeType_Click);
			// 
			// bt_listNoChambre
			// 
			this.bt_listNoChambre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_listNoChambre.BackgroundImage")));
			this.bt_listNoChambre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bt_listNoChambre.Location = new System.Drawing.Point(187, 19);
			this.bt_listNoChambre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_listNoChambre.Name = "bt_listNoChambre";
			this.bt_listNoChambre.Size = new System.Drawing.Size(27, 25);
			this.bt_listNoChambre.TabIndex = 25;
			this.bt_listNoChambre.UseVisualStyleBackColor = true;
			this.bt_listNoChambre.Click += new System.EventHandler(this.bt_listNoChambre_Click);
			// 
			// gb_commodite
			// 
			this.gb_commodite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_commodite.Controls.Add(this.bt_deleteCommodite);
			this.gb_commodite.Controls.Add(this.bt_listCommodite);
			this.gb_commodite.Controls.Add(this.dgv_commodite);
			this.gb_commodite.Location = new System.Drawing.Point(3, 201);
			this.gb_commodite.Name = "gb_commodite";
			this.gb_commodite.Size = new System.Drawing.Size(985, 328);
			this.gb_commodite.TabIndex = 26;
			this.gb_commodite.TabStop = false;
			this.gb_commodite.Text = "Liste des commodités";
			// 
			// bt_deleteCommodite
			// 
			this.bt_deleteCommodite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_deleteCommodite.BackgroundImage")));
			this.bt_deleteCommodite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bt_deleteCommodite.Enabled = false;
			this.bt_deleteCommodite.Location = new System.Drawing.Point(6, 50);
			this.bt_deleteCommodite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_deleteCommodite.Name = "bt_deleteCommodite";
			this.bt_deleteCommodite.Size = new System.Drawing.Size(27, 25);
			this.bt_deleteCommodite.TabIndex = 10;
			this.bt_deleteCommodite.UseVisualStyleBackColor = true;
			this.bt_deleteCommodite.Click += new System.EventHandler(this.bt_deleteCommodite_Click);
			// 
			// bt_listCommodite
			// 
			this.bt_listCommodite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_listCommodite.BackgroundImage")));
			this.bt_listCommodite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bt_listCommodite.Enabled = false;
			this.bt_listCommodite.Location = new System.Drawing.Point(6, 21);
			this.bt_listCommodite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_listCommodite.Name = "bt_listCommodite";
			this.bt_listCommodite.Size = new System.Drawing.Size(27, 25);
			this.bt_listCommodite.TabIndex = 9;
			this.bt_listCommodite.UseVisualStyleBackColor = true;
			this.bt_listCommodite.Click += new System.EventHandler(this.bt_listCommodite_Click);
			// 
			// dS_Master
			// 
			this.dS_Master.DataSetName = "DS_Master";
			this.dS_Master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// TA_CHAMBRE
			// 
			this.TA_CHAMBRE.ClearBeforeFill = true;
			// 
			// TA_COMMODITE
			// 
			this.TA_COMMODITE.ClearBeforeFill = true;
			// 
			// TA_TYPECHAM
			// 
			this.TA_TYPECHAM.ClearBeforeFill = true;
			// 
			// TA_LOCALISATION
			// 
			this.TA_LOCALISATION.ClearBeforeFill = true;
			// 
			// TA_AYANT
			// 
			this.TA_AYANT.ClearBeforeFill = true;
			// 
			// TA_BK_COMMODITE
			// 
			this.TA_BK_COMMODITE.ClearBeforeFill = true;
			// 
			// UC_Chambre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gb_commodite);
			this.Controls.Add(this.gb_infoChambre);
			this.Name = "UC_Chambre";
			this.Size = new System.Drawing.Size(1297, 532);
			this.Load += new System.EventHandler(this.Tab_Chambre_Load);
			this.Enter += new System.EventHandler(this.UC_Chambre_Enter);
			this.Leave += new System.EventHandler(this.UC_Chambre_Leave);
			((System.ComponentModel.ISupportInitialize)(this.dgv_commodite)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_AYANT)).EndInit();
			this.gb_infoChambre.ResumeLayout(false);
			this.gb_infoChambre.PerformLayout();
			this.gb_commodite.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_COMMODITE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_TYPECHAM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_LOCALISATION)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_BK_COMMODITE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dS_Master)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DS_Master dS_Master;
		private DS_MasterTableAdapters.CHAMBRETableAdapter TA_CHAMBRE;
		private DS_MasterTableAdapters.COMMODITETableAdapter TA_COMMODITE;
		private DS_MasterTableAdapters.TYPECHAMTableAdapter TA_TYPECHAM;
		private System.Windows.Forms.Label lb_noCham;
		private System.Windows.Forms.Label lb_etage;
		private System.Windows.Forms.TextBox tb_etage;
		private System.Windows.Forms.Label lb_etat;
		private System.Windows.Forms.TextBox tb_etat;
		private System.Windows.Forms.Label lb_codeType;
		private System.Windows.Forms.Label lb_codeLoc;
		private System.Windows.Forms.BindingSource BS_CHAMBRE;
		private System.Windows.Forms.BindingSource BS_AYANT;
		private System.Windows.Forms.DataGridView dgv_commodite;
		private System.Windows.Forms.BindingSource BS_COMMODITE;
		private System.Windows.Forms.BindingSource BS_TYPECHAM;
		private System.Windows.Forms.TextBox tb_noCham;
		private System.Windows.Forms.Label lb_prix;
		private System.Windows.Forms.Label lb_descLoc;
		private System.Windows.Forms.Label lb_descType;
		private System.Windows.Forms.Label lb_memo;
		private System.Windows.Forms.TextBox tb_codeLoc;
		private System.Windows.Forms.TextBox tb_codeType;
		private System.Windows.Forms.TextBox tb_descLoc;
		private System.Windows.Forms.TextBox tb_descType;
		private System.Windows.Forms.TextBox tb_memo;
		private System.Windows.Forms.MaskedTextBox mtb_prix;
		private System.Windows.Forms.GroupBox gb_infoChambre;
		private System.Windows.Forms.GroupBox gb_commodite;
		private PrjEq01_CommonForm.Controls.Button_List bt_listCodeType;
		private PrjEq01_CommonForm.Controls.Button_List bt_listNoChambre;
		private PrjEq01_CommonForm.Controls.Button_List bt_listCommodite;
		private PrjEq01_CommonForm.Controls.Button_List bt_listCodeLoc;
		private DS_MasterTableAdapters.LOCALISATIONTableAdapter TA_LOCALISATION;
		private System.Windows.Forms.BindingSource BS_LOCALISATION;
		private PrjEq01_CommonForm.Controls.Button_List bt_deleteCommodite;
		private DS_MasterTableAdapters.AYANTTableAdapter TA_AYANT;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private DS_MasterTableAdapters.BK_COMMODITETableAdapter TA_BK_COMMODITE;
		private System.Windows.Forms.BindingSource BS_BK_COMMODITE;
	}
}
