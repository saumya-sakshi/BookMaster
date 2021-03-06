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

namespace BookMaster
{
    public partial class BookCovers : Form
    {
        public BookCovers()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                long coverfile = Convert.ToInt64(txtcoverfile.Text);

            }catch(Exception ex)
            {
                MessageBox.Show("Please enter integer value"+ex.Message);
            }
            try {
                string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
                string cmd = "INSERT INTO [BookCovers] VALUES("+txtcoverfile.Text+",'" + comboBox1.SelectedValue  + "')";
                SqlConnection con = new SqlConnection(conString);

                con.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, con);
                sqlCommand.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Added Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void BookCovers_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string cmd;
            cmd = "Select * from [books]";
            SqlConnection con = new SqlConnection(conString);

            SqlDataAdapter datadapter = new SqlDataAdapter(cmd, con);
            DataSet paging = new DataSet();
            con.Open();
            datadapter.Fill(paging);
            con.Close();
            comboBox1.DataSource = paging.Tables[0];
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Title";
        }
    }
}
