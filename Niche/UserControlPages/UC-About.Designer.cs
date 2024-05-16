namespace Niche.UserControlPages
{
    partial class UC_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_About));
            this.aboutLabel = new System.Windows.Forms.Label();
            this.descrLabel = new System.Windows.Forms.Label();
            this.copyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            resources.ApplyResources(this.aboutLabel, "aboutLabel");
            this.aboutLabel.Name = "aboutLabel";
            // 
            // descrLabel
            // 
            resources.ApplyResources(this.descrLabel, "descrLabel");
            this.descrLabel.Name = "descrLabel";
            // 
            // copyLabel
            // 
            resources.ApplyResources(this.copyLabel, "copyLabel");
            this.copyLabel.Name = "copyLabel";
            // 
            // UC_About
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.copyLabel);
            this.Controls.Add(this.descrLabel);
            this.Controls.Add(this.aboutLabel);
            this.Name = "UC_About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label descrLabel;
        private System.Windows.Forms.Label copyLabel;
    }
}
