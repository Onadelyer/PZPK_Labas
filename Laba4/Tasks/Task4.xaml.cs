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

namespace Laba4.Tasks
{
    /// <summary>
    /// Interaction logic for Task2.xaml
    /// </summary>
    public partial class Task4 : Page
    {
        private Regex regex = new Regex(@"\b\w+\b");

        public Task4()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MatchCollection matches = regex.Matches(Input.Text);

            List <string[]> chains = new List<string[]>();

            for (int i = 0; i < matches.Count; i++)
            {
                chains.Add(GetChainOfWords(matches, i));
                i += chains.Last().Length - 1;
            }

            string result = "";

            var longestChain = chains.First(chain => chain.Length == chains.Max(ch => ch.Length));

            foreach(var word in longestChain)
                result += word + " ";

            Output.Text = result;
        }

        private string[] GetChainOfWords(MatchCollection text, int startIndex)
        {
            List<string> chain = new List<string>();
            int wordLength = text[startIndex].Length;

            for(int i = startIndex; i < text.Count; i++)
            {
                if (text[i].Length == wordLength)
                    chain.Add(text[i].Value);
                else
                    break;
            }

            return chain.ToArray();
        }
    }
}
