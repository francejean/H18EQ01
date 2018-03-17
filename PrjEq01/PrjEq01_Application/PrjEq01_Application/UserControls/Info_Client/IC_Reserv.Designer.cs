namespace PrjEq01_Application.UserControls.Info_Client
{
	partial class IC_Reserv
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

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.label4 = new System.Windows.Forms.Label();
			this.tb_solde = new System.Windows.Forms.MaskedTextBox();
			this.gb_client.SuspendLayout();
			this.SuspendLayout();
			// 
			// gb_client
			// 
			this.gb_client.Controls.Add(this.tb_solde);
			this.gb_client.Controls.Add(this.label4);
			this.gb_client.Controls.SetChildIndex(this.label4, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_solde, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_noClient, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_adresse, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_telephone, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_expiration, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_typeCarte, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_nomClient, 0);
			this.gb_client.Controls.SetChildIndex(this.tb_noCarte, 0);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(201, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Solde dû";
			// 
			// tb_solde
			// 
			this.tb_solde.Location = new System.Drawing.Point(259, 139);
			this.tb_solde.Mask = "000.00$";
			this.tb_solde.Name = "tb_solde";
			this.tb_solde.Size = new System.Drawing.Size(100, 20);
			this.tb_solde.TabIndex = 17;
			this.tb_solde.Text = "00000";
			// 
			// IC_Reserv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "IC_Reserv";
			this.gb_client.ResumeLayout(false);
			this.gb_client.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.MaskedTextBox tb_solde;
	}
}
