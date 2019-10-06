﻿using System;
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
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True";
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

        private void TxbEmp_PasswordAdd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmp_PasswordAdd.Text))
            {
                e.Cancel = true;
                txbEmp_PasswordAdd.Focus();
                epPassword.SetError(txbEmp_PasswordAdd, "Please enter employee password !");
            }
            else
            {
                e.Cancel = false;
                epPassword.SetError(txbEmp_PasswordAdd, null);

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

        private void TxbUsernameAdd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbUsernameAdd.Text))
            {
                e.Cancel = true;
                txbUsernameAdd.Focus();
                epUsername.SetError(txbUsernameAdd, "Please enter employee last name !");
            }
            else
            {
                e.Cancel = false;
                epUsername.SetError(txbUsernameAdd, null);

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

        private void TxbShiftTimeAdd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbShiftTimeAdd.Text))
            {
                e.Cancel = true;
                txbShiftTimeAdd.Focus();
                epTime.SetError(txbShiftTimeAdd, "Please enter employee shift time !");
            }
            else
            {
                e.Cancel = false;
                epTime.SetError(txbShiftTimeAdd, null);

            }
        }

        /*      private void btnChange_Click(object sender, EventArgs e)
              {

              }*/

        public bool ValidateTime(string time)
        {
            DateTime ignored;
            return DateTime.TryParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out ignored);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string time = txbShiftTimeAdd.Text;
            ValidateTime(time);
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbShiftTimeAdd.Text, "Please enter employee shift time !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbUsernameAdd.Text, "Please enter employee username !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
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
                MessageBox.Show(txbEmp_PasswordAdd.Text, "Please enter employee password!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txbEmp_CellNumAdd.Text, "Please enter employee cell number!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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