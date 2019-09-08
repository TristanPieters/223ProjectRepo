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
        //SqlDataAdapter adapter;


        private void AccountUpdateDel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stallionsDbDataSet.ACCOUNT' table. You can move, or remove it, as needed.
            this.aCCOUNTTableAdapter.Fill(this.stallionsDbDataSet.ACCOUNT);

            CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dewald\Desktop\CMPG223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {
       /*     con.Open();
            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @" DELETE FROM Account WHERE LastName ='" + textBox1.Text + "'"";
 command = new SqlCommand(sql, con);
            DataSet ds = new DataSet();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery(); //Deletes from database, Adapter
            makes changes

 con.Close();*/
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
    }
}
