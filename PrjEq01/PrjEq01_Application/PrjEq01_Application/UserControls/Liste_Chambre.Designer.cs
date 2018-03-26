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
            this.GroupBox_ListeChambres = new System.Windows.Forms.GroupBox();
            this.dgv_chambre = new System.Windows.Forms.DataGridView();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descTypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_CHAMBRE = new System.Windows.Forms.BindingSource(this.components);
            this.ds_master = new PrjEq01_Application.DS_Master();
            this.TA_CHAMBRE = new PrjEq01_Application.DS_MasterTableAdapters.CHAMBRETableAdapter();
            this.GroupBox_ListeChambres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_ListeChambres
            // 
            this.GroupBox_ListeChambres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_ListeChambres.Controls.Add(this.dgv_chambre);
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
            this.Etat});
            this.dgv_chambre.DataSource = this.BS_CHAMBRE;
            this.dgv_chambre.Location = new System.Drawing.Point(6, 17);
            this.dgv_chambre.Name = "dgv_chambre";
            this.dgv_chambre.ReadOnly = true;
            this.dgv_chambre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_chambre.RowHeadersVisible = false;
            this.dgv_chambre.Size = new System.Drawing.Size(939, 233);
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
            this.descTypDataGridViewTextBoxColumn.DataPropertyName = "CodTypCham";
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
            // Etat
            // 
            this.Etat.DataPropertyName = "Attribuee";
            this.Etat.HeaderText = "Etat";
            this.Etat.Name = "Etat";
            this.Etat.ReadOnly = true;
            // 
            // BS_CHAMBRE
            // 
            this.BS_CHAMBRE.DataMember = "CHAMBRE";
            this.BS_CHAMBRE.DataSource = this.ds_master;
            // 
            // ds_master
            // 
            this.ds_master.DataSetName = "DS_Master";
            this.ds_master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TA_CHAMBRE
            // 
            this.TA_CHAMBRE.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox GroupBox_ListeChambres;
        private System.Windows.Forms.BindingSource BS_CHAMBRE;
        private DS_Master ds_master;
        private DS_MasterTableAdapters.CHAMBRETableAdapter TA_CHAMBRE;
        public System.Windows.Forms.DataGridView dgv_chambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descTypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
    }
}
