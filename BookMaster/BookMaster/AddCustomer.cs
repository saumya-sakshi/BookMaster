using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BookMaster
{
    public partial class AddCustomer : Form
    {
        public AddCustomer(string cid, string feature)
        {
            InitializeComponent();
            id = cid;
            add_edit = feature;
        }
        string id;
        string add_edit;
        SqlDataAdapter dataAdapter;
        DataSet pagingD;
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            txtid.Text = id;
            txtname.Text = Form3.SetValueForText2;
            txtaddress.Text = Form3.SetValueForText3;
            txtzip.Text = Form3.SetValueForText4;
            txtcity.Text = Form3.SetValueForText5;
            txtphone.Text = Form3.SetValueForText6;
            txtemail.Text= Form3.SetValueForText7;

            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd = "SELECT * from [customers]";
            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingD);
            // dataAdapter.Fill(pagingD, scroll, 5, "customers");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (add_edit == "add")
            {
                string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
                string sqlcmd = "INSERT INTO [customers] VALUES ('"+txtid.Text+"','"+ txtname.Text+"', '"+txtaddress.Text+"', '"+txtzip.Text+"', '"+txtcity.Text+"', '"+txtphone+"', '"+txtemail.Text+"')";
                SqlConnection con = new SqlConnection(conString);
                dataAdapter = new SqlDataAdapter(sqlcmd, con);
                pagingD = new DataSet();
                con.Open();
                dataAdapter.Fill(pagingD);
                // dataAdapter.Fill(pagingD, scroll, 5, "customers");
                con.Close();
                MessageBox.Show("customer Added Successfully");
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            if (add_edit == "edit")
            {
                string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
                string sqlcmd = "UPDATE [customers] SET Name = '"+txtname.Text+ "', Address = '"+txtaddress.Text+ "',Zip = '"+txtzip.Text+ "',City='"+txtcity.Text+ "',Phone ='"+txtphone.Text+ "',Email='"+txtemail.Text+"'WHERE ID = '"+txtid.Text+"';";
                SqlConnection con = new SqlConnection(conString);
                dataAdapter = new SqlDataAdapter(sqlcmd, con);
                pagingD = new DataSet();
                con.Open();
                dataAdapter.Fill(pagingD);
                // dataAdapter.Fill(pagingD, scroll, 5, "customers");
                con.Close();
                MessageBox.Show("customer Edited Successfully");
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }
    }
}
