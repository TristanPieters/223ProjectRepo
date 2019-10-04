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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PUK\Year 2\2nd Sem\CMPG223\Project\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDBFF.mdf;Integrated Security=True");

        public FuelSalesForm()
        {
            InitializeComponent();
        }

        private void FuelSalesForm_Load(object sender, EventArgs e)
        {
            comBoxRewardSelect.Enabled = false;

            try
            {
                string sqlFuelComBFill = @"Select Fuel_Description From FUEL";
                SqlDataReader reader;
                SqlCommand comm = new SqlCommand(sqlFuelComBFill, conn);
                conn.Open();
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string outputFuelComBFill = Convert.ToString(reader.GetValue(0));
                    comBoxFuelType.Items.Add(outputFuelComBFill);
                }
                conn.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            try
            {
                string sqlRewardComBFill = @"SELECT Reward_ID From REWARD";
                SqlDataReader reader;
                SqlCommand comm = new SqlCommand(sqlRewardComBFill, conn);
                conn.Open();
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string outputRewardComBFill = Convert.ToString(reader.GetValue(0));
                    comBoxRewardSelect.Items.Add(outputRewardComBFill);
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCompSale_Click(object sender, EventArgs e)
        {

        }

        

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comBoxFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectFuelType = comBoxFuelType.SelectedItem.ToString();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");
            string sql = @"Select Fuel_Price_Per_Liter From FUEL WHERE Fuel_Description = '"+ selectFuelType +"'";
            SqlDataReader reader;
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            reader = comm.ExecuteReader();

            while (reader.Read())
            {


                string output = Convert.ToString(reader.GetValue(0));
                lblFuelPrice.Text = output;
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

        private void btnCalcTotalFuelPrice_Click(object sender, EventArgs e)
        {
            decimal fuelPriceLiter, fuelLiterAmount;

            fuelPriceLiter = Convert.ToDecimal(lblFuelPrice.Text);
            fuelLiterAmount = Convert.ToDecimal(tBoxFuelAmountLiters.Text);
            decimal totalFuelPrice = fuelPriceLiter * fuelLiterAmount;

            lblFuelPurchased.Text = totalFuelPrice.ToString();
        }

        private void btnAccSearch_Click(object sender, EventArgs e)
        {
            string accSearchNum = tboxAccNum.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");


            string sql = @"SELECT * FROM ACCOUNT WHERE Acc_ID = '" + accSearchNum + "'";

            SqlDataReader reader;
            SqlCommand comm = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string outputFullName = Convert.ToString(reader.GetValue(1)) + " " + Convert.ToString(reader.GetValue(2));
                    lblAccHolderName.Text = outputFullName;

                    string outputCreditOutstand = Convert.ToString(reader.GetValue(6));
                    lblAccCreditOutstand.Text = outputCreditOutstand;
                }
                conn.Close();
            }

            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCreateNewAcc_Click(object sender, EventArgs e)
        {
            AccountForm formAccCreate = new AccountForm();
            formAccCreate.ShowDialog();
        }

        private void tboxAccNum_TextChanged(object sender, EventArgs e)
        {
            if(tboxAccNum.Text == "1")
            {
                comBoxRewardSelect.Enabled = false;
                toolTipRewardComBox.Show("No rewards on cash", comBoxRewardSelect);
            }
            else
            {
                comBoxRewardSelect.Enabled = true;
            }
        }

        private void btnAccUpdateCredit_Click(object sender, EventArgs e)
        {
            string accNum = tboxAccNum.Text;
            string currCredAmnt = tBoxAccCreditAmount.Text;

            try
            {
                string sqlUpdateCredit = @"UPDATE ACCOUNT SET Acc_Debt =  '"+currCredAmnt+"'WHERE Acc_ID = '"+ accNum +"'";

                conn.Open();
                SqlCommand comm = new SqlCommand();
                SqlDataAdapter adap = new SqlDataAdapter();

                comm = new SqlCommand(sqlUpdateCredit, conn);
                adap.UpdateCommand = new SqlCommand(sqlUpdateCredit, conn);
                adap.UpdateCommand.ExecuteNonQuery();

                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            decimal currentCredAmount, addCreditAmount;
            currentCredAmount = Convert.ToDecimal(lblAccCreditOutstand.Text);
            addCreditAmount = Convert.ToDecimal(tBoxAccCreditAmount.Text);
            decimal newCredAmount = currentCredAmount + addCreditAmount;

            lblAccNewCredit.Text = newCredAmount.ToString();
        }

        private void tBoxAccCreditAmount_Click(object sender, EventArgs e)
        {
            tBoxAccCreditAmount.Text = lblFuelPurchased.Text;
        }
    }
}
