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
            this.createSampleCVButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createSampleCVButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createSampleCVButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createSampleCVButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createSampleCVButton.FillColor = System.Drawing.Color.IndianRed;
            this.createSampleCVButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createSampleCVButton.ForeColor = System.Drawing.Color.White;
            this.createSampleCVButton.Location = new System.Drawing.Point(260, 238);
            this.createSampleCVButton.Name = "createSampleCVButton";
            this.createSampleCVButton.Size = new System.Drawing.Size(180, 31);
            this.createSampleCVButton.TabIndex = 0;
            this.createSampleCVButton.Text = "Create Sample CV";
            this.createSampleCVButton.Click += new System.EventHandler(this.createSampleCVButton_Click);
            // 
            // createCVGroupBox
            // 
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
            this.createCVGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createCVGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.createCVGroupBox.Location = new System.Drawing.Point(32, 221);
            this.createCVGroupBox.Name = "createCVGroupBox";
            this.createCVGroupBox.Size = new System.Drawing.Size(700, 305);
            this.createCVGroupBox.TabIndex = 1;
            this.createCVGroupBox.Text = "Create Sample CV";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(39, 59);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(252, 20);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "Please enter your information below:";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(470, 165);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(111, 15);
            this.languageLabel.TabIndex = 14;
            this.languageLabel.Text = "Select CV language:";
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "French",
            "Spanish"});
            this.languageComboBox.Location = new System.Drawing.Point(473, 183);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(180, 23);
            this.languageComboBox.TabIndex = 13;
            // 
            // experienceTextBox
            // 
            this.experienceTextBox.Location = new System.Drawing.Point(473, 128);
            this.experienceTextBox.Name = "experienceTextBox";
            this.experienceTextBox.Size = new System.Drawing.Size(180, 23);
            this.experienceTextBox.TabIndex = 12;
            // 
            // experienceLabel
            // 
            this.experienceLabel.AutoSize = true;
            this.experienceLabel.Location = new System.Drawing.Point(470, 106);
            this.experienceLabel.Name = "experienceLabel";
            this.experienceLabel.Size = new System.Drawing.Size(67, 15);
            this.experienceLabel.TabIndex = 11;
            this.experienceLabel.Text = "Experience:";
            // 
            // skillsLabel
            // 
            this.skillsLabel.AutoSize = true;
            this.skillsLabel.Location = new System.Drawing.Point(257, 162);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(36, 15);
            this.skillsLabel.TabIndex = 10;
            this.skillsLabel.Text = "Skills:";
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.Location = new System.Drawing.Point(257, 106);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(63, 15);
            this.educationLabel.TabIndex = 9;
            this.educationLabel.Text = "Education:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(41, 162);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 15);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(40, 106);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 15);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First Name:";
            // 
            // skillsTextBox
            // 
            this.skillsTextBox.Location = new System.Drawing.Point(260, 183);
            this.skillsTextBox.Name = "skillsTextBox";
            this.skillsTextBox.Size = new System.Drawing.Size(180, 23);
            this.skillsTextBox.TabIndex = 6;
            // 
            // educationTextBox
            // 
            this.educationTextBox.Location = new System.Drawing.Point(260, 128);
            this.educationTextBox.Name = "educationTextBox";
            this.educationTextBox.Size = new System.Drawing.Size(180, 23);
            this.educationTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(43, 180);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(180, 23);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(43, 128);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(180, 23);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createCVGroupBox);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(769, 549);
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
