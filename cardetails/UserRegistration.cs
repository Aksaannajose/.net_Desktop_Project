using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardetails
{
    public partial class UserRegistration : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader rdr;
        String sql;
        int temp;

        conctnclass obj = new conctnclass();


        public UserRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if(temp == 1)
              {
                sql = "insert into Login values('" + uname.Text + "','" + pswd.Text + "','User')";
                obj.insupdel(sql);

                sql = "insert into UserRegistration values('" + textname.Text + "','" + textnum.Text + "','" + textmail.Text + "','" + uname.Text + "')";
                obj.insupdel(sql);

                MessageBox.Show("Registered Sucessfully", "sucess", MessageBoxButtons.OKCancel);

              }
        }

        private void checkuser()
        {
            temp = 0;
            sql = "select Username from Login where Username='" +uname.Text + "'";

            rdr = obj.Getdata(sql);

            if (rdr.Read())
            {
                label7.Text = "Username already exist";

            }
            else
            {
                temp = 1;


                MessageBox.Show("Not Registered");
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkuser();

        }
    }
}
