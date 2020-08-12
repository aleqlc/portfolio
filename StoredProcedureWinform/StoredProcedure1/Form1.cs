using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StoredProcedure1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection ss = new SqlConnection("Data Source=DESKTOP-A5HOU30;Initial Catalog=StudentData;Integrated Security=True");
            ss.Open();
            SqlDataAdapter aa = new SqlDataAdapter("StudentInset",ss);

            aa.SelectCommand.CommandType = CommandType.StoredProcedure;

            aa.SelectCommand.Parameters.Add("@id",SqlDbType.Int).Value = txtbox_id.Text;
            aa.SelectCommand.Parameters.Add("@Name", SqlDbType.VarChar,(50)).Value = txtbox_name.Text;
            aa.SelectCommand.Parameters.Add("@Father", SqlDbType.VarChar,(50)).Value = txtbox_father.Text;
            aa.SelectCommand.Parameters.Add("@DOB", SqlDbType.Date).Value = dateTimePicker1.Value.ToString();
            aa.SelectCommand.Parameters.Add("@Class", SqlDbType.VarChar,(50)).Value = txtbox_class.Text;

            aa.SelectCommand.ExecuteNonQuery();
            ss.Close();
            MessageBox.Show("저장되었습니다.");
        }
    }
}
