using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG213_Prototype
{
    public partial class _ : Form
    {
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnADD;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tbDelete;
        private ComboBox comboBox2;
        private Button button1;
        private Label label3;
        private TabPage tpUpdate;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnUdate;

        public _()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnADD = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDelete = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUdate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbDelete.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tbDelete);
            this.tabControl1.Controls.Add(this.tpUpdate);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(317, 215);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btnADD);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(309, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ORDER";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.White;
            this.btnADD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnADD.Location = new System.Drawing.Point(9, 123);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(95, 31);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRICE PER LITER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUEL DESCRIPTION";
            // 
            // tbDelete
            // 
            this.tbDelete.BackColor = System.Drawing.Color.Black;
            this.tbDelete.Controls.Add(this.comboBox2);
            this.tbDelete.Controls.Add(this.button1);
            this.tbDelete.Controls.Add(this.label3);
            this.tbDelete.Location = new System.Drawing.Point(4, 22);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tbDelete.Size = new System.Drawing.Size(309, 189);
            this.tbDelete.TabIndex = 1;
            this.tbDelete.Text = "DELETE";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(161, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(116, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(9, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "FUEL DESCRIPTION";
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackColor = System.Drawing.Color.Black;
            this.tpUpdate.Controls.Add(this.comboBox1);
            this.tpUpdate.Controls.Add(this.textBox6);
            this.tpUpdate.Controls.Add(this.textBox5);
            this.tpUpdate.Controls.Add(this.label6);
            this.tpUpdate.Controls.Add(this.label5);
            this.tpUpdate.Controls.Add(this.label4);
            this.tpUpdate.Controls.Add(this.btnUdate);
            this.tpUpdate.Location = new System.Drawing.Point(4, 22);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Size = new System.Drawing.Size(309, 189);
            this.tpUpdate.TabIndex = 2;
            this.tpUpdate.Text = "UPDATE";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(176, 50);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(116, 20);
            this.textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(176, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 20);
            this.textBox5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "FUEL RESERVES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "PRICE PER LITER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "FUEL DESCRIPTION";
            // 
            // btnUdate
            // 
            this.btnUdate.BackColor = System.Drawing.Color.White;
            this.btnUdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUdate.Location = new System.Drawing.Point(6, 136);
            this.btnUdate.Name = "btnUdate";
            this.btnUdate.Size = new System.Drawing.Size(75, 23);
            this.btnUdate.TabIndex = 0;
            this.btnUdate.Text = "UPDATE";
            this.btnUdate.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(309, 189);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "RECIEVE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _
            // 
            this.ClientSize = new System.Drawing.Size(683, 424);
            this.Controls.Add(this.tabControl1);
            this.Name = "_";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbDelete.ResumeLayout(false);
            this.tbDelete.PerformLayout();
            this.tpUpdate.ResumeLayout(false);
            this.tpUpdate.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
