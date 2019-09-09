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
    public partial class Maintain_Employees : Form
    {
        public Maintain_Employees()
        {
            InitializeComponent();
        }
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True";
        SqlConnection conn;

        string fName, lName, job, email, username, password, shift, cellNr;

  /*      private void btnChange_Click(object sender, EventArgs e)
        {

        }*/

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            shift = txbShiftTimeAdd.Text;
            fName = txbEmp_FNameAdd.Text;
            lName = txbEmp_LNameAdd.Text;
            password = txbEmp_PasswordAdd.Text;
            cellNr = txbEmp_CellNumAdd.Text;
            job = txbEmp_JobAdd.Text;
            email = txbEmp_EmailAdd.Text;
            username = txbUsernameAdd.Text;

            string sql = @"Insert Into EMPLOYEE (ShiftTime, Emp_FName, Emp_LName, Emp_CellNum, Emp_JOB, Emp_Email, Emp_Username, Emp_Password)Values('" + shift + "','" + fName + "','" + lName + "','" + cellNr + "','" + job + "','" + email + "','" + username + "','" + password + "')";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();               
                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();
                adap.Fill(ds, "EMPLOYEE");
                dgvEmployee.DataSource = ds;
                dgvEmployee.DataMember = "EMPLOYEE";
                MessageBox.Show("Record inserted successfully");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            txbShiftTimeAdd.Text = "";
            txbEmp_FNameAdd.Text = "";
            txbEmp_LNameAdd.Text = "";
            txbEmp_PasswordAdd.Text = "";
            txbEmp_CellNumAdd.Text = "";
            txbEmp_JobAdd.Text = "";
            txbEmp_EmailAdd.Text = "";
            txbUsernameAdd.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            shift = txbShiftTimeUp.Text;
            fName = txbEmp_FNameUp.Text;
            lName = txbEmp_LNameUp.Text;
            password = txbEmp_PasswordUp.Text;
            cellNr = txbEmp_CellNumUp.Text;
            job = txbEmp_JobUp.Text;
            email = txbEmp_EmailUp.Text;
            username = txbUsernameUp.Text;

            string sql = @"UPDATE EMPLOYEE SET ShiftTime ='" + shift + "', Emp_FName = '" + fName + "', Emp_LName = '" + lName + "', Emp_CellNum = '" + cellNr + "', Emp_JOB = '" + job + "', Emp_Email = '" + email + "', Emp_Username = '" + username + "', Emp_Password = '" + password + "' WHERE Emp_ID = '" + cmbUpdate.SelectedItem + "'";


            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                adap.UpdateCommand = new SqlCommand(sql, conn);
                adap.UpdateCommand.ExecuteNonQuery();
                adap.Fill(ds, "EMPLOYEE");
                dgvEmployee.DataSource = ds;
                dgvEmployee.DataMember = "EMPLOYEE";
                MessageBox.Show("Record successfuly updated!");
                comm.Dispose();
                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            txbShiftTimeUp.Text = "";
            txbEmp_FNameUp.Text = "";
            txbEmp_LNameUp.Text = "";
            txbEmp_PasswordUp.Text = "";
            txbEmp_CellNumUp.Text = "";
            txbEmp_JobUp.Text = "";
            txbEmp_EmailUp.Text = "";
            txbUsernameUp.Text = "";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM EMPLOYEE WHERE Emp_ID = '" + cmbDelete.SelectedItem + "'";
            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                adap.DeleteCommand = new SqlCommand(sql, conn);
                adap.DeleteCommand.ExecuteNonQuery();
                adap.Fill(ds, "EMPLOYEE");
                dgvEmployee.DataSource = ds;
                dgvEmployee.DataMember = "EMPLOYEE";
                MessageBox.Show("Record successfuly deleted!");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Home_Page_FutureTech home = new Form_Home_Page_FutureTech();
            home.ShowDialog();
        }

        private void Maintain_Employees_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constring);
            string sql = @"SELECT Emp_ID FROM EMPLOYEE";
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
    }
}