namespace Niche.UserControlPages
{
    partial class UC_Jobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Jobs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.showAllButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.salaryTrackBarLabel = new System.Windows.Forms.Label();
            this.jobsFormLabel = new System.Windows.Forms.Label();
            this.midSalaryLabel = new System.Windows.Forms.Label();
            this.maxSalaryLabel = new System.Windows.Forms.Label();
            this.minSalaryLabel = new System.Windows.Forms.Label();
            this.salaryTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.searchJobsTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.jobsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nicheDataSet = new Niche.NicheDataSet();
            this.jobsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.jobsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.jobsTableAdapter = new Niche.NicheDataSetTableAdapters.JobsTableAdapter();
            this.tableAdapterManager = new Niche.NicheDataSetTableAdapters.TableAdapterManager();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicheDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingNavigator)).BeginInit();
            this.jobsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.Controls.Add(this.showAllButton);
            this.guna2Panel1.Controls.Add(this.searchButton);
            this.guna2Panel1.Controls.Add(this.salaryTrackBarLabel);
            this.guna2Panel1.Controls.Add(this.jobsFormLabel);
            this.guna2Panel1.Controls.Add(this.midSalaryLabel);
            this.guna2Panel1.Controls.Add(this.maxSalaryLabel);
            this.guna2Panel1.Controls.Add(this.minSalaryLabel);
            this.guna2Panel1.Controls.Add(this.salaryTrackBar);
            this.guna2Panel1.Controls.Add(this.searchJobsTextBox);
            this.guna2Panel1.Controls.Add(this.searchLabel);
            this.guna2Panel1.Controls.Add(this.jobsDataGridView);
            this.guna2Panel1.Name = "guna2Panel1";
            // 
            // showAllButton
            // 
            resources.ApplyResources(this.showAllButton, "showAllButton");
            this.showAllButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showAllButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showAllButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAllButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showAllButton.FillColor = System.Drawing.Color.IndianRed;
            this.showAllButton.ForeColor = System.Drawing.Color.White;
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.FillColor = System.Drawing.Color.IndianRed;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Name = "searchButton";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // salaryTrackBarLabel
            // 
            resources.ApplyResources(this.salaryTrackBarLabel, "salaryTrackBarLabel");
            this.salaryTrackBarLabel.Name = "salaryTrackBarLabel";
            // 
            // jobsFormLabel
            // 
            resources.ApplyResources(this.jobsFormLabel, "jobsFormLabel");
            this.jobsFormLabel.Name = "jobsFormLabel";
            // 
            // midSalaryLabel
            // 
            resources.ApplyResources(this.midSalaryLabel, "midSalaryLabel");
            this.midSalaryLabel.Name = "midSalaryLabel";
            // 
            // maxSalaryLabel
            // 
            resources.ApplyResources(this.maxSalaryLabel, "maxSalaryLabel");
            this.maxSalaryLabel.Name = "maxSalaryLabel";
            // 
            // minSalaryLabel
            // 
            resources.ApplyResources(this.minSalaryLabel, "minSalaryLabel");
            this.minSalaryLabel.Name = "minSalaryLabel";
            // 
            // salaryTrackBar
            // 
            resources.ApplyResources(this.salaryTrackBar, "salaryTrackBar");
            this.salaryTrackBar.LargeChange = 10000;
            this.salaryTrackBar.Maximum = 90000;
            this.salaryTrackBar.Minimum = 45000;
            this.salaryTrackBar.Name = "salaryTrackBar";
            this.salaryTrackBar.SmallChange = 5000;
            this.salaryTrackBar.ThumbColor = System.Drawing.Color.IndianRed;
            this.salaryTrackBar.Value = 45000;
            this.salaryTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.salaryTrackBar_Scroll);
            // 
            // searchJobsTextBox
            // 
            resources.ApplyResources(this.searchJobsTextBox, "searchJobsTextBox");
            this.searchJobsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchJobsTextBox.DefaultText = "";
            this.searchJobsTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchJobsTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchJobsTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchJobsTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchJobsTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchJobsTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchJobsTextBox.Name = "searchJobsTextBox";
            this.searchJobsTextBox.PasswordChar = '\0';
            this.searchJobsTextBox.PlaceholderText = "";
            this.searchJobsTextBox.SelectedText = "";
            // 
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // jobsDataGridView
            // 
            resources.ApplyResources(this.jobsDataGridView, "jobsDataGridView");
            this.jobsDataGridView.AllowUserToAddRows = false;
            this.jobsDataGridView.AllowUserToDeleteRows = false;
            this.jobsDataGridView.AllowUserToResizeColumns = false;
            this.jobsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.jobsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.jobsDataGridView.AutoGenerateColumns = false;
            this.jobsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.jobsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.jobsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.jobsDataGridView.DataSource = this.jobsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.jobsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.jobsDataGridView.Name = "jobsDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.jobsDataGridView.RowHeadersVisible = false;
            this.jobsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.jobsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.jobsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.jobsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.jobsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.jobsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.jobsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.jobsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.jobsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.jobsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.jobsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.jobsDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.jobsDataGridView.ThemeStyle.ReadOnly = false;
            this.jobsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.jobsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.jobsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.jobsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.jobsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.jobsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "JobTitle";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Company";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Location";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Salary";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "JobDescription";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // jobsBindingSource
            // 
            this.jobsBindingSource.DataMember = "Jobs";
            this.jobsBindingSource.DataSource = this.nicheDataSet;
            // 
            // nicheDataSet
            // 
            this.nicheDataSet.DataSetName = "NicheDataSet";
            this.nicheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobsBindingNavigator
            // 
            resources.ApplyResources(this.jobsBindingNavigator, "jobsBindingNavigator");
            this.jobsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jobsBindingNavigator.BindingSource = this.jobsBindingSource;
            this.jobsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jobsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jobsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.jobsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.jobsBindingNavigatorSaveItem});
            this.jobsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jobsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jobsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jobsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jobsBindingNavigator.Name = "jobsBindingNavigator";
            this.jobsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorAddNewItem
            // 
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
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
            // jobsBindingNavigatorSaveItem
            // 
            resources.ApplyResources(this.jobsBindingNavigatorSaveItem, "jobsBindingNavigatorSaveItem");
            this.jobsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jobsBindingNavigatorSaveItem.Name = "jobsBindingNavigatorSaveItem";
            this.jobsBindingNavigatorSaveItem.Click += new System.EventHandler(this.jobsBindingNavigatorSaveItem_Click_1);
            // 
            // jobsTableAdapter
            // 
            this.jobsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JobsTableAdapter = this.jobsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Niche.NicheDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UC_Jobs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.jobsBindingNavigator);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_Jobs";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicheDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingNavigator)).EndInit();
            this.jobsBindingNavigator.ResumeLayout(false);
            this.jobsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private NicheDataSet nicheDataSet;
        private System.Windows.Forms.BindingSource jobsBindingSource;
        private NicheDataSetTableAdapters.JobsTableAdapter jobsTableAdapter;
        private NicheDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jobsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton jobsBindingNavigatorSaveItem;
        private Guna.UI2.WinForms.Guna2DataGridView jobsDataGridView;
        private System.Windows.Forms.Label searchLabel;
        private Guna.UI2.WinForms.Guna2TextBox searchJobsTextBox;
        private Guna.UI2.WinForms.Guna2TrackBar salaryTrackBar;
        private System.Windows.Forms.Label midSalaryLabel;
        private System.Windows.Forms.Label maxSalaryLabel;
        private System.Windows.Forms.Label minSalaryLabel;
        private System.Windows.Forms.Label jobsFormLabel;
        private System.Windows.Forms.Label salaryTrackBarLabel;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2Button showAllButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
