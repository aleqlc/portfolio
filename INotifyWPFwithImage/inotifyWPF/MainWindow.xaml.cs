using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace inotifyWPF
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

        ObservableCollection<Person> persons = new ObservableCollection<Person>();
        Person prs1;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)//Add
        {
            prs1 = new Person();
            grd1.DataContext = prs1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//Save
        {
            persons.Add(prs1);
            lst1.ItemsSource = persons;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//Browse
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            if (file.FileName != null)
            {
                prs1.Img = file.FileName;
            }
        }
    }
}
