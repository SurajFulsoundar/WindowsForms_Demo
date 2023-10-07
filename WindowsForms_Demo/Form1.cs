using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text =="suraj" && txtpassword.Text == "0000")
            {
                MessageBox.Show("Login Successful");
               // Form2 form2 = new Form2();
               // form2.Show();

                MdiForm obj = new MdiForm();
                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }
    }
}
