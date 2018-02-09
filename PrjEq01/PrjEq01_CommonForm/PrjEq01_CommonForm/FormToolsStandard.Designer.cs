namespace PrjEq01_CommonForm
{
    partial class FormToolsStandard
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
            this.Button_Function = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Function
            // 
            this.Button_Function.Location = new System.Drawing.Point(110, 72);
            this.Button_Function.Name = "Button_Function";
            this.Button_Function.Size = new System.Drawing.Size(229, 136);
            this.Button_Function.TabIndex = 0;
            this.Button_Function.Text = "Button_Function";
            this.Button_Function.UseVisualStyleBackColor = true;
            // 
            // FormToolsStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 385);
            this.Controls.Add(this.Button_Function);
            this.Name = "FormToolsStandard";
            this.Text = "FormToolsStandard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Function;
    }
}