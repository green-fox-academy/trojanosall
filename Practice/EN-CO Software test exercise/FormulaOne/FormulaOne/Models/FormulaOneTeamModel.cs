using System.ComponentModel;

namespace FormulaOne.Models
{
    public class FormulaOneTeamModel
    {
    }

    public class FormulaOneTeam : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        private int yearOfFundation;
        public int YearOfFundation
        {
            get { return yearOfFundation; }
            set
            {
                if (yearOfFundation != value)
                {
                    yearOfFundation = value;
                    RaisePropertyChanged("YearOfFundation");
                }
            }
        }

        private int numberOfChampionshipTitles;
        public int NumberOfChampionshipTitles
        {
            get { return numberOfChampionshipTitles; }
            set
            {
                if (numberOfChampionshipTitles != value)
                {
                    numberOfChampionshipTitles = value;
                    RaisePropertyChanged("NumberOfChampionshipTitles");
                }
            }
        }

        private bool isEntryFeePaid;
        public bool IsEntryFeePaid
        {
            get { return isEntryFeePaid; }
            set
            {
                if (isEntryFeePaid != value)
                {
                    isEntryFeePaid = value;
                    RaisePropertyChanged("IsEntryFeePaid");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
