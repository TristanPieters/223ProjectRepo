using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG213_Prototype
{
    public partial class Maintain_Rewards : Form
    {
        public Maintain_Rewards()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\SGSDBF.mdf;Integrated Security=True");


        string detail, amt;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbAddDesc.Text, "Please enter valid reward description.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbAddAmt.Text, "Please enter valid amount !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            detail = txbAddDesc.Text;
            amt = txbAddAmt.Text;

            string sql = @"Insert Into REWARD (Reward_Description, Reward_Amount) Values('" + detail + "', '" + amt + "')";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            txbAddDesc.Text = "";
            txbAddAmt.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbUpdate.SelectedItem == null)
            {
                errProvComboxUpdate.SetError(cmbUpdate, "Please select an item from the combobox !");
            }
            else
            {
                errProvComboxUpdate.Clear();
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbUpDesc.Text, "Please enter valid reward description.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbUpAmt.Text, "Please enter valid amount.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            detail = txbUpDesc.Text;
            amt = txbUpAmt.Text;

            string sql = @"UPDATE REWARD SET Reward_Description ='" + detail + "', Reward_Amount = '" + amt + "' WHERE Reward_ID = '" + cmbUpdate.SelectedItem + "'";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                adap.UpdateCommand = new SqlCommand(sql, conn);
                adap.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Record successfuly updated!");
                comm.Dispose();
                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            txbUpDesc.Text = "";
            txbUpAmt.Text = "";
        }

       

        private void Maintain_Rewards_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT Reward_ID FROM REWARD";
            conn.Open();
            SqlDataReader reader;
            SqlCommand comm = new SqlCommand(sql, conn);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string output = Convert.ToString(reader.GetValue(0));
                cmbUpdate.Items.Add(output);
            }
            comm.Dispose();
            conn.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Home_Page_FutureTech home = new Form_Home_Page_FutureTech();
            home.ShowDialog();
        }


        private void TxbAddAmt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbAddAmt.Text))
            {
                e.Cancel = true;
                txbAddAmt.Focus();
                errProvAddAmt.SetError(txbAddAmt, "Please enter valid amount !");
            }
            else
            {
                e.Cancel = false;
                errProvAddAmt.SetError(txbAddAmt, null);

            }

        }

        private void TxbAddAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void TxbAddDesc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbAddDesc.Text))
            {
                e.Cancel = true;
                txbAddDesc.Focus();
                errProvAddRewDesc.SetError(txbAddDesc, "Please enter valid reward description !");
            }
            else
            {
                e.Cancel = false;
                errProvAddRewDesc.SetError(txbAddDesc, null);
            }

        }

        private void TxbAddDesc_TextChanged(object sender, EventArgs e)
        {
            if (txbAddDesc.Text.All(chr => char.IsLetter(chr)))
            {
                string oldText = txbAddDesc.Text;
                txbAddDesc.Text = oldText;

                txbAddDesc.BackColor = System.Drawing.Color.White;
                txbAddDesc.ForeColor = System.Drawing.Color.Black;
            }
            else
            {

                txbAddDesc.BackColor = System.Drawing.Color.Red;
                txbAddDesc.ForeColor = System.Drawing.Color.White;
            }
            txbAddDesc.SelectionStart = txbAddDesc.Text.Length;

        }

        private void TxbUpDesc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbUpDesc.Text))
            {
                e.Cancel = true;
                txbUpDesc.Focus();
                errProvUpDesc.SetError(txbUpDesc, "Please enter valid reward description !");
            }
            else
            {
                e.Cancel = false;
                errProvUpDesc.SetError(txbUpDesc, null);
            }

        }

        private void TxbUpDesc_TextChanged(object sender, EventArgs e)
        {
            if (txbUpDesc.Text.All(chr => char.IsLetter(chr)))
            {
                string oldText = txbUpDesc.Text;
                txbUpDesc.Text = oldText;

                txbUpDesc.BackColor = System.Drawing.Color.White;
                txbUpDesc.ForeColor = System.Drawing.Color.Black;
            }
            else
            {

                txbUpDesc.BackColor = System.Drawing.Color.Red;
                txbUpDesc.ForeColor = System.Drawing.Color.White;
            }
            txbUpDesc.SelectionStart = txbUpDesc.Text.Length;
        }

        private void TxbUpAmt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbUpAmt.Text))
            {
                e.Cancel = true;
                txbUpAmt.Focus();
                errProvUpAmt.SetError(txbUpAmt, "Please enter employee cell number !");
            }
            else
            {
                e.Cancel = false;
                errProvUpAmt.SetError(txbUpAmt, null);

            }

        }

        private void TxbUpAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
