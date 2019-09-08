using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Form_FuelPrices updateFuelPriceForm = new Form_FuelPrices();
            updateFuelPriceForm.ShowDialog();
        }

        private void BtnManageEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Employees manageEmpForm = new Manage_Employees();
            manageEmpForm.ShowDialog();
        }
    }
}
