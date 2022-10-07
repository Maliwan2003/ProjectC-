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
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Fname.Text == "" || Lname.Text == "" || phone.Text == "" || user.Text == "" || pass.Text == "" || confirm.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง");
            }
            else if (phone.Text.Length != 10)
            {
                MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ของท่านให้ครบ 10 หลัก");
            }
            else if (pass.Text != confirm.Text)
            {
                MessageBox.Show("รหัสผ่านไม่ถูกต้อง");

            }
            else
            {
                string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=login1;";
                string sql = "INSERT INTO registers (FirstName,LastName,PhoneNumber,UserName,Password,Confirmpass) VALUES" +
                    "('" + Fname.Text + "','" + Lname.Text + "','" + phone.Text + "','" + user.Text + "','" + pass.Text + "','" + confirm.Text + "') ";
                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    MessageBox.Show("สำเร็จ");
                    Form1 Form1 = new Form1();
                    Form1.Show();
                    this.Hide();
                    Form2.user= user.Text;
                    Form2.phone = phone.Text;
                   
                }
            }
        }

        private void Fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl (e.KeyChar) && !char.IsLetter(e.KeyChar)) // เช็คไม่ให้กรอกพยัญชนะภาษาไทย
            {
                e.Handled = true;
            }
        }

        private void Lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e) // เช็คว่าต้องเป็นภาษาอังกฤษ
        {
            if (Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // เช็คว่าต้องเป็นตัวเลขเท่านั้น
            {
                e.Handled = true;
            }
        }
    }
}
