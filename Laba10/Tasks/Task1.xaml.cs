using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Laba10.Tasks
{
    /// <summary>
    /// Interaction logic for Task1.xaml
    /// </summary>
    public partial class Task1 : Page
    {
        string loadedText = "";

        public Task1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                loadedText = File.ReadAllText(filePath);
            }

            ResultLabel.Content = loadedText;
        }
        
        void Button_Click2(object sender, RoutedEventArgs e)
        {
            string inputText = loadedText;
            bool isValid = ValidateBrackets(inputText);

            if (isValid)
                MessageBox.Show("Input is correct");
            else
                MessageBox.Show("Input is incorrect");
        }

        public bool ValidateBrackets(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();

            foreach (char c in text)
            {
                if (c == '(')
                    stack.Push(c);
                else if (c == ')')
                {
                    if (stack.Count == 0 || stack.Peek() != '(')
                        return false;
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}
