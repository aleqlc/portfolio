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
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button_openfile_Click(object sender, EventArgs e)
        {
            Stream myStream;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if((myStream = openFileDialog.OpenFile()) != null)
                {
                    string strfilename = openFileDialog.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    //MessageBox.Show(strfilename);
                    richTextBox1.Text = filetext;
                }
            }
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            int index = 0;
            String temp = richTextBox1.Text;
            richTextBox1.Text = "";
            richTextBox1.Text = temp;

            while(index < richTextBox1.Text.LastIndexOf(textBox1.Text))
            {
                richTextBox1.Find(textBox1.Text, index, richTextBox1.TextLength, RichTextBoxFinds.None);
                richTextBox1.SelectionBackColor = Color.Red;
                index=richTextBox1.Text.IndexOf(textBox1.Text,index)+1;
            }
        }

        private void button_makefile_Click(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter("C#test.txt");//프로젝트 bin에 생성
            File.Write("안녕하세요?\r\n");
            File.Write("안녕하세요?\r\n");
            File.Write("안녕하세요?\r\n");
            File.Write("안녕하세요?\r\n");
            File.Write("안녕하세요?\r\n");

            File.Close();
        }

        private void button_makeexcel_Click(object sender, EventArgs e)
        {
            //create new xls file
            string file = "newdoc.xls"; 
            Workbook workbook = new Workbook(); 
            Worksheet worksheet = new Worksheet("First Sheet"); 
            worksheet.Cells[0, 1] = new Cell((short)1); 
            worksheet.Cells[0, 2] = new Cell(9999999); 
            worksheet.Cells[0, 3] = new Cell((decimal)3.45); 
            worksheet.Cells[0, 4] = new Cell("Text string"); 
            worksheet.Cells[0, 5] = new Cell("Second string"); 
            worksheet.Cells[0, 6] = new Cell(32764.5, "#,##0.00"); 
            worksheet.Cells[0, 7] = new Cell(DateTime.Now, @"YYYY-MM-DD"); 
            worksheet.Cells.ColumnWidth[0, 1] = 3000; 
            workbook.Worksheets.Add(worksheet); workbook.Save(file);

            // open xls file 
            Workbook book = Workbook.Load(file); 
            Worksheet sheet = book.Worksheets[0];

            // traverse cells 
            /*foreach ()
            { 
                dgvCells[cell.Left.Right, cell.Left.Left].Value = cell.Right.Value; 
            }
            
            // traverse rows by Index 
            for (int rowIndex = sheet.Cells.FirstRowIndex; 
                rowIndex <= sheet.Cells.LastRowIndex; 
                rowIndex++) 
            { 
                Row row = sheet.Cells.GetRow(rowIndex); 
                for (int colIndex = row.FirstColIndex; 
                    colIndex <= row.LastColIndex; colIndex++) 
                { 
                    Cell cell = row.GetCell(colIndex);
                } 
            }*/
        }
    }
}
