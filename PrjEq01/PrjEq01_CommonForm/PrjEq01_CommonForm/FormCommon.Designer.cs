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
			this.ts_main = new System.Windows.Forms.ToolStrip();
			this.button_add = new System.Windows.Forms.ToolStripButton();
			this.button_edit = new System.Windows.Forms.ToolStripButton();
			this.button_delete = new System.Windows.Forms.ToolStripButton();
			this.button_forwardAll = new System.Windows.Forms.ToolStripButton();
			this.button_forwardOne = new System.Windows.Forms.ToolStripButton();
			this.button_backOne = new System.Windows.Forms.ToolStripButton();
			this.button_backAll = new System.Windows.Forms.ToolStripButton();
			this.button_undo = new System.Windows.Forms.ToolStripButton();
			this.button_save = new System.Windows.Forms.ToolStripButton();
			this.tc_main = new System.Windows.Forms.TabControl();
			this.Tab_Clients = new PrjEq01_CommonForm.Tab_Interface();
			this.Tab_Chambres = new PrjEq01_CommonForm.Tab_Interface();
			this.Tab_Réservations = new PrjEq01_CommonForm.Tab_Interface();
			this.Tab_Arrivées = new PrjEq01_CommonForm.Tab_Interface();
			this.Tab_Départs = new PrjEq01_CommonForm.Tab_Interface();
			this.ts_main.SuspendLayout();
			this.tc_main.SuspendLayout();
			this.SuspendLayout();
			// 
			// ts_main
			// 
			this.ts_main.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_add,
            this.button_edit,
            this.button_delete,
            this.button_forwardAll,
            this.button_forwardOne,
            this.button_backOne,
            this.button_backAll,
            this.button_undo,
            this.button_save});
			this.ts_main.Location = new System.Drawing.Point(0, 0);
			this.ts_main.Name = "ts_main";
			this.ts_main.Size = new System.Drawing.Size(997, 27);
			this.ts_main.TabIndex = 1;
			this.ts_main.Text = "ts_main";
			// 
			// button_add
			// 
			this.button_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.button_add.Image = global::PrjEq01_CommonForm.Properties.Resources.Add_Hanan_;
			this.button_add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(24, 24);
			this.button_add.Text = "Ajouter";
			this.button_add.Click += new System.EventHandler(this.Button_Add_Click);
			// 
			// button_edit
			// 
			this.button_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.button_edit.Image = global::PrjEq01_CommonForm.Properties.Resources.Edit_Freepik_;
			this.button_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.button_edit.Name = "button_edit";
			this.button_edit.Size = new System.Drawing.Size(24, 24);
			this.button_edit.Text = "Modifier";
			this.button_edit.Click += new System.EventHandler(this.Button_Edit_Click);
			// 
			// button_delete
			// 
			this.button_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.button_delete.Image = global::PrjEq01_CommonForm.Properties.Resources.Delete_Freepik_;
			this.button_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(24, 24);
			this.button_delete.Text = "Supprimer";
			this.button_delete.Click += new System.EventHandler(this.Button_Delete_Click);
			// 
			// button_forwardAll
			// 
			this.button_forwardAll.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.button_forwardAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.button_forwardAll.Image = global::PrjEq01_CommonForm.Properties.Resources.Double_Right_Arrow_Dave_Gandy_;
			this.button_forwardAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.button_forwardAll.Name = "button_forwardAll";
			this.button_forwardAll.Size = new System.Drawing.Size(24, 24);
			this.button_forwardAll.Text = "Fin";
			this.button_forwardAll.Click += new System.EventHandler(this.Button_Forward_All_Click);
			// 
			// button_forwardOne
			// 
			this.button_forwardOne.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.button_forwardOne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.button_forwardOne.Image = global::PrjEq01_CommonForm.Properties.Resources.Right_Arrow_Google_;
			this.button_forwardOne.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.button_forwardOne.Name = "button_forwardOne";
			this.button_forwardOne.Size = new System.Drawing.Size(24, 24);
			this.button_forwardOne.Text = "Avant";
			this.button_forwardOne.Click += new System.EventHandler(this.Button_Forward_One_Click);
			// 
			// button_backOne
			// 
			this.button_backOne.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.button_backOne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.button_backOne.Image = global::PrjEq01_CommonForm.Properties.Resources.Left_Arrow_Google_;
			this.button_backOne.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.button_backOne.Name = "button_backOne";
			this.button_backOne.Size = new System.Drawing.Size(24, 24);
			this.button_backOne.Text = "Arrière";
			this.button_backOne.Click += new System.EventHandler(this.Button_Back_One_Click);
			// 
			// button_backAll
			// 
			this.button_backAll.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.button_backAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.button_backAll.Image = global::PrjEq01_CommonForm.Properties.Resources.Double_Left_Arrow_Dave_Gandy_;
			this.button_backAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.button_backAll.Name = "button_backAll";
			this.button_backAll.Size = new System.Drawing.Size(24, 24);
			this.button_backAll.Text = "Début";
			this.button_backAll.Click += new System.EventHandler(this.Button_Back_All_Click);
			// 
			// button_undo
			// 
			this.button_undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.button_undo.Enabled = false;
			this.button_undo.Image = global::PrjEq01_CommonForm.Properties.Resources.Back_Dave_Gandy_;
			this.button_undo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.button_undo.Name = "button_undo";
			this.button_undo.Size = new System.Drawing.Size(24, 24);
			this.button_undo.Text = "Revenir en arrière";
			this.button_undo.Click += new System.EventHandler(this.Button_Undo_Click);
			// 
			// button_save
			// 
			this.button_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.button_save.Enabled = false;
			this.button_save.Image = global::PrjEq01_CommonForm.Properties.Resources.Save_Smashicons_;
			this.button_save.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(24, 24);
			this.button_save.Text = "Sauvegarder";
			this.button_save.Click += new System.EventHandler(this.Button_Save_Click);
			// 
			// tc_main
			// 
			this.tc_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tc_main.Controls.Add(this.Tab_Clients);
			this.tc_main.Controls.Add(this.Tab_Chambres);
			this.tc_main.Controls.Add(this.Tab_Réservations);
			this.tc_main.Controls.Add(this.Tab_Arrivées);
			this.tc_main.Controls.Add(this.Tab_Départs);
			this.tc_main.Location = new System.Drawing.Point(9, 24);
			this.tc_main.Margin = new System.Windows.Forms.Padding(2);
			this.tc_main.Name = "tc_main";
			this.tc_main.SelectedIndex = 0;
			this.tc_main.Size = new System.Drawing.Size(979, 456);
			this.tc_main.TabIndex = 0;
			this.tc_main.SelectedIndexChanged += new System.EventHandler(this.tc_main_SelectedIndexChanged);
			// 
			// Tab_Clients
			// 
			this.Tab_Clients.Location = new System.Drawing.Point(4, 22);
			this.Tab_Clients.Name = "Tab_Clients";
			this.Tab_Clients.Size = new System.Drawing.Size(971, 430);
			this.Tab_Clients.TabIndex = 5;
			this.Tab_Clients.Text = "Clients";
			this.Tab_Clients.UseVisualStyleBackColor = true;
			// 
			// Tab_Chambres
			// 
			this.Tab_Chambres.Location = new System.Drawing.Point(4, 22);
			this.Tab_Chambres.Margin = new System.Windows.Forms.Padding(2);
			this.Tab_Chambres.Name = "Tab_Chambres";
			this.Tab_Chambres.Size = new System.Drawing.Size(971, 430);
			this.Tab_Chambres.TabIndex = 2;
			this.Tab_Chambres.Text = "Chambres";
			this.Tab_Chambres.uc_tab = null;
			this.Tab_Chambres.UseVisualStyleBackColor = true;
			// 
			// Tab_Réservations
			// 
			this.Tab_Réservations.Location = new System.Drawing.Point(4, 22);
			this.Tab_Réservations.Margin = new System.Windows.Forms.Padding(2);
			this.Tab_Réservations.Name = "Tab_Réservations";
			this.Tab_Réservations.Padding = new System.Windows.Forms.Padding(2);
			this.Tab_Réservations.Size = new System.Drawing.Size(971, 430);
			this.Tab_Réservations.TabIndex = 1;
			this.Tab_Réservations.Text = "Réservations";
			this.Tab_Réservations.uc_tab = null;
			this.Tab_Réservations.UseVisualStyleBackColor = true;
			// 
			// Tab_Arrivées
			// 
			this.Tab_Arrivées.Location = new System.Drawing.Point(4, 22);
			this.Tab_Arrivées.Margin = new System.Windows.Forms.Padding(2);
			this.Tab_Arrivées.Name = "Tab_Arrivées";
			this.Tab_Arrivées.Size = new System.Drawing.Size(971, 430);
			this.Tab_Arrivées.TabIndex = 3;
			this.Tab_Arrivées.Text = "Arrivées";
			this.Tab_Arrivées.uc_tab = null;
			this.Tab_Arrivées.UseVisualStyleBackColor = true;
			// 
			// Tab_Départs
			// 
			this.Tab_Départs.Location = new System.Drawing.Point(4, 22);
			this.Tab_Départs.Margin = new System.Windows.Forms.Padding(2);
			this.Tab_Départs.Name = "Tab_Départs";
			this.Tab_Départs.Size = new System.Drawing.Size(971, 430);
			this.Tab_Départs.TabIndex = 4;
			this.Tab_Départs.Text = "Départs";
			this.Tab_Départs.uc_tab = null;
			this.Tab_Départs.UseVisualStyleBackColor = true;
			// 
			// FormCommon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 490);
			this.Controls.Add(this.ts_main);
			this.Controls.Add(this.tc_main);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormCommon";
			this.Text = "FormCommon";
			this.ts_main.ResumeLayout(false);
			this.ts_main.PerformLayout();
			this.tc_main.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        protected Tab_Interface Tab_Réservations;
        protected Tab_Interface Tab_Chambres;
        protected Tab_Interface Tab_Arrivées;
        protected Tab_Interface Tab_Départs;
		protected Tab_Interface Tab_Clients;
		protected System.Windows.Forms.TabControl tc_main;
        internal System.Windows.Forms.ToolStrip ts_main;
        internal System.Windows.Forms.ToolStripButton button_add;
        internal System.Windows.Forms.ToolStripButton button_delete;
        internal System.Windows.Forms.ToolStripButton button_forwardAll;
        internal System.Windows.Forms.ToolStripButton button_forwardOne;
        internal System.Windows.Forms.ToolStripButton button_backOne;
        internal System.Windows.Forms.ToolStripButton button_backAll;
        internal System.Windows.Forms.ToolStripButton button_edit;
        internal System.Windows.Forms.ToolStripButton button_undo;
        internal System.Windows.Forms.ToolStripButton button_save;
		
	}
}