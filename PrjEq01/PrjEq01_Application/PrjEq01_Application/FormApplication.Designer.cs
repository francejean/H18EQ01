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
            this.Tab_Départs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Départs
            // 
            this.Tab_Départs.Controls.Add(this.tab_Arrive1);
            // 
            // tab_Arrive1
            // 
            this.tab_Arrive1.Location = new System.Drawing.Point(3, 3);
            this.tab_Arrive1.Name = "tab_Arrive1";
            this.tab_Arrive1.Size = new System.Drawing.Size(1291, 526);
            this.tab_Arrive1.TabIndex = 0;
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 603);
            this.Name = "FormApplication";
            this.Text = "Hotel Simulator 2018";
            this.Tab_Départs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private Tabs.Tab_Arrive tab_Arrive1;
    }
}

