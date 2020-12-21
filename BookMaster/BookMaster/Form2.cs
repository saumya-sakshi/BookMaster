using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMaster
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool loginsession = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text=="admin1234")
            {
                MessageBox.Show("Login Successful");
                loginsession = true;
                Form1 frm1 = new Form1(true);
                frm1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check  your username and password");
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form1 frm1 = new Form1(false);
            frm1.Show();
            this.Close();
        }
    }
}
