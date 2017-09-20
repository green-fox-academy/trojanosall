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

namespace FourRectangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            // draw four different size and color rectangles
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Random rnd = new Random();


            // For ciklussal negyszer meghivom a fuggvenyt
            for (int i = 0; i < 4; i++)
            {
                FourRectangle(foxDraw, rnd);
            }
                        
        }

        private void FourRectangle(FoxDraw foxDraw, Random rnd)
        {
            // A negyszog bal felso sarkanak koordinatai
            double x1 = rnd.Next(300);
            double y1 = rnd.Next(300);

            // A negyszog oldalainak hosszanak meghatarozasa
            double a = rnd.Next(300);
            double b = rnd.Next(300);

            // Random szingeneralas es rajzolas
            foxDraw.FillColor(Color.FromRgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)));
            foxDraw.DrawRectangle(x1, y1, a, b);
            
        }
    }
}
