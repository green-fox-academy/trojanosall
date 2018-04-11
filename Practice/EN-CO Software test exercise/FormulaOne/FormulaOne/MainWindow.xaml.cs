using System.Windows;

namespace FormulaOne
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FormulaOneTeamViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            FormulaOne.ViewModels.FormulaOneTeamViewModel formulaOneTeamViewModelObject = new FormulaOne.ViewModels.FormulaOneTeamViewModel();
            formulaOneTeamViewModelObject.LoadFormulaOneTeams();

            FormulaOneTeamViewControl.DataContext = formulaOneTeamViewModelObject;
        }
    }
}
