namespace PrjEq01_Application.UserControls.Liste_Chambre
{
	partial class LC_Arrive
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
			this.GroupBox_ListeChambres.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_chambre)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_chambre
			// 
			this.dgv_chambre.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chambre_CellDoubleClick);
			// 
			// LC_Arrive
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "LC_Arrive";
			this.GroupBox_ListeChambres.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_chambre)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
	}
}
