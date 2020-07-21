using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
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

namespace AboutIsolatedStorage
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

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(txtNewFrd.Text != null)
            {
                AddFriend(txtNewFrd.Text);
                txtNewFrd.Text = String.Empty;
            }
        }

        private void AddFriend(string p)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Content = p;
            listFrd.Items.Add(lvi);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            IsolatedStorageFile isofile = IsolatedStorageFile.GetUserStoreForAssembly();
            using(IsolatedStorageFileStream stream = new IsolatedStorageFileStream("listfrd", FileMode.Create, isofile))
            {
                using(StreamWriter sw = new StreamWriter(stream))
                {
                    foreach(ListViewItem lvi in listFrd.Items)
                    {
                        sw.WriteLine(lvi.Content);
                    }
                }
            }
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            IsolatedStorageFile isofile = IsolatedStorageFile.GetUserStoreForAssembly();
            using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream("listfrd", FileMode.OpenOrCreate, isofile))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    while (!sr.EndOfStream)
                    {
                        AddFriend(sr.ReadLine());
                    }
                }
            }
        }
    }
}
