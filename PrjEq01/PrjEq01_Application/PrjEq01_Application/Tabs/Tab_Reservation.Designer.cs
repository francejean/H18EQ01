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
            this.info_Reservation1 = new PrjEq01_Application.UserControls.Info_Reservation();
            this.saisi_Info_Client1 = new PrjEq01_Application.UserControls.Saisi_Info_Client();
            this.placeHolderTextBox1 = new PrjEq01_Application.UserControls.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Solde dû";
            // 
            // info_Reservation1
            // 
            this.info_Reservation1.Location = new System.Drawing.Point(374, 7);
            this.info_Reservation1.MaximumSize = new System.Drawing.Size(170, 180);
            this.info_Reservation1.MinimumSize = new System.Drawing.Size(200, 180);
            this.info_Reservation1.Name = "info_Reservation1";
            this.info_Reservation1.Size = new System.Drawing.Size(200, 180);
            this.info_Reservation1.TabIndex = 2;
            // 
            // saisi_Info_Client1
            // 
            this.saisi_Info_Client1.Location = new System.Drawing.Point(3, 3);
            this.saisi_Info_Client1.MinimumSize = new System.Drawing.Size(365, 184);
            this.saisi_Info_Client1.Name = "saisi_Info_Client1";
            this.saisi_Info_Client1.Size = new System.Drawing.Size(365, 184);
            this.saisi_Info_Client1.TabIndex = 1;
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(256, 155);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "$0.00";
            this.placeHolderTextBox1.Size = new System.Drawing.Size(100, 20);
            this.placeHolderTextBox1.TabIndex = 18;
            this.placeHolderTextBox1.Text = "$0.00";
            // 
            // Tab_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.placeHolderTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.info_Reservation1);
            this.Controls.Add(this.saisi_Info_Client1);
            this.Name = "Tab_Reservation";
            this.Size = new System.Drawing.Size(971, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private UserControls.Saisi_Info_Client saisi_Info_Client1;
		private UserControls.Info_Reservation info_Reservation1;
		private System.Windows.Forms.Label label9;
		private UserControls.PlaceHolderTextBox placeHolderTextBox1;
	}
}
