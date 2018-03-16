namespace PrjEq01_Application.UserControls.Info_Reservation
{
    partial class IR_Depart
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
            this.tb_confirmerPar = new System.Windows.Forms.TextBox();
            this.lb_confirmerPar = new System.Windows.Forms.Label();
            this.gb_reserv.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_reserv
            // 
            this.gb_reserv.Controls.Add(this.tb_confirmerPar);
            this.gb_reserv.Controls.Add(this.lb_confirmerPar);
            this.gb_reserv.Controls.SetChildIndex(this.tb_noReserv, 0);
            this.gb_reserv.Controls.SetChildIndex(this.DTP_Reserv, 0);
            this.gb_reserv.Controls.SetChildIndex(this.DTP_Debut, 0);
            this.gb_reserv.Controls.SetChildIndex(this.DTP_Fin, 0);
            this.gb_reserv.Controls.SetChildIndex(this.lb_confirmerPar, 0);
            this.gb_reserv.Controls.SetChildIndex(this.tb_confirmerPar, 0);
            // 
            // tb_confirmerPar
            // 
            this.tb_confirmerPar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_confirmerPar.Location = new System.Drawing.Point(129, 169);
            this.tb_confirmerPar.Margin = new System.Windows.Forms.Padding(4);
            this.tb_confirmerPar.Name = "tb_confirmerPar";
            this.tb_confirmerPar.Size = new System.Drawing.Size(128, 22);
            this.tb_confirmerPar.TabIndex = 27;
            // 
            // lb_confirmerPar
            // 
            this.lb_confirmerPar.AutoSize = true;
            this.lb_confirmerPar.Location = new System.Drawing.Point(9, 172);
            this.lb_confirmerPar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_confirmerPar.Name = "lb_confirmerPar";
            this.lb_confirmerPar.Size = new System.Drawing.Size(89, 17);
            this.lb_confirmerPar.TabIndex = 26;
            this.lb_confirmerPar.Text = "Confirmé par";
            // 
            // IR_Depart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "IR_Depart";
            this.gb_reserv.ResumeLayout(false);
            this.gb_reserv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox tb_confirmerPar;
        private System.Windows.Forms.Label lb_confirmerPar;
    }
}
