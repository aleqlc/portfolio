using Microsoft.Reporting.WinForms;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCrudWithOracle
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'helpdbDataSet.EMPLOYEE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.EMPLOYEETableAdapter.Fill(this.helpdbDataSet.EMPLOYEE);

            this.reportViewer1.RefreshReport();

            OracleConnection con = new OracleConnection("Data Source=localhost; User Id=sys; Password=sys; DBA Privilege=SYSDBA;");
            OracleCommand cmd = new OracleCommand("select * from EMPLOYEE order by employee_number asc", con);
            DataTable tbl = new DataTable();

            con.Open();
            tbl.Load(cmd.ExecuteReader());
            con.Close();

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", tbl as DataTable);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
