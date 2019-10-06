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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFirstNameU = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxEmailU = new System.Windows.Forms.TextBox();
            this.tbxLiters = new System.Windows.Forms.TextBox();
            this.tbxLastNameU = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxCellNumberU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxIDu = new System.Windows.Forms.TextBox();
            this.tbxDebt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stallionsDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(48, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1330, 473);
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
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.bindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.bindingNavigator1.Location = new System.Drawing.Point(10, 102);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0);
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(391, 42);
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
            this.tbxID.Location = new System.Drawing.Point(48, 83);
            this.tbxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(248, 44);
            this.tbxID.TabIndex = 2;
            this.tbxID.TextChanged += new System.EventHandler(this.TbxID_TextChanged);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteAccount.Location = new System.Drawing.Point(64, 142);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(140, 56);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "DELETE";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(1412, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(410, 221);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NAVIGATE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDeleteAccount);
            this.groupBox2.Controls.Add(this.tbxID);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(1412, 562);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(410, 221);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DELETE";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
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
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(1412, 302);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(410, 221);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FILTER BY";
            // 
            // btnFillterLiters
            // 
            this.btnFillterLiters.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFillterLiters.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFillterLiters.Location = new System.Drawing.Point(30, 127);
            this.btnFillterLiters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFillterLiters.Name = "btnFillterLiters";
            this.btnFillterLiters.Size = new System.Drawing.Size(276, 62);
            this.btnFillterLiters.TabIndex = 1;
            this.btnFillterLiters.Text = "MOST LITERS";
            this.btnFillterLiters.UseVisualStyleBackColor = false;
            this.btnFillterLiters.Click += new System.EventHandler(this.BtnFillterLiters_Click);
            // 
            // btnOutstanding
            // 
            this.btnOutstanding.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOutstanding.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOutstanding.Location = new System.Drawing.Point(30, 42);
            this.btnOutstanding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOutstanding.Name = "btnOutstanding";
            this.btnOutstanding.Size = new System.Drawing.Size(276, 60);
            this.btnOutstanding.TabIndex = 0;
            this.btnOutstanding.Text = "OUSTANDING ACCOUNTS";
            this.btnOutstanding.UseVisualStyleBackColor = false;
            this.btnOutstanding.Click += new System.EventHandler(this.BtnOutstanding_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(22, 21);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(1988, 1006);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UPDATE  AND DELETE ACCOUNT";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(1584, 865);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(238, 85);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.btnUpdateAccount);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tbxFirstNameU);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tbxEmailU);
            this.groupBox5.Controls.Add(this.tbxLiters);
            this.groupBox5.Controls.Add(this.tbxLastNameU);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.tbxCellNumberU);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.tbxIDu);
            this.groupBox5.Controls.Add(this.tbxDebt);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(48, 562);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Size = new System.Drawing.Size(1262, 408);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "UPDATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(986, 231);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 44);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cell Number:";
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateAccount.Location = new System.Drawing.Point(986, 304);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(216, 85);
            this.btnUpdateAccount.TabIndex = 12;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID:";
            // 
            // tbxFirstNameU
            // 
            this.tbxFirstNameU.Location = new System.Drawing.Point(268, 46);
            this.tbxFirstNameU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxFirstNameU.Name = "tbxFirstNameU";
            this.tbxFirstNameU.Size = new System.Drawing.Size(240, 44);
            this.tbxFirstNameU.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(594, 244);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(354, 37);
            this.label10.TabIndex = 19;
            this.label10.Text = "Account ID to change:";
            // 
            // tbxEmailU
            // 
            this.tbxEmailU.Location = new System.Drawing.Point(986, 115);
            this.tbxEmailU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxEmailU.Name = "tbxEmailU";
            this.tbxEmailU.Size = new System.Drawing.Size(240, 44);
            this.tbxEmailU.TabIndex = 7;
            // 
            // tbxLiters
            // 
            this.tbxLiters.Location = new System.Drawing.Point(268, 233);
            this.tbxLiters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxLiters.Name = "tbxLiters";
            this.tbxLiters.Size = new System.Drawing.Size(240, 44);
            this.tbxLiters.TabIndex = 17;
            // 
            // tbxLastNameU
            // 
            this.tbxLastNameU.Location = new System.Drawing.Point(986, 52);
            this.tbxLastNameU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxLastNameU.Name = "tbxLastNameU";
            this.tbxLastNameU.Size = new System.Drawing.Size(240, 44);
            this.tbxLastNameU.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 244);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 37);
            this.label9.TabIndex = 16;
            this.label9.Text = "Liters:";
            // 
            // tbxCellNumberU
            // 
            this.tbxCellNumberU.Location = new System.Drawing.Point(268, 110);
            this.tbxCellNumberU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCellNumberU.Name = "tbxCellNumberU";
            this.tbxCellNumberU.Size = new System.Drawing.Size(240, 44);
            this.tbxCellNumberU.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "Debt:";
            // 
            // tbxIDu
            // 
            this.tbxIDu.Location = new System.Drawing.Point(268, 173);
            this.tbxIDu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxIDu.Name = "tbxIDu";
            this.tbxIDu.Size = new System.Drawing.Size(240, 44);
            this.tbxIDu.TabIndex = 11;
            // 
            // tbxDebt
            // 
            this.tbxDebt.Location = new System.Drawing.Point(986, 171);
            this.tbxDebt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDebt.Name = "tbxDebt";
            this.tbxDebt.Size = new System.Drawing.Size(240, 44);
            this.tbxDebt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 581);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 37);
            this.label6.TabIndex = 5;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // AccountUpdateDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(2066, 1048);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxLiters;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxDebt;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.TextBox tbxIDu;
        private System.Windows.Forms.TextBox tbxCellNumberU;
        private System.Windows.Forms.TextBox tbxLastNameU;
        private System.Windows.Forms.TextBox tbxEmailU;
        private System.Windows.Forms.TextBox tbxFirstNameU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}