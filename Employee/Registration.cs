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
    public partial class Registration : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlDataAdapter adp;
        String sql;

        int temp;


        cntnclass obj = new cntnclass();


        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(temp == 1)
            
            sql = "insert into Login values('" + uname.Text + "','" + pswd.Text + "','User')";
            obj.insupdel(sql);

            sql = "insert into Registration values('" + name.Text + "','" + address.Text + "','" + pincode.Text + "','" + contact.Text + "','" + email.Text + "','" + uname.Text + "')";
            obj.insupdel(sql);

            MessageBox.Show("Registered Sucessfully", "sucess", MessageBoxButtons.OKCancel);


        }
        private void checkuser()
        {
            temp = 0;

            sql = "select Username from Login where Username='" + uname.Text + "'";
            rdr = obj.Getdata(sql);

            if (rdr.Read())
            {
                label9.Text = "Username already exist";

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
