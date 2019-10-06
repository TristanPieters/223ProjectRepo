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
            

        }

        private void BtnClosedata_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sCombo;
            sCombo = cmbTable.SelectedItem.ToString();

            CONN = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Dewald\Desktop\CMPG223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\SGSDBF.mdf; Integrated Security = True");

            CONN.Open();
        
            string sql = "Select * FROM " + sCombo;
            SqlCommand comm = new SqlCommand();
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = new SqlCommand(sql, CONN);
            adap.SelectCommand.ExecuteNonQuery();

            DataSet ds = new DataSet();

            adap.Fill(ds, sCombo);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = sCombo;
            comm.Dispose();
            CONN.Close();
        }
    }
}
