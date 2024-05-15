namespace Niche
{
    partial class HomeForm
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
            this.navPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.loginRegisterBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.homeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.jobsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.testimoniesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.libraryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.aboutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.footerLabel = new System.Windows.Forms.Label();
            this.navPanel.SuspendLayout();
            this.upperPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.White;
            this.navPanel.Controls.Add(this.loginRegisterBtn);
            this.navPanel.Controls.Add(this.homeBtn);
            this.navPanel.Controls.Add(this.jobsBtn);
            this.navPanel.Controls.Add(this.testimoniesBtn);
            this.navPanel.Controls.Add(this.libraryBtn);
            this.navPanel.Controls.Add(this.aboutBtn);
            this.navPanel.Location = new System.Drawing.Point(0, 38);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(200, 568);
            this.navPanel.TabIndex = 0;
            // 
            // loginRegisterBtn
            // 
            this.loginRegisterBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.loginRegisterBtn.HoverState.ImageSize = new System.Drawing.Size(100, 70);
            this.loginRegisterBtn.Image = global::Niche.Properties.Resources.image0;
            this.loginRegisterBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.loginRegisterBtn.ImageRotate = 0F;
            this.loginRegisterBtn.ImageSize = new System.Drawing.Size(90, 70);
            this.loginRegisterBtn.Location = new System.Drawing.Point(3, 3);
            this.loginRegisterBtn.Name = "loginRegisterBtn";
            this.loginRegisterBtn.PressedState.ImageSize = new System.Drawing.Size(90, 90);
            this.loginRegisterBtn.Size = new System.Drawing.Size(197, 96);
            this.loginRegisterBtn.TabIndex = 0;
            this.loginRegisterBtn.Click += new System.EventHandler(this.loginRegisterBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homeBtn.Checked = true;
            this.homeBtn.CheckedState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.homeBtn.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.homeBtn.CustomBorderColor = System.Drawing.Color.White;
            this.homeBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.homeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeBtn.FillColor = System.Drawing.Color.White;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.Brown;
            this.homeBtn.HoverState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.homeBtn.Location = new System.Drawing.Point(3, 105);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(197, 60);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "HOME";
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // jobsBtn
            // 
            this.jobsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.jobsBtn.CheckedState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.jobsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.jobsBtn.CustomBorderColor = System.Drawing.Color.White;
            this.jobsBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.jobsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.jobsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.jobsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.jobsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.jobsBtn.FillColor = System.Drawing.Color.White;
            this.jobsBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsBtn.ForeColor = System.Drawing.Color.Brown;
            this.jobsBtn.HoverState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.jobsBtn.Location = new System.Drawing.Point(3, 171);
            this.jobsBtn.Name = "jobsBtn";
            this.jobsBtn.Size = new System.Drawing.Size(197, 60);
            this.jobsBtn.TabIndex = 2;
            this.jobsBtn.Text = "JOBS";
            this.jobsBtn.Click += new System.EventHandler(this.jobsBtn_Click);
            // 
            // testimoniesBtn
            // 
            this.testimoniesBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.testimoniesBtn.CheckedState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.testimoniesBtn.CustomBorderColor = System.Drawing.Color.White;
            this.testimoniesBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.testimoniesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.testimoniesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.testimoniesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.testimoniesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.testimoniesBtn.FillColor = System.Drawing.Color.White;
            this.testimoniesBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testimoniesBtn.ForeColor = System.Drawing.Color.Brown;
            this.testimoniesBtn.HoverState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.testimoniesBtn.Location = new System.Drawing.Point(3, 237);
            this.testimoniesBtn.Name = "testimoniesBtn";
            this.testimoniesBtn.Size = new System.Drawing.Size(197, 60);
            this.testimoniesBtn.TabIndex = 3;
            this.testimoniesBtn.Text = "TESTIMONIALS";
            this.testimoniesBtn.Click += new System.EventHandler(this.testimoniesBtn_Click);
            // 
            // libraryBtn
            // 
            this.libraryBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.libraryBtn.CheckedState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.libraryBtn.CustomBorderColor = System.Drawing.Color.White;
            this.libraryBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.libraryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.libraryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.libraryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.libraryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.libraryBtn.FillColor = System.Drawing.Color.White;
            this.libraryBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryBtn.ForeColor = System.Drawing.Color.Brown;
            this.libraryBtn.HoverState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.libraryBtn.Location = new System.Drawing.Point(3, 303);
            this.libraryBtn.Name = "libraryBtn";
            this.libraryBtn.Size = new System.Drawing.Size(197, 60);
            this.libraryBtn.TabIndex = 4;
            this.libraryBtn.Text = "LIBRARY";
            this.libraryBtn.Click += new System.EventHandler(this.libraryBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.aboutBtn.CheckedState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.aboutBtn.CustomBorderColor = System.Drawing.Color.White;
            this.aboutBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.aboutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.aboutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.aboutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aboutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.aboutBtn.FillColor = System.Drawing.Color.White;
            this.aboutBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.ForeColor = System.Drawing.Color.Brown;
            this.aboutBtn.HoverState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.aboutBtn.Location = new System.Drawing.Point(3, 369);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(197, 60);
            this.aboutBtn.TabIndex = 5;
            this.aboutBtn.Text = "ABOUT";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Salmon;
            this.headerLabel.Location = new System.Drawing.Point(30, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(127, 41);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "NICHE";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContainer.Location = new System.Drawing.Point(200, 38);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(769, 558);
            this.panelContainer.TabIndex = 1;
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.upperPanel.Controls.Add(this.headerLabel);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(971, 41);
            this.upperPanel.TabIndex = 2;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.footerPanel.Controls.Add(this.footerLabel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 589);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(971, 29);
            this.footerPanel.TabIndex = 3;
            // 
            // footerLabel
            // 
            this.footerLabel.AutoSize = true;
            this.footerLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footerLabel.ForeColor = System.Drawing.Color.Salmon;
            this.footerLabel.Location = new System.Drawing.Point(484, 5);
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(59, 15);
            this.footerLabel.TabIndex = 0;
            this.footerLabel.Text = "2024 Niche";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(971, 618);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.navPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.navPanel.ResumeLayout(false);
            this.upperPanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel navPanel;
        private System.Windows.Forms.Label headerLabel;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private Guna.UI2.WinForms.Guna2Button jobsBtn;
        private Guna.UI2.WinForms.Guna2Button testimoniesBtn;
        private Guna.UI2.WinForms.Guna2Button libraryBtn;
        private Guna.UI2.WinForms.Guna2Button aboutBtn;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label footerLabel;
        private Guna.UI2.WinForms.Guna2ImageButton loginRegisterBtn;
    }
}

