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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();


        }
        SqlConnection CONN;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string sName = " ", sSurname = " ", sID = " ", sCellnr = " ", sEmail = " ", sql = "";
            SqlCommand comm;
            SqlDataAdapter adapter = new SqlDataAdapter();
            int length = tbxID.Text.Length;
            int lengthCell = tbxCellNumber.Text.Length;
            Boolean bAccount = true;

            if (tbxFirstName.Text == " ")
            {
                MessageBox.Show("First Name Required");
                tbxFirstName.Focus();
                bAccount = false;
            }

            else
            {

                sName = tbxFirstName.Text;



                if (tbxLastName.Text != " ")
                {
                    sSurname = tbxLastName.Text;

                }

                if (tbxLastName.Text != " ")
                {
                    sSurname = tbxLastName.Text;
                }
                else
                {
                    MessageBox.Show("LastName Required");
                    tbxLastName.Focus();
                    bAccount = false;
                }

                if ((length == 13) && (tbxID.Text != " "))
                {
                    sID = tbxID.Text;

                }
                else
                {
                    MessageBox.Show("ID required and must be 13 digits");
                    tbxID.Focus();
                    bAccount = false;
                }

                if ((lengthCell == 10) || (tbxCellNumber.Text != " "))
                {
                    sCellnr = tbxCellNumber.Text;
                }
                else
                {
                    MessageBox.Show("Cell required and must be 10 digits");
                    tbxCellNumber.Focus();
                    bAccount = false;

                }
                Regex pattern = new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$");
                if (pattern.IsMatch(tbxCellNumber.Text))
                {
                    MessageBox.Show("Phone Correct");
                }
                else
                {
                    MessageBox.Show("Invalid phone number");
                    bAccount = false;
                    tbxCellNumber.Focus();
                }

                if ((tbxEmail.Text != " ") || (!tbxEmail.Text.Contains('@') || !this.tbxEmail.Text.Contains('.')))
                {
                    sEmail = tbxEmail.Text;
                }
                else
                {
                    MessageBox.Show("Email incorrect");
                    tbxEmail.Focus();
                    bAccount = false;
                }




                if (bAccount == true)
                {

                    CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akademie\CMPG_223\FinalFinalFinal\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\SGSDBF.mdf;Integrated Security=True");

                    sEmail = tbxEmail.Text;
                }

                //CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dewald\Desktop\CMPG223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");

                sName = tbxFirstName.Text;
                sSurname = tbxLastName.Text;
                sID = tbxID.Text;
                sCellnr = tbxCellNumber.Text;
                sEmail = tbxEmail.Text;
                CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akademie\CMPG_223\FinalFinalFinal\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\SGSDBF.mdf;Integrated Security=True");



                CONN.Open();
                sql = @"Insert into ACCOUNT (Acc_FName,Acc_LName,Acc_Email,Acc_Cellnum,Acc_IDnum) values('" + sName + "','" + sSurname + "','" + sEmail + "','" + sCellnr + "','" + sID + "') ";


                comm = new SqlCommand(sql, CONN);

                adapter.InsertCommand = new SqlCommand(sql, CONN);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Account Added");
                CONN.Close();
                comm.Dispose();

                this.Close();

                /*else
                {
                    MessageBox.Show("Try Again");
                }*/

            }

            /*private void AccountForm_Load(object sender, EventArgs e)
            {

            }*/
        }

        private void TbxFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxFirstName.Text))
            {
                e.Cancel = true;
                tbxFirstName.Focus();
                errorProvider1.SetError(tbxFirstName, "Please enter valid Name !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbxFirstName , null);

            }
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void TbxLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxLastName.Text))
            {
                e.Cancel = true;
                tbxLastName.Focus();
                errorProvider2.SetError(tbxLastName, "Please enter valid Last Name !");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(tbxLastName, null);

            }
        }

        private void TbxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxEmail.Text))
            {
                e.Cancel = true;
                tbxEmail.Focus();
                errorProvider3.SetError(tbxEmail, "Please enter  email !");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(tbxEmail, null);

            }
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (tbxEmail.Text.Length > 0)
            {

                if (!rEMail.IsMatch(tbxEmail.Text))
                {

                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tbxEmail.SelectAll();

                    e.Cancel = true;

                }

            }
        }

        private void TbxCellNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxCellNumber.Text))
            {
                e.Cancel = true;
                tbxCellNumber.Focus();
                errorProvider4.SetError(tbxCellNumber, "Please enter valid Number !");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(tbxCellNumber, null);

            }

        }

        private void TbxID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxID.Text))
            {
                e.Cancel = true;
                tbxFirstName.Focus();
                errorProvider5.SetError(tbxID, "Please enter valid  !");
            }
            else
            {
                e.Cancel = false;
                errorProvider5.SetError(tbxID, null);

            }
        }

        private void TbxCellNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxCellNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (tbxFirstName.Text.All(chr => char.IsLetter(chr)))
            {
                string oldText = tbxFirstName.Text;
                tbxFirstName.Text = oldText;

                tbxFirstName.BackColor = System.Drawing.Color.White;
                tbxFirstName.ForeColor = System.Drawing.Color.Black;
            }
            else
            {

                tbxFirstName.BackColor = System.Drawing.Color.Red;
                tbxFirstName.ForeColor = System.Drawing.Color.White;
            }
            tbxFirstName.SelectionStart = tbxFirstName.Text.Length;
        }

        private void TbxLastName_TextChanged(object sender, EventArgs e)
        {
            if (tbxLastName.Text.All(chr => char.IsLetter(chr)))
            {
                string oldText = tbxLastName.Text;
                tbxLastName.Text = oldText;

                tbxLastName.BackColor = System.Drawing.Color.White;
                tbxLastName.ForeColor = System.Drawing.Color.Black;
            }
            else
            {

                tbxLastName.BackColor = System.Drawing.Color.Red;
                tbxLastName.ForeColor = System.Drawing.Color.White;
            }
            tbxLastName.SelectionStart = tbxLastName.Text.Length;
        }
    }
}
