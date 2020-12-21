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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
                string cmd = "INSERT INTO [books] VALUES('" + txtkey.Text + "','" + txttitle.Text + "','" + txtsub.Text + "','" + dtp1.Text + "','" + txtdescription.Text  + "')";
                SqlConnection con = new SqlConnection(conString);

                con.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, con);
                sqlCommand.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Added Successfully");
                txtkey.Text = "";
                txtsub.Text = "";
                txttitle.Text = "";
                txtdescription.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
