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
    public partial class Form1 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader rdr;
        String sql;

        String Usertype;


        conctnclass obj = new conctnclass();

        public static string User;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User = uname.Text;
            sql = "select Usertype from Login where Username='" + uname.Text + "'and password='"+pswd.Text+"'";
           
            rdr = obj.Getdata(sql);

                if(rdr.Read())
                {
                 Usertype = rdr.GetString(0);
                 
                 if(Usertype == "Admin")
                  {
                        Adminhome obj = new Adminhome();
                        obj.Show();

                  }
                    else if (Usertype == "User")
                          {
                           Userhome obj = new Userhome();
                           obj.Show();

                          }
                    else
                    {
                        label4.Text = "Invalid Username or Password";

                    }
                }
                else
                {
                    label4.Text = "Invalid Username or Password";
                }
            
        }

                   private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                    {
                    UserRegistration obj = new UserRegistration();
                    obj.ShowDialog();
                    }

                    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                     {
                      Changepassword obj = new Changepassword();
                      obj.ShowDialog();

                     }
    }
}
