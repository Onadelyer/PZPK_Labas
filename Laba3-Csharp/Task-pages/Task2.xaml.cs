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
    public partial class Task2 : Page
    {
        public Task2()
        {
            InitializeComponent();

            BubbleButton.Click += (sender, e) =>
            {
                var array = GetArrayFromBox();
                BubbleSort.Sort(array);
                ChangeTextBox(array);
            };
            ShakerButton.Click += (sender, e) =>
            {
                var array = GetArrayFromBox();
                ShakerSort.Sort(array);
                ChangeTextBox(array);
            };
            InsertionButton.Click += (sender, e) =>
            {
                var array = GetArrayFromBox();
                InsertionSort.Sort(array);
                ChangeTextBox(array);
            };  
            StoogeButton.Click += (sender, e) =>
            {
                var array = GetArrayFromBox();
                StoogeSort.Sort(array, 0, array.Length - 1);
                ChangeTextBox(array);
            };
            ShellButton.Click += (sender, e) =>
            {
                var array = GetArrayFromBox();
                ShellSort.Sort(array);
                ChangeTextBox(array);
            };
            MergeButton.Click += (sender, e) =>
            {
                var array = GetArrayFromBox();
                MergeSort.Sort(array, 0, array.Length - 1);
                ChangeTextBox(array);
            };
            SelectionButton.Click += (sender, e) =>
            {
                var array = GetArrayFromBox();
                SelectionSort.Sort(array);
                ChangeTextBox(array);
            };
            QuickButton.Click += (sender, e) =>
            {
                var array = GetArrayFromBox();
                QuickSort.Sort(array, 0, array.Length - 1);
                ChangeTextBox(array);
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
            var array = new int[50];

            var random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }

            ChangeTextBox(array);
        }
    }
}
