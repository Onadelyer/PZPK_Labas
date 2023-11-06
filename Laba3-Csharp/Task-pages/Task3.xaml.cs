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

namespace Laba3_Csharp.Task_pages
{
    public partial class Task3 : Page
    {
        public Task3()
        {
            InitializeComponent();

            LongestCommonSubstringSearch.Click += (sender, e) =>
            {
                LongestCommonSubstring.Search(OutputBox.Text, IndexOutput.Text);
                
            };
        }

        private void ChangeTextBox(int[] array)
        {
            OutputBox.Text = "";

            for (int i = 0; i < array.Length; i++)
            {
                OutputBox.Text += array[i] + " ";
            }
        }

        private int[] GetArrayFromBox()
        {
            try
            {
                string text = OutputBox.Text;

                var a = text.Split(' ').Where(n => n != "");

                return a.Select(n => int.Parse(n)).ToArray();
            }
            catch
            {
                return new int[0];
            }
        }

        private void GenerateNumbersToSort(object sender, RoutedEventArgs e)
        {
            var array = new int[15];

            var random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }

            ChangeTextBox(array);
        }
    }
}
