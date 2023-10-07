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
    public partial class Form2 : Form
    {
        List<string> diptlist = new List<string>()
        {
            "HR","Admin","Sales","development","Tast","Marketing"
        };
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbdepartment.DataSource = diptlist;
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double bs = Convert.ToDouble(txtbasicsalary.Text);
            double hra = bs * 0.40;
            double ta = bs * 0.30;
            double da = bs * 0.20;
            double pf = bs * 0.12;
            double gross = (bs + hra + ta + da) - pf;



            txthra.Text = hra.ToString();
            txtta.Text = ta.ToString();
            txtda.Text = da.ToString();
            txtpf.Text = pf.ToString();
            txtgrosssalary.Text = gross.ToString();

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            string msg = txtempid.Text + "\n" + txtempname.Text + " \n " + cmbdepartment.Text + " \n " + txtgrosssalary.Text;
            lblmsg.Text = msg;
        }
    }
}
