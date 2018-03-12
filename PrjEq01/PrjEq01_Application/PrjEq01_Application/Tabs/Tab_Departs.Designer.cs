namespace PrjEq01_Application.Tabs
{
    partial class Tab_Departs
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
            this.saisi_Info_Client1 = new PrjEq01_Application.UserControls.Saisi_Info_Client();
            this.info_Reservation1 = new PrjEq01_Application.UserControls.Info_Reservation();
            this.lb_noDepart = new System.Windows.Forms.Label();
            this.tb_noDepart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saisi_Info_Client1
            // 
            this.saisi_Info_Client1.Location = new System.Drawing.Point(4, 4);
            this.saisi_Info_Client1.Margin = new System.Windows.Forms.Padding(4);
            this.saisi_Info_Client1.MinimumSize = new System.Drawing.Size(487, 234);
            this.saisi_Info_Client1.Name = "saisi_Info_Client1";
            this.saisi_Info_Client1.Size = new System.Drawing.Size(487, 234);
            this.saisi_Info_Client1.TabIndex = 0;
            // 
            // info_Reservation1
            // 
            this.info_Reservation1.Location = new System.Drawing.Point(499, 4);
            this.info_Reservation1.Margin = new System.Windows.Forms.Padding(4);
            this.info_Reservation1.MinimumSize = new System.Drawing.Size(267, 234);
            this.info_Reservation1.Name = "info_Reservation1";
            this.info_Reservation1.Size = new System.Drawing.Size(267, 234);
            this.info_Reservation1.TabIndex = 1;
            // 
            // lb_noDepart
            // 
            this.lb_noDepart.AutoSize = true;
            this.lb_noDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_noDepart.Location = new System.Drawing.Point(774, 4);
            this.lb_noDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_noDepart.Name = "lb_noDepart";
            this.lb_noDepart.Size = new System.Drawing.Size(77, 17);
            this.lb_noDepart.TabIndex = 12;
            this.lb_noDepart.Text = "No. Départ";
            // 
            // tb_noDepart
            // 
            this.tb_noDepart.Location = new System.Drawing.Point(774, 25);
            this.tb_noDepart.Margin = new System.Windows.Forms.Padding(4);
            this.tb_noDepart.Name = "tb_noDepart";
            this.tb_noDepart.Size = new System.Drawing.Size(132, 22);
            this.tb_noDepart.TabIndex = 13;
            // 
            // Tab_Departs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_noDepart);
            this.Controls.Add(this.lb_noDepart);
            this.Controls.Add(this.info_Reservation1);
            this.Controls.Add(this.saisi_Info_Client1);
            this.Name = "Tab_Departs";
            this.Size = new System.Drawing.Size(1297, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Saisi_Info_Client saisi_Info_Client1;
        private UserControls.Info_Reservation info_Reservation1;
        private System.Windows.Forms.Label lb_noDepart;
        private System.Windows.Forms.TextBox tb_noDepart;
    }
}
