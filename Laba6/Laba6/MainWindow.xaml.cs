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

namespace Laba6
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

        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.Task1());
        }

        private void ButtonClick2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.Task2());
        }

        private void ButtonClick3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.Task3());
        }

        private void ButtonClick4(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.Task4());
        }

        private void ButtonClick5(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.Task5());
        }

        private void ButtonClick6(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.Task6());
        }

        private void ButtonClick7(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.Task7());
        }

        private void ButtonClick8(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.Task8());
        }

    }
}
