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

namespace Laba5.Tasks
{
    /// <summary>
    /// Interaction logic for Task5.xaml
    /// </summary>
    public partial class Task5 : Page
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void showResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Please provide valid input.");
                    return;
                }

                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);

                string operation = ((ComboBoxItem)operationComboBox.SelectedItem).Content.ToString();
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        MessageBox.Show("Invalid operation.");
                        return;
                }

                string resultString = $"{num1} {operation} {num2} Result = {result}";
                MessageBox.Show($"Result: {result}");
                FileHandler.WriteToTextFile("Task5Output.bin", new string[] { resultString });
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter numeric values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
