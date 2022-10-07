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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            showEquipment();
        }

        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=login1");

   
  
        private void showEquipment()
        {
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=login1;");
            DataSet ds = new DataSet();
            conn.Open();
       
                sqll1 = $"SELECT * FROM status WHERE status = 'จอง' and Username Like '{textBox1.Text}%'  and zone Like '{comboBox1.Text}%' ";
   
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = sqll1;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0];

        }

        int editID;
        string data;
        private void delete_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=login1;");
            data = "UPDATE status SET Username = '-' ,status = 'ว่าง', PhoneNumber = '-' WHERE ID = '" + editID + "'";
            MySqlCommand cmd = new MySqlCommand(data, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            string message = "คุณต้องการลบข้อมูลนี้ใช่หรือไม่";
            string title = "คำเตือน";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message,title,buttons);

            if (result == DialogResult.OK)
            {
                if (rows > 0)
                {
                    MessageBox.Show("ลบข้อมูลสำเร็จ");
                    showEquipment();

                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("ยกเลิกสำเร็จ");
                showEquipment();
            }
        }
        string sqll1;
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            showEquipment();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=login1;");
            DataSet ds = new DataSet();
            conn.Open();
        
            sqll1 = $"SELECT * FROM status WHERE status = 'จอง'";
       
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = sqll1;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form3_Shown(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)  //back
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            showEquipment();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; // เมื่อกดที่ textBox1 ข้อความที่แสดงไว้จะหายไป
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString()); // ทุกครั้งที่กด dataGridView จะเก็บข้อมูลไปไว้ที่ editID

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
