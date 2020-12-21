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
    public partial class AuthorDisplay : Form
    {
        public AuthorDisplay(string auth)
        {
            InitializeComponent();
            name = auth;
        }
        string name;
        SqlDataAdapter dataAdapter;
        DataSet pagingD;
        string link;

        private void AuthorDisplay_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string cmd2 = "Select * from [authors]";
            SqlConnection con2 = new SqlConnection(conString);

            SqlDataAdapter datadapter2 = new SqlDataAdapter(cmd2, con2);
            DataSet paging2 = new DataSet();
            con2.Open();
            datadapter2.Fill(paging2);
            con2.Close();
            comboBox1.DataSource = paging2.Tables[0];
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Name";
            for(int i = 0; i < paging2.Tables[0].Rows.Count - 1; i++) {
                if(paging2.Tables[0].Rows[i][1].ToString() == name)
                {
                    comboBox1.SelectedIndex = i;
                }
            }
            


            //string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd;

            sqlcmd = "select BirthDate,Bio,wikipedia from authors where Name='" + name + "'";


            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingD);
            // dataAdapter.Fill(pagingD, scroll, 5, "customers");
            con.Close();
            label1.Text= pagingD.Tables[0].Rows[0][0].ToString();
            label3.Text= pagingD.Tables[0].Rows[0][1].ToString();
            link= pagingD.Tables[0].Rows[0][2].ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
           void VisitLink()
            {
                // Change the color of the link text by setting LinkVisited
                // to true.
                linkLabel1.LinkVisited = true;
                //Call the Process.Start method to open the default browser
                //with a URL:
                System.Diagnostics.Process.Start(link);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd;
          string str = comboBox1.SelectedIndex.ToString();

            sqlcmd = "select BirthDate,Bio,wikipedia from authors where AuthorKey='" + str + "'";


            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingD);
            // dataAdapter.Fill(pagingD, scroll, 5, "customers");
            con.Close();
            label1.Text = pagingD.Tables[0].Rows[0][0].ToString();
            label3.Text = pagingD.Tables[0].Rows[0][1].ToString();
            link = pagingD.Tables[0].Rows[0][2].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
