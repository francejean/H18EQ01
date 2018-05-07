namespace PrjEq01_Application.Tabs
{
	partial class UC_Clients
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
			this.ic_client = new PrjEq01_Application.UserControls.Info_Client.IC_Client();
			this.ds_master = new PrjEq01_Application.DS_Master();
			this.TA_CLIENT = new PrjEq01_Application.DS_MasterTableAdapters.CLIENTTableAdapter();
			this.BS_CLIENT = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).BeginInit();
			this.SuspendLayout();
			// 
			// ic_client
			// 
			this.ic_client.BS = null;
			this.ic_client.ClientSelected = null;
			this.ic_client.Location = new System.Drawing.Point(3, 3);
			this.ic_client.MinimumSize = new System.Drawing.Size(395, 190);
			this.ic_client.Name = "ic_client";
			this.ic_client.Size = new System.Drawing.Size(408, 190);
			this.ic_client.TabIndex = 0;
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
			// UC_Clients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ic_client);
			this.Name = "UC_Clients";
			this.Size = new System.Drawing.Size(973, 432);
			this.Load += new System.EventHandler(this.UC_Clients_Load);
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private UserControls.Info_Client.IC_Client ic_client;
		private DS_Master ds_master;
		private DS_MasterTableAdapters.CLIENTTableAdapter TA_CLIENT;
		private System.Windows.Forms.BindingSource BS_CLIENT;
	}
}
