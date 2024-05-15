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
            this.libraryLabel = new System.Windows.Forms.Label();
            this.libraryDescLabel = new System.Windows.Forms.Label();
            this.libraryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // libraryLabel
            // 
            this.libraryLabel.AutoSize = true;
            this.libraryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryLabel.Location = new System.Drawing.Point(26, 32);
            this.libraryLabel.Name = "libraryLabel";
            this.libraryLabel.Size = new System.Drawing.Size(73, 24);
            this.libraryLabel.TabIndex = 4;
            this.libraryLabel.Text = "Library";
            // 
            // libraryDescLabel
            // 
            this.libraryDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryDescLabel.Location = new System.Drawing.Point(82, 106);
            this.libraryDescLabel.Name = "libraryDescLabel";
            this.libraryDescLabel.Size = new System.Drawing.Size(597, 53);
            this.libraryDescLabel.TabIndex = 5;
            this.libraryDescLabel.Text = "Our site offers resources to help bolster your CV. Please click the link down bel" +
    "ow to view our Resources Library.";
            // 
            // libraryLinkLabel
            // 
            this.libraryLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.libraryLinkLabel.BackColor = System.Drawing.Color.IndianRed;
            this.libraryLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryLinkLabel.LinkColor = System.Drawing.Color.White;
            this.libraryLinkLabel.Location = new System.Drawing.Point(85, 203);
            this.libraryLinkLabel.Name = "libraryLinkLabel";
            this.libraryLinkLabel.Size = new System.Drawing.Size(580, 123);
            this.libraryLinkLabel.TabIndex = 6;
            this.libraryLinkLabel.TabStop = true;
            this.libraryLinkLabel.Text = "Click to view Resources Library";
            this.libraryLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.libraryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.libraryLinkLabel_LinkClicked);
            // 
            // UC_Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.libraryLinkLabel);
            this.Controls.Add(this.libraryDescLabel);
            this.Controls.Add(this.libraryLabel);
            this.Name = "UC_Library";
            this.Size = new System.Drawing.Size(769, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label libraryLabel;
        private System.Windows.Forms.Label libraryDescLabel;
        private System.Windows.Forms.LinkLabel libraryLinkLabel;
    }
}
