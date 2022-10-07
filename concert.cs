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
    public partial class concert : Form
    {
        public concert()
        {
            InitializeComponent();
        }

        public static string c;
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c = comboBox1.Text;
            if (MessageBox.Show("คุณต้องการเลือกรอบการแสดงนี้ใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

            }
            else
            {
                MessageBox.Show("ยกเลิกสำเร็จ");

            }

        }

        private void button1_Click(object sender, EventArgs e) //ดำเนินการต่อ
        {
            if (comboBox1.Text != "")
            {
                zone zone = new zone();
                zone.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกวันที่");
            }
        }


    }
}
