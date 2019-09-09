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
    public partial class AccountUpdateDel : Form
    {
        public AccountUpdateDel()
        {
            InitializeComponent();
        }
        SqlConnection CONN = new SqlConnection();





        private void AccountUpdateDel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stallionsDbDataSet.ACCOUNT' table. You can move, or remove it, as needed.
            this.aCCOUNTTableAdapter.Fill(this.stallionsDbDataSet.ACCOUNT);

            CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dewald\Desktop\CMPG223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");
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
           
            

            string query = @"SELECT * from ACCOUNT WHERE Acc_IDnum
 LIKE '%" + tbxID.Text + "%'";
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
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =D:\Akademie\CMPG_223\FutureTech Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security = True");
            string sName, sSurname, sID, sCellnr, sEmail;
            decimal dDebt;
            double Liters;

            sName = tbxFirstNameU.Text;
            sSurname = tbxLastNameU.Text;
            sID = tbxIDu.Text;
            sCellnr = tbxCellNumberU.Text;
            sEmail = tbxEmailU.Text;
            dDebt = Convert.ToDecimal(tbxDebt.Text);
            Liters = Convert.ToDouble(tbxLiters.Text);
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
    }
}
