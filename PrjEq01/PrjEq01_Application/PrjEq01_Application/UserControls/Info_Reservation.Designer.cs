﻿namespace PrjEq01_Application.UserControls
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
            this.Button_List = new PrjEq01_CommonForm.Controls.Button_List();
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
            this.groupBox1.Controls.Add(this.Button_List);
            this.groupBox1.Controls.Add(this.noReserText);
            this.groupBox1.Controls.Add(this.dateFinText);
            this.groupBox1.Controls.Add(this.dateDebutText);
            this.groupBox1.Controls.Add(this.dateReserText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.MinimumSize = new System.Drawing.Size(259, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information sur la réservation";
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
            // noReserText
            // 
            this.noReserText.Location = new System.Drawing.Point(129, 43);
            this.noReserText.Margin = new System.Windows.Forms.Padding(4);
            this.noReserText.Name = "noReserText";
            this.noReserText.Size = new System.Drawing.Size(128, 22);
            this.noReserText.TabIndex = 18;
            // 
            // dateFinText
            // 
            this.dateFinText.Location = new System.Drawing.Point(129, 139);
            this.dateFinText.Margin = new System.Windows.Forms.Padding(4);
            this.dateFinText.Mask = "00/00/0000";
            this.dateFinText.Name = "dateFinText";
            this.dateFinText.Size = new System.Drawing.Size(128, 22);
            this.dateFinText.TabIndex = 17;
            this.dateFinText.ValidatingType = typeof(System.DateTime);
            // 
            // dateDebutText
            // 
            this.dateDebutText.Location = new System.Drawing.Point(129, 107);
            this.dateDebutText.Margin = new System.Windows.Forms.Padding(4);
            this.dateDebutText.Mask = "00/00/0000";
            this.dateDebutText.Name = "dateDebutText";
            this.dateDebutText.Size = new System.Drawing.Size(128, 22);
            this.dateDebutText.TabIndex = 16;
            this.dateDebutText.ValidatingType = typeof(System.DateTime);
            // 
            // dateReserText
            // 
            this.dateReserText.Location = new System.Drawing.Point(129, 75);
            this.dateReserText.Margin = new System.Windows.Forms.Padding(4);
            this.dateReserText.Mask = "00/00/0000";
            this.dateReserText.Name = "dateReserText";
            this.dateReserText.Size = new System.Drawing.Size(128, 22);
            this.dateReserText.TabIndex = 15;
            this.dateReserText.ValidatingType = typeof(System.DateTime);
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
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(267, 234);
            this.Name = "Info_Reservation";
            this.Size = new System.Drawing.Size(267, 234);
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
        private PrjEq01_CommonForm.Controls.Button_List Button_List;
    }
}
