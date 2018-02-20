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
        this.Tab_Arrivées.SuspendLayout();
        this.Tab_Réservations.SuspendLayout();
        this.SuspendLayout();
        // 
        // Tab_Réservations
        // 
        this.Tab_Réservations.Controls.Add(this.tab_Reservation1);
        // 
        // tab_Reservation1
        // 
        this.tab_Reservation1.Location = new System.Drawing.Point(0, 0);
        this.tab_Reservation1.Name = "tab_Reservation1";
        this.tab_Reservation1.Size = new System.Drawing.Size(971, 430);
        this.tab_Reservation1.TabIndex = 0;
        // 
        // Tab_Arrivées
        // 
        this.Tab_Arrivées.Controls.Add(this.tab_Arrive1);
        // 
        // tab_Arrive1
        // 
        this.tab_Arrive1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.tab_Arrive1.Location = new System.Drawing.Point(3, 3);
        this.tab_Arrive1.Name = "tab_Arrive1";
        this.tab_Arrive1.Size = new System.Drawing.Size(1291, 526);
        this.tab_Arrive1.TabIndex = 1;
        // 
        // FormApplication
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1329, 603);
        this.Name = "FormApplication";
        this.Text = "Hotel Simulator 2018";
        this.Tab_Arrivées.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
		}

        #endregion

        private Tabs.Tab_Reservation tab_Reservation1;
        private Tabs.Tab_Arrive tab_Arrive1;
    }
}
