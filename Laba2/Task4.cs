using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZPK_Labas.Laba2
{
    public static class Task4
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 4. Розробити програму, яка знаходить і друкує номери тих рядків, " +
                "\nелементи в яких не повторюються. Якщо таких рядків немає, то друкує повідомлення про це.\n");

            int x, y;

            Console.WriteLine("Введіть розмірність матриці: ");
            ConsoleInput.SafeIntInput("\tX", out x);
            ConsoleInput.SafeIntInput("\tY", out y);

            int[,] matrix = ArrayHelper.GenerateMatrix(y, x, -50, 49);

            Console.WriteLine("Матриця");
            ArrayHelper.PrintMatrix(matrix);

            CalculateRowsWithNoRepeatNumbers(matrix);
        }

        private static void CalculateRowsWithNoRepeatNumbers(int[,] matrix)
        {
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] row = new int[matrix.GetLength(1)];

                for (int j = 0; j < matrix.GetLength(1); j++)
                    row[j] = matrix[i, j];

                if (HasRepeatNumbers(row))
                    Console.WriteLine($"Рядок #{i+1} має повторювані числа");
            }
        }

        private static bool HasRepeatNumbers(int[] row)
        {
            for (int i = 0; i < row.Length; i++)
                for (int j = i + 1; j < row.Length; j++)
                    if (row[i] == row[j])
                        return true;

            return false;
        }
    }
}
