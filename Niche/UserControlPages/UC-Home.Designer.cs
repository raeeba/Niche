namespace Niche.UserControlPages
{
    partial class UC_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.createSampleCVButton = new Guna.UI2.WinForms.Guna2Button();
            this.createCVGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.experienceTextBox = new System.Windows.Forms.TextBox();
            this.experienceLabel = new System.Windows.Forms.Label();
            this.skillsLabel = new System.Windows.Forms.Label();
            this.educationLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.skillsTextBox = new System.Windows.Forms.TextBox();
            this.educationTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.createCVGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createSampleCVButton
            // 
            resources.ApplyResources(this.createSampleCVButton, "createSampleCVButton");
            this.createSampleCVButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createSampleCVButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createSampleCVButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createSampleCVButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createSampleCVButton.FillColor = System.Drawing.Color.IndianRed;
            this.createSampleCVButton.ForeColor = System.Drawing.Color.White;
            this.createSampleCVButton.Name = "createSampleCVButton";
            this.createSampleCVButton.Click += new System.EventHandler(this.createSampleCVButton_Click);
            // 
            // createCVGroupBox
            // 
            resources.ApplyResources(this.createCVGroupBox, "createCVGroupBox");
            this.createCVGroupBox.Controls.Add(this.infoLabel);
            this.createCVGroupBox.Controls.Add(this.languageLabel);
            this.createCVGroupBox.Controls.Add(this.languageComboBox);
            this.createCVGroupBox.Controls.Add(this.experienceTextBox);
            this.createCVGroupBox.Controls.Add(this.experienceLabel);
            this.createCVGroupBox.Controls.Add(this.skillsLabel);
            this.createCVGroupBox.Controls.Add(this.educationLabel);
            this.createCVGroupBox.Controls.Add(this.lastNameLabel);
            this.createCVGroupBox.Controls.Add(this.firstNameLabel);
            this.createCVGroupBox.Controls.Add(this.skillsTextBox);
            this.createCVGroupBox.Controls.Add(this.educationTextBox);
            this.createCVGroupBox.Controls.Add(this.lastNameTextBox);
            this.createCVGroupBox.Controls.Add(this.firstNameTextBox);
            this.createCVGroupBox.Controls.Add(this.createSampleCVButton);
            this.createCVGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.createCVGroupBox.Name = "createCVGroupBox";
            // 
            // infoLabel
            // 
            resources.ApplyResources(this.infoLabel, "infoLabel");
            this.infoLabel.Name = "infoLabel";
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2")});
            this.languageComboBox.Name = "languageComboBox";
            // 
            // experienceTextBox
            // 
            resources.ApplyResources(this.experienceTextBox, "experienceTextBox");
            this.experienceTextBox.Name = "experienceTextBox";
            // 
            // experienceLabel
            // 
            resources.ApplyResources(this.experienceLabel, "experienceLabel");
            this.experienceLabel.Name = "experienceLabel";
            // 
            // skillsLabel
            // 
            resources.ApplyResources(this.skillsLabel, "skillsLabel");
            this.skillsLabel.Name = "skillsLabel";
            // 
            // educationLabel
            // 
            resources.ApplyResources(this.educationLabel, "educationLabel");
            this.educationLabel.Name = "educationLabel";
            // 
            // lastNameLabel
            // 
            resources.ApplyResources(this.lastNameLabel, "lastNameLabel");
            this.lastNameLabel.Name = "lastNameLabel";
            // 
            // firstNameLabel
            // 
            resources.ApplyResources(this.firstNameLabel, "firstNameLabel");
            this.firstNameLabel.Name = "firstNameLabel";
            // 
            // skillsTextBox
            // 
            resources.ApplyResources(this.skillsTextBox, "skillsTextBox");
            this.skillsTextBox.Name = "skillsTextBox";
            // 
            // educationTextBox
            // 
            resources.ApplyResources(this.educationTextBox, "educationTextBox");
            this.educationTextBox.Name = "educationTextBox";
            // 
            // lastNameTextBox
            // 
            resources.ApplyResources(this.lastNameTextBox, "lastNameTextBox");
            this.lastNameTextBox.Name = "lastNameTextBox";
            // 
            // firstNameTextBox
            // 
            resources.ApplyResources(this.firstNameTextBox, "firstNameTextBox");
            this.firstNameTextBox.Name = "firstNameTextBox";
            // 
            // UC_Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createCVGroupBox);
            this.Name = "UC_Home";
            this.createCVGroupBox.ResumeLayout(false);
            this.createCVGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button createSampleCVButton;
        private Guna.UI2.WinForms.Guna2GroupBox createCVGroupBox;
        private System.Windows.Forms.TextBox skillsTextBox;
        private System.Windows.Forms.TextBox educationTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label skillsLabel;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.TextBox experienceTextBox;
        private System.Windows.Forms.Label experienceLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}
