using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Oracle.ManagedDataAccess.Client;

namespace WinformCrudWithOracle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            txtPath.Text = ofd.FileName;
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            FileInfo fi = new FileInfo(txtPath.Text);
            byte[] imgData = br.ReadBytes((int)fi.Length);
            fs.Close();
            br.Close();

            OracleConnection con = new OracleConnection("Data Source=localhost; User Id=sys; Password=sys; DBA Privilege=SYSDBA;");
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into emp values(:emp_code, :img)";
            cmd.Parameters.Add("emp_code", txtEmpCode.Text);
            cmd.Parameters.Add("img", (object)imgData);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
            con.Close();
            MessageBox.Show("이미지가 저장되었습니다.");
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=localhost; User Id=sys; Password=sys; DBA Privilege=SYSDBA;");
            OracleCommand cmd = new OracleCommand("select * from emp where emp_code=" + txtEmpCode.Text, con);
            DataTable tbl = new DataTable();
            con.Open();
            tbl.Load(cmd.ExecuteReader());
            con.Close();
            byte[] imgData = (byte[])tbl.Rows[0][1];
            MemoryStream ms = new MemoryStream();
            ms.Write(imgData, 0, imgData.Length);
            Bitmap bm = new Bitmap(ms, false);
            picEmp.Image = bm;
            ms.Dispose();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("Data Source=localhost; User Id=sys; Password=sys; DBA Privilege=SYSDBA;");
            OracleCommand cmd = new OracleCommand("select * from emp", con);
            DataTable tbl = new DataTable();
            con.Open();
            tbl.Load(cmd.ExecuteReader());
            con.Close();
            dgvEmp.DataSource = tbl;
        }
    }
}
