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
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =D:\Akademie\CMPG_223\FutureTech Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDBFF.mdf; Integrated Security = True");
            string sql = @"Select * From EMPLOYEE";
            SqlDataReader reader;
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string output = Convert.ToString(reader.GetValue(0));
                comboBox1.Items.Add(output);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akademie\CMPG_223\FutureTech Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDBFF.mdf;Integrated Security=True");
            string semp = comboBox1.SelectedText;
            string sql = @"Insert Into WSHIFT (Shift_StartT, Emp_ID) Values('" + DateTime.Now + "','" + semp + "')";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
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
    }
}
