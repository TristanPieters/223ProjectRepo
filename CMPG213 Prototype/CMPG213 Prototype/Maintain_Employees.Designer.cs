namespace CMPG213_Prototype
{
    partial class Maintain_Employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbEmp_JobAdd = new System.Windows.Forms.TextBox();
            this.txbEmp_EmailAdd = new System.Windows.Forms.TextBox();
            this.txbEmp_FNameAdd = new System.Windows.Forms.TextBox();
            this.txbEmp_LNameAdd = new System.Windows.Forms.TextBox();
            this.txbEmp_CellNumAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbEmp_JobUp = new System.Windows.Forms.TextBox();
            this.txbEmp_EmailUp = new System.Windows.Forms.TextBox();
            this.txbEmp_FNameUp = new System.Windows.Forms.TextBox();
            this.txbEmp_LNameUp = new System.Windows.Forms.TextBox();
            this.txbEmp_CellNumUp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tpDelete = new System.Windows.Forms.TabPage();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.stallionsDbDataSet = new CMPG213_Prototype.StallionsDbDataSet();
            this.aCCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTTableAdapter = new CMPG213_Prototype.StallionsDbDataSetTableAdapters.ACCOUNTTableAdapter();
            this.epTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLname = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFname = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCell = new System.Windows.Forms.ErrorProvider(this.components);
            this.epJob = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpLName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpFName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpCell = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpJob = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpEmp_ID = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            this.tpDelete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stallionsDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpLName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpEmp_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAdd);
            this.tabControl1.Controls.Add(this.tpUpdate);
            this.tabControl1.Controls.Add(this.tpDelete);
            this.tabControl1.Location = new System.Drawing.Point(25, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAdd
            // 
            this.tpAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpAdd.Controls.Add(this.btnAdd);
            this.tpAdd.Controls.Add(this.txbEmp_JobAdd);
            this.tpAdd.Controls.Add(this.txbEmp_EmailAdd);
            this.tpAdd.Controls.Add(this.txbEmp_FNameAdd);
            this.tpAdd.Controls.Add(this.txbEmp_LNameAdd);
            this.tpAdd.Controls.Add(this.txbEmp_CellNumAdd);
            this.tpAdd.Controls.Add(this.label7);
            this.tpAdd.Controls.Add(this.label6);
            this.tpAdd.Controls.Add(this.label5);
            this.tpAdd.Controls.Add(this.label3);
            this.tpAdd.Controls.Add(this.label2);
            this.tpAdd.Location = new System.Drawing.Point(4, 34);
            this.tpAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAdd.Size = new System.Drawing.Size(549, 483);
            this.tpAdd.TabIndex = 0;
            this.tpAdd.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(397, 400);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 50);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txbEmp_JobAdd
            // 
            this.txbEmp_JobAdd.Location = new System.Drawing.Point(355, 201);
            this.txbEmp_JobAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmp_JobAdd.Name = "txbEmp_JobAdd";
            this.txbEmp_JobAdd.Size = new System.Drawing.Size(169, 30);
            this.txbEmp_JobAdd.TabIndex = 31;
            this.txbEmp_JobAdd.TextChanged += new System.EventHandler(this.TxbEmp_JobAdd_TextChanged);
            this.txbEmp_JobAdd.Validating += new System.ComponentModel.CancelEventHandler(this.TxbEmp_JobAdd_Validating);
            // 
            // txbEmp_EmailAdd
            // 
            this.txbEmp_EmailAdd.Location = new System.Drawing.Point(355, 245);
            this.txbEmp_EmailAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmp_EmailAdd.Name = "txbEmp_EmailAdd";
            this.txbEmp_EmailAdd.Size = new System.Drawing.Size(169, 30);
            this.txbEmp_EmailAdd.TabIndex = 30;
            this.txbEmp_EmailAdd.Validating += new System.ComponentModel.CancelEventHandler(this.TxbEmp_EmailAdd_Validating);
            // 
            // txbEmp_FNameAdd
            // 
            this.txbEmp_FNameAdd.Location = new System.Drawing.Point(355, 65);
            this.txbEmp_FNameAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmp_FNameAdd.Name = "txbEmp_FNameAdd";
            this.txbEmp_FNameAdd.Size = new System.Drawing.Size(169, 30);
            this.txbEmp_FNameAdd.TabIndex = 28;
            this.txbEmp_FNameAdd.TextChanged += new System.EventHandler(this.TxbEmp_FNameAdd_TextChanged);
            this.txbEmp_FNameAdd.Validating += new System.ComponentModel.CancelEventHandler(this.TxbEmp_FNameAdd_Validating);
            // 
            // txbEmp_LNameAdd
            // 
            this.txbEmp_LNameAdd.Location = new System.Drawing.Point(355, 108);
            this.txbEmp_LNameAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmp_LNameAdd.Name = "txbEmp_LNameAdd";
            this.txbEmp_LNameAdd.Size = new System.Drawing.Size(169, 30);
            this.txbEmp_LNameAdd.TabIndex = 27;
            this.txbEmp_LNameAdd.TextChanged += new System.EventHandler(this.TxbEmp_LNameAdd_TextChanged);
            this.txbEmp_LNameAdd.Validating += new System.ComponentModel.CancelEventHandler(this.TxbEmp_LNameAdd_Validating);
            // 
            // txbEmp_CellNumAdd
            // 
            this.txbEmp_CellNumAdd.Location = new System.Drawing.Point(355, 155);
            this.txbEmp_CellNumAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmp_CellNumAdd.Name = "txbEmp_CellNumAdd";
            this.txbEmp_CellNumAdd.Size = new System.Drawing.Size(169, 30);
            this.txbEmp_CellNumAdd.TabIndex = 25;
            this.txbEmp_CellNumAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbEmp_CellNumAdd_KeyPress);
            this.txbEmp_CellNumAdd.Leave += new System.EventHandler(this.TxbEmp_CellNumAdd_Leave);
            this.txbEmp_CellNumAdd.Validating += new System.ComponentModel.CancelEventHandler(this.TxbEmp_CellNumAdd_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "EMPLOYEE EMAIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "EMPLOYEE JOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "EMPLOYEE CELL NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "EMPLOYEE LAST NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "EMPLOYEE FIRST NAME";
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpUpdate.Controls.Add(this.label18);
            this.tpUpdate.Controls.Add(this.cmbUpdate);
            this.tpUpdate.Controls.Add(this.btnUpdate);
            this.tpUpdate.Controls.Add(this.txbEmp_JobUp);
            this.tpUpdate.Controls.Add(this.txbEmp_EmailUp);
            this.tpUpdate.Controls.Add(this.txbEmp_FNameUp);
            this.tpUpdate.Controls.Add(this.txbEmp_LNameUp);
            this.tpUpdate.Controls.Add(this.txbEmp_CellNumUp);
            this.tpUpdate.Controls.Add(this.label10);
            this.tpUpdate.Controls.Add(this.label11);
            this.tpUpdate.Controls.Add(this.label12);
            this.tpUpdate.Controls.Add(this.label14);
            this.tpUpdate.Controls.Add(this.label15);
            this.tpUpdate.Location = new System.Drawing.Point(4, 34);
            this.tpUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUpdate.Size = new System.Drawing.Size(549, 483);
            this.tpUpdate.TabIndex = 1;
            this.tpUpdate.Text = "Update";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 25);
            this.label18.TabIndex = 51;
            this.label18.Text = "EMPLOYEE ID";
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Location = new System.Drawing.Point(337, 10);
            this.cmbUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(169, 33);
            this.cmbUpdate.TabIndex = 50;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(380, 415);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 48);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txbEmp_JobUp
            // 
            this.txbEmp_JobUp.Location = new System.Drawing.Point(337, 182);
            this.txbEmp_JobUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmp_JobUp.Name = "txbEmp_JobUp";
            this.txbEmp_JobUp.Size = new System.Drawing.Size(169, 30);
            this.txbEmp_JobUp.TabIndex = 47;
            this.txbEmp_JobUp.TextChanged += new System.EventHandler(this.TxbEmp_JobUp_TextChanged);
            this.txbEmp_JobUp.Validating += new System.ComponentModel.CancelEventHandler(this.TxbEmp_JobUp_Validating);
            // 
            // txbEmp_EmailUp
            // 
            this.txbEmp_EmailUp.Location = new System.Drawing.Point(337, 223);
            this.txbEmp_EmailUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmp_EmailUp.Name = "txbEmp_EmailUp";
            this.txbEmp_EmailUp.Size = new System.Drawing.Size(169, 30);
            this.txbEmp_EmailUp.TabIndex = 46;
            this.txbEmp_EmailUp.Validating += new System.ComponentModel.CancelEventHandler(this.TxbEmp_EmailUp_Validating);
            // 
            // txbEmp_FNameUp
            // 
            this.txbEmp_FNameUp.Location = new System.Drawing.Point(337, 57);
            this.txbEmp_FNameUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmp_FNameUp.Name = "txbEmp_FNameUp";
            this.txbEmp_FNameUp.Size = new System.Drawing.Size(169, 30);
            this.txbEmp_FNameUp.TabIndex = 44;
            this.txbEmp_FNameUp.TextChanged += new System.EventHandler(this.TxbEmp_FNameUp_TextChanged);
            this.txbEmp_FNameUp.Validating += new System.ComponentModel.CancelEventHandler(this.TxbEmp_FNameUp_Validating);
            // 
            // txbEmp_LNameUp
            // 
            this.txbEmp_LNameUp.Location = new System.Drawing.Point(337, 100);
            this.txbEmp_LNameUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmp_LNameUp.Name = "txbEmp_LNameUp";
            this.txbEmp_LNameUp.Size = new System.Drawing.Size(169, 30);
            this.txbEmp_LNameUp.TabIndex = 43;
            this.txbEmp_LNameUp.TextChanged += new System.EventHandler(this.TxbEmp_LNameUp_TextChanged);
            this.txbEmp_LNameUp.Validating += new System.ComponentModel.CancelEventHandler(this.TxbEmp_LNameUp_Validating);
            // 
            // txbEmp_CellNumUp
            // 
            this.txbEmp_CellNumUp.Location = new System.Drawing.Point(337, 139);
            this.txbEmp_CellNumUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmp_CellNumUp.Name = "txbEmp_CellNumUp";
            this.txbEmp_CellNumUp.Size = new System.Drawing.Size(169, 30);
            this.txbEmp_CellNumUp.TabIndex = 41;
            this.txbEmp_CellNumUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbEmp_CellNumUp_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 231);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "EMPLOYEE EMAIL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 186);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "EMPLOYEE JOB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 143);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(285, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "EMPLOYEE CELL NUMBER";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 103);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(259, 25);
            this.label14.TabIndex = 34;
            this.label14.Text = "EMPLOYEE LAST NAME";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 60);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(265, 25);
            this.label15.TabIndex = 33;
            this.label15.Text = "EMPLOYEE FIRST NAME";
            // 
            // tpDelete
            // 
            this.tpDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpDelete.Controls.Add(this.cmbDelete);
            this.tpDelete.Controls.Add(this.label17);
            this.tpDelete.Controls.Add(this.btnDelete);
            this.tpDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpDelete.Location = new System.Drawing.Point(4, 34);
            this.tpDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDelete.Name = "tpDelete";
            this.tpDelete.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDelete.Size = new System.Drawing.Size(549, 483);
            this.tpDelete.TabIndex = 2;
            this.tpDelete.Text = "Delete";
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(209, 58);
            this.cmbDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(173, 33);
            this.cmbDelete.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 25);
            this.label17.TabIndex = 35;
            this.label17.Text = "EMPLOYEE ID";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(256, 127);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 53);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack1.Location = new System.Drawing.Point(1055, 528);
            this.btnBack1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(128, 50);
            this.btnBack1.TabIndex = 33;
            this.btnBack1.Text = "BACK";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.BtnBack1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.dgvEmployee);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.btnBack1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1213, 597);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMPLOYEES";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.Location = new System.Drawing.Point(621, 41);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(561, 215);
            this.dgvEmployee.TabIndex = 35;
            // 
            // stallionsDbDataSet
            // 
            this.stallionsDbDataSet.DataSetName = "StallionsDbDataSet";
            this.stallionsDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCCOUNTBindingSource
            // 
            this.aCCOUNTBindingSource.DataMember = "ACCOUNT";
            this.aCCOUNTBindingSource.DataSource = this.stallionsDbDataSet;
            // 
            // aCCOUNTTableAdapter
            // 
            this.aCCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // epTime
            // 
            this.epTime.ContainerControl = this;
            // 
            // epLname
            // 
            this.epLname.ContainerControl = this;
            // 
            // epFname
            // 
            this.epFname.ContainerControl = this;
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            // 
            // epCell
            // 
            this.epCell.ContainerControl = this;
            // 
            // epJob
            // 
            this.epJob.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // epUsername
            // 
            this.epUsername.ContainerControl = this;
            // 
            // epUpTime
            // 
            this.epUpTime.ContainerControl = this;
            // 
            // epUpLName
            // 
            this.epUpLName.ContainerControl = this;
            // 
            // epUpFName
            // 
            this.epUpFName.ContainerControl = this;
            // 
            // epUpPassword
            // 
            this.epUpPassword.ContainerControl = this;
            // 
            // epUpCell
            // 
            this.epUpCell.ContainerControl = this;
            // 
            // epUpJob
            // 
            this.epUpJob.ContainerControl = this;
            // 
            // epUpEmail
            // 
            this.epUpEmail.ContainerControl = this;
            // 
            // epUpUsername
            // 
            this.epUpUsername.ContainerControl = this;
            // 
            // epUpEmp_ID
            // 
            this.epUpEmp_ID.ContainerControl = this;
            // 
            // epDelete
            // 
            this.epDelete.ContainerControl = this;
            // 
            // Maintain_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1245, 626);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Maintain_Employees";
            this.Text = "Maintain_Employees";
            this.Load += new System.EventHandler(this.Maintain_Employees_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            this.tpUpdate.ResumeLayout(false);
            this.tpUpdate.PerformLayout();
            this.tpDelete.ResumeLayout(false);
            this.tpDelete.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stallionsDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpLName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpEmp_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.TextBox txbEmp_JobAdd;
        private System.Windows.Forms.TextBox txbEmp_EmailAdd;
        private System.Windows.Forms.TextBox txbEmp_FNameAdd;
        private System.Windows.Forms.TextBox txbEmp_LNameAdd;
        private System.Windows.Forms.TextBox txbEmp_CellNumAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbEmp_JobUp;
        private System.Windows.Forms.TextBox txbEmp_EmailUp;
        private System.Windows.Forms.TextBox txbEmp_FNameUp;
        private System.Windows.Forms.TextBox txbEmp_LNameUp;
        private System.Windows.Forms.TextBox txbEmp_CellNumUp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tpDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbUpdate;
        private System.Windows.Forms.ComboBox cmbDelete;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private StallionsDbDataSet stallionsDbDataSet;
        private System.Windows.Forms.BindingSource aCCOUNTBindingSource;
        private StallionsDbDataSetTableAdapters.ACCOUNTTableAdapter aCCOUNTTableAdapter;
        private System.Windows.Forms.ErrorProvider epTime;
        private System.Windows.Forms.ErrorProvider epLname;
        private System.Windows.Forms.ErrorProvider epFname;
        private System.Windows.Forms.ErrorProvider epPassword;
        private System.Windows.Forms.ErrorProvider epCell;
        private System.Windows.Forms.ErrorProvider epJob;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.ErrorProvider epUsername;
        private System.Windows.Forms.ErrorProvider epUpTime;
        private System.Windows.Forms.ErrorProvider epUpLName;
        private System.Windows.Forms.ErrorProvider epUpFName;
        private System.Windows.Forms.ErrorProvider epUpPassword;
        private System.Windows.Forms.ErrorProvider epUpCell;
        private System.Windows.Forms.ErrorProvider epUpJob;
        private System.Windows.Forms.ErrorProvider epUpEmail;
        private System.Windows.Forms.ErrorProvider epUpUsername;
        private System.Windows.Forms.ErrorProvider epUpEmp_ID;
        private System.Windows.Forms.ErrorProvider epDelete;
    }
}