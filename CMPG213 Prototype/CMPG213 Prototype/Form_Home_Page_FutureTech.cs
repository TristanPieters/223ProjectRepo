using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
//using System.Data;
//using System.Text;

namespace CMPG213_Prototype
{
    public partial class Form_Home_Page_FutureTech : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Akademie\CMPG_223\NEWREPO\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\SGSDBF.mdf;Integrated Security=True";
        public Form_Home_Page_FutureTech()
        {
            InitializeComponent();
        }
        
        private void Form_Home_Page_FutureTech_Load(object sender, EventArgs e)
        {
            string selectall = "SELECT Fuel_Description, Fuel_Price_Per_Liter, Current_Fuel_Reserve FROM FUEL";

            try
            {

                SqlConnection conn = new SqlConnection(connectionString);
                string sql = @"Select * From FUEL";
                SqlDataReader reader;
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(selectall, con); DataSet

                    ds = new DataSet();

                    SqlDataAdapter adapt = new SqlDataAdapter();
                    adapt.SelectCommand = cmd;

                    adapt.Fill(ds, "FUEL");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "FUEL";
                    con.Close();
                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void GbFuelType_Enter(object sender, EventArgs e)
        {
            string selectall = "SELECT Fuel_Description, Fuel_Price_Per_Liter FROM FUEL";

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(selectall, con); DataSet

                ds = new DataSet();

                SqlDataAdapter adapt = new SqlDataAdapter();
                adapt.SelectCommand = cmd;

                adapt.Fill(ds, "FUEL");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "FUEL";
                con.Close();
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Exit application", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                Form_Home_Page_FutureTech homePage = new Form_Home_Page_FutureTech();
                homePage.ShowDialog();
            }
        }

        private void BtnHelpAndSupport_Click(object sender, EventArgs e)
        {
            Form_HelpSupport helpAndSupportForm = new Form_HelpSupport();
            helpAndSupportForm.ShowDialog();
        }

        private void BtnUpdateFuelPrice_Click(object sender, EventArgs e)
        {
            Maintain_Fuel updateFuelPriceForm = new Maintain_Fuel();
            updateFuelPriceForm.ShowDialog();
        }

        private void BtnManageEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Maintain_Employees manageEmpForm = new Maintain_Employees();
            manageEmpForm.ShowDialog();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {          
            SqlConnection con = new SqlConnection(connectionString);


            try
            {
                StreamWriter outputFile;
                DateTime date;
                date = DateTime.Now;

                string reportOutput = "";

                reportOutput = "*********************";
                reportOutput = reportOutput + "\nStallions Gas Station";
                reportOutput = reportOutput + "\n*********************";
                reportOutput = reportOutput + "\n" + date.ToString() + "\n";

                con.Open();
                SqlDataReader reader;

                string sqlShifts = @"SELECT * FROM WSHIFT";
                SqlCommand command = new SqlCommand(sqlShifts, con);
                reader = command.ExecuteReader();

                reportOutput = reportOutput + "\n*********************";
                reportOutput = reportOutput + "\nShifts";
                reportOutput = reportOutput + "\n*********************";


                while (reader.Read())
                {
                    if (Convert.ToDateTime(reader.GetValue(3)) == DateTime.Today.Date)
                    {
                        reportOutput = reportOutput + "\nEmp ID: " + reader.GetValue(4).ToString();
                        reportOutput = reportOutput + "\nShift Start Time: " + reader.GetValue(1).ToString();
                        reportOutput = reportOutput + "\nShift End Time: " + reader.GetValue(2).ToString();
                        reportOutput = reportOutput + "\n";

                    }
                }
                command.Dispose();
                reader.Close();


                reportOutput = reportOutput + "\n*********************";
                reportOutput = reportOutput + "\nFuel Orders";
                reportOutput = reportOutput + "\n*********************";

                string sqlFO = @"SELECT * FROM FORDER";
                command = new SqlCommand(sqlFO, con);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (Convert.ToDateTime(reader.GetValue(3)) == DateTime.Today.Date)
                    {
                        reportOutput = reportOutput + "\nOrder ID: " + reader.GetValue(0).ToString();
                        reportOutput = reportOutput + "\nOrder Date: " + reader.GetValue(3).ToString();
                        reportOutput = reportOutput + "\nOrder Recieved: " + reader.GetValue(4).ToString();
                        reportOutput = reportOutput + "\nAmount Orderd: " + reader.GetValue(5).ToString();
                        reportOutput = reportOutput + "\nFuel ID: " + reader.GetValue(2).ToString();
                        reportOutput = reportOutput + "\nEmp ID: " + reader.GetValue(1).ToString();

                    }
                }
                command.Dispose();
                reader.Close();

                reportOutput = reportOutput + "\n*********************";
                reportOutput = reportOutput + "\nTransactions";
                reportOutput = reportOutput + "\n*********************";

                string sqlTrans = @"SELECT * FROM TRANSACT";
                command = new SqlCommand(sqlTrans, con);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (Convert.ToDateTime(reader.GetValue(5)) == DateTime.Today.Date)
                    {
                        if(Convert.ToInt32(reader.GetValue(2)) == 1)
                        {
                            reportOutput = reportOutput + "\nTransactions ID: " + reader.GetValue(0).ToString();
                            reportOutput = reportOutput + "\nEmp ID: " + reader.GetValue(1).ToString();
                            reportOutput = reportOutput + "\nCash Sale ";
                            reportOutput = reportOutput + "\nFuel ID: " + reader.GetValue(3).ToString();
                            reportOutput = reportOutput + "\nReward ID: " + reader.GetValue(4).ToString();
                            reportOutput = reportOutput + "\nPrice: " + reader.GetValue(6).ToString();
                            reportOutput = reportOutput + "\nAmount Liters: " + reader.GetValue(7).ToString();
                        }

                        else
                        {
                            reportOutput = reportOutput + "\nTransactions ID: " + reader.GetValue(0).ToString();
                            reportOutput = reportOutput + "\nEmp ID: " + reader.GetValue(1).ToString();
                            reportOutput = reportOutput + "\nAccount ID: " + reader.GetValue(2).ToString();
                            reportOutput = reportOutput + "\nFuel ID: " + reader.GetValue(3).ToString();
                            reportOutput = reportOutput + "\nReward ID: " + reader.GetValue(4).ToString();
                            reportOutput = reportOutput + "\nPrice: " + reader.GetValue(6).ToString();
                            reportOutput = reportOutput + "\nAmount Liters: " + reader.GetValue(7).ToString();
                        }

                    }
                }
                command.Dispose();
                reader.Close();

                string myFile;

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "StallionsReport_" + DateTime.Now.ToString() + ".txt";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = "StallionsReport_" + DateTime.Now.ToLongDateString().ToString()+ ".txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    myFile = saveFileDialog1.FileName;
                    outputFile = File.CreateText(saveFileDialog1.FileName);
                    outputFile.WriteLine(reportOutput);
                    outputFile.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
          
            
    
           

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAddAccounts_Click(object sender, EventArgs e)
        {
            AccountForm myForm = new AccountForm();
            myForm.ShowDialog();
        }

        private void BtnViewAccountDB_Click(object sender, EventArgs e)
        {

        }

        private void BtnViewOutstandingAcc_Click(object sender, EventArgs e)
        {
            AccountUpdateDel myForm = new AccountUpdateDel();
            myForm.ShowDialog();
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            FuelSalesForm formSales = new FuelSalesForm();
            formSales.ShowDialog();
        }

        private void btnClockIN_Click(object sender, EventArgs e)
        {
            ClockInForm clock = new ClockInForm();
            clock.Show();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            FOrderForm fOrder = new FOrderForm();
            fOrder.Show();
        }

        private void BtnMaintainReward_Click(object sender, EventArgs e)
        {
            this.Close();
            Maintain_Rewards rewards = new Maintain_Rewards();
            rewards.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectall = "SELECT Fuel_Description, Fuel_Price_Per_Liter, Current_Fuel_Reserve FROM FUEL";

            try
            {

                SqlConnection conn = new SqlConnection(connectionString);
                string sql = @"Select * From FUEL";
                SqlDataReader reader;
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(selectall, con); DataSet

                    ds = new DataSet();

                    SqlDataAdapter adapt = new SqlDataAdapter();
                    adapt.SelectCommand = cmd;

                    adapt.Fill(ds, "FUEL");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "FUEL";
                    con.Close();
                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnReceiveOrder_Click(object sender, EventArgs e)
        {

        }

        private void BtnMaintainFuel_Click(object sender, EventArgs e)
        {
            Maintain_Fuel myForm = new Maintain_Fuel();
            myForm.ShowDialog();
        }
    }
}
