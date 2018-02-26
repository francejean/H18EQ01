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
            this.components = new System.ComponentModel.Container();
            this.Liste_Chambre = new PrjEq01_Application.UserControls.Liste_Chambre();
            this.Label_Num_Chambre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label_Num_Client = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Label_Nom_Client = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Label_Num_Arrivee = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Info_Client = new PrjEq01_Application.UserControls.Info_Client();
            this.Info_Reservation = new PrjEq01_Application.UserControls.Info_Reservation();
            this.TA_ARRIVE = new PrjEq01_Application.DS_MasterTableAdapters.ARRIVETableAdapter();
            this.TA_RESERVATION = new PrjEq01_Application.DS_MasterTableAdapters.RESERVATIONTableAdapter();
            this.TA_DEPART = new PrjEq01_Application.DS_MasterTableAdapters.DEPARTTableAdapter();
            this.TA_TRX = new PrjEq01_Application.DS_MasterTableAdapters.TRXTableAdapter();
            this.DS_Master = new PrjEq01_Application.DS_Master();
            this.BS_ARRIVE = new System.Windows.Forms.BindingSource(this.components);
            this.BS_RESERVATION = new System.Windows.Forms.BindingSource(this.components);
            this.BS_DEPART = new System.Windows.Forms.BindingSource(this.components);
            this.BS_TRX = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_ARRIVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_DEPART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TRX)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste_Chambre
            // 
            this.Liste_Chambre.Location = new System.Drawing.Point(4, 245);
            this.Liste_Chambre.Margin = new System.Windows.Forms.Padding(5);
            this.Liste_Chambre.MinimumSize = new System.Drawing.Size(1133, 283);
            this.Liste_Chambre.Name = "Liste_Chambre";
            this.Liste_Chambre.Size = new System.Drawing.Size(1133, 283);
            this.Liste_Chambre.TabIndex = 2;
            // 
            // Label_Num_Chambre
            // 
            this.Label_Num_Chambre.AutoSize = true;
            this.Label_Num_Chambre.Location = new System.Drawing.Point(267, 173);
            this.Label_Num_Chambre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Num_Chambre.Name = "Label_Num_Chambre";
            this.Label_Num_Chambre.Size = new System.Drawing.Size(89, 17);
            this.Label_Num_Chambre.TabIndex = 3;
            this.Label_Num_Chambre.Text = "No. chambre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 170);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Label_Num_Client
            // 
            this.Label_Num_Client.AutoSize = true;
            this.Label_Num_Client.Location = new System.Drawing.Point(507, 173);
            this.Label_Num_Client.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Num_Client.Name = "Label_Num_Client";
            this.Label_Num_Client.Size = new System.Drawing.Size(69, 17);
            this.Label_Num_Client.TabIndex = 5;
            this.Label_Num_Client.Text = "No. Client";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(626, 170);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 22);
            this.textBox2.TabIndex = 6;
            // 
            // Label_Nom_Client
            // 
            this.Label_Nom_Client.AutoSize = true;
            this.Label_Nom_Client.Location = new System.Drawing.Point(507, 200);
            this.Label_Nom_Client.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Nom_Client.Name = "Label_Nom_Client";
            this.Label_Nom_Client.Size = new System.Drawing.Size(37, 17);
            this.Label_Nom_Client.TabIndex = 7;
            this.Label_Nom_Client.Text = "Nom";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(626, 199);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 22);
            this.textBox3.TabIndex = 8;
            // 
            // Label_Num_Arrivee
            // 
            this.Label_Num_Arrivee.AutoSize = true;
            this.Label_Num_Arrivee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Num_Arrivee.Location = new System.Drawing.Point(773, 4);
            this.Label_Num_Arrivee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Num_Arrivee.Name = "Label_Num_Arrivee";
            this.Label_Num_Arrivee.Size = new System.Drawing.Size(79, 17);
            this.Label_Num_Arrivee.TabIndex = 11;
            this.Label_Num_Arrivee.Text = "No. Arrivee";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(773, 23);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 12;
            // 
            // Info_Client
            // 
            this.Info_Client.Location = new System.Drawing.Point(0, 0);
            this.Info_Client.Margin = new System.Windows.Forms.Padding(4);
            this.Info_Client.MinimumSize = new System.Drawing.Size(487, 234);
            this.Info_Client.Name = "Info_Client";
            this.Info_Client.Size = new System.Drawing.Size(487, 234);
            this.Info_Client.TabIndex = 13;
            // 
            // Info_Reservation
            // 
            this.Info_Reservation.Location = new System.Drawing.Point(498, 0);
            this.Info_Reservation.Margin = new System.Windows.Forms.Padding(4);
            this.Info_Reservation.MinimumSize = new System.Drawing.Size(267, 234);
            this.Info_Reservation.Name = "Info_Reservation";
            this.Info_Reservation.Size = new System.Drawing.Size(267, 234);
            this.Info_Reservation.TabIndex = 14;
            // 
            // TA_ARRIVE
            // 
            this.TA_ARRIVE.ClearBeforeFill = true;
            // 
            // TA_RESERVATION
            // 
            this.TA_RESERVATION.ClearBeforeFill = true;
            // 
            // TA_DEPART
            // 
            this.TA_DEPART.ClearBeforeFill = true;
            // 
            // TA_TRX
            // 
            this.TA_TRX.ClearBeforeFill = true;
            // 
            // DS_Master
            // 
            this.DS_Master.DataSetName = "DS_Master";
            this.DS_Master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tab_Arrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Label_Num_Arrivee);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Label_Nom_Client);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Label_Num_Client);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label_Num_Chambre);
            this.Controls.Add(this.Liste_Chambre);
            this.Controls.Add(this.Info_Client);
            this.Controls.Add(this.Info_Reservation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tab_Arrive";
            this.Size = new System.Drawing.Size(1297, 532);
            this.Load += new System.EventHandler(this.Tab_Arrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_ARRIVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_DEPART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TRX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.Liste_Chambre Liste_Chambre;
        private System.Windows.Forms.Label Label_Num_Chambre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Label_Num_Client;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Label_Nom_Client;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Label_Num_Arrivee;
        private System.Windows.Forms.TextBox textBox4;
        private UserControls.Info_Client Info_Client;
        private UserControls.Info_Reservation Info_Reservation;
        private DS_MasterTableAdapters.ARRIVETableAdapter TA_ARRIVE;
        private DS_MasterTableAdapters.RESERVATIONTableAdapter TA_RESERVATION;
        private DS_MasterTableAdapters.DEPARTTableAdapter TA_DEPART;
        private DS_MasterTableAdapters.TRXTableAdapter TA_TRX;
        private DS_Master DS_Master;
        private System.Windows.Forms.BindingSource BS_ARRIVE;
        private System.Windows.Forms.BindingSource BS_RESERVATION;
        private System.Windows.Forms.BindingSource BS_DEPART;
        private System.Windows.Forms.BindingSource BS_TRX;
    }
}
