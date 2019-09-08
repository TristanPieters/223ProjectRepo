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
    public partial class AccountUpdateDel : Form
    {
        public AccountUpdateDel()
        {
            InitializeComponent();
        }

        private void AccountUpdateDel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stallionsDbDataSet.ACCOUNT' table. You can move, or remove it, as needed.
            this.aCCOUNTTableAdapter.Fill(this.stallionsDbDataSet.ACCOUNT);

        }
    }
}
