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
            string formattedText = Regex.Replace(Input.Text, "#");

            FileHandler.WriteToTextFile("Original.txt", Input.Text.Split('\n'));
            FileHandler.WriteToTextFile("Formatted.txt", formattedText.Split('\n'));

            UpdateTextBlocks();
        }

        private void UpdateTextBlocks()
        {
            Input.Text = string.Join("\n", FileHandler.ReadFromTextFile("Original.txt"));
            Output.Text = string.Join("\n", FileHandler.ReadFromTextFile("Formatted.txt"));
        }
    }
}
