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
using WpfStudentManagementSysWithDbFirstApproach.EntityModel;

namespace WpfStudentManagementSysWithDbFirstApproach
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        StudentContext db = new StudentContext();
        tblInfo tblobj = new tblInfo();

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            tblobj.StudentName = txtName.Text;
            tblobj.DateOfBirth = datePicker.SelectedDate.Value.Date;
            tblobj.Gender = (rbMale.IsChecked == true ? true : false);
            tblobj.Class = comboClass.Text;
            tblobj.Subject = (cbScience.IsChecked == true ? "Science" : "Arts");
            tblobj.FatherName = txtFatherName.Text;
            tblobj.CaliberRate = (int)slider.Value;
            tblobj.Address = txtAddress.Text;
            try
            {
                 db.tblInfoes.Add(tblobj);
                 db.SaveChanges();
            }
            catch(Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
            ClearControl();
            LoadGrid();
        }

        private void ClearControl()
        {
            txtName.Clear();
            txtFatherName.Clear();
            txtAddress.Clear();
            txtEditid.Clear();
            datePicker.SelectedDate = null;
            rbMale.IsChecked = false;
            rbFmale.IsChecked = false;
            cbArts.IsChecked = false;
            cbScience.IsChecked = false;
            comboClass.Text = "";
            slider.Value = 0;
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearControl();
        }

        private void LoadGrid()
        {
            var data = from x in db.tblInfoes select x;
            dataGrid.ItemsSource = data.ToList();
        }

        private void cbShow_checked(object sender, RoutedEventArgs e)
        {
            LoadGrid();
        }

        private void cbShow_Unchecked(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
        }

        tblInfo result;
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(txtEditid.Text);
            result = db.tblInfoes.Single(u => u.id == Id);
            txtName.Text = result.StudentName;
            datePicker.SelectedDate = result.DateOfBirth;

            if (result.Gender == true)
            {
                rbMale.IsChecked = true;
            }
            else
            {
                rbFmale.IsChecked = true;
            }

            comboClass.Text = result.Class;
            txtFatherName.Text = result.FatherName;

            if (result.Subject == "Science")
            {
                cbScience.IsChecked = true;
            }
            else
            {
                cbArts.IsChecked = true;
            }

            slider.Value = (double)result.CaliberRate;
            txtAddress.Text = result.Address;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //update 버튼클릭시
            //id적고 edit버튼누른다음에 수정해서 update 버튼 눌러야함
            result.StudentName = txtName.Text;
            result.DateOfBirth = datePicker.SelectedDate.Value.Date;
            result.Gender = (rbMale.IsChecked == true ? true : false);
            result.Class = comboClass.Text;
            result.Subject = (cbScience.IsChecked == true ? "Science" : "Arts");
            result.FatherName = txtFatherName.Text;
            result.CaliberRate = (int)slider.Value;
            result.Address = txtAddress.Text;
            try
            {
                db.tblInfoes.Add(result);//tblobj
                db.Entry(result).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ClearControl();
            LoadGrid();
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int Id = Convert.ToInt32(txtEditid.Text);
            var d = db.tblInfoes.Single(u => u.id == Id);
            db.tblInfoes.Remove(d);
            db.SaveChanges();
            ClearControl();
            LoadGrid();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //라디오버튼 male
        }

        
    }
}
