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
            this.label4 = new System.Windows.Forms.Label();
            this.tb_noChambre = new System.Windows.Forms.TextBox();
            this.gb_client.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_noCarte
            // 
            this.tb_noCarte.ReadOnly = true;
            // 
            // tb_nomClient
            // 
            this.tb_nomClient.ReadOnly = true;
            // 
            // tb_typeCarte
            // 
            this.tb_typeCarte.ReadOnly = true;
            // 
            // tb_expiration
            // 
            this.tb_expiration.ReadOnly = true;
            // 
            // tb_telephone
            // 
            this.tb_telephone.ReadOnly = true;
            // 
            // tb_noClient
            // 
            this.tb_noClient.ReadOnly = true;
            // 
            // tb_adresse
            // 
            this.tb_adresse.ReadOnly = true;
            // 
            // gb_client
            // 
            this.gb_client.Controls.Add(this.tb_noChambre);
            this.gb_client.Controls.Add(this.label4);
            this.gb_client.Controls.SetChildIndex(this.tb_noClient, 0);
            this.gb_client.Controls.SetChildIndex(this.tb_adresse, 0);
            this.gb_client.Controls.SetChildIndex(this.tb_telephone, 0);
            this.gb_client.Controls.SetChildIndex(this.tb_expiration, 0);
            this.gb_client.Controls.SetChildIndex(this.tb_typeCarte, 0);
            this.gb_client.Controls.SetChildIndex(this.tb_nomClient, 0);
            this.gb_client.Controls.SetChildIndex(this.tb_noCarte, 0);
            this.gb_client.Controls.SetChildIndex(this.label4, 0);
            this.gb_client.Controls.SetChildIndex(this.tb_noChambre, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "No. chambre";
            // 
            // tb_noChambre
            // 
            this.tb_noChambre.Location = new System.Drawing.Point(278, 139);
            this.tb_noChambre.Name = "tb_noChambre";
            this.tb_noChambre.ReadOnly = true;
            this.tb_noChambre.Size = new System.Drawing.Size(81, 20);
            this.tb_noChambre.TabIndex = 15;
            // 
            // IC_Arrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "IC_Arrive";
            this.gb_client.ResumeLayout(false);
            this.gb_client.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox tb_noChambre;
	}
}
