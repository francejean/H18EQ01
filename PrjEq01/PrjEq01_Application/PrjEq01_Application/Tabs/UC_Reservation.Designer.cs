namespace PrjEq01_Application.Tabs
{
	partial class UC_Reservation
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
			this.TA_CHAMBRE = new PrjEq01_Application.DS_MasterTableAdapters.CHAMBRETableAdapter();
			this.DS_Master = new PrjEq01_Application.DS_Master();
			this.BS_CHAMBRE = new System.Windows.Forms.BindingSource(this.components);
			this.BS_DE = new System.Windows.Forms.BindingSource(this.components);
			this.BS_RESERVATION = new System.Windows.Forms.BindingSource(this.components);
			this.BS_CLIENT = new System.Windows.Forms.BindingSource(this.components);
			this.TA_CLIENT = new PrjEq01_Application.DS_MasterTableAdapters.CLIENTTableAdapter();
			this.ic_Reserv = new PrjEq01_Application.UserControls.Info_Client.IC_Reserv();
			this.ir_Base = new PrjEq01_Application.UserControls.IR_Base();
			this.lc_chambre = new PrjEq01_Application.UserControls.Liste_Chambre.LC_Reserv();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.DS_Master)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_DE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
			// TA_CHAMBRE
			// 
			this.TA_CHAMBRE.ClearBeforeFill = true;
			// 
			// DS_Master
			// 
			this.DS_Master.DataSetName = "DS_Master";
			this.DS_Master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// TA_CLIENT
			// 
			this.TA_CLIENT.ClearBeforeFill = true;
			// 
			// ic_Reserv
			// 
			this.ic_Reserv.ClientSelected = null;
			this.ic_Reserv.Location = new System.Drawing.Point(3, 3);
			this.ic_Reserv.MinimumSize = new System.Drawing.Size(365, 190);
			this.ic_Reserv.Name = "ic_Reserv";
			this.ic_Reserv.Size = new System.Drawing.Size(395, 190);
			this.ic_Reserv.TabIndex = 22;
			// 
			// ir_Base
			// 
			this.ir_Base.BS = null;
			this.ir_Base.Location = new System.Drawing.Point(404, 3);
			this.ir_Base.MinimumSize = new System.Drawing.Size(200, 190);
			this.ir_Base.Name = "ir_Base";
			this.ir_Base.ReservSelected = null;
			this.ir_Base.Size = new System.Drawing.Size(200, 190);
			this.ir_Base.TabIndex = 21;
			// 
			// lc_chambre
			// 
			this.lc_chambre.Location = new System.Drawing.Point(3, 199);
			this.lc_chambre.MinimumSize = new System.Drawing.Size(850, 230);
			this.lc_chambre.Name = "lc_chambre";
			this.lc_chambre.Size = new System.Drawing.Size(951, 256);
			this.lc_chambre.TabIndex = 23;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// UC_Reservation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.lc_chambre);
			this.Controls.Add(this.ic_Reserv);
			this.Controls.Add(this.ir_Base);
			this.Name = "UC_Reservation";
			this.Size = new System.Drawing.Size(971, 458);
			this.Load += new System.EventHandler(this.Tab_Reservation_Load);
			((System.ComponentModel.ISupportInitialize)(this.DS_Master)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_DE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DS_MasterTableAdapters.DETableAdapter TA_DE;
		private DS_MasterTableAdapters.RESERVATIONTableAdapter TA_RESERVATION;
		private DS_MasterTableAdapters.CHAMBRETableAdapter TA_CHAMBRE;
		private DS_Master DS_Master;
		private System.Windows.Forms.BindingSource BS_CHAMBRE;
		private System.Windows.Forms.BindingSource BS_DE;
		private System.Windows.Forms.BindingSource BS_RESERVATION;
		private UserControls.IR_Base ir_Base;
		private UserControls.Info_Client.IC_Reserv ic_Reserv;
		private System.Windows.Forms.BindingSource BS_CLIENT;
		private DS_MasterTableAdapters.CLIENTTableAdapter TA_CLIENT;
		private UserControls.Liste_Chambre.LC_Reserv lc_chambre;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
