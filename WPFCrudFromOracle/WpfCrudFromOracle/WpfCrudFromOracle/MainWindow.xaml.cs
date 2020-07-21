using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace WpfCrudFromOracle
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        OracleConnection con = null;
        public MainWindow()
        {
            this.setConnection();
            InitializeComponent();
        }

        private void updateDataGrid()
        {
            try
            {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT EMPLOYEE_ID, LAST_NAME, JOB_ID, HIRE_DATE, EMAIL FROM EMPLOYEES ORDER BY EMPLOYEE_ID ASC";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            myDataGrid.ItemsSource = dt.DefaultView;
            dr.Close();
            }
            catch(Exception expe)
            {
                MessageBox.Show(expe.Message);
            }
            
        }

        private void setConnection()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            con = new OracleConnection(connectionString);
            try
            {
                con.Open();
            }
            catch(Exception expe)
            {
                MessageBox.Show(expe.Message);
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            this.updateDataGrid();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            con.Close();
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            String sql = "INSERT INTO EMPLOYEES(EMPLOYEE_ID, LAST_NAME, EMAIL, HIRE_DATE, JOB_ID) " +
                "VALUES(:EMPLOYEE_ID, :LAST_NAME, :EMAIL, :HIRE_DATE, :JOB_ID)";
            this.AUD(sql, 0);
            add_btn.IsEnabled = false;
            update_btn.IsEnabled = true;
            delete_btn.IsEnabled = true;
        }

        private void update_btn_Click(object sender, RoutedEventArgs e)
        {
            String sql = "UPDATE EMPLOYEES SET LAST_NAME=:LAST_NAME," +
                "EMAIL=:EMAIL, JOB_ID=:JOB_ID, HIRE_DATE=:HIRE_DATE " +
                "WHERE EMPLOYEE_ID=:EMPLOYEE_ID";
            try
            {
                this.AUD(sql, 1);
            }
            catch(Exception expe)
            {
                MessageBox.Show(expe.Message);
            }
            
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            String sql = "DELETE FROM EMPLOYEES " +
                "WHERE EMPLOYEE_ID=:EMPLOYEE_ID";
            this.AUD(sql, 2);
            this.resetAll();
        }

        private void resetAll()
        {
            employee_id_txtbx.Text = "";
            email_txtbx.Text = "";
            last_name_txtbx.Text = "";
            job_id_txtbx.Text = "";
            hire_date_txtbx.Text = "";

            add_btn.IsEnabled = true;
            update_btn.IsEnabled = false;
            delete_btn.IsEnabled = false;
        }

        private void reset_btn_Click(object sender, RoutedEventArgs e)
        {
            this.resetAll();
        }

        private void AUD(String sql_stmt, int state)
        {
            String msg = "";
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql_stmt;
            cmd.CommandType = CommandType.Text;
            try
            {
                switch (state)
            {
                case 0:
                    msg = "Row Inserted Successfully!";
                    cmd.Parameters.Add("EMPLOYEE_ID", OracleDbType.Int32, 20).Value= Int32.Parse(employee_id_txtbx.Text);
                    cmd.Parameters.Add("LAST_NAME", OracleDbType.Varchar2, 20).Value = last_name_txtbx.Text;
                    cmd.Parameters.Add("EMAIL", OracleDbType.Varchar2, 20).Value = email_txtbx.Text;
                    cmd.Parameters.Add("HIRE_DATE", OracleDbType.Varchar2, 20).Value = hire_date_txtbx.Text;
                    cmd.Parameters.Add("JOB_ID", OracleDbType.Varchar2, 20).Value = job_id_txtbx.Text;
                    break;
                case 1:
                    msg = "Row Updated Succesfully!";
                    cmd.Parameters.Add("LAST_NAME", OracleDbType.Varchar2, 20).Value = last_name_txtbx.Text;
                    cmd.Parameters.Add("EMAIL", OracleDbType.Varchar2, 20).Value = email_txtbx.Text;
                    cmd.Parameters.Add("HIRE_DATE", OracleDbType.Varchar2, 20).Value = hire_date_txtbx.Text;
                    cmd.Parameters.Add("JOB_ID", OracleDbType.Varchar2, 20).Value = job_id_txtbx.Text;
                    cmd.Parameters.Add("EMPLOYEE_ID", OracleDbType.Int32, 20).Value = Int32.Parse(employee_id_txtbx.Text);

                        break;
                case 2:
                    msg = "Row Deleted Succesfully!";
                    cmd.Parameters.Add("EMPLOYEE_ID", OracleDbType.Int32, 20).Value = Int32.Parse(employee_id_txtbx.Text);
                    break;
            }
            }
            catch(Exception expe)
            {
                MessageBox.Show(expe.Message);
            }
            
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show(msg);
                    this.updateDataGrid();
                }
            }
            catch (Exception expe)
            {
                MessageBox.Show(expe.Message);
            }
        }

        private void myDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                employee_id_txtbx.Text = dr["EMPLOYEE_ID"].ToString();
                last_name_txtbx.Text = dr["LAST_NAME"].ToString();
                job_id_txtbx.Text = dr["JOB_ID"].ToString();
                email_txtbx.Text = dr["EMAIL"].ToString();
                hire_date_txtbx.Text = dr["HIRE_DATE"].ToString();

                add_btn.IsEnabled = false;
                update_btn.IsEnabled = true;
                delete_btn.IsEnabled = true;

            }
            }
            catch(Exception expe)
            {
                MessageBox.Show(expe.Message);
            }
            
        }
    }
}
