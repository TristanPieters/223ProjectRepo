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

        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True";
        
        private void btnADD_Click(object sender, EventArgs e)
        { 
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(textBox1.Text, "Please enter valid fuel description", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(textBox2.Text, "Please eneter valid price per liter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SqlConnection conn = new SqlConnection(constr);
            
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
            if(comboBox2.SelectedItem == null)
            {
                errorProvider3.SetError(comboBox2, "Please select an item from the combobox !");
                MessageBox.Show("Please select an item from the combobox!");
            }
            else
            {
                errorProvider3.Clear();
            }
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");
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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(textBox5.Text, "Please enter valid fuel reserves value !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(textBox6.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (comboBox1.SelectedItem == null)
            {
                errorProvider3.SetError(comboBox1, "Please select an item from the combobox !");
                MessageBox.Show("Please select an item from the combobox!");
            }
            else
            {
                errorProvider3.Clear();
            }
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");
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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dewald\Desktop\CMPG223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDBFF.mdf;Integrated Security=True");
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

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please enter valid fuel description !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);

            }
        }

        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Please enter valid fuel price per liter !");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, null);

            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') 
            {
                e.Handled = true;
            }
        }

        private void TextBox6_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                e.Cancel = true;
                textBox6.Focus();
                errorProvider5.SetError(textBox6, "Please enter valid fuel price per liter !");
            }
            else
            {
                e.Cancel = false;
                errorProvider5.SetError(textBox6, null);

            }
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider4.SetError(textBox5, "Please enter valid fuel reserves !");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(textBox5, null);

            }
        }

        private void ComboBox2_Validating(object sender, CancelEventArgs e)
        {
       
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
