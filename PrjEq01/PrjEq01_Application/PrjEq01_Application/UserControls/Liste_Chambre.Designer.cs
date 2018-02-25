namespace PrjEq01_Application.UserControls
{
    partial class Liste_Chambre
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liste_Chambre));
            this.GroupBox_ListeChambres = new System.Windows.Forms.GroupBox();
            this.button_List1 = new PrjEq01_CommonForm.Controls.Button_List();
            this.Label_Occupee_Chambre = new System.Windows.Forms.Label();
            this.Label_Prix_Chambre = new System.Windows.Forms.Label();
            this.Label_Type_Chambre = new System.Windows.Forms.Label();
            this.Label_No_Chambre = new System.Windows.Forms.Label();
            this.Liste_Occupee_Chambre = new System.Windows.Forms.ListBox();
            this.Liste_Prix_Chambre = new System.Windows.Forms.ListBox();
            this.Liste_Type_Chambre = new System.Windows.Forms.ListBox();
            this.Liste_No_Chambre = new System.Windows.Forms.ListBox();
            this.GroupBox_ListeChambres.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_ListeChambres
            // 
            this.GroupBox_ListeChambres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_ListeChambres.Controls.Add(this.button_List1);
            this.GroupBox_ListeChambres.Controls.Add(this.Label_Occupee_Chambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Label_Prix_Chambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Label_Type_Chambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Label_No_Chambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Liste_Occupee_Chambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Liste_Prix_Chambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Liste_Type_Chambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Liste_No_Chambre);
            this.GroupBox_ListeChambres.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_ListeChambres.Name = "GroupBox_ListeChambres";
            this.GroupBox_ListeChambres.Size = new System.Drawing.Size(850, 230);
            this.GroupBox_ListeChambres.TabIndex = 1;
            this.GroupBox_ListeChambres.TabStop = false;
            this.GroupBox_ListeChambres.Text = "Liste des chambres";
            // 
            // button_List1
            // 
            this.button_List1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_List1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_List1.BackgroundImage")));
            this.button_List1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_List1.Location = new System.Drawing.Point(824, 10);
            this.button_List1.Margin = new System.Windows.Forms.Padding(2);
            this.button_List1.Name = "button_List1";
            this.button_List1.Size = new System.Drawing.Size(20, 20);
            this.button_List1.TabIndex = 1;
            this.button_List1.UseVisualStyleBackColor = true;
            // 
            // Label_Occupee_Chambre
            // 
            this.Label_Occupee_Chambre.AutoSize = true;
            this.Label_Occupee_Chambre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Occupee_Chambre.Location = new System.Drawing.Point(652, 14);
            this.Label_Occupee_Chambre.Name = "Label_Occupee_Chambre";
            this.Label_Occupee_Chambre.Size = new System.Drawing.Size(54, 16);
            this.Label_Occupee_Chambre.TabIndex = 7;
            this.Label_Occupee_Chambre.Text = "Occupée";
            // 
            // Label_Prix_Chambre
            // 
            this.Label_Prix_Chambre.AutoSize = true;
            this.Label_Prix_Chambre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Prix_Chambre.Location = new System.Drawing.Point(440, 14);
            this.Label_Prix_Chambre.Name = "Label_Prix_Chambre";
            this.Label_Prix_Chambre.Size = new System.Drawing.Size(28, 16);
            this.Label_Prix_Chambre.TabIndex = 6;
            this.Label_Prix_Chambre.Text = "Prix";
            // 
            // Label_Type_Chambre
            // 
            this.Label_Type_Chambre.AutoSize = true;
            this.Label_Type_Chambre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Type_Chambre.Location = new System.Drawing.Point(217, 14);
            this.Label_Type_Chambre.Name = "Label_Type_Chambre";
            this.Label_Type_Chambre.Size = new System.Drawing.Size(97, 16);
            this.Label_Type_Chambre.TabIndex = 5;
            this.Label_Type_Chambre.Text = "Type de chambre";
            // 
            // Label_No_Chambre
            // 
            this.Label_No_Chambre.AutoSize = true;
            this.Label_No_Chambre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_No_Chambre.Location = new System.Drawing.Point(8, 14);
            this.Label_No_Chambre.Name = "Label_No_Chambre";
            this.Label_No_Chambre.Size = new System.Drawing.Size(74, 16);
            this.Label_No_Chambre.TabIndex = 4;
            this.Label_No_Chambre.Text = "No. chambre";
            // 
            // Liste_Occupee_Chambre
            // 
            this.Liste_Occupee_Chambre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Liste_Occupee_Chambre.FormattingEnabled = true;
            this.Liste_Occupee_Chambre.Location = new System.Drawing.Point(653, 33);
            this.Liste_Occupee_Chambre.Name = "Liste_Occupee_Chambre";
            this.Liste_Occupee_Chambre.Size = new System.Drawing.Size(191, 186);
            this.Liste_Occupee_Chambre.TabIndex = 3;
            // 
            // Liste_Prix_Chambre
            // 
            this.Liste_Prix_Chambre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Liste_Prix_Chambre.FormattingEnabled = true;
            this.Liste_Prix_Chambre.Location = new System.Drawing.Point(441, 33);
            this.Liste_Prix_Chambre.Name = "Liste_Prix_Chambre";
            this.Liste_Prix_Chambre.Size = new System.Drawing.Size(198, 186);
            this.Liste_Prix_Chambre.TabIndex = 2;
            // 
            // Liste_Type_Chambre
            // 
            this.Liste_Type_Chambre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Liste_Type_Chambre.FormattingEnabled = true;
            this.Liste_Type_Chambre.Location = new System.Drawing.Point(218, 33);
            this.Liste_Type_Chambre.Name = "Liste_Type_Chambre";
            this.Liste_Type_Chambre.Size = new System.Drawing.Size(209, 186);
            this.Liste_Type_Chambre.TabIndex = 1;
            // 
            // Liste_No_Chambre
            // 
            this.Liste_No_Chambre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Liste_No_Chambre.FormattingEnabled = true;
            this.Liste_No_Chambre.Location = new System.Drawing.Point(6, 33);
            this.Liste_No_Chambre.Name = "Liste_No_Chambre";
            this.Liste_No_Chambre.Size = new System.Drawing.Size(198, 186);
            this.Liste_No_Chambre.TabIndex = 0;
            // 
            // Liste_Chambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox_ListeChambres);
            this.MinimumSize = new System.Drawing.Size(850, 230);
            this.Name = "Liste_Chambre";
            this.Size = new System.Drawing.Size(850, 230);
            this.GroupBox_ListeChambres.ResumeLayout(false);
            this.GroupBox_ListeChambres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_ListeChambres;
        private System.Windows.Forms.Label Label_No_Chambre;
        private System.Windows.Forms.ListBox Liste_Occupee_Chambre;
        private System.Windows.Forms.ListBox Liste_Prix_Chambre;
        private System.Windows.Forms.ListBox Liste_Type_Chambre;
        private System.Windows.Forms.ListBox Liste_No_Chambre;
        private System.Windows.Forms.Label Label_Occupee_Chambre;
        private System.Windows.Forms.Label Label_Prix_Chambre;
        private System.Windows.Forms.Label Label_Type_Chambre;
        private PrjEq01_CommonForm.Controls.Button_List button_List1;
    }
}
