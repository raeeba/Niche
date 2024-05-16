namespace Niche.UserControlPages
{
    partial class UC_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Login));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new Niche.UsersDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.usersTableAdapter = new Niche.UsersDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Niche.UsersDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).BeginInit();
            this.usersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // usernameTextbox
            // 
            resources.ApplyResources(this.usernameTextbox, "usernameTextbox");
            this.usernameTextbox.BorderRadius = 15;
            this.usernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextbox.DefaultText = "";
            this.usernameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PasswordChar = '\0';
            this.usernameTextbox.PlaceholderText = "Username";
            this.usernameTextbox.SelectedText = "";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.BorderRadius = 15;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.PlaceholderText = "Password";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.BorderRadius = 15;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.FillColor = System.Drawing.Color.DarkRed;
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Name = "loginButton";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // guna2HtmlLabel1
            // 
            resources.ApplyResources(this.guna2HtmlLabel1, "guna2HtmlLabel1");
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            // 
            // guna2HtmlLabel2
            // 
            resources.ApplyResources(this.guna2HtmlLabel2, "guna2HtmlLabel2");
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            // 
            // usersBindingNavigator
            // 
            resources.ApplyResources(this.usersBindingNavigator, "usersBindingNavigator");
            this.usersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usersBindingNavigator.BindingSource = this.usersBindingSource;
            this.usersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usersBindingNavigatorSaveItem});
            this.usersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usersBindingNavigator.Name = "usersBindingNavigator";
            this.usersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorAddNewItem
            // 
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            // 
            // bindingNavigatorDeleteItem
            // 
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            // 
            // bindingNavigatorMoveNextItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            // 
            // usersBindingNavigatorSaveItem
            // 
            resources.ApplyResources(this.usersBindingNavigatorSaveItem, "usersBindingNavigatorSaveItem");
            this.usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersBindingNavigatorSaveItem.Name = "usersBindingNavigatorSaveItem";
            this.usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.usersBindingNavigatorSaveItem_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Niche.UsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // UC_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usersBindingNavigator);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.usernameLabel);
            this.Name = "UC_Login";
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).EndInit();
            this.usersBindingNavigator.ResumeLayout(false);
            this.usersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UsersDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private UsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorSaveItem;
    }
}
