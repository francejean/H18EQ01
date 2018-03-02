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
			this.components = new System.ComponentModel.Container();
			this.label9 = new System.Windows.Forms.Label();
			this.info_Reservation1 = new PrjEq01_Application.UserControls.Info_Reservation();
			this.saisi_Info_Client1 = new PrjEq01_Application.UserControls.Info_Client();
			this.placeHolderTextBox1 = new PrjEq01_Application.UserControls.PlaceHolderTextBox();
			this.TA_DE = new PrjEq01_Application.DS_MasterTableAdapters.DETableAdapter();
			this.TA_RESERVATION = new PrjEq01_Application.DS_MasterTableAdapters.RESERVATIONTableAdapter();
			this.liste_Chambre1 = new PrjEq01_Application.UserControls.Liste_Chambre();
			this.TA_CHAMBRE = new PrjEq01_Application.DS_MasterTableAdapters.CHAMBRETableAdapter();
			this.DS_Master = new PrjEq01_Application.DS_Master();
			this.BS_CHAMBRE = new System.Windows.Forms.BindingSource(this.components);
			this.BS_DE = new System.Windows.Forms.BindingSource(this.components);
			this.BS_RESERVATION = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.DS_Master)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_DE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(201, 141);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Solde dû";
			// 
			// info_Reservation1
			// 
			this.info_Reservation1.Location = new System.Drawing.Point(371, 0);
			this.info_Reservation1.MaximumSize = new System.Drawing.Size(170, 184);
			this.info_Reservation1.MinimumSize = new System.Drawing.Size(200, 184);
			this.info_Reservation1.Name = "info_Reservation1";
			this.info_Reservation1.Size = new System.Drawing.Size(200, 184);
			this.info_Reservation1.TabIndex = 2;
			// 
			// saisi_Info_Client1
			// 
			this.saisi_Info_Client1.Location = new System.Drawing.Point(0, 0);
			this.saisi_Info_Client1.MinimumSize = new System.Drawing.Size(365, 184);
			this.saisi_Info_Client1.Name = "saisi_Info_Client1";
			this.saisi_Info_Client1.Size = new System.Drawing.Size(365, 184);
			this.saisi_Info_Client1.TabIndex = 1;
			// 
			// placeHolderTextBox1
			// 
			this.placeHolderTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
			this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Gray;
			this.placeHolderTextBox1.Location = new System.Drawing.Point(259, 138);
			this.placeHolderTextBox1.Name = "placeHolderTextBox1";
			this.placeHolderTextBox1.PlaceHolderText = "$0.00";
			this.placeHolderTextBox1.Size = new System.Drawing.Size(100, 20);
			this.placeHolderTextBox1.TabIndex = 18;
			this.placeHolderTextBox1.Text = "$0.00";
			// 
			// TA_DE
			// 
			this.TA_DE.ClearBeforeFill = true;
			// 
			// TA_RESERVATION
			// 
			this.TA_RESERVATION.ClearBeforeFill = true;
			// 
			// liste_Chambre1
			// 
			this.liste_Chambre1.Location = new System.Drawing.Point(3, 190);
			this.liste_Chambre1.MinimumSize = new System.Drawing.Size(850, 230);
			this.liste_Chambre1.Name = "liste_Chambre1";
			this.liste_Chambre1.Size = new System.Drawing.Size(850, 230);
			this.liste_Chambre1.TabIndex = 19;
			// 
			// TA_CHAMBRE
			// 
			this.TA_CHAMBRE.ClearBeforeFill = true;
			// 
			// DS_Master
			// 
			this.DS_Master.DataSetName = "DS_Master";
			this.DS_Master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// Tab_Reservation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.liste_Chambre1);
			this.Controls.Add(this.placeHolderTextBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.info_Reservation1);
			this.Controls.Add(this.saisi_Info_Client1);
			this.Name = "Tab_Reservation";
			this.Size = new System.Drawing.Size(971, 430);
			this.Load += new System.EventHandler(this.Tab_Reservation_Load);
			((System.ComponentModel.ISupportInitialize)(this.DS_Master)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_DE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label9;
		private UserControls.PlaceHolderTextBox placeHolderTextBox1;
        private UserControls.Info_Client saisi_Info_Client1;
        private UserControls.Info_Reservation info_Reservation1;
		private DS_MasterTableAdapters.DETableAdapter TA_DE;
		private DS_MasterTableAdapters.RESERVATIONTableAdapter TA_RESERVATION;
		private UserControls.Liste_Chambre liste_Chambre1;
		private DS_MasterTableAdapters.CHAMBRETableAdapter TA_CHAMBRE;
		private DS_Master DS_Master;
		private System.Windows.Forms.BindingSource BS_CHAMBRE;
		private System.Windows.Forms.BindingSource BS_DE;
		private System.Windows.Forms.BindingSource BS_RESERVATION;
	}
}
