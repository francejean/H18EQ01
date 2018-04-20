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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Departs));
            this.lb_noArrivee = new System.Windows.Forms.Label();
            this.tb_noArrivee = new System.Windows.Forms.TextBox();
            this.dS_Master = new PrjEq01_Application.DS_Master();
            this.bt_listArrivee = new PrjEq01_CommonForm.Controls.Button_List();
            this.gb_infoDeparts = new System.Windows.Forms.GroupBox();
            this.dgv_departs = new System.Windows.Forms.DataGridView();
            this.BS_ARRIVE = new System.Windows.Forms.BindingSource(this.components);
            this.BS_CLIENT = new System.Windows.Forms.BindingSource(this.components);
            this.BS_DEPART = new System.Windows.Forms.BindingSource(this.components);
            this.BS_RESERVATION = new System.Windows.Forms.BindingSource(this.components);
            this.TA_CLIENT = new PrjEq01_Application.DS_MasterTableAdapters.CLIENTTableAdapter();
            this.TA_DEPART = new PrjEq01_Application.DS_MasterTableAdapters.DEPARTTableAdapter();
            this.TA_RESERVATION = new PrjEq01_Application.DS_MasterTableAdapters.RESERVATIONTableAdapter();
            this.TA_ARRIVE = new PrjEq01_Application.DS_MasterTableAdapters.ARRIVETableAdapter();
            this.ir_departs = new PrjEq01_Application.UserControls.Info_Reservation.IR_Depart();
            this.ic_base = new PrjEq01_Application.UserControls.IC_Base();
            this.IdDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmerPar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).BeginInit();
            this.gb_infoDeparts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_departs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_ARRIVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_DEPART)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).BeginInit();
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
            // dS_Master
            // 
            this.dS_Master.DataSetName = "DS_Master";
            this.dS_Master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_listArrivee
            // 
            this.bt_listArrivee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_listArrivee.BackgroundImage")));
            this.bt_listArrivee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_listArrivee.Location = new System.Drawing.Point(913, 22);
            this.bt_listArrivee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_listArrivee.Name = "bt_listArrivee";
            this.bt_listArrivee.Size = new System.Drawing.Size(27, 25);
            this.bt_listArrivee.TabIndex = 16;
            this.bt_listArrivee.UseVisualStyleBackColor = true;
            this.bt_listArrivee.Click += new System.EventHandler(this.bt_list_Click);
            // 
            // gb_infoDeparts
            // 
            this.gb_infoDeparts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_infoDeparts.Controls.Add(this.dgv_departs);
            this.gb_infoDeparts.Location = new System.Drawing.Point(4, 246);
            this.gb_infoDeparts.Name = "gb_infoDeparts";
            this.gb_infoDeparts.Size = new System.Drawing.Size(936, 283);
            this.gb_infoDeparts.TabIndex = 17;
            this.gb_infoDeparts.TabStop = false;
            this.gb_infoDeparts.Text = "Informations sur les départs";
            // 
            // dgv_departs
            // 
            this.dgv_departs.AllowUserToAddRows = false;
            this.dgv_departs.AllowUserToDeleteRows = false;
            this.dgv_departs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_departs.AutoGenerateColumns = false;
            this.dgv_departs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_departs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDepart,
            this.ConfirmerPar,
            this.DateDepart,
            this.NoCham,
            this.IdCli,
            this.Nom});
            this.dgv_departs.DataSource = this.BS_DEPART;
            this.dgv_departs.Location = new System.Drawing.Point(6, 21);
            this.dgv_departs.Name = "dgv_departs";
            this.dgv_departs.ReadOnly = true;
            this.dgv_departs.RowHeadersVisible = false;
            this.dgv_departs.RowTemplate.Height = 24;
            this.dgv_departs.Size = new System.Drawing.Size(924, 256);
            this.dgv_departs.TabIndex = 0;
            // 
            // TA_CLIENT
            // 
            this.TA_CLIENT.ClearBeforeFill = true;
            // 
            // TA_DEPART
            // 
            this.TA_DEPART.ClearBeforeFill = true;
            // 
            // TA_RESERVATION
            // 
            this.TA_RESERVATION.ClearBeforeFill = true;
            // 
            // TA_ARRIVE
            // 
            this.TA_ARRIVE.ClearBeforeFill = true;
            // 
            // ir_departs
            // 
            this.ir_departs.Location = new System.Drawing.Point(499, 4);
            this.ir_departs.Margin = new System.Windows.Forms.Padding(4);
            this.ir_departs.MinimumSize = new System.Drawing.Size(267, 234);
            this.ir_departs.Name = "ir_departs";
            this.ir_departs.Size = new System.Drawing.Size(267, 234);
            this.ir_departs.ReservSelected = null;
            this.ir_departs.TabIndex = 15;
            // 
            // ic_base
            // 
            this.ic_base.Location = new System.Drawing.Point(4, 4);
            this.ic_base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ic_base.MinimumSize = new System.Drawing.Size(487, 234);
            this.ic_base.Name = "ic_base";
            this.ic_base.Size = new System.Drawing.Size(487, 234);
            this.ic_base.ClientSelected = null;
            this.ic_base.TabIndex = 14;
            // 
            // IdDepart
            // 
            this.IdDepart.DataPropertyName = "IdDepart";
            this.IdDepart.HeaderText = "No.Départ";
            this.IdDepart.Name = "IdDepart";
            this.IdDepart.ReadOnly = true;
            // 
            // ConfirmerPar
            // 
            this.ConfirmerPar.DataPropertyName = "ConfirmerPar";
            this.ConfirmerPar.HeaderText = "Conf.Par";
            this.ConfirmerPar.Name = "ConfirmerPar";
            this.ConfirmerPar.ReadOnly = true;
            // 
            // DateDepart
            // 
            this.DateDepart.DataPropertyName = "DateDepart";
            this.DateDepart.HeaderText = "Date de départ";
            this.DateDepart.Name = "DateDepart";
            this.DateDepart.ReadOnly = true;
            this.DateDepart.Width = 150;
            // 
            // NoCham
            // 
            this.NoCham.DataPropertyName = "NoCham";
            this.NoCham.HeaderText = "No.Chambre";
            this.NoCham.Name = "NoCham";
            this.NoCham.ReadOnly = true;
            // 
            // IdCli
            // 
            this.IdCli.DataPropertyName = "IdCli";
            this.IdCli.HeaderText = "No.Client";
            this.IdCli.Name = "IdCli";
            this.IdCli.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // UC_Departs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_infoDeparts);
            this.Controls.Add(this.bt_listArrivee);
            this.Controls.Add(this.ir_departs);
            this.Controls.Add(this.ic_base);
            this.Controls.Add(this.tb_noArrivee);
            this.Controls.Add(this.lb_noArrivee);
            this.Name = "UC_Departs";
            this.Size = new System.Drawing.Size(1297, 532);
            this.Load += new System.EventHandler(this.Tab_Departs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Master)).EndInit();
            this.gb_infoDeparts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_departs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_ARRIVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CLIENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_DEPART)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_RESERVATION)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_noArrivee;
        private System.Windows.Forms.TextBox tb_noArrivee;
        private UserControls.IC_Base ic_base;
        private UserControls.Info_Reservation.IR_Depart ir_departs;
        private DS_Master dS_Master;
        public PrjEq01_CommonForm.Controls.Button_List bt_listArrivee;
        private System.Windows.Forms.GroupBox gb_infoDeparts;
        private System.Windows.Forms.DataGridView dgv_departs;
        private System.Windows.Forms.BindingSource BS_ARRIVE;
        private System.Windows.Forms.BindingSource BS_CLIENT;
        private System.Windows.Forms.BindingSource BS_DEPART;
        private System.Windows.Forms.BindingSource BS_RESERVATION;
        private DS_MasterTableAdapters.CLIENTTableAdapter TA_CLIENT;
        private DS_MasterTableAdapters.DEPARTTableAdapter TA_DEPART;
        private DS_MasterTableAdapters.RESERVATIONTableAdapter TA_RESERVATION;
        private DS_MasterTableAdapters.ARRIVETableAdapter TA_ARRIVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmerPar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCham;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
    }
}
