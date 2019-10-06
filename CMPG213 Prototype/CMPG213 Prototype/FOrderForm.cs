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
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\SGSDBF.mdf;Integrated Security=True";
        SqlConnection conn;
        public FOrderForm()
        {
            InitializeComponent();
        }
        
        private void BtnADD_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbOrAmt.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (cmbOrEmployee.SelectedItem == null)
            {
                epOrEmp.SetError(cmbOrEmployee, "Please select an item from the list!");
            }
            else
            {
                epOrEmp.Clear();
            }

            if (cmbOrFuel.SelectedItem == null)
            {
                epOrFuel.SetError(cmbOrFuel, "Please select an item from the list!");
            }
            else
            {
                epOrFuel.Clear();
            }

            DateTime todayDate = DateTime.Now;
            string td = todayDate.ToShortDateString();
            mcOr.MaxSelectionCount = 1;
            string recDate = mcOr.SelectionRange.Start.ToShortDateString();

            string sql = @"Insert Into FORDER (Emp_ID, Fuel_ID, Order_Date, Recieve_date, Amt_OrderdLiters )Values('" + cmbOrEmployee.SelectedItem + "','" + cmbOrFuel.SelectedItem + "','" + td + "', '" + recDate + "','" + txbOrAmt.Text + "')";
            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully");
                refresh();
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            txbOrAmt.Text = "";
            conn.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (cmbDelete.SelectedItem == null)
            {
                epDelete.SetError(cmbDelete, "Please select an item from the list!");
            }
            else
            {
                epDelete.Clear();
            }

            string sql = @"DELETE FROM FORDER WHERE Order_ID = '" + cmbDelete.SelectedItem + "'";
            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                adap.DeleteCommand = new SqlCommand(sql, conn);
                adap.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Record successfuly deleted!");
                refresh();
                comm.Dispose();
                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            conn.Close();
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
            comm1.Dispose();
            conn.Close();

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
            comm2.Dispose();
            conn.Close();

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
            refresh();
            comm3.Dispose();
            conn.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbUpEmployee.SelectedItem == null)
            {
                epUpEmp.SetError(cmbUpEmployee, "Please select an item from the list!");
            }
            else
            {
                epUpEmp.Clear();
            }

            if (cmbUpFuel.SelectedItem == null)
            {
                epUpFuel.SetError(cmbUpFuel, "Please select an item from the list!");
            }
            else
            {
                epUpFuel.Clear();
            }
            if (cmbUpOrder.SelectedItem == null)
            {
                epUpOrder.SetError(cmbUpOrder, "Please select an item from the list!");
            }
            else
            {
                epUpOrder.Clear();
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbUpAmt.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DateTime todayDate = DateTime.Now;
            mcUp.MaxSelectionCount = 1;
            string recDate = mcUp.SelectionRange.Start.ToString();

            string sql = @"UPDATE FORDER SET Emp_ID ='" + cmbUpEmployee.SelectedItem + "', Fuel_ID ='" + cmbUpFuel.SelectedItem + "', Recieve_Date ='" + recDate + "', Amount_Ordered ='" + txbUpAmt.Text + "' WHERE Order_ID = '" + cmbUpOrder.SelectedItem + "'";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                adap.UpdateCommand = new SqlCommand(sql, conn);
                adap.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Record successfuly updated!");
                refresh();
                comm.Dispose();
                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            conn.Close();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TxbOrAmt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbOrAmt.Text))
            {
                e.Cancel = true;
                txbOrAmt.Focus();
                epOrAmt.SetError(txbOrAmt, "Pleased enter a valid number! ");
            }
            else
            {
                e.Cancel = false;
                epOrAmt.SetError(txbOrAmt, null);
            }

        }

        private void TxbOrAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }

        private void TxbUpAmt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbUpAmt.Text))
            {
                e.Cancel = true;
                txbUpAmt.Focus();
                epUpAmt.SetError(txbUpAmt, "Pleased enter a valid number! ");
            }
            else
            {
                e.Cancel = false;
                epUpAmt.SetError(txbUpAmt, null);
            }
        }

        private void TxbUpAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        public void refresh()
        {
            conn.Close();
            conn.Open();
            SqlDataAdapter adap = new SqlDataAdapter();
            //string sql = "";
            adap.SelectCommand = new SqlCommand();
            //string sql = "Select * from FORDER";
            //SqlCommand comm = new SqlCommand(sql, conn);
            DataSet ds = new DataSet();
            adap.SelectCommand = new SqlCommand("Select * from FORDER");
            adap.SelectCommand.Connection = conn;
            adap.SelectCommand.ExecuteNonQuery();
            adap.Fill(ds, "FORDER");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "FORDER";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Form_Home_Page_FutureTech hp = new Form_Home_Page_FutureTech();
            hp.ShowDialog();
            this.Close();
        }
    }
}
