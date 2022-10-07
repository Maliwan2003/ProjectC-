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
    public partial class status : Form
    {
        public status()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        MySqlConnection Coom = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=login1;");
        private void zone()
        {
            
        }
        string sql_6;
        private void A1(string ที่นั่ง)

        {
            Form2.zone = ที่นั่ง;
            string conn_6 = "datasource=127.0.0.1;port=3306;username=root;password=;database=login1;";
            if (concert.c == "Sat  12  July  2022  7 P.M.")
            {
                sql_6 = "UPDATE status SET " +
                "Username= '" + Form2.user + "',status= 'จอง',PhoneNumber= '" + Form2.phone + "' WHERE zone= '" + ที่นั่ง + "' ";
            }
            else if (concert.c == "Sun  13  July  2022  8  P.M.")
            {
                sql_6 = "UPDATE status2 SET " +
                "Username= '" + Form2.user + "',status= 'จอง',PhoneNumber= '" + Form2.phone + "' WHERE zone= '" + ที่นั่ง + "' ";
            }
            
            MySqlConnection con_6 = new MySqlConnection(conn_6);
            MySqlCommand cmd_6 = new MySqlCommand(sql_6, con_6);
            con_6.Open();
            int rows_6 = cmd_6.ExecuteNonQuery();
            con_6.Close();
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

            if (concert.c == "Sat  12  July  2022  7 P.M.")
            {
                sql = "SELECT * FROM `status`";
            }
            else if (concert.c == "Sun  13  July  2022  8  P.M.")
            {
                sql = "SELECT * FROM `status2`";
            }
            MySqlCommand cmd = new MySqlCommand(sql, Coom);
            Coom.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "1")
                {
                    button1.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "2")
                {
                    button2.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "3")
                {
                    button3.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "4")
                {
                    button4.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "5")
                {
                    button5.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "6")
                {
                    button6.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "7")
                {
                    button7.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "8")
                {
                    button8.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "9")
                {
                    button9.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "10")
                {
                    button10.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "11")
                {
                    button11.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "12")
                {
                    button12.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "13")
                {
                    button13.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "14")
                {
                    button14.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "15")
                {
                    button15.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "16")
                {
                    button16.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "17")
                {
                    button17.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "18")
                {
                    button18.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "19")
                {
                    button19.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "20")
                {
                    button20.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "21")
                {
                    button21.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "22")
                {
                    button22.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "23")
                {
                    button23.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "24")
                {
                    button24.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "25")
                {
                    button25.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "26")
                {
                    button26.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "27")
                {
                    button27.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "28")
                {
                    button28.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "29")
                {
                    button29.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "30")
                {
                    button30.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "31")
                {
                    button31.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "32")
                {
                    button32.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "33")
                {
                    button33.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "34")
                {
                    button34.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "35")
                {
                    button35.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "36")
                {
                    button36.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "37")
                {
                    button37.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "38")
                {
                    button38.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "38")
                {
                    button38.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "39")
                {
                    button39.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "40")
                {
                    button40.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "41")
                {
                    button41.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "42")
                {
                    button42.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "43")
                {
                    button43.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "44")
                {
                    button44.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "45")
                {
                    button45.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "46")
                {
                    button46.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "47")
                {
                    button47.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "48")
                {
                    button48.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "49")
                {
                    button49.BackColor = Color.Red;
                }
                if (reader.GetString("status") == "จอง" && reader.GetString("ID") == "50")
                {
                    button50.BackColor = Color.Red;
                }
            }
        }
        private void status_Load(object sender, EventArgs e)
        {

            status_();


        }
        private void button50_(object sender, EventArgs e)
        {
           if (MessageBox.Show("คุณต้องการจองที่นั่งใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
           {
                Control click = (Control)sender;
                click.BackColor = Color.Red;
                A1(((Button)sender).Text);
           }
           else
           {
                MessageBox.Show("ยกเลิกสำเร็จ");
           }
        }
    
        private void Back_Click(object sender, EventArgs e)
        {
            zone zone = new zone();
            zone.Show();
            this.Hide();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void status_Shown(object sender, EventArgs e)
        {

        }
    }
}
