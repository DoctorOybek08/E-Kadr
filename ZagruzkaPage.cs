using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadr
{
    public partial class ZagruzkaPage : Form
    {
        public ZagruzkaPage()
        {
            InitializeComponent();
            this.BackColor = Color.Gray;
            this.TransparencyKey = Color.Gray;
           // label1.Text = "© " + DateTime.Now.Year + " UZB";
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
