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
    public partial class Edit_Profile : Form
    {


        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlDataAdapter adp;
        String sql;

        cntnclass obj = new cntnclass();

        public Edit_Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update Registration set Address='" + address.Text + "',Pincode='" + pincode.Text + "',Contact_number='" + contact.Text + "',Email='" + email.Text + "'";
                obj.insupdel(sql);

                MessageBox.Show("Profile Updated Sucessfully");

            }
             catch(Exception ex)
            {

            }

        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {
            try
            {
                sql = "select * from Registration where Username = '"+Form1.User+"'";
                rdr = obj.Getdata(sql);

                if(rdr.Read())
                {
                    label3.Text = rdr.GetString(1);
                    address.Text = rdr.GetString(2);
                    pincode.Text = rdr.GetString(3);
                    contact.Text = rdr.GetString(4);
                    email.Text = rdr.GetString(5);

                }
            }
             catch(Exception ex)
            {

            }
           rdr.Close();

        }
    }
}
