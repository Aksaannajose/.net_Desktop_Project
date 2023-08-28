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
    public partial class Registration : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader rdr;
        String sql;

        conctnclass obj = new conctnclass();


        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "insert into Addcar values('" + textrgnum.Text + "','" + textmodel.Text + "','" + textmake.Text + "','" + textbody.Text + "','" + textprice.Text + "','" + textyear.Text + "','" + textinterior.Text + "','" + textexterior.Text + "')";
            obj.insupdel(sql);

            MessageBox.Show("Data Added Sucessfully", "sucess", MessageBoxButtons.OKCancel);

        }
    }
}
