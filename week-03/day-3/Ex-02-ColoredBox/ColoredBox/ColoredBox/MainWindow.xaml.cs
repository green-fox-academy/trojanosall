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

namespace ColoredBox
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

            // draw a box that has different colored lines on each edge.
            DrawBox(foxDraw);

        }

        public static void DrawBox(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Magenta);
            foxDraw.DrawLine(30, 30, 100, 30);

            foxDraw.StrokeColor(Colors.Bisque);
            foxDraw.DrawLine(30, 100, 100, 100);

            foxDraw.StrokeColor(Colors.Gainsboro);
            foxDraw.DrawLine(30, 30, 30, 100);

            foxDraw.StrokeColor(Colors.RosyBrown);
            foxDraw.DrawLine(100, 30, 100, 100);

        }

    }
}
