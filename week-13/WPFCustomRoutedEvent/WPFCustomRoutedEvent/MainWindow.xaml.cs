using System.Windows;

namespace WPFCustomRoutedEvent
{
    // <summary> 
    // Interaction logic for MainWindow.xaml
    // </summary> 

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyCustomControl_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("It is the custom routed event of your custom control");
        }

    }
}