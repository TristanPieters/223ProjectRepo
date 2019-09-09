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
            string sName, sSurname, sID, sCellnr, sEmail , sql="";
            SqlCommand comm;
            SqlDataAdapter adapter = new SqlDataAdapter();


            sName = tbxFirstName.Text;
            sSurname = tbxLastName.Text;
            sID = tbxID.Text;
            sCellnr = tbxCellNumber.Text;
            sEmail = tbxEmail.Text;
            CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dewald\Desktop\CMPG223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");

            CONN.Open();
            sql = @"Insert into ACCOUNT (Acc_FName,Acc_LName,Acc_Email,Acc_Cellnum,Acc_IDnum) values('"+ sName + "','" + sSurname + "','" + sEmail + "','" + sCellnr + "','" + sID + "') ";
          //  @"Insert Into EMPLOYEE (ShiftTime, Emp_FName, Emp_LName, Emp_CellNum, Emp_JOB, Emp_Email, Emp_Username, Emp_Password)Values('" + shift + "','" + fName + "','" + lName + "','" + cellNr + "','" + job + "','" + email + "','" + username + "','" + password + "')";

            comm = new SqlCommand(sql, CONN);

            adapter.InsertCommand = new SqlCommand(sql,CONN);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Account Added");
            CONN.Close();
            comm.Dispose();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {


            
;          
        }
    }
}
