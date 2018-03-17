namespace PrjEq01_Application.List_Forms
{
    partial class LF_Client
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
            this.components = new System.ComponentModel.Container();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.ds_master = new PrjEq01_Application.DS_Master();
            this.TA_CLIENT = new PrjEq01_Application.DS_MasterTableAdapters.CLIENTTableAdapter();
            this.BS_CLIENT = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldeDuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Location = new System.Drawing.Point(245, 282);
            this.bt_ok.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(59, 34);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Location = new System.Drawing.Point(429, 282);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(59, 34);
            this.bt_cancel.TabIndex = 3;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // ds_master
            // 
            this.ds_master.DataSetName = "DS_Master";
            this.ds_master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TA_CLIENT
            // 
            this.TA_CLIENT.ClearBeforeFill = true;
            // 
            // dgv_client
            // 
            this.dgv_client.AllowUserToAddRows = false;
            this.dgv_client.AllowUserToDeleteRows = false;
            this.dgv_client.AutoGenerateColumns = false;
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.noCarteDataGridViewTextBoxColumn,
            this.typeCarteDataGridViewTextBoxColumn,
            this.datExpDataGridViewTextBoxColumn,
            this.soldeDuDataGridViewTextBoxColumn});
            this.dgv_client.DataSource = this.cLIENTBindingSource;
            this.dgv_client.Location = new System.Drawing.Point(12, 12);
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.ReadOnly = true;
            this.dgv_client.Size = new System.Drawing.Size(702, 253);
            this.dgv_client.TabIndex = 4;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.ds_master;
            // 
            // idCliDataGridViewTextBoxColumn
            // 
            this.idCliDataGridViewTextBoxColumn.DataPropertyName = "IdCli";
            this.idCliDataGridViewTextBoxColumn.HeaderText = "No. Client";
            this.idCliDataGridViewTextBoxColumn.Name = "idCliDataGridViewTextBoxColumn";
            this.idCliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noCarteDataGridViewTextBoxColumn
            // 
            this.noCarteDataGridViewTextBoxColumn.DataPropertyName = "NoCarte";
            this.noCarteDataGridViewTextBoxColumn.HeaderText = "No. Carte";
            this.noCarteDataGridViewTextBoxColumn.Name = "noCarteDataGridViewTextBoxColumn";
            this.noCarteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeCarteDataGridViewTextBoxColumn
            // 
            this.typeCarteDataGridViewTextBoxColumn.DataPropertyName = "TypeCarte";
            this.typeCarteDataGridViewTextBoxColumn.HeaderText = "Type de carte";
            this.typeCarteDataGridViewTextBoxColumn.Name = "typeCarteDataGridViewTextBoxColumn";
            this.typeCarteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datExpDataGridViewTextBoxColumn
            // 
            this.datExpDataGridViewTextBoxColumn.DataPropertyName = "DatExp";
            this.datExpDataGridViewTextBoxColumn.HeaderText = "Date d\'exp.";
            this.datExpDataGridViewTextBoxColumn.Name = "datExpDataGridViewTextBoxColumn";
            this.datExpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soldeDuDataGridViewTextBoxColumn
            // 
            this.soldeDuDataGridViewTextBoxColumn.DataPropertyName = "SoldeDu";
            this.soldeDuDataGridViewTextBoxColumn.HeaderText = "Solde dû";
            this.soldeDuDataGridViewTextBoxColumn.Name = "soldeDuDataGridViewTextBoxColumn";
            this.soldeDuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LF_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 326);
            this.Controls.Add(this.dgv_client);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.MinimumSize = new System.Drawing.Size(742, 364);
            this.Name = "LF_Client";
            this.Text = "LF_Client";
            ((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_cancel;
        private DS_Master ds_master;
        private DS_MasterTableAdapters.CLIENTTableAdapter TA_CLIENT;
        private System.Windows.Forms.BindingSource BS_CLIENT;
        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldeDuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
    }
}