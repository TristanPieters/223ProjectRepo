namespace CMPG213_Prototype
{
    partial class FOrderForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txbOrDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOrEmployee = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOrFuel = new System.Windows.Forms.ComboBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.txbOrAmt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDelete = new System.Windows.Forms.TabPage();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.cmbUpEmployee = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbUpDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbUpFuel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUpOrder = new System.Windows.Forms.ComboBox();
            this.txbUpAmt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbDelete.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbDelete);
            this.tabControl1.Controls.Add(this.tpUpdate);
            this.tabControl1.Location = new System.Drawing.Point(19, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(424, 310);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage1.Controls.Add(this.txbOrDate);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cmbOrEmployee);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmbOrFuel);
            this.tabPage1.Controls.Add(this.btnADD);
            this.tabPage1.Controls.Add(this.txbOrAmt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(416, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ORDER";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // txbOrDate
            // 
            this.txbOrDate.Location = new System.Drawing.Point(206, 151);
            this.txbOrDate.Name = "txbOrDate";
            this.txbOrDate.Size = new System.Drawing.Size(120, 26);
            this.txbOrDate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "RECIEVE DATE";
            // 
            // cmbOrEmployee
            // 
            this.cmbOrEmployee.FormattingEnabled = true;
            this.cmbOrEmployee.Location = new System.Drawing.Point(206, 107);
            this.cmbOrEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOrEmployee.Name = "cmbOrEmployee";
            this.cmbOrEmployee.Size = new System.Drawing.Size(120, 28);
            this.cmbOrEmployee.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "EMPLOYEE ID";
            // 
            // cmbOrFuel
            // 
            this.cmbOrFuel.FormattingEnabled = true;
            this.cmbOrFuel.Location = new System.Drawing.Point(206, 20);
            this.cmbOrFuel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOrFuel.Name = "cmbOrFuel";
            this.cmbOrFuel.Size = new System.Drawing.Size(120, 28);
            this.cmbOrFuel.TabIndex = 5;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.White;
            this.btnADD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnADD.Location = new System.Drawing.Point(231, 211);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(95, 31);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.BtnADD_Click);
            // 
            // txbOrAmt
            // 
            this.txbOrAmt.Location = new System.Drawing.Point(206, 63);
            this.txbOrAmt.Name = "txbOrAmt";
            this.txbOrAmt.Size = new System.Drawing.Size(120, 26);
            this.txbOrAmt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "AMOUNT ORDERED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUEL ID";
            // 
            // tbDelete
            // 
            this.tbDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbDelete.Controls.Add(this.cmbDelete);
            this.tbDelete.Controls.Add(this.btnDelete);
            this.tbDelete.Controls.Add(this.label3);
            this.tbDelete.Location = new System.Drawing.Point(4, 29);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbDelete.Size = new System.Drawing.Size(416, 277);
            this.tbDelete.TabIndex = 1;
            this.tbDelete.Text = "DELETE";
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(130, 25);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(116, 28);
            this.cmbDelete.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(135, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ORDER ID";
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpUpdate.Controls.Add(this.cmbUpEmployee);
            this.tpUpdate.Controls.Add(this.label10);
            this.tpUpdate.Controls.Add(this.txbUpDate);
            this.tpUpdate.Controls.Add(this.label9);
            this.tpUpdate.Controls.Add(this.cmbUpFuel);
            this.tpUpdate.Controls.Add(this.label8);
            this.tpUpdate.Controls.Add(this.cmbUpOrder);
            this.tpUpdate.Controls.Add(this.txbUpAmt);
            this.tpUpdate.Controls.Add(this.label5);
            this.tpUpdate.Controls.Add(this.label4);
            this.tpUpdate.Controls.Add(this.btnUpdate);
            this.tpUpdate.Location = new System.Drawing.Point(4, 29);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Size = new System.Drawing.Size(416, 277);
            this.tpUpdate.TabIndex = 2;
            this.tpUpdate.Text = "UPDATE";
            // 
            // cmbUpEmployee
            // 
            this.cmbUpEmployee.FormattingEnabled = true;
            this.cmbUpEmployee.Location = new System.Drawing.Point(230, 96);
            this.cmbUpEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUpEmployee.Name = "cmbUpEmployee";
            this.cmbUpEmployee.Size = new System.Drawing.Size(120, 28);
            this.cmbUpEmployee.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(38, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "EMPLOYEE ID";
            // 
            // txbUpDate
            // 
            this.txbUpDate.Location = new System.Drawing.Point(230, 173);
            this.txbUpDate.Name = "txbUpDate";
            this.txbUpDate.Size = new System.Drawing.Size(120, 26);
            this.txbUpDate.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(38, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "RECIEVE DATE";
            // 
            // cmbUpFuel
            // 
            this.cmbUpFuel.FormattingEnabled = true;
            this.cmbUpFuel.Location = new System.Drawing.Point(230, 57);
            this.cmbUpFuel.Name = "cmbUpFuel";
            this.cmbUpFuel.Size = new System.Drawing.Size(120, 28);
            this.cmbUpFuel.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(38, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "FUEL ID";
            // 
            // cmbUpOrder
            // 
            this.cmbUpOrder.FormattingEnabled = true;
            this.cmbUpOrder.Location = new System.Drawing.Point(230, 20);
            this.cmbUpOrder.Name = "cmbUpOrder";
            this.cmbUpOrder.Size = new System.Drawing.Size(120, 28);
            this.cmbUpOrder.TabIndex = 7;
            // 
            // txbUpAmt
            // 
            this.txbUpAmt.Location = new System.Drawing.Point(230, 135);
            this.txbUpAmt.Name = "txbUpAmt";
            this.txbUpAmt.Size = new System.Drawing.Size(120, 26);
            this.txbUpAmt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(38, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "AMOUNT ORDERED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(38, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ORDER ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(239, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 33);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(474, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(356, 122);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 402);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FUEL ORDERS";
            // 
            // FOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FOrderForm";
            this.Text = "FOrderForm";
            this.Load += new System.EventHandler(this.FOrderForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbDelete.ResumeLayout(false);
            this.tbDelete.PerformLayout();
            this.tpUpdate.ResumeLayout(false);
            this.tpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txbOrAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbDelete;
        private System.Windows.Forms.ComboBox cmbDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.ComboBox cmbUpOrder;
        private System.Windows.Forms.TextBox txbUpAmt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbOrEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOrFuel;
        private System.Windows.Forms.ComboBox cmbUpFuel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbOrDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbUpDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUpEmployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}