using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using ExcelDataReader;
using MySql.Data.MySqlClient;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button_table_Click(object sender, EventArgs e)
        {
            string constring = "datasource = localhost; port=3306; username=root; password=root";
            string Query = "create table opentutorials." + this.textBox_table.Text + " (author varchar(30) NOT NULL, title varchar(30), description varchar(30), profile varchar(30), PRIMARY KEY(author))";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("새로운 테이블이 생성되었습니다.");

                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }

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

        //데이터그리드뷰로 엑셀파일 불러오기
        DataSet result;
        private void button_Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter="Excel Workbook|*.xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    //reader.IsFirstRowAsColumnNames = true;
                    result = reader.AsDataSet();
                    comboBox_Sheet.Items.Clear();
                    foreach(DataTable dt in result.Tables)
                    {
                        comboBox_Sheet.Items.Add(dt.TableName);
                    }
                    reader.Close();
                }
            }
        }

        private void comboBox_Sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = result.Tables[comboBox_Sheet.SelectedIndex];
        }


        //웹캠
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void button_Start_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox_Camera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                comboBox_Camera.Items.Add(filterInfo.Name);
            }
            comboBox_Camera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();



            //비디오편집기
            axTimelineControl1.SetPreviewWnd((int)pictureBox3.Handle);
        }

        private void button_goMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }


        //비디오편집기프로그램만들기
        private void button_AddVideo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files(*.*)|*.*|mpg (*.mpg|*.vob)|*.mpg;*.vob|avi (*.avi)|Divx (*.divx)|*.divx|wmv (*.wmv)|*.wmv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string strFile = openFileDialog1.FileName;
                axTimelineControl1.AddVideoClip(1, strFile, 0, axTimelineControl1.GetMediaDuration(strFile), 0);
                axTimelineControl1.AddAudioClip(5, strFile, 0, axTimelineControl1.GetMediaDuration(strFile), 0, (float)1.0);
            }
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            axTimelineControl1.Play();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            axTimelineControl1.Stop();
        }

        private void button_scale003_Click(object sender, EventArgs e)
        {
            axTimelineControl1.SetScale((float)0.03);
        }

        private void button_scale005_Click(object sender, EventArgs e)
        {
            axTimelineControl1.SetScale((float)0.05);
        }

        /*
        //얼굴감지
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        private void button_Detection_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog(){ Multiselect = false, Filter = "JPEG|*.jpg"})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    Bitmap bitmap = new Bitmap(pictureBox1.Image);
                    Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
                    Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.4, 0);
                    foreach(Rectangle rectangle in rectangles)
                    {
                        using(Graphics graphics = Graphics.FromImage(bitmap))
                        {
                            using(Pen pen = new Pen(Color.Red, 1))
                            {
                                graphics.DrawRectangle(pen, rectangle);
                            }
                        }
                    }
                    pictureBox1.Image = bitmap;
                }
            }
        }*/
    }
}