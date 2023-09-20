using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class ArrayHelper
    {
        public static int[] GenerateArray(int countOfElements, int elementMin = -100, int elementMax = 100)
        {
            int[] array = new int[countOfElements];

            Random random = new Random();

            for (int i = 0; i < countOfElements; i++)
                array[i] = random.Next(elementMin, elementMax+1);

            return array;
        }

        public static int[] InputArray(int countOfElements)
        {
            int[] array = new int[countOfElements];

            for (int i = 0; i < countOfElements; i++)
                ConsoleInput.SafeIntInput($"Елемент №{i + 1}", out array[i]);

            return array;
        }

        public static int[,] InputMatrix(int countOfCollums, int countOfRows)
        {
            int[,] matrix = new int[countOfCollums, countOfRows];

            for (int i = 0; i < countOfCollums; i++)
                for (int j = 0; j < countOfRows; j++)
                    ConsoleInput.SafeIntInput($"Елемент [{i + 1}][{j + 1}]", out matrix[i, j]);

            return matrix;
        }

        public static int[,] GenerateMatrix(int countOfCollums, int countOfRows, int elementMin = -100, int elementMax = 100)
        {
            int[,] matrix = new int[countOfCollums, countOfRows];

            Random random = new Random();

            for (int i = 0; i < countOfCollums; i++)
                for (int j = 0; j < countOfRows; j++)
                    matrix[i, j] = random.Next(elementMin, elementMax+1);

            return matrix;
        }

        public static int[][] GenerateStepMatrix(int n, int min, int max)
        {
            int[][] matrix = new int[n][];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[i+1];
                for (int j = 0; j <= i; j++)
                {
                    matrix[i][j] = random.Next(min, max + 1);
                }
            }

            return matrix;
        }

        public static int[][] InputStepMatrix(int n)
        {
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[i];
                for (int j = 0; j < n; j++)
                {
                    ConsoleInput.SafeIntInput($"Елемент [{i + 1}][{j + 1}]", out matrix[i][j]);
                }
            }

            return matrix;
        }



        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0, 5}", array[i]);

            Console.WriteLine();
        }

        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0, 11}", array[i]);

            Console.WriteLine();
        }


        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 5}", matrix[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 5}", matrix[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void PrintStepMatrix(int[][] matrix)
        {
            foreach (int[] row in matrix)
            {
                foreach (int element in row)
                {
                    Console.Write("{0, 5}", element);
                }
                Console.WriteLine();
            }
        }
    }
}
