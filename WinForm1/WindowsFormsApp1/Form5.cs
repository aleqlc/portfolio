using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Security.Cryptography;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using iTextSharp.text.pdf.parser;
//using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            desObj = Rijndael.Create();
        }
        string cipherData;
        byte[] chipherbytes;
        byte[] plainbytes;
        byte[] plainbytes2;
        byte[] plainKey;

        SymmetricAlgorithm desObj;

        string[] files, paths;

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button_beep_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)//비프음 5번 출력
            {
                Console.Beep();
                Thread.Sleep(1000);//1초간격
            }
        }

        private void button_goForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button_chooseFile_Click(object sender, EventArgs e)//재생할 오디오파일 선택하기
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox_path.Text = openFileDialog1.FileName;
            }
        }

        private void button_playAudio_Click(object sender, EventArgs e)//선택한 오디오파일(wav) 재생
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = textBox_path.Text;
                player.Load();
                player.PlaySync();
            }
            catch(Win32Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_makeRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox_result.Text = rnd.Next(Convert.ToInt32(textBox_min.Text), Convert.ToInt32(textBox_max.Text)+1).ToString();
        }

        private void button_chooseVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox_pathVideo.Text = openFileDialog.FileName;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = textBox_pathVideo.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
        }

        private void button_Decryption_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms1 = new System.IO.MemoryStream(chipherbytes);
            CryptoStream cs1 = new CryptoStream(ms1, desObj.CreateDecryptor(), CryptoStreamMode.Read);

            cs1.Read(chipherbytes, 0, chipherbytes.Length);
            plainbytes2 = ms1.ToArray();
            cs1.Close();
            ms1.Close();

            textBox3_decrypted.Text = Encoding.ASCII.GetString(plainbytes2);
        }

        private void button_Encryption_Click(object sender, EventArgs e)
        {
            cipherData = textBox1_Plain.Text;
            plainbytes = Encoding.ASCII.GetBytes(cipherData);
            plainKey = Encoding.ASCII.GetBytes("0123456789abcdef");
            desObj.Key = plainKey;

            desObj.Mode = CipherMode.CBC;
            desObj.Padding = PaddingMode.PKCS7;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, desObj.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(plainbytes, 0, plainbytes.Length);
            cs.Close();
            chipherbytes = ms.ToArray();
            ms.Close();
            textBox2_Encrypted.Text = Encoding.ASCII.GetString(chipherbytes);
        }

        //리치텍스트박스에 pdf파일 불러오기
        /*private void button_loadPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            string filePath;
            dig.Filter = "PDF FILEs(*.PDF)|*.PDF|All Files(*.*)|*.*";

            if (dig.ShowDialog() == DialogResult.OK)
            {
                filePath = dig.FileName.ToString();
                string strText = string.Empty;
              try
              {
                PdfReader reader = new PdfReader(filePath);

                for(int page = 1; page <= reader.NumberOfPages; page++;)
                {
                    iTextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                    String s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                    s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s));
                    
                    strText = strText + s;
                    richTextBox_PDF.Text = strText;
                 }
                    reader.Close();
              }
              catch(Exception ex)
              {
                 MessageBox.Show(ex.Message);
              }

              //pdf파일 txt파일로 변환하기
              StreamWriter File = new StreamWriter("PDF_to_Text.txt");
              File.Write(richTextBox_PDF.Text);
              File.Close();
             }
            }
        */




        /*private void button_makePDFfile_Click(object sender, EventArgs e)//pdf파일 만들기
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();

            iTextSharp.text.image PNG = iTextSharp.text.Image.GetInstance("파일이름.png");//이미지파일을 bin폴더에 넣어줘야함
            PNG.ScalePercent(25f);//원래 이미지 크기의 25%로 줄임, 200f넣으면 이미지가 2배커짐
            PNG.SetAbsolutePosition(doc.PageSize.Width - 36f - 72f, doc.PageSize.Height - 36f -216.6f);//이미지 출력위치 결정
            PNG.ScaleToFit(50f, 100f);//이미지크기 조정
            PNG.Border = iTextSharp.text.Rectangle.BOX;
            PNG.BorderColor = iTextSharp.text.BaseColor.YELLOW;//이미지 경계선 색깔
            PNG.BorderWidth = 5f;//이미지 경계선 두께
            doc.Add(PNG);

            Paragraph paragraph = new Paragraph("This is my First line using Paragraph.");
            doc.Add(paragraph);

            //리스트 pdf파일 생성
            //RomanList romanlist = new RomanList(true, 20);//밑에 list 전부 romanlist로 전환
            //RomanList는 앞에 순서대로 i. , ii. , iii. 이런식으로 로마자 붙음
            List list = new List(List.UNORDERED);
            list.IndentationLeft = 35f;
            list.Add(new LoistItem("ONE");
            list.Add("Two");
            list.Add("Three");
            list.Add("Four");
            list.Add("Five");
            list.Add(new ListItem("one"));

            doc.Add(list);

            //pdf에 테이블만들기
            PdfPTable table = new PdfPTable(3);

            PdfPCell cell = new PdfPCell(new Phrase
            ("Header spanning 3 columns", new iTextSharp.text.Font
            (iTextSharp.text.Font.NORMAL, 8F, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED)));//테이블위에 제목출력, 글씨는 빨강색
            cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 150, 0);//제목 칸의 배경색을 녹색으로
            
            cell.Colspan = 3;//3열에 걸쳐 합쳐진 제목칸이 만들어짐
            cell.HorizontalAlignment = 1;//제목이 칸 가운데로 정렬, 0=left 1=center 2=right
            table.AddCell(cell);

            table.AddCell("Col 1 Row 1");//1행1열
            table.AddCell("Col 2 Row 1");//1행2열
            table.AddCell("Col 3 Row 1");//1행3열
            table.AddCell("Col 1 Row 2");//2행1열
            table.AddCell("Col 2 Row 2");//2행2열
            table.AddCell("Col 3 Row 2");//2행3열
            doc.Add(table);

            //pdf에 dataGridView 삽입하기
            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

            for(int i=0; i<dataGridView1.Columns.Count; i++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText));
            }
            table.HeaderRows = 1;

            for(int j=0; j<dataGridView1.Rows.Count; j++)
            {
                for(int k=0; k<dataGridView1.Columns.Count; k++)
                {
                    if(dataGridView[k,j].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView1[k,j].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            
            //pdf에 chart 삽입하기
            var chartimage = new MemoryStream();
            chart1.SaveImage(chartimage, ChartImageFormat.PNG);
            iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
            Chart_image.ScalePercent(200f);//차트 원래 크기 2배로
            doc.Add(Chart_image);

            doc.Close();
        }*/

        private void button_chooseMP3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;//파일 여러개 선택 가능

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.SafeFileNames;//파일이름 저장
                paths = openFileDialog.FileNames;//파일경로 저장
                for(int i=0; i<files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                }
            }
        }

        /* pdf파일 열기
        private void button_runPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                exAcroPDF1.src = openFileDialog1.FileName;
            }
        }

        //exe파일실행시키기
        private void button_runExe_Click(object sender, EventArgs e)
        {
            button_runExe.openPdf openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string FilePath = openFileDialog1.FileName;
                Process.Start(FilePath);
            }
        }
        */

    }
}
