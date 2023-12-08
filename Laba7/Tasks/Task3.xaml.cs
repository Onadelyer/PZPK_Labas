using System;
using Laba7.Models;
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

namespace Laba7.Tasks
{
    public partial class Task3 : Page
    {
        List<Tuple<string, int, KindOfSport, AgeSection>> gameResults = new List<Tuple<string, int, KindOfSport, AgeSection>>();

        public Task3()
        {
            InitializeComponent();

            GenerateGameResults();
        }

        public void ShowButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "";

            foreach (var result in gameResults)
                ResultLabel.Content += string.Format("Назва:{0}    Загальний бал:{1}    Вид спорту:{2}    Вікова група:{3} \n", result.Item1, result.Item2, result.Item3, result.Item4);
        }

        public void SelectButtonClick(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "";

            var selectedResults = gameResults.Where(result => result.Item2 > gameResults.Average(r => r.Item2));

            foreach (var result in selectedResults)
                ResultLabel.Content += string.Format("Назва:{0}    Загальний бал:{1}    Вид спорту:{2}    Вікова група:{3} \n", result.Item1, result.Item2, result.Item3, result.Item4);

            PassedCount.Content = "Count of passed teams: " + gameResults.Average(r => r.Item2);
        }

        private void GenerateGameResults()
        {
            gameResults.Add(new Tuple<string, int, KindOfSport, AgeSection>("Team1", 1, KindOfSport.Volleyball, AgeSection.Junior));
            gameResults.Add(new Tuple<string, int, KindOfSport, AgeSection>("Team2", 2, KindOfSport.Basketball, AgeSection.Senior));
            gameResults.Add(new Tuple<string, int, KindOfSport, AgeSection>("Team3", 3, KindOfSport.Tennis, AgeSection.Middle));
            gameResults.Add(new Tuple<string, int, KindOfSport, AgeSection>("Team4", 4, KindOfSport.Basketball, AgeSection.Junior));
            gameResults.Add(new Tuple<string, int, KindOfSport, AgeSection>("Team5", 5, KindOfSport.Hockey, AgeSection.Senior));
            gameResults.Add(new Tuple<string, int, KindOfSport, AgeSection>("Team6", 6, KindOfSport.Volleyball, AgeSection.Middle));
            gameResults.Add(new Tuple<string, int, KindOfSport, AgeSection>("Team7", 7, KindOfSport.Football, AgeSection.Junior));
            gameResults.Add(new Tuple<string, int, KindOfSport, AgeSection>("Team8", 8, KindOfSport.Tennis, AgeSection.Senior));
            gameResults.Add(new Tuple<string, int, KindOfSport, AgeSection>("Team9", 9, KindOfSport.Football, AgeSection.Middle));
            gameResults.Add(new Tuple<string, int, KindOfSport, AgeSection>("Team10", 10, KindOfSport.Hockey, AgeSection.Junior));
        }
    }
}
