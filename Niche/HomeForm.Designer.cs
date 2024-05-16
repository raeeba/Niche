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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
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
            this.themeToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
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
            resources.ApplyResources(this.navPanel, "navPanel");
            this.navPanel.Name = "navPanel";
            // 
            // loginRegisterBtn
            // 
            this.loginRegisterBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.loginRegisterBtn.HoverState.ImageSize = new System.Drawing.Size(100, 70);
            this.loginRegisterBtn.Image = ((System.Drawing.Image)(resources.GetObject("loginRegisterBtn.Image")));
            this.loginRegisterBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.loginRegisterBtn.ImageRotate = 0F;
            this.loginRegisterBtn.ImageSize = new System.Drawing.Size(90, 70);
            resources.ApplyResources(this.loginRegisterBtn, "loginRegisterBtn");
            this.loginRegisterBtn.Name = "loginRegisterBtn";
            this.loginRegisterBtn.PressedState.ImageSize = new System.Drawing.Size(90, 90);
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
            resources.ApplyResources(this.homeBtn, "homeBtn");
            this.homeBtn.ForeColor = System.Drawing.Color.Brown;
            this.homeBtn.HoverState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.homeBtn.Name = "homeBtn";
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
            resources.ApplyResources(this.jobsBtn, "jobsBtn");
            this.jobsBtn.ForeColor = System.Drawing.Color.Brown;
            this.jobsBtn.HoverState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.jobsBtn.Name = "jobsBtn";
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
            resources.ApplyResources(this.testimoniesBtn, "testimoniesBtn");
            this.testimoniesBtn.ForeColor = System.Drawing.Color.Brown;
            this.testimoniesBtn.HoverState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.testimoniesBtn.Name = "testimoniesBtn";
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
            resources.ApplyResources(this.libraryBtn, "libraryBtn");
            this.libraryBtn.ForeColor = System.Drawing.Color.Brown;
            this.libraryBtn.HoverState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.libraryBtn.Name = "libraryBtn";
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
            resources.ApplyResources(this.aboutBtn, "aboutBtn");
            this.aboutBtn.ForeColor = System.Drawing.Color.Brown;
            this.aboutBtn.HoverState.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // headerLabel
            // 
            resources.ApplyResources(this.headerLabel, "headerLabel");
            this.headerLabel.ForeColor = System.Drawing.Color.Salmon;
            this.headerLabel.Name = "headerLabel";
            // 
            // panelContainer
            // 
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.panelContainer, "panelContainer");
            this.panelContainer.Name = "panelContainer";
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.upperPanel.Controls.Add(this.themeToggleSwitch);
            this.upperPanel.Controls.Add(this.languageComboBox);
            this.upperPanel.Controls.Add(this.headerLabel);
            resources.ApplyResources(this.upperPanel, "upperPanel");
            this.upperPanel.Name = "upperPanel";
            // 
            // themeToggleSwitch
            // 
            this.themeToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.themeToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.themeToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.themeToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            resources.ApplyResources(this.themeToggleSwitch, "themeToggleSwitch");
            this.themeToggleSwitch.Name = "themeToggleSwitch";
            this.themeToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.themeToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.themeToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.themeToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.themeToggleSwitch.CheckedChanged += new System.EventHandler(this.themeToggleSwitch_CheckedChanged);
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2")});
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.footerPanel.Controls.Add(this.footerLabel);
            resources.ApplyResources(this.footerPanel, "footerPanel");
            this.footerPanel.Name = "footerPanel";
            // 
            // footerLabel
            // 
            resources.ApplyResources(this.footerLabel, "footerLabel");
            this.footerLabel.ForeColor = System.Drawing.Color.Salmon;
            this.footerLabel.Name = "footerLabel";
            // 
            // HomeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.navPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
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
        private System.Windows.Forms.ComboBox languageComboBox;
        private Guna.UI2.WinForms.Guna2ImageButton loginRegisterBtn;
        private Guna.UI2.WinForms.Guna2ToggleSwitch themeToggleSwitch;
    }
}

