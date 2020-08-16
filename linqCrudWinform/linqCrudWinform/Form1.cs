using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqCrudWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        void loaddata()//현재 모든 데이터 출력하는 함수
        {
            var st = from s in db.MyInfoTabs select s;
            dataGridView1.DataSource = st;
        }

        //db에 연결하기위해
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var st = new MyInfoTabs
            {
                ID = int.Parse(textBox1.Text),
                Name = textBox2.Text,
                Address = textBox3.Text,
                Age = double.Parse(textBox4.Text)
            };
            db.MyInfoTabs.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("저장되었습니다.");
            loaddata();//저장 후 데이터 출력
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var st = (from s in db.MyInfoTabs where s.ID == int.Parse(textBox1.Text) select s).First();

            st.Name = textBox2.Text;
            st.Address = textBox3.Text;
            st.Age = double.Parse(textBox4.Text);
            db.SubmitChanges();
            MessageBox.Show("수정되었습니다.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var st = (from s in db.MyInfoTabs where s.ID == int.Parse(textBox1.Text) select s).First();
            textBox2.Text = st.Name;
            textBox3.Text = st.Address;
            textBox4.Text = st.Age.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var st = (from s in db.MyInfoTabs where s.ID == int.Parse(textBox1.Text) select s).First();
            db.MyInfoTabs.DeleteOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("삭제되었습니다.");
            loaddata();
        }
    }
}
