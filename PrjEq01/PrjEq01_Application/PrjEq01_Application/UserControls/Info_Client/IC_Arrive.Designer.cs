namespace PrjEq01_Application.UserControls.Info_Client
{
	partial class IC_Arrive
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
			this.lb_noChambre = new System.Windows.Forms.Label();
			this.tb_noChambre = new System.Windows.Forms.TextBox();
			this.gb_client.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
			this.SuspendLayout();
			// 
			// gb_client
			// 
			this.gb_client.Controls.Add(this.tb_noChambre);
			this.gb_client.Controls.Add(this.lb_noChambre);
			this.gb_client.Controls.SetChildIndex(this.dtp_datExp, 0);
			this.gb_client.Controls.SetChildIndex(this.bt_list, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_noClient, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_adresse, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_telephone, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_typeCarte, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_nomClient, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_noCarte, 0);
			this.gb_client.Controls.SetChildIndex(this.lb_noChambre, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_noChambre, 0);
			// 
			// lb_noChambre
			// 
			this.lb_noChambre.AutoSize = true;
			this.lb_noChambre.Location = new System.Drawing.Point(214, 142);
			this.lb_noChambre.Name = "lb_noChambre";
			this.lb_noChambre.Size = new System.Drawing.Size(68, 13);
			this.lb_noChambre.TabIndex = 14;
			this.lb_noChambre.Text = "No. chambre";
			// 
			// tb_noChambre
			// 
			this.tb_noChambre.Location = new System.Drawing.Point(288, 139);
			this.tb_noChambre.Name = "tb_noChambre";
			this.tb_noChambre.ReadOnly = true;
			this.tb_noChambre.Size = new System.Drawing.Size(92, 20);
			this.tb_noChambre.TabIndex = 15;
			// 
			// IC_Arrive
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "IC_Arrive";
			this.gb_client.ResumeLayout(false);
			this.gb_client.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lb_noChambre;
		public System.Windows.Forms.TextBox tb_noChambre;
	}
}
