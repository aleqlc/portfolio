using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace AboutUIAutomationInvoke
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AEList.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "실행파일";
            ofd.DefaultExt = ".exe";
            ofd.Filter = "실행파일 (*.exe)|*.exe";

            Nullable<bool> re = ofd.ShowDialog();
            if (re == true)
            {
                AECollection ae = new AECollection(ofd.FileName);
                DataTable dt = ae.DataTable;

                ComboBoxItem item;
                foreach(DataRow dr in dt.Rows)
                {
                    item = new ComboBoxItem();
                    item.Content = dr["name"];
                    item.Tag = ae;
                    item.ToolTip = dr["aeid"];
                    AEList.Items.Add(item);

                }
                Result.Content = string.Format("{0}개의 실행 가능한 자동화 요소 발견",dt.Rows.Count);
            }
        }

        private void AEList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = AEList.SelectedItem as ComboBoxItem;
            if(item == null)
            {
                return;
            }

            AECollection ae = item.Tag as AECollection;

            ae.InvokeAE(item.ToolTip.ToString());
        }
    }
}
