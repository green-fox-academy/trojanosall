namespace FormulaOne.Models
{
    public class FormulaOneTeamModel
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int yearOfFundation;
        public int YearOfFundation
        {
            get { return yearOfFundation; }
            set { yearOfFundation = value; }
        }

        private int numberOfChampionshipTitles;
        public int NumberOfChampionshipTitles
        {
            get { return numberOfChampionshipTitles; }
            set { numberOfChampionshipTitles = value; }
        }

        private bool isEntryFeePaid;
        public bool IsEntryFeePaid
        {
            get { return isEntryFeePaid; }
            set { isEntryFeePaid = value; }
        }
    }
}
