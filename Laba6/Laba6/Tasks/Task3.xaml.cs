using Laba6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Laba6.Tasks
{
    /// <summary>
    /// Interaction logic for Task3.xaml
    /// </summary>
    public partial class Task3 : Page
    {
        Task3Class task3 = new Task3Class(30, 12, 2003);

        public Task3()
        {
            InitializeComponent();
            DataLabel.Content = "Дата в об'єкті: " + task3.ToString();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int year = int.Parse(InputBox.Text);

            task3.CalculateAgeOfProduct(year);

            ResultLabel.Content = task3.AgeOfProduct;
        }
    }
}
