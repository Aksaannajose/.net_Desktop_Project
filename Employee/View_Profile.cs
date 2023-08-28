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
    public partial class View_Profile : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlDataAdapter adp;
        String sql;

        cntnclass obj = new cntnclass();



        public View_Profile()
        {
            InitializeComponent();
        }

        private void View_Profile_Load(object sender, EventArgs e)
        {
            sql = "select * from Registration where Username='"+Form1.User+"'";
            rdr = obj.Getdata(sql);

            if(rdr != null )
            {
                if(rdr.Read())
                {
                    label7.Text = rdr.GetString(1);
                    label8.Text = rdr.GetString(2);
                    label9.Text = rdr.GetString(3);
                    label10.Text = rdr.GetString(4);
                    label11.Text = rdr.GetString(5);

                }
            }
            rdr.Close();


                

        }
    }
}
