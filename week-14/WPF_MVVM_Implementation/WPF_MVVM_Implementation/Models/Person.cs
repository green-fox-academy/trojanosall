using System.ComponentModel;

namespace WPF_MVVM_Implementation.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string fName;
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        private string lName;
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        private string fullName;
        public string FullName
        {
            get
            {
                return fullName = FName + " " + LName;
            }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                }

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
            {
                ph(this, new PropertyChangedEventArgs(p));
            }
        }

    }
}
