using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZPK_Labas.Laba2
{
    public static class Task3
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 3. Обчислити елементи масиву Y за формулою. Сформувати та вивести на екран новий масив R, \n" +
                "елементами якого є парні за індексом елементи вихідного (початкового) масиву Х та масиву Y.\n");

            int n;
            ConsoleInput.SafeIntInput("Введіть кількість елементів масиву", out n);

            int[] array = ArrayHelper.GenerateArray(n);

            Console.WriteLine("Массив X:");
            ArrayHelper.PrintArray(array);

            Console.WriteLine("\nМассив Y:");
            ArrayHelper.PrintArray(GetArrayY(array));
        }

        private static double[] GetArrayY(int[] arrayX)
        {
            double[] arrayY = new double[arrayX.Length];

            for (int i = 0; i < arrayX.Length; i++)
            {
                int x = arrayX[i];

                if (Math.Cos(x) > 0)
                    arrayY[i] = Math.Round(Math.Pow(x, 3) - 7.5, 2);
                else if (Math.Sin(x) <= 0)
                    arrayY[i] = Math.Round(Math.Pow(x, 2) - (5 * Math.Pow(Math.E, Math.Sin(x))), 2);
            }

            return arrayY;
        }
    }
}
