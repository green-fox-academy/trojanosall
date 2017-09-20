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

namespace CenteredBoxFuncion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.

            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                CenteredBoxFuncion(foxDraw, rnd);
            }   
            
        }

        private void CenteredBoxFuncion(FoxDraw foxDraw, Random rnd)
        {
            double a = rnd.Next(300);
            double x1 = canvas.Width / 2 - a / 2;
            double y1 = canvas.Height / 2 - a / 2;

            foxDraw.FillColor(Color.FromRgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)));
            foxDraw.DrawRectangle(x1, y1, a, a);
        }
    }
}
