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
            this.lb_noDepart = new System.Windows.Forms.Label();
            this.tb_noDepart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.Name = "Tab_Departs";
            this.Size = new System.Drawing.Size(1297, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_noDepart;
        private System.Windows.Forms.TextBox tb_noDepart;
    }
}
