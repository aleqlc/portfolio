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
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using System.Diagnostics;
using System.IO;
using System.Windows.Annotations;

namespace WindowsFormsApp1
{
    
    public partial class Form2 : Form
    {
        inotify inotify1 = new inotify();

        public Form2()
        {
            InitializeComponent();
            fillCombo();
            fillListbox();
            textBox_author.DataBindings.Add("Text", inotify1, "Author",
                true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_title.DataBindings.Add("Text", inotify1, "Title",
                true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_description.DataBindings.Add("Text", inotify1, "Description",
                true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_profile.DataBindings.Add("Text", inotify1, "Profile",
                true, DataSourceUpdateMode.OnPropertyChanged);
        }

        void fillCombo()
        {
            string constring = "datasource = localhost; port=3306; username=root; password=root";
            string Query = "select * from opentutorials.topic_backup";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sTitle = myReader.GetString("title");
                    comboBox1.Items.Add(sTitle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillListbox()
        {
            string constring = "datasource = localhost; port=3306; username=root; password=root";
            string Query = "select * from opentutorials.topic_backup";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sTitle = myReader.GetString("title");
                    listBox1.Items.Add(sTitle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }


        private void button_save_Click(object sender, EventArgs e)//insert
        {
            /*byte[] imageBt = null;
            FileStream fstream = new FileStream(this.textBox_imagePath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);*/

            string constring = "datasource = localhost; port=3306; username=root; password=root";
            string Query = "insert into opentutorials.topic_backup (author,title,description,profile,gender,DOB)" +
                            "value('" + inotify1.Author + "','" + inotify1.Title + "','" + inotify1.Description + "','" + inotify1.Profile + "','" + inotify1.Gender + "','" + this.dateTimePicker1.Text + "')";
            /*string Query = "insert into opentutorials.topic_backup (author,title,description,profile,gender,DOB,image)" +
                            "value('"+this.textBox_author.Text+"','"+this.textBox_title.Text+"','"+this.textBox_description.Text+"','"+this.textBox_profile.Text+ "','" + gender + "','"+this.dateTimePicker1.Text+"',@IMG)";*/
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                /*cmdDataBase.Parameters.Add(new MySqlParameter("@IMG", imageBt));*/
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("저장되었습니다");

                while(myReader.Read())
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost; port=3306; username=root; password=root";
            string Query = "update opentutorials.topic_backup set author='" + inotify1.Author + "',title='" + inotify1.Title + "',description='" + inotify1.Description + "',profile='" + inotify1.Profile + "' where author='" + inotify1.Author + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("수정되었습니다");

                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost; port=3306; username=root; password=root";
            string Query = "delete from opentutorials.topic_backup where author='" + inotify1.Author+"';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("삭제되었습니다");

                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_addstring_Click(object sender, EventArgs e)
        {
            string titleStr = textBox_title.Text;
            comboBox1.Items.Add(titleStr);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource = localhost; port=3306; username=root; password=root";
            string Query = "select * from opentutorials.topic_backup where title='"+comboBox1.Text+"';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sAuthor = myReader.GetString("author").ToString();
                    string sTitle = myReader.GetString("title").ToString();
                    string sDescription = myReader.GetString("description").ToString();
                    string sProfile = myReader.GetString("profile").ToString();

                    inotify1.Author = sAuthor;
                    inotify1.Title = sTitle;
                    inotify1.Description = sDescription;
                    inotify1.Profile = sProfile;

                    byte[] imgg = (byte[])(myReader["image"]);
                    if(imgg == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource = localhost; port=3306; username=root; password=root";
            string Query = "select * from opentutorials.topic_backup where title='" + listBox1.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sAuthor = myReader.GetString("author").ToString();
                    string sTitle = myReader.GetString("title").ToString();
                    string sDescription = myReader.GetString("description").ToString();
                    string sProfile = myReader.GetString("profile").ToString();

                    inotify1.Author = sAuthor;
                    inotify1.Title = sTitle;
                    inotify1.Description = sDescription;
                    inotify1.Profile = sProfile;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_loadTable_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost; port=3306; username=root; password=root";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select id as '아이디',author as '저자', title as '제목', description as '설명', profile as '프로필',gender as '성별', DOB as '생년월일' from opentutorials.topic_backup;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbDataSet = new DataTable();
                sda.Fill(dbDataSet);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataSet;
                dataGridView1.DataSource = bSource;
                sda.Update(dbDataSet);

                //gridview의 정보를 엑셀파일로 내보내기
                DataSet ds = new DataSet("New_DataSet");
                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                sda.Fill(dbDataSet);
                ds.Tables.Add(dbDataSet);
                ExcelLibrary.DataSetHelper.CreateWorkbook("MyExcelFile.xls", ds);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button_loadchart_Click(object sender, EventArgs e)
        {
            /*this.chart1.Series["age"].Points.AddXY("Kim", 15);
            this.chart1.Series["age"].Points.AddXY("Lee", 32);
            this.chart1.Series["age"].Points.AddXY("Choi", 20);
            this.chart1.Series["age"].Points.AddXY("Park", 51);

            this.chart1.Series["score"].Points.AddXY("Kim", 70);
            this.chart1.Series["score"].Points.AddXY("Lee", 55);
            this.chart1.Series["score"].Points.AddXY("Choi", 90);
            this.chart1.Series["score"].Points.AddXY("Park", 85);*/

            string constring = "datasource = localhost; port=3306; username=root; password=root";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from opentutorials.topic_backup;", conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    this.chart1.Series["id"].Points.AddXY(myReader.GetString("author"), myReader.GetInt32("id"));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("정말로 종료하시겠습니까?", "Exit", MessageBoxButtons.YesNo);
            
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                
                textBox_author.Text = row.Cells["저자"].Value.ToString();
                textBox_title.Text = row.Cells["제목"].Value.ToString();
                textBox_description.Text = row.Cells["설명"].Value.ToString();
                textBox_profile.Text = row.Cells["프로필"].Value.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            inotify1.Gender = "남자";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            inotify1.Gender = "여자";
        }

        private void button_openfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button_goForm5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button_loadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            dig.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if(dig.ShowDialog() == DialogResult.OK)
            {
                string picLoc = dig.FileName.ToString();
                textBox_imagePath.Text = picLoc;
                pictureBox1.ImageLocation = picLoc;
            }
        }
    }
}
