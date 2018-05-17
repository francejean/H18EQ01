namespace PrjEq01_Application.List_Forms
{
	partial class LF_Depart
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
			((System.ComponentModel.ISupportInitialize)(this.BS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_main
			// 
			this.dgv_main.RowTemplate.Height = 24;
			// 
			// LF_Depart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(981, 446);
			this.Name = "LF_Depart";
			this.Text = "Liste de sélection sur les départs";
			((System.ComponentModel.ISupportInitialize)(this.BS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
	}
}