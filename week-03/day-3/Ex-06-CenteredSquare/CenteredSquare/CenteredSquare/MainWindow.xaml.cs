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

namespace CenteredSquare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // draw a green 10x10 square to the canvas' center.

            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            // Meghivtuk a fuggvenyt
            CenteredSquare(foxDraw);
        }
        public void CenteredSquare(FoxDraw foxDraw)
        {
            // A negyszog bal felso sarkanak koordinatai
            double x1 = (canvas.Width / 2) - 4.5;
            double y1 = (canvas.Height / 2) - 4.5;
            
            // A negyszog oldalainak hosszanak meghatarozasa
            double a = 10;

            // Negyszog megrajzolasa - bal felso sarok koordinatai (x1, y1) es az oldalak hossza (a, a)
            foxDraw.DrawRectangle(x1, y1, a, a);

        }
    }
}
