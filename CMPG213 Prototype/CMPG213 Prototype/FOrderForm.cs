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
    public partial class FOrderForm : Form
    {
        public FOrderForm()
        {
            InitializeComponent();
        }
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True";
        string amt;
        SqlConnection conn;
        private void BtnADD_Click(object sender, EventArgs e)
        {
            DateTime todayDate = DateTime.Now;
            string sql = @"Insert Into FORDER (Emp_ID, Fuel_ID, Order_Date, Recieve_date, Amount_Ordered )Values('" + cmbOrEmployee.SelectedItem + "','" + cmbOrFuel.SelectedItem + "','" + todayDate + "', '" + txbOrDate.Text + "','" + txbOrAmt.Text + "')";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();
                adap.Fill(ds, "FORDER");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "FORDER";
                MessageBox.Show("Record inserted successfully");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            txbOrAmt.Text = "";
            txbOrDate.Text = "";

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM FORDER WHERE Order_ID = '" + cmbDelete.SelectedItem + "'";
            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                adap.DeleteCommand = new SqlCommand(sql, conn);
                adap.DeleteCommand.ExecuteNonQuery();
                adap.Fill(ds, "FORDER");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "FORDER";
                MessageBox.Show("Record successfuly deleted!");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void FOrderForm_Load(object sender, EventArgs e)
        {
            //Employee comboBox
            conn = new SqlConnection(constring);
            string sql1 = @"SELECT Emp_ID FROM EMPLOYEE";
            SqlDataReader reader1;
            SqlCommand comm1 = new SqlCommand(sql1, conn);
            conn.Open();
            reader1 = comm1.ExecuteReader();

            while (reader1.Read())
            {
                string output = Convert.ToString(reader1.GetValue(0));
                cmbOrEmployee.Items.Add(output);
                cmbUpEmployee.Items.Add(output);
            }

            //Fuel description comboBox
            string sql2 = @"SELECT Fuel_ID FROM FUEL";
            SqlDataReader reader2;
            SqlCommand comm2 = new SqlCommand(sql2, conn);
            conn.Open();
            reader2 = comm2.ExecuteReader();

            while (reader2.Read())
            {
                string output = Convert.ToString(reader2.GetValue(0));
                cmbOrFuel.Items.Add(output);
                cmbUpFuel.Items.Add(output);
            }

            //Order_ID comboBox
            string sql3 = @"SELECT Order_ID FROM FORDER";
            SqlDataReader reader3;
            SqlCommand comm3 = new SqlCommand(sql3, conn);
            conn.Open();
            reader3 = comm3.ExecuteReader();

            while (reader3.Read())
            {
                string output = Convert.ToString(reader3.GetValue(0));
                cmbUpOrder.Items.Add(output);
                cmbDelete.Items.Add(output);
            }

            comm1.Dispose();
            comm2.Dispose();
            comm3.Dispose();
            conn.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DateTime todayDate = DateTime.Now;
            string sql = @"UPDATE FORDER SET Emp_ID ='" + cmbUpEmployee.SelectedItem + "', Fuel_ID ='" + cmbUpFuel.SelectedItem + "', Recieve_Date ='" + txbUpDate.Text + "', Amount_Ordered ='" + txbUpAmt.Text + "' WHERE Order_ID = '" + cmbUpOrder.SelectedItem + "'";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                adap.UpdateCommand = new SqlCommand(sql, conn);
                adap.UpdateCommand.ExecuteNonQuery();
                adap.Fill(ds, "FORDER");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "FORDER";
                MessageBox.Show("Record successfuly updated!");
                comm.Dispose();
                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
