using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace PZPK_Labas.Laba2
{
    public static class Task7
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 7: Для кожного рядка знайти останній парний елемент " +
                "і записати дані в новий масив. ");

            int n;
            ConsoleInput.SafeIntInput("Введіть кількість рядків матриці", out n);

            int[][] matrix = ArrayHelper.GenerateStepMatrix(n, -100, 100);

            Console.WriteLine("Матриця: ");
            ArrayHelper.PrintStepMatrix(matrix);

            Console.WriteLine("\nМасив: ");
            ArrayHelper.PrintArray(GetLastEvenElements(matrix));
        }

        public static int[] GetLastEvenElements(int[][] matrix)
        {
            int[] result = new int[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                int lastEvenElement = 0;

                for (int j = 0; j < matrix[i].Length; j++)
                    if (matrix[i][j] % 2 == 0)
                        lastEvenElement = matrix[i][j];

                result[i] = lastEvenElement;
            }

            return result;
        }
    }
}
