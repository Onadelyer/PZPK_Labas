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
    /// Interaction logic for Task2.xaml
    /// </summary>
    public partial class Task2 : Page
    {
        public Regex regex = new Regex(@"\b\w*a\w*\b");

        public Task2()
        {
            InitializeComponent();
            UpdateTextBlocks();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] generatedSentences = GenerateSentences();

            FileHandler.WriteToTextFile("TF_1.txt", generatedSentences);
            FileHandler.WriteToTextFile("TF_2.txt", FormattedSentences(string.Join("\n", generatedSentences)));

            UpdateTextBlocks();
        }

        private void UpdateTextBlocks()
        {
            TF_1.Text =  string.Join("\n", FileHandler.ReadFromTextFile("TF_1.txt"));
            TF_2.Text =  string.Join("\n", FileHandler.ReadFromTextFile("TF_2.txt"));
        }

        private string[] GenerateSentences()
        {
            string[] sentences = {
            "Hello world! This is a test string.",
            "Another string with multiple words containing 'a' character.",
            "This string doesn't have the character 'a'.",
            "A last line for the TF_1 file.",
            "Random sentence with some words in it.",
            "The quick brown fox jumps over the lazy dog.",
            "A rolling stone gathers no moss.",
            "Actions speak louder than words.",
            "Beauty is in the eye of the beholder.",
            "All that glitters is not gold.",
            "Practice makes perfect.",
            "Where there's a will, there's a way.",
            "Two wrongs don't make a right.",
            "When in Rome, do as the Romans do.",
            "An apple a day keeps the doctor away.",
            "Fortune favors the bold.",
            "Honesty is the best policy.",
            "Look before you leap.",
            "The early bird catches the worm.",
            "When the going gets tough, the tough get going."
            };


            string[] randomSentences = new string[5];
            Random random = new Random();
            for (int i = 0; i < randomSentences.Length; i++)
            {
                string sentence = sentences[random.Next(sentences.Length)];
                randomSentences[i] = sentence;
            }

            return randomSentences;
        }

        private string[] FormattedSentences(string text)
        {
            MatchCollection matches = regex.Matches(text);

            if(matches.Count == 0)
                return new string[] { "No matches found." };

            return matches.Select(match => match.Value).ToArray();
        }
    }
}
