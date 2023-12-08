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

namespace Laba7.Tasks
{
    public partial class Task4 : Page
    {
        public Task4()
        {
            InitializeComponent();
        }

        public void CalculateClick(object sender, RoutedEventArgs e)
        {
            Tuple<int, int, int, int, int, int> examScores = new Tuple<int, int, int, int, int, int>
                (int.Parse(box1.Text), int.Parse(box2.Text), int.Parse(box3.Text), 
                int.Parse(box4.Text), int.Parse(box5.Text), int.Parse(box6.Text));

            MessageBox.Show(GetRating(NameBox.Text, examScores, double.Parse(CoefficientBox.Text)));
        }

        static string GetRating(string student, Tuple<int, int, int, int, int, int> examScores, double diligenceCoefficient)
        {
            double averageScore = new int[] { examScores.Item1, examScores.Item2, examScores.Item3, examScores.Item4, examScores.Item5, examScores.Item6, }.Average();

            double grade = averageScore + 1.25 * diligenceCoefficient;

            double roundedGrade = Math.Round(grade, 1);

            string result = $"Рейтинг студента {student} рівний {roundedGrade}";

            return result;
        }
    }
}
