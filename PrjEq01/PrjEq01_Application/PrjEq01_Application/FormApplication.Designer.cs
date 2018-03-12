namespace PrjEq01_Application
{
	partial class FormApplication
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
            this.uc_chambre = new PrjEq01_Application.Tabs.UC_Chambre();
            this.uc_departs = new PrjEq01_Application.Tabs.UC_Departs();
            this.uc_reservation = new PrjEq01_Application.Tabs.UC_Reservation();
            this.uc_arrive = new PrjEq01_Application.Tabs.UC_Arrive();
            this.Tab_Réservations.SuspendLayout();
            this.Tab_Chambres.SuspendLayout();
            this.Tab_Arrivées.SuspendLayout();
            this.Tab_Départs.SuspendLayout();
            this.tc_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Réservations
            // 
            this.Tab_Réservations.Controls.Add(this.uc_reservation);
            this.Tab_Réservations.Location = new System.Drawing.Point(4, 25);
            this.Tab_Réservations.Margin = new System.Windows.Forms.Padding(3);
            this.Tab_Réservations.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Réservations.Size = new System.Drawing.Size(1297, 532);
            // 
            // Tab_Chambres
            // 
            this.Tab_Chambres.Controls.Add(this.uc_chambre);
            this.Tab_Chambres.Location = new System.Drawing.Point(4, 25);
            this.Tab_Chambres.Margin = new System.Windows.Forms.Padding(3);
            this.Tab_Chambres.Size = new System.Drawing.Size(1297, 532);
            // 
            // Tab_Arrivées
            // 
            this.Tab_Arrivées.Controls.Add(this.uc_arrive);
            this.Tab_Arrivées.Location = new System.Drawing.Point(4, 25);
            this.Tab_Arrivées.Margin = new System.Windows.Forms.Padding(3);
            this.Tab_Arrivées.Size = new System.Drawing.Size(1297, 532);
            // 
            // Tab_Départs
            // 
            this.Tab_Départs.Controls.Add(this.uc_departs);
            this.Tab_Départs.Location = new System.Drawing.Point(4, 25);
            this.Tab_Départs.Margin = new System.Windows.Forms.Padding(3);
            this.Tab_Départs.Size = new System.Drawing.Size(1297, 532);
            // 
            // uc_chambre
            // 
            this.uc_chambre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_chambre.Location = new System.Drawing.Point(0, 0);
            this.uc_chambre.Name = "uc_chambre";
            this.uc_chambre.Size = new System.Drawing.Size(1297, 532);
            this.uc_chambre.TabIndex = 0;
            // 
            // uc_departs
            // 
            this.uc_departs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_departs.Location = new System.Drawing.Point(0, 0);
            this.uc_departs.Name = "uc_departs";
            this.uc_departs.Size = new System.Drawing.Size(1297, 532);
            this.uc_departs.TabIndex = 0;
            // 
            // uc_reservation
            // 
            this.uc_reservation.AutoSize = true;
            this.uc_reservation.Location = new System.Drawing.Point(0, 0);
            this.uc_reservation.Margin = new System.Windows.Forms.Padding(2);
            this.uc_reservation.Name = "uc_reservation";
            this.uc_reservation.Size = new System.Drawing.Size(1142, 522);
            this.uc_reservation.TabIndex = 0;
            // 
            // uc_arrive
            // 
            this.uc_arrive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_arrive.Location = new System.Drawing.Point(0, 0);
            this.uc_arrive.Margin = new System.Windows.Forms.Padding(2);
            this.uc_arrive.Name = "uc_arrive";
            this.uc_arrive.Size = new System.Drawing.Size(970, 430);
            this.uc_arrive.TabIndex = 1;
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 490);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.MinimumSize = new System.Drawing.Size(1013, 526);
            this.Name = "FormApplication";
            this.Text = "Hotel Simulator 2018";
            this.Tab_Réservations.ResumeLayout(false);
            this.Tab_Réservations.PerformLayout();
            this.Tab_Chambres.ResumeLayout(false);
            this.Tab_Arrivées.ResumeLayout(false);
            this.Tab_Départs.ResumeLayout(false);
            this.tc_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private Tabs.UC_Reservation uc_reservation;
        private Tabs.UC_Arrive uc_arrive;
        private Tabs.UC_Chambre uc_chambre;
        private Tabs.UC_Departs uc_departs;
    }
}
