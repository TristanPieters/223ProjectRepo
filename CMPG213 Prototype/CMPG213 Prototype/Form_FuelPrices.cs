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
    public partial class Form_FuelPrices : Form
    {
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
                MessageBox.Show("Price has been successfully updated.", "Successfull");
                chkBoxConfChange.Checked = false;
            }
            else
            {
                MessageBox.Show("Please confirm price change!", "Confirmation required");
            }
        }
    }
}
