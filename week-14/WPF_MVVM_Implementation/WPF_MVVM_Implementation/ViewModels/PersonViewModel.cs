using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using WPF_MVVM_Implementation.Command;
using WPF_MVVM_Implementation.Models;

namespace WPF_MVVM_Implementation.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;

        public Person Person
        {
            get { return _person; }
            set { _person = value; NotifyPropertyChanged("Person"); }
        }

        public PersonViewModel()
        {
            this.Person = Person;
        }

        private ObservableCollection<Person> _persons;

        public ObservableCollection<Person> Persons
        {
            get
            {
                return _persons;
            }
            set
            {
                _persons = value;
                NotifyPropertyChanged("Persons");
            }
        }

        private ICommand _SummitCommand;

        public ICommand SummitCommand
        {
            get
            {
                if (_SummitCommand == null)
                {
                    _SummitCommand = new RelayCommand(SummitExecute, CanSummitExecute, false);
                }
                return _SummitCommand;
            }
        }

        private void SummitExecute(object parameter)
        {
            Persons.Add(Person);
        }

        private bool CanSummitExecute(object parameter)
        {
            if (string.IsNullOrEmpty(Person.FName) || string.IsNullOrEmpty(Person.LName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
