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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost; port=3306; username=root; password=root";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("select * opentutorials.topic_backup", myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                
                myConn.Open();
               
                DataSet ds = new DataSet();
                MessageBox.Show("연결되었습니다.");
               
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost; port=3306; username=root; password=root";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand selectCommand = new MySqlCommand("select * from opentutorials.topic_backup where user_name='"
                                                                + this.textBox_username.Text + "' and password = '" + this.textBox_password.Text + "'", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = selectCommand.ExecuteReader();
                int count = 0;

                while(myReader.Read())
                {
                    count = count+1;
                }

                if (count == 1)
                {
                    MessageBox.Show("로그인성공");
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                else if(count>1)
                {
                    MessageBox.Show("중복되는 유저네임과 패스워드가 있습니다.");
                }
                else
                {
                    MessageBox.Show("유저네임과 패스워드가 일치하지 않습니다.");
                }
                
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label_time.Text = dateTime.ToString();
            this.progressBar1.Increment(1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("정말로 종료하시겠습니까?", "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
