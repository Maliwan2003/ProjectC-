using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public static string user, phone, conname, venue, dateandtime, zone, price, service, total,status;

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //confirm
        {
            if (MessageBox.Show("คุณต้องการที่จะยืนยันใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bill bill = new bill();
                bill.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("ยกเลิกสำเร็จ");
            }
        }

        string sql;
        private void Form2_Shown(object sender, EventArgs e)
        {
            label11.Text = user;
            label12.Text = phone;
            label15.Text = concert.c; //วันที่แสดงโชว์
            label16.Text = zone;
            sql = "SELECT * FROM `zones` WHERE zone = '" + zone + "'";
            
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=login1;");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                label17.Text=reader.GetString(2);
                price = reader.GetString(2);
                label19.Text=Convert.ToString(reader.GetInt32(2)+40);
                total = Convert.ToString(reader.GetInt32(2) + 40);
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)// back
        {
            this.Hide();
            zone zone = new zone();
            zone.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
