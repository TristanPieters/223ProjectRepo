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
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adap;

        String fName, lName, job, email, username, password;
        DateTime shift;
        int cellNr = 0;


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            String fName = txbEmp_FName.Text, lName = txbEmp_LName.Text, job = txbEmp_Job.Text, email = txbEmp_Email.Text, username = txbShiftTime.Text, password = txbEmp_Password.Text, shift = txbShiftTime.Text;
            int cellNr = int.Parse(txbEmp_CellNum.Text);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(@"Insert Into EMPLOYEE (ShiftTime, Emp_FName, Emp_LName, Emp_CellNum, Emp_JOB, Emp_Email, Emp_Username, Emp_Password)Values('" + shift + "','" + fName + "','" + lName + "','" + cellNr + "','" + job + "','" + email + "','" + username + "','" + password + "')", conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            String fName = txbEmp_FName.Text, lName = txbEmp_LName.Text, job = txbEmp_Job.Text, email = txbEmp_Email.Text, username = txbShiftTime.Text, password = txbEmp_Password.Text, shift = txbShiftTime.Text;
            int cellNr = int.Parse(txbEmp_CellNum.Text);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(@"UPDATE EMPLOYEE (ShiftTime, Emp_FName, Emp_LName, Emp_CellNum, Emp_JOB, Emp_Email, Emp_Username, Emp_Password)Values('" + shift + "','" + fName + "','" + lName + "','" + cellNr + "','" + job + "','" + email + "','" + username + "','" + password + "')", conn);
                SqlDataAdapter adap = new SqlDataAdapter();
                adap.DeleteCommand = command;
                adap.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Record successfuly deleted!");
                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            String fName = txbEmp_FName.Text, lName = txbEmp_LName.Text;
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Delete From EMPLOYEE Where Emp_FName = '" +fName+ "' AND Emp_LName = '" + lName + "'" , conn);
                SqlDataAdapter adap = new SqlDataAdapter();
                adap.DeleteCommand = command;
                adap.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Record successfuly deleted!");
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
            
        }
    }
}
