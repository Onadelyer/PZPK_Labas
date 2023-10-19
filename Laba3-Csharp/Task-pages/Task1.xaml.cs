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
    /// <summary>
    /// Interaction logic for Task1.xaml
    /// </summary>
    public partial class Task1 : Page
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            int[,] matrix = Task1Logic.GenerateMatrix(7, 5);
            Task1Logic.FillTextBoxWithMatrix(InputBox, matrix);
            int[] array = Task1Logic.GenerateCalculatedArray(matrix);
            Task1Logic.FillTextBoxWithArray(OutputBox, array);
        }
    }

    public static class Task1Logic
    {
        public static int[,] GenerateMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < columns; i++)
            {
                int sum = 0;
                for (int j = 0; j < rows; j++)
                {
                    matrix[j, i] = random.Next(-100, 101);
                    sum += matrix[j, i];
                }
                matrix[i, columns - 1] = sum;
            }

            return matrix;
        }

        public static void FillTextBoxWithMatrix(TextBox box, int[,] matrix)
        {
            box.Text = "";

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                string row = "";
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    row += matrix[i, j] + " ";
                }
                box.Text += row + "\n";
            }
        }

        public static void FillTextBoxWithArray(TextBox box, int[] array)
        {
            box.Text = "";

            string row = "";
            for (int i = 0; i < array.Length; i++)
            {
                row += array[i] + " ";
            }
            box.Text += row + "\n";
        }

        public static int[] GenerateCalculatedArray(int[,] matrix)
        {
            int[] array = new int[matrix.GetLength(0)];
            
            for(int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                for(int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] < 0)
                        sum += matrix[i, j];
                array[i] = sum;
            }

            return array;
        }
    }
}
