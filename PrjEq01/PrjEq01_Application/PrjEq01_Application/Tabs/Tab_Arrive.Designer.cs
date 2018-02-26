namespace PrjEq01_Application.Tabs
{
    partial class Tab_Arrive
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
			this.liste_Chambre1 = new PrjEq01_Application.UserControls.Liste_Chambre();
			this.Label_Num_Chambre = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Label_Num_Client = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.Label_Nom_Client = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.Label_Num_Arrivee = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.saisi_Info_Client1 = new PrjEq01_Application.UserControls.Saisi_Info_Client();
			this.info_Reservation1 = new PrjEq01_Application.UserControls.Info_Reservation();
			this.SuspendLayout();
			// 
			// liste_Chambre1
			// 
			this.liste_Chambre1.Location = new System.Drawing.Point(3, 199);
			this.liste_Chambre1.Margin = new System.Windows.Forms.Padding(4);
			this.liste_Chambre1.MinimumSize = new System.Drawing.Size(850, 230);
			this.liste_Chambre1.Name = "liste_Chambre1";
			this.liste_Chambre1.Size = new System.Drawing.Size(850, 230);
			this.liste_Chambre1.TabIndex = 2;
			// 
			// Label_Num_Chambre
			// 
			this.Label_Num_Chambre.AutoSize = true;
			this.Label_Num_Chambre.Location = new System.Drawing.Point(200, 144);
			this.Label_Num_Chambre.Name = "Label_Num_Chambre";
			this.Label_Num_Chambre.Size = new System.Drawing.Size(68, 13);
			this.Label_Num_Chambre.TabIndex = 3;
			this.Label_Num_Chambre.Text = "No. chambre";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(276, 143);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(82, 20);
			this.textBox1.TabIndex = 4;
			// 
			// Label_Num_Client
			// 
			this.Label_Num_Client.AutoSize = true;
			this.Label_Num_Client.Location = new System.Drawing.Point(383, 143);
			this.Label_Num_Client.Name = "Label_Num_Client";
			this.Label_Num_Client.Size = new System.Drawing.Size(53, 13);
			this.Label_Num_Client.TabIndex = 5;
			this.Label_Num_Client.Text = "No. Client";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(470, 141);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(98, 20);
			this.textBox2.TabIndex = 6;
			// 
			// Label_Nom_Client
			// 
			this.Label_Nom_Client.AutoSize = true;
			this.Label_Nom_Client.Location = new System.Drawing.Point(383, 166);
			this.Label_Nom_Client.Name = "Label_Nom_Client";
			this.Label_Nom_Client.Size = new System.Drawing.Size(29, 13);
			this.Label_Nom_Client.TabIndex = 7;
			this.Label_Nom_Client.Text = "Nom";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(470, 166);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(98, 20);
			this.textBox3.TabIndex = 8;
			// 
			// Label_Num_Arrivee
			// 
			this.Label_Num_Arrivee.AutoSize = true;
			this.Label_Num_Arrivee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_Num_Arrivee.Location = new System.Drawing.Point(580, 3);
			this.Label_Num_Arrivee.Name = "Label_Num_Arrivee";
			this.Label_Num_Arrivee.Size = new System.Drawing.Size(60, 13);
			this.Label_Num_Arrivee.TabIndex = 11;
			this.Label_Num_Arrivee.Text = "No. Arrivee";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(580, 19);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 12;
			// 
			// saisi_Info_Client1
			// 
			this.saisi_Info_Client1.Location = new System.Drawing.Point(0, 3);
			this.saisi_Info_Client1.MinimumSize = new System.Drawing.Size(365, 190);
			this.saisi_Info_Client1.Name = "saisi_Info_Client1";
			this.saisi_Info_Client1.Size = new System.Drawing.Size(365, 190);
			this.saisi_Info_Client1.TabIndex = 13;
			// 
			// info_Reservation1
			// 
			this.info_Reservation1.Location = new System.Drawing.Point(374, 3);
			this.info_Reservation1.MinimumSize = new System.Drawing.Size(200, 190);
			this.info_Reservation1.Name = "info_Reservation1";
			this.info_Reservation1.Size = new System.Drawing.Size(200, 190);
			this.info_Reservation1.TabIndex = 14;
			// 
			// Tab_Arrive
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.Label_Num_Arrivee);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.Label_Nom_Client);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.Label_Num_Client);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Label_Num_Chambre);
			this.Controls.Add(this.liste_Chambre1);
			this.Controls.Add(this.saisi_Info_Client1);
			this.Controls.Add(this.info_Reservation1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Tab_Arrive";
			this.Size = new System.Drawing.Size(973, 432);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private UserControls.Liste_Chambre liste_Chambre1;
        private System.Windows.Forms.Label Label_Num_Chambre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Label_Num_Client;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Label_Nom_Client;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Label_Num_Arrivee;
        private System.Windows.Forms.TextBox textBox4;
        private UserControls.Saisi_Info_Client saisi_Info_Client1;
        private UserControls.Info_Reservation info_Reservation1;
    }
}
