using Laba6.Models;
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

namespace Laba6.Tasks
{
    /// <summary>
    /// Interaction logic for Task6.xaml
    /// </summary>
    public partial class Task6 : Page
    {
        PlantDatabase PlantDatabase { get; set; } = new();

        public Task6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PlantDatabase.GeneratePlants();
            PlantDatabase.DisplayInformationOnScreen(ResultLabel);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PlantDatabase.DisplayPlantsOnTheVergeOfExtinction(ResultLabel);
        }
    }
}
