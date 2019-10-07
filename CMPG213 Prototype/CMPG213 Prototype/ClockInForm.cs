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
    public partial class ClockInForm : Form
    {
        public ClockInForm()
        {
            InitializeComponent();
        }

        private void ClockInForm_Load(object sender, EventArgs e)
        {
            SqlConnection CONN = new SqlConnection();
            try
            {
                CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akademie\CMPG_223\FinalFinalFinal\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\SGSDBF.mdf;Integrated Security=True");
                string query = "Select Emp_FName, Emp_ID , Emp_LName from EMPLOYEE";
                SqlCommand comm = new SqlCommand(query, CONN);
                comm.CommandText = query;
                CONN.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cmbEmployee.Items.Add(reader["Emp_ID"].ToString() + " " + reader["Emp_FName"].ToString() + " " + reader["Emp_LName"].ToString());
                    cmbEmployee.ValueMember = reader["Emp_ID"].ToString();
                    cmbEmployee.DisplayMember = reader["Emp_FName"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        private void BtnClockIn_Click(object sender, EventArgs e)
        {
            DateTime dStartTime, dEndTime , dDate;
            string sql , id , cmbtext;
            SqlCommand comm;
            SqlDataAdapter adapter = new SqlDataAdapter();
            dDate = DateTime.Now;

            dtTimeIN.Format = DateTimePickerFormat.Custom;
            dtTimeOut.CustomFormat = "hh:mm:ss";
            dtTimeOut.Format = DateTimePickerFormat.Custom;
            dtTimeOut.CustomFormat = "hh:mm:ss";

            dStartTime = dtTimeIN.Value;
            dEndTime = dtTimeOut.Value;

            cmbtext = cmbEmployee.Text;
            id = cmbtext.Substring(0, cmbtext.IndexOf(" "));



            SqlConnection CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akademie\CMPG_223\FinalFinalFinal\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\SGSDBF.mdf;Integrated Security=True");


            
            CONN.Open();
            sql = @"Insert into WSHIFT (Shift_StartT,Shift_EndT,Shift_Date,Emp_ID) values('" + dStartTime+ "','" + dEndTime + "','" + dDate + "','" + Convert.ToInt32(id)  + "') ";


            comm = new SqlCommand(sql, CONN);

            adapter.InsertCommand = new SqlCommand(sql, CONN);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Time added");
            CONN.Close();
            comm.Dispose();

            this.Close(); 


        }

        private void CmbEmployee_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbEmployee.Text))
            {
                e.Cancel = true;
                 cmbEmployee.Focus();
                errorProvider1.SetError(cmbEmployee, "Please Select valid Employee !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbEmployee, null);

            }

        }
    }
}
