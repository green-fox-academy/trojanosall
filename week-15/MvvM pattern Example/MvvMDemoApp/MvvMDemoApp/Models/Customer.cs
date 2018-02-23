using System;
using System.ComponentModel;

namespace MvvMDemoApp.Models
{
    public class Customer : INotifyPropertyChanged
    {
        private string _Name;

        public String Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged("Name"); }
        }

        public Customer(String customerName)
        {
            Name = customerName;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
