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

namespace FuncionToCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // fill the canvas with lines from the edges, every 20 px, to the center.

            foxDraw.StrokeColor(Colors.Purple);
            
            FuncionToCenter(foxDraw);

        }
        private void FuncionToCenter(FoxDraw foxDraw)
        {
            for (int i = 0; i <= 15; i++)
            {
                foxDraw.DrawLine(0, i * 20, 150, 150);
            }

            for (int j = 0; j <= 15; j++)
            {
                foxDraw.DrawLine(300, j * 20, 150, 150);
            }

            for (int k = 0; k <= 15; k++)
            {
                foxDraw.DrawLine(k * 20, 0, 150, 150);
            }

            for (int l = 0; l <= 15; l++)
            {
                foxDraw.DrawLine(l * 20, 300, 150, 150);
            }
        }
    }
}
