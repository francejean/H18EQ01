namespace PrjEq01_Application.List_Forms
{
    partial class LF_Reservation
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
            this.TA_RESERVATION = new PrjEq01_Application.DS_MasterTableAdapters.RESERVATIONTableAdapter();
            this.ds_master = new PrjEq01_Application.DS_Master();
            this.BS_RESERVATION = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_reservation = new System.Windows.Forms.DataGridView();
            this.idReserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESERVATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVATIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Location = new System.Drawing.Point(245, 282);
            this.bt_ok.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(59, 34);
            this.bt_ok.TabIndex = 3;
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
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // TA_RESERVATION
            // 
            this.TA_RESERVATION.ClearBeforeFill = true;
            // 
            // ds_master
            // 
            this.ds_master.DataSetName = "DS_Master";
            this.ds_master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_reservation
            // 
            this.dgv_reservation.AllowUserToAddRows = false;
            this.dgv_reservation.AllowUserToDeleteRows = false;
            this.dgv_reservation.AutoGenerateColumns = false;
            this.dgv_reservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReserDataGridViewTextBoxColumn,
            this.idCliDataGridViewTextBoxColumn,
            this.dateReserDataGridViewTextBoxColumn,
            this.dateDebutDataGridViewTextBoxColumn,
            this.dateFinDataGridViewTextBoxColumn});
            this.dgv_reservation.DataSource = this.rESERVATIONBindingSource;
            this.dgv_reservation.Location = new System.Drawing.Point(12, 12);
            this.dgv_reservation.Name = "dgv_reservation";
            this.dgv_reservation.ReadOnly = true;
            this.dgv_reservation.Size = new System.Drawing.Size(702, 265);
            this.dgv_reservation.TabIndex = 5;
            // 
            // idReserDataGridViewTextBoxColumn
            // 
            this.idReserDataGridViewTextBoxColumn.DataPropertyName = "IdReser";
            this.idReserDataGridViewTextBoxColumn.HeaderText = "No. Réservation";
            this.idReserDataGridViewTextBoxColumn.Name = "idReserDataGridViewTextBoxColumn";
            this.idReserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCliDataGridViewTextBoxColumn
            // 
            this.idCliDataGridViewTextBoxColumn.DataPropertyName = "IdCli";
            this.idCliDataGridViewTextBoxColumn.HeaderText = "No. Client";
            this.idCliDataGridViewTextBoxColumn.Name = "idCliDataGridViewTextBoxColumn";
            this.idCliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateReserDataGridViewTextBoxColumn
            // 
            this.dateReserDataGridViewTextBoxColumn.DataPropertyName = "DateReser";
            this.dateReserDataGridViewTextBoxColumn.HeaderText = "Date Réser.";
            this.dateReserDataGridViewTextBoxColumn.Name = "dateReserDataGridViewTextBoxColumn";
            this.dateReserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDebutDataGridViewTextBoxColumn
            // 
            this.dateDebutDataGridViewTextBoxColumn.DataPropertyName = "DateDebut";
            this.dateDebutDataGridViewTextBoxColumn.HeaderText = "Date Début";
            this.dateDebutDataGridViewTextBoxColumn.Name = "dateDebutDataGridViewTextBoxColumn";
            this.dateDebutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateFinDataGridViewTextBoxColumn
            // 
            this.dateFinDataGridViewTextBoxColumn.DataPropertyName = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.HeaderText = "Date Fin";
            this.dateFinDataGridViewTextBoxColumn.Name = "dateFinDataGridViewTextBoxColumn";
            this.dateFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rESERVATIONBindingSource
            // 
            this.rESERVATIONBindingSource.DataMember = "RESERVATION";
            this.rESERVATIONBindingSource.DataSource = this.ds_master;
            // 
            // LF_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 326);
            this.Controls.Add(this.dgv_reservation);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.MinimumSize = new System.Drawing.Size(742, 364);
            this.Name = "LF_Reservation";
            this.Text = "LF_Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVATIONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_cancel;
        private DS_MasterTableAdapters.RESERVATIONTableAdapter TA_RESERVATION;
        private DS_Master ds_master;
        private System.Windows.Forms.BindingSource BS_RESERVATION;
        private System.Windows.Forms.DataGridView dgv_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rESERVATIONBindingSource;
    }
}