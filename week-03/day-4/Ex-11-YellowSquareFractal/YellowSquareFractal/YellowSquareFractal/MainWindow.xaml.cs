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

namespace YellowSquareFractal
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

            double BasicWidth = canvas.Width; // Az alapparametert a Canvas meretehez igazitom. A Canvas amugy negyzet alaku, 600 * 600-asra parameterezve.

            foxDraw.BackgroundColor(Colors.Yellow); // A Canvas sarga hatter szinenek beallitasa.
            foxDraw.StrokeColor(Colors.Black); // A vonalak szinenek beallitasa.
            Drawing(foxDraw, 0, 0, BasicWidth, 6); // A fuggveny meghivasa. Mivel nullra allitottam be az x es y alapparameteret. Ezert a fuggveny a BasicWidth-bol szarmaztatott eltolasabol hatarozza meg a vonalak parameteret. A level 6-os erteken kerult meghatarozasra. Hat felett mar nagyon letompul a gep. Bar az is lehet, hogy 1 keppont ala csokken a BasicWidth es azert nem tud vele mit kezdeni.
        }

        public static void Drawing(FoxDraw foxDraw, double x, double y, double BasicWidth, int level) // A vonalak  berajzolasahoz 4 parameter szukseges (kezdopont es vegpont koordinatai). A vegkoordiatak az x es y koordinatak, valamint ezek eltolasabol kerulnek kiszamitasra. Az eltolashoz a Canvas szelessegebol szarmaztatott BasicWith-et hasznalom. A level hatarozza meg, hogy hagyszor ter vissza magaba a fuggveny.
        {
            if (level == 0) // Ha nullara er a level, akkor mar nem fut tovabb es nem ter vissza a fuggveny onmagaba.
            {
                return;
            }
            else
            {
                // Eloszor a legnagyobb haloracsot kapjuk meg.
                foxDraw.DrawLine(x + BasicWidth / 3, y, x + BasicWidth / 3, y + BasicWidth);                  //Elso fuggoleges vonal.
                foxDraw.DrawLine(x + BasicWidth / 3 * 2, y, x + BasicWidth / 3 * 2, y + BasicWidth);         // Masodik fuggoleges vonal.
                foxDraw.DrawLine(x, y + BasicWidth / 3, x + BasicWidth, y + BasicWidth / 3);                // Elso vizszintes vonal.
                foxDraw.DrawLine(x, y + BasicWidth / 3 * 2, x + BasicWidth, y + BasicWidth / 3 * 2);       // Masodik vizszintes vonal.


                // A legnagyobb haloracs utan jonnek a kissebbek. Ahogz csokken a szintek szama. Ugy folyamatosan csokken az eltolas (BasicWidth) erteke, vagyis egyre kisebb haloracsok szuletnek.
                Drawing(foxDraw, x + BasicWidth / 3, y, BasicWidth / 3, level - 1);                         
                Drawing(foxDraw, x + BasicWidth / 3, y + BasicWidth / 3 * 2, BasicWidth / 3, level - 1);
                Drawing(foxDraw, x, y + BasicWidth / 3, BasicWidth / 3, level - 1);
                Drawing(foxDraw, x + BasicWidth / 3 * 2, y + BasicWidth / 3, BasicWidth / 3, level - 1);
            }
        }
    }
}