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
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.Tab_Chambres = new System.Windows.Forms.TabPage();
            this.Tab_Réservations = new System.Windows.Forms.TabPage();
            this.Tab_Arrivées = new System.Windows.Forms.TabPage();
            this.Tab_Départs = new System.Windows.Forms.TabPage();
            this.ToolStrip_Main = new System.Windows.Forms.ToolStrip();
            this.Button_Add = new System.Windows.Forms.ToolStripButton();
            this.Button_Edit = new System.Windows.Forms.ToolStripButton();
            this.Button_Delete = new System.Windows.Forms.ToolStripButton();
            this.Button_Forward_All = new System.Windows.Forms.ToolStripButton();
            this.Button_Forward_One = new System.Windows.Forms.ToolStripButton();
            this.Button_Back_One = new System.Windows.Forms.ToolStripButton();
            this.Button_Back_All = new System.Windows.Forms.ToolStripButton();
            this.Button_Undo = new System.Windows.Forms.ToolStripButton();
            this.Button_Save = new System.Windows.Forms.ToolStripButton();
            this.TabControl_Main.SuspendLayout();
            this.ToolStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Main.Controls.Add(this.Tab_Chambres);
            this.TabControl_Main.Controls.Add(this.Tab_Réservations);
            this.TabControl_Main.Controls.Add(this.Tab_Arrivées);
            this.TabControl_Main.Controls.Add(this.Tab_Départs);
            this.TabControl_Main.Location = new System.Drawing.Point(12, 30);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(1305, 561);
            this.TabControl_Main.TabIndex = 0;
            // 
            // Tab_Chambres
            // 
            this.Tab_Chambres.Location = new System.Drawing.Point(4, 25);
            this.Tab_Chambres.Name = "Tab_Chambres";
            this.Tab_Chambres.Size = new System.Drawing.Size(1297, 532);
            this.Tab_Chambres.TabIndex = 2;
            this.Tab_Chambres.Text = "Chambres";
            this.Tab_Chambres.UseVisualStyleBackColor = true;
            // 
            // Tab_Réservations
            // 
            this.Tab_Réservations.Location = new System.Drawing.Point(4, 25);
            this.Tab_Réservations.Name = "Tab_Réservations";
            this.Tab_Réservations.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Réservations.Size = new System.Drawing.Size(1297, 532);
            this.Tab_Réservations.TabIndex = 1;
            this.Tab_Réservations.Text = "Réservations";
            this.Tab_Réservations.UseVisualStyleBackColor = true;
            // 
            // Tab_Arrivées
            // 
            this.Tab_Arrivées.Location = new System.Drawing.Point(4, 25);
            this.Tab_Arrivées.Name = "Tab_Arrivées";
            this.Tab_Arrivées.Size = new System.Drawing.Size(1297, 532);
            this.Tab_Arrivées.TabIndex = 3;
            this.Tab_Arrivées.Text = "Arrivées";
            this.Tab_Arrivées.UseVisualStyleBackColor = true;
            // 
            // Tab_Départs
            // 
            this.Tab_Départs.Location = new System.Drawing.Point(4, 25);
            this.Tab_Départs.Name = "Tab_Départs";
            this.Tab_Départs.Size = new System.Drawing.Size(1297, 532);
            this.Tab_Départs.TabIndex = 4;
            this.Tab_Départs.Text = "Départs";
            this.Tab_Départs.UseVisualStyleBackColor = true;
            // 
            // ToolStrip_Main
            // 
            this.ToolStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Add,
            this.Button_Edit,
            this.Button_Delete,
            this.Button_Forward_All,
            this.Button_Forward_One,
            this.Button_Back_One,
            this.Button_Back_All,
            this.Button_Undo,
            this.Button_Save});
            this.ToolStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip_Main.Name = "ToolStrip_Main";
            this.ToolStrip_Main.Size = new System.Drawing.Size(1329, 27);
            this.ToolStrip_Main.TabIndex = 1;
            this.ToolStrip_Main.Text = "toolStrip1";
            // 
            // Button_Add
            // 
            this.Button_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Add.Image = global::PrjEq01_CommonForm.Properties.Resources.Add_Hanan_;
            this.Button_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(24, 24);
            this.Button_Add.Text = "Ajouter";
            // 
            // Button_Edit
            // 
            this.Button_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Edit.Image = global::PrjEq01_CommonForm.Properties.Resources.Edit_Freepik_;
            this.Button_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(24, 24);
            this.Button_Edit.Text = "Modifier";
            // 
            // Button_Delete
            // 
            this.Button_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Delete.Image = global::PrjEq01_CommonForm.Properties.Resources.Delete_Freepik_;
            this.Button_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(24, 24);
            this.Button_Delete.Text = "Supprimer";
            // 
            // Button_Forward_All
            // 
            this.Button_Forward_All.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Button_Forward_All.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Forward_All.Image = global::PrjEq01_CommonForm.Properties.Resources.Double_Right_Arrow_Dave_Gandy_;
            this.Button_Forward_All.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Forward_All.Name = "Button_Forward_All";
            this.Button_Forward_All.Size = new System.Drawing.Size(24, 24);
            this.Button_Forward_All.Text = "Fin";
            // 
            // Button_Forward_One
            // 
            this.Button_Forward_One.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Button_Forward_One.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Forward_One.Image = global::PrjEq01_CommonForm.Properties.Resources.Right_Arrow_Google_;
            this.Button_Forward_One.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Forward_One.Name = "Button_Forward_One";
            this.Button_Forward_One.Size = new System.Drawing.Size(24, 24);
            this.Button_Forward_One.Text = "Avant";
            // 
            // Button_Back_One
            // 
            this.Button_Back_One.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Button_Back_One.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Back_One.Image = global::PrjEq01_CommonForm.Properties.Resources.Left_Arrow_Google_;
            this.Button_Back_One.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Back_One.Name = "Button_Back_One";
            this.Button_Back_One.Size = new System.Drawing.Size(24, 24);
            this.Button_Back_One.Text = "Arrière";
            // 
            // Button_Back_All
            // 
            this.Button_Back_All.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Button_Back_All.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Back_All.Image = global::PrjEq01_CommonForm.Properties.Resources.Double_Left_Arrow_Dave_Gandy_;
            this.Button_Back_All.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Back_All.Name = "Button_Back_All";
            this.Button_Back_All.Size = new System.Drawing.Size(24, 24);
            this.Button_Back_All.Text = "Début";
            // 
            // Button_Undo
            // 
            this.Button_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Undo.Image = global::PrjEq01_CommonForm.Properties.Resources.Back_Dave_Gandy_;
            this.Button_Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Undo.Name = "Button_Undo";
            this.Button_Undo.Size = new System.Drawing.Size(24, 24);
            this.Button_Undo.Text = "Revenir en arrière";
            // 
            // Button_Save
            // 
            this.Button_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button_Save.Image = global::PrjEq01_CommonForm.Properties.Resources.Save_Smashicons_;
            this.Button_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(24, 24);
            this.Button_Save.Text = "Sauvegarder";
            // 
            // FormCommon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 603);
            this.Controls.Add(this.ToolStrip_Main);
            this.Controls.Add(this.TabControl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCommon";
            this.Text = "FormCommon";
            this.TabControl_Main.ResumeLayout(false);
            this.ToolStrip_Main.ResumeLayout(false);
            this.ToolStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip ToolStrip_Main;
        private System.Windows.Forms.ToolStripButton Button_Add;
        private System.Windows.Forms.ToolStripButton Button_Delete;
        private System.Windows.Forms.ToolStripButton Button_Forward_All;
        private System.Windows.Forms.ToolStripButton Button_Forward_One;
        private System.Windows.Forms.ToolStripButton Button_Back_One;
        private System.Windows.Forms.ToolStripButton Button_Back_All;
        private System.Windows.Forms.TabControl TabControl_Main;
        protected System.Windows.Forms.TabPage Tab_Réservations;
        protected System.Windows.Forms.TabPage Tab_Chambres;
        protected System.Windows.Forms.TabPage Tab_Arrivées;
        protected System.Windows.Forms.TabPage Tab_Départs;
        private System.Windows.Forms.ToolStripButton Button_Edit;
        private System.Windows.Forms.ToolStripButton Button_Undo;
        private System.Windows.Forms.ToolStripButton Button_Save;
    }
}