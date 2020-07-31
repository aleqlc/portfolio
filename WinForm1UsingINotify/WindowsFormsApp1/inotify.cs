using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class inotify : INotifyPropertyChanged
    {
        private string author;
        private string title;
        private string description;
        private string profile;
        private string gender;
        public string Author
        {
            get { return author; }
            set
            {
                if (value == Author) return;
                author = value;
                OnPropertyChanged("Author");
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                if (value == Title) return;
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (value == Description) return;
                description = value;
                OnPropertyChanged("Description");
            }
        }
        public string Profile
        {
            get { return profile; }
            set
            {
                if (value == Profile) return;
                profile = value;
                OnPropertyChanged("Profile");
            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == Gender) return;
                gender = value;
                OnPropertyChanged("Gender");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
