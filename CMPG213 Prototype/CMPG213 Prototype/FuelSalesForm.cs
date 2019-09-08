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
    public partial class FuelSalesForm : Form
    {
        public FuelSalesForm()
        {
            InitializeComponent();
        }

        private void FuelSalesForm_Load(object sender, EventArgs e)
        {
            gBoxAccount.Enabled = false;
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
    }
}
