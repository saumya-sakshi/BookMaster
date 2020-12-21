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
using Microsoft.Office.Interop.Excel;

namespace BookMaster
{

    public partial class Form1 : Form
    {
        public Form1(bool getvar)
        {
            InitializeComponent();
            scroll = 0;
            count = 1;
            logiinsesssion = getvar;
        }
        SqlDataAdapter dataAdapter;
        DataSet pagingD;
        int scroll;
        int count;
        bool logiinsesssion = false;
        string auth;


        private void button4_Click(object sender, EventArgs e)
        {
            //<
            scroll = scroll - 5;
            if (scroll <= 0)
            {
                scroll = 0;
                count = 1;
            }
            pagingD.Clear();
            dataAdapter.Fill(pagingD, scroll, 5, "issues");




        }
        private void Loaddata()
        {
            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd = "select b.Title,a.Name from books as b inner join bookauthors ba on ba.BookKey = b.[Key] inner join authors a on ba.AuthorKey = a.[Key]";
            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();

            dataAdapter.Fill(pagingD, scroll, 5, "issues");
            con.Close();
            dataGridView1.DataSource = pagingD;
            dataGridView1.DataMember = "issues";
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            label13.Text = "Books Found = " + ds.Tables[0].Rows.Count;

        }

        private void button6_Click(object sender, EventArgs e)
        {



        }


        private void button5_Click(object sender, EventArgs e)
        {
            //>
            scroll = scroll + 5;
            if (scroll > 13)
            {
                scroll = 8;
                count--;
            }
            pagingD.Clear();
            dataAdapter.Fill(pagingD, scroll, 5, "issues");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fileToolStripMenuItem.DropDownItems.Count > 0)
            {
                if (logiinsesssion == true) { fileToolStripMenuItem.DropDownItems[0].Text = "Logout"; }
                else
                {
                    fileToolStripMenuItem.DropDownItems[0].Text = "Login";
                }
            }

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileToolStripMenuItem.DropDownItems[0].Text == "Logout")
            {
                logiinsesssion = false;
                fileToolStripMenuItem.DropDownItems[0].Text = "Login";

            }
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            // this.Hide();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authors auth = new Authors();
            auth.Show();

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Show();
        }

        private void booksAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookAuthor bookauth = new BookAuthor();
            bookauth.Show();
        }

        private void booksCoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookCovers coverbook = new BookCovers();
            coverbook.Show();
        }

        private void bookSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSubjects sub = new BookSubjects();
            sub.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = @"C:\Users\Sakshi\Downloads\CH_2017\CH_2017";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd;

            sqlcmd = "select b.Title,b.FirstPublishDate,b.Description,a.Name,a.wikipedia,bs.Subject,bc.CoverFile from books as b inner join bookauthors ba on ba.BookKey = b.[Key] inner join authors a on ba.AuthorKey = a.[Key] inner join BookSubjects bs on bs.Book_Key = b.[Key] inner join BookCovers bc on bc.Book_Key = b.[Key]";


            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingD);
            // dataAdapter.Fill(pagingD, scroll, 5, "customers");
            con.Close();
            //label4.Text = pagingD.Tables[0].Rows[0][0].ToString();
            label5.Text = pagingD.Tables[0].Rows[0][1].ToString();
            label6.Text = pagingD.Tables[0].Rows[0][2].ToString();
            linkLabel1.Text = pagingD.Tables[0].Rows[0][3].ToString();
            //label8.Text = pagingD.Tables[0].Rows[0][4].ToString();
            label9.Text = pagingD.Tables[0].Rows[0][5].ToString();
            //label10.Text = pagingD.Tables[0].Rows[0][6].ToString();
            auth = pagingD.Tables[0].Rows[0][3].ToString();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void circulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circulation circulation = new Circulation();
            circulation.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            string title = dataGridView1.Rows[index].Cells[0].Value.ToString();
            //label14.Text = title;
            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd;

            sqlcmd = "select b.Title,b.FirstPublishDate,b.Description,a.Name,a.wikipedia,bs.Subject,bc.CoverFile from books as b inner join bookauthors ba on ba.BookKey = b.[Key] inner join authors a on ba.AuthorKey = a.[Key] inner join BookSubjects bs on bs.Book_Key = b.[Key] inner join BookCovers bc on bc.Book_Key = b.[Key] where b.Title='" + title + "'";


            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingD);
            // dataAdapter.Fill(pagingD, scroll, 5, "customers");
            con.Close();
            label4.Text = pagingD.Tables[0].Rows[0][0].ToString();
            label5.Text = pagingD.Tables[0].Rows[0][1].ToString();
            label6.Text = pagingD.Tables[0].Rows[0][2].ToString();
            linkLabel1.Text = pagingD.Tables[0].Rows[0][3].ToString();
            //label8.Text = pagingD.Tables[0].Rows[0][4].ToString();
            label9.Text = pagingD.Tables[0].Rows[0][5].ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            auth = linkLabel1.Text;
            AuthorDisplay frm = new AuthorDisplay(auth);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conS = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd;
            sqlcmd = "select b.Title,a.Name from books as b inner join bookauthors ba on ba.BookKey = b.[Key] inner join authors a on ba.AuthorKey = a.[Key] where Title='" + txttitle.Text + "'or Name ='" + txtauthor.Text + "'";

            SqlConnection con = new SqlConnection(conS);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();
           // dataAdapter.Fill(pagingD);
             dataAdapter.Fill(pagingD, scroll, 5, "issues");
            con.Close();
            if (pagingD.Tables[0].Rows.Count > 0) { dataGridView1.DataSource = pagingD.Tables[0]; }
            else
            {
                MessageBox.Show("No entry Matched the search criteria");
                txtauthor.Text = "";
                txttitle.Text = "";
                txtsubtitle.Text = "";
                sqlcmd= "select b.Title,a.Name from books as b inner join bookauthors ba on ba.BookKey = b.[Key] inner join authors a on ba.AuthorKey = a.[Key]";
                SqlConnection scon = new SqlConnection(conS);
                dataAdapter = new SqlDataAdapter(sqlcmd, scon);
                pagingD = new DataSet();
                scon.Open();
                //dataAdapter.Fill(pagingD);
                dataAdapter.Fill(pagingD, scroll, 5, "issues");
                scon.Close();
                dataGridView1.DataSource = pagingD.Tables[0];

            }
            if(txtsubtitle.Text!=""&& (txttitle.Text == "" || txtauthor.Text == ""))
            {
                MessageBox.Show("Enter either of author or title to search");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

        
    

