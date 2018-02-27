namespace PrjEq01_Application.UserControls
{
	partial class Info_Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Reservation));
            this.GroupBox_Reserv = new System.Windows.Forms.GroupBox();
            this.Button_List = new PrjEq01_CommonForm.Controls.Button_List();
            this.TextBox_NoReserv = new System.Windows.Forms.TextBox();
            this.TextBox_DateFin = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_DateDebut = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_DateReserv = new System.Windows.Forms.MaskedTextBox();
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
            this.GroupBox_Reserv.Controls.Add(this.Button_List);
            this.GroupBox_Reserv.Controls.Add(this.TextBox_NoReserv);
            this.GroupBox_Reserv.Controls.Add(this.TextBox_DateFin);
            this.GroupBox_Reserv.Controls.Add(this.TextBox_DateDebut);
            this.GroupBox_Reserv.Controls.Add(this.TextBox_DateReserv);
            this.GroupBox_Reserv.Controls.Add(this.label4);
            this.GroupBox_Reserv.Controls.Add(this.label1);
            this.GroupBox_Reserv.Controls.Add(this.label2);
            this.GroupBox_Reserv.Controls.Add(this.label3);
            this.GroupBox_Reserv.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_Reserv.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_Reserv.MinimumSize = new System.Drawing.Size(259, 209);
            this.GroupBox_Reserv.Name = "GroupBox_Reserv";
            this.GroupBox_Reserv.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_Reserv.Size = new System.Drawing.Size(267, 234);
            this.GroupBox_Reserv.TabIndex = 0;
            this.GroupBox_Reserv.TabStop = false;
            this.GroupBox_Reserv.Text = "Information sur la réservation";
            // 
            // Button_List
            // 
            this.Button_List.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_List.BackgroundImage")));
            this.Button_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_List.Location = new System.Drawing.Point(232, 12);
            this.Button_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_List.Name = "Button_List";
            this.Button_List.Size = new System.Drawing.Size(27, 25);
            this.Button_List.TabIndex = 1;
            this.Button_List.UseVisualStyleBackColor = true;
            // 
            // TextBox_NoReserv
            // 
            this.TextBox_NoReserv.Location = new System.Drawing.Point(129, 43);
            this.TextBox_NoReserv.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_NoReserv.Name = "TextBox_NoReserv";
            this.TextBox_NoReserv.Size = new System.Drawing.Size(128, 22);
            this.TextBox_NoReserv.TabIndex = 18;
            // 
            // TextBox_DateFin
            // 
            this.TextBox_DateFin.Location = new System.Drawing.Point(129, 139);
            this.TextBox_DateFin.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_DateFin.Mask = "00/00/0000";
            this.TextBox_DateFin.Name = "TextBox_DateFin";
            this.TextBox_DateFin.Size = new System.Drawing.Size(128, 22);
            this.TextBox_DateFin.TabIndex = 17;
            this.TextBox_DateFin.ValidatingType = typeof(System.DateTime);
            // 
            // TextBox_DateDebut
            // 
            this.TextBox_DateDebut.Location = new System.Drawing.Point(129, 107);
            this.TextBox_DateDebut.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_DateDebut.Mask = "00/00/0000";
            this.TextBox_DateDebut.Name = "TextBox_DateDebut";
            this.TextBox_DateDebut.Size = new System.Drawing.Size(128, 22);
            this.TextBox_DateDebut.TabIndex = 16;
            this.TextBox_DateDebut.ValidatingType = typeof(System.DateTime);
            // 
            // TextBox_DateReserv
            // 
            this.TextBox_DateReserv.Location = new System.Drawing.Point(129, 75);
            this.TextBox_DateReserv.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_DateReserv.Mask = "00/00/0000";
            this.TextBox_DateReserv.Name = "TextBox_DateReserv";
            this.TextBox_DateReserv.Size = new System.Drawing.Size(128, 22);
            this.TextBox_DateReserv.TabIndex = 15;
            this.TextBox_DateReserv.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date de fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "No. Réservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Réservé le";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date de début";
            // 
            // Info_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox_Reserv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(267, 234);
            this.Name = "Info_Reservation";
            this.Size = new System.Drawing.Size(267, 234);
            this.GroupBox_Reserv.ResumeLayout(false);
            this.GroupBox_Reserv.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox TextBox_DateFin;
		private System.Windows.Forms.MaskedTextBox TextBox_DateDebut;
		private System.Windows.Forms.MaskedTextBox TextBox_DateReserv;
		private System.Windows.Forms.TextBox TextBox_NoReserv;
        private PrjEq01_CommonForm.Controls.Button_List Button_List;
        public System.Windows.Forms.GroupBox GroupBox_Reserv;
    }
}
