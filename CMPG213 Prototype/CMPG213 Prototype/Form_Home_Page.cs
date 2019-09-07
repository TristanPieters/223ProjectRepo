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

namespace CMPG213_Prototype
{
    public partial class Form_Home_Page : Form
    {
        public Form_Home_Page()
        {
            InitializeComponent();
        }

        private void Form_Home_Page_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome to Stallion's Gas Station");
        }

        private void btnExitHomeP_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Exit application", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(dialog == DialogResult.No)
            {
                //Do not close application
            }
        }

        private void btnHelpSupp_Click(object sender, EventArgs e)
        {
            Form_HelpSupport helpSuppFrm = new Form_HelpSupport();
            helpSuppFrm.ShowDialog();
        }

        private void btnUpdFuelPrice_Click(object sender, EventArgs e)
        {
            Form_FuelPrices updFuelPriceFrm = new Form_FuelPrices();
            updFuelPriceFrm.ShowDialog();
            //
        }

        private void BtnEmpManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Employees ME = new Manage_Employees();
            ME.ShowDialog();
            this.Close();
        }
    }
}
