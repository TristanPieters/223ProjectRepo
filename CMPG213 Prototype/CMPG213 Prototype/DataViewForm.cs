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
    public partial class DataViewForm : Form
    {
        public DataViewForm()
        {
            InitializeComponent();
        }
        SqlConnection CONN = new SqlConnection();

        private void CmbTable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sCombo;
            sCombo = cmbTable.SelectedItem.ToString();

            CONN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dewald\Desktop\CMPG223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\SGSDBF.mdf;Integrated Security=True");

            CONN.Open();
            SqlCommand comm;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select * FROM '"+ sCombo+"'";
            comm = new SqlCommand(sql, CONN);
            DataSet ds = new DataSet();
            adapter.SelectCommand = comm;
            adapter.Fill(ds,sCombo);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = sCombo;
            CONN.Close();

        }

        private void BtnClosedata_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
