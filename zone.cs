using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class zone : Form
    {
        public zone()
        {
            InitializeComponent();
        }

        private void zoneA_Click(object sender, EventArgs e)
        {
         
        }

        private void zoneB_Click(object sender, EventArgs e)
        {

        }

        private void zoneC_Click(object sender, EventArgs e)
        {

        }

        private void zoneD_Click(object sender, EventArgs e)
        {

        }

        private void zoneE_Click(object sender, EventArgs e)
        {
 
        }

        private void Back_Click(object sender, EventArgs e)
        {
            concert concert = new concert();
            concert.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            status_A status = new status_A();
            status.Show();
            this.Hide();
        }
    }

}
