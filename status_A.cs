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
    public partial class status_A : Form
    {
        public status_A()
        {
            InitializeComponent();
        }

        MySqlConnection Coom = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=login1;");

        string sql_6;
        private void A1(string ที่นั่ง)

        {
            Form2.zone = ที่นั่ง;
            string conn_6 = "datasource=127.0.0.1;port=3306;username=root;password=;database=login1;";
            //if (concert.c == "Sat  12  July  2022  7 P.M.")
            //{
                sql_6 = "UPDATE status SET " +
                "Username= '" + Form2.user + "',status= 'จอง',PhoneNumber= '" + Form2.phone + "' WHERE" +
                " zone= '" + comboBox1.Text + ที่นั่ง + "' and Date_And_Time='"+concert.c+"' ";
         
            //}
            //else if (concert.c == "Sun  13  July  2022  8  P.M.")
            //{
            //    sql_6 = "UPDATE status_a2 SET " +
            //    "Username= '" + Form2.user + "',status= 'จอง',PhoneNumber= '" + Form2.phone + "' WHERE zone= '" + ที่นั่ง + "' ";
            //}

            MySqlConnection con_6 = new MySqlConnection(conn_6);
            MySqlCommand cmd_6 = new MySqlCommand(sql_6, con_6);
            con_6.Open();
            int rows_6 = cmd_6.ExecuteNonQuery();
            con_6.Close();
          
            status_();
        }

        string sql;
        private void status_()
        {
            button1.BackColor = Color.Lime;
            button2.BackColor = Color.Lime;
            button3.BackColor = Color.Lime;
            button4.BackColor = Color.Lime;
            button5.BackColor = Color.Lime;
            button6.BackColor = Color.Lime;
            button7.BackColor = Color.Lime;
            button8.BackColor = Color.Lime;
            button9.BackColor = Color.Lime;
            button10.BackColor = Color.Lime;
            button11.BackColor = Color.Lime;
            button12.BackColor = Color.Lime;
            button13.BackColor = Color.Lime;
            button14.BackColor = Color.Lime;
            button15.BackColor = Color.Lime;
            button16.BackColor = Color.Lime;
            button17.BackColor = Color.Lime;
            button18.BackColor = Color.Lime;
            button19.BackColor = Color.Lime;
            button20.BackColor = Color.Lime;
            button21.BackColor = Color.Lime;
            button22.BackColor = Color.Lime;
            button23.BackColor = Color.Lime;
            button24.BackColor = Color.Lime;
            button25.BackColor = Color.Lime;
            button26.BackColor = Color.Lime;
            button27.BackColor = Color.Lime;
            button28.BackColor = Color.Lime;
            button29.BackColor = Color.Lime;
            button30.BackColor = Color.Lime;
            button31.BackColor = Color.Lime;
            button32.BackColor = Color.Lime;
            button33.BackColor = Color.Lime;
            button34.BackColor = Color.Lime;
            button35.BackColor = Color.Lime;
            button36.BackColor = Color.Lime;
            button37.BackColor = Color.Lime;
            button38.BackColor = Color.Lime;
            button39.BackColor = Color.Lime;
            button40.BackColor = Color.Lime;
            button41.BackColor = Color.Lime;
            button42.BackColor = Color.Lime;
            button43.BackColor = Color.Lime;
            button44.BackColor = Color.Lime;
            button45.BackColor = Color.Lime;
            button46.BackColor = Color.Lime;
            button47.BackColor = Color.Lime;
            button48.BackColor = Color.Lime;
            button49.BackColor = Color.Lime;
            button50.BackColor = Color.Lime;

            //if (concert.c == "Sat  12  July  2022  7 P.M.")
            //{
                sql = $"SELECT * FROM `status` WHERE zone Like '{comboBox1.Text}%' and Date_And_Time='{concert.c}' ";
            //}
            //else if (concert.c == "Sun  13  July  2022  8  P.M.")
            //{
            //    sql = "SELECT * FROM `status`";
            //}
            MySqlCommand cmd = new MySqlCommand(sql, Coom);
            Coom.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            int i = 1;
            if (comboBox1.Text == "A")
            {
                i = 0;
                if(concert.c== "Sun 13 July 2022 8 P.M.")
                {
                    i += 50;
                }
            }
            if (comboBox1.Text == "B")
            {
                i = 100;
                if (concert.c == "Sun 13 July 2022 8 P.M.")
                {
                    i += 50;
                }
            }
            if (comboBox1.Text == "C")
            {
                i = 200;
                if (concert.c == "Sun 13 July 2022 8 P.M.")
                {
                    i += 50;
                }
            }
            if (comboBox1.Text == "D")
            {
                i = 300;
                if (concert.c == "Sun 13 July 2022 8 P.M.")
                {
                    i += 50;
                }
            }
            if (comboBox1.Text == "E")
            {
                i = 400;
                if (concert.c == "Sun 13 July 2022 8 P.M.")
                {
                    i += 50;
                }
            }
            
            while (reader.Read())
            {
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 1 + i)
                {
                    button1.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 2 + i)

                {
                    button2.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 3 + i)

                {
                    button3.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 4 + i)

                {
                    button4.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 5 + i)
                {
                    button5.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 6 + i)
                {
                    button6.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 7 + i)
                {
                    button7.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 8 + i)
                {
                    button8.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 9 + i)
                {
                    button9.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 10 + i)
                {
                    button10.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 11 + i)
                {
                    button11.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 12 + i)
                {
                    button12.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 13 + i)
                {
                    button13.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 14 + i)
                {
                    button14.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 15 + i)
                {
                    button15.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 16 + i)
                {
                    button16.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 17 + i)
                {
                    button17.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 18 + i)
                {
                    button18.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 19 + i)
                {
                    button19.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 20 + i)
                {
                    button20.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 21 + i)
                {
                    button21.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 22 + i)
                {
                    button22.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 23 + i)
                {
                    button23.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 24 + i)
                {
                    button24.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 25 + i)
                {
                    button25.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 26 + i)
                {
                    button26.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 27 + i)
                {
                    button27.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 28 + i)
                {
                    button28.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 29 + i)
                {
                    button29.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 30 + i)
                {
                    button30.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 31 + i)
                {
                    button31.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 32 + i)
                {
                    button32.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 33 + i)
                {
                    button33.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 34 + i)
                {
                    button34.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 35 + i)
                {
                    button35.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 36 + i)
                {
                    button36.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 37 + i)
                {
                    button37.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 38 + i)
                {
                    button38.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 39 + i)
                {
                    button39.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 40 + i)
                {
                    button40.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 41 + i)
                {
                    button41.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 42 + i)
                {
                    button42.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 43 + i)
                {
                    button43.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 44 + i)
                {
                    button44.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 45 + i)
                {
                    button45.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 46 + i)
                {
                    button46.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 47 + i)
                {
                    button47.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 48 + i)
                {
                    button48.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 49 + i)
                {
                    button49.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetInt32("ID") == 50 + i)
                {
                    button50.BackColor = Color.Red;
                }
            }
            Coom.Close();
        }
        private void status_Load(object sender, EventArgs e)
        {
            status_();
        }
        private void button50_(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            zone zone = new zone();
            zone.Show();
            this.Hide();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("กรุณาเลือก zone หรือ ที่นั่ง");
            }
            else
            {
                Form2 Form2 = new Form2();
                Form2.zone = comboBox1.Text + textBox1.Text;
                Form2.Show();
                this.Hide();
            }

        }

        private void status_Shown(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            status_();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text=="")
            {
                MessageBox.Show("กรุณาเลือก zone หรือ ที่นั่ง");
            }
            else if (MessageBox.Show("คุณต้องการจองที่นั่งใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                A1(textBox1.Text);
            }
            else
            {
                MessageBox.Show("ยกเลิกสำเร็จ");
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("กรุณาเลือก zone หรือ ที่นั่ง");
            }
            else if (MessageBox.Show("คุณต้องการที่จะยกเลิกใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Form2.zone = textBox1.Text;
                string conn_6 = "datasource=127.0.0.1;port=3306;username=root;password=;database=login1;";

                sql_6 = "UPDATE status SET " +
                "Username= '-',status= 'ว่าง',PhoneNumber= '-' WHERE" +
                " zone= '" + comboBox1.Text + textBox1.Text + "' and Date_And_Time='" + concert.c + "' ";

                MySqlConnection con_6 = new MySqlConnection(conn_6);
                MySqlCommand cmd_6 = new MySqlCommand(sql_6, con_6);
                con_6.Open();
                int rows_6 = cmd_6.ExecuteNonQuery();
                con_6.Close();
                 textBox1.Text = "";
                status_();
            }
            else
            {
                MessageBox.Show("ยกเลิกสำเร็จ");
            }
            
        }
    }
}
