namespace CMPG213_Prototype
{
    partial class ClockInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.btnClockIn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtTimeIN = new System.Windows.Forms.DateTimePicker();
            this.dtTimeOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(50, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(394, 87);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(238, 45);
            this.cmbEmployee.TabIndex = 1;
            this.cmbEmployee.Validating += new System.ComponentModel.CancelEventHandler(this.CmbEmployee_Validating);
            // 
            // btnClockIn
            // 
            this.btnClockIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnClockIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClockIn.Location = new System.Drawing.Point(394, 469);
            this.btnClockIn.Margin = new System.Windows.Forms.Padding(6);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(236, 87);
            this.btnClockIn.TabIndex = 2;
            this.btnClockIn.Text = "Clock In";
            this.btnClockIn.UseVisualStyleBackColor = false;
            this.btnClockIn.Click += new System.EventHandler(this.BtnClockIn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtTimeOut);
            this.groupBox1.Controls.Add(this.dtTimeIN);
            this.groupBox1.Controls.Add(this.cmbEmployee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClockIn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(60, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(746, 589);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clock Time";
            // 
            // dtTimeIN
            // 
            this.dtTimeIN.CustomFormat = "\"hh:mm:ss\"";
            this.dtTimeIN.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimeIN.Location = new System.Drawing.Point(392, 181);
            this.dtTimeIN.Name = "dtTimeIN";
            this.dtTimeIN.Size = new System.Drawing.Size(238, 44);
            this.dtTimeIN.TabIndex = 5;
            this.dtTimeIN.Value = new System.DateTime(2019, 10, 6, 17, 46, 5, 0);
            // 
            // dtTimeOut
            // 
            this.dtTimeOut.CustomFormat = "\"hh:mm:ss\"";
            this.dtTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimeOut.Location = new System.Drawing.Point(394, 289);
            this.dtTimeOut.Name = "dtTimeOut";
            this.dtTimeOut.Size = new System.Drawing.Size(238, 44);
            this.dtTimeOut.TabIndex = 6;
            this.dtTimeOut.Value = new System.DateTime(2019, 10, 6, 17, 46, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(50, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time IN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(50, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time Out";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ClockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1026, 735);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ClockInForm";
            this.Text = "ClockInForm";
            this.Load += new System.EventHandler(this.ClockInForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Button btnClockIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtTimeIN;
        private System.Windows.Forms.DateTimePicker dtTimeOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}