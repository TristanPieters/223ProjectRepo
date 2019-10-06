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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mcOr = new System.Windows.Forms.MonthCalendar();
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
            this.mcUp = new System.Windows.Forms.MonthCalendar();
            this.cmbUpEmployee = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.epOrFuel = new System.Windows.Forms.ErrorProvider(this.components);
            this.epOrEmp = new System.Windows.Forms.ErrorProvider(this.components);
            this.epOrAmt = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpOrder = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpFuel = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpEmp = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUpAmt = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbDelete.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epOrFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOrEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOrAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpAmt)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbDelete);
            this.tabControl1.Controls.Add(this.tpUpdate);
            this.tabControl1.Location = new System.Drawing.Point(25, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 573);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage1.Controls.Add(this.mcOr);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cmbOrEmployee);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmbOrFuel);
            this.tabPage1.Controls.Add(this.btnADD);
            this.tabPage1.Controls.Add(this.txbOrAmt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(592, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ORDER";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // mcOr
            // 
            this.mcOr.Location = new System.Drawing.Point(275, 190);
            this.mcOr.MaxSelectionCount = 1;
            this.mcOr.Name = "mcOr";
            this.mcOr.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(8, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "RECIEVE DATE";
            // 
            // cmbOrEmployee
            // 
            this.cmbOrEmployee.FormattingEnabled = true;
            this.cmbOrEmployee.Location = new System.Drawing.Point(275, 83);
            this.cmbOrEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOrEmployee.Name = "cmbOrEmployee";
            this.cmbOrEmployee.Size = new System.Drawing.Size(159, 33);
            this.cmbOrEmployee.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(8, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "EMPLOYEE ID";
            // 
            // cmbOrFuel
            // 
            this.cmbOrFuel.FormattingEnabled = true;
            this.cmbOrFuel.Location = new System.Drawing.Point(275, 25);
            this.cmbOrFuel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOrFuel.Name = "cmbOrFuel";
            this.cmbOrFuel.Size = new System.Drawing.Size(159, 33);
            this.cmbOrFuel.TabIndex = 5;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.White;
            this.btnADD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnADD.Location = new System.Drawing.Point(335, 450);
            this.btnADD.Margin = new System.Windows.Forms.Padding(4);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(127, 38);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.BtnADD_Click);
            // 
            // txbOrAmt
            // 
            this.txbOrAmt.Location = new System.Drawing.Point(275, 137);
            this.txbOrAmt.Margin = new System.Windows.Forms.Padding(4);
            this.txbOrAmt.Name = "txbOrAmt";
            this.txbOrAmt.Size = new System.Drawing.Size(159, 30);
            this.txbOrAmt.TabIndex = 3;
            this.txbOrAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbOrAmt_KeyPress);
            this.txbOrAmt.Validating += new System.ComponentModel.CancelEventHandler(this.TxbOrAmt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "AMOUNT ORDERED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUEL ID";
            // 
            // tbDelete
            // 
            this.tbDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbDelete.Controls.Add(this.cmbDelete);
            this.tbDelete.Controls.Add(this.btnDelete);
            this.tbDelete.Controls.Add(this.label3);
            this.tbDelete.Location = new System.Drawing.Point(4, 34);
            this.tbDelete.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Padding = new System.Windows.Forms.Padding(4);
            this.tbDelete.Size = new System.Drawing.Size(592, 535);
            this.tbDelete.TabIndex = 1;
            this.tbDelete.Text = "DELETE";
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(173, 31);
            this.cmbDelete.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(153, 33);
            this.cmbDelete.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(180, 89);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(8, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ORDER ID";
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpUpdate.Controls.Add(this.mcUp);
            this.tpUpdate.Controls.Add(this.cmbUpEmployee);
            this.tpUpdate.Controls.Add(this.label10);
            this.tpUpdate.Controls.Add(this.label9);
            this.tpUpdate.Controls.Add(this.cmbUpFuel);
            this.tpUpdate.Controls.Add(this.label8);
            this.tpUpdate.Controls.Add(this.cmbUpOrder);
            this.tpUpdate.Controls.Add(this.txbUpAmt);
            this.tpUpdate.Controls.Add(this.label5);
            this.tpUpdate.Controls.Add(this.label4);
            this.tpUpdate.Controls.Add(this.btnUpdate);
            this.tpUpdate.Location = new System.Drawing.Point(4, 34);
            this.tpUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Size = new System.Drawing.Size(592, 535);
            this.tpUpdate.TabIndex = 2;
            this.tpUpdate.Text = "UPDATE";
            // 
            // mcUp
            // 
            this.mcUp.Location = new System.Drawing.Point(307, 212);
            this.mcUp.Name = "mcUp";
            this.mcUp.TabIndex = 5;
            // 
            // cmbUpEmployee
            // 
            this.cmbUpEmployee.FormattingEnabled = true;
            this.cmbUpEmployee.Location = new System.Drawing.Point(307, 118);
            this.cmbUpEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUpEmployee.Name = "cmbUpEmployee";
            this.cmbUpEmployee.Size = new System.Drawing.Size(159, 33);
            this.cmbUpEmployee.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(51, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "EMPLOYEE ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(51, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "RECIEVE DATE";
            // 
            // cmbUpFuel
            // 
            this.cmbUpFuel.FormattingEnabled = true;
            this.cmbUpFuel.Location = new System.Drawing.Point(307, 70);
            this.cmbUpFuel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUpFuel.Name = "cmbUpFuel";
            this.cmbUpFuel.Size = new System.Drawing.Size(159, 33);
            this.cmbUpFuel.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(51, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "FUEL ID";
            // 
            // cmbUpOrder
            // 
            this.cmbUpOrder.FormattingEnabled = true;
            this.cmbUpOrder.Location = new System.Drawing.Point(307, 25);
            this.cmbUpOrder.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUpOrder.Name = "cmbUpOrder";
            this.cmbUpOrder.Size = new System.Drawing.Size(159, 33);
            this.cmbUpOrder.TabIndex = 7;
            // 
            // txbUpAmt
            // 
            this.txbUpAmt.Location = new System.Drawing.Point(307, 166);
            this.txbUpAmt.Margin = new System.Windows.Forms.Padding(4);
            this.txbUpAmt.Name = "txbUpAmt";
            this.txbUpAmt.Size = new System.Drawing.Size(159, 30);
            this.txbUpAmt.TabIndex = 6;
            this.txbUpAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbUpAmt_KeyPress);
            this.txbUpAmt.Validating += new System.ComponentModel.CancelEventHandler(this.TxbUpAmt_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(51, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "AMOUNT ORDERED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(51, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "ORDER ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(367, 467);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 41);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(632, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 226);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(16, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1132, 655);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FUEL ORDERS";
            // 
            // epOrFuel
            // 
            this.epOrFuel.ContainerControl = this;
            // 
            // epOrEmp
            // 
            this.epOrEmp.ContainerControl = this;
            // 
            // epOrAmt
            // 
            this.epOrAmt.ContainerControl = this;
            // 
            // epDelete
            // 
            this.epDelete.ContainerControl = this;
            // 
            // epUpOrder
            // 
            this.epUpOrder.ContainerControl = this;
            // 
            // epUpFuel
            // 
            this.epUpFuel.ContainerControl = this;
            // 
            // epUpEmp
            // 
            this.epUpEmp.ContainerControl = this;
            // 
            // epUpAmt
            // 
            this.epUpAmt.ContainerControl = this;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(813, 525);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(213, 69);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "BACK";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1185, 699);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.epOrFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOrEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOrAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUpAmt)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUpEmployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar mcOr;
        private System.Windows.Forms.MonthCalendar mcUp;
        private System.Windows.Forms.ErrorProvider epOrFuel;
        private System.Windows.Forms.ErrorProvider epOrEmp;
        private System.Windows.Forms.ErrorProvider epOrAmt;
        private System.Windows.Forms.ErrorProvider epDelete;
        private System.Windows.Forms.ErrorProvider epUpOrder;
        private System.Windows.Forms.ErrorProvider epUpFuel;
        private System.Windows.Forms.ErrorProvider epUpEmp;
        private System.Windows.Forms.ErrorProvider epUpAmt;
        private System.Windows.Forms.Button btnExit;
    }
}