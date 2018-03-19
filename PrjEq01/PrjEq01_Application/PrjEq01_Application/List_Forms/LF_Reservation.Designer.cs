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
			this.ds_master = new PrjEq01_Application.DS_Master();
			this.BS_RESERVATION = new System.Windows.Forms.BindingSource(this.components);
			this.TA_RESERVATION = new PrjEq01_Application.DS_MasterTableAdapters.RESERVATIONTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_main
			// 
			this.dgv_main.DataSource = this.BS_RESERVATION;
			// 
			// ds_master
			// 
			this.ds_master.DataSetName = "DS_Master";
			this.ds_master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// BS_RESERVATION
			// 
			this.BS_RESERVATION.DataMember = "RESERVATION";
			this.BS_RESERVATION.DataSource = this.ds_master;
			// 
			// TA_RESERVATION
			// 
			this.TA_RESERVATION.ClearBeforeFill = true;
			// 
			// LF_Reservation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(734, 362);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "LF_Reservation";
			this.Load += new System.EventHandler(this.LF_Reservation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DS_Master ds_master;
        private System.Windows.Forms.BindingSource BS_RESERVATION;
        private DS_MasterTableAdapters.RESERVATIONTableAdapter TA_RESERVATION;
    }
}
