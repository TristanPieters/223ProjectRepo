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
                CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dewald\Desktop\CMPG223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDBFF.mdf;Integrated Security=True");
                string query = "Select Emp_FName, Emp_ID , Emp_LName from EMPLOYEE";
                SqlCommand comm = new SqlCommand(query, CONN);
                comm.CommandText = query;
                CONN.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    cmbEmployee.Items.Add(reader["Emp_FName"].ToString() + " " + reader["Emp_LName"].ToString());
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
             
        }
    }
}
