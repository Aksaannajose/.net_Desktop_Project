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

namespace Employee
{
    public partial class changepassword : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlDataAdapter adp;
        String sql;
        DataSet ds;


        cntnclass obj = new cntnclass();

        public changepassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                sql = "update Login set Password='" + textBox1.Text + "' where Username = '" + Form1.User + "'";
                obj.insupdel(sql);

                MessageBox.Show("Password change sucessfully", "sucess", MessageBoxButtons.OKCancel);

            }
            else
            {


                MessageBox.Show("Retry");

            }
        }
    }
}
