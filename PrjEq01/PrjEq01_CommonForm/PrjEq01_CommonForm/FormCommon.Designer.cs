namespace PrjEq01_CommonForm
{
    partial class FormCommon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommon));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Tab_Clients = new System.Windows.Forms.TabPage();
			this.Tab_Réservations = new System.Windows.Forms.TabPage();
			this.Tab_Chambres = new System.Windows.Forms.TabPage();
			this.Tab_Arrivées = new System.Windows.Forms.TabPage();
			this.Tab_Départs = new System.Windows.Forms.TabPage();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.Button_Add = new System.Windows.Forms.ToolStripButton();
			this.Button_Edit = new System.Windows.Forms.ToolStripButton();
			this.Button_Delete = new System.Windows.Forms.ToolStripButton();
			this.Button_Forward_All = new System.Windows.Forms.ToolStripButton();
			this.Button_Forward_One = new System.Windows.Forms.ToolStripButton();
			this.Button_Back_One = new System.Windows.Forms.ToolStripButton();
			this.Button_Back_All = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.tabControl1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.Tab_Clients);
			this.tabControl1.Controls.Add(this.Tab_Réservations);
			this.tabControl1.Controls.Add(this.Tab_Chambres);
			this.tabControl1.Controls.Add(this.Tab_Arrivées);
			this.tabControl1.Controls.Add(this.Tab_Départs);
			this.tabControl1.Location = new System.Drawing.Point(9, 24);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(979, 456);
			this.tabControl1.TabIndex = 0;
			// 
			// Tab_Clients
			// 
			this.Tab_Clients.Location = new System.Drawing.Point(4, 22);
			this.Tab_Clients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Tab_Clients.Name = "Tab_Clients";
			this.Tab_Clients.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Tab_Clients.Size = new System.Drawing.Size(971, 430);
			this.Tab_Clients.TabIndex = 0;
			this.Tab_Clients.Text = "Clients";
			this.Tab_Clients.UseVisualStyleBackColor = true;
			// 
			// Tab_Réservations
			// 
			this.Tab_Réservations.Location = new System.Drawing.Point(4, 22);
			this.Tab_Réservations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Tab_Réservations.Name = "Tab_Réservations";
			this.Tab_Réservations.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Tab_Réservations.Size = new System.Drawing.Size(971, 430);
			this.Tab_Réservations.TabIndex = 1;
			this.Tab_Réservations.Text = "Réservations";
			this.Tab_Réservations.UseVisualStyleBackColor = true;
			// 
			// Tab_Chambres
			// 
			this.Tab_Chambres.Location = new System.Drawing.Point(4, 22);
			this.Tab_Chambres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Tab_Chambres.Name = "Tab_Chambres";
			this.Tab_Chambres.Size = new System.Drawing.Size(971, 430);
			this.Tab_Chambres.TabIndex = 2;
			this.Tab_Chambres.Text = "Chambres";
			this.Tab_Chambres.UseVisualStyleBackColor = true;
			// 
			// Tab_Arrivées
			// 
			this.Tab_Arrivées.Location = new System.Drawing.Point(4, 22);
			this.Tab_Arrivées.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Tab_Arrivées.Name = "Tab_Arrivées";
			this.Tab_Arrivées.Size = new System.Drawing.Size(971, 430);
			this.Tab_Arrivées.TabIndex = 3;
			this.Tab_Arrivées.Text = "Arrivées";
			this.Tab_Arrivées.UseVisualStyleBackColor = true;
			// 
			// Tab_Départs
			// 
			this.Tab_Départs.Location = new System.Drawing.Point(4, 22);
			this.Tab_Départs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Tab_Départs.Name = "Tab_Départs";
			this.Tab_Départs.Size = new System.Drawing.Size(971, 430);
			this.Tab_Départs.TabIndex = 4;
			this.Tab_Départs.Text = "Départs";
			this.Tab_Départs.UseVisualStyleBackColor = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Add,
            this.Button_Edit,
            this.Button_Delete,
            this.Button_Forward_All,
            this.Button_Forward_One,
            this.Button_Back_One,
            this.Button_Back_All,
            this.toolStripButton1,
            this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(997, 27);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// Button_Add
			// 
			this.Button_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Button_Add.Image = global::PrjEq01_CommonForm.Properties.Resources.Add_Hanan_;
			this.Button_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button_Add.Name = "Button_Add";
			this.Button_Add.Size = new System.Drawing.Size(24, 24);
			this.Button_Add.Text = "Button_Add";
			// 
			// Button_Edit
			// 
			this.Button_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Button_Edit.Image = global::PrjEq01_CommonForm.Properties.Resources.Edit_Freepik_;
			this.Button_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button_Edit.Name = "Button_Edit";
			this.Button_Edit.Size = new System.Drawing.Size(24, 24);
			this.Button_Edit.Text = "Button_Edit";
			// 
			// Button_Delete
			// 
			this.Button_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Button_Delete.Image = global::PrjEq01_CommonForm.Properties.Resources.Delete_Freepik_;
			this.Button_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button_Delete.Name = "Button_Delete";
			this.Button_Delete.Size = new System.Drawing.Size(24, 24);
			this.Button_Delete.Text = "Button_Delete";
			// 
			// Button_Forward_All
			// 
			this.Button_Forward_All.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.Button_Forward_All.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Button_Forward_All.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button_Forward_All.Name = "Button_Forward_All";
			this.Button_Forward_All.Size = new System.Drawing.Size(23, 24);
			this.Button_Forward_All.Text = "Button_Forward_All";
			// 
			// Button_Forward_One
			// 
			this.Button_Forward_One.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.Button_Forward_One.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Button_Forward_One.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button_Forward_One.Name = "Button_Forward_One";
			this.Button_Forward_One.Size = new System.Drawing.Size(23, 24);
			this.Button_Forward_One.Text = "Button_Forward_One";
			// 
			// Button_Back_One
			// 
			this.Button_Back_One.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.Button_Back_One.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Button_Back_One.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button_Back_One.Name = "Button_Back_One";
			this.Button_Back_One.Size = new System.Drawing.Size(23, 24);
			this.Button_Back_One.Text = "Button_Back_One";
			// 
			// Button_Back_All
			// 
			this.Button_Back_All.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.Button_Back_All.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Button_Back_All.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Button_Back_All.Name = "Button_Back_All";
			this.Button_Back_All.Size = new System.Drawing.Size(23, 24);
			this.Button_Back_All.Text = "Button_Back_All";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::PrjEq01_CommonForm.Properties.Resources.Back_Dave_Gandy_;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = global::PrjEq01_CommonForm.Properties.Resources.Save_Smashicons_;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// FormCommon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 490);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FormCommon";
			this.Text = "Système de réservation en hébergement";
			this.tabControl1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Button_Add;
        private System.Windows.Forms.ToolStripButton Button_Delete;
        private System.Windows.Forms.ToolStripButton Button_Forward_All;
        private System.Windows.Forms.ToolStripButton Button_Forward_One;
        private System.Windows.Forms.ToolStripButton Button_Back_One;
        private System.Windows.Forms.ToolStripButton Button_Back_All;
        private System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage Tab_Clients;
        protected System.Windows.Forms.TabPage Tab_Réservations;
        protected System.Windows.Forms.TabPage Tab_Chambres;
        protected System.Windows.Forms.TabPage Tab_Arrivées;
        protected System.Windows.Forms.TabPage Tab_Départs;
        private System.Windows.Forms.ToolStripButton Button_Edit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}