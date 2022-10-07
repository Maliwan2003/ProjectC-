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
    public partial class Form1 : Form
    {
        private void button1_Click(object sender, EventArgs e) //login
        {
            string sql = "SELECT * FROM `registers` WHERE username = '" + user.Text + "' and password = '" + pass.Text + "'  "; //เช็คว่าข้อมูลตรงกับที่มีใน db มั้ย
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=login1;");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("ยินดีต้อนรับเข้าสู่ระบบ");
                concert concert = new concert();
                concert.Show();
                this.Hide();
                Form2.user = user.Text;
                Form2.phone = reader.GetString("PhoneNumber");
            }
            else
            {
                MessageBox.Show("พบข้อผิดพลาด โปรดลองอีกครั้ง");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //showpass
        {
            if (checkBox1.Checked)
            {
                string checkBox1 = user.Text; // ถ้าคลิ๊ก show จะขึ้นตัวเลข ถ้าไม่คลิ๊กจะเป็น *
                pass.PasswordChar = '\0';
            }
            else
            {
                pass.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e) //Create account
        {
            sign_in sign_in = new sign_in();
            sign_in.Show();
            this.Hide();
        }


        private void user_KeyPress(object sender, KeyPressEventArgs e) // username
        {
            if (Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1) // เช็คว่าต้องกรอกเป็นภาษาอังกฤษเท่านั้น
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)// admin
        {
            string sql = "SELECT * FROM `admin` WHERE username = '" + user.Text + "' and password = '" + pass.Text + "'  ";
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=login1;");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                MessageBox.Show("ยินดีต้อนรับเข้าสู่ระบบ");
                Form3 Form3 = new Form3();
                Form3.Show();
                this.Hide();
                Form2.user = user.Text;

            }
            else
            {
                MessageBox.Show("พบข้อผิดพลาด โปรดลองอีกครั้ง");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}

