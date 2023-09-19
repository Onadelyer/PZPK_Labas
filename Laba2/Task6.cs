using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZPK_Labas.Laba2
{
    public static class Task6
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 6. У двовимірному масиві зберігається дохід 10 магазинів за кожен місяць року (кожному магазину відповідає один рядок). " +
                "\nНаписати програму, що визначає дохід обраного користувачем магазину за обраний квартал року.");

            //int[,] matrix = ArrayHelper.InputMatrix(10, 12);
            int[,] matrix = ArrayHelper.GenerateMatrix(10, 12, 0, 1000);

            Console.WriteLine("\nМатриця:\n");
            PrintProfitMatrix(matrix);

            AskClientForProfit(matrix);
        }

        private static void PrintProfitMatrix(int[,] matrix)
        {
            // array of months            // array of months
            string[] months = new string[] { "Січень", "Лютий", "Березень", "Квітень",
                "Травень", "Червень", "Липень", "Серпень", "Вересень",
                "Жовтень", "Листопад", "Грудень"};
            // print months
            Console.Write("{0, -13}", "МІСЯЦІ");
            for (int i = 0; i < months.Length; i++)
                Console.Write("{0, 10}", months[i]);
            Console.WriteLine();
            // print profit

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("{0, -13}",$"Магазин #{i+1}: ");
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 10}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void AskClientForProfit(int[,] matrix)
        {
            Console.WriteLine();

            bool isAsking = true;

            while (isAsking)
            {
                int shopIndex, monthIndex;
                ConsoleInput.SafeIntInput("Введіть номер магазину", out shopIndex);
                ConsoleInput.SafeIntInput("Введіть номер місяця", out monthIndex);

                Console.WriteLine($"Дохід магазину #{shopIndex} за місяць #{monthIndex}: {matrix[shopIndex - 1, monthIndex - 1]}");

                Console.Write("Продовжити? (y/n)");
                isAsking = Console.ReadLine().Contains('y');
            }
        }
    }
}
