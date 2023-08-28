using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardetails
{
    public partial class Adminhome : Form
    {
        public Adminhome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Viewgrid obj = new Viewgrid();
            obj.ShowDialog();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration obj = new Registration();
            obj.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Editprofile obj = new Editprofile();
            obj.ShowDialog();

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deletecardetails obj = new deletecardetails();
            obj.ShowDialog();

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewProfile obj = new ViewProfile();
            obj.ShowDialog();

        }
    } 

}
