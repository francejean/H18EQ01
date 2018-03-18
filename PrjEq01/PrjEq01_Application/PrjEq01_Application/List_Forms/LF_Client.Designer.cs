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
			this.ds_master = new PrjEq01_Application.DS_Master();
			this.BS_CLIENT = new System.Windows.Forms.BindingSource(this.components);
			this.TA_CLIENT = new PrjEq01_Application.DS_MasterTableAdapters.CLIENTTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_main
			// 
			this.dgv_main.DataSource = this.BS_CLIENT;
			// 
			// ds_master
			// 
			this.ds_master.DataSetName = "DS_Master";
			this.ds_master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// BS_CLIENT
			// 
			this.BS_CLIENT.DataMember = "CLIENT";
			this.BS_CLIENT.DataSource = this.ds_master;
			// 
			// TA_CLIENT
			// 
			this.TA_CLIENT.ClearBeforeFill = true;
			// 
			// LF_Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(734, 362);
			this.Name = "LF_Client";
			this.Text = "Liste des clients";
			this.Load += new System.EventHandler(this.LF_Client_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DS_Master ds_master;
        private System.Windows.Forms.BindingSource BS_CLIENT;
        private DS_MasterTableAdapters.CLIENTTableAdapter TA_CLIENT;
    }
}
