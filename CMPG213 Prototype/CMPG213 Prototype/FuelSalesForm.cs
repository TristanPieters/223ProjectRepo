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
using System.Globalization;

namespace CMPG213_Prototype
{
    public partial class FuelSalesForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akademie\CMPG_223\FinalFinalFinal\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\SGSDBF.mdf;Integrated Security=True");
        CultureInfo enZA = CultureInfo.CreateSpecificCulture("en-ZA");

        public FuelSalesForm()
        {
            InitializeComponent();
            btnAccUpdateCredit.Enabled = false;
            //SetAppDomainCultures("en-ZA");

        }

        private void FuelSalesForm_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlFillEmployeeComB = @"SELECT Emp_ID FROM EMPLOYEE";
                SqlDataReader reader;
                SqlCommand comm = new SqlCommand(sqlFillEmployeeComB, conn);
                conn.Open();
                reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    string outputEmpComBFill = Convert.ToString(reader.GetValue(0));
                    comBoxEmpNum.Items.Add(outputEmpComBFill);
                }
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

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
                comm.Dispose();
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
                
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tBoxFuelAmountLiters_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tBoxFuelAmountLiters_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tboxAccNum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tboxAccNum.Text))
            {
                e.Cancel = true;
                tboxAccNum.Focus();
                errProvAccNum.SetError(tboxAccNum, "Please enter a valid account number or create a new one.");
            }
            else
            {
                e.Cancel = false;
                errProvAccNum.SetError(tboxAccNum, null);
            }
        }

        private void tboxAccNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tBoxAccCreditAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxAccCreditAmount.Text))
            {
                e.Cancel = true;
                tBoxAccCreditAmount.Focus();
                errProvAmountCredit.SetError(tBoxAccCreditAmount, "Please enter a amount to be credited.");
            }
            else
            {
                e.Cancel = false;
                errProvAmountCredit.SetError(tBoxAccCreditAmount, null);
            }
        }

        private void btnCompSale_Click(object sender, EventArgs e)
        {            
            

            string fuelResType = comBoxFuelType.SelectedItem.ToString();
            int empNum = Convert.ToInt32(comBoxEmpNum.SelectedIndex.ToString());
            int accNum = Convert.ToInt32(tboxAccNum.Text);
            int fuelTypeID = Convert.ToInt32(comBoxFuelType.SelectedIndex.ToString());
            int rewardIDNum = 0;

            if(comBoxRewardSelect.SelectedItem !=null)
            {
                rewardIDNum = Convert.ToInt32(comBoxRewardSelect.SelectedItem.ToString());
            }

            //string dateSale = DateTime.Now.Date.ToString("yyyy/MM/dd");
            string dateSale = DateTime.Now.ToShortDateString();
            string timeSale = DateTime.Now.ToString("hh:mm");
            decimal fuelPurchAmountSold = Convert.ToDecimal(lblFuelPurchased.Text);
            decimal fuelLiterSold = Convert.ToDecimal(tBoxFuelAmountLiters.Text);
            

            try
            {
                decimal reserveFuel = 0;

                string sqlSelectFuelTypeRes = @"SELECT Current_Fuel_Reserve FROM FUEL WHERE Fuel_Description = '"+fuelResType+"' ";
                conn.Open();
                SqlDataReader reader;
                SqlCommand commSelect = new SqlCommand(sqlSelectFuelTypeRes, conn);
                reader = commSelect.ExecuteReader();
                while (reader.Read())
                {
                    decimal output = Convert.ToDecimal(reader.GetValue(0));
                    reserveFuel = output;
                }
                commSelect.Dispose();
                conn.Close();

                try
                {
                    decimal fuelResSubractAmount = Convert.ToDecimal(tBoxFuelAmountLiters.Text);
                    decimal fuelUpdateAmount = reserveFuel - fuelResSubractAmount;

                    string sqlUpdateReserveFuel = "UPDATE FUEL SET Current_Fuel_Reserve = @fuelUpdateAmount WHERE Fuel_Description = @fuelResType";
                    conn.Open();
                    SqlCommand comm = new SqlCommand();
                    SqlDataAdapter adap = new SqlDataAdapter();
                    comm = new SqlCommand(sqlUpdateReserveFuel, conn);
                    adap.UpdateCommand = new SqlCommand(sqlUpdateReserveFuel, conn);
                    adap.UpdateCommand.Parameters.AddWithValue("@fuelUpdateAmount", fuelUpdateAmount);
                    adap.UpdateCommand.Parameters.AddWithValue("@fuelResType", fuelResType);
                    adap.UpdateCommand.ExecuteNonQuery();
                    comm.Dispose();
                    conn.Close();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string sqlInsertTransactTbl = "INSERT INTO TRANSACT (Emp_Id, Acc_ID, Fuel_ID, Reward_ID, DateofSale, TimeofSale, Amount_Sold, Liters_Sold) VALUES (@empNum, @accNum, @fuelTypeID, @rewardIDNum, @dateSale, @timeSale, @fuelPurchAmountSold, @fuelLiterSold)";

                conn.Open();
                SqlCommand commInsertTrans = new SqlCommand();
                SqlDataAdapter adap = new SqlDataAdapter();
                commInsertTrans = new SqlCommand(sqlInsertTransactTbl, conn);
                adap.InsertCommand = new SqlCommand(sqlInsertTransactTbl, conn);
                adap.InsertCommand.Parameters.AddWithValue("@empNum", empNum);
                adap.InsertCommand.Parameters.AddWithValue("@accNum", accNum);
                adap.InsertCommand.Parameters.AddWithValue("@fuelTypeID", fuelTypeID);
                adap.InsertCommand.Parameters.AddWithValue("@rewardIDNum", rewardIDNum);
                adap.InsertCommand.Parameters.Add("@dateSale", SqlDbType.Date);
                adap.InsertCommand.Parameters["@dateSale"].Value = dateSale;
                adap.InsertCommand.Parameters.Add("@timeSale", SqlDbType.Time);
                adap.InsertCommand.Parameters["@timeSale"].Value = timeSale;
                adap.InsertCommand.Parameters.AddWithValue("@fuelPurchAmountSold", fuelPurchAmountSold);
                adap.InsertCommand.Parameters.AddWithValue("@fuelLiterSold", fuelLiterSold);
                adap.InsertCommand.ExecuteNonQuery();
                commInsertTrans.Dispose();
                MessageBox.Show("Transaction sucessfully made!");
                conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                    string sqlInsertRewAccTbl = "INSERT INTO REWARD_ACCOUNT (Acc_ID, Reward_ID, R_DateRecieved) VALUES ( @accNum, @rewardNum, @dateSale)";

                    conn.Open();
                    SqlCommand commInsertRewAcc = new SqlCommand();
                    SqlDataAdapter adap = new SqlDataAdapter();
                    commInsertRewAcc = new SqlCommand(sqlInsertRewAccTbl, conn);
                    adap.InsertCommand = new SqlCommand(sqlInsertRewAccTbl, conn);
                    adap.InsertCommand.Parameters.AddWithValue("@accNum", accNum);
                    adap.InsertCommand.Parameters.AddWithValue("@rewardNum", rewardIDNum);                    
                    adap.InsertCommand.Parameters.Add("@dateSale", SqlDbType.Date);
                    adap.InsertCommand.Parameters["@dateSale"].Value = dateSale;
                    adap.InsertCommand.ExecuteNonQuery();
                    commInsertRewAcc.Dispose();
                    MessageBox.Show("Reward recorded");
                    conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(tboxAccNum.Text, "Account credit has been updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(tBoxFuelAmountLiters.Text, "Please enter a valid fuel amount using format '00,00'.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(tBoxAccCreditAmount.Text, "Please enter a valid credit amount using format '00,00'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comBoxFuelType.SelectedItem == null)
            {
                errProvComBoxFuelType.SetError(comBoxFuelType, "Please select an item from the combobox.");
                MessageBox.Show("Please select an item from the combobox.");
            }
            else
            {
                errProvComBoxFuelType.Clear();
            }
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comBoxFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectFuelType = comBoxFuelType.SelectedItem.ToString();

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
            btnAccUpdateCredit.Enabled = true;
            string accSearchNum = tboxAccNum.Text;
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

        private void btnAccUpdateCredit_Click(object sender, EventArgs e)
        {
            try
            {
                string accNum = tboxAccNum.Text;
                string currCredAmnt = tBoxAccCreditAmount.Text;
                string addDiscountAcc = lblDiscountedAmount.Text;

                decimal currentCredAmount, discountAmnt;
                currentCredAmount = Convert.ToDecimal(currCredAmnt);
                discountAmnt = Convert.ToDecimal(addDiscountAcc);

                decimal newCredAmount = currentCredAmount - discountAmnt;

                

                lblAccNewCredit.Text = newCredAmount.ToString();
                //string sFormat = String.Format("{0:C}", newCredAmount).Replace('.',',');

                string sqlUpdateCredit = "UPDATE ACCOUNT SET Acc_Debt = @price WHERE Acc_ID = @acc";

                conn.Open();
                SqlCommand comm = new SqlCommand();
                SqlDataAdapter adap = new SqlDataAdapter();

                comm = new SqlCommand(sqlUpdateCredit, conn);
                adap.UpdateCommand = new SqlCommand(sqlUpdateCredit, conn);
                adap.UpdateCommand.Parameters.AddWithValue("@price", newCredAmount);
                adap.UpdateCommand.Parameters.AddWithValue("@acc", accNum);
                adap.UpdateCommand.ExecuteNonQuery();

                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tBoxAccCreditAmount_Click(object sender, EventArgs e)
        {
            tBoxAccCreditAmount.Text = lblFuelPurchased.Text;
        }

        private void comBoxRewardSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectRewardDet = comBoxRewardSelect.SelectedItem.ToString();

            try
            {
                string sqlSelectRewDsecript = @"SELECT Reward_Description From REWARD WHERE Reward_ID = '" + selectRewardDet + "'";
                SqlDataReader reader;
                SqlCommand comm = new SqlCommand(sqlSelectRewDsecript, conn);
                conn.Open();
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    string output = Convert.ToString(reader.GetValue(0));
                    lblRewardDetail.Text = output;
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            try
            {
                decimal DiscAmount = 0;

                string sqlSelectDiscountAmount = @"SELECT Reward_Amount FROM REWARD WHERE Reward_ID = '" + selectRewardDet + "'";

                SqlDataReader reader;
                SqlCommand comm = new SqlCommand(sqlSelectDiscountAmount, conn);

                conn.Open();
                reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    decimal output = Convert.ToDecimal(reader.GetValue(0));
                    DiscAmount = output;
                }

                string currOutstandCred = tBoxAccCreditAmount.Text;
                
                decimal currentCredAmount, divDiscAmount;
                currentCredAmount = Convert.ToDecimal(currOutstandCred);
                divDiscAmount = Convert.ToDecimal(DiscAmount);

                decimal newCredAmount = currentCredAmount * (divDiscAmount/100);

                lblDiscountedAmount.Text = newCredAmount.ToString();

                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        //public static void SetAppDomainCultures(string name)
        //{
        //    try
        //    {
        //        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CreateSpecificCulture(name);
        //        CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CreateSpecificCulture(name);
        //    }
        //    // If an exception occurs, we'll just fall back to the system default.
        //    catch (CultureNotFoundException)
        //    {
        //        return;
        //    }
        //    catch (ArgumentException)
        //    {
        //        return;
        //    }
        //}
    }


}
