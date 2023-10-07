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
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        private void employeeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Parent = this;
            form2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad obj = new Notepad();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
