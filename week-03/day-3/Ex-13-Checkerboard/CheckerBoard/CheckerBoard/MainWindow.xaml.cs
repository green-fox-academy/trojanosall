using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace CheckerBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // fill the canvas with a checkerboard pattern.

            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.FillColor(Colors.White);                      // Az alap feher hateret megcsinaltam
            foxDraw.DrawRectangle(0, 0, 200, 200);                // A saktabla korvonalait megcsinaltam
            CheckerBoard(foxDraw);                                // Fuggvenz meghivva

        }

        private void CheckerBoard(FoxDraw foxDraw)
        {
            for (int i = 1; i <= 8; i++)                          // Elso for ciklusban az alapjan megy tovabb a rendszer, hogz paros vagy paratlan-e a sor.
            {
                if (i % 2 != 0)                                   // Ha paratlan a sor akkor egz masik for ciklussal a masodik elemeket feketere szinezem
                {
                    for (int j = 1; j <= 8; j++)                               
                    {
                        if (j % 2 == 0)
                        {
                            double a = 25;
                            double x = (j - 1) * a;
                            double y = (i - 1) * a;

                            foxDraw.FillColor(Colors.Black);
                            foxDraw.DrawRectangle(x, y, a, a);
                        }
                    }
                }
                else                                             // Ha a sor paros akkor a harmadik for cilus a paratlan oszolopban levo elemekt feketere szinezi.
                {
                    for (int k = 1; k <= 8; k++)
                    {
                        if (k % 2 != 0)
                        {
                            double a = 25;
                            double x = (k - 1) * a;
                            double y = (i -1) * a;

                            foxDraw.FillColor(Colors.Black);
                            foxDraw.DrawRectangle(x, y, a, a);
                        }
                        
                    }
                }
            }
        }
    }
}
