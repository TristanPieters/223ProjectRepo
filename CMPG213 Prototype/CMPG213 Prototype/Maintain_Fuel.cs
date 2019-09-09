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
    public partial class Maintain_Fuel : Form
    {
        public Maintain_Fuel()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");
=======
            SqlConnection conn = new SqlConnection(@"Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akademie\CMPG_223\FutureTech Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDBF.mdf;Integrated Security=True");
>>>>>>> Stashed changes
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

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");
=======
            SqlConnection conn = new SqlConnection(@"Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akademie\CMPG_223\FutureTech Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDBF.mdf;Integrated Security=True");
>>>>>>> Stashed changes
            string todelete = Convert.ToString(comboBox2.SelectedItem);
            string sql = @"DELETE FROM FUEL WHERE Fuel_Description ='" + todelete + "'";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                adap.DeleteCommand = new SqlCommand(sql, conn);
                adap.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnUdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akademie\CMPG_223\FutureTech Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDBF.mdf;Integrated Security=True");
            string fueldescription = Convert.ToString(comboBox1.SelectedItem);
            string fuelppl = textBox6.Text;
            string fuelreserves = textBox5.Text;
            string sql = @"UPDATE FUEL SET Fuel_Price_Per_Liter = '" + fuelppl + "', Current_Fuel_Reserve = '" + fuelreserves + "' WHERE Fuel_Description = '" + fueldescription + "'";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                adap.UpdateCommand = new SqlCommand(sql, conn);
                adap.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Record Updated successfully");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Maintain_Fuel_Load(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");
=======
            SqlConnection conn = new SqlConnection(@"Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akademie\CMPG_223\FutureTech Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDBF.mdf;Integrated Security=True");
>>>>>>> Stashed changes
            string sql = @"Select * From FUEL";
            SqlDataReader reader;
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string output = Convert.ToString(reader.GetValue(1));
                comboBox1.Items.Add(output);
                comboBox2.Items.Add(output);
            }
            conn.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
