using GreenFox;
using System;
using System.Windows;
using System.Windows.Media;

namespace PositionSquare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.    

            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                PositionSquare(foxDraw, rnd);
            }

        }

        private void PositionSquare(FoxDraw foxDraw, Random rnd)
        {
            double x1 = rnd.Next(300);
            double y1 = rnd.Next(300);

            double a = 50;

            foxDraw.FillColor(Color.FromRgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)));
            foxDraw.DrawRectangle(x1, y1, a, a);
        }
    }
}

