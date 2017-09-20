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

namespace GoToCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.
            
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            //A main-ben generaltuk a random szamot, mert a fuggvenyben generalt szam mindig ugyanaz volt
            Random rnd = new Random();

            //Haromszor meghivtuk a fuggvenyt, hogz meglegyen a harom vonal
            GoToCenter(foxDraw, rnd);

            GoToCenter(foxDraw, rnd);

            GoToCenter(foxDraw, rnd);
        }

        public void GoToCenter(FoxDraw foxDraw, Random rnd)
        {
            //A vonalak kezdo koordinatainak legeneralasa a main-ben generalt random szam segitsegevel
            double x1 = rnd.Next(300);                        
            double y1 = rnd.Next(300);

            //A center koordinatainak meghatarozasa
            double x2 = canvas.Width / 2;
            double y2 = canvas.Height / 2;

            foxDraw.DrawLine(x1, y1, x2, y2);


        }
    }
}
