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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home_Page_FutureTech));
            this.btnExit = new System.Windows.Forms.Button();
            this.gbSales = new System.Windows.Forms.GroupBox();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.btnUpdateFuelPrice = new System.Windows.Forms.Button();
            this.btnHelpAndSupport = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMaintainFuel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAccounts = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddAccounts = new System.Windows.Forms.Button();
            this.btnViewOutstandingAcc = new System.Windows.Forms.Button();
            this.tpEmpolyees = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.btnWorkHouers = new System.Windows.Forms.Button();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnReceiveOrder = new System.Windows.Forms.Button();
            this.tpSifts = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnClockOut = new System.Windows.Forms.Button();
            this.btnClockIN = new System.Windows.Forms.Button();
            this.tpRewards = new System.Windows.Forms.TabPage();
            this.btnShowRewardAccount = new System.Windows.Forms.Button();
            this.btnMaintainReward = new System.Windows.Forms.Button();
            this.gbSales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpAccounts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpEmpolyees.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpOrders.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpSifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tpRewards.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(733, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // gbSales
            // 
            this.gbSales.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbSales.Controls.Add(this.btnNewSale);
            this.gbSales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSales.Location = new System.Drawing.Point(501, 279);
            this.gbSales.Name = "gbSales";
            this.gbSales.Size = new System.Drawing.Size(204, 81);
            this.gbSales.TabIndex = 3;
            this.gbSales.TabStop = false;
            this.gbSales.Text = "SALES";
            // 
            // btnNewSale
            // 
            this.btnNewSale.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewSale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewSale.Location = new System.Drawing.Point(43, 31);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(124, 32);
            this.btnNewSale.TabIndex = 0;
            this.btnNewSale.Text = "NEW SALE";
            this.btnNewSale.UseVisualStyleBackColor = false;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // btnUpdateFuelPrice
            // 
            this.btnUpdateFuelPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateFuelPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateFuelPrice.Location = new System.Drawing.Point(531, 188);
            this.btnUpdateFuelPrice.Name = "btnUpdateFuelPrice";
            this.btnUpdateFuelPrice.Size = new System.Drawing.Size(127, 51);
            this.btnUpdateFuelPrice.TabIndex = 1;
            this.btnUpdateFuelPrice.Text = "MAINTAIN FUEL";
            this.btnUpdateFuelPrice.UseVisualStyleBackColor = false;
            this.btnUpdateFuelPrice.Click += new System.EventHandler(this.BtnUpdateFuelPrice_Click);
            // 
            // btnHelpAndSupport
            // 
            this.btnHelpAndSupport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHelpAndSupport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHelpAndSupport.Location = new System.Drawing.Point(407, 376);
            this.btnHelpAndSupport.Name = "btnHelpAndSupport";
            this.btnHelpAndSupport.Size = new System.Drawing.Size(208, 32);
            this.btnHelpAndSupport.TabIndex = 4;
            this.btnHelpAndSupport.Text = "HELP AND SUPPORT";
            this.btnHelpAndSupport.UseVisualStyleBackColor = false;
            this.btnHelpAndSupport.Click += new System.EventHandler(this.BtnHelpAndSupport_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReports.Location = new System.Drawing.Point(621, 376);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(106, 32);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tabControl);
            this.groupBox1.Controls.Add(this.btnReports);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnHelpAndSupport);
            this.groupBox1.Controls.Add(this.gbSales);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 414);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STALLION\'S GAS STATION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMaintainFuel);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnUpdateFuelPrice);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(455, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 250);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CURRENT FUEL PRICES";
            // 
            // btnMaintainFuel
            // 
            this.btnMaintainFuel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMaintainFuel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaintainFuel.Location = new System.Drawing.Point(11, 188);
            this.btnMaintainFuel.Name = "btnMaintainFuel";
            this.btnMaintainFuel.Size = new System.Drawing.Size(110, 51);
            this.btnMaintainFuel.TabIndex = 10;
            this.btnMaintainFuel.Text = "MAINTAIN FUEL";
            this.btnMaintainFuel.UseVisualStyleBackColor = false;
            this.btnMaintainFuel.Click += new System.EventHandler(this.BtnMaintainFuel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(232, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "gu";
            this.tabControl.Controls.Add(this.tpHome);
            this.tabControl.Controls.Add(this.tpAccounts);
            this.tabControl.Controls.Add(this.tpEmpolyees);
            this.tabControl.Controls.Add(this.tpOrders);
            this.tabControl.Controls.Add(this.tpSifts);
            this.tabControl.Controls.Add(this.tpRewards);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(24, 23);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(415, 330);
            this.tabControl.TabIndex = 7;
            // 
            // tpHome
            // 
            this.tpHome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpHome.Controls.Add(this.label7);
            this.tpHome.Controls.Add(this.label6);
            this.tpHome.Controls.Add(this.label5);
            this.tpHome.Controls.Add(this.label4);
            this.tpHome.Controls.Add(this.label3);
            this.tpHome.Controls.Add(this.label2);
            this.tpHome.Controls.Add(this.label1);
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(407, 304);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "HOME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "TRISTAN PIETERS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ROELOU VAN DER MERWE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "NEIL FOXCROFT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DEWALD WILLEMSE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ANDRE SPANGENBERG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESIGNED AND DEVELOPED BY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUTURETECH";
            // 
            // tpAccounts
            // 
            this.tpAccounts.Controls.Add(this.panel1);
            this.tpAccounts.Location = new System.Drawing.Point(4, 22);
            this.tpAccounts.Name = "tpAccounts";
            this.tpAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccounts.Size = new System.Drawing.Size(407, 304);
            this.tpAccounts.TabIndex = 1;
            this.tpAccounts.Text = "ACCOUNTS";
            this.tpAccounts.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnAddAccounts);
            this.panel1.Controls.Add(this.btnViewOutstandingAcc);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 306);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btnAddAccounts
            // 
            this.btnAddAccounts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccounts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddAccounts.Location = new System.Drawing.Point(16, 32);
            this.btnAddAccounts.Name = "btnAddAccounts";
            this.btnAddAccounts.Size = new System.Drawing.Size(192, 66);
            this.btnAddAccounts.TabIndex = 0;
            this.btnAddAccounts.Text = "ADD NEW ACCOUNT";
            this.btnAddAccounts.UseVisualStyleBackColor = false;
            this.btnAddAccounts.Click += new System.EventHandler(this.BtnAddAccounts_Click);
            // 
            // btnViewOutstandingAcc
            // 
            this.btnViewOutstandingAcc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnViewOutstandingAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOutstandingAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewOutstandingAcc.Location = new System.Drawing.Point(16, 131);
            this.btnViewOutstandingAcc.Name = "btnViewOutstandingAcc";
            this.btnViewOutstandingAcc.Size = new System.Drawing.Size(192, 65);
            this.btnViewOutstandingAcc.TabIndex = 2;
            this.btnViewOutstandingAcc.Text = "UPDATE AND DELETE ACCOUNTS";
            this.btnViewOutstandingAcc.UseVisualStyleBackColor = false;
            this.btnViewOutstandingAcc.Click += new System.EventHandler(this.BtnViewOutstandingAcc_Click);
            // 
            // tpEmpolyees
            // 
            this.tpEmpolyees.Controls.Add(this.panel2);
            this.tpEmpolyees.Location = new System.Drawing.Point(4, 22);
            this.tpEmpolyees.Name = "tpEmpolyees";
            this.tpEmpolyees.Size = new System.Drawing.Size(407, 304);
            this.tpEmpolyees.TabIndex = 2;
            this.tpEmpolyees.Text = "EMPLOYEES";
            this.tpEmpolyees.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnManageEmployees);
            this.panel2.Controls.Add(this.btnWorkHouers);
            this.panel2.Location = new System.Drawing.Point(-4, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 310);
            this.panel2.TabIndex = 3;
            // 
            // btnManageEmployees
            // 
            this.btnManageEmployees.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnManageEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnManageEmployees.Location = new System.Drawing.Point(18, 76);
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.Size = new System.Drawing.Size(151, 47);
            this.btnManageEmployees.TabIndex = 2;
            this.btnManageEmployees.Text = "MANAGE EMPLOYEES";
            this.btnManageEmployees.UseVisualStyleBackColor = false;
            this.btnManageEmployees.Click += new System.EventHandler(this.BtnManageEmployees_Click);
            // 
            // btnWorkHouers
            // 
            this.btnWorkHouers.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.tpOrders.Size = new System.Drawing.Size(407, 304);
            this.tpOrders.TabIndex = 3;
            this.tpOrders.Text = "ORDERS";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.btnPlaceOrder);
            this.panel3.Controls.Add(this.btnReceiveOrder);
            this.panel3.Location = new System.Drawing.Point(-4, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 310);
            this.panel3.TabIndex = 2;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlaceOrder.Location = new System.Drawing.Point(30, 49);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(128, 38);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "PLACE ORDER";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnReceiveOrder
            // 
            this.btnReceiveOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReceiveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReceiveOrder.Location = new System.Drawing.Point(30, 144);
            this.btnReceiveOrder.Name = "btnReceiveOrder";
            this.btnReceiveOrder.Size = new System.Drawing.Size(128, 38);
            this.btnReceiveOrder.TabIndex = 1;
            this.btnReceiveOrder.Text = "RECIEVE ORDER";
            this.btnReceiveOrder.UseVisualStyleBackColor = false;
            this.btnReceiveOrder.Click += new System.EventHandler(this.BtnReceiveOrder_Click);
            // 
            // tpSifts
            // 
            this.tpSifts.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpSifts.Controls.Add(this.pictureBox6);
            this.tpSifts.Controls.Add(this.btnClockOut);
            this.tpSifts.Controls.Add(this.btnClockIN);
            this.tpSifts.Location = new System.Drawing.Point(4, 22);
            this.tpSifts.Name = "tpSifts";
            this.tpSifts.Size = new System.Drawing.Size(407, 304);
            this.tpSifts.TabIndex = 4;
            this.tpSifts.Text = "SHIFTS";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(132, 91);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(118, 101);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // btnClockOut
            // 
            this.btnClockOut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClockOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClockOut.Location = new System.Drawing.Point(132, 215);
            this.btnClockOut.Name = "btnClockOut";
            this.btnClockOut.Size = new System.Drawing.Size(118, 33);
            this.btnClockOut.TabIndex = 1;
            this.btnClockOut.Text = "CLOCK OUT";
            this.btnClockOut.UseVisualStyleBackColor = false;
            // 
            // btnClockIN
            // 
            this.btnClockIN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClockIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClockIN.Location = new System.Drawing.Point(132, 37);
            this.btnClockIN.Name = "btnClockIN";
            this.btnClockIN.Size = new System.Drawing.Size(118, 33);
            this.btnClockIN.TabIndex = 0;
            this.btnClockIN.Text = "CLOCK IN";
            this.btnClockIN.UseVisualStyleBackColor = false;
            this.btnClockIN.Click += new System.EventHandler(this.btnClockIN_Click);
            // 
            // tpRewards
            // 
            this.tpRewards.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpRewards.Controls.Add(this.btnShowRewardAccount);
            this.tpRewards.Controls.Add(this.btnMaintainReward);
            this.tpRewards.Location = new System.Drawing.Point(4, 22);
            this.tpRewards.Name = "tpRewards";
            this.tpRewards.Size = new System.Drawing.Size(407, 304);
            this.tpRewards.TabIndex = 5;
            this.tpRewards.Text = "REWARDS";
            // 
            // btnShowRewardAccount
            // 
            this.btnShowRewardAccount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnShowRewardAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowRewardAccount.Location = new System.Drawing.Point(15, 134);
            this.btnShowRewardAccount.Name = "btnShowRewardAccount";
            this.btnShowRewardAccount.Size = new System.Drawing.Size(206, 54);
            this.btnShowRewardAccount.TabIndex = 1;
            this.btnShowRewardAccount.Text = "SHOW REWARDS ON ACCOUNT";
            this.btnShowRewardAccount.UseVisualStyleBackColor = false;
            // 
            // btnMaintainReward
            // 
            this.btnMaintainReward.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMaintainReward.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaintainReward.Location = new System.Drawing.Point(15, 60);
            this.btnMaintainReward.Name = "btnMaintainReward";
            this.btnMaintainReward.Size = new System.Drawing.Size(206, 54);
            this.btnMaintainReward.TabIndex = 0;
            this.btnMaintainReward.Text = "MAINTAIN REWARDS";
            this.btnMaintainReward.UseVisualStyleBackColor = false;
            this.btnMaintainReward.Click += new System.EventHandler(this.BtnMaintainReward_Click);
            // 
            // Form_Home_Page_FutureTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Home_Page_FutureTech";
            this.Text = "Form_Home_Page_FutureTech";
            this.Load += new System.EventHandler(this.Form_Home_Page_FutureTech_Load);
            this.gbSales.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpHome.PerformLayout();
            this.tpAccounts.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tpEmpolyees.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tpOrders.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tpSifts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tpRewards.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbSales;
        private System.Windows.Forms.Button btnUpdateFuelPrice;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Button btnHelpAndSupport;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpAccounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddAccounts;
        private System.Windows.Forms.Button btnViewOutstandingAcc;
        private System.Windows.Forms.TabPage tpEmpolyees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManageEmployees;
        private System.Windows.Forms.Button btnWorkHouers;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnReceiveOrder;
        private System.Windows.Forms.TabPage tpSifts;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnClockOut;
        private System.Windows.Forms.Button btnClockIN;
        private System.Windows.Forms.TabPage tpRewards;
        private System.Windows.Forms.Button btnShowRewardAccount;
        private System.Windows.Forms.Button btnMaintainReward;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaintainFuel;
    }
}