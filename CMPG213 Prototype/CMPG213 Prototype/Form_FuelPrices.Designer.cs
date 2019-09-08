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
<<<<<<< Updated upstream
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FuelPrices));
            this.comBoxFuelType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxCurrPrice = new System.Windows.Forms.TextBox();
            this.tBoxNewPrice = new System.Windows.Forms.TextBox();
            this.btnUpdPrice = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFuelConf = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFuelPriceConf = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.comBoxFuelType.Location = new System.Drawing.Point(160, 48);
            this.comBoxFuelType.Name = "comBoxFuelType";
            this.comBoxFuelType.Size = new System.Drawing.Size(121, 21);
            this.comBoxFuelType.TabIndex = 0;
            this.comBoxFuelType.SelectedIndexChanged += new System.EventHandler(this.comBoxFuelType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select fuel type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter new price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current price:";
            // 
            // tBoxCurrPrice
            // 
            this.tBoxCurrPrice.Location = new System.Drawing.Point(160, 114);
            this.tBoxCurrPrice.Name = "tBoxCurrPrice";
            this.tBoxCurrPrice.Size = new System.Drawing.Size(121, 20);
            this.tBoxCurrPrice.TabIndex = 5;
            // 
            // tBoxNewPrice
            // 
            this.tBoxNewPrice.Location = new System.Drawing.Point(160, 173);
            this.tBoxNewPrice.Name = "tBoxNewPrice";
            this.tBoxNewPrice.Size = new System.Drawing.Size(121, 20);
            this.tBoxNewPrice.TabIndex = 6;
            // 
            // btnUpdPrice
            // 
            this.btnUpdPrice.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdPrice.Location = new System.Drawing.Point(13, 296);
            this.btnUpdPrice.Name = "btnUpdPrice";
            this.btnUpdPrice.Size = new System.Drawing.Size(102, 41);
            this.btnUpdPrice.TabIndex = 9;
            this.btnUpdPrice.Text = "Update";
            this.btnUpdPrice.UseVisualStyleBackColor = true;
            this.btnUpdPrice.Click += new System.EventHandler(this.btnUpdPrice_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(160, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 41);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Return to home page";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(6, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price change:";
            // 
            // lblFuelPriceConf
            // 
            this.lblFuelPriceConf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFuelPriceConf.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelPriceConf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFuelPriceConf.Location = new System.Drawing.Point(163, 238);
            this.lblFuelPriceConf.Name = "lblFuelPriceConf";
            this.lblFuelPriceConf.Size = new System.Drawing.Size(90, 18);
            this.lblFuelPriceConf.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comBoxFuelType);
            this.groupBox1.Controls.Add(this.tBoxCurrPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnUpdPrice);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblFuelPriceConf);
            this.groupBox1.Controls.Add(this.tBoxNewPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 354);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UPDATE FUEL PRICE";
            // 
            // Form_FuelPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(541, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFuelConf);
            this.Name = "Form_FuelPrices";
            this.Text = "Form_FuelPrices";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FuelPrices));
            this.comBoxFuelType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxCurrPrice = new System.Windows.Forms.TextBox();
            this.tBoxNewPrice = new System.Windows.Forms.TextBox();
            this.btnUpdPrice = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFuelConf = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFuelPriceConf = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.comBoxFuelType.Location = new System.Drawing.Point(160, 48);
            this.comBoxFuelType.Name = "comBoxFuelType";
            this.comBoxFuelType.Size = new System.Drawing.Size(121, 21);
            this.comBoxFuelType.TabIndex = 0;
            this.comBoxFuelType.SelectedIndexChanged += new System.EventHandler(this.comBoxFuelType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select fuel type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter new price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current price:";
            // 
            // tBoxCurrPrice
            // 
            this.tBoxCurrPrice.Location = new System.Drawing.Point(160, 114);
            this.tBoxCurrPrice.Name = "tBoxCurrPrice";
            this.tBoxCurrPrice.Size = new System.Drawing.Size(121, 20);
            this.tBoxCurrPrice.TabIndex = 5;
            // 
            // tBoxNewPrice
            // 
            this.tBoxNewPrice.Location = new System.Drawing.Point(160, 173);
            this.tBoxNewPrice.Name = "tBoxNewPrice";
            this.tBoxNewPrice.Size = new System.Drawing.Size(121, 20);
            this.tBoxNewPrice.TabIndex = 6;
            // 
            // btnUpdPrice
            // 
            this.btnUpdPrice.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdPrice.Location = new System.Drawing.Point(13, 296);
            this.btnUpdPrice.Name = "btnUpdPrice";
            this.btnUpdPrice.Size = new System.Drawing.Size(102, 41);
            this.btnUpdPrice.TabIndex = 9;
            this.btnUpdPrice.Text = "Update";
            this.btnUpdPrice.UseVisualStyleBackColor = true;
            this.btnUpdPrice.Click += new System.EventHandler(this.btnUpdPrice_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(160, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 41);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Return to home page";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(6, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price change:";
            // 
            // lblFuelPriceConf
            // 
            this.lblFuelPriceConf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFuelPriceConf.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelPriceConf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFuelPriceConf.Location = new System.Drawing.Point(163, 238);
            this.lblFuelPriceConf.Name = "lblFuelPriceConf";
            this.lblFuelPriceConf.Size = new System.Drawing.Size(90, 18);
            this.lblFuelPriceConf.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comBoxFuelType);
            this.groupBox1.Controls.Add(this.tBoxCurrPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnUpdPrice);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblFuelPriceConf);
            this.groupBox1.Controls.Add(this.tBoxNewPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 354);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UPDATE FUEL PRICE";
            // 
            // Form_FuelPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(541, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFuelConf);
            this.Name = "Form_FuelPrices";
            this.Text = "Form_FuelPrices";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

>>>>>>> Stashed changes
        }

        #endregion

        private System.Windows.Forms.ComboBox comBoxFuelType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxCurrPrice;
        private System.Windows.Forms.TextBox tBoxNewPrice;
        private System.Windows.Forms.Button btnUpdPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFuelConf;
        private System.Windows.Forms.Label label7;
<<<<<<< Updated upstream
        private System.Windows.Forms.Label lblFuelPriceConf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
=======
        private System.Windows.Forms.Label lblFuelPriceConf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
>>>>>>> Stashed changes
    }
}