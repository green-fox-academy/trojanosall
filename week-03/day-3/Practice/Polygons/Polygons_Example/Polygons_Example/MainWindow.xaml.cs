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

namespace Polygons_Example
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

            DrawGreenPolygon(foxDraw);
        }

        public static void DrawGreenPolygon(FoxDraw foxDraw)
        {
            var points = new List<Point>();
            points.Add(new Point(10, 10));
            points.Add(new Point(40, 210));
            points.Add(new Point(170, 190));
            points.Add(new Point(130, 40));

            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(points);
        }
    }
}
