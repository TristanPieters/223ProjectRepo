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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuelSalesForm));
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
            this.comBoxEmpNum = new System.Windows.Forms.ComboBox();
            this.btnCalcTotalFuelPrice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBoxAccount.SuspendLayout();
            this.gbSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fuel type:";
            // 
            // comBoxFuelType
            // 
            this.comBoxFuelType.FormattingEnabled = true;
            this.comBoxFuelType.Location = new System.Drawing.Point(72, 74);
            this.comBoxFuelType.Name = "comBoxFuelType";
            this.comBoxFuelType.Size = new System.Drawing.Size(100, 21);
            this.comBoxFuelType.TabIndex = 5;
            this.comBoxFuelType.SelectedIndexChanged += new System.EventHandler(this.comBoxFuelType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price per liter (R):";
            // 
            // lblFuelPrice
            // 
            this.lblFuelPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFuelPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelPrice.Location = new System.Drawing.Point(122, 117);
            this.lblFuelPrice.Name = "lblFuelPrice";
            this.lblFuelPrice.Size = new System.Drawing.Size(79, 15);
            this.lblFuelPrice.TabIndex = 7;
            this.lblFuelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount liters:";
            // 
            // tBoxFuelAmountLiters
            // 
            this.tBoxFuelAmountLiters.Location = new System.Drawing.Point(98, 150);
            this.tBoxFuelAmountLiters.Name = "tBoxFuelAmountLiters";
            this.tBoxFuelAmountLiters.Size = new System.Drawing.Size(100, 20);
            this.tBoxFuelAmountLiters.TabIndex = 9;
            this.tBoxFuelAmountLiters.TextChanged += new System.EventHandler(this.tBoxFuelAmountLiters_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total amount purchased (R):";
            // 
            // lblFuelPurchased
            // 
            this.lblFuelPurchased.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFuelPurchased.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelPurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelPurchased.Location = new System.Drawing.Point(183, 216);
            this.lblFuelPurchased.Name = "lblFuelPurchased";
            this.lblFuelPurchased.Size = new System.Drawing.Size(79, 15);
            this.lblFuelPurchased.TabIndex = 11;
            // 
            // gBoxAccount
            // 
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
            this.gBoxAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gBoxAccount.Location = new System.Drawing.Point(272, 26);
            this.gBoxAccount.Name = "gBoxAccount";
            this.gBoxAccount.Size = new System.Drawing.Size(277, 277);
            this.gBoxAccount.TabIndex = 13;
            this.gBoxAccount.TabStop = false;
            this.gBoxAccount.Text = "Accounts:";
            // 
            // btnAccSearch
            // 
            this.btnAccSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAccSearch.Location = new System.Drawing.Point(192, 15);
            this.btnAccSearch.Name = "btnAccSearch";
            this.btnAccSearch.Size = new System.Drawing.Size(75, 28);
            this.btnAccSearch.TabIndex = 12;
            this.btnAccSearch.Text = "SEARCH";
            this.btnAccSearch.UseVisualStyleBackColor = true;
            this.btnAccSearch.Click += new System.EventHandler(this.btnAccSearch_Click);
            // 
            // btnCreateNewAcc
            // 
            this.btnCreateNewAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateNewAcc.Location = new System.Drawing.Point(39, 217);
            this.btnCreateNewAcc.Name = "btnCreateNewAcc";
            this.btnCreateNewAcc.Size = new System.Drawing.Size(147, 44);
            this.btnCreateNewAcc.TabIndex = 11;
            this.btnCreateNewAcc.Text = "CREATE NEW ACCOUNT";
            this.btnCreateNewAcc.UseVisualStyleBackColor = true;
            this.btnCreateNewAcc.Click += new System.EventHandler(this.btnCreateNewAcc_Click);
            // 
            // lblAccNewCredit
            // 
            this.lblAccNewCredit.AutoSize = true;
            this.lblAccNewCredit.Location = new System.Drawing.Point(132, 192);
            this.lblAccNewCredit.Name = "lblAccNewCredit";
            this.lblAccNewCredit.Size = new System.Drawing.Size(73, 13);
            this.lblAccNewCredit.TabIndex = 10;
            this.lblAccNewCredit.Text = "[NewCredit]";
            // 
            // btnAccUpdateCredit
            // 
            this.btnAccUpdateCredit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAccUpdateCredit.Location = new System.Drawing.Point(116, 154);
            this.btnAccUpdateCredit.Name = "btnAccUpdateCredit";
            this.btnAccUpdateCredit.Size = new System.Drawing.Size(75, 28);
            this.btnAccUpdateCredit.TabIndex = 9;
            this.btnAccUpdateCredit.Text = "UPDATE";
            this.btnAccUpdateCredit.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "New Credit Amount:";
            // 
            // tBoxAccCreditAmount
            // 
            this.tBoxAccCreditAmount.Location = new System.Drawing.Point(10, 159);
            this.tBoxAccCreditAmount.Name = "tBoxAccCreditAmount";
            this.tBoxAccCreditAmount.Size = new System.Drawing.Size(100, 20);
            this.tBoxAccCreditAmount.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Amount to be credited:";
            // 
            // lblAccCreditOutstand
            // 
            this.lblAccCreditOutstand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccCreditOutstand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccCreditOutstand.Location = new System.Drawing.Point(10, 115);
            this.lblAccCreditOutstand.Name = "lblAccCreditOutstand";
            this.lblAccCreditOutstand.Size = new System.Drawing.Size(79, 15);
            this.lblAccCreditOutstand.TabIndex = 5;
            this.lblAccCreditOutstand.Text = "[OutstandCredit]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Outstanding credit amount (R):";
            // 
            // lblAccHolderName
            // 
            this.lblAccHolderName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccHolderName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccHolderName.Location = new System.Drawing.Point(10, 74);
            this.lblAccHolderName.Name = "lblAccHolderName";
            this.lblAccHolderName.Size = new System.Drawing.Size(120, 15);
            this.lblAccHolderName.TabIndex = 3;
            this.lblAccHolderName.Text = "[AccHoldName]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Account Holder Name:";
            // 
            // tboxAccNum
            // 
            this.tboxAccNum.Location = new System.Drawing.Point(86, 20);
            this.tboxAccNum.Name = "tboxAccNum";
            this.tboxAccNum.Size = new System.Drawing.Size(100, 20);
            this.tboxAccNum.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Account Nr.:";
            // 
            // btnCompSale
            // 
            this.btnCompSale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCompSale.Location = new System.Drawing.Point(66, 254);
            this.btnCompSale.Name = "btnCompSale";
            this.btnCompSale.Size = new System.Drawing.Size(141, 49);
            this.btnCompSale.TabIndex = 14;
            this.btnCompSale.Text = "COMPLETE SALE";
            this.btnCompSale.UseVisualStyleBackColor = true;
            this.btnCompSale.Click += new System.EventHandler(this.btnCompSale_Click);
            // 
            // btnReturnHome
            // 
            this.btnReturnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReturnHome.Location = new System.Drawing.Point(392, 309);
            this.btnReturnHome.Name = "btnReturnHome";
            this.btnReturnHome.Size = new System.Drawing.Size(112, 43);
            this.btnReturnHome.TabIndex = 15;
            this.btnReturnHome.Text = "RETURN HOME";
            this.btnReturnHome.UseVisualStyleBackColor = true;
            this.btnReturnHome.Click += new System.EventHandler(this.btnReturnHome_Click);
            // 
            // gbSales
            // 
            this.gbSales.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbSales.Controls.Add(this.comBoxEmpNum);
            this.gbSales.Controls.Add(this.btnCalcTotalFuelPrice);
            this.gbSales.Controls.Add(this.pictureBox1);
            this.gbSales.Controls.Add(this.label2);
            this.gbSales.Controls.Add(this.btnReturnHome);
            this.gbSales.Controls.Add(this.gBoxAccount);
            this.gbSales.Controls.Add(this.btnCompSale);
            this.gbSales.Controls.Add(this.label3);
            this.gbSales.Controls.Add(this.comBoxFuelType);
            this.gbSales.Controls.Add(this.lblFuelPurchased);
            this.gbSales.Controls.Add(this.label4);
            this.gbSales.Controls.Add(this.label6);
            this.gbSales.Controls.Add(this.lblFuelPrice);
            this.gbSales.Controls.Add(this.tBoxFuelAmountLiters);
            this.gbSales.Controls.Add(this.label5);
            this.gbSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSales.Location = new System.Drawing.Point(12, 12);
            this.gbSales.Name = "gbSales";
            this.gbSales.Size = new System.Drawing.Size(662, 372);
            this.gbSales.TabIndex = 16;
            this.gbSales.TabStop = false;
            this.gbSales.Text = "SALES";
            // 
            // comBoxEmpNum
            // 
            this.comBoxEmpNum.FormattingEnabled = true;
            this.comBoxEmpNum.Location = new System.Drawing.Point(72, 29);
            this.comBoxEmpNum.Name = "comBoxEmpNum";
            this.comBoxEmpNum.Size = new System.Drawing.Size(100, 21);
            this.comBoxEmpNum.TabIndex = 18;
            // 
            // btnCalcTotalFuelPrice
            // 
            this.btnCalcTotalFuelPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcTotalFuelPrice.Location = new System.Drawing.Point(98, 176);
            this.btnCalcTotalFuelPrice.Name = "btnCalcTotalFuelPrice";
            this.btnCalcTotalFuelPrice.Size = new System.Drawing.Size(88, 28);
            this.btnCalcTotalFuelPrice.TabIndex = 13;
            this.btnCalcTotalFuelPrice.Text = "CALCULATE";
            this.btnCalcTotalFuelPrice.UseVisualStyleBackColor = true;
            this.btnCalcTotalFuelPrice.Click += new System.EventHandler(this.btnCalcTotalFuelPrice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FuelSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(700, 424);
            this.Controls.Add(this.gbSales);
            this.Name = "FuelSalesForm";
            this.Text = "FuelSalesForm";
            this.Load += new System.EventHandler(this.FuelSalesForm_Load);
            this.gBoxAccount.ResumeLayout(false);
            this.gBoxAccount.PerformLayout();
            this.gbSales.ResumeLayout(false);
            this.gbSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAccSearch;
        private System.Windows.Forms.Button btnCalcTotalFuelPrice;
        private System.Windows.Forms.ComboBox comBoxEmpNum;
    }
}