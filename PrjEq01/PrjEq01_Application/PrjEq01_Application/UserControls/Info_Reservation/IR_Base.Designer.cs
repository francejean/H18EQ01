namespace PrjEq01_Application.UserControls
{
	partial class Info_Reservation_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Reservation_Base));
            this.GroupBox_Reserv = new System.Windows.Forms.GroupBox();
            this.DTP_Fin = new System.Windows.Forms.DateTimePicker();
            this.DTP_Debut = new System.Windows.Forms.DateTimePicker();
            this.DTP_Reserv = new System.Windows.Forms.DateTimePicker();
            this.Button_List = new PrjEq01_CommonForm.Controls.Button_List();
            this.TextBox_NoReserv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox_Reserv.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Reserv
            // 
            this.GroupBox_Reserv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Reserv.Controls.Add(this.DTP_Fin);
            this.GroupBox_Reserv.Controls.Add(this.DTP_Debut);
            this.GroupBox_Reserv.Controls.Add(this.DTP_Reserv);
            this.GroupBox_Reserv.Controls.Add(this.Button_List);
            this.GroupBox_Reserv.Controls.Add(this.TextBox_NoReserv);
            this.GroupBox_Reserv.Controls.Add(this.label4);
            this.GroupBox_Reserv.Controls.Add(this.label1);
            this.GroupBox_Reserv.Controls.Add(this.label2);
            this.GroupBox_Reserv.Controls.Add(this.label3);
            this.GroupBox_Reserv.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_Reserv.MinimumSize = new System.Drawing.Size(194, 170);
            this.GroupBox_Reserv.Name = "GroupBox_Reserv";
            this.GroupBox_Reserv.Size = new System.Drawing.Size(200, 190);
            this.GroupBox_Reserv.TabIndex = 0;
            this.GroupBox_Reserv.TabStop = false;
            this.GroupBox_Reserv.Text = "Information sur la réservation";
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
            // Button_List
            // 
            this.Button_List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_List.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_List.BackgroundImage")));
            this.Button_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_List.Location = new System.Drawing.Point(174, 10);
            this.Button_List.Margin = new System.Windows.Forms.Padding(2);
            this.Button_List.Name = "Button_List";
            this.Button_List.Size = new System.Drawing.Size(20, 20);
            this.Button_List.TabIndex = 1;
            this.Button_List.UseVisualStyleBackColor = true;
            // 
            // TextBox_NoReserv
            // 
            this.TextBox_NoReserv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_NoReserv.Location = new System.Drawing.Point(97, 35);
            this.TextBox_NoReserv.Name = "TextBox_NoReserv";
            this.TextBox_NoReserv.Size = new System.Drawing.Size(97, 20);
            this.TextBox_NoReserv.TabIndex = 18;
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
            this.Controls.Add(this.GroupBox_Reserv);
            this.MinimumSize = new System.Drawing.Size(200, 190);
            this.Name = "Info_Reservation_Base";
            this.Size = new System.Drawing.Size(200, 190);
            this.GroupBox_Reserv.ResumeLayout(false);
            this.GroupBox_Reserv.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private PrjEq01_CommonForm.Controls.Button_List Button_List;
        public System.Windows.Forms.GroupBox GroupBox_Reserv;
        public System.Windows.Forms.DateTimePicker DTP_Fin;
        public System.Windows.Forms.DateTimePicker DTP_Debut;
        public System.Windows.Forms.DateTimePicker DTP_Reserv;
        public System.Windows.Forms.TextBox TextBox_NoReserv;
    }
}
