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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IC_Base));
            this.gb_client = new System.Windows.Forms.GroupBox();
            this.bt_list = new PrjEq01_CommonForm.Controls.Button_List();
            this.tb_noCarte = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_nomClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_typeCarte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_expiration = new System.Windows.Forms.TextBox();
            this.tb_telephone = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_noClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_client.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_client
            // 
            this.gb_client.Controls.Add(this.bt_list);
            this.gb_client.Controls.Add(this.tb_noCarte);
            this.gb_client.Controls.Add(this.label8);
            this.gb_client.Controls.Add(this.tb_nomClient);
            this.gb_client.Controls.Add(this.label7);
            this.gb_client.Controls.Add(this.tb_typeCarte);
            this.gb_client.Controls.Add(this.label6);
            this.gb_client.Controls.Add(this.tb_expiration);
            this.gb_client.Controls.Add(this.tb_telephone);
            this.gb_client.Controls.Add(this.tb_adresse);
            this.gb_client.Controls.Add(this.tb_noClient);
            this.gb_client.Controls.Add(this.label5);
            this.gb_client.Controls.Add(this.label3);
            this.gb_client.Controls.Add(this.label2);
            this.gb_client.Controls.Add(this.label1);
            this.gb_client.Location = new System.Drawing.Point(0, 0);
            this.gb_client.Name = "gb_client";
            this.gb_client.Size = new System.Drawing.Size(365, 190);
            this.gb_client.TabIndex = 1;
            this.gb_client.TabStop = false;
            this.gb_client.Text = "Informations du client";
            // 
            // bt_list
            // 
            this.bt_list.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_list.BackgroundImage")));
            this.bt_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_list.Location = new System.Drawing.Point(339, 10);
            this.bt_list.Margin = new System.Windows.Forms.Padding(2);
            this.bt_list.Name = "bt_list";
            this.bt_list.Size = new System.Drawing.Size(20, 20);
            this.bt_list.TabIndex = 1;
            this.bt_list.UseVisualStyleBackColor = true;
            this.bt_list.Click += new System.EventHandler(this.bt_list_Click);
            // 
            // tb_noCarte
            // 
            this.tb_noCarte.Location = new System.Drawing.Point(259, 113);
            this.tb_noCarte.Name = "tb_noCarte";
            this.tb_noCarte.ReadOnly = true;
            this.tb_noCarte.Size = new System.Drawing.Size(100, 20);
            this.tb_noCarte.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "No. Carte";
            // 
            // tb_nomClient
            // 
            this.tb_nomClient.Location = new System.Drawing.Point(259, 35);
            this.tb_nomClient.Name = "tb_nomClient";
            this.tb_nomClient.ReadOnly = true;
            this.tb_nomClient.Size = new System.Drawing.Size(100, 20);
            this.tb_nomClient.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nom";
            // 
            // tb_typeCarte
            // 
            this.tb_typeCarte.Location = new System.Drawing.Point(87, 113);
            this.tb_typeCarte.Name = "tb_typeCarte";
            this.tb_typeCarte.ReadOnly = true;
            this.tb_typeCarte.Size = new System.Drawing.Size(100, 20);
            this.tb_typeCarte.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Type de Carte";
            // 
            // tb_expiration
            // 
            this.tb_expiration.Location = new System.Drawing.Point(87, 139);
            this.tb_expiration.Name = "tb_expiration";
            this.tb_expiration.ReadOnly = true;
            this.tb_expiration.Size = new System.Drawing.Size(100, 20);
            this.tb_expiration.TabIndex = 7;
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
            this.tb_adresse.Size = new System.Drawing.Size(272, 20);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Expiration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Téléphone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Client";
            // 
            // IC_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_client);
            this.MinimumSize = new System.Drawing.Size(365, 190);
            this.Name = "IC_Base";
            this.Size = new System.Drawing.Size(365, 190);
            this.gb_client.ResumeLayout(false);
            this.gb_client.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.TextBox tb_noCarte;
		public System.Windows.Forms.TextBox tb_nomClient;
		public System.Windows.Forms.TextBox tb_typeCarte;
		public System.Windows.Forms.TextBox tb_expiration;
		public System.Windows.Forms.TextBox tb_telephone;
		public System.Windows.Forms.TextBox tb_noClient;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private PrjEq01_CommonForm.Controls.Button_List bt_list;
		public System.Windows.Forms.TextBox tb_adresse;
        public System.Windows.Forms.GroupBox gb_client;
    }
}
