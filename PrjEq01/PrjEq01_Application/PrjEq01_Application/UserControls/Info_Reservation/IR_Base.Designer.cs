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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.gb_reserv.Controls.Add(this.label4);
            this.gb_reserv.Controls.Add(this.label1);
            this.gb_reserv.Controls.Add(this.label2);
            this.gb_reserv.Controls.Add(this.label3);
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
            // 
            // tb_noReserv
            // 
            this.tb_noReserv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_noReserv.Location = new System.Drawing.Point(97, 35);
            this.tb_noReserv.Name = "tb_noReserv";
            this.tb_noReserv.Size = new System.Drawing.Size(97, 20);
            this.tb_noReserv.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date de fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "No. Réservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Réservé le";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date de début";
            // 
            // Info_Reservation_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_reserv);
            this.MinimumSize = new System.Drawing.Size(200, 190);
            this.Name = "Info_Reservation_Base";
            this.Size = new System.Drawing.Size(200, 190);
            this.gb_reserv.ResumeLayout(false);
            this.gb_reserv.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private PrjEq01_CommonForm.Controls.Button_List bt_list;
        public System.Windows.Forms.GroupBox gb_reserv;
        public System.Windows.Forms.DateTimePicker DTP_Fin;
        public System.Windows.Forms.DateTimePicker DTP_Debut;
        public System.Windows.Forms.DateTimePicker DTP_Reserv;
        public System.Windows.Forms.TextBox tb_noReserv;
    }
}
