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

            CheckerBoard(foxDraw);

        }

        private void CheckerBoard(FoxDraw foxDraw)
        {
            for (int i = 0; i < 8; i++)
            {
                if (i%2 == 0)
                {
                    double a = 25;
                    double x = i * a;
                    double y = 0;
                    
                    foxDraw.FillColor(Colors.Black);
                    foxDraw.DrawRectangle(x, y, a, a);
                }
                
            };
        }
    }
}
