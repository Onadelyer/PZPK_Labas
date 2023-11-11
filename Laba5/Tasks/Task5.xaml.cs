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

namespace Laba5.Tasks
{
    public partial class Task5 : Page
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void LoadDataFromFile(object sender, RoutedEventArgs e)
        {
            int? first, second;

            (first, second) = LoadParametersFromFile();

            if (first == null || second == null)
                return;

            variable1Box.Text = first.ToString();
            variable2Box.Text = second.ToString();
        }

        private void CalculateResult(object sender, RoutedEventArgs e)
        {
            double operand1 = double.Parse(variable1Box.Text);
            double operand2 = double.Parse(variable2Box.Text);

            string operation = operationComboBox.Text;

            string result = $"{operand1} {operation} {operand2} Результат = {Calculate(operand1, operand2, operation).ToString()}";

            resultBox.Text = result;

            FileHandler.WriteToTextFile("./Result.txt", new string[] { result } );
        }

        private double Calculate(double operand1, double operand2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    if (operand2 != 0)
                    {
                        return operand1 / operand2;
                    }
                    else
                    {
                        MessageBox.Show("Помилка: Ділення на нуль.");
                        return double.NaN;
                    }
                default:
                    MessageBox.Show("Помилка: Оберіть операцію.");
                    return double.NaN;
            }
        }


        private (int?, int?) LoadParametersFromFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select a File";
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                try
                {
                    string selectedFilePath = openFileDialog.FileName;

                    string[] lines = File.ReadAllLines(selectedFilePath);

                    if (lines.Length >= 2 && int.TryParse(lines[0], out int firstNumber) && int.TryParse(lines[1], out int secondNumber))
                        return (firstNumber, secondNumber);
                    else
                        MessageBox.Show("Неправильний формат файлу. Переконайтеся, що файл містить два цілих числа на окремих рядках.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка читання файлу: {ex.Message}");
                }
            }
            else
                MessageBox.Show("Операцію відмінено");

            return (null, null);
        }

    }
}
