namespace Niche.UserControlPages
{
    partial class UC_Library
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Library));
            this.libraryLabel = new System.Windows.Forms.Label();
            this.libraryDescLabel = new System.Windows.Forms.Label();
            this.libraryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // libraryLabel
            // 
            resources.ApplyResources(this.libraryLabel, "libraryLabel");
            this.libraryLabel.Name = "libraryLabel";
            // 
            // libraryDescLabel
            // 
            resources.ApplyResources(this.libraryDescLabel, "libraryDescLabel");
            this.libraryDescLabel.Name = "libraryDescLabel";
            // 
            // libraryLinkLabel
            // 
            resources.ApplyResources(this.libraryLinkLabel, "libraryLinkLabel");
            this.libraryLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.libraryLinkLabel.BackColor = System.Drawing.Color.IndianRed;
            this.libraryLinkLabel.LinkColor = System.Drawing.Color.White;
            this.libraryLinkLabel.Name = "libraryLinkLabel";
            this.libraryLinkLabel.TabStop = true;
            this.libraryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.libraryLinkLabel_LinkClicked);
            // 
            // UC_Library
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.libraryLinkLabel);
            this.Controls.Add(this.libraryDescLabel);
            this.Controls.Add(this.libraryLabel);
            this.Name = "UC_Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label libraryLabel;
        private System.Windows.Forms.Label libraryDescLabel;
        private System.Windows.Forms.LinkLabel libraryLinkLabel;
    }
}
