namespace PrjEq01_Application.List_Forms
{
	partial class LF_ChambreNoCham
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
			this.components = new System.ComponentModel.Container();
			this.BS_CHAMBRE = new System.Windows.Forms.BindingSource(this.components);
			this.dS_Master = new PrjEq01_Application.DS_Master();
			this.TA_CHAMBRE = new PrjEq01_Application.DS_MasterTableAdapters.CHAMBRETableAdapter();
			this.NoCham = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Etage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CodLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CodTypCham = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dS_Master)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_main
			// 
			this.dgv_main.AllowUserToResizeColumns = true;
			this.dgv_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.NoCham,
			this.Etage,
			this.Prix,
			this.Etat,
			this.Memo,
			this.CodLoc,
			this.CodTypCham});
			this.dgv_main.RowTemplate.Height = 24;
			// 
			// BS_CHAMBRE
			// 
			this.BS_CHAMBRE.DataMember = "CHAMBRE";
			this.BS_CHAMBRE.DataSource = this.dS_Master;
			// 
			// dS_Master
			// 
			this.dS_Master.DataSetName = "DS_Master";
			this.dS_Master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// TA_CHAMBRE
			// 
			this.TA_CHAMBRE.ClearBeforeFill = true;
			// 
			// NoCham
			// 
			this.NoCham.DataPropertyName = "NoCham";
			this.NoCham.HeaderText = "No. Cham";
			this.NoCham.Name = "NoCham";
			// 
			// Etage
			// 
			this.Etage.DataPropertyName = "Etage";
			this.Etage.HeaderText = "Étage";
			this.Etage.Name = "Etage";
			// 
			// Prix
			// 
			this.Prix.DataPropertyName = "Prix";
			this.Prix.HeaderText = "Prix";
			this.Prix.Name = "Prix";
			// 
			// Etat
			// 
			this.Etat.DataPropertyName = "Etat";
			this.Etat.HeaderText = "État";
			this.Etat.Name = "Etat";
			// 
			// Memo
			// 
			this.Memo.DataPropertyName = "Memo";
			this.Memo.HeaderText = "Mémo";
			this.Memo.Name = "Memo";
			// 
			// CodLoc
			// 
			this.CodLoc.DataPropertyName = "CodLoc";
			this.CodLoc.HeaderText = "Code location";
			this.CodLoc.Name = "CodLoc";
			// 
			// CodTypCham
			// 
			this.CodTypCham.DataPropertyName = "CodTypCham";
			this.CodTypCham.HeaderText = "Code type";
			this.CodTypCham.Name = "CodTypCham";
			// 
			// LF_ChambreNoCham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(981, 446);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MinimumSize = new System.Drawing.Size(983, 437);
			this.Name = "LF_ChambreNoCham";
			this.Text = "Liste de sélection sur No Chambre";
			this.Load += new System.EventHandler(this.LF_ChambreNoCham_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BS_CHAMBRE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dS_Master)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DS_Master dS_Master;
		private System.Windows.Forms.BindingSource BS_CHAMBRE;
		private DS_MasterTableAdapters.CHAMBRETableAdapter TA_CHAMBRE;
		private System.Windows.Forms.DataGridViewTextBoxColumn NoCham;
		private System.Windows.Forms.DataGridViewTextBoxColumn Etage;
		private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
		private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
		private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodLoc;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodTypCham;
	}
}