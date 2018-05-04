namespace PrjEq01_Application.UserControls
{
	partial class IC_Base
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IC_Base));
			this.gb_client = new System.Windows.Forms.GroupBox();
			this.dtp_datExp = new System.Windows.Forms.DateTimePicker();
			this.bt_list = new PrjEq01_CommonForm.Controls.Button_List();
			this.tb_noCarte = new System.Windows.Forms.TextBox();
			this.lb_noCarte = new System.Windows.Forms.Label();
			this.tb_nomClient = new System.Windows.Forms.TextBox();
			this.lb_nom = new System.Windows.Forms.Label();
			this.tb_typeCarte = new System.Windows.Forms.TextBox();
			this.lb_typeCarte = new System.Windows.Forms.Label();
			this.tb_telephone = new System.Windows.Forms.TextBox();
			this.tb_adresse = new System.Windows.Forms.TextBox();
			this.tb_noClient = new System.Windows.Forms.TextBox();
			this.lb_expiration = new System.Windows.Forms.Label();
			this.lb_telephone = new System.Windows.Forms.Label();
			this.lb_addresse = new System.Windows.Forms.Label();
			this.lb_noClient = new System.Windows.Forms.Label();
			this.ds_master = new PrjEq01_Application.DS_Master();
			this.TA_CLIENT = new PrjEq01_Application.DS_MasterTableAdapters.CLIENTTableAdapter();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.gb_client.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// gb_client
			// 
			this.gb_client.Controls.Add(this.dtp_datExp);
			this.gb_client.Controls.Add(this.bt_list);
			this.gb_client.Controls.Add(this.tb_noCarte);
			this.gb_client.Controls.Add(this.lb_noCarte);
			this.gb_client.Controls.Add(this.tb_nomClient);
			this.gb_client.Controls.Add(this.lb_nom);
			this.gb_client.Controls.Add(this.tb_typeCarte);
			this.gb_client.Controls.Add(this.lb_typeCarte);
			this.gb_client.Controls.Add(this.tb_telephone);
			this.gb_client.Controls.Add(this.tb_adresse);
			this.gb_client.Controls.Add(this.tb_noClient);
			this.gb_client.Controls.Add(this.lb_expiration);
			this.gb_client.Controls.Add(this.lb_telephone);
			this.gb_client.Controls.Add(this.lb_addresse);
			this.gb_client.Controls.Add(this.lb_noClient);
			this.gb_client.Location = new System.Drawing.Point(0, 0);
			this.gb_client.Name = "gb_client";
			this.gb_client.Size = new System.Drawing.Size(405, 190);
			this.gb_client.TabIndex = 1;
			this.gb_client.TabStop = false;
			this.gb_client.Text = "Informations du client";
			// 
			// dtp_datExp
			// 
			this.dtp_datExp.Enabled = false;
			this.dtp_datExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_datExp.Location = new System.Drawing.Point(87, 139);
			this.dtp_datExp.Name = "dtp_datExp";
			this.dtp_datExp.Size = new System.Drawing.Size(100, 20);
			this.dtp_datExp.TabIndex = 14;
			// 
			// bt_list
			// 
			this.bt_list.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_list.BackgroundImage")));
			this.bt_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bt_list.Enabled = false;
			this.bt_list.Location = new System.Drawing.Point(380, 10);
			this.bt_list.Margin = new System.Windows.Forms.Padding(2);
			this.bt_list.Name = "bt_list";
			this.bt_list.Size = new System.Drawing.Size(20, 20);
			this.bt_list.TabIndex = 1;
			this.bt_list.UseVisualStyleBackColor = true;
			this.bt_list.Click += new System.EventHandler(this.bt_list_Click);
			// 
			// tb_noCarte
			// 
			this.tb_noCarte.Location = new System.Drawing.Point(272, 113);
			this.tb_noCarte.Name = "tb_noCarte";
			this.tb_noCarte.ReadOnly = true;
			this.tb_noCarte.Size = new System.Drawing.Size(108, 20);
			this.tb_noCarte.TabIndex = 13;
			// 
			// lb_noCarte
			// 
			this.lb_noCarte.AutoSize = true;
			this.lb_noCarte.Location = new System.Drawing.Point(214, 116);
			this.lb_noCarte.Name = "lb_noCarte";
			this.lb_noCarte.Size = new System.Drawing.Size(52, 13);
			this.lb_noCarte.TabIndex = 12;
			this.lb_noCarte.Text = "No. Carte";
			// 
			// tb_nomClient
			// 
			this.tb_nomClient.Location = new System.Drawing.Point(272, 35);
			this.tb_nomClient.Name = "tb_nomClient";
			this.tb_nomClient.ReadOnly = true;
			this.tb_nomClient.Size = new System.Drawing.Size(108, 20);
			this.tb_nomClient.TabIndex = 11;
			// 
			// lb_nom
			// 
			this.lb_nom.AutoSize = true;
			this.lb_nom.Location = new System.Drawing.Point(214, 38);
			this.lb_nom.Name = "lb_nom";
			this.lb_nom.Size = new System.Drawing.Size(29, 13);
			this.lb_nom.TabIndex = 10;
			this.lb_nom.Text = "Nom";
			// 
			// tb_typeCarte
			// 
			this.tb_typeCarte.Location = new System.Drawing.Point(87, 113);
			this.tb_typeCarte.Name = "tb_typeCarte";
			this.tb_typeCarte.ReadOnly = true;
			this.tb_typeCarte.Size = new System.Drawing.Size(100, 20);
			this.tb_typeCarte.TabIndex = 9;
			// 
			// lb_typeCarte
			// 
			this.lb_typeCarte.AutoSize = true;
			this.lb_typeCarte.Location = new System.Drawing.Point(7, 116);
			this.lb_typeCarte.Name = "lb_typeCarte";
			this.lb_typeCarte.Size = new System.Drawing.Size(74, 13);
			this.lb_typeCarte.TabIndex = 8;
			this.lb_typeCarte.Text = "Type de Carte";
			// 
			// tb_telephone
			// 
			this.tb_telephone.Location = new System.Drawing.Point(87, 87);
			this.tb_telephone.Name = "tb_telephone";
			this.tb_telephone.ReadOnly = true;
			this.tb_telephone.Size = new System.Drawing.Size(100, 20);
			this.tb_telephone.TabIndex = 6;
			// 
			// tb_adresse
			// 
			this.tb_adresse.Location = new System.Drawing.Point(87, 61);
			this.tb_adresse.Name = "tb_adresse";
			this.tb_adresse.ReadOnly = true;
			this.tb_adresse.Size = new System.Drawing.Size(293, 20);
			this.tb_adresse.TabIndex = 5;
			// 
			// tb_noClient
			// 
			this.tb_noClient.Location = new System.Drawing.Point(87, 35);
			this.tb_noClient.Name = "tb_noClient";
			this.tb_noClient.ReadOnly = true;
			this.tb_noClient.Size = new System.Drawing.Size(100, 20);
			this.tb_noClient.TabIndex = 1;
			// 
			// lb_expiration
			// 
			this.lb_expiration.AutoSize = true;
			this.lb_expiration.Location = new System.Drawing.Point(7, 142);
			this.lb_expiration.Name = "lb_expiration";
			this.lb_expiration.Size = new System.Drawing.Size(53, 13);
			this.lb_expiration.TabIndex = 4;
			this.lb_expiration.Text = "Expiration";
			// 
			// lb_telephone
			// 
			this.lb_telephone.AutoSize = true;
			this.lb_telephone.Location = new System.Drawing.Point(7, 90);
			this.lb_telephone.Name = "lb_telephone";
			this.lb_telephone.Size = new System.Drawing.Size(58, 13);
			this.lb_telephone.TabIndex = 2;
			this.lb_telephone.Text = "Téléphone";
			// 
			// lb_addresse
			// 
			this.lb_addresse.AutoSize = true;
			this.lb_addresse.Location = new System.Drawing.Point(7, 64);
			this.lb_addresse.Name = "lb_addresse";
			this.lb_addresse.Size = new System.Drawing.Size(45, 13);
			this.lb_addresse.TabIndex = 1;
			this.lb_addresse.Text = "Adresse";
			// 
			// lb_noClient
			// 
			this.lb_noClient.AutoSize = true;
			this.lb_noClient.Location = new System.Drawing.Point(7, 38);
			this.lb_noClient.Name = "lb_noClient";
			this.lb_noClient.Size = new System.Drawing.Size(53, 13);
			this.lb_noClient.TabIndex = 0;
			this.lb_noClient.Text = "No. Client";
			// 
			// ds_master
			// 
			this.ds_master.DataSetName = "DS_Master";
			this.ds_master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// TA_CLIENT
			// 
			this.TA_CLIENT.ClearBeforeFill = true;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// IC_Base
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gb_client);
			this.MinimumSize = new System.Drawing.Size(408, 190);
			this.Name = "IC_Base";
			this.Size = new System.Drawing.Size(408, 190);
			this.gb_client.ResumeLayout(false);
			this.gb_client.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.TextBox tb_noCarte;
		public System.Windows.Forms.TextBox tb_nomClient;
		public System.Windows.Forms.TextBox tb_typeCarte;
		public System.Windows.Forms.TextBox tb_telephone;
		public System.Windows.Forms.TextBox tb_noClient;
		private System.Windows.Forms.Label lb_noCarte;
		private System.Windows.Forms.Label lb_nom;
		private System.Windows.Forms.Label lb_typeCarte;
		private System.Windows.Forms.Label lb_expiration;
		private System.Windows.Forms.Label lb_telephone;
		private System.Windows.Forms.Label lb_addresse;
		private System.Windows.Forms.Label lb_noClient;
		public System.Windows.Forms.TextBox tb_adresse;
		public System.Windows.Forms.GroupBox gb_client;
		public PrjEq01_CommonForm.Controls.Button_List bt_list;
		protected DS_Master ds_master;
		private DS_MasterTableAdapters.CLIENTTableAdapter TA_CLIENT;
		public System.Windows.Forms.DateTimePicker dtp_datExp;
		protected System.Windows.Forms.ErrorProvider errorProvider;
	}
}
