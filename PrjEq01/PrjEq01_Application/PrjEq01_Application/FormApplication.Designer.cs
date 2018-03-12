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
            this.tab_Chambre1 = new PrjEq01_Application.Tabs.Tab_Chambre();
            this.tab_Departs1 = new PrjEq01_Application.Tabs.Tab_Departs();
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
            this.Tab_Réservations.Margin = new System.Windows.Forms.Padding(3);
            this.Tab_Réservations.Padding = new System.Windows.Forms.Padding(3);
            // 
            // Tab_Chambres
            // 
            this.Tab_Chambres.Controls.Add(this.tab_Chambre1);
            this.Tab_Chambres.Margin = new System.Windows.Forms.Padding(3);
            // 
            // Tab_Arrivées
            // 
            this.Tab_Arrivées.Controls.Add(this.uc_arrive);
            this.Tab_Arrivées.Margin = new System.Windows.Forms.Padding(3);
            // 
            // Tab_Départs
            // 
            this.Tab_Départs.Controls.Add(this.tab_Departs1);
            this.Tab_Départs.Margin = new System.Windows.Forms.Padding(3);
            // 
            // uc_reservation
            // 
            this.uc_reservation.AutoSize = true;
            this.uc_reservation.Location = new System.Drawing.Point(0, 0);
            this.uc_reservation.Margin = new System.Windows.Forms.Padding(2);
            this.uc_reservation.Name = "uc_reservation";
            this.uc_reservation.Size = new System.Drawing.Size(856, 423);
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
            // tab_Chambre1
            // 
            this.tab_Chambre1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Chambre1.Location = new System.Drawing.Point(0, 0);
            this.tab_Chambre1.Name = "tab_Chambre1";
            this.tab_Chambre1.Size = new System.Drawing.Size(1297, 532);
            this.tab_Chambre1.TabIndex = 0;
            // 
            // tab_Departs1
            // 
            this.tab_Departs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Departs1.Location = new System.Drawing.Point(0, 0);
            this.tab_Departs1.Name = "tab_Departs1";
            this.tab_Departs1.Size = new System.Drawing.Size(1297, 532);
            this.tab_Departs1.TabIndex = 0;
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
        private Tabs.Tab_Chambre tab_Chambre1;
        private Tabs.Tab_Departs tab_Departs1;
    }
}
