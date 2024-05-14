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
            this.label1 = new System.Windows.Forms.Label();
            this.libraryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.libraryCircleButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "library";
            // 
            // libraryLinkLabel
            // 
            this.libraryLinkLabel.AutoSize = true;
            this.libraryLinkLabel.Location = new System.Drawing.Point(127, 262);
            this.libraryLinkLabel.Name = "libraryLinkLabel";
            this.libraryLinkLabel.Size = new System.Drawing.Size(80, 13);
            this.libraryLinkLabel.TabIndex = 1;
            this.libraryLinkLabel.TabStop = true;
            this.libraryLinkLabel.Text = "libraryLinkLabel";
            this.libraryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.libraryLinkLabel_LinkClicked);
            // 
            // libraryCircleButton
            // 
            this.libraryCircleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.libraryCircleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.libraryCircleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.libraryCircleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.libraryCircleButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.libraryCircleButton.ForeColor = System.Drawing.Color.White;
            this.libraryCircleButton.Location = new System.Drawing.Point(244, 144);
            this.libraryCircleButton.Name = "libraryCircleButton";
            this.libraryCircleButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.libraryCircleButton.Size = new System.Drawing.Size(233, 221);
            this.libraryCircleButton.TabIndex = 2;
            this.libraryCircleButton.Text = "Click to visit library";
            // 
            // UC_Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.libraryCircleButton);
            this.Controls.Add(this.libraryLinkLabel);
            this.Controls.Add(this.label1);
            this.Name = "UC_Library";
            this.Size = new System.Drawing.Size(769, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel libraryLinkLabel;
        private Guna.UI2.WinForms.Guna2CircleButton libraryCircleButton;
    }
}
