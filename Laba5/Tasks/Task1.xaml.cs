using Laba5.Models;
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

namespace Laba5.Tasks
{
    /// <summary>
    /// Interaction logic for Task1.xaml
    /// </summary>
    public partial class Task1 : Page
    {
        List<Keeper> keepers = new List<Keeper>();
        List<Keeper> keepersThatWorkMoreThan10Years = new List<Keeper>();

        public Task1()
        {
            InitializeComponent();

            keepers = Keeper.GetKeepers("Task1.txt");

            KeepersGrid.ItemsSource = keepers;
            KeepersGrid.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            keepers.Add(Keeper.GenerateRandomKeeper());
            KeepersGrid.ItemsSource = keepers;
            KeepersGrid.Items.Refresh();

            FileHandler.WriteToTextFile("Task1.txt", keepers.Select(keeper => keeper.ToString()).ToArray());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            keepersThatWorkMoreThan10Years = keepers.Where(keeper => Math.Abs(keeper.YearOfEmployment - DateTime.Now.Year) > 10).ToList();
            KeepersGrid.ItemsSource = keepersThatWorkMoreThan10Years;
            KeepersGrid.Items.Refresh();
        }
    }
}
