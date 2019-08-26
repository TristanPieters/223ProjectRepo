namespace CMPG213_Prototype
{
    partial class Form_FuelPrices
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
            this.comBoxFuelType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxCurrPrice = new System.Windows.Forms.TextBox();
            this.tBoxNewPrice = new System.Windows.Forms.TextBox();
            this.chkBoxConfChange = new System.Windows.Forms.CheckBox();
            this.btnUpdPrice = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFuelConf = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFuelPriceConf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comBoxFuelType
            // 
            this.comBoxFuelType.FormattingEnabled = true;
            this.comBoxFuelType.Items.AddRange(new object[] {
            "Unleaded 93",
            "Unleaded 95",
            "Diesel 50ppm",
            "Diesel 500ppm"});
            this.comBoxFuelType.Location = new System.Drawing.Point(185, 100);
            this.comBoxFuelType.Name = "comBoxFuelType";
            this.comBoxFuelType.Size = new System.Drawing.Size(121, 21);
            this.comBoxFuelType.TabIndex = 0;
            this.comBoxFuelType.SelectedIndexChanged += new System.EventHandler(this.comBoxFuelType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select fuel type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Update fuel price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter new price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current price:";
            // 
            // tBoxCurrPrice
            // 
            this.tBoxCurrPrice.Location = new System.Drawing.Point(185, 137);
            this.tBoxCurrPrice.Name = "tBoxCurrPrice";
            this.tBoxCurrPrice.Size = new System.Drawing.Size(121, 20);
            this.tBoxCurrPrice.TabIndex = 5;
            // 
            // tBoxNewPrice
            // 
            this.tBoxNewPrice.Location = new System.Drawing.Point(185, 173);
            this.tBoxNewPrice.Name = "tBoxNewPrice";
            this.tBoxNewPrice.Size = new System.Drawing.Size(121, 20);
            this.tBoxNewPrice.TabIndex = 6;
            // 
            // chkBoxConfChange
            // 
            this.chkBoxConfChange.AutoSize = true;
            this.chkBoxConfChange.Location = new System.Drawing.Point(282, 240);
            this.chkBoxConfChange.Name = "chkBoxConfChange";
            this.chkBoxConfChange.Size = new System.Drawing.Size(15, 14);
            this.chkBoxConfChange.TabIndex = 8;
            this.chkBoxConfChange.UseVisualStyleBackColor = true;
            // 
            // btnUpdPrice
            // 
            this.btnUpdPrice.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdPrice.Location = new System.Drawing.Point(82, 290);
            this.btnUpdPrice.Name = "btnUpdPrice";
            this.btnUpdPrice.Size = new System.Drawing.Size(102, 41);
            this.btnUpdPrice.TabIndex = 9;
            this.btnUpdPrice.Text = "Update";
            this.btnUpdPrice.UseVisualStyleBackColor = true;
            this.btnUpdPrice.Click += new System.EventHandler(this.btnUpdPrice_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(204, 290);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 41);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Return to home page";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirm that:";
            // 
            // lblFuelConf
            // 
            this.lblFuelConf.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelConf.Location = new System.Drawing.Point(175, 217);
            this.lblFuelConf.Name = "lblFuelConf";
            this.lblFuelConf.Size = new System.Drawing.Size(90, 18);
            this.lblFuelConf.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price change:";
            // 
            // lblFuelPriceConf
            // 
            this.lblFuelPriceConf.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelPriceConf.Location = new System.Drawing.Point(175, 240);
            this.lblFuelPriceConf.Name = "lblFuelPriceConf";
            this.lblFuelPriceConf.Size = new System.Drawing.Size(90, 18);
            this.lblFuelPriceConf.TabIndex = 14;
            // 
            // Form_FuelPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 378);
            this.Controls.Add(this.lblFuelPriceConf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFuelConf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdPrice);
            this.Controls.Add(this.chkBoxConfChange);
            this.Controls.Add(this.tBoxNewPrice);
            this.Controls.Add(this.tBoxCurrPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBoxFuelType);
            this.Name = "Form_FuelPrices";
            this.Text = "Form_FuelPrices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoxFuelType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxCurrPrice;
        private System.Windows.Forms.TextBox tBoxNewPrice;
        private System.Windows.Forms.CheckBox chkBoxConfChange;
        private System.Windows.Forms.Button btnUpdPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFuelConf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFuelPriceConf;
    }
}