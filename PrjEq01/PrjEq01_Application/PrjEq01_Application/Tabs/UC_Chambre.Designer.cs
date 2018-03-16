﻿namespace PrjEq01_Application.Tabs
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
            this.BS_CHAMBRE = new System.Windows.Forms.BindingSource(this.components);
            this.BS_AYANT = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_commodite = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_COMMODITE = new System.Windows.Forms.BindingSource(this.components);
            this.BS_TYPECHAM = new System.Windows.Forms.BindingSource(this.components);
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
            this.dS_Master = new PrjEq01_Application.DS_Master();
            this.TA_CHAMBRE = new PrjEq01_Application.DS_MasterTableAdapters.CHAMBRETableAdapter();
            this.TA_AYANT = new PrjEq01_Application.DS_MasterTableAdapters.AYANTTableAdapter();
            this.TA_COMMODITE = new PrjEq01_Application.DS_MasterTableAdapters.COMMODITETableAdapter();
            this.TA_TYPECHAM = new PrjEq01_Application.DS_MasterTableAdapters.TYPECHAMTableAdapter();
            this.gb_infoChambre = new System.Windows.Forms.GroupBox();
            this.gb_commodite = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_list = new PrjEq01_CommonForm.Controls.Button_List();
            this.button_List1 = new PrjEq01_CommonForm.Controls.Button_List();
            this.button_List2 = new PrjEq01_CommonForm.Controls.Button_List();
            this.button_List3 = new PrjEq01_CommonForm.Controls.Button_List();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AYANT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commodite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_COMMODITE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TYPECHAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).BeginInit();
            this.gb_infoChambre.SuspendLayout();
            this.gb_commodite.SuspendLayout();
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
            this.tb_etage.Name = "tb_etage";
            this.tb_etage.ReadOnly = true;
            this.tb_etage.Size = new System.Drawing.Size(116, 22);
            this.tb_etage.TabIndex = 3;
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
            this.tb_etat.Name = "tb_etat";
            this.tb_etat.ReadOnly = true;
            this.tb_etat.Size = new System.Drawing.Size(116, 22);
            this.tb_etat.TabIndex = 5;
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
            this.dgv_commodite.AllowUserToOrderColumns = true;
            this.dgv_commodite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_commodite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_commodite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Description,
            this.Column2});
            this.dgv_commodite.Location = new System.Drawing.Point(39, 21);
            this.dgv_commodite.Name = "dgv_commodite";
            this.dgv_commodite.ReadOnly = true;
            this.dgv_commodite.RowTemplate.Height = 24;
            this.dgv_commodite.Size = new System.Drawing.Size(940, 301);
            this.dgv_commodite.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodCom";
            this.Column1.HeaderText = "CODCOM";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "DescCom";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NoCham";
            this.Column2.HeaderText = "No. Cham";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // tb_noCham
            // 
            this.tb_noCham.Location = new System.Drawing.Point(82, 22);
            this.tb_noCham.Margin = new System.Windows.Forms.Padding(4);
            this.tb_noCham.Name = "tb_noCham";
            this.tb_noCham.ReadOnly = true;
            this.tb_noCham.Size = new System.Drawing.Size(98, 22);
            this.tb_noCham.TabIndex = 14;
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
            this.tb_codeLoc.Size = new System.Drawing.Size(81, 22);
            this.tb_codeLoc.TabIndex = 19;
            // 
            // tb_codeType
            // 
            this.tb_codeType.Location = new System.Drawing.Point(325, 22);
            this.tb_codeType.Name = "tb_codeType";
            this.tb_codeType.ReadOnly = true;
            this.tb_codeType.Size = new System.Drawing.Size(124, 22);
            this.tb_codeType.TabIndex = 20;
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
            this.mtb_prix.Size = new System.Drawing.Size(72, 22);
            this.mtb_prix.TabIndex = 24;
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
            // TA_AYANT
            // 
            this.TA_AYANT.ClearBeforeFill = true;
            // 
            // TA_COMMODITE
            // 
            this.TA_COMMODITE.ClearBeforeFill = true;
            // 
            // TA_TYPECHAM
            // 
            this.TA_TYPECHAM.ClearBeforeFill = true;
            // 
            // gb_infoChambre
            // 
            this.gb_infoChambre.Controls.Add(this.button_List3);
            this.gb_infoChambre.Controls.Add(this.button_List2);
            this.gb_infoChambre.Controls.Add(this.button_List1);
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
            // gb_commodite
            // 
            this.gb_commodite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_commodite.Controls.Add(this.bt_list);
            this.gb_commodite.Controls.Add(this.dgv_commodite);
            this.gb_commodite.Location = new System.Drawing.Point(3, 201);
            this.gb_commodite.Name = "gb_commodite";
            this.gb_commodite.Size = new System.Drawing.Size(985, 328);
            this.gb_commodite.TabIndex = 26;
            this.gb_commodite.TabStop = false;
            this.gb_commodite.Text = "Liste des commodités";
            // 
            // bt_list
            // 
            this.bt_list.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_list.BackgroundImage")));
            this.bt_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_list.Location = new System.Drawing.Point(6, 21);
            this.bt_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_list.Name = "bt_list";
            this.bt_list.Size = new System.Drawing.Size(27, 25);
            this.bt_list.TabIndex = 9;
            this.bt_list.UseVisualStyleBackColor = true;
            // 
            // button_List1
            // 
            this.button_List1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_List1.BackgroundImage")));
            this.button_List1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_List1.Location = new System.Drawing.Point(187, 19);
            this.button_List1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_List1.Name = "button_List1";
            this.button_List1.Size = new System.Drawing.Size(27, 25);
            this.button_List1.TabIndex = 25;
            this.button_List1.UseVisualStyleBackColor = true;
            // 
            // button_List2
            // 
            this.button_List2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_List2.BackgroundImage")));
            this.button_List2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_List2.Location = new System.Drawing.Point(455, 19);
            this.button_List2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_List2.Name = "button_List2";
            this.button_List2.Size = new System.Drawing.Size(27, 25);
            this.button_List2.TabIndex = 26;
            this.button_List2.UseVisualStyleBackColor = true;
            // 
            // button_List3
            // 
            this.button_List3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_List3.BackgroundImage")));
            this.button_List3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_List3.Location = new System.Drawing.Point(455, 72);
            this.button_List3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_List3.Name = "button_List3";
            this.button_List3.Size = new System.Drawing.Size(27, 25);
            this.button_List3.TabIndex = 27;
            this.button_List3.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AYANT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commodite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_COMMODITE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TYPECHAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).EndInit();
            this.gb_infoChambre.ResumeLayout(false);
            this.gb_infoChambre.PerformLayout();
            this.gb_commodite.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DS_Master dS_Master;
        private DS_MasterTableAdapters.CHAMBRETableAdapter TA_CHAMBRE;
        private DS_MasterTableAdapters.AYANTTableAdapter TA_AYANT;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox gb_commodite;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PrjEq01_CommonForm.Controls.Button_List button_List2;
        private PrjEq01_CommonForm.Controls.Button_List button_List1;
        private PrjEq01_CommonForm.Controls.Button_List bt_list;
        private PrjEq01_CommonForm.Controls.Button_List button_List3;
    }
}
