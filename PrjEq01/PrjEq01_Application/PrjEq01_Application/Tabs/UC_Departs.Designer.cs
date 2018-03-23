namespace PrjEq01_Application.Tabs
{
    partial class UC_Departs
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
            this.lb_noArrivee = new System.Windows.Forms.Label();
            this.tb_noArrivee = new System.Windows.Forms.TextBox();
            this.ir_departs = new PrjEq01_Application.UserControls.Info_Reservation.IR_Depart(new System.Windows.Forms.BindingSource());
            this.ic_base = new PrjEq01_Application.UserControls.IC_Base(new System.Windows.Forms.BindingSource());
            this.dS_Master = new PrjEq01_Application.DS_Master();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_noArrivee
            // 
            this.lb_noArrivee.AutoSize = true;
            this.lb_noArrivee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_noArrivee.Location = new System.Drawing.Point(774, 4);
            this.lb_noArrivee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_noArrivee.Name = "lb_noArrivee";
            this.lb_noArrivee.Size = new System.Drawing.Size(79, 17);
            this.lb_noArrivee.TabIndex = 12;
            this.lb_noArrivee.Text = "No. Arrivée";
            // 
            // tb_noArrivee
            // 
            this.tb_noArrivee.Location = new System.Drawing.Point(774, 25);
            this.tb_noArrivee.Margin = new System.Windows.Forms.Padding(4);
            this.tb_noArrivee.Name = "tb_noArrivee";
            this.tb_noArrivee.ReadOnly = true;
            this.tb_noArrivee.Size = new System.Drawing.Size(132, 22);
            this.tb_noArrivee.TabIndex = 13;
            // 
            // ir_departs
            // 
            this.ir_departs.Location = new System.Drawing.Point(499, 4);
            this.ir_departs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ir_departs.MinimumSize = new System.Drawing.Size(267, 234);
            this.ir_departs.Name = "ir_departs";
            this.ir_departs.Size = new System.Drawing.Size(267, 234);
            this.ir_departs.TabIndex = 15;
            // 
            // ic_base
            // 
            this.ic_base.Location = new System.Drawing.Point(4, 4);
            this.ic_base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ic_base.MinimumSize = new System.Drawing.Size(487, 234);
            this.ic_base.Name = "ic_base";
            this.ic_base.Size = new System.Drawing.Size(487, 234);
            this.ic_base.TabIndex = 14;
            // 
            // dS_Master
            // 
            this.dS_Master.DataSetName = "DS_Master";
            this.dS_Master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UC_Departs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ir_departs);
            this.Controls.Add(this.ic_base);
            this.Controls.Add(this.tb_noArrivee);
            this.Controls.Add(this.lb_noArrivee);
            this.Name = "UC_Departs";
            this.Size = new System.Drawing.Size(1297, 532);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_noArrivee;
        private System.Windows.Forms.TextBox tb_noArrivee;
        private UserControls.IC_Base ic_base;
        private UserControls.Info_Reservation.IR_Depart ir_departs;
        private DS_Master dS_Master;
    }
}
