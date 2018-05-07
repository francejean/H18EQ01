namespace PrjEq01_Application.UserControls.Liste_Chambre
{
	partial class LC_Reserv
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
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.GroupBox_ListeChambres.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_chambre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// LC_Reserv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "LC_Reserv";
			this.GroupBox_ListeChambres.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_chambre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
