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

namespace Laba11
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

        public void Task1Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.Task1());
        }
        
        public void Task2Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.Task2());
        }
        
        public void Task3Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.Task3());
        }
    }
}
