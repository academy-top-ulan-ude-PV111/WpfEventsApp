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

namespace WpfEventsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                //MessageBox.Show(button.Background.ToString() + " " + (e.OriginalSource as Button).Background.ToString());
                //e.Handled = true;
                tablo.Text += "Mouse Click:\n";
                tablo.Text += "Sender: " + button.Background.ToString() + "\n";
                tablo.Text += "Source: " + (e.OriginalSource as Button).Background.ToString() + "\n\n";

            }
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button button)
            {
                tablo.Text += "MouseDown Click:\n";
                tablo.Text += "Sender: " + button.Background.ToString() + "\n";
                tablo.Text += "Source: " + (e.Source as Button).Background.ToString() + "\n\n";
            }
                
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button button)
            {
                tablo.Text += "PreviewMouseDown Click:\n";
                tablo.Text += "Sender: " + button.Background.ToString() + "\n";
                tablo.Text += "Source: " + (e.Source as Button).Background.ToString() + "\n\n";
            }
                
        }
    }
}
