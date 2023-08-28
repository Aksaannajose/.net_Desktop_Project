using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardetails
{
    public partial class Changepassword : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader rdr;
        String sql;

        conctnclass obj = new conctnclass();
        public Changepassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == textBox2.Text)
             {
                sql = "update Login set Password='" +textBox1.Text + "' where Username='" + Form1.User + "'";
                obj.insupdel(sql);

                MessageBox.Show("Password Sucessfully changed");


             }
            else
            {
                MessageBox.Show("Retry");

            }
        }
    }
}
