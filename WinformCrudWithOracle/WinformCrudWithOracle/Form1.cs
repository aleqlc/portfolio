using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WinformCrudWithOracle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "Data Source=localhost; User Id=sys; Password=sys; DBA Privilege = SYSDBA;";
            con.Open();
            MessageBox.Show("데이터베이스에 연결되었습니다.");
            con.Close();
            //MessageBox.Show("Database Closed...");
        }

        private void btnCreateEmpTable_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            OracleCommand cmd = new OracleCommand();

            con.ConnectionString = "Data Source=localhost; User Id=sys; Password=sys; DBA Privilege = SYSDBA;";
            cmd.Connection = con;
            cmd.CommandText = "create table employee (EMPLOYEE_NUMBER NUMBER, EMPLOYEE_NAME VARCHAR2(70), SALARY NUMBER, constraint EMPLOYEE_PK primary key (EMPLOYEE_NUMBER))";
            //cmd.commandText쿼리에 ; '' "있으면 invalid character 오류뜸

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("테이블이 생성되었습니다.");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=localhost; User Id=sys; Password=sys; DBA Privilege=SYSDBA;");
            try
            {
                OracleCommand cmd = new OracleCommand();

                cmd.Connection = con;
                con.Open();//아래처럼 cmd 2개이상쓰려면 여기에서 open해야됨

                cmd.CommandText = "insert into employee values(1, 'Yumi', 2500)";
                cmd.ExecuteNonQuery();
                
                cmd.CommandText = "insert into employee values(2, 'mike', 3000)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "insert into employee values(3, 'wang', 4000)";
                cmd.ExecuteNonQuery();

                MessageBox.Show("데이터가 삽입되었습니다.");
                con.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=localhost; User Id=sys; Password=sys; DBA Privilege=SYSDBA;");
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                con.Open();//아래처럼 cmd 2개이상쓰려면 여기에서 open해야됨

                cmd.CommandText = "update employee set employee_name='chuchu', salary=6500 where employee_number=1";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "update employee set employee_name='sara', salary=5000 where employee_number=2";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "update employee set employee_name='gyu', salary=1200 where employee_number=3";
                cmd.ExecuteNonQuery();

                MessageBox.Show("업데이트 되었습니다.");
                con.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnDelData_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=localhost; User Id=sys; Password=sys; DBA Privilege=SYSDBA;");
            OracleCommand cmd = new OracleCommand("delete from employee", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("데이터가 삭제되었습니다.");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=localhost; User Id=sys; Password=sys; DBA Privilege=SYSDBA;");
            OracleCommand cmd = new OracleCommand("select * from employee order by employee_number asc", con);
            DataTable tblEmp = new DataTable();

            try
            {
                con.Open();
                tblEmp.Load(cmd.ExecuteReader());
                dgvEmp.DataSource = tblEmp;

                con.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void btnGotoF2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=localhost; User Id=sys; Password=sys; DBA Privilege=SYSDBA;");
            OracleCommand cmd = new OracleCommand("select * from employee where employee_name like '%" + txtSearch.Text + "%' order by employee_number asc", con);
            DataTable tbl = new DataTable();
            con.Open();
            tbl.Load(cmd.ExecuteReader());
            con.Close();

            dgvEmp.DataSource = tbl;

            //lblCount.Text = "You have " + tbl.Rows.Count + " Rows";
            lblCount.Text = tbl.Rows.Count + "행이 선택되었습니다.";
        }

        private void btnGotoF3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
