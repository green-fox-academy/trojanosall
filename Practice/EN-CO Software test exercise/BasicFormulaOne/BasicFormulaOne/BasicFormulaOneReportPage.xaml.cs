using System.Windows.Controls;

namespace BasicFormulaOne
{

    public partial class BasicFormulaOneReportPage : Page
    {
        public BasicFormulaOneReportPage()
        {
            InitializeComponent();
        }

        public BasicFormulaOneReportPage(object data) : this()
        {
            this.DataContext = data;
        }
    }
}
