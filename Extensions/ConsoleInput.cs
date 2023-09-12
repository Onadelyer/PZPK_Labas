using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class ConsoleInput
    {
        public static void SafeIntInput(string message, out int value)
        {
            while (true)
            {
                Console.Write(message + ": ");


                if (int.TryParse(Console.ReadLine(), out value))
                    break;
                else
                    Console.WriteLine("Введіть ціле число!");
            }
        }

        public static void SafeIntInput(string message, out double value)
        {
            while (true)
            {
                Console.Write(message + ": ");


                if (double.TryParse(Console.ReadLine(), out value))
                    break;
                else
                    Console.WriteLine("Введіть ціле число!");
            }
        }
    }
}
