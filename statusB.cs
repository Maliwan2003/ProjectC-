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
    public partial class statusB : Form
    {
        public statusB()
        {
            InitializeComponent();
        }
        private void button50_(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการจองที่นั่งใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Control click = (Control)sender;
                click.BackColor = Color.Red;
                //A1(((Button)sender).Text);
            }
            else
            {
                MessageBox.Show("ยกเลิกสำเร็จ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
