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
using System.Text.RegularExpressions;

namespace CMPG213_Prototype
{
    public partial class AccountUpdateDel : Form
    {
        public AccountUpdateDel()
        {
            InitializeComponent();
        }
        SqlConnection CONN = new SqlConnection();





        private void AccountUpdateDel_Load(object sender, EventArgs e)
        {
            CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dewald\Desktop\CMPG223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDBFF.mdf;Integrated Security=True");

            CONN.Open();
            SqlCommand comm;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select * FROM ACCOUNT";
            comm = new SqlCommand(sql, CONN);
            DataSet ds = new DataSet();
            adapter.SelectCommand = comm;
            adapter.Fill(ds, "ACCOUNT");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ACCOUNT";
            CONN.Close();


        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {

            CONN.Open();
            SqlCommand command;
            string sql = @" DELETE FROM ACCOUNT WHERE Acc_IDnum  ='" + tbxID.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter();
         
            command = new SqlCommand(sql,CONN);
            DataSet ds = new DataSet();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
            adapter.Fill(ds, "ACCOUNT");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ACCOUNT";

            CONN.Close();
        }

        private void TbxID_TextChanged(object sender, EventArgs e)
        {
            string query = @"SELECT * from ACCOUNT WHERE Acc_IDnum LIKE '%" + tbxID.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, CONN);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ACCOUNT");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ACCOUNT";
        }

        private void BtnOutstanding_Click(object sender, EventArgs e)
        {
            CONN.Open();
            SqlCommand comm;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select * FROM ACCOUNT WHERE Acc_Debt > 0";
            comm = new SqlCommand(sql, CONN);
            DataSet ds = new DataSet();
            adapter.SelectCommand = comm;
            adapter.Fill(ds, "ACCOUNT");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ACCOUNT";
            CONN.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int length = tbxIDu.Text.Length;
            Regex pattern = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$");
            if (pattern.IsMatch(tbxCellNumberU.Text))
            {
                MessageBox.Show("Cell phone number is valid");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                tbxCellNumberU.Focus();
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(tbxFirstNameU.Text, "Please enter valid account first name !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(tbxLastNameU.Text, "Please enter valid account last name !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(tbxCellNumberU.Text, "Please enter valid account cell number !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(tbxEmailU.Text, "Please enter valid account email !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(tbxIDu.Text, "Please enter valid account ID !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(tbxDebt.Text, "Please enter valid account dept !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(tbxLiters.Text, "Please enter valid account liters sold !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =D:\Akademie\CMPG_223\FutureTech Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security = True");
            string sName, sSurname, sID, sCellnr, sEmail;
            decimal dDebt;
            double Liters;

            sName = tbxFirstNameU.Text;
            sSurname = tbxLastNameU.Text;
            sCellnr = tbxCellNumberU.Text;
            sEmail = tbxEmailU.Text;
            dDebt = Convert.ToDecimal(tbxDebt.Text);
            Liters = Convert.ToDouble(tbxLiters.Text);
            if ((length == 13) && (tbxID.Text != " "))
            {
                sID = tbxIDu.Text;

            }
            else
            {
                MessageBox.Show("ID required and must be 13 digits");
                tbxID.Focus();
            }
            string sql = @"UPDATE ACCOUNT SET Acc_FName = '" + sName + "', Acc_LName = '" + sSurname + "', Acc_Email = '" + sEmail + "', Acc_Cellnum = '" + sCellnr + "', Acc_Debt = '" + dDebt + "', Acc_LSold = '" + Liters + "' WHERE Acc_ID = '" + Convert.ToString(numericUpDown1.Value) + "'";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                adap.UpdateCommand = new SqlCommand(sql, conn);
                adap.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Record Updated successfully");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnFillterLiters_Click(object sender, EventArgs e)
        {
            CONN.Open();
            SqlCommand comm;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select * FROM ACCOUNT WHERE Acc_LSold > 0";
            comm = new SqlCommand(sql, CONN);
            DataSet ds = new DataSet();
            adapter.SelectCommand = comm;
            adapter.Fill(ds, "ACCOUNT");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ACCOUNT";
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbxFirstNameU_TextChanged(object sender, EventArgs e)
        {
            if (tbxFirstNameU.Text.All(chr => char.IsLetter(chr)))
            {
                string oldText = tbxFirstNameU.Text;
                tbxFirstNameU.Text = oldText;

                tbxFirstNameU.BackColor = System.Drawing.Color.White;
                tbxFirstNameU.ForeColor = System.Drawing.Color.Black;
            }
            else
            {

                tbxFirstNameU.BackColor = System.Drawing.Color.Red;
                tbxFirstNameU.ForeColor = System.Drawing.Color.White;
            }
            tbxFirstNameU.SelectionStart = tbxFirstNameU.Text.Length;
        }

        private void TbxFirstNameU_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxFirstNameU.Text))
            {
                e.Cancel = true;
                tbxFirstNameU.Focus();
                epFName.SetError(tbxFirstNameU, "Please enter employee first name !");
            }
            else
            {
                e.Cancel = false;
                epFName.SetError(tbxFirstNameU, null);

            }
        }

        private void TbxLastNameU_TextChanged(object sender, EventArgs e)
        {
            if (tbxLastNameU.Text.All(chr => char.IsLetter(chr)))
            {
                string oldText = tbxLastNameU.Text;
                tbxLastNameU.Text = oldText;

                tbxLastNameU.BackColor = System.Drawing.Color.White;
                tbxLastNameU.ForeColor = System.Drawing.Color.Black;
            }
            else
            {

                tbxLastNameU.BackColor = System.Drawing.Color.Red;
                tbxLastNameU.ForeColor = System.Drawing.Color.White;
            }
            tbxLastNameU.SelectionStart = tbxLastNameU.Text.Length;
        }

        private void TbxLastNameU_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxLastNameU.Text))
            {
                e.Cancel = true;
                tbxLastNameU.Focus();
                epLname.SetError(tbxLastNameU, "Please enter employee last name !");
            }
            else
            {
                e.Cancel = false;
                epLname.SetError(tbxLastNameU, null);

            }
        }

        private void TbxCellNumberU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbxCellNumberU_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxCellNumberU.Text))
            {
                e.Cancel = true;
                tbxCellNumberU.Focus();
                epCell.SetError(tbxCellNumberU, "Please enter employee cell number !");
            }
            else
            {
                e.Cancel = false;
                epCell.SetError(tbxCellNumberU, null);

            }
        }

        private void TbxEmailU_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxEmailU.Text))
            {
                e.Cancel = true;
                tbxEmailU.Focus();
                epEmail.SetError(tbxEmailU, "Please enter employee email !");
            }
            else
            {
                e.Cancel = false;
                epEmail.SetError(tbxEmailU, null);

            }
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (tbxEmailU.Text.Length > 0)
            {

                if (!rEMail.IsMatch(tbxEmailU.Text))
                {

                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tbxEmailU.SelectAll();

                    e.Cancel = true;

                }
            }
        }

        private void TbxIDu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbxIDu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxIDu.Text))
            {
                e.Cancel = true;
                tbxIDu.Focus();
                epID.SetError(tbxIDu, "Please enter valid ID !");
            }
            else
            {
                e.Cancel = false;
                epID.SetError(tbxIDu, null);

            }
        }

        private void TbxDebt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void TbxDebt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDebt.Text))
            {
                e.Cancel = true;
                tbxDebt.Focus();
                epDept.SetError(tbxDebt, "Please enter valid dept value !");
            }
            else
            {
                e.Cancel = false;
                epDept.SetError(tbxDebt, null);

            }
        }

        private void TbxLiters_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxLiters.Text))
            {
                e.Cancel = true;
                tbxLiters.Focus();
                epLiters.SetError(tbxLiters, "Please enter valid dept value !");
            }
            else
            {
                e.Cancel = false;
                epLiters.SetError(tbxLiters, null);

            }
        }

        private void TbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbxID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxID.Text))
            {
                e.Cancel = true;
                tbxID.Focus();
                epDelete.SetError(tbxID, "Please enter valid ID number !");
            }
            else
            {
                e.Cancel = false;
                epDelete.SetError(tbxID, null);

            }
        }

        private void TbxLiters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
