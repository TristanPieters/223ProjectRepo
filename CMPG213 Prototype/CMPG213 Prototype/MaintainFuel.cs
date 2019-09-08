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
    public partial class MaintainFuel : Form
    {
        public MaintainFuel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =D:\Akademie\CMPG_223\FutureTech Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security = True");
            string fueldescription = textBox1.Text;
            string fuelppl = textBox2.Text;
            string sql = @"Insert Into FUEL (Fuel_Description, Fuel_Price_Per_Liter) Values('" + fueldescription + "','" + fuelppl + "')";

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
