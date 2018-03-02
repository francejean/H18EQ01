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
			this.tab_Arrive1 = new PrjEq01_Application.Tabs.Tab_Arrive();
			this.tab_Reservation1 = new PrjEq01_Application.Tabs.Tab_Reservation();
			this.Tab_Réservations.SuspendLayout();
			this.Tab_Arrivées.SuspendLayout();
			this.SuspendLayout();
			// 
			// Tab_Réservations
			// 
			this.Tab_Réservations.Controls.Add(this.tab_Reservation1);
			this.Tab_Réservations.Location = new System.Drawing.Point(4, 22);
			this.Tab_Réservations.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.Tab_Réservations.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.Tab_Réservations.Size = new System.Drawing.Size(971, 430);
			// 
			// Tab_Chambres
			// 
			this.Tab_Chambres.Location = new System.Drawing.Point(4, 22);
			this.Tab_Chambres.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.Tab_Chambres.Size = new System.Drawing.Size(971, 430);
			// 
			// Tab_Arrivées
			// 
			this.Tab_Arrivées.Controls.Add(this.tab_Arrive1);
			this.Tab_Arrivées.Location = new System.Drawing.Point(4, 22);
			this.Tab_Arrivées.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.Tab_Arrivées.Size = new System.Drawing.Size(971, 430);
			// 
			// Tab_Départs
			// 
			this.Tab_Départs.Location = new System.Drawing.Point(4, 22);
			this.Tab_Départs.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.Tab_Départs.Size = new System.Drawing.Size(971, 430);
			// 
			// tab_Arrive1
			// 
			this.tab_Arrive1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tab_Arrive1.Location = new System.Drawing.Point(0, 0);
			this.tab_Arrive1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tab_Arrive1.Name = "tab_Arrive1";
			this.tab_Arrive1.Size = new System.Drawing.Size(970, 430);
			this.tab_Arrive1.TabIndex = 1;
			// 
			// tab_Reservation1
			// 
			this.tab_Reservation1.AutoSize = true;
			this.tab_Reservation1.Location = new System.Drawing.Point(0, 0);
			this.tab_Reservation1.Name = "tab_Reservation1";
			this.tab_Reservation1.Size = new System.Drawing.Size(856, 430);
			this.tab_Reservation1.TabIndex = 0;
			// 
			// FormApplication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 490);
			this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.MinimumSize = new System.Drawing.Size(1013, 526);
			this.Name = "FormApplication";
			this.Text = "Hotel Simulator 2018";
			this.Tab_Réservations.ResumeLayout(false);
			this.Tab_Réservations.PerformLayout();
			this.Tab_Arrivées.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion
        private Tabs.Tab_Arrive tab_Arrive1;
		private Tabs.Tab_Reservation tab_Reservation1;
	}
}
