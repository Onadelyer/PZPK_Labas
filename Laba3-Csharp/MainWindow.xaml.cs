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

namespace Laba3_Csharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Uri("Task-pages/Task1.xaml", UriKind.Relative));
        }

        private void Task1ButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Task-pages/Task1.xaml", UriKind.Relative));
        }

        private void Task2ButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Task-pages/Task2.xaml", UriKind.Relative));
        }

        private void Task3ButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Task-pages/Task3.xaml", UriKind.Relative));
        }

        private void Task4ButtonClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Task-pages/Task4.xaml", UriKind.Relative));
        }
    }
}
