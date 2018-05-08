namespace PrjEq01_Application.UserControls
{
	partial class LC_Base
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LC_Base));
			this.GroupBox_ListeChambres = new System.Windows.Forms.GroupBox();
			this.bt_listCommodite = new PrjEq01_CommonForm.Controls.Button_List();
			this.ds_master = new PrjEq01_Application.DS_Master();
			this.dgv_chambre = new PrjEq01_Application.UserControls.Inherit_DGV();
			this.noChamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descTypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Attribuee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GroupBox_ListeChambres.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_chambre)).BeginInit();
			this.SuspendLayout();
			// 
			// GroupBox_ListeChambres
			// 
			this.GroupBox_ListeChambres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBox_ListeChambres.Controls.Add(this.dgv_chambre);
			this.GroupBox_ListeChambres.Controls.Add(this.bt_listCommodite);
			this.GroupBox_ListeChambres.Location = new System.Drawing.Point(0, 0);
			this.GroupBox_ListeChambres.Name = "GroupBox_ListeChambres";
			this.GroupBox_ListeChambres.Size = new System.Drawing.Size(951, 256);
			this.GroupBox_ListeChambres.TabIndex = 0;
			this.GroupBox_ListeChambres.TabStop = false;
			this.GroupBox_ListeChambres.Text = "Liste des chambres";
			// 
			// bt_listCommodite
			// 
			this.bt_listCommodite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_listCommodite.BackgroundImage")));
			this.bt_listCommodite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bt_listCommodite.Enabled = false;
			this.bt_listCommodite.Location = new System.Drawing.Point(5, 18);
			this.bt_listCommodite.Margin = new System.Windows.Forms.Padding(2);
			this.bt_listCommodite.Name = "bt_listCommodite";
			this.bt_listCommodite.Size = new System.Drawing.Size(20, 20);
			this.bt_listCommodite.TabIndex = 10;
			this.bt_listCommodite.UseVisualStyleBackColor = true;
			this.bt_listCommodite.Click += new System.EventHandler(this.bt_list_Click);
			// 
			// ds_master
			// 
			this.ds_master.DataSetName = "DS_Master";
			this.ds_master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dgv_chambre
			// 
			this.dgv_chambre.AllowUserToAddRows = false;
			this.dgv_chambre.AllowUserToDeleteRows = false;
			this.dgv_chambre.AllowUserToResizeColumns = false;
			this.dgv_chambre.AllowUserToResizeRows = false;
			this.dgv_chambre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_chambre.AutoGenerateColumns = false;
			this.dgv_chambre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_chambre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgv_chambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noChamDataGridViewTextBoxColumn,
            this.descTypDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.Attribuee});
			this.dgv_chambre.Location = new System.Drawing.Point(30, 18);
			this.dgv_chambre.Name = "dgv_chambre";
			this.dgv_chambre.ReadOnly = true;
			this.dgv_chambre.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgv_chambre.RowHeadersVisible = false;
			this.dgv_chambre.Size = new System.Drawing.Size(915, 233);
			this.dgv_chambre.TabIndex = 2;
			// 
			// noChamDataGridViewTextBoxColumn
			// 
			this.noChamDataGridViewTextBoxColumn.DataPropertyName = "NoCham";
			this.noChamDataGridViewTextBoxColumn.HeaderText = "No. chambre";
			this.noChamDataGridViewTextBoxColumn.Name = "noChamDataGridViewTextBoxColumn";
			this.noChamDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descTypDataGridViewTextBoxColumn
			// 
			this.descTypDataGridViewTextBoxColumn.DataPropertyName = "CodTypCham";
			this.descTypDataGridViewTextBoxColumn.HeaderText = "Type de chambre";
			this.descTypDataGridViewTextBoxColumn.Name = "descTypDataGridViewTextBoxColumn";
			this.descTypDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// prixDataGridViewTextBoxColumn
			// 
			this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
			this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
			this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
			this.prixDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Attribuee
			// 
			this.Attribuee.DataPropertyName = "Attribuee";
			this.Attribuee.HeaderText = "Attribuée";
			this.Attribuee.Name = "Attribuee";
			this.Attribuee.ReadOnly = true;
			// 
			// LC_Base
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.GroupBox_ListeChambres);
			this.MinimumSize = new System.Drawing.Size(850, 230);
			this.Name = "LC_Base";
			this.Size = new System.Drawing.Size(951, 256);
			this.GroupBox_ListeChambres.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_chambre)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.GroupBox GroupBox_ListeChambres;
		protected PrjEq01_CommonForm.Controls.Button_List bt_listCommodite;
		private System.Windows.Forms.DataGridViewTextBoxColumn noChamDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descTypDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Attribuee;
		public Inherit_DGV dgv_chambre;
		protected DS_Master ds_master;
	}
}
