namespace PrjEq01_Application.Tabs
{
    partial class Tab_Chambre
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
            this.label1 = new System.Windows.Forms.Label();
            this.noChamTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.etageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.etatTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BS_CHAMBRE = new System.Windows.Forms.BindingSource(this.components);
            this.BS_AYANT = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dS_Master = new PrjEq01_Application.DS_Master();
            this.TA_CHAMBRE = new PrjEq01_Application.DS_MasterTableAdapters.CHAMBRETableAdapter();
            this.TA_AYANT = new PrjEq01_Application.DS_MasterTableAdapters.AYANTTableAdapter();
            this.TA_COMMODITE = new PrjEq01_Application.DS_MasterTableAdapters.COMMODITETableAdapter();
            this.TA_TYPECHAM = new PrjEq01_Application.DS_MasterTableAdapters.TYPECHAMTableAdapter();
            this.dSMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aYANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codComDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AYANT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYANTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Cham :";
            // 
            // noChamTextBox
            // 
            this.noChamTextBox.Location = new System.Drawing.Point(81, 28);
            this.noChamTextBox.Name = "noChamTextBox";
            this.noChamTextBox.Size = new System.Drawing.Size(100, 22);
            this.noChamTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Étage :";
            // 
            // etageTextBox
            // 
            this.etageTextBox.Location = new System.Drawing.Point(81, 74);
            this.etageTextBox.Name = "etageTextBox";
            this.etageTextBox.Size = new System.Drawing.Size(100, 22);
            this.etageTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "État :";
            // 
            // etatTextBox
            // 
            this.etatTextBox.Location = new System.Drawing.Point(81, 132);
            this.etatTextBox.Name = "etatTextBox";
            this.etatTextBox.Size = new System.Drawing.Size(34, 22);
            this.etatTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Code Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Code Localisation :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noChamDataGridViewTextBoxColumn,
            this.codComDataGridViewTextBoxColumn,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(101, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(354, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "DescCom";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
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
            // dSMasterBindingSource
            // 
            this.dSMasterBindingSource.DataSource = this.dS_Master;
            this.dSMasterBindingSource.Position = 0;
            // 
            // aYANTBindingSource
            // 
            this.aYANTBindingSource.DataMember = "AYANT";
            this.aYANTBindingSource.DataSource = this.dS_Master;
            // 
            // codComDataGridViewTextBoxColumn
            // 
            this.codComDataGridViewTextBoxColumn.DataPropertyName = "CodCom";
            this.codComDataGridViewTextBoxColumn.HeaderText = "CodCom";
            this.codComDataGridViewTextBoxColumn.Name = "codComDataGridViewTextBoxColumn";
            // 
            // noChamDataGridViewTextBoxColumn
            // 
            this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
            this.noChamDataGridViewTextBoxColumn.HeaderText = "NoCham";
            this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
            // 
            // Tab_Chambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.etatTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.etageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noChamTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Tab_Chambre";
            this.Size = new System.Drawing.Size(1297, 532);
            this.Load += new System.EventHandler(this.Tab_Chambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_AYANT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aYANTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS_Master dS_Master;
        private DS_MasterTableAdapters.CHAMBRETableAdapter TA_CHAMBRE;
        private DS_MasterTableAdapters.AYANTTableAdapter TA_AYANT;
        private DS_MasterTableAdapters.COMMODITETableAdapter TA_COMMODITE;
        private DS_MasterTableAdapters.TYPECHAMTableAdapter TA_TYPECHAM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noChamTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox etageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox etatTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource BS_CHAMBRE;
        private System.Windows.Forms.BindingSource BS_AYANT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.BindingSource dSMasterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codComDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aYANTBindingSource;
    }
}
