namespace PrjEq01_Application.List_Forms
{
    partial class LF_Reservation
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
            this.ds_master = new PrjEq01_Application.DS_Master();
            ((System.ComponentModel.ISupportInitialize)(this.BS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_master)).BeginInit();
            this.SuspendLayout();
            // 
            // ds_master
            // 
            this.ds_master.DataSetName = "DS_Master";
            this.ds_master.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LF_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 362);
            this.Name = "LF_Reservation";
            this.Text = "Liste des réservations";
            ((System.ComponentModel.ISupportInitialize)(this.BS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_master)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_Master ds_master;
    }
}
