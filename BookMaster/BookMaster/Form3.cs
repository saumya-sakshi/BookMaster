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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlDataAdapter dataAdapter;
        DataSet pagingD;
        //int scroll;
        string ciid;
        public static string SetValueForText7 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";


        private void Form3_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd = "SELECT * from [customers]";
            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingD);
           // dataAdapter.Fill(pagingD, scroll, 5, "customers");
            con.Close();
            dataGridView1.DataSource = pagingD.Tables[0];
            int count = pagingD.Tables[0].Rows.Count;
            string str = pagingD.Tables[0].Rows[count - 1][0].ToString();
            int cid = Convert.ToInt32(str.Replace("C", " ").Trim()) + 1;

            label3.Text = "C" + cid;
            ciid= "C" + cid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd;
            if(txtid.Text==""&& txtname.Text == "")
            {
                sqlcmd = "SELECT * from [customers]";
            }
            else { sqlcmd = "SELECT * from [customers] where ID='" + txtid.Text + "'or Name ='" + txtname.Text + "'"; }
                
            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingD);
            // dataAdapter.Fill(pagingD, scroll, 5, "customers");
            con.Close();
            if (pagingD.Tables[0].Rows.Count > 0) { dataGridView1.DataSource = pagingD.Tables[0]; }
            else
            {
                MessageBox.Show("No entry Matched the search criteria");
                txtid.Text = "";
                txtname.Text = "";
                sqlcmd = "SELECT * from [customers]";
                SqlConnection scon = new SqlConnection(conString);
                dataAdapter = new SqlDataAdapter(sqlcmd, scon);
                pagingD = new DataSet();
                scon.Open();
                dataAdapter.Fill(pagingD);
                scon.Close();
                dataGridView1.DataSource = pagingD.Tables[0];


            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            txtid.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
         
            SetValueForText2 = txtname.Text;
            SetValueForText3 = dataGridView1.Rows[index].Cells[2].Value.ToString();
            SetValueForText4 = dataGridView1.Rows[index].Cells[3].Value.ToString();
            SetValueForText5 = dataGridView1.Rows[index].Cells[4].Value.ToString();
            SetValueForText6 = dataGridView1.Rows[index].Cells[5].Value.ToString();
            SetValueForText7 = dataGridView1.Rows[index].Cells[6].Value.ToString();


        }
        string feature = "";

        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer(ciid, "add");
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCustomer edit = new AddCustomer(txtid.Text, "edit");
            edit.Show();
            this.Hide();
        }
    }
}
