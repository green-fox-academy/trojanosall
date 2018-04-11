using System.Windows;
using System.Windows.Controls;

namespace BasicFormulaOne
{

    public partial class BasicFormulaOneHome : Page
    {
        public BasicFormulaOneHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BasicFormulaOneReportPage basicFormulaOneReportPage = new BasicFormulaOneReportPage(this.formulaOneTeamListBox.SelectedItem);
            this.NavigationService.Navigate(basicFormulaOneReportPage);
        }
    }
}
