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
    public partial class Form_FuelPrices : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Akademie\CMPG_223\FutureTech Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security = True");

        public Form_FuelPrices()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comBoxFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fuelType = comBoxFuelType.GetItemText(comBoxFuelType.SelectedItem);
            lblFuelConf.Text = fuelType;
            tBoxNewPrice.Focus();
        }

        private void btnUpdPrice_Click(object sender, EventArgs e)
        {
            if(chkBoxConfChange.Checked)
            {
                con.Open();   
                MessageBox.Show("Price has been successfully updated.", "Successfull");
                chkBoxConfChange.Checked = false;
                DataSet ds = new DataSet();
                SqlCommand command = new SqlCommand(@"UPDATE FUEL SET Fuel_Price_Per_Liter = '" + tBoxNewPrice.Text + "' WHERE Fuel_ID = '" + comBoxFuelType.SelectedItem+ "'");
                SqlDataAdapter adapter = new SqlDataAdapter();
                command.ExecuteNonQuery();
                adapter.UpdateCommand = command;
                adapter.Fill(ds);
                con.Close();
                
            }
            else
            {
                MessageBox.Show("Please confirm price change!", "Confirmation required");
            }
        }
    }
}
