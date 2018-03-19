namespace PrjEq01_Application.UserControls.Info_Reservation
{
    partial class IR_Arrive
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_noClient = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.tb_noClient = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.gb_reserv.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_reserv
            // 
            this.gb_reserv.Controls.Add(this.tb_nom);
            this.gb_reserv.Controls.Add(this.tb_noClient);
            this.gb_reserv.Controls.Add(this.lb_nom);
            this.gb_reserv.Controls.Add(this.lb_noClient);
            this.gb_reserv.Controls.SetChildIndex(this.tb_noReserv, 0);
            this.gb_reserv.Controls.SetChildIndex(this.lb_noClient, 0);
            this.gb_reserv.Controls.SetChildIndex(this.lb_nom, 0);
            this.gb_reserv.Controls.SetChildIndex(this.tb_noClient, 0);
            this.gb_reserv.Controls.SetChildIndex(this.tb_nom, 0);
            this.gb_reserv.Controls.SetChildIndex(this.DTP_Reserv, 0);
            this.gb_reserv.Controls.SetChildIndex(this.DTP_Debut, 0);
            this.gb_reserv.Controls.SetChildIndex(this.DTP_Fin, 0);
            // 
            // lb_noClient
            // 
            this.lb_noClient.AutoSize = true;
            this.lb_noClient.Location = new System.Drawing.Point(7, 139);
            this.lb_noClient.Name = "lb_noClient";
            this.lb_noClient.Size = new System.Drawing.Size(53, 13);
            this.lb_noClient.TabIndex = 22;
            this.lb_noClient.Text = "No. Client";
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Location = new System.Drawing.Point(7, 161);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(29, 13);
            this.lb_nom.TabIndex = 23;
            this.lb_nom.Text = "Nom";
            // 
            // tb_noClient
            // 
            this.tb_noClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_noClient.Location = new System.Drawing.Point(97, 136);
            this.tb_noClient.Name = "tb_noClient";
            this.tb_noClient.ReadOnly = true;
            this.tb_noClient.Size = new System.Drawing.Size(97, 20);
            this.tb_noClient.TabIndex = 24;
            // 
            // tb_nom
            // 
            this.tb_nom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_nom.Location = new System.Drawing.Point(97, 161);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.ReadOnly = true;
            this.tb_nom.Size = new System.Drawing.Size(97, 20);
            this.tb_nom.TabIndex = 25;
            // 
            // IR_Arrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "IR_Arrive";
            this.gb_reserv.ResumeLayout(false);
            this.gb_reserv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_noClient;
        private System.Windows.Forms.Label lb_nom;
        public System.Windows.Forms.TextBox tb_nom;
        public System.Windows.Forms.TextBox tb_noClient;
    }
}
