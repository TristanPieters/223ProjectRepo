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
    public partial class FuelSalesForm : Form
    {
        public FuelSalesForm()
        {
            InitializeComponent();
        }

        private void FuelSalesForm_Load(object sender, EventArgs e)
        {
            gBoxAccount.Enabled = false;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Crispy\Desktop\PUK\Year 2\2nd Sem\CMPG223\Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");
            string sql = @"Select Fuel_Description From FUEL";
            SqlDataReader reader;
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string output = Convert.ToString(reader.GetValue(0));
                comBoxFuelType.Items.Add(output);
            }
            conn.Close();
        }

        private void btnCompSale_Click(object sender, EventArgs e)
        {

        }

        private void cBoxAccCredit_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxAccCredit.Checked == true)
            {
                gBoxAccount.Enabled = true;
            }
            if(cBoxAccCredit.Checked == false)
            {
                gBoxAccount.Enabled = false;
            }
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comBoxFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectFuelType = comBoxFuelType.SelectedItem.ToString();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Crispy\Desktop\PUK\Year 2\2nd Sem\CMPG223\Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");
            string sql = @"Select Fuel_Price_Per_Liter From FUEL WHERE Fuel_Description = '"+ selectFuelType +"'";
            SqlDataReader reader;
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            reader = comm.ExecuteReader();

            while (reader.Read())
            {


                string output = Convert.ToString(reader.GetValue(0));
                lblFuelPrice.Text = "R" + output;
            }
            conn.Close();
        }

        public decimal fuelTotalSum(decimal fuelPriceLiter, decimal fuelLiterAmount)
        {
            fuelPriceLiter = Convert.ToDecimal(lblFuelPrice.Text);
            fuelLiterAmount = Convert.ToDecimal(tBoxFuelAmountLiters.Text);
            decimal totalFuelPrice = fuelPriceLiter * fuelLiterAmount;


            return totalFuelPrice;
        }

        private void tBoxFuelAmountLiters_TextChanged(object sender, EventArgs e)
        {
            /*decimal fuelPriceLiter, fuelLiterAmount;

            fuelPriceLiter = Convert.ToDecimal(lblFuelPrice.Text);
            fuelLiterAmount = Convert.ToDecimal(tBoxFuelAmountLiters.Text);

            fuelTotalSum(fuelPriceLiter, fuelLiterAmount);*/
        }
    }
}
