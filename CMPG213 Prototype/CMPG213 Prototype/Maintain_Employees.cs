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
using System.Globalization;

namespace CMPG213_Prototype
{
    public partial class Maintain_Employees : Form
    {
        public Maintain_Employees()
        {
            InitializeComponent();
        }
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\SGSDBF.mdf;Integrated Security=True";
        SqlConnection conn;

        string fName, lName, job, email, username, password, shift, cellNr;

        private void TxbEmp_LNameAdd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmp_LNameAdd.Text))
            {
                e.Cancel = true;
                txbEmp_LNameAdd.Focus();
                epLname.SetError(txbEmp_LNameAdd, "Please enter employee last name !");
            }
            else
            {
                e.Cancel = false;
                epLname.SetError(txbEmp_LNameAdd, null);

            }
        }


        private void TxbEmp_CellNumAdd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmp_CellNumAdd.Text))
            {
                e.Cancel = true;
                txbEmp_CellNumAdd.Focus();
                epCell.SetError(txbEmp_CellNumAdd, "Please enter employee cell number !");
            }
            else
            {
                e.Cancel = false;
                epCell.SetError(txbEmp_CellNumAdd, null);

            }
           
        }

        private void TxbEmp_CellNumAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxbEmp_JobAdd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmp_JobAdd.Text))
            {
                e.Cancel = true;
                txbEmp_JobAdd.Focus();
                epJob.SetError(txbEmp_JobAdd, "Please enter employee job description !");
            }
            else
            {
                e.Cancel = false;
                epJob.SetError(txbEmp_JobAdd, null);

            }
        }

        private void TxbEmp_EmailAdd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmp_EmailAdd.Text))
            {
                e.Cancel = true;
                txbEmp_EmailAdd.Focus();
                epEmail.SetError(txbEmp_EmailAdd, "Please enter employee email !");
            }
            else
            {
                e.Cancel = false;
                epEmail.SetError(txbEmp_EmailAdd, null);

            }
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txbEmp_EmailAdd.Text.Length > 0)
            {

                if (!rEMail.IsMatch(txbEmp_EmailAdd.Text))
                {

                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txbEmp_EmailAdd.SelectAll();

                    e.Cancel = true;

                }

            }
        }


        private void TxbEmp_FNameAdd_TextChanged(object sender, EventArgs e)
        {
            if (txbEmp_FNameAdd.Text.All(chr => char.IsLetter(chr)))
            {
                string oldText = txbEmp_FNameAdd.Text;
                txbEmp_FNameAdd.Text = oldText;

                txbEmp_FNameAdd.BackColor = System.Drawing.Color.White;
                txbEmp_FNameAdd.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                
                txbEmp_FNameAdd.BackColor = System.Drawing.Color.Red;
                txbEmp_FNameAdd.ForeColor = System.Drawing.Color.White;
            }
            txbEmp_FNameAdd.SelectionStart = txbEmp_FNameAdd.Text.Length;
        }

        private void TxbEmp_LNameAdd_TextChanged(object sender, EventArgs e)
        {
            if (txbEmp_LNameAdd.Text.All(chr => char.IsLetter(chr)))
            {
                string oldText = txbEmp_LNameAdd.Text;
                txbEmp_LNameAdd.Text = oldText;

                txbEmp_LNameAdd.BackColor = System.Drawing.Color.White;
                txbEmp_LNameAdd.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                txbEmp_LNameAdd.BackColor = System.Drawing.Color.Red;
                txbEmp_LNameAdd.ForeColor = System.Drawing.Color.White;
            }
            txbEmp_LNameAdd.SelectionStart = txbEmp_LNameAdd.Text.Length;
        }

        private void TxbEmp_JobAdd_TextChanged(object sender, EventArgs e)
        {
            if (txbEmp_JobAdd.Text.All(chr => char.IsLetter(chr)))
            {
                string oldText = txbEmp_JobAdd.Text;
                txbEmp_JobAdd.Text = oldText;

                txbEmp_JobAdd.BackColor = System.Drawing.Color.White;
                txbEmp_JobAdd.ForeColor = System.Drawing.Color.Black;
            }
            else
            {

                txbEmp_JobAdd.BackColor = System.Drawing.Color.Red;
                txbEmp_JobAdd.ForeColor = System.Drawing.Color.White;
            }
            txbEmp_FNameAdd.SelectionStart = txbEmp_FNameAdd.Text.Length;
        }

        private void TxbEmp_FNameAdd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmp_FNameAdd.Text))
            {
                e.Cancel = true;
                txbEmp_FNameAdd.Focus();
                epFname.SetError(txbEmp_FNameAdd, "Please enter employee first name !");
            }
            else
            {
                e.Cancel = false;
                epFname.SetError(txbEmp_FNameAdd, null);

            }
        }

        private void TxbEmp_FNameUp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmp_FNameUp.Text))
            {
                e.Cancel = true;
                txbEmp_FNameUp.Focus();
                epUpFName.SetError(txbEmp_FNameUp, "Please enter employee first name !");
            }
            else
            {
                e.Cancel = false;
                epUpFName.SetError(txbEmp_FNameUp, null);

            }
        }

        private void TxbEmp_FNameUp_TextChanged(object sender, EventArgs e)
        {
            if (txbEmp_FNameUp.Text.All(chr => char.IsLetter(chr)))
            {
                string oldText = txbEmp_FNameUp.Text;
                txbEmp_FNameUp.Text = oldText;

                txbEmp_FNameUp.BackColor = System.Drawing.Color.White;
                txbEmp_FNameUp.ForeColor = System.Drawing.Color.Black;
            }
            else
            {

                txbEmp_FNameUp.BackColor = System.Drawing.Color.Red;
                txbEmp_FNameUp.ForeColor = System.Drawing.Color.White;
            }
            txbEmp_FNameUp.SelectionStart = txbEmp_FNameUp.Text.Length;
        }

        private void TxbEmp_LNameUp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmp_LNameUp.Text))
            {
                e.Cancel = true;
                txbEmp_LNameUp.Focus();
                epUpLName.SetError(txbEmp_LNameUp, "Please enter employee first name !");
            }
            else
            {
                e.Cancel = false;
                epUpLName.SetError(txbEmp_LNameUp, null);

            }
        }

        private void TxbEmp_LNameUp_TextChanged(object sender, EventArgs e)
        {
            if (txbEmp_LNameUp.Text.All(chr => char.IsLetter(chr)))
            {
                string oldText = txbEmp_LNameUp.Text;
                txbEmp_LNameUp.Text = oldText;

                txbEmp_LNameUp.BackColor = System.Drawing.Color.White;
                txbEmp_LNameUp.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                txbEmp_LNameUp.BackColor = System.Drawing.Color.Red;
                txbEmp_LNameUp.ForeColor = System.Drawing.Color.White;
            }
            txbEmp_LNameUp.SelectionStart = txbEmp_LNameUp.Text.Length;
        }


        private void TxbEmp_CellNumUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxbEmp_JobUp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmp_JobUp.Text))
            {
                e.Cancel = true;
                txbEmp_JobUp.Focus();
                epUpJob.SetError(txbEmp_JobUp, "Please enter employee job description !");
            }
            else
            {
                e.Cancel = false;
                epUpJob.SetError(txbEmp_JobUp, null);

            }
        }

        private void TxbEmp_JobUp_TextChanged(object sender, EventArgs e)
        {
            if (txbEmp_JobUp.Text.All(chr => char.IsLetter(chr)))
            {
                string oldText = txbEmp_JobUp.Text;
                txbEmp_JobUp.Text = oldText;

                txbEmp_JobUp.BackColor = System.Drawing.Color.White;
                txbEmp_JobUp.ForeColor = System.Drawing.Color.Black;
            }
            else
            {

                txbEmp_JobUp.BackColor = System.Drawing.Color.Red;
                txbEmp_JobUp.ForeColor = System.Drawing.Color.White;
            }
            txbEmp_JobUp.SelectionStart = txbEmp_JobUp.Text.Length;
        }

        private void TxbEmp_EmailUp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmp_EmailUp.Text))
            {
                e.Cancel = true;
                txbEmp_EmailUp.Focus();
                epUpEmail.SetError(txbEmp_EmailUp, "Please enter employee email !");
            }
            else
            {
                e.Cancel = false;
                epUpEmail.SetError(txbEmp_EmailUp, null);

            }
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txbEmp_EmailUp.Text.Length > 0)
            {

                if (!rEMail.IsMatch(txbEmp_EmailUp.Text))
                {

                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txbEmp_EmailUp.SelectAll();

                    e.Cancel = true;

                }

            }
        }




        /*      private void btnChange_Click(object sender, EventArgs e)
              {

              }*/

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$");
            if (pattern.IsMatch(txbEmp_CellNumAdd.Text))
            {
                MessageBox.Show("Cell phone number is valid");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                txbEmp_CellNumAdd.Focus();
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbEmp_EmailAdd.Text, "Please enter employee email !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbEmp_JobAdd.Text, "Please enter employee job description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbEmp_FNameAdd.Text, "Please enter  employee first name !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbEmp_LNameAdd.Text, "Please enter employee last name!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbEmp_CellNumAdd.Text, "Please enter employee cell number!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            fName = txbEmp_FNameAdd.Text;
            lName = txbEmp_LNameAdd.Text;
            cellNr = txbEmp_CellNumAdd.Text;
            job = txbEmp_JobAdd.Text;
            email = txbEmp_EmailAdd.Text;
            

            string sql = @"Insert Into EMPLOYEE (Emp_FName, Emp_LName, Emp_CellNum, Emp_JOB, Emp_Email)Values('" + fName + "','" + lName + "','" + cellNr + "','" + job + "','" + email + "')";

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

            txbEmp_FNameAdd.Text = "";
            txbEmp_LNameAdd.Text = "";
            txbEmp_CellNumAdd.Text = "";
            txbEmp_JobAdd.Text = "";
            txbEmp_EmailAdd.Text = "";

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$");
            if (pattern.IsMatch(txbEmp_CellNumUp.Text))
            {
                MessageBox.Show("Cell phone number is valid");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                txbEmp_CellNumUp.Focus();
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbEmp_EmailUp.Text, "Please enter employee email !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbEmp_JobUp.Text, "Please enter employee job description !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbEmp_FNameUp.Text, "Please enter  employee first name !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbEmp_LNameUp.Text, "Please enter employee last name!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbEmp_CellNumUp.Text, "Please enter employee cell number!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (cmbUpdate.SelectedItem == null)
            {
                epUpEmp_ID.SetError(cmbUpdate, "Please select an item from the list!");
                MessageBox.Show("Please select an item from the list!");
                cmbUpdate.Focus();
            }
            else
            {
                epUpEmp_ID.Clear();
            }

            
            fName = txbEmp_FNameUp.Text;
            lName = txbEmp_LNameUp.Text;
            cellNr = txbEmp_CellNumUp.Text;
            job = txbEmp_JobUp.Text;
            email = txbEmp_EmailUp.Text;
            

            string sql = @"UPDATE EMPLOYEE SET Emp_FName = '" + fName + "', Emp_LName = '" + lName + "', Emp_CellNum = '" + cellNr + "', Emp_JOB = '" + job + "', Emp_Email = '" + email +  "' WHERE Emp_ID = '" + cmbUpdate.SelectedItem + "'";


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

            txbEmp_FNameUp.Text = "";
            txbEmp_LNameUp.Text = "";
            txbEmp_CellNumUp.Text = "";
            txbEmp_JobUp.Text = "";
            txbEmp_EmailUp.Text = "";
           
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (cmbDelete.SelectedItem == null)
            {
                epDelete.SetError(cmbDelete, "Please select an item from the combobox !");
                MessageBox.Show("Please select an item from the combobox!");
            }
            else
            {
                epDelete.Clear();
            }
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