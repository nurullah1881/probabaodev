using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i_inonu_sayfa.Visible = false;
            ii_inonu_sayfa.Visible = false;

        }

        private void i_inonu_kapat_Click(object sender, EventArgs e)
        {
            i_inonu_sayfa.Visible = false;
        }
        private void i_inonu_Click(object sender, EventArgs e)
        {

        }

        private void i_inonu_Click_1(object sender, EventArgs e)
        {
            i_inonu_sayfa.Visible = true;
        }

        private void ii_inonu_kapat_Click(object sender, EventArgs e)
        {
            ii_inonu_sayfa.Visible = false;

        }

        private void ii_inonu_Click(object sender, EventArgs e)
        {
            ii_inonu_sayfa.Visible = true;
        }
    }
}
