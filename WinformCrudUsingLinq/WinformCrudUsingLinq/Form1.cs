using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCrudUsingLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db;

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            dataGridView1.DataSource = db.personel;//실행하면 현재 모든 데이터 로드됨
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            personel newperson = new personel();
            newperson.NAME = txtName.Text;
            newperson.TEL = txtTel.Text;
            newperson.CITY = txtCity.Text;
            db.personel.InsertOnSubmit(newperson);
            db.SubmitChanges();
            dataGridView1.DataSource = db.personel;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            //현재 선택된 행을 update
            int pId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = db.personel.Where(w => w.ID == pId).FirstOrDefault();
            query.NAME = txtName.Text;
            query.TEL = txtTel.Text;
            query.CITY = txtCity.Text;
            db.SubmitChanges();
            dataGridView1.DataSource = db.personel;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            //현재 선택된 행을 delete
            int pId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = db.personel.Where(w => w.ID == pId).FirstOrDefault();
            db.personel.DeleteOnSubmit(query);
            db.SubmitChanges();
            dataGridView1.DataSource = db.personel;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
