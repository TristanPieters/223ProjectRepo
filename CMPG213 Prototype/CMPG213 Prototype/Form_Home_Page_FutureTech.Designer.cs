namespace CMPG213_Prototype
{
    partial class Form_Home_Page_FutureTech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home_Page_FutureTech));
            this.gbFuelType = new System.Windows.Forms.GroupBox();
            this.lblDiesel500 = new System.Windows.Forms.Label();
            this.lblDiesel50 = new System.Windows.Forms.Label();
            this.lblUnleaded95 = new System.Windows.Forms.Label();
            this.lblUnleaded93 = new System.Windows.Forms.Label();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbSales = new System.Windows.Forms.GroupBox();
            this.btnUpdateFuelPrice = new System.Windows.Forms.Button();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.btnHelpAndSupport = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.lblCurrentFuelPrices = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpAccounts = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddAccounts = new System.Windows.Forms.Button();
            this.btnViewAccountDB = new System.Windows.Forms.Button();
            this.btnViewOutstandingAcc = new System.Windows.Forms.Button();
            this.tpEmpolyees = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.btnWorkHouers = new System.Windows.Forms.Button();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnReceiveOrder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbFuelType.SuspendLayout();
            this.gbPrice.SuspendLayout();
            this.gbSales.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpAccounts.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpEmpolyees.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tpOrders.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFuelType
            // 
            this.gbFuelType.Controls.Add(this.lblDiesel500);
            this.gbFuelType.Controls.Add(this.lblDiesel50);
            this.gbFuelType.Controls.Add(this.lblUnleaded95);
            this.gbFuelType.Controls.Add(this.lblUnleaded93);
            this.gbFuelType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbFuelType.Location = new System.Drawing.Point(467, 29);
            this.gbFuelType.Name = "gbFuelType";
            this.gbFuelType.Size = new System.Drawing.Size(103, 141);
            this.gbFuelType.TabIndex = 0;
            this.gbFuelType.TabStop = false;
            this.gbFuelType.Text = "FUEL TYPE";
            this.gbFuelType.Enter += new System.EventHandler(this.GbFuelType_Enter);
            // 
            // lblDiesel500
            // 
            this.lblDiesel500.AutoSize = true;
            this.lblDiesel500.Location = new System.Drawing.Point(6, 110);
            this.lblDiesel500.Name = "lblDiesel500";
            this.lblDiesel500.Size = new System.Drawing.Size(80, 13);
            this.lblDiesel500.TabIndex = 3;
            this.lblDiesel500.Text = "DIESEL 500:";
            // 
            // lblDiesel50
            // 
            this.lblDiesel50.AutoSize = true;
            this.lblDiesel50.Location = new System.Drawing.Point(6, 83);
            this.lblDiesel50.Name = "lblDiesel50";
            this.lblDiesel50.Size = new System.Drawing.Size(73, 13);
            this.lblDiesel50.TabIndex = 2;
            this.lblDiesel50.Text = "DIESEL 50:";
            // 
            // lblUnleaded95
            // 
            this.lblUnleaded95.AutoSize = true;
            this.lblUnleaded95.Location = new System.Drawing.Point(6, 54);
            this.lblUnleaded95.Name = "lblUnleaded95";
            this.lblUnleaded95.Size = new System.Drawing.Size(96, 13);
            this.lblUnleaded95.TabIndex = 1;
            this.lblUnleaded95.Text = "UNLEADED 95:";
            // 
            // lblUnleaded93
            // 
            this.lblUnleaded93.AutoSize = true;
            this.lblUnleaded93.Location = new System.Drawing.Point(6, 26);
            this.lblUnleaded93.Name = "lblUnleaded93";
            this.lblUnleaded93.Size = new System.Drawing.Size(96, 13);
            this.lblUnleaded93.TabIndex = 0;
            this.lblUnleaded93.Text = "UNLEADED 93:";
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.label4);
            this.gbPrice.Controls.Add(this.label3);
            this.gbPrice.Controls.Add(this.label2);
            this.gbPrice.Controls.Add(this.label1);
            this.gbPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbPrice.Location = new System.Drawing.Point(587, 29);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(103, 141);
            this.gbPrice.TabIndex = 1;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "PRICE";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(670, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // gbSales
            // 
            this.gbSales.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbSales.Controls.Add(this.btnUpdateFuelPrice);
            this.gbSales.Controls.Add(this.btnNewSale);
            this.gbSales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSales.Location = new System.Drawing.Point(467, 195);
            this.gbSales.Name = "gbSales";
            this.gbSales.Size = new System.Drawing.Size(212, 154);
            this.gbSales.TabIndex = 3;
            this.gbSales.TabStop = false;
            this.gbSales.Text = "SALES";
            // 
            // btnUpdateFuelPrice
            // 
            this.btnUpdateFuelPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateFuelPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateFuelPrice.Location = new System.Drawing.Point(6, 36);
            this.btnUpdateFuelPrice.Name = "btnUpdateFuelPrice";
            this.btnUpdateFuelPrice.Size = new System.Drawing.Size(103, 40);
            this.btnUpdateFuelPrice.TabIndex = 1;
            this.btnUpdateFuelPrice.Text = "Maintain Fuel";
            this.btnUpdateFuelPrice.UseVisualStyleBackColor = false;
            this.btnUpdateFuelPrice.Click += new System.EventHandler(this.BtnUpdateFuelPrice_Click);
            // 
            // btnNewSale
            // 
            this.btnNewSale.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewSale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewSale.Location = new System.Drawing.Point(6, 93);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(101, 40);
            this.btnNewSale.TabIndex = 0;
            this.btnNewSale.Text = "NEW SALE";
<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            this.btnNewSale.UseVisualStyleBackColor = true;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // btnHelpAndSupport
            // 
<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
=======

>>>>>>> Stashed changes

            this.btnNewSale.UseVisualStyleBackColor = false;

            this.btnNewSale.UseVisualStyleBackColor = true;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
<<<<<<< Updated upstream


<<<<<<< Updated upstream
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            this.btnHelpAndSupport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHelpAndSupport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHelpAndSupport.Location = new System.Drawing.Point(412, 376);
            this.btnHelpAndSupport.Name = "btnHelpAndSupport";
            this.btnHelpAndSupport.Size = new System.Drawing.Size(158, 32);
            this.btnHelpAndSupport.TabIndex = 4;
            this.btnHelpAndSupport.Text = "HELP AND SUPPORT";
            this.btnHelpAndSupport.UseVisualStyleBackColor = false;
            this.btnHelpAndSupport.Click += new System.EventHandler(this.BtnHelpAndSupport_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReports.Location = new System.Drawing.Point(576, 376);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(88, 32);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // lblCurrentFuelPrices
            // 
            this.lblCurrentFuelPrices.AutoSize = true;
            this.lblCurrentFuelPrices.Location = new System.Drawing.Point(506, 13);
            this.lblCurrentFuelPrices.Name = "lblCurrentFuelPrices";
            this.lblCurrentFuelPrices.Size = new System.Drawing.Size(142, 13);
            this.lblCurrentFuelPrices.TabIndex = 6;
            this.lblCurrentFuelPrices.Text = "CURRET FUEL PRICES";
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "gu";
            this.tabControl.Controls.Add(this.tpHome);
            this.tabControl.Controls.Add(this.tpAccounts);
            this.tabControl.Controls.Add(this.tpEmpolyees);
            this.tabControl.Controls.Add(this.tpOrders);
            this.tabControl.Location = new System.Drawing.Point(24, 23);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(431, 330);
            this.tabControl.TabIndex = 7;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.pictureBox1);
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(423, 304);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "HOME";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tpAccounts
            // 
            this.tpAccounts.Controls.Add(this.panel1);
            this.tpAccounts.Location = new System.Drawing.Point(4, 22);
            this.tpAccounts.Name = "tpAccounts";
            this.tpAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccounts.Size = new System.Drawing.Size(423, 304);
            this.tpAccounts.TabIndex = 1;
            this.tpAccounts.Text = "ACCOUNTS";
            this.tpAccounts.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnAddAccounts);
            this.panel1.Controls.Add(this.btnViewAccountDB);
            this.panel1.Controls.Add(this.btnViewOutstandingAcc);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 306);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(350, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 306);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddAccounts
            // 
            this.btnAddAccounts.BackColor = System.Drawing.Color.White;
            this.btnAddAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccounts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddAccounts.Location = new System.Drawing.Point(16, 32);
            this.btnAddAccounts.Name = "btnAddAccounts";
            this.btnAddAccounts.Size = new System.Drawing.Size(192, 66);
            this.btnAddAccounts.TabIndex = 0;
            this.btnAddAccounts.Text = "Add New Accounts";
            this.btnAddAccounts.UseVisualStyleBackColor = false;
            this.btnAddAccounts.Click += new System.EventHandler(this.BtnAddAccounts_Click);
            // 
            // btnViewAccountDB
            // 
            this.btnViewAccountDB.BackColor = System.Drawing.Color.White;
            this.btnViewAccountDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAccountDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewAccountDB.Location = new System.Drawing.Point(16, 115);
            this.btnViewAccountDB.Name = "btnViewAccountDB";
            this.btnViewAccountDB.Size = new System.Drawing.Size(192, 63);
            this.btnViewAccountDB.TabIndex = 1;
            this.btnViewAccountDB.Text = "View Outstanding Accounts";
            this.btnViewAccountDB.UseVisualStyleBackColor = false;
            this.btnViewAccountDB.Click += new System.EventHandler(this.BtnViewAccountDB_Click);
            // 
            // btnViewOutstandingAcc
            // 
            this.btnViewOutstandingAcc.BackColor = System.Drawing.Color.White;
            this.btnViewOutstandingAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOutstandingAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewOutstandingAcc.Location = new System.Drawing.Point(16, 194);
            this.btnViewOutstandingAcc.Name = "btnViewOutstandingAcc";
            this.btnViewOutstandingAcc.Size = new System.Drawing.Size(192, 65);
            this.btnViewOutstandingAcc.TabIndex = 2;
            this.btnViewOutstandingAcc.Text = "Update and Delete Accounts ";
            this.btnViewOutstandingAcc.UseVisualStyleBackColor = false;
            this.btnViewOutstandingAcc.Click += new System.EventHandler(this.BtnViewOutstandingAcc_Click);
            // 
            // tpEmpolyees
            // 
            this.tpEmpolyees.Controls.Add(this.panel2);
            this.tpEmpolyees.Location = new System.Drawing.Point(4, 22);
            this.tpEmpolyees.Name = "tpEmpolyees";
            this.tpEmpolyees.Size = new System.Drawing.Size(423, 304);
            this.tpEmpolyees.TabIndex = 2;
            this.tpEmpolyees.Text = "EMPLOYEES";
            this.tpEmpolyees.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btnManageEmployees);
            this.panel2.Controls.Add(this.btnWorkHouers);
            this.panel2.Location = new System.Drawing.Point(-4, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 310);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(354, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 306);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btnManageEmployees
            // 
            this.btnManageEmployees.BackColor = System.Drawing.Color.White;
            this.btnManageEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnManageEmployees.Location = new System.Drawing.Point(18, 66);
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.Size = new System.Drawing.Size(151, 47);
            this.btnManageEmployees.TabIndex = 2;
            this.btnManageEmployees.Text = "MANAGE EMPLOYEES";
            this.btnManageEmployees.UseVisualStyleBackColor = false;
            this.btnManageEmployees.Click += new System.EventHandler(this.BtnManageEmployees_Click);
            // 
            // btnWorkHouers
            // 
            this.btnWorkHouers.BackColor = System.Drawing.Color.White;
            this.btnWorkHouers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkHouers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWorkHouers.Location = new System.Drawing.Point(18, 156);
            this.btnWorkHouers.Name = "btnWorkHouers";
            this.btnWorkHouers.Size = new System.Drawing.Size(151, 47);
            this.btnWorkHouers.TabIndex = 0;
            this.btnWorkHouers.Text = "MANAGE WORK HOUERS";
            this.btnWorkHouers.UseVisualStyleBackColor = false;
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.panel3);
            this.tpOrders.Location = new System.Drawing.Point(4, 22);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Size = new System.Drawing.Size(423, 304);
            this.tpOrders.TabIndex = 3;
            this.tpOrders.Text = "OREDERS";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.btnPlaceOrder);
            this.panel3.Controls.Add(this.btnReceiveOrder);
            this.panel3.Location = new System.Drawing.Point(-4, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 310);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(351, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 306);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlaceOrder.Location = new System.Drawing.Point(16, 44);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(118, 32);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "PLACE ORDER";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // btnReceiveOrder
            // 
            this.btnReceiveOrder.BackColor = System.Drawing.Color.White;
            this.btnReceiveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReceiveOrder.Location = new System.Drawing.Point(16, 156);
            this.btnReceiveOrder.Name = "btnReceiveOrder";
            this.btnReceiveOrder.Size = new System.Drawing.Size(118, 32);
            this.btnReceiveOrder.TabIndex = 1;
            this.btnReceiveOrder.Text = "RECIEVE ORDER";
            this.btnReceiveOrder.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl);
            this.groupBox1.Controls.Add(this.gbPrice);
            this.groupBox1.Controls.Add(this.btnReports);
            this.groupBox1.Controls.Add(this.lblCurrentFuelPrices);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnHelpAndSupport);
            this.groupBox1.Controls.Add(this.gbFuelType);
            this.groupBox1.Controls.Add(this.gbSales);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 414);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STALLION\'S GAS STATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // Form_Home_Page_FutureTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Home_Page_FutureTech";
            this.Text = "Form_Home_Page_FutureTech";
            this.Load += new System.EventHandler(this.Form_Home_Page_FutureTech_Load);
            this.gbFuelType.ResumeLayout(false);
            this.gbFuelType.PerformLayout();
            this.gbPrice.ResumeLayout(false);
            this.gbPrice.PerformLayout();
            this.gbSales.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpAccounts.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpEmpolyees.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tpOrders.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFuelType;
        private System.Windows.Forms.Label lblDiesel50;
        private System.Windows.Forms.Label lblUnleaded95;
        private System.Windows.Forms.Label lblUnleaded93;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.Label lblDiesel500;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbSales;
        private System.Windows.Forms.Button btnUpdateFuelPrice;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Button btnHelpAndSupport;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label lblCurrentFuelPrices;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpAccounts;
        private System.Windows.Forms.TabPage tpEmpolyees;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.Button btnViewOutstandingAcc;
        private System.Windows.Forms.Button btnViewAccountDB;
        private System.Windows.Forms.Button btnAddAccounts;
        private System.Windows.Forms.Button btnManageEmployees;
        private System.Windows.Forms.Button btnWorkHouers;
        private System.Windows.Forms.Button btnReceiveOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}