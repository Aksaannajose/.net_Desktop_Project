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
    public partial class ViewProfile : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader rdr;
        String sql;

        conctnclass obj = new conctnclass();

        public ViewProfile()
        {
            InitializeComponent();
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            sql = "select * from Addcar";
            rdr = obj.Getdata(sql);

            //if(rdr!=null)
                if(rdr.Read())
                {
                    label10.Text = rdr.GetString(1);
                    label11.Text = rdr.GetString(2);
                    label12.Text = rdr.GetString(3);
                    label13.Text = rdr.GetString(4);
                    label14.Text = rdr.GetString(5);
                    label15.Text = rdr.GetString(6);
                    label16.Text = rdr.GetString(7);
                    label17.Text = rdr.GetString(8);

                }
            rdr.Close();

        }
    }
}
