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
    public partial class Task2 : Page
    {
        private Regex regex = new Regex("10|[0-9]|[A-F]");

        public Task2()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MatchCollection matches = regex.Matches(Input.Text);

            MatchesLabel.Content = matches.Count;

            Output.Text = "";
            foreach (Match match in matches)
                Output.Text += match.Value + " ";

            ReplacedOutout.Text = regex.Replace(Input.Text, ReplaceText.Text);
        }
    }
}
