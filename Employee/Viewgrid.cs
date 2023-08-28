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
    public partial class Viewgrid : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlDataAdapter adp;
        String sql;
        DataSet ds;


        cntnclass obj = new cntnclass();
        public Viewgrid()
        {
            InitializeComponent();
        }

        private void Viewgrid_Load(object sender, EventArgs e)
        {
            sql = "select * from Registration";
            ds = obj.Grid(sql);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
