﻿using System;
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

namespace RainbowBoxFuncions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.

            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Random rnd = new Random();
            
            RainbowBoxFuncions(foxDraw, rnd);       
            
        }

        private void RainbowBoxFuncions(FoxDraw foxDraw, Random rnd)
        {
            for (int i = 0; i < (canvas.Width / 2); i++)
            {
                double x1 = i;
                double y1 = i;
                double a = canvas.Width - 2 * i;

                foxDraw.FillColor(Color.FromRgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)));
                foxDraw.DrawRectangle(x1, y1, a, a);
        };
    }
    }
}
