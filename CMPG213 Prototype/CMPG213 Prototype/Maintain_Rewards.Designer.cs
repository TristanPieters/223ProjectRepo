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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tpDelete = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDelete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvReward = new System.Windows.Forms.DataGridView();
            this.REWARDS = new System.Windows.Forms.GroupBox();
            this.errProvAddRewDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvComboxUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvTboxUpd = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvComboxDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvTboxDelete = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpDelete.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReward)).BeginInit();
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
            // 
            // tpAdd
            // 
            this.tpAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpAdd.Controls.Add(this.groupBox1);
            this.tpAdd.Location = new System.Drawing.Point(4, 29);
            this.tpAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(2);
            this.tpAdd.Size = new System.Drawing.Size(457, 253);
            this.tpAdd.TabIndex = 0;
            this.tpAdd.Text = "Add";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(416, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD";
            // 
            // txbAdd
            // 
            this.txbAdd.Location = new System.Drawing.Point(262, 48);
            this.txbAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txbAdd.Name = "txbAdd";
            this.txbAdd.Size = new System.Drawing.Size(133, 26);
            this.txbAdd.TabIndex = 7;
            this.txbAdd.Validating += new System.ComponentModel.CancelEventHandler(this.txbAdd_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter reward description";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(308, 124);
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
            this.tpUpdate.Controls.Add(this.groupBox2);
            this.tpUpdate.Location = new System.Drawing.Point(4, 29);
            this.tpUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(2);
            this.tpUpdate.Size = new System.Drawing.Size(457, 253);
            this.tpUpdate.TabIndex = 1;
            this.tpUpdate.Text = "Update";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbUpdate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbUpdate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(22, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(405, 208);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UPDATE";
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Location = new System.Drawing.Point(240, 29);
            this.cmbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(133, 28);
            this.cmbUpdate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reward ID";
            // 
            // txbUpdate
            // 
            this.txbUpdate.Location = new System.Drawing.Point(240, 78);
            this.txbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txbUpdate.Name = "txbUpdate";
            this.txbUpdate.Size = new System.Drawing.Size(133, 26);
            this.txbUpdate.TabIndex = 7;
            this.txbUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.txbUpdate_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter reward description";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(276, 139);
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
            this.tpDelete.Controls.Add(this.groupBox3);
            this.tpDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpDelete.Location = new System.Drawing.Point(4, 29);
            this.tpDelete.Margin = new System.Windows.Forms.Padding(2);
            this.tpDelete.Name = "tpDelete";
            this.tpDelete.Padding = new System.Windows.Forms.Padding(2);
            this.tpDelete.Size = new System.Drawing.Size(457, 253);
            this.tpDelete.TabIndex = 2;
            this.tpDelete.Text = "Delete";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbDelete);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txbDelete);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(22, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(409, 208);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DELETE";
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(241, 29);
            this.cmbDelete.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(133, 28);
            this.cmbDelete.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reward ID";
            // 
            // txbDelete
            // 
            this.txbDelete.Location = new System.Drawing.Point(241, 70);
            this.txbDelete.Margin = new System.Windows.Forms.Padding(2);
            this.txbDelete.Name = "txbDelete";
            this.txbDelete.Size = new System.Drawing.Size(133, 26);
            this.txbDelete.TabIndex = 7;
            this.txbDelete.Validating += new System.ComponentModel.CancelEventHandler(this.txbDelete_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter reward description";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(280, 139);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(48, 361);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dgvReward
            // 
            this.dgvReward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReward.Location = new System.Drawing.Point(522, 37);
            this.dgvReward.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReward.Name = "dgvReward";
            this.dgvReward.RowTemplate.Height = 24;
            this.dgvReward.Size = new System.Drawing.Size(535, 305);
            this.dgvReward.TabIndex = 6;
            // 
            // REWARDS
            // 
            this.REWARDS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.REWARDS.Controls.Add(this.dgvReward);
            this.REWARDS.Controls.Add(this.btnBack);
            this.REWARDS.Controls.Add(this.tabControl1);
            this.REWARDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REWARDS.ForeColor = System.Drawing.SystemColors.Control;
            this.REWARDS.Location = new System.Drawing.Point(12, 11);
            this.REWARDS.Name = "REWARDS";
            this.REWARDS.Size = new System.Drawing.Size(1088, 445);
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
            // Maintain_Rewards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1124, 497);
            this.Controls.Add(this.REWARDS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Maintain_Rewards";
            this.Text = "Maintain_Rewards";
            this.Load += new System.EventHandler(this.Maintain_Rewards_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAdd.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpUpdate.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpDelete.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReward)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabPage tpDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvReward;
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
    }
}