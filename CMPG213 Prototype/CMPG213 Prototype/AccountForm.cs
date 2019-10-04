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

                    CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dewald\Desktop\CMPG223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDBFF.mdf;Integrated Security=True");

                    sEmail = tbxEmail.Text;
                }

                //CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dewald\Desktop\CMPG223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");

                sName = tbxFirstName.Text;
                sSurname = tbxLastName.Text;
                sID = tbxID.Text;
                sCellnr = tbxCellNumber.Text;
                sEmail = tbxEmail.Text;
                CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");



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
    }
}
