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
    public partial class deletecardetails : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adp;
        SqlDataReader rdr;
        String sql;

        conctnclass obj = new conctnclass();


        public deletecardetails()
        {
            InitializeComponent();
        }

        private void display()
        {
            comboBox1.Items.Clear();

            sql = "select Username from UserRegistration";
            rdr = obj.Getdata(sql);

            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr.GetString(0));
                    
            }
            rdr.Close();


        }

        private void deletecardetails_Load(object sender, EventArgs e)
        {
            display();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.SelectedItem.ToString()!=null)
                {
                    sql = "delete from UserRegistration where Username='" + comboBox1.SelectedItem.ToString() + "'";
                    obj.insupdel(sql);

                    sql = "delete from Login where Username='" + comboBox1.SelectedItem.ToString() + "'";
                    obj.insupdel(sql);

                    MessageBox.Show("Deleted");



                }
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
