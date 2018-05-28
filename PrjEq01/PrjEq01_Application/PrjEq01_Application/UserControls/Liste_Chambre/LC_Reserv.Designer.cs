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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LC_Reserv));
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.bt_deleteRow = new PrjEq01_CommonForm.Controls.Button_List();
			this.GroupBox_ListeChambres.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_chambre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// GroupBox_ListeChambres
			// 
			this.GroupBox_ListeChambres.Controls.Add(this.bt_deleteRow);
			this.GroupBox_ListeChambres.Controls.SetChildIndex(this.bt_listCommodite, 0);
			this.GroupBox_ListeChambres.Controls.SetChildIndex(this.dgv_chambre, 0);
			this.GroupBox_ListeChambres.Controls.SetChildIndex(this.bt_deleteRow, 0);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// bt_deleteRow
			// 
			this.bt_deleteRow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_deleteRow.BackgroundImage")));
			this.bt_deleteRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bt_deleteRow.Enabled = false;
			this.bt_deleteRow.Location = new System.Drawing.Point(5, 42);
			this.bt_deleteRow.Margin = new System.Windows.Forms.Padding(2);
			this.bt_deleteRow.Name = "bt_deleteRow";
			this.bt_deleteRow.Size = new System.Drawing.Size(20, 20);
			this.bt_deleteRow.TabIndex = 11;
			this.bt_deleteRow.UseVisualStyleBackColor = true;
			this.bt_deleteRow.Click += new System.EventHandler(this.bt_deleteRow_Click);
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
		protected PrjEq01_CommonForm.Controls.Button_List bt_deleteRow;
	}
}
