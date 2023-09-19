using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZPK_Labas.Laba2
{
    public static class Task5
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 5. У заданій матриці розмірності 6 на 4 визначити номер стовпця з мінімальною " +
                                "сумою елементів і величину цієї суми.");

            int[,] matrix = ArrayHelper.GenerateMatrix(4, 6, -50, 49);

            Console.WriteLine("Матриця:");
            ArrayHelper.PrintMatrix(matrix);

            CalculateRowWithWithMinSum(matrix);
        }

        private static void CalculateRowWithWithMinSum(int[,] matrix)
        {
            int minSum = int.MaxValue;
            int minSumColumnIndex = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                    sum += matrix[i, j];
                if (sum < minSum)
                {
                    minSum = sum;
                    minSumColumnIndex = i;
                }
            }
            Console.WriteLine($"Номер стовпця з мінімальною сумою елементів: {minSumColumnIndex + 1}");
            Console.WriteLine($"Величина цієї суми: {minSum}");
        }
    }
}
