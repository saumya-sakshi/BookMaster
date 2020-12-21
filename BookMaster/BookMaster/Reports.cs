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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        SqlDataAdapter dataAdapter;
        DataSet pagingD;
        string tab ;
        private void Reports_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd = "select Book as Title , Customer,[Date of issue],DATEADD(DD,21,[Date of issue]) as Return_Until from issues where [Return date] is  null ";
            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingD);
            // dataAdapter.Fill(pagingD, scroll, 5, "customers");
            con.Close();
            dataGridView1.DataSource = pagingD.Tables[0];
        }

        private void Reminders_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd = "select Book as Title , Customer,[Date of issue],DATEADD(DD,21,[Date of issue]) as Return_Until from issues where [Return date] is null ";
            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingD);
            // dataAdapter.Fill(pagingD, scroll, 5, "customers");
            con.Close();
            dataGridView1.DataSource = pagingD.Tables[0];
        }

        private void History_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd = "Select Customer,[Date of issue] ,[Return date]  from issues where [Book ID] = '" + txtbookid.Text + "'";
            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingD);
            // dataAdapter.Fill(pagingD, scroll, 5, "customers");
            con.Close();
            dataGridView2.DataSource = pagingD.Tables[0];


        }

        private void txtbookid_TextChanged(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-RP9S7ET;Initial Catalog=BookMaster;Integrated Security=True";
            string sqlcmd = "Select Customer,[Date of issue] ,[Return date]  from issues where [Book ID] = '" + txtbookid.Text + "'";
            SqlConnection con = new SqlConnection(conString);
            dataAdapter = new SqlDataAdapter(sqlcmd, con);
            pagingD = new DataSet();
            con.Open();
            dataAdapter.Fill(pagingD);
            // dataAdapter.Fill(pagingD, scroll, 5, "customers");
            con.Close();
            dataGridView2.DataSource = pagingD.Tables[0];


        }

        private void btnexp_Click(object sender, EventArgs e)
        {
            if (tab == "Remind")
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs("d:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
            else if (tab == "History")
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
                for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs("d:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
           
        }

        private void tabcontrol1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrol1.TabIndex == 0)
            {
                tab = "Remind";

            }
            else if (tabcontrol1.TabIndex == 1)
            {
                tab = "History";
            }
        }
    }
}
