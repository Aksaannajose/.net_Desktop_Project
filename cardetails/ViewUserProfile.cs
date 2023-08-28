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
    public partial class ViewUserProfile : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader rdr;
        String sql;
        int temp;

        conctnclass obj = new conctnclass();



        public ViewUserProfile()
        {
            InitializeComponent();
        }

        private void ViewUserProfile_Load(object sender, EventArgs e)
        {
            sql = "select * from UserRegistration where Username ='" + Form1.User + "'";
            rdr = obj.Getdata(sql);
         
                if(rdr.Read())
                {
                    label5.Text = rdr.GetString(1);
                    label6.Text = rdr.GetString(2);
                    label7.Text = rdr.GetString(3);


                }
            
            rdr.Close();


           
        }
    }
}
