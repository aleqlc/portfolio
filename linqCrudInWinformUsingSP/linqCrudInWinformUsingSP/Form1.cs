using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqCrudInWinformUsingSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Id;

        DataClasses1DataContext data = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            //데이터 보여줌
            dataGridView1.DataSource = data.View_Data();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" | txtAge.Text == "" | txtContact.Text == ""
                | txtFullname.Text == "" | comboGender.Text == "" | txtFullname.Text == "")
            {
                MessageBox.Show("입력되지 않은 항목이 있습니다.");
            }
            else
            {
                //데이터저장
                data.Save_Data(txtFullname.Text, txtAddress.Text, DateTime.Parse(dateTimePicker1.Text)
                    , int.Parse(txtAge.Text), comboGender.Text, int.Parse(txtContact.Text));
                MessageBox.Show("저장되었습니다.");

                txtAddress.Text = "";
                txtAge.Text = "";
                txtContact.Text = "";
                txtFullname.Text = "";
                comboGender.Text = string.Empty;

                //저장후 데이터 보여줌
                dataGridView1.DataSource = data.View_Data();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" | txtAge.Text == "" | txtContact.Text == ""
                | txtFullname.Text == "" | comboGender.Text == "" | txtFullname.Text == "")
            {
                MessageBox.Show("입력되지 않은 항목이 있습니다.");
            }
            else
            {
                //update
                data.Update_Data(Id, txtFullname.Text, txtAddress.Text, DateTime.Parse(dateTimePicker1.Text)
                    , int.Parse(txtAge.Text), comboGender.Text, int.Parse(txtContact.Text));
                MessageBox.Show("수정되었습니다.");

                txtAddress.Text = "";
                txtAge.Text = "";
                txtContact.Text = "";
                txtFullname.Text = "";
                comboGender.Text = string.Empty;

                //수정후 데이터 보여줌
                dataGridView1.DataSource = data.View_Data();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //나이를 정확히 계산하기 위해
            int age = DateTime.Today.Year - dateTimePicker1.Value.Year;
            txtAge.Text = age.ToString();
        }

        //데이터그리드뷰 눌렀을 때 텍스트박스에 전부 값이 들어감
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtFullname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            txtAge.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboGender.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtContact.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtAge.Text = "";
            txtContact.Text = "";
            txtFullname.Text = "";
            comboGender.Text = string.Empty;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //삭제하려면 dataGridView1_CellContentClick할 수 밖에 없음. Id를 포함한 모든 정보가 입력되야함
            if (txtAddress.Text == "" | txtAge.Text == "" | txtContact.Text == ""
                | txtFullname.Text == "" | comboGender.Text == "" | txtFullname.Text == "")
            {
                MessageBox.Show("입력되지 않은 항목이 있습니다.");
            }
            else
            {
                //remove
                data.Remove_Data(Id);
                MessageBox.Show("삭제되었습니다.");

                txtAddress.Text = "";
                txtAge.Text = "";
                txtContact.Text = "";
                txtFullname.Text = "";
                comboGender.Text = string.Empty;

                //삭제후 데이터 보여줌
                dataGridView1.DataSource = data.View_Data();
            }
        }
    }
}
