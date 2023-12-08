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

namespace Laba11.Tasks
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var operation = GetSelectedOperation();
                int firstNumber = int.Parse(firstNumberTextBox.Text);
                int secondNumber = int.Parse(secondNumberTextBox.Text);

                var result = Curry(Calculate)(operation)(firstNumber)(secondNumber);
                resultTextBlock.Text = "Result: " + result.ToString();
            }
            catch (Exception ex)
            {
                resultTextBlock.Text = "Error: " + ex.Message;
            }
        }

        private Operation GetSelectedOperation()
        {
            switch (operationComboBox.Text)
            {
                case "Add": return Operation.Add;
                case "Subtract": return Operation.Subtract;
                case "Multiply": return Operation.Multiply;
                case "Divide": return Operation.Divide;
                default: throw new InvalidOperationException("Select an operation");
            }
        }

        enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        static int Calculate(Operation op, int x, int y)
        {
            switch (op)
            {
                case Operation.Add: return x + y;
                case Operation.Subtract: return x - y;
                case Operation.Multiply: return x * y;
                case Operation.Divide: return y != 0 ? x / y : 0;
                default: throw new ArgumentException("Invalid operation");
            }
        }

        static Func<Operation, Func<int, Func<int, int>>> Curry(Func<Operation, int, int, int> func)
        {
            return op => x => y => func(op, x, y);
        }
    }
}
