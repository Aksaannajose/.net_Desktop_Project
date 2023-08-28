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
    public partial class Editprofile : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader rdr;
        String sql;

        conctnclass obj = new conctnclass();


        public Editprofile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update Addcar set Model='" + textmodel.Text + "',Make='" + textmake.Text + "',Body_style='" + textbody.Text + "',Price='" + textprice.Text + "',Year='" + textyear.Text + "',interior_color='" + textinterior.Text + "',Exterior_color='" + textexterior.Text + "'";
                obj.insupdel(sql);

                MessageBox.Show("Edit Sucessfully");

            }
             catch(Exception ex)
            {

            }
        }

        private void Editprofile_Load(object sender, EventArgs e)
        {
            try
            {
                sql = "select * from Addcar";

                rdr = obj.Getdata(sql);

                if(rdr.Read())
                {
                    label3.Text = rdr.GetString(1);
                    textmodel.Text = rdr.GetString(2);
                    textmake.Text = rdr.GetString(3);
                    textbody.Text = rdr.GetString(4);
                    textprice.Text = rdr.GetString(5);
                    textyear.Text = rdr.GetString(6);
                    textinterior.Text = rdr.GetString(7);
                    textexterior.Text = rdr.GetString(8);


                }

            }
             catch(Exception ex)
            {

            }
            rdr.Close();

        }
    }
}
