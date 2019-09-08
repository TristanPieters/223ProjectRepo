namespace CMPG213_Prototype
{
    partial class AccountUpdateDel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountUpdateDel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accCellnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accIDnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accDebtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accLSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stallionsDbDataSet = new CMPG213_Prototype.StallionsDbDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aCCOUNTTableAdapter = new CMPG213_Prototype.StallionsDbDataSetTableAdapters.ACCOUNTTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFillterLiters = new System.Windows.Forms.Button();
            this.btnOutstanding = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stallionsDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accIDDataGridViewTextBoxColumn,
            this.accFNameDataGridViewTextBoxColumn,
            this.accLNameDataGridViewTextBoxColumn,
            this.accEmailDataGridViewTextBoxColumn,
            this.accCellnumDataGridViewTextBoxColumn,
            this.accIDnumDataGridViewTextBoxColumn,
            this.accDebtDataGridViewTextBoxColumn,
            this.accLSoldDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aCCOUNTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1361, 446);
            this.dataGridView1.TabIndex = 0;
            // 
            // accIDDataGridViewTextBoxColumn
            // 
            this.accIDDataGridViewTextBoxColumn.DataPropertyName = "Acc_ID";
            this.accIDDataGridViewTextBoxColumn.HeaderText = "Acc_ID";
            this.accIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.accIDDataGridViewTextBoxColumn.Name = "accIDDataGridViewTextBoxColumn";
            this.accIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.accIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // accFNameDataGridViewTextBoxColumn
            // 
            this.accFNameDataGridViewTextBoxColumn.DataPropertyName = "Acc_FName";
            this.accFNameDataGridViewTextBoxColumn.HeaderText = "Acc_FName";
            this.accFNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.accFNameDataGridViewTextBoxColumn.Name = "accFNameDataGridViewTextBoxColumn";
            this.accFNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // accLNameDataGridViewTextBoxColumn
            // 
            this.accLNameDataGridViewTextBoxColumn.DataPropertyName = "Acc_LName";
            this.accLNameDataGridViewTextBoxColumn.HeaderText = "Acc_LName";
            this.accLNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.accLNameDataGridViewTextBoxColumn.Name = "accLNameDataGridViewTextBoxColumn";
            this.accLNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // accEmailDataGridViewTextBoxColumn
            // 
            this.accEmailDataGridViewTextBoxColumn.DataPropertyName = "Acc_Email";
            this.accEmailDataGridViewTextBoxColumn.HeaderText = "Acc_Email";
            this.accEmailDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.accEmailDataGridViewTextBoxColumn.Name = "accEmailDataGridViewTextBoxColumn";
            this.accEmailDataGridViewTextBoxColumn.Width = 200;
            // 
            // accCellnumDataGridViewTextBoxColumn
            // 
            this.accCellnumDataGridViewTextBoxColumn.DataPropertyName = "Acc_Cellnum";
            this.accCellnumDataGridViewTextBoxColumn.HeaderText = "Acc_Cellnum";
            this.accCellnumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.accCellnumDataGridViewTextBoxColumn.Name = "accCellnumDataGridViewTextBoxColumn";
            this.accCellnumDataGridViewTextBoxColumn.Width = 200;
            // 
            // accIDnumDataGridViewTextBoxColumn
            // 
            this.accIDnumDataGridViewTextBoxColumn.DataPropertyName = "Acc_IDnum";
            this.accIDnumDataGridViewTextBoxColumn.HeaderText = "Acc_IDnum";
            this.accIDnumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.accIDnumDataGridViewTextBoxColumn.Name = "accIDnumDataGridViewTextBoxColumn";
            this.accIDnumDataGridViewTextBoxColumn.Width = 200;
            // 
            // accDebtDataGridViewTextBoxColumn
            // 
            this.accDebtDataGridViewTextBoxColumn.DataPropertyName = "Acc_Debt";
            this.accDebtDataGridViewTextBoxColumn.HeaderText = "Acc_Debt";
            this.accDebtDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.accDebtDataGridViewTextBoxColumn.Name = "accDebtDataGridViewTextBoxColumn";
            this.accDebtDataGridViewTextBoxColumn.Width = 200;
            // 
            // accLSoldDataGridViewTextBoxColumn
            // 
            this.accLSoldDataGridViewTextBoxColumn.DataPropertyName = "Acc_LSold";
            this.accLSoldDataGridViewTextBoxColumn.HeaderText = "Acc_LSold";
            this.accLSoldDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.accLSoldDataGridViewTextBoxColumn.Name = "accLSoldDataGridViewTextBoxColumn";
            this.accLSoldDataGridViewTextBoxColumn.Width = 200;
            // 
            // aCCOUNTBindingSource
            // 
            this.aCCOUNTBindingSource.DataMember = "ACCOUNT";
            this.aCCOUNTBindingSource.DataSource = this.stallionsDbDataSet;
            // 
            // stallionsDbDataSet
            // 
            this.stallionsDbDataSet.DataSetName = "StallionsDbDataSet";
            this.stallionsDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.aCCOUNTBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.bindingNavigator1.Location = new System.Drawing.Point(10, 102);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(285, 42);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(47, 83);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(247, 31);
            this.tbxID.TabIndex = 2;
            this.tbxID.TextChanged += new System.EventHandler(this.TbxID_TextChanged);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(64, 142);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(139, 56);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Location = new System.Drawing.Point(93, 615);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDeleteAccount);
            this.groupBox2.Controls.Add(this.tbxID);
            this.groupBox2.Location = new System.Drawing.Point(504, 615);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 222);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delete by ID:";
            // 
            // aCCOUNTTableAdapter
            // 
            this.aCCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFillterLiters);
            this.groupBox3.Controls.Add(this.btnOutstanding);
            this.groupBox3.Location = new System.Drawing.Point(103, 899);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 222);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter By";
            // 
            // btnFillterLiters
            // 
            this.btnFillterLiters.Location = new System.Drawing.Point(30, 126);
            this.btnFillterLiters.Name = "btnFillterLiters";
            this.btnFillterLiters.Size = new System.Drawing.Size(277, 61);
            this.btnFillterLiters.TabIndex = 1;
            this.btnFillterLiters.Text = "Most Litres";
            this.btnFillterLiters.UseVisualStyleBackColor = true;
            // 
            // btnOutstanding
            // 
            this.btnOutstanding.Location = new System.Drawing.Point(30, 43);
            this.btnOutstanding.Name = "btnOutstanding";
            this.btnOutstanding.Size = new System.Drawing.Size(277, 59);
            this.btnOutstanding.TabIndex = 0;
            this.btnOutstanding.Text = "Outstanding Accounts";
            this.btnOutstanding.UseVisualStyleBackColor = true;
            this.btnOutstanding.Click += new System.EventHandler(this.BtnOutstanding_Click);
            // 
            // AccountUpdateDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1559);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AccountUpdateDel";
            this.Text = "AccountUpdateDel";
            this.Load += new System.EventHandler(this.AccountUpdateDel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stallionsDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StallionsDbDataSet stallionsDbDataSet;
        private System.Windows.Forms.BindingSource aCCOUNTBindingSource;
        private StallionsDbDataSetTableAdapters.ACCOUNTTableAdapter aCCOUNTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accCellnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accIDnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accDebtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accLSoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFillterLiters;
        private System.Windows.Forms.Button btnOutstanding;
    }
}