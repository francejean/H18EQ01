namespace PrjEq01_Application.UserControls
{
	partial class IR_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IR_Base));
            this.gb_reserv = new System.Windows.Forms.GroupBox();
            this.DTP_Fin = new System.Windows.Forms.DateTimePicker();
            this.DTP_Debut = new System.Windows.Forms.DateTimePicker();
            this.DTP_Reserv = new System.Windows.Forms.DateTimePicker();
            this.bt_list = new PrjEq01_CommonForm.Controls.Button_List();
            this.tb_noReserv = new System.Windows.Forms.TextBox();
            this.lb_dateFin = new System.Windows.Forms.Label();
            this.lb_noReservation = new System.Windows.Forms.Label();
            this.lb_dateReserv = new System.Windows.Forms.Label();
            this.lb_dateDebut = new System.Windows.Forms.Label();
            this.gb_reserv.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_reserv
            // 
            this.gb_reserv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_reserv.Controls.Add(this.DTP_Fin);
            this.gb_reserv.Controls.Add(this.DTP_Debut);
            this.gb_reserv.Controls.Add(this.DTP_Reserv);
            this.gb_reserv.Controls.Add(this.bt_list);
            this.gb_reserv.Controls.Add(this.tb_noReserv);
            this.gb_reserv.Controls.Add(this.lb_dateFin);
            this.gb_reserv.Controls.Add(this.lb_noReservation);
            this.gb_reserv.Controls.Add(this.lb_dateReserv);
            this.gb_reserv.Controls.Add(this.lb_dateDebut);
            this.gb_reserv.Location = new System.Drawing.Point(0, 0);
            this.gb_reserv.MinimumSize = new System.Drawing.Size(194, 170);
            this.gb_reserv.Name = "gb_reserv";
            this.gb_reserv.Size = new System.Drawing.Size(200, 190);
            this.gb_reserv.TabIndex = 0;
            this.gb_reserv.TabStop = false;
            this.gb_reserv.Text = "Information sur la réservation";
            // 
            // DTP_Fin
            // 
            this.DTP_Fin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_Fin.Enabled = false;
            this.DTP_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Fin.Location = new System.Drawing.Point(97, 113);
            this.DTP_Fin.Name = "DTP_Fin";
            this.DTP_Fin.Size = new System.Drawing.Size(97, 20);
            this.DTP_Fin.TabIndex = 21;
            // 
            // DTP_Debut
            // 
            this.DTP_Debut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_Debut.Enabled = false;
            this.DTP_Debut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Debut.Location = new System.Drawing.Point(97, 87);
            this.DTP_Debut.Name = "DTP_Debut";
            this.DTP_Debut.Size = new System.Drawing.Size(97, 20);
            this.DTP_Debut.TabIndex = 20;
            // 
            // DTP_Reserv
            // 
            this.DTP_Reserv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_Reserv.Enabled = false;
            this.DTP_Reserv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Reserv.Location = new System.Drawing.Point(97, 61);
            this.DTP_Reserv.Name = "DTP_Reserv";
            this.DTP_Reserv.Size = new System.Drawing.Size(97, 20);
            this.DTP_Reserv.TabIndex = 19;
            // 
            // bt_list
            // 
            this.bt_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_list.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_list.BackgroundImage")));
            this.bt_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_list.Location = new System.Drawing.Point(174, 10);
            this.bt_list.Margin = new System.Windows.Forms.Padding(2);
            this.bt_list.Name = "bt_list";
            this.bt_list.Size = new System.Drawing.Size(20, 20);
            this.bt_list.TabIndex = 1;
            this.bt_list.UseVisualStyleBackColor = true;
            this.bt_list.Click += new System.EventHandler(this.bt_list_Click);
            // 
            // tb_noReserv
            // 
            this.tb_noReserv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_noReserv.Location = new System.Drawing.Point(97, 35);
            this.tb_noReserv.Name = "tb_noReserv";
            this.tb_noReserv.ReadOnly = true;
            this.tb_noReserv.Size = new System.Drawing.Size(97, 20);
            this.tb_noReserv.TabIndex = 18;
            // 
            // lb_dateFin
            // 
            this.lb_dateFin.AutoSize = true;
            this.lb_dateFin.Location = new System.Drawing.Point(7, 116);
            this.lb_dateFin.Name = "lb_dateFin";
            this.lb_dateFin.Size = new System.Drawing.Size(59, 13);
            this.lb_dateFin.TabIndex = 13;
            this.lb_dateFin.Text = "Date de fin";
            // 
            // lb_noReservation
            // 
            this.lb_noReservation.AutoSize = true;
            this.lb_noReservation.Location = new System.Drawing.Point(7, 38);
            this.lb_noReservation.Name = "lb_noReservation";
            this.lb_noReservation.Size = new System.Drawing.Size(84, 13);
            this.lb_noReservation.TabIndex = 7;
            this.lb_noReservation.Text = "No. Réservation";
            // 
            // lb_dateReserv
            // 
            this.lb_dateReserv.AutoSize = true;
            this.lb_dateReserv.Location = new System.Drawing.Point(7, 64);
            this.lb_dateReserv.Name = "lb_dateReserv";
            this.lb_dateReserv.Size = new System.Drawing.Size(58, 13);
            this.lb_dateReserv.TabIndex = 9;
            this.lb_dateReserv.Text = "Réservé le";
            // 
            // lb_dateDebut
            // 
            this.lb_dateDebut.AutoSize = true;
            this.lb_dateDebut.Location = new System.Drawing.Point(7, 90);
            this.lb_dateDebut.Name = "lb_dateDebut";
            this.lb_dateDebut.Size = new System.Drawing.Size(75, 13);
            this.lb_dateDebut.TabIndex = 10;
            this.lb_dateDebut.Text = "Date de début";
            // 
            // IR_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_reserv);
            this.MinimumSize = new System.Drawing.Size(200, 190);
            this.Name = "IR_Base";
            this.Size = new System.Drawing.Size(200, 190);
            this.gb_reserv.ResumeLayout(false);
            this.gb_reserv.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lb_noReservation;
		private System.Windows.Forms.Label lb_dateReserv;
		private System.Windows.Forms.Label lb_dateDebut;
		private System.Windows.Forms.Label lb_dateFin;
        private PrjEq01_CommonForm.Controls.Button_List bt_list;
        public System.Windows.Forms.GroupBox gb_reserv;
        public System.Windows.Forms.DateTimePicker DTP_Fin;
        public System.Windows.Forms.DateTimePicker DTP_Debut;
        public System.Windows.Forms.DateTimePicker DTP_Reserv;
        public System.Windows.Forms.TextBox tb_noReserv;
	}
}
