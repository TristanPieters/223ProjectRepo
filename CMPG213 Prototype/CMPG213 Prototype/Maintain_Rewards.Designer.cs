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
            this.txbAddAmt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbAddDesc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.txbUpAmt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUpDesc = new System.Windows.Forms.TextBox();
            this.REWARDS = new System.Windows.Forms.GroupBox();
            this.errProvAddRewDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvComboxUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvUpDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvAddAmt = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvUpAmt = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            this.REWARDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvAddRewDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvComboxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvUpDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvAddAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvUpAmt)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAdd);
            this.tabControl1.Controls.Add(this.tpUpdate);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(29, 49);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAdd
            // 
            this.tpAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpAdd.Controls.Add(this.txbAddAmt);
            this.tpAdd.Controls.Add(this.label6);
            this.tpAdd.Controls.Add(this.txbAddDesc);
            this.tpAdd.Controls.Add(this.btnAdd);
            this.tpAdd.Controls.Add(this.label1);
            this.tpAdd.Location = new System.Drawing.Point(4, 34);
            this.tpAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAdd.Size = new System.Drawing.Size(612, 314);
            this.tpAdd.TabIndex = 0;
            this.tpAdd.Text = "Add";
            // 
            // txbAddAmt
            // 
            this.txbAddAmt.Location = new System.Drawing.Point(379, 100);
            this.txbAddAmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAddAmt.Name = "txbAddAmt";
            this.txbAddAmt.Size = new System.Drawing.Size(176, 30);
            this.txbAddAmt.TabIndex = 9;
            this.txbAddAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbAddAmt_KeyPress);
            this.txbAddAmt.Validating += new System.ComponentModel.CancelEventHandler(this.TxbAddAmt_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Enter Reward Amount:";
            // 
            // txbAddDesc
            // 
            this.txbAddDesc.Location = new System.Drawing.Point(379, 44);
            this.txbAddDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAddDesc.Name = "txbAddDesc";
            this.txbAddDesc.Size = new System.Drawing.Size(176, 30);
            this.txbAddDesc.TabIndex = 7;
            this.txbAddDesc.TextChanged += new System.EventHandler(this.TxbAddDesc_TextChanged);
            this.txbAddDesc.Validating += new System.ComponentModel.CancelEventHandler(this.TxbAddDesc_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(440, 169);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 48);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter reward description";
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpUpdate.Controls.Add(this.txbUpAmt);
            this.tpUpdate.Controls.Add(this.label7);
            this.tpUpdate.Controls.Add(this.cmbUpdate);
            this.tpUpdate.Controls.Add(this.btnUpdate);
            this.tpUpdate.Controls.Add(this.label2);
            this.tpUpdate.Controls.Add(this.label4);
            this.tpUpdate.Controls.Add(this.txbUpDesc);
            this.tpUpdate.Location = new System.Drawing.Point(4, 34);
            this.tpUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUpdate.Size = new System.Drawing.Size(612, 314);
            this.tpUpdate.TabIndex = 1;
            this.tpUpdate.Text = "Update";
            // 
            // txbUpAmt
            // 
            this.txbUpAmt.Location = new System.Drawing.Point(356, 187);
            this.txbUpAmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUpAmt.Name = "txbUpAmt";
            this.txbUpAmt.Size = new System.Drawing.Size(176, 30);
            this.txbUpAmt.TabIndex = 11;
            this.txbUpAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbUpAmt_KeyPress);
            this.txbUpAmt.Validating += new System.ComponentModel.CancelEventHandler(this.TxbUpAmt_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Enter Reward Amount:";
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Location = new System.Drawing.Point(356, 64);
            this.cmbUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(176, 33);
            this.cmbUpdate.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(404, 240);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 48);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter reward description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reward ID";
            // 
            // txbUpDesc
            // 
            this.txbUpDesc.Location = new System.Drawing.Point(356, 124);
            this.txbUpDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUpDesc.Name = "txbUpDesc";
            this.txbUpDesc.Size = new System.Drawing.Size(176, 30);
            this.txbUpDesc.TabIndex = 7;
            this.txbUpDesc.TextChanged += new System.EventHandler(this.TxbUpDesc_TextChanged);
            this.txbUpDesc.Validating += new System.ComponentModel.CancelEventHandler(this.TxbUpDesc_Validating);
            // 
            // REWARDS
            // 
            this.REWARDS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.REWARDS.Controls.Add(this.tabControl1);
            this.REWARDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REWARDS.ForeColor = System.Drawing.SystemColors.Control;
            this.REWARDS.Location = new System.Drawing.Point(16, 14);
            this.REWARDS.Margin = new System.Windows.Forms.Padding(4);
            this.REWARDS.Name = "REWARDS";
            this.REWARDS.Padding = new System.Windows.Forms.Padding(4);
            this.REWARDS.Size = new System.Drawing.Size(709, 450);
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
            // errProvUpDesc
            // 
            this.errProvUpDesc.ContainerControl = this;
            // 
            // errProvAddAmt
            // 
            this.errProvAddAmt.ContainerControl = this;
            // 
            // errProvUpAmt
            // 
            this.errProvUpAmt.ContainerControl = this;
            // 
            // Maintain_Rewards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(751, 484);
            this.Controls.Add(this.REWARDS);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Maintain_Rewards";
            this.Text = "Maintain_Rewards";
            this.Load += new System.EventHandler(this.Maintain_Rewards_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            this.tpUpdate.ResumeLayout(false);
            this.tpUpdate.PerformLayout();
            this.REWARDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProvAddRewDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvComboxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvUpDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvAddAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvUpAmt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.TextBox txbAddDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.TextBox txbUpDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox REWARDS;
        private System.Windows.Forms.ErrorProvider errProvAddRewDesc;
        private System.Windows.Forms.ErrorProvider errProvComboxUpdate;
        private System.Windows.Forms.ErrorProvider errProvUpDesc;
        private System.Windows.Forms.ErrorProvider errProvAddAmt;
        private System.Windows.Forms.TextBox txbAddAmt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbUpAmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errProvUpAmt;
    }
}