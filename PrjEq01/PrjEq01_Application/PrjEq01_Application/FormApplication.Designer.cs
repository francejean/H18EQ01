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
            this.tab_Reservation1 = new PrjEq01_Application.Tabs.Tab_Reservation();
            this.tab_Arrive1 = new PrjEq01_Application.Tabs.Tab_Arrive();
            this.Tab_Réservations.SuspendLayout();
            this.Tab_Arrivées.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Réservations
            // 
            this.Tab_Réservations.Controls.Add(this.tab_Reservation1);
            this.Tab_Réservations.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_Réservations.Padding = new System.Windows.Forms.Padding(4);
            // 
            // Tab_Chambres
            // 
            this.Tab_Chambres.Margin = new System.Windows.Forms.Padding(4);
            // 
            // Tab_Arrivées
            // 
            this.Tab_Arrivées.Controls.Add(this.tab_Arrive1);
            this.Tab_Arrivées.Margin = new System.Windows.Forms.Padding(4);
            // 
            // Tab_Départs
            // 
            this.Tab_Départs.Margin = new System.Windows.Forms.Padding(4);
            // 
            // tab_Reservation1
            // 
            this.tab_Reservation1.AutoSize = true;
            this.tab_Reservation1.Location = new System.Drawing.Point(0, 0);
            this.tab_Reservation1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Reservation1.Name = "tab_Reservation1";
            this.tab_Reservation1.Size = new System.Drawing.Size(1027, 430);
            this.tab_Reservation1.TabIndex = 0;
            // 
            // tab_Arrive1
            // 
            this.tab_Arrive1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Arrive1.Location = new System.Drawing.Point(0, 0);
            this.tab_Arrive1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Arrive1.Name = "tab_Arrive1";
            this.tab_Arrive1.Size = new System.Drawing.Size(1294, 529);
            this.tab_Arrive1.TabIndex = 1;
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 603);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1345, 639);
            this.Name = "FormApplication";
            this.Text = "Hotel Simulator 2018";
            this.Tab_Réservations.ResumeLayout(false);
            this.Tab_Réservations.PerformLayout();
            this.Tab_Arrivées.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private Tabs.Tab_Reservation tab_Reservation1;
        private Tabs.Tab_Arrive tab_Arrive1;
    }
}
