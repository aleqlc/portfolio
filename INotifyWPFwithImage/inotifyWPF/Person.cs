using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inotifyWPF
{
    class Person : INotifyPropertyChanged
    {
        int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        string _img;
        public string Img
        {
            get { return _img; }
            set 
            {
                _img = value;
                propChanged("Img");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void propChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}