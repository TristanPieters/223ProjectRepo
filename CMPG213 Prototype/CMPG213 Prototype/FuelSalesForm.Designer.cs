namespace CMPG213_Prototype
{
    partial class FuelSalesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxFuelType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFuelPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxFuelAmountLiters = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFuelPurchased = new System.Windows.Forms.Label();
            this.gBoxAccount = new System.Windows.Forms.GroupBox();
            this.lblRewardDetail = new System.Windows.Forms.Label();
            this.comBoxRewardSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccSearch = new System.Windows.Forms.Button();
            this.btnCreateNewAcc = new System.Windows.Forms.Button();
            this.lblAccNewCredit = new System.Windows.Forms.Label();
            this.btnAccUpdateCredit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tBoxAccCreditAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAccCreditOutstand = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAccHolderName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxAccNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCompSale = new System.Windows.Forms.Button();
            this.btnReturnHome = new System.Windows.Forms.Button();
            this.gbSales = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcTotalFuelPrice = new System.Windows.Forms.Button();
            this.toolTipRewardComBox = new System.Windows.Forms.ToolTip(this.components);
            this.tBoxEmpNum = new System.Windows.Forms.TextBox();
            this.gBoxAccount.SuspendLayout();
            this.gbSales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fuel type:";
            // 
            // comBoxFuelType
            // 
            this.comBoxFuelType.FormattingEnabled = true;
            this.comBoxFuelType.Location = new System.Drawing.Point(187, 91);
            this.comBoxFuelType.Name = "comBoxFuelType";
            this.comBoxFuelType.Size = new System.Drawing.Size(100, 28);
            this.comBoxFuelType.TabIndex = 5;
            this.comBoxFuelType.SelectedIndexChanged += new System.EventHandler(this.comBoxFuelType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price per liter (R):";
            // 
            // lblFuelPrice
            // 
            this.lblFuelPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFuelPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelPrice.Location = new System.Drawing.Point(187, 153);
            this.lblFuelPrice.Name = "lblFuelPrice";
            this.lblFuelPrice.Size = new System.Drawing.Size(79, 18);
            this.lblFuelPrice.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount liters:";
            // 
            // tBoxFuelAmountLiters
            // 
            this.tBoxFuelAmountLiters.Location = new System.Drawing.Point(187, 213);
            this.tBoxFuelAmountLiters.Name = "tBoxFuelAmountLiters";
            this.tBoxFuelAmountLiters.Size = new System.Drawing.Size(100, 26);
            this.tBoxFuelAmountLiters.TabIndex = 9;
            this.tBoxFuelAmountLiters.TextChanged += new System.EventHandler(this.tBoxFuelAmountLiters_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total amount purchased (R):";
            // 
            // lblFuelPurchased
            // 
            this.lblFuelPurchased.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFuelPurchased.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelPurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelPurchased.Location = new System.Drawing.Point(261, 322);
            this.lblFuelPurchased.Name = "lblFuelPurchased";
            this.lblFuelPurchased.Size = new System.Drawing.Size(79, 18);
            this.lblFuelPurchased.TabIndex = 11;
            // 
            // gBoxAccount
            // 
            this.gBoxAccount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gBoxAccount.Controls.Add(this.lblRewardDetail);
            this.gBoxAccount.Controls.Add(this.comBoxRewardSelect);
            this.gBoxAccount.Controls.Add(this.label1);
            this.gBoxAccount.Controls.Add(this.btnAccSearch);
            this.gBoxAccount.Controls.Add(this.btnCreateNewAcc);
            this.gBoxAccount.Controls.Add(this.lblAccNewCredit);
            this.gBoxAccount.Controls.Add(this.btnAccUpdateCredit);
            this.gBoxAccount.Controls.Add(this.label11);
            this.gBoxAccount.Controls.Add(this.tBoxAccCreditAmount);
            this.gBoxAccount.Controls.Add(this.label10);
            this.gBoxAccount.Controls.Add(this.lblAccCreditOutstand);
            this.gBoxAccount.Controls.Add(this.label9);
            this.gBoxAccount.Controls.Add(this.lblAccHolderName);
            this.gBoxAccount.Controls.Add(this.label8);
            this.gBoxAccount.Controls.Add(this.tboxAccNum);
            this.gBoxAccount.Controls.Add(this.label7);
            this.gBoxAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gBoxAccount.Location = new System.Drawing.Point(477, 28);
            this.gBoxAccount.Name = "gBoxAccount";
            this.gBoxAccount.Size = new System.Drawing.Size(408, 426);
            this.gBoxAccount.TabIndex = 13;
            this.gBoxAccount.TabStop = false;
            this.gBoxAccount.Text = "ACCOUNT SALES: ";
            // 
            // lblRewardDetail
            // 
            this.lblRewardDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRewardDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRewardDetail.Location = new System.Drawing.Point(280, 326);
            this.lblRewardDetail.Name = "lblRewardDetail";
            this.lblRewardDetail.Size = new System.Drawing.Size(71, 18);
            this.lblRewardDetail.TabIndex = 15;
            // 
            // comBoxRewardSelect
            // 
            this.comBoxRewardSelect.FormattingEnabled = true;
            this.comBoxRewardSelect.Location = new System.Drawing.Point(280, 295);
            this.comBoxRewardSelect.Name = "comBoxRewardSelect";
            this.comBoxRewardSelect.Size = new System.Drawing.Size(116, 28);
            this.comBoxRewardSelect.TabIndex = 14;
            this.comBoxRewardSelect.SelectedIndexChanged += new System.EventHandler(this.comBoxRewardSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reward (No cash):";
            // 
            // btnAccSearch
            // 
            this.btnAccSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAccSearch.Location = new System.Drawing.Point(280, 63);
            this.btnAccSearch.Name = "btnAccSearch";
            this.btnAccSearch.Size = new System.Drawing.Size(100, 28);
            this.btnAccSearch.TabIndex = 12;
            this.btnAccSearch.Text = "SEARCH";
            this.btnAccSearch.UseVisualStyleBackColor = true;
            this.btnAccSearch.Click += new System.EventHandler(this.btnAccSearch_Click);
            // 
            // btnCreateNewAcc
            // 
            this.btnCreateNewAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateNewAcc.Location = new System.Drawing.Point(173, 376);
            this.btnCreateNewAcc.Name = "btnCreateNewAcc";
            this.btnCreateNewAcc.Size = new System.Drawing.Size(223, 44);
            this.btnCreateNewAcc.TabIndex = 11;
            this.btnCreateNewAcc.Text = "CREATE NEW ACCOUNT";
            this.btnCreateNewAcc.UseVisualStyleBackColor = true;
            this.btnCreateNewAcc.Click += new System.EventHandler(this.btnCreateNewAcc_Click);
            // 
            // lblAccNewCredit
            // 
            this.lblAccNewCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccNewCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNewCredit.Location = new System.Drawing.Point(280, 260);
            this.lblAccNewCredit.Name = "lblAccNewCredit";
            this.lblAccNewCredit.Size = new System.Drawing.Size(79, 18);
            this.lblAccNewCredit.TabIndex = 10;
            // 
            // btnAccUpdateCredit
            // 
            this.btnAccUpdateCredit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAccUpdateCredit.Location = new System.Drawing.Point(280, 208);
            this.btnAccUpdateCredit.Name = "btnAccUpdateCredit";
            this.btnAccUpdateCredit.Size = new System.Drawing.Size(107, 28);
            this.btnAccUpdateCredit.TabIndex = 9;
            this.btnAccUpdateCredit.Text = "UPDATE";
            this.btnAccUpdateCredit.UseVisualStyleBackColor = true;
            this.btnAccUpdateCredit.Click += new System.EventHandler(this.btnAccUpdateCredit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "New Credit Amount (R):";
            // 
            // tBoxAccCreditAmount
            // 
            this.tBoxAccCreditAmount.Location = new System.Drawing.Point(280, 176);
            this.tBoxAccCreditAmount.Name = "tBoxAccCreditAmount";
            this.tBoxAccCreditAmount.Size = new System.Drawing.Size(100, 26);
            this.tBoxAccCreditAmount.TabIndex = 7;
            this.tBoxAccCreditAmount.Click += new System.EventHandler(this.tBoxAccCreditAmount_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Amount to be credited:";
            // 
            // lblAccCreditOutstand
            // 
            this.lblAccCreditOutstand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccCreditOutstand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccCreditOutstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccCreditOutstand.Location = new System.Drawing.Point(280, 135);
            this.lblAccCreditOutstand.Name = "lblAccCreditOutstand";
            this.lblAccCreditOutstand.Size = new System.Drawing.Size(79, 18);
            this.lblAccCreditOutstand.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Outstanding credit amount (R):";
            // 
            // lblAccHolderName
            // 
            this.lblAccHolderName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccHolderName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccHolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccHolderName.Location = new System.Drawing.Point(11, 99);
            this.lblAccHolderName.Name = "lblAccHolderName";
            this.lblAccHolderName.Size = new System.Drawing.Size(120, 18);
            this.lblAccHolderName.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Account Holder Name:";
            // 
            // tboxAccNum
            // 
            this.tboxAccNum.Location = new System.Drawing.Point(280, 28);
            this.tboxAccNum.Name = "tboxAccNum";
            this.tboxAccNum.Size = new System.Drawing.Size(100, 26);
            this.tboxAccNum.TabIndex = 1;
            this.tboxAccNum.TextChanged += new System.EventHandler(this.tboxAccNum_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Account Nr.:";
            // 
            // btnCompSale
            // 
            this.btnCompSale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCompSale.Location = new System.Drawing.Point(16, 371);
            this.btnCompSale.Name = "btnCompSale";
            this.btnCompSale.Size = new System.Drawing.Size(155, 49);
            this.btnCompSale.TabIndex = 14;
            this.btnCompSale.Text = "COMPLETE SALE";
            this.btnCompSale.UseVisualStyleBackColor = true;
            this.btnCompSale.Click += new System.EventHandler(this.btnCompSale_Click);
            // 
            // btnReturnHome
            // 
            this.btnReturnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReturnHome.Location = new System.Drawing.Point(724, 457);
            this.btnReturnHome.Name = "btnReturnHome";
            this.btnReturnHome.Size = new System.Drawing.Size(161, 43);
            this.btnReturnHome.TabIndex = 15;
            this.btnReturnHome.Text = "RETURN HOME";
            this.btnReturnHome.UseVisualStyleBackColor = true;
            this.btnReturnHome.Click += new System.EventHandler(this.btnReturnHome_Click);
            // 
            // gbSales
            // 
            this.gbSales.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbSales.Controls.Add(this.groupBox1);
            this.gbSales.Controls.Add(this.btnReturnHome);
            this.gbSales.Controls.Add(this.gBoxAccount);
            this.gbSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSales.Location = new System.Drawing.Point(12, 12);
            this.gbSales.Name = "gbSales";
            this.gbSales.Size = new System.Drawing.Size(911, 506);
            this.gbSales.TabIndex = 16;
            this.gbSales.TabStop = false;
            this.gbSales.Text = "SALES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBoxEmpNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCalcTotalFuelPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tBoxFuelAmountLiters);
            this.groupBox1.Controls.Add(this.lblFuelPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCompSale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblFuelPurchased);
            this.groupBox1.Controls.Add(this.comBoxFuelType);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(30, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 426);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CASH SALES:";
            // 
            // btnCalcTotalFuelPrice
            // 
            this.btnCalcTotalFuelPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcTotalFuelPrice.Location = new System.Drawing.Point(187, 254);
            this.btnCalcTotalFuelPrice.Name = "btnCalcTotalFuelPrice";
            this.btnCalcTotalFuelPrice.Size = new System.Drawing.Size(123, 28);
            this.btnCalcTotalFuelPrice.TabIndex = 13;
            this.btnCalcTotalFuelPrice.Text = "CALCULATE";
            this.btnCalcTotalFuelPrice.UseVisualStyleBackColor = true;
            this.btnCalcTotalFuelPrice.Click += new System.EventHandler(this.btnCalcTotalFuelPrice_Click);
            // 
            // tBoxEmpNum
            // 
            this.tBoxEmpNum.Location = new System.Drawing.Point(187, 31);
            this.tBoxEmpNum.Name = "tBoxEmpNum";
            this.tBoxEmpNum.Size = new System.Drawing.Size(100, 26);
            this.tBoxEmpNum.TabIndex = 15;
            // 
            // FuelSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(967, 530);
            this.Controls.Add(this.gbSales);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FuelSalesForm";
            this.Text = "FuelSalesForm";
            this.Load += new System.EventHandler(this.FuelSalesForm_Load);
            this.gBoxAccount.ResumeLayout(false);
            this.gBoxAccount.PerformLayout();
            this.gbSales.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoxFuelType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFuelPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxFuelAmountLiters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFuelPurchased;
        private System.Windows.Forms.GroupBox gBoxAccount;
        private System.Windows.Forms.Button btnCreateNewAcc;
        private System.Windows.Forms.Label lblAccNewCredit;
        private System.Windows.Forms.Button btnAccUpdateCredit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBoxAccCreditAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAccCreditOutstand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAccHolderName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxAccNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCompSale;
        private System.Windows.Forms.Button btnReturnHome;
        private System.Windows.Forms.GroupBox gbSales;
        private System.Windows.Forms.Button btnAccSearch;
        private System.Windows.Forms.Button btnCalcTotalFuelPrice;
        private System.Windows.Forms.ComboBox comBoxRewardSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipRewardComBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRewardDetail;
        private System.Windows.Forms.TextBox tBoxEmpNum;
    }
}