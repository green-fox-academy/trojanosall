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

namespace Diagonals
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

            // draw the canvas' diagonals in green.

            Diagonals(foxDraw);      
        }

        public void Diagonals(FoxDraw foxDraw)
        {
            // X es y koordinatak definialasa
            double x1 = canvas.Width % 1;
            double x2 = canvas.Width;
            double y1 = canvas.Height % 1;
            double y2 = canvas.Height;

            //vonal szin definialasa
            foxDraw.StrokeColor(Colors.Green);

            //vonalak megrajzolasa a koordinatak alapjan
            foxDraw.DrawLine(x1,y1,x2,y2);                       
            foxDraw.DrawLine(x1, y2, x2, y1);
        }
    }
}
