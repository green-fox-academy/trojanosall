using FormulaOne.Models;
using System.Collections.ObjectModel;

namespace FormulaOne.ViewModels
{
    public class FormulaOneTeamViewModel
    {
        public ObservableCollection<FormulaOneTeam> FormulaOneTeams { get; set; }

        public void LoadFormulaOneTeams()
        {
            ObservableCollection<FormulaOneTeam> formulaOneTeams = new ObservableCollection<FormulaOneTeam>();

            formulaOneTeams.Add(new FormulaOneTeam { Id = 0, Name = "Ferrari", YearOfFundation = 1950, NumberOfChampionshipTitles = 16, IsEntryFeePaid = true });
            formulaOneTeams.Add(new FormulaOneTeam { Id = 1, Name = "Force India", YearOfFundation = 2008, NumberOfChampionshipTitles = 0, IsEntryFeePaid = true });
            formulaOneTeams.Add(new FormulaOneTeam { Id = 2, Name = "Haas", YearOfFundation = 2016, NumberOfChampionshipTitles = 0, IsEntryFeePaid = true });
            formulaOneTeams.Add(new FormulaOneTeam { Id = 3, Name = "McLaren", YearOfFundation = 1966, NumberOfChampionshipTitles = 8, IsEntryFeePaid = true });
            formulaOneTeams.Add(new FormulaOneTeam { Id = 4, Name = "Mercedes", YearOfFundation = 1954, NumberOfChampionshipTitles = 4, IsEntryFeePaid = true });
            formulaOneTeams.Add(new FormulaOneTeam { Id = 5, Name = "Red Bull", YearOfFundation = 2005, NumberOfChampionshipTitles = 4, IsEntryFeePaid = true });
            formulaOneTeams.Add(new FormulaOneTeam { Id = 6, Name = "Renault", YearOfFundation = 1977, NumberOfChampionshipTitles = 2, IsEntryFeePaid = true });
            formulaOneTeams.Add(new FormulaOneTeam { Id = 7, Name = "Sauber", YearOfFundation = 1993, NumberOfChampionshipTitles = 0, IsEntryFeePaid = true });
            formulaOneTeams.Add(new FormulaOneTeam { Id = 8, Name = "Toro Rosso", YearOfFundation = 2006, NumberOfChampionshipTitles = 0, IsEntryFeePaid = true });
            formulaOneTeams.Add(new FormulaOneTeam { Id = 9, Name = "Williams", YearOfFundation = 1978, NumberOfChampionshipTitles = 4, IsEntryFeePaid = true });
        }
    }
}
