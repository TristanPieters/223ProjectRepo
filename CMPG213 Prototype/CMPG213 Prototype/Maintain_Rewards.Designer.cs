namespace CMPG213_Prototype
{
    partial class Maintain_Rewards
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
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.txbAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tpDelete = new System.Windows.Forms.TabPage();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.REWARDS = new System.Windows.Forms.GroupBox();
            this.errProvAddRewDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvComboxUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvTboxUpd = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvComboxDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvTboxDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            this.tpDelete.SuspendLayout();
            this.REWARDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvAddRewDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvComboxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvTboxUpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvComboxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvTboxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAdd);
            this.tabControl1.Controls.Add(this.tpUpdate);
            this.tabControl1.Controls.Add(this.tpDelete);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(22, 40);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(465, 286);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpAdd
            // 
            this.tpAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpAdd.Controls.Add(this.textBox1);
            this.tpAdd.Controls.Add(this.label6);
            this.tpAdd.Controls.Add(this.txbAdd);
            this.tpAdd.Controls.Add(this.btnAdd);
            this.tpAdd.Controls.Add(this.label1);
            this.tpAdd.Location = new System.Drawing.Point(4, 29);
            this.tpAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(2);
            this.tpAdd.Size = new System.Drawing.Size(457, 253);
            this.tpAdd.TabIndex = 0;
            this.tpAdd.Text = "Add";
            // 
            // txbAdd
            // 
            this.txbAdd.Location = new System.Drawing.Point(284, 36);
            this.txbAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txbAdd.Name = "txbAdd";
            this.txbAdd.Size = new System.Drawing.Size(133, 26);
            this.txbAdd.TabIndex = 7;
            this.txbAdd.Validating += new System.ComponentModel.CancelEventHandler(this.txbAdd_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter reward description";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(330, 137);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpUpdate.Controls.Add(this.textBox2);
            this.tpUpdate.Controls.Add(this.label7);
            this.tpUpdate.Controls.Add(this.cmbUpdate);
            this.tpUpdate.Controls.Add(this.btnUpdate);
            this.tpUpdate.Controls.Add(this.label2);
            this.tpUpdate.Controls.Add(this.label4);
            this.tpUpdate.Controls.Add(this.txbUpdate);
            this.tpUpdate.Location = new System.Drawing.Point(4, 29);
            this.tpUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(2);
            this.tpUpdate.Size = new System.Drawing.Size(457, 253);
            this.tpUpdate.TabIndex = 1;
            this.tpUpdate.Text = "Update";
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Location = new System.Drawing.Point(267, 52);
            this.cmbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(133, 28);
            this.cmbUpdate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reward ID";
            // 
            // txbUpdate
            // 
            this.txbUpdate.Location = new System.Drawing.Point(267, 101);
            this.txbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txbUpdate.Name = "txbUpdate";
            this.txbUpdate.Size = new System.Drawing.Size(133, 26);
            this.txbUpdate.TabIndex = 7;
            this.txbUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.txbUpdate_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter reward description";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(303, 195);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 39);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // tpDelete
            // 
            this.tpDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpDelete.Controls.Add(this.cmbDelete);
            this.tpDelete.Controls.Add(this.btnDelete);
            this.tpDelete.Controls.Add(this.label5);
            this.tpDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpDelete.Location = new System.Drawing.Point(4, 29);
            this.tpDelete.Margin = new System.Windows.Forms.Padding(2);
            this.tpDelete.Name = "tpDelete";
            this.tpDelete.Padding = new System.Windows.Forms.Padding(2);
            this.tpDelete.Size = new System.Drawing.Size(457, 253);
            this.tpDelete.TabIndex = 2;
            this.tpDelete.Text = "Delete";
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(285, 25);
            this.cmbDelete.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(133, 28);
            this.cmbDelete.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reward ID";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(324, 180);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // REWARDS
            // 
            this.REWARDS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.REWARDS.Controls.Add(this.tabControl1);
            this.REWARDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REWARDS.ForeColor = System.Drawing.SystemColors.Control;
            this.REWARDS.Location = new System.Drawing.Point(12, 11);
            this.REWARDS.Name = "REWARDS";
            this.REWARDS.Size = new System.Drawing.Size(532, 366);
            this.REWARDS.TabIndex = 7;
            this.REWARDS.TabStop = false;
            this.REWARDS.Text = "REWARDS";
            // 
            // errProvAddRewDesc
            // 
            this.errProvAddRewDesc.ContainerControl = this;
            // 
            // errProvComboxUpdate
            // 
            this.errProvComboxUpdate.ContainerControl = this;
            // 
            // errProvTboxUpd
            // 
            this.errProvTboxUpd.ContainerControl = this;
            // 
            // errProvComboxDelete
            // 
            this.errProvComboxDelete.ContainerControl = this;
            // 
            // errProvTboxDelete
            // 
            this.errProvTboxDelete.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 81);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Enter Reward Amount:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 152);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 26);
            this.textBox2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Enter Reward Amount:";
            // 
            // Maintain_Rewards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(563, 393);
            this.Controls.Add(this.REWARDS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Maintain_Rewards";
            this.Text = "Maintain_Rewards";
            this.Load += new System.EventHandler(this.Maintain_Rewards_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            this.tpUpdate.ResumeLayout(false);
            this.tpUpdate.PerformLayout();
            this.tpDelete.ResumeLayout(false);
            this.tpDelete.PerformLayout();
            this.REWARDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProvAddRewDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvComboxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvTboxUpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvComboxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvTboxDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.TextBox txbAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.TextBox txbUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabPage tpDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox REWARDS;
        private System.Windows.Forms.ErrorProvider errProvAddRewDesc;
        private System.Windows.Forms.ErrorProvider errProvComboxUpdate;
        private System.Windows.Forms.ErrorProvider errProvTboxUpd;
        private System.Windows.Forms.ErrorProvider errProvComboxDelete;
        private System.Windows.Forms.ErrorProvider errProvTboxDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
    }
}