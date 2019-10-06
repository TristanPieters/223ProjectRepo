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
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akademie\CMPG_223\NEWREPO\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\SGSDBF.mdf;Integrated Security=True";
        SqlConnection conn;
        string detail;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbAdd.Text, "Please enter valid reward description.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            detail = txbAdd.Text;

            string sql = @"Insert Into REWARD (Reward_Description) Values('" + detail + "')";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();
                adap.Fill(ds, "REWARD");
                MessageBox.Show("Record inserted successfully");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            txbAdd.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbUpdate.SelectedItem == null)
            {
                errProvComboxUpdate.SetError(cmbUpdate, "Please select an item from the combobox !");
                MessageBox.Show("Please select an item from the combobox!");
            }
            else
            {
                errProvComboxUpdate.Clear();
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbUpdate.Text, "Please enter valid reward description.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            detail = txbUpdate.Text;
            string sql = @"UPDATE REWARD SET Reward_Detail ='" + detail + "' WHERE Reward_ID = '" + cmbUpdate.SelectedItem + "'";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                adap.UpdateCommand = new SqlCommand(sql, conn);
                adap.UpdateCommand.ExecuteNonQuery();
                adap.Fill(ds, "REWARD");
                MessageBox.Show("Record successfuly updated!");
                comm.Dispose();
                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            txbUpdate.Text = "";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (cmbDelete.SelectedItem == null)
            {
                errProvComboxDelete.SetError(cmbDelete, "Please select an item from the combobox !");
                MessageBox.Show("Please select an item from the combobox!");
            }
            else
            {
                errProvComboxDelete.Clear();
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //MessageBox.Show(txbDelete.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            string sql = @"DELETE FROM REWARD WHERE Reward_ID = '" + cmbDelete.SelectedItem + "'";
            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                adap.DeleteCommand = new SqlCommand(sql, conn);
                adap.DeleteCommand.ExecuteNonQuery();
                adap.Fill(ds, "REWARD");
                MessageBox.Show("Record successfuly deleted!");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Maintain_Rewards_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constring);
            string sql = @"SELECT Reward_ID FROM REWARD";
            SqlDataReader reader;
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string output = Convert.ToString(reader.GetValue(0));
                cmbUpdate.Items.Add(output);
                cmbDelete.Items.Add(output);
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

        private void txbAdd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbAdd.Text))
            {
                e.Cancel = true;
                txbAdd.Focus();
                errProvAddRewDesc.SetError(txbAdd, "Please enter valid reward description !");
            }
            else
            {
                e.Cancel = false;
                errProvAddRewDesc.SetError(txbAdd, null);

            }
        }

        private void txbUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbUpdate.Text))
            {
                e.Cancel = true;
                txbUpdate.Focus();
                errProvTboxUpd.SetError(txbUpdate, "Please enter valid reward description !");
            }
            else
            {
                e.Cancel = false;
                errProvTboxUpd.SetError(txbUpdate, null);

            }
        }

       /* private void txbDelete_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbDelete.Text))
            {
                e.Cancel = true;
                txbDelete.Focus();
                errProvTboxDelete.SetError(txbDelete, "Please enter valid reward description !");
            }
            else
            {
                e.Cancel = false;
                errProvTboxDelete.SetError(txbDelete, null);
            }
        }
        */
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
