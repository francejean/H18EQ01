namespace PrjEq01_Application.UserControls.Info_Client
{
	partial class IC_Client
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
			this.gb_client.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_noCarte
			// 
			this.tb_noCarte.Validated += new System.EventHandler(this.tb_noCarte_Validated);
			// 
			// tb_nomClient
			// 
			this.tb_nomClient.Validated += new System.EventHandler(this.tb_nomClient_Validated);
			// 
			// tb_telephone
			// 
			this.tb_telephone.Validated += new System.EventHandler(this.tb_telephone_Validated);
			// 
			// tb_adresse
			// 
			this.tb_adresse.Validated += new System.EventHandler(this.tb_adresse_Validated);
			// 
			// bt_list
			// 
			this.bt_list.Visible = false;
			// 
			// dtp_datExp
			// 
			this.dtp_datExp.Validated += new System.EventHandler(this.dtp_datExp_Validated);
			// 
			// cb_typeCarte
			// 
			this.cb_typeCarte.Validated += new System.EventHandler(this.cb_typeCarte_Validated);
			// 
			// IC_Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "IC_Client";
			this.gb_client.ResumeLayout(false);
			this.gb_client.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
	}
}
