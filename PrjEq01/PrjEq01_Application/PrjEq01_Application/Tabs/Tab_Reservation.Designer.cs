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
			this.Name = "Tab_Reservation";
			this.Size = new System.Drawing.Size(971, 430);
			this.Load += new System.EventHandler(this.Tab_Reservation_Load);
			((System.ComponentModel.ISupportInitialize)(this.DS_Master)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_DE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
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
