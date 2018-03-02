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
            this.Label_Num_Arrivee = new System.Windows.Forms.Label();
            this.TextBox_NoArrive = new System.Windows.Forms.TextBox();
            this.TA_ARRIVE = new PrjEq01_Application.DS_MasterTableAdapters.ARRIVETableAdapter();
            this.TA_RESERVATION = new PrjEq01_Application.DS_MasterTableAdapters.RESERVATIONTableAdapter();
            this.TA_DEPART = new PrjEq01_Application.DS_MasterTableAdapters.DEPARTTableAdapter();
            this.TA_TRX = new PrjEq01_Application.DS_MasterTableAdapters.TRXTableAdapter();
            this.DS_Master = new PrjEq01_Application.DS_Master();
            this.BS_ARRIVE = new System.Windows.Forms.BindingSource(this.components);
            this.BS_RESERVATION = new System.Windows.Forms.BindingSource(this.components);
            this.BS_DEPART = new System.Windows.Forms.BindingSource(this.components);
            this.BS_TRX = new System.Windows.Forms.BindingSource(this.components);
            this.TA_CLIENT = new PrjEq01_Application.DS_MasterTableAdapters.CLIENTTableAdapter();
            this.BS_CLIENT = new System.Windows.Forms.BindingSource(this.components);
            this.Liste_Chambre = new PrjEq01_Application.UserControls.Liste_Chambre();
            this.TA_CHAMBRE = new PrjEq01_Application.DS_MasterTableAdapters.CHAMBRETableAdapter();
            this.BS_CHAMBRE = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_ARRIVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_DEPART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TRX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).BeginInit();
            this.SuspendLayout();
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
            // TextBox_NoArrive
            // 
            this.TextBox_NoArrive.Location = new System.Drawing.Point(580, 19);
            this.TextBox_NoArrive.Name = "TextBox_NoArrive";
            this.TextBox_NoArrive.Size = new System.Drawing.Size(100, 20);
            this.TextBox_NoArrive.TabIndex = 12;
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
            // TA_CLIENT
            // 
            this.TA_CLIENT.ClearBeforeFill = true;
            // 
            // Liste_Chambre
            // 
            this.Liste_Chambre.Location = new System.Drawing.Point(3, 199);
            this.Liste_Chambre.Margin = new System.Windows.Forms.Padding(4);
            this.Liste_Chambre.MinimumSize = new System.Drawing.Size(850, 230);
            this.Liste_Chambre.Name = "Liste_Chambre";
            this.Liste_Chambre.Size = new System.Drawing.Size(850, 230);
            this.Liste_Chambre.TabIndex = 2;
            // 
            // TA_CHAMBRE
            // 
            this.TA_CHAMBRE.ClearBeforeFill = true;
            // 
            // Tab_Arrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox_NoArrive);
            this.Controls.Add(this.Label_Num_Arrivee);
            this.Controls.Add(this.Liste_Chambre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tab_Arrive";
            this.Size = new System.Drawing.Size(973, 432);
            this.Load += new System.EventHandler(this.Tab_Arrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_ARRIVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_DEPART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_TRX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.Liste_Chambre Liste_Chambre;
        private System.Windows.Forms.Label Label_Num_Arrivee;
        private System.Windows.Forms.TextBox TextBox_NoArrive;
        private DS_MasterTableAdapters.ARRIVETableAdapter TA_ARRIVE;
        private DS_MasterTableAdapters.RESERVATIONTableAdapter TA_RESERVATION;
        private DS_MasterTableAdapters.DEPARTTableAdapter TA_DEPART;
        private DS_MasterTableAdapters.TRXTableAdapter TA_TRX;
        private DS_Master DS_Master;
        private System.Windows.Forms.BindingSource BS_ARRIVE;
        private System.Windows.Forms.BindingSource BS_RESERVATION;
        private System.Windows.Forms.BindingSource BS_DEPART;
        private System.Windows.Forms.BindingSource BS_TRX;
        private DS_MasterTableAdapters.CLIENTTableAdapter TA_CLIENT;
        private System.Windows.Forms.BindingSource BS_CLIENT;
        private DS_MasterTableAdapters.CHAMBRETableAdapter TA_CHAMBRE;
        private System.Windows.Forms.BindingSource BS_CHAMBRE;
    }
}
