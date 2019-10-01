﻿using System;
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
    public partial class Maintain_Rewards : Form
    {
        public Maintain_Rewards()
        {
            InitializeComponent();
        }
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\2de Sem\CMPG 223\223ProjectRepo\CMPG213 Prototype\CMPG213 Prototype\StallionsDb.mdf;Integrated Security=True";
        SqlConnection conn;
        string detail;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            detail = txbAdd.Text;

            string sql = @"Insert Into REWARD (Reward_Detail) Values('" + detail + "')";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();
                adap.Fill(ds, "REWARD");
                dgvReward.DataSource = ds;
                dgvReward.DataMember = "REWARD";
                MessageBox.Show("Record inserted successfully");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            txbAdd.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            detail = txbUpdate.Text;
            string sql = @"UPDATE REWARD SET Reward_Detail ='" + detail + "' WHERE Reward_ID = '" + cmbUpdate.SelectedItem + "'";

            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                adap.UpdateCommand = new SqlCommand(sql, conn);
                adap.UpdateCommand.ExecuteNonQuery();
                adap.Fill(ds, "REWARD");
                dgvReward.DataSource = ds;
                dgvReward.DataMember = "REWARD";
                MessageBox.Show("Record successfuly updated!");
                comm.Dispose();
                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            txbUpdate.Text = "";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM REWARD WHERE Reward_ID = '" + cmbDelete.SelectedItem + "'";
            try
            {
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                SqlCommand comm = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                adap.DeleteCommand = new SqlCommand(sql, conn);
                adap.DeleteCommand.ExecuteNonQuery();
                adap.Fill(ds, "REWARD");
                dgvReward.DataSource = ds;
                dgvReward.DataMember = "REWARD";
                MessageBox.Show("Record successfuly deleted!");
                comm.Dispose();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Maintain_Rewards_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constring);
            string sql = @"SELECT Emp_ID FROM REWARD";
            SqlDataReader reader;
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string output = Convert.ToString(reader.GetValue(0));
                cmbUpdate.Items.Add(output);
                cmbDelete.Items.Add(output);
            }
            comm.Dispose();
            conn.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Home_Page_FutureTech home = new Form_Home_Page_FutureTech();
            home.ShowDialog();
        }
    }
}