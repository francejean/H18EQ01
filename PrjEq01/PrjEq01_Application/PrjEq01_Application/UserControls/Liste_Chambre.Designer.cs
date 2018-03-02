namespace PrjEq01_Application.UserControls
{
    partial class Liste_Chambre
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liste_Chambre));
            this.GroupBox_ListeChambres = new System.Windows.Forms.GroupBox();
            this.dgv_chambre = new System.Windows.Forms.DataGridView();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTypChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHAMBREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Master = new PrjEq01_Application.DS_Master();
            this.bt_list = new PrjEq01_CommonForm.Controls.Button_List();
            this.cHAMBRETableAdapter = new PrjEq01_Application.DS_MasterTableAdapters.CHAMBRETableAdapter();
            this.GroupBox_ListeChambres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAMBREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_ListeChambres
            // 
            this.GroupBox_ListeChambres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_ListeChambres.Controls.Add(this.dgv_chambre);
            this.GroupBox_ListeChambres.Controls.Add(this.bt_list);
            this.GroupBox_ListeChambres.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_ListeChambres.Name = "GroupBox_ListeChambres";
            this.GroupBox_ListeChambres.Size = new System.Drawing.Size(850, 230);
            this.GroupBox_ListeChambres.TabIndex = 1;
            this.GroupBox_ListeChambres.TabStop = false;
            this.GroupBox_ListeChambres.Text = "Liste des chambres";
            // 
            // dgv_chambre
            // 
            this.dgv_chambre.AllowUserToAddRows = false;
            this.dgv_chambre.AllowUserToDeleteRows = false;
            this.dgv_chambre.AutoGenerateColumns = false;
            this.dgv_chambre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noChamDataGridViewTextBoxColumn,
            this.etageDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.etatDataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn,
            this.codLocDataGridViewTextBoxColumn,
            this.codTypChamDataGridViewTextBoxColumn});
            this.dgv_chambre.DataSource = this.cHAMBREBindingSource;
            this.dgv_chambre.Location = new System.Drawing.Point(29, 18);
            this.dgv_chambre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_chambre.Name = "dgv_chambre";
            this.dgv_chambre.RowTemplate.Height = 24;
            this.dgv_chambre.Size = new System.Drawing.Size(815, 206);
            this.dgv_chambre.TabIndex = 8;
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            // 
            // etageDataGridViewTextBoxColumn
            // 
            this.etageDataGridViewTextBoxColumn.DataPropertyName = "Etage";
            this.etageDataGridViewTextBoxColumn.HeaderText = "Etage";
            this.etageDataGridViewTextBoxColumn.Name = "etageDataGridViewTextBoxColumn";
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            // 
            // etatDataGridViewTextBoxColumn
            // 
            this.etatDataGridViewTextBoxColumn.DataPropertyName = "Etat";
            this.etatDataGridViewTextBoxColumn.HeaderText = "Etat";
            this.etatDataGridViewTextBoxColumn.Name = "etatDataGridViewTextBoxColumn";
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "Memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "Memo";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            // 
            // codLocDataGridViewTextBoxColumn
            // 
            this.codLocDataGridViewTextBoxColumn.DataPropertyName = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.HeaderText = "CodLoc";
            this.codLocDataGridViewTextBoxColumn.Name = "codLocDataGridViewTextBoxColumn";
            // 
            // codTypChamDataGridViewTextBoxColumn
            // 
            this.codTypChamDataGridViewTextBoxColumn.DataPropertyName = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.HeaderText = "CodTypCham";
            this.codTypChamDataGridViewTextBoxColumn.Name = "codTypChamDataGridViewTextBoxColumn";
            // 
            // cHAMBREBindingSource
            // 
            this.cHAMBREBindingSource.DataMember = "CHAMBRE";
            this.cHAMBREBindingSource.DataSource = this.dS_Master;
            // 
            // dS_Master
            // 
            this.dS_Master.DataSetName = "DS_Master";
            this.dS_Master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_list
            // 
            this.bt_list.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_list.BackgroundImage")));
            this.bt_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_list.Location = new System.Drawing.Point(5, 17);
            this.bt_list.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_list.Name = "bt_list";
            this.bt_list.Size = new System.Drawing.Size(20, 20);
            this.bt_list.TabIndex = 1;
            this.bt_list.UseVisualStyleBackColor = true;
            // 
            // cHAMBRETableAdapter
            // 
            this.cHAMBRETableAdapter.ClearBeforeFill = true;
            // 
            // Liste_Chambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox_ListeChambres);
            this.MinimumSize = new System.Drawing.Size(850, 230);
            this.Name = "Liste_Chambre";
            this.Size = new System.Drawing.Size(850, 230);
            this.GroupBox_ListeChambres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAMBREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PrjEq01_CommonForm.Controls.Button_List bt_list;
        public System.Windows.Forms.GroupBox GroupBox_ListeChambres;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTypChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cHAMBREBindingSource;
        private DS_Master dS_Master;
        private DS_MasterTableAdapters.CHAMBRETableAdapter cHAMBRETableAdapter;
        public System.Windows.Forms.DataGridView dgv_chambre;
    }
}
