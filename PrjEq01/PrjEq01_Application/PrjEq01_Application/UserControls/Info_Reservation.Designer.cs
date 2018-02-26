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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_List1 = new PrjEq01_CommonForm.Controls.Button_List();
            this.noReserText = new System.Windows.Forms.TextBox();
            this.dateFinText = new System.Windows.Forms.MaskedTextBox();
            this.dateDebutText = new System.Windows.Forms.MaskedTextBox();
            this.dateReserText = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_List1);
            this.groupBox1.Controls.Add(this.noReserText);
            this.groupBox1.Controls.Add(this.dateFinText);
            this.groupBox1.Controls.Add(this.dateDebutText);
            this.groupBox1.Controls.Add(this.dateReserText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(194, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information sur la réservation";
            // 
            // button_List1
            // 
            this.button_List1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_List1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_List1.BackgroundImage")));
            this.button_List1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_List1.Location = new System.Drawing.Point(174, 10);
            this.button_List1.Margin = new System.Windows.Forms.Padding(2);
            this.button_List1.Name = "button_List1";
            this.button_List1.Size = new System.Drawing.Size(20, 20);
            this.button_List1.TabIndex = 1;
            this.button_List1.UseVisualStyleBackColor = true;
            // 
            // noReserText
            // 
            this.noReserText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noReserText.Location = new System.Drawing.Point(97, 35);
            this.noReserText.Name = "noReserText";
            this.noReserText.Size = new System.Drawing.Size(97, 20);
            this.noReserText.TabIndex = 18;
            // 
            // dateFinText
            // 
            this.dateFinText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFinText.Location = new System.Drawing.Point(97, 113);
            this.dateFinText.Mask = "00/00/0000";
            this.dateFinText.Name = "dateFinText";
            this.dateFinText.Size = new System.Drawing.Size(97, 20);
            this.dateFinText.TabIndex = 17;
            this.dateFinText.ValidatingType = typeof(System.DateTime);
            // 
            // dateDebutText
            // 
            this.dateDebutText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDebutText.Location = new System.Drawing.Point(97, 87);
            this.dateDebutText.Mask = "00/00/0000";
            this.dateDebutText.Name = "dateDebutText";
            this.dateDebutText.Size = new System.Drawing.Size(97, 20);
            this.dateDebutText.TabIndex = 16;
            this.dateDebutText.ValidatingType = typeof(System.DateTime);
            // 
            // dateReserText
            // 
            this.dateReserText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateReserText.Location = new System.Drawing.Point(97, 61);
            this.dateReserText.Mask = "00/00/0000";
            this.dateReserText.Name = "dateReserText";
            this.dateReserText.Size = new System.Drawing.Size(97, 20);
            this.dateReserText.TabIndex = 15;
            this.dateReserText.ValidatingType = typeof(System.DateTime);
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
            // Info_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(200, 190);
            this.Name = "Info_Reservation";
            this.Size = new System.Drawing.Size(200, 190);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox dateFinText;
		private System.Windows.Forms.MaskedTextBox dateDebutText;
		private System.Windows.Forms.MaskedTextBox dateReserText;
		private System.Windows.Forms.TextBox noReserText;
        private PrjEq01_CommonForm.Controls.Button_List button_List1;
    }
}
