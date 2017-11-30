using System;
using System.IO;
using System.Windows;

namespace WPFCommandLine
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            String[] args = App.Args;

            try
            {
                // Open the text file using a stream reader. 
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    // Read the stream to a string, and write  
                    // the string to the text box 
                    String line = sr.ReadToEnd();
                    textBox.AppendText(line.ToString());
                    textBox.AppendText("\n");
                }
            }
            catch (Exception e)
            {
                textBox.AppendText("The file could not be read:");
                textBox.AppendText("\n");
                textBox.AppendText(e.Message);
            }
        }
    }
}