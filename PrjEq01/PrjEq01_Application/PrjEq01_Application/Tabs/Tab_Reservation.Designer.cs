namespace PrjEq01_Application.Tabs
{
	partial class Tab_Reservation
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

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.label9 = new System.Windows.Forms.Label();
            this.placeHolderTextBox1 = new PrjEq01_Application.UserControls.PlaceHolderTextBox();
            this.saisi_Info_Client1 = new PrjEq01_Application.UserControls.Saisi_Info_Client();
            this.info_Reservation1 = new PrjEq01_Application.UserControls.Info_Reservation();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Solde dû";
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(349, 174);
            this.placeHolderTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "$0.00";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(132, 23);
            this.placeHolderTextBox1.TabIndex = 18;
            this.placeHolderTextBox1.Text = "$0.00";
            // 
            // saisi_Info_Client1
            // 
            this.saisi_Info_Client1.Location = new System.Drawing.Point(4, 4);
            this.saisi_Info_Client1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saisi_Info_Client1.MinimumSize = new System.Drawing.Size(487, 234);
            this.saisi_Info_Client1.Name = "saisi_Info_Client1";
            this.saisi_Info_Client1.Size = new System.Drawing.Size(487, 234);
            this.saisi_Info_Client1.TabIndex = 19;
            // 
            // info_Reservation1
            // 
            this.info_Reservation1.Location = new System.Drawing.Point(499, 4);
            this.info_Reservation1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.info_Reservation1.MinimumSize = new System.Drawing.Size(267, 234);
            this.info_Reservation1.Name = "info_Reservation1";
            this.info_Reservation1.Size = new System.Drawing.Size(267, 234);
            this.info_Reservation1.TabIndex = 20;
            // 
            // Tab_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.info_Reservation1);
            this.Controls.Add(this.placeHolderTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.saisi_Info_Client1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tab_Reservation";
            this.Size = new System.Drawing.Size(1295, 562);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label9;
		private UserControls.PlaceHolderTextBox placeHolderTextBox1;
        private UserControls.Saisi_Info_Client saisi_Info_Client1;
        private UserControls.Info_Reservation info_Reservation1;
    }
}
