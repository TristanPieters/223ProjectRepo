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
    public partial class Manage_Employees : Form
    {
        public Manage_Employees()
        {
            InitializeComponent();
        }
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True";
        SqlConnection conn;

        string fName, lName, job, email, username, password, shift;
        int cellNr = 0;


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            fName = txbEmp_FName.Text;
            lName = txbEmp_LName.Text;
            job = txbEmp_Job.Text;
            email = txbEmp_Email.Text;
            username = txbShiftTime.Text;
            password = txbEmp_Password.Text;
            shift = txbShiftTime.Text;
            cellNr = int.Parse(txbEmp_CellNum.Text);
            string sql = @"Insert Into EMPLOYEE (ShiftTime, Emp_FName, Emp_LName, Emp_CellNum, Emp_JOB, Emp_Email, Emp_Username, Emp_Password)Values('" + shift + "','" + fName + "','" + lName + "','" + cellNr + "','" + job + "','" + email + "','" + username + "','" + password + "')";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql,conn);
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
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            fName = txbEmp_FName.Text;
            lName = txbEmp_LName.Text;
            job = txbEmp_Job.Text;
            email = txbEmp_Email.Text;
            username = txbShiftTime.Text;
            password = txbEmp_Password.Text;
            shift = txbShiftTime.Text;
            cellNr = int.Parse(txbEmp_CellNum.Text);
            string sql = @"UPDATE EMPLOYEE (ShiftTime, Emp_FName, Emp_LName, Emp_CellNum, Emp_JOB, Emp_Email, Emp_Username, Emp_Password)Values('" + shift + "','" + fName + "','" + lName + "','" + cellNr + "','" + job + "','" + email + "','" + username + "','" + password + "')";

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
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            fName = txbEmp_FName.Text;
            lName = txbEmp_LName.Text;
            string sql = @"Delete From EMPLOYEE Where Emp_FName = '" + fName + "' AND Emp_LName = '" + lName + "'";
            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                adap.DeleteCommand = new SqlCommand(sql, conn);
                adap.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Record successfuly deleted!");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Manage_Employees_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constring);
        }
    }
}
