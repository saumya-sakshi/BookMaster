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

namespace BookMaster
{
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
                string cmd = "INSERT INTO [authors] VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox6.Text+"')";
                SqlConnection con = new SqlConnection(conString);
                
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, con);
                sqlCommand.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show("Added Successfully");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                dateTimePicker1.Text = "";
               dateTimePicker2.Text = "";
                textBox6.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void Authors_Load(object sender, EventArgs e)
        {

        }
    }
}
