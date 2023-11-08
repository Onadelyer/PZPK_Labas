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

namespace Laba5.Tasks
{
    /// <summary>
    /// Interaction logic for Task3.xaml
    /// </summary>
    public partial class Task3 : Page
    {
        private Regex Regex = new Regex(@"\b\w+\b");

        public Task3()
        {
            InitializeComponent();
            UpdateTextBlocks();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MatchCollection matches = Regex.Matches(Input.Text);
            int maxWordLengh = matches.Max(x => x.Value.Length);

            string formattedText = matches.Select(match => match.Value).Select(match =>
            {
                if(match.Length == maxWordLengh)
                    return ReplaceAllCharacters(match, '#');
                else
                    return match;
            }).Aggregate((x, y) => x + " " + y);

            FileHandler.WriteToTextFile("Original.txt", Input.Text.Split('\n'));
            FileHandler.WriteToTextFile("Formatted.txt", formattedText.Split('\n'));

            UpdateTextBlocks();
        }

        private void UpdateTextBlocks()
        {
            Input.Text = string.Join("\n", FileHandler.ReadFromTextFile("Original.txt"));
            Output.Text = string.Join("\n", FileHandler.ReadFromTextFile("Formatted.txt"));
        }

        private static string ReplaceAllCharacters(string word, char replacementChar)
        {
            char[] charArray = word.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = replacementChar;
            }
            return new string(charArray);
        }
    }
}
