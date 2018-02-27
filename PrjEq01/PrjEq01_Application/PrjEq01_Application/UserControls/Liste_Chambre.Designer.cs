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
            this.DG_Chambres = new System.Windows.Forms.DataGridView();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTypChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHAMBREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Master = new PrjEq01_Application.DS_Master();
            this.Button_List = new PrjEq01_CommonForm.Controls.Button_List();
            this.cHAMBRETableAdapter = new PrjEq01_Application.DS_MasterTableAdapters.CHAMBRETableAdapter();
            this.GroupBox_ListeChambres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Chambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAMBREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_ListeChambres
            // 
            this.GroupBox_ListeChambres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_ListeChambres.Controls.Add(this.DG_Chambres);
            this.GroupBox_ListeChambres.Controls.Add(this.Button_List);
            this.GroupBox_ListeChambres.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_ListeChambres.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_ListeChambres.Name = "GroupBox_ListeChambres";
            this.GroupBox_ListeChambres.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_ListeChambres.Size = new System.Drawing.Size(1133, 283);
            this.GroupBox_ListeChambres.TabIndex = 1;
            this.GroupBox_ListeChambres.TabStop = false;
            this.GroupBox_ListeChambres.Text = "Liste des chambres";
            // 
            // DG_Chambres
            // 
            this.DG_Chambres.AllowUserToAddRows = false;
            this.DG_Chambres.AllowUserToDeleteRows = false;
            this.DG_Chambres.AutoGenerateColumns = false;
            this.DG_Chambres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Chambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Chambres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noChamDataGridViewTextBoxColumn,
            this.etageDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.etatDataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn,
            this.codLocDataGridViewTextBoxColumn,
            this.codTypChamDataGridViewTextBoxColumn});
            this.DG_Chambres.DataSource = this.cHAMBREBindingSource;
            this.DG_Chambres.Location = new System.Drawing.Point(39, 22);
            this.DG_Chambres.Name = "DG_Chambres";
            this.DG_Chambres.RowTemplate.Height = 24;
            this.DG_Chambres.Size = new System.Drawing.Size(1087, 254);
            this.DG_Chambres.TabIndex = 8;
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
            // Button_List
            // 
            this.Button_List.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_List.BackgroundImage")));
            this.Button_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_List.Location = new System.Drawing.Point(7, 21);
            this.Button_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_List.Name = "Button_List";
            this.Button_List.Size = new System.Drawing.Size(27, 25);
            this.Button_List.TabIndex = 1;
            this.Button_List.UseVisualStyleBackColor = true;
            // 
            // cHAMBRETableAdapter
            // 
            this.cHAMBRETableAdapter.ClearBeforeFill = true;
            // 
            // Liste_Chambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox_ListeChambres);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1133, 283);
            this.Name = "Liste_Chambre";
            this.Size = new System.Drawing.Size(1133, 283);
            this.GroupBox_ListeChambres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Chambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAMBREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PrjEq01_CommonForm.Controls.Button_List Button_List;
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
        public System.Windows.Forms.DataGridView DG_Chambres;
    }
}
