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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.btnClockIn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE ID:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(197, 45);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(121, 28);
            this.cmbEmployee.TabIndex = 1;
            // 
            // btnClockIn
            // 
            this.btnClockIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnClockIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClockIn.Location = new System.Drawing.Point(200, 175);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(118, 45);
            this.btnClockIn.TabIndex = 2;
            this.btnClockIn.Text = "Clock In";
            this.btnClockIn.UseVisualStyleBackColor = false;
            this.btnClockIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEmployee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClockIn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(30, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 245);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLOCK IN";
            // 
            // ClockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(513, 294);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClockInForm";
            this.Text = "ClockInForm";
            this.Load += new System.EventHandler(this.ClockInForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Button btnClockIn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}