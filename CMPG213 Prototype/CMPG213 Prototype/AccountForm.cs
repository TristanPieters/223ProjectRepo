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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();

           
        }
        SqlConnection CONN;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string sName, sSurname, sID, sCellnr, sEmail , sql="";
            SqlCommand comm;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string constr =  @"";
            CONN = new SqlConnection(constr);
            sName = tbxFirstName.Text;
            sSurname = tbxLastName.Text;
            sID = tbxID.Text;
            sCellnr = tbxCellNumber.Text;
            sEmail = tbxEmail.Text;
            CONN.Open();
            sql = "Insert into ACCOUNT (Acc_FName,Acc_LName,Acc_Email,Acc_Cellnum,Acc_IDnum) values('"+ sName + "','" + sSurname + "','" + sEmail + "','" + sCellnr + "','" + sID+ "',) ";

            comm = new SqlCommand(sql, CONN);

            adapter.InsertCommand = new SqlCommand(sql,CONN);
            adapter.InsertCommand.ExecuteNonQuery();

            CONN.Close();
            comm.Dispose();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {


            
;          
        }
    }
}