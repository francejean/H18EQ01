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
			this.ir_Reserv = new PrjEq01_Application.UserControls.Info_Reservation.IR_Reserv();
			this.lc_reserv = new PrjEq01_Application.UserControls.Liste_Chambre.LC_Reserv();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.TA_BK_CHAMBRE = new PrjEq01_Application.DS_MasterTableAdapters.BK_CHAMBRETableAdapter();
			this.TA_TRX = new PrjEq01_Application.DS_MasterTableAdapters.TRXTableAdapter();
			this.TA_ARRIVE = new PrjEq01_Application.DS_MasterTableAdapters.ARRIVETableAdapter();
			this.TA_DEPART = new PrjEq01_Application.DS_MasterTableAdapters.DEPARTTableAdapter();
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
			this.ic_Reserv.BS = null;
			this.ic_Reserv.ClientSelected = null;
			this.ic_Reserv.Location = new System.Drawing.Point(3, 3);
			this.ic_Reserv.MinimumSize = new System.Drawing.Size(365, 190);
			this.ic_Reserv.Name = "ic_Reserv";
			this.ic_Reserv.Size = new System.Drawing.Size(408, 190);
			this.ic_Reserv.TabIndex = 22;
			// 
			// ir_Reserv
			// 
			this.ir_Reserv.BS = null;
			this.ir_Reserv.Location = new System.Drawing.Point(417, 3);
			this.ir_Reserv.MinimumSize = new System.Drawing.Size(200, 190);
			this.ir_Reserv.Name = "ir_Reserv";
			this.ir_Reserv.ReservSelected = null;
			this.ir_Reserv.Size = new System.Drawing.Size(224, 190);
			this.ir_Reserv.TabIndex = 21;
			// 
			// lc_reserv
			// 
			this.lc_reserv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lc_reserv.BeforeSelection = null;
			this.lc_reserv.Location = new System.Drawing.Point(3, 199);
			this.lc_reserv.MinimumSize = new System.Drawing.Size(850, 230);
			this.lc_reserv.Name = "lc_reserv";
			this.lc_reserv.OnSelected = null;
			this.lc_reserv.Size = new System.Drawing.Size(967, 233);
			this.lc_reserv.TabIndex = 23;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// TA_BK_CHAMBRE
			// 
			this.TA_BK_CHAMBRE.ClearBeforeFill = true;
			// 
			// TA_TRX
			// 
			this.TA_TRX.ClearBeforeFill = true;
			// 
			// TA_ARRIVE
			// 
			this.TA_ARRIVE.ClearBeforeFill = true;
			// 
			// TA_DEPART
			// 
			this.TA_DEPART.ClearBeforeFill = true;
			// 
			// UC_Reservation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.lc_reserv);
			this.Controls.Add(this.ic_Reserv);
			this.Controls.Add(this.ir_Reserv);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UC_Reservation";
			this.Size = new System.Drawing.Size(973, 432);
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
		private UserControls.Info_Reservation.IR_Reserv ir_Reserv;
		private UserControls.Info_Client.IC_Reserv ic_Reserv;
		private System.Windows.Forms.BindingSource BS_CLIENT;
		private DS_MasterTableAdapters.CLIENTTableAdapter TA_CLIENT;
		private UserControls.Liste_Chambre.LC_Reserv lc_reserv;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private DS_MasterTableAdapters.BK_CHAMBRETableAdapter TA_BK_CHAMBRE;
		private DS_MasterTableAdapters.TRXTableAdapter TA_TRX;
		private DS_MasterTableAdapters.ARRIVETableAdapter TA_ARRIVE;
		private DS_MasterTableAdapters.DEPARTTableAdapter TA_DEPART;
	}
}
