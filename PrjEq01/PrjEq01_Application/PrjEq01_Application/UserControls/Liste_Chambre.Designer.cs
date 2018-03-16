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
            this.descTypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHAMBREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Master = new PrjEq01_Application.DS_Master();
            this.bt_list = new PrjEq01_CommonForm.Controls.Button_List();
            this.cHAMBRETableAdapter = new PrjEq01_Application.DS_MasterTableAdapters.CHAMBRETableAdapter();
            this.aRRIVEFKNoChamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aRRIVETableAdapter = new PrjEq01_Application.DS_MasterTableAdapters.ARRIVETableAdapter();
            this.GroupBox_ListeChambres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAMBREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRRIVEFKNoChamBindingSource)).BeginInit();
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
            this.GroupBox_ListeChambres.Size = new System.Drawing.Size(951, 256);
            this.GroupBox_ListeChambres.TabIndex = 1;
            this.GroupBox_ListeChambres.TabStop = false;
            this.GroupBox_ListeChambres.Text = "Liste des chambres";
            // 
            // dgv_chambre
            // 
            this.dgv_chambre.AllowUserToAddRows = false;
            this.dgv_chambre.AllowUserToDeleteRows = false;
            this.dgv_chambre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_chambre.AutoGenerateColumns = false;
            this.dgv_chambre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noChamDataGridViewTextBoxColumn,
            this.descTypDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.etatDataGridViewTextBoxColumn});
            this.dgv_chambre.DataSource = this.cHAMBREBindingSource;
            this.dgv_chambre.Location = new System.Drawing.Point(30, 17);
            this.dgv_chambre.Name = "dgv_chambre";
            this.dgv_chambre.ReadOnly = true;
            this.dgv_chambre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_chambre.Size = new System.Drawing.Size(915, 233);
            this.dgv_chambre.TabIndex = 2;
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "No. chambre";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            this.noChamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descTypDataGridViewTextBoxColumn
            // 
            this.descTypDataGridViewTextBoxColumn.DataPropertyName = "DescTyp";
            this.descTypDataGridViewTextBoxColumn.HeaderText = "Type de chambre";
            this.descTypDataGridViewTextBoxColumn.Name = "descTypDataGridViewTextBoxColumn";
            this.descTypDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etatDataGridViewTextBoxColumn
            // 
            this.etatDataGridViewTextBoxColumn.DataPropertyName = "Etat";
            this.etatDataGridViewTextBoxColumn.HeaderText = "Etat";
            this.etatDataGridViewTextBoxColumn.Name = "etatDataGridViewTextBoxColumn";
            this.etatDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.bt_list.Margin = new System.Windows.Forms.Padding(2);
            this.bt_list.Name = "bt_list";
            this.bt_list.Size = new System.Drawing.Size(20, 20);
            this.bt_list.TabIndex = 1;
            this.bt_list.UseVisualStyleBackColor = true;
            this.bt_list.Click += new System.EventHandler(this.bt_list_Click);
            // 
            // cHAMBRETableAdapter
            // 
            this.cHAMBRETableAdapter.ClearBeforeFill = true;
            // 
            // aRRIVEFKNoChamBindingSource
            // 
            this.aRRIVEFKNoChamBindingSource.DataMember = "ARRIVE_FK_NoCham";
            this.aRRIVEFKNoChamBindingSource.DataSource = this.cHAMBREBindingSource;
            // 
            // aRRIVETableAdapter
            // 
            this.aRRIVETableAdapter.ClearBeforeFill = true;
            // 
            // Liste_Chambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox_ListeChambres);
            this.MinimumSize = new System.Drawing.Size(850, 230);
            this.Name = "Liste_Chambre";
            this.Size = new System.Drawing.Size(951, 256);
            this.GroupBox_ListeChambres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAMBREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRRIVEFKNoChamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PrjEq01_CommonForm.Controls.Button_List bt_list;
        public System.Windows.Forms.GroupBox GroupBox_ListeChambres;
        private System.Windows.Forms.BindingSource cHAMBREBindingSource;
        private DS_Master dS_Master;
        private DS_MasterTableAdapters.CHAMBRETableAdapter cHAMBRETableAdapter;
        private System.Windows.Forms.BindingSource aRRIVEFKNoChamBindingSource;
        private DS_MasterTableAdapters.ARRIVETableAdapter aRRIVETableAdapter;
        public System.Windows.Forms.DataGridView dgv_chambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descTypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatDataGridViewTextBoxColumn;
    }
}
