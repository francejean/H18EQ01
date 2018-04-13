﻿namespace PrjEq01_Application.Tabs
{
    partial class UC_Arrive
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
            this.lb_noArrive = new System.Windows.Forms.Label();
            this.tb_noArrive = new System.Windows.Forms.TextBox();
            this.TA_ARRIVE = new PrjEq01_Application.DS_MasterTableAdapters.ARRIVETableAdapter();
            this.TA_RESERVATION = new PrjEq01_Application.DS_MasterTableAdapters.RESERVATIONTableAdapter();
            this.ds_master = new PrjEq01_Application.DS_Master();
            this.BS_ARRIVE = new System.Windows.Forms.BindingSource(this.components);
            this.BS_RESERVATION = new System.Windows.Forms.BindingSource(this.components);
            this.TA_CLIENT = new PrjEq01_Application.DS_MasterTableAdapters.CLIENTTableAdapter();
            this.BS_CLIENT = new System.Windows.Forms.BindingSource(this.components);
            this.TA_CHAMBRE = new PrjEq01_Application.DS_MasterTableAdapters.CHAMBRETableAdapter();
            this.BS_CHAMBRE = new System.Windows.Forms.BindingSource(this.components);
            this.ir_arrive = new PrjEq01_Application.UserControls.Info_Reservation.IR_Arrive();
            this.ic_arrive = new PrjEq01_Application.UserControls.Info_Client.IC_Arrive();
            this.TA_DE = new PrjEq01_Application.DS_MasterTableAdapters.DETableAdapter();
            this.BS_DE = new System.Windows.Forms.BindingSource(this.components);
            this.lc_base = new PrjEq01_Application.UserControls.LC_Base();
            ((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_ARRIVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_DE)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_noArrive
            // 
            this.lb_noArrive.AutoSize = true;
            this.lb_noArrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_noArrive.Location = new System.Drawing.Point(580, 3);
            this.lb_noArrive.Name = "lb_noArrive";
            this.lb_noArrive.Size = new System.Drawing.Size(60, 13);
            this.lb_noArrive.TabIndex = 11;
            this.lb_noArrive.Text = "No. Arrivee";
            // 
            // tb_noArrive
            // 
            this.tb_noArrive.Location = new System.Drawing.Point(580, 19);
            this.tb_noArrive.Name = "tb_noArrive";
            this.tb_noArrive.ReadOnly = true;
            this.tb_noArrive.Size = new System.Drawing.Size(100, 20);
            this.tb_noArrive.TabIndex = 12;
            // 
            // TA_ARRIVE
            // 
            this.TA_ARRIVE.ClearBeforeFill = true;
            // 
            // TA_RESERVATION
            // 
            this.TA_RESERVATION.ClearBeforeFill = true;
            // 
            // ds_master
            // 
            this.ds_master.DataSetName = "DS_Master";
            this.ds_master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TA_CLIENT
            // 
            this.TA_CLIENT.ClearBeforeFill = true;
            // 
            // TA_CHAMBRE
            // 
            this.TA_CHAMBRE.ClearBeforeFill = true;
            // 
            // ir_arrive
            // 
            this.ir_arrive.Location = new System.Drawing.Point(374, 3);
            this.ir_arrive.MinimumSize = new System.Drawing.Size(200, 190);
            this.ir_arrive.Name = "ir_arrive";
            this.ir_arrive.Size = new System.Drawing.Size(200, 190);
            this.ir_arrive.TabIndex = 14;
            // 
            // ic_arrive
            // 
            this.ic_arrive.Location = new System.Drawing.Point(3, 3);
            this.ic_arrive.MinimumSize = new System.Drawing.Size(365, 190);
            this.ic_arrive.Name = "ic_arrive";
            this.ic_arrive.Size = new System.Drawing.Size(365, 190);
            this.ic_arrive.TabIndex = 13;
            // 
            // TA_DE
            // 
            this.TA_DE.ClearBeforeFill = true;
            // 
            // lc_base
            // 
            this.lc_base.Location = new System.Drawing.Point(3, 199);
            this.lc_base.MinimumSize = new System.Drawing.Size(850, 230);
            this.lc_base.Name = "lc_base";
            this.lc_base.Size = new System.Drawing.Size(967, 230);
            this.lc_base.TabIndex = 15;
            // 
            // UC_Arrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_base);
            this.Controls.Add(this.ir_arrive);
            this.Controls.Add(this.ic_arrive);
            this.Controls.Add(this.tb_noArrive);
            this.Controls.Add(this.lb_noArrive);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Arrive";
            this.Size = new System.Drawing.Size(973, 432);
            this.Load += new System.EventHandler(this.Tab_Arrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_ARRIVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_DE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_noArrive;
        private System.Windows.Forms.TextBox tb_noArrive;
        private DS_MasterTableAdapters.ARRIVETableAdapter TA_ARRIVE;
        private DS_MasterTableAdapters.RESERVATIONTableAdapter TA_RESERVATION;
        private DS_Master ds_master;
        private System.Windows.Forms.BindingSource BS_ARRIVE;
        private System.Windows.Forms.BindingSource BS_RESERVATION;
        private DS_MasterTableAdapters.CLIENTTableAdapter TA_CLIENT;
        private System.Windows.Forms.BindingSource BS_CLIENT;
        private DS_MasterTableAdapters.CHAMBRETableAdapter TA_CHAMBRE;
		private UserControls.Info_Client.IC_Arrive ic_arrive;
		private UserControls.Info_Reservation.IR_Arrive ir_arrive;
        public System.Windows.Forms.BindingSource BS_CHAMBRE;
        private DS_MasterTableAdapters.DETableAdapter TA_DE;
        private System.Windows.Forms.BindingSource BS_DE;
        private UserControls.LC_Base lc_base;
    }
}
