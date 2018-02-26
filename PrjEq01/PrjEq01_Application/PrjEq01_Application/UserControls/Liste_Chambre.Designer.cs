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
            this.Button_List = new PrjEq01_CommonForm.Controls.Button_List();
            this.Label_Occupee_Chambre = new System.Windows.Forms.Label();
            this.Label_Prix_Chambre = new System.Windows.Forms.Label();
            this.Label_Type_Chambre = new System.Windows.Forms.Label();
            this.Label_No_Chambre = new System.Windows.Forms.Label();
            this.Liste_OccupeeChambre = new System.Windows.Forms.ListBox();
            this.Liste_PrixChambre = new System.Windows.Forms.ListBox();
            this.Liste_TypeChambre = new System.Windows.Forms.ListBox();
            this.Liste_NoChambre = new System.Windows.Forms.ListBox();
            this.GroupBox_ListeChambres.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_ListeChambres
            // 
            this.GroupBox_ListeChambres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_ListeChambres.Controls.Add(this.Button_List);
            this.GroupBox_ListeChambres.Controls.Add(this.Label_Occupee_Chambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Label_Prix_Chambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Label_Type_Chambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Label_No_Chambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Liste_OccupeeChambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Liste_PrixChambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Liste_TypeChambre);
            this.GroupBox_ListeChambres.Controls.Add(this.Liste_NoChambre);
            this.GroupBox_ListeChambres.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_ListeChambres.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_ListeChambres.Name = "GroupBox_ListeChambres";
            this.GroupBox_ListeChambres.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_ListeChambres.Size = new System.Drawing.Size(1133, 283);
            this.GroupBox_ListeChambres.TabIndex = 1;
            this.GroupBox_ListeChambres.TabStop = false;
            this.GroupBox_ListeChambres.Text = "Liste des chambres";
            // 
            // Button_List
            // 
            this.Button_List.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_List.BackgroundImage")));
            this.Button_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_List.Location = new System.Drawing.Point(1099, 12);
            this.Button_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_List.Name = "Button_List";
            this.Button_List.Size = new System.Drawing.Size(27, 25);
            this.Button_List.TabIndex = 1;
            this.Button_List.UseVisualStyleBackColor = true;
            // 
            // Label_Occupee_Chambre
            // 
            this.Label_Occupee_Chambre.AutoSize = true;
            this.Label_Occupee_Chambre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Occupee_Chambre.Location = new System.Drawing.Point(869, 17);
            this.Label_Occupee_Chambre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Occupee_Chambre.Name = "Label_Occupee_Chambre";
            this.Label_Occupee_Chambre.Size = new System.Drawing.Size(71, 22);
            this.Label_Occupee_Chambre.TabIndex = 7;
            this.Label_Occupee_Chambre.Text = "Occupée";
            // 
            // Label_Prix_Chambre
            // 
            this.Label_Prix_Chambre.AutoSize = true;
            this.Label_Prix_Chambre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Prix_Chambre.Location = new System.Drawing.Point(587, 17);
            this.Label_Prix_Chambre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Prix_Chambre.Name = "Label_Prix_Chambre";
            this.Label_Prix_Chambre.Size = new System.Drawing.Size(37, 22);
            this.Label_Prix_Chambre.TabIndex = 6;
            this.Label_Prix_Chambre.Text = "Prix";
            // 
            // Label_Type_Chambre
            // 
            this.Label_Type_Chambre.AutoSize = true;
            this.Label_Type_Chambre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Type_Chambre.Location = new System.Drawing.Point(289, 17);
            this.Label_Type_Chambre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Type_Chambre.Name = "Label_Type_Chambre";
            this.Label_Type_Chambre.Size = new System.Drawing.Size(129, 22);
            this.Label_Type_Chambre.TabIndex = 5;
            this.Label_Type_Chambre.Text = "Type de chambre";
            // 
            // Label_No_Chambre
            // 
            this.Label_No_Chambre.AutoSize = true;
            this.Label_No_Chambre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_No_Chambre.Location = new System.Drawing.Point(11, 17);
            this.Label_No_Chambre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_No_Chambre.Name = "Label_No_Chambre";
            this.Label_No_Chambre.Size = new System.Drawing.Size(97, 22);
            this.Label_No_Chambre.TabIndex = 4;
            this.Label_No_Chambre.Text = "No. chambre";
            // 
            // Liste_OccupeeChambre
            // 
            this.Liste_OccupeeChambre.FormattingEnabled = true;
            this.Liste_OccupeeChambre.ItemHeight = 16;
            this.Liste_OccupeeChambre.Location = new System.Drawing.Point(871, 41);
            this.Liste_OccupeeChambre.Margin = new System.Windows.Forms.Padding(4);
            this.Liste_OccupeeChambre.Name = "Liste_OccupeeChambre";
            this.Liste_OccupeeChambre.Size = new System.Drawing.Size(253, 228);
            this.Liste_OccupeeChambre.TabIndex = 3;
            // 
            // Liste_PrixChambre
            // 
            this.Liste_PrixChambre.FormattingEnabled = true;
            this.Liste_PrixChambre.ItemHeight = 16;
            this.Liste_PrixChambre.Location = new System.Drawing.Point(588, 41);
            this.Liste_PrixChambre.Margin = new System.Windows.Forms.Padding(4);
            this.Liste_PrixChambre.Name = "Liste_PrixChambre";
            this.Liste_PrixChambre.Size = new System.Drawing.Size(263, 228);
            this.Liste_PrixChambre.TabIndex = 2;
            // 
            // Liste_TypeChambre
            // 
            this.Liste_TypeChambre.FormattingEnabled = true;
            this.Liste_TypeChambre.ItemHeight = 16;
            this.Liste_TypeChambre.Location = new System.Drawing.Point(291, 41);
            this.Liste_TypeChambre.Margin = new System.Windows.Forms.Padding(4);
            this.Liste_TypeChambre.Name = "Liste_TypeChambre";
            this.Liste_TypeChambre.Size = new System.Drawing.Size(277, 228);
            this.Liste_TypeChambre.TabIndex = 1;
            // 
            // Liste_NoChambre
            // 
            this.Liste_NoChambre.FormattingEnabled = true;
            this.Liste_NoChambre.ItemHeight = 16;
            this.Liste_NoChambre.Location = new System.Drawing.Point(8, 41);
            this.Liste_NoChambre.Margin = new System.Windows.Forms.Padding(4);
            this.Liste_NoChambre.Name = "Liste_NoChambre";
            this.Liste_NoChambre.Size = new System.Drawing.Size(263, 228);
            this.Liste_NoChambre.TabIndex = 0;
            // 
            // Liste_Chambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox_ListeChambres);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1133, 283);
            this.Name = "Liste_Chambre";
            this.Size = new System.Drawing.Size(1133, 283);
            this.GroupBox_ListeChambres.ResumeLayout(false);
            this.GroupBox_ListeChambres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Label_No_Chambre;
        private System.Windows.Forms.ListBox Liste_OccupeeChambre;
        private System.Windows.Forms.ListBox Liste_PrixChambre;
        private System.Windows.Forms.ListBox Liste_TypeChambre;
        private System.Windows.Forms.ListBox Liste_NoChambre;
        private System.Windows.Forms.Label Label_Occupee_Chambre;
        private System.Windows.Forms.Label Label_Prix_Chambre;
        private System.Windows.Forms.Label Label_Type_Chambre;
        private PrjEq01_CommonForm.Controls.Button_List Button_List;
        public System.Windows.Forms.GroupBox GroupBox_ListeChambres;
    }
}
