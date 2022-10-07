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
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        public static string user_, phone_, zone_, price_, total_;

        string sql_;
        private void bill_Shown(object sender, EventArgs e)
        {
            
            username.Text = Form2.user;
            phonenumber.Text = Form2.phone;
            DateTime.Text = concert.c;
            zones.Text = Form2.zone;
            prices.Text = Form2.price;
            total_amount.Text = Form2.total;
       
                sql_ = "SELECT * FROM `zones` WHERE zone = '" + zones + "'";
 
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=login1;");
            MySqlCommand cmd = new MySqlCommand(sql_, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                prices.Text = reader.GetString(2);
                total_amount.Text = Convert.ToString(reader.GetInt32(2) + 40);
            }

        }
        private void button1_Click(object sender, EventArgs e) //generate
        {
            txtResult.Clear();
            txtResult.Text += "************************************************************\n\n";
            txtResult.Text += "************ Receipt The Ticket Con GOT 7 ************\n\n";
            txtResult.Text += "************************************************************\n\n";
            txtResult.Text += "Date  : " + System.DateTime.Now + " \n\n\n\n";

            txtResult.Text += "Username : " + username.Text + " \n\n";
            txtResult.Text += "PhoneNumber : " + phonenumber.Text + " \n\n";
            txtResult.Text += "Date  And  Time : " + DateTime.Text + " \n\n";
            txtResult.Text += "Zone : " + zones.Text + " \n\n";
            txtResult.Text += "Price : " + prices.Text + " \n\n";
            txtResult.Text += "Service : " + service.Text + " \n\n";
            txtResult.Text += "Total  Amount : " + total_amount.Text + " \n\n\n\n\n";

            txtResult.Text += "***************  Thank you for using our service  ***************\n";
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text, new Font("Microsoft  Sans  Serif", 18, FontStyle.Bold), Brushes.Black, new Point(50, 100));
           
        }

        private void button2_Click(object sender, EventArgs e) //back
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void print_Click(object sender, EventArgs e) //print
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //logout
        {
            if (MessageBox.Show("คุณต้องการที่จะออกจากระบบใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("ขอบคุณที่ใช้บริการ");

                Form1 Form1 = new Form1();
                Form1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("ยกเลิกสำเร็จ");
            }
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void service_Click(object sender, EventArgs e)
        {

        }
    }
}
