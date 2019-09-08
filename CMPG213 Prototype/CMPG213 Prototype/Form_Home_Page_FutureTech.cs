﻿using System;
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
        public Form_Home_Page_FutureTech()
        {
            InitializeComponent();
        }
        
        private void Form_Home_Page_FutureTech_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Stallion's Gas Station designed and developed by FUTURETECH");

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dewald\Desktop\CMPG223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True");
            string sql = @"Select * From FUEL";
            SqlDataReader reader;
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            reader = comm.ExecuteReader();
            int counter = 1;
            //string reffrance = "label" + Convert.ToString(counter);

            while (reader.Read())
            {
                string output = Convert.ToString(reader.GetValue(2));

                if(counter == 1)
                {
                    label1.Text = output;
                }
               else if (counter == 2 )
                {
                   label2.Text = output;
                }
                else if(counter == 3 )
                {
                    label3.Text = output;
                }
                else if (counter == 4)
                {
                    label4.Text = output;
                }
                counter++;  
            }
            conn.Close();
        }

        private void GbFuelType_Enter(object sender, EventArgs e)
        {

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
<<<<<<< Updated upstream
<<<<<<< Updated upstream

            Maintain_Fuel updateFuelPriceForm = new Maintain_Fuel();
            //updateFuelPriceForm.ShowDialog(
            //MaintainFuel updateFuelPriceForm = new MaintainFuel();
            //updateFuelPriceForm.ShowDialog();

=======
            Maintain_Fuel updateFuelPriceForm = new Maintain_Fuel();
            updateFuelPriceForm.ShowDialog();
=======

            Maintain_Fuel updateFuelPriceForm = new Maintain_Fuel();
            updateFuelPriceForm.ShowDialog();

>>>>>>> Stashed changes
            //MaintainFuel updateFuelPriceForm = new MaintainFuel();
            //updateFuelPriceForm.ShowDialog();

        }

        private void BtnManageEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
>>>>>>> Stashed changes

           // Manage_Employees manageEmpForm = new Manage_Employees();
           // manageEmpForm.ShowDialog();

<<<<<<< Updated upstream
          //  Manage_Employees manageEmpForm = new Manage_Employees();
            //manageEmpForm.ShowDialog();

=======
           // Manage_Employees manageEmpForm = new Manage_Employees();
           // manageEmpForm.ShowDialog();
=======
>>>>>>> Stashed changes
          //  Manage_Employees manageEmpForm = new Manage_Employees();
            //manageEmpForm.ShowDialog();

        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            //Daily report
            /*
            CONN.Open();
            String transID;
            DateTime transDate;
            decimal transAmnt;
            double transLitersSold;

            SqlCommand commTrans;
            SqlCommand commEmp;
            SqlCommand commAcc;
            SqlCommand commFuel;
            SqlCommand commReward;

            SqlDataAdapter dataReader = new SqlDataAdapter();

            String sqlTrans,sqlEmp,sqlAcc,sqlFuel,sqlReward, Output;

            sqlTrans = "Select Trans_ID,Dateofsale,Amount_Liters_Sold, Liters_Sold from TRANSACT";
            sqlEmp = "Select Emp_ID from EMPLOYEE";
            sqlAcc = "Select Acc_ID from ACCOUNT";
            sqlFuel = "Select Fuel_ID from FUEL";
            sqlReward = "Select Reward_ID from REWARD";

            commTrans = new SqlCommand(sqlTrans, CONN);
            commEmp = new SqlCommand(sqlEmp, CONN);
            commAcc = new SqlCommand(sqlAcc, CONN);
            commFuel = new SqlCommand(sqlFuel, CONN);
            commReward = new SqlCommand(sqlReward, CONN);

            dataReader = comm.ExcecuteReader();



            try
            {
                StreamWriter inputFile;
                inputFile = File.CreateText("Report.txt");

                saveFileDialog1.InitialDirectory = @"c:/";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.CreateText(saveFileDialog1.FileName);
                   

                    inputFile.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
    */
           

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
    }
}
