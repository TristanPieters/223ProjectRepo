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
            this.gbFuelType = new System.Windows.Forms.GroupBox();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.lblUnleaded93 = new System.Windows.Forms.Label();
            this.lblUnleaded95 = new System.Windows.Forms.Label();
            this.lblDiesel50 = new System.Windows.Forms.Label();
            this.lblDiesel500 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbSales = new System.Windows.Forms.GroupBox();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.btnUpdateFuelPrice = new System.Windows.Forms.Button();
            this.btnHelpAndSupport = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.lblCurrentFuelPrices = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tpAccounts = new System.Windows.Forms.TabPage();
            this.tpEmpolyees = new System.Windows.Forms.TabPage();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.gbAccounts = new System.Windows.Forms.GroupBox();
            this.btnManageAccounts = new System.Windows.Forms.Button();
            this.btnViewAccountDB = new System.Windows.Forms.Button();
            this.btnViewOutstandingAcc = new System.Windows.Forms.Button();
            this.btnWorkHouers = new System.Windows.Forms.Button();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnReceiveOrder = new System.Windows.Forms.Button();
            this.gbFuelType.SuspendLayout();
            this.gbSales.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpAccounts.SuspendLayout();
            this.tpEmpolyees.SuspendLayout();
            this.tpOrders.SuspendLayout();
            this.gbAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFuelType
            // 
            this.gbFuelType.Controls.Add(this.lblDiesel500);
            this.gbFuelType.Controls.Add(this.lblDiesel50);
            this.gbFuelType.Controls.Add(this.lblUnleaded95);
            this.gbFuelType.Controls.Add(this.lblUnleaded93);
            this.gbFuelType.Location = new System.Drawing.Point(556, 29);
            this.gbFuelType.Name = "gbFuelType";
            this.gbFuelType.Size = new System.Drawing.Size(103, 141);
            this.gbFuelType.TabIndex = 0;
            this.gbFuelType.TabStop = false;
            this.gbFuelType.Text = "FUEL TYPE";
            this.gbFuelType.Enter += new System.EventHandler(this.GbFuelType_Enter);
            // 
            // gbPrice
            // 
            this.gbPrice.Location = new System.Drawing.Point(665, 29);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(103, 141);
            this.gbPrice.TabIndex = 1;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "PRICE";
            // 
            // lblUnleaded93
            // 
            this.lblUnleaded93.AutoSize = true;
            this.lblUnleaded93.Location = new System.Drawing.Point(6, 26);
            this.lblUnleaded93.Name = "lblUnleaded93";
            this.lblUnleaded93.Size = new System.Drawing.Size(84, 13);
            this.lblUnleaded93.TabIndex = 0;
            this.lblUnleaded93.Text = "UNLEADED 93:";
            // 
            // lblUnleaded95
            // 
            this.lblUnleaded95.AutoSize = true;
            this.lblUnleaded95.Location = new System.Drawing.Point(6, 54);
            this.lblUnleaded95.Name = "lblUnleaded95";
            this.lblUnleaded95.Size = new System.Drawing.Size(84, 13);
            this.lblUnleaded95.TabIndex = 1;
            this.lblUnleaded95.Text = "UNLEADED 95:";
            // 
            // lblDiesel50
            // 
            this.lblDiesel50.AutoSize = true;
            this.lblDiesel50.Location = new System.Drawing.Point(6, 83);
            this.lblDiesel50.Name = "lblDiesel50";
            this.lblDiesel50.Size = new System.Drawing.Size(63, 13);
            this.lblDiesel50.TabIndex = 2;
            this.lblDiesel50.Text = "DIESEL 50:";
            // 
            // lblDiesel500
            // 
            this.lblDiesel500.AutoSize = true;
            this.lblDiesel500.Location = new System.Drawing.Point(6, 110);
            this.lblDiesel500.Name = "lblDiesel500";
            this.lblDiesel500.Size = new System.Drawing.Size(69, 13);
            this.lblDiesel500.TabIndex = 3;
            this.lblDiesel500.Text = "DIESEL 500:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(700, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // gbSales
            // 
            this.gbSales.Controls.Add(this.btnUpdateFuelPrice);
            this.gbSales.Controls.Add(this.btnNewSale);
            this.gbSales.Location = new System.Drawing.Point(556, 185);
            this.gbSales.Name = "gbSales";
            this.gbSales.Size = new System.Drawing.Size(212, 154);
            this.gbSales.TabIndex = 3;
            this.gbSales.TabStop = false;
            this.gbSales.Text = "SALES";
            // 
            // btnNewSale
            // 
            this.btnNewSale.Location = new System.Drawing.Point(6, 93);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(101, 40);
            this.btnNewSale.TabIndex = 0;
            this.btnNewSale.Text = "NEW SALE";
            this.btnNewSale.UseVisualStyleBackColor = true;
            // 
            // btnUpdateFuelPrice
            // 
            this.btnUpdateFuelPrice.Location = new System.Drawing.Point(6, 36);
            this.btnUpdateFuelPrice.Name = "btnUpdateFuelPrice";
            this.btnUpdateFuelPrice.Size = new System.Drawing.Size(103, 40);
            this.btnUpdateFuelPrice.TabIndex = 1;
            this.btnUpdateFuelPrice.Text = "UPDATE FUEL PRICE";
            this.btnUpdateFuelPrice.UseVisualStyleBackColor = true;
            // 
            // btnHelpAndSupport
            // 
            this.btnHelpAndSupport.Location = new System.Drawing.Point(556, 406);
            this.btnHelpAndSupport.Name = "btnHelpAndSupport";
            this.btnHelpAndSupport.Size = new System.Drawing.Size(136, 32);
            this.btnHelpAndSupport.TabIndex = 4;
            this.btnHelpAndSupport.Text = "HELP AND SUPPORT";
            this.btnHelpAndSupport.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(700, 355);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(88, 32);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // lblCurrentFuelPrices
            // 
            this.lblCurrentFuelPrices.AutoSize = true;
            this.lblCurrentFuelPrices.Location = new System.Drawing.Point(593, 9);
            this.lblCurrentFuelPrices.Name = "lblCurrentFuelPrices";
            this.lblCurrentFuelPrices.Size = new System.Drawing.Size(124, 13);
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
            this.tabControl.Location = new System.Drawing.Point(12, 9);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(431, 330);
            this.tabControl.TabIndex = 7;
            // 
            // tpHome
            // 
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(423, 304);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "HOME";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // tpAccounts
            // 
            this.tpAccounts.Controls.Add(this.gbAccounts);
            this.tpAccounts.Location = new System.Drawing.Point(4, 22);
            this.tpAccounts.Name = "tpAccounts";
            this.tpAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccounts.Size = new System.Drawing.Size(423, 304);
            this.tpAccounts.TabIndex = 1;
            this.tpAccounts.Text = "ACCOUNTS";
            this.tpAccounts.UseVisualStyleBackColor = true;
            // 
            // tpEmpolyees
            // 
            this.tpEmpolyees.Controls.Add(this.btnManageEmployees);
            this.tpEmpolyees.Controls.Add(this.btnWorkHouers);
            this.tpEmpolyees.Location = new System.Drawing.Point(4, 22);
            this.tpEmpolyees.Name = "tpEmpolyees";
            this.tpEmpolyees.Size = new System.Drawing.Size(423, 304);
            this.tpEmpolyees.TabIndex = 2;
            this.tpEmpolyees.Text = "EMPLOYEES";
            this.tpEmpolyees.UseVisualStyleBackColor = true;
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.btnReceiveOrder);
            this.tpOrders.Controls.Add(this.btnPlaceOrder);
            this.tpOrders.Location = new System.Drawing.Point(4, 22);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Size = new System.Drawing.Size(423, 304);
            this.tpOrders.TabIndex = 3;
            this.tpOrders.Text = "OREDERS";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // gbAccounts
            // 
            this.gbAccounts.Controls.Add(this.btnViewOutstandingAcc);
            this.gbAccounts.Controls.Add(this.btnViewAccountDB);
            this.gbAccounts.Controls.Add(this.btnManageAccounts);
            this.gbAccounts.Location = new System.Drawing.Point(16, 21);
            this.gbAccounts.Name = "gbAccounts";
            this.gbAccounts.Size = new System.Drawing.Size(364, 244);
            this.gbAccounts.TabIndex = 0;
            this.gbAccounts.TabStop = false;
            this.gbAccounts.Text = "ACCOUNTS";
            // 
            // btnManageAccounts
            // 
            this.btnManageAccounts.Location = new System.Drawing.Point(40, 35);
            this.btnManageAccounts.Name = "btnManageAccounts";
            this.btnManageAccounts.Size = new System.Drawing.Size(135, 38);
            this.btnManageAccounts.TabIndex = 0;
            this.btnManageAccounts.Text = "Manage Accounts";
            this.btnManageAccounts.UseVisualStyleBackColor = true;
            // 
            // btnViewAccountDB
            // 
            this.btnViewAccountDB.Location = new System.Drawing.Point(40, 185);
            this.btnViewAccountDB.Name = "btnViewAccountDB";
            this.btnViewAccountDB.Size = new System.Drawing.Size(135, 38);
            this.btnViewAccountDB.TabIndex = 1;
            this.btnViewAccountDB.Text = "View Outstanding Accounts";
            this.btnViewAccountDB.UseVisualStyleBackColor = true;
            // 
            // btnViewOutstandingAcc
            // 
            this.btnViewOutstandingAcc.Location = new System.Drawing.Point(40, 107);
            this.btnViewOutstandingAcc.Name = "btnViewOutstandingAcc";
            this.btnViewOutstandingAcc.Size = new System.Drawing.Size(135, 38);
            this.btnViewOutstandingAcc.TabIndex = 2;
            this.btnViewOutstandingAcc.Text = "View Account Database";
            this.btnViewOutstandingAcc.UseVisualStyleBackColor = true;
            // 
            // btnWorkHouers
            // 
            this.btnWorkHouers.Location = new System.Drawing.Point(24, 99);
            this.btnWorkHouers.Name = "btnWorkHouers";
            this.btnWorkHouers.Size = new System.Drawing.Size(103, 40);
            this.btnWorkHouers.TabIndex = 0;
            this.btnWorkHouers.Text = "MANAGE WORK HOUERS";
            this.btnWorkHouers.UseVisualStyleBackColor = true;
            // 
            // btnManageEmployees
            // 
            this.btnManageEmployees.Location = new System.Drawing.Point(24, 25);
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.Size = new System.Drawing.Size(103, 40);
            this.btnManageEmployees.TabIndex = 2;
            this.btnManageEmployees.Text = "MANAGE EMPLOYEES";
            this.btnManageEmployees.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(15, 24);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(118, 32);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "PLACE ORDER";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // btnReceiveOrder
            // 
            this.btnReceiveOrder.Location = new System.Drawing.Point(15, 81);
            this.btnReceiveOrder.Name = "btnReceiveOrder";
            this.btnReceiveOrder.Size = new System.Drawing.Size(118, 32);
            this.btnReceiveOrder.TabIndex = 1;
            this.btnReceiveOrder.Text = "RECIEVE ORDER";
            this.btnReceiveOrder.UseVisualStyleBackColor = true;
            // 
            // Form_Home_Page_FutureTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblCurrentFuelPrices);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnHelpAndSupport);
            this.Controls.Add(this.gbSales);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbPrice);
            this.Controls.Add(this.gbFuelType);
            this.Name = "Form_Home_Page_FutureTech";
            this.Text = "Form_Home_Page_FutureTech";
            this.Load += new System.EventHandler(this.Form_Home_Page_FutureTech_Load);
            this.gbFuelType.ResumeLayout(false);
            this.gbFuelType.PerformLayout();
            this.gbSales.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tpAccounts.ResumeLayout(false);
            this.tpEmpolyees.ResumeLayout(false);
            this.tpOrders.ResumeLayout(false);
            this.gbAccounts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox gbAccounts;
        private System.Windows.Forms.Button btnViewOutstandingAcc;
        private System.Windows.Forms.Button btnViewAccountDB;
        private System.Windows.Forms.Button btnManageAccounts;
        private System.Windows.Forms.Button btnManageEmployees;
        private System.Windows.Forms.Button btnWorkHouers;
        private System.Windows.Forms.Button btnReceiveOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}