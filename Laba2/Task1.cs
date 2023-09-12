using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PZPK_Labas.Laba2
{
    public static class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 1. " + "Дано ціле-чисельний масив, що складається із n (позитивних та негативних) елементів.\n" + 
                "Отримати новий масив, як різницю між елементами вхідного масиву та його середнього арифметичного.");

            int n;
            ConsoleInput.SafeIntInput("Введіть кількість елементів масиву", out n);

            int[] array = ArrayHelper.GenerateArray(n, 0, 20);

            Console.WriteLine("\nПочатковий масив:");
            ArrayHelper.PrintArray(array);

            Console.WriteLine($"\nСереднє арифметичне масиву: {GetAveregeNumberOfArray(array)}\n");

            Console.WriteLine("Оброблений масив:");
            ArrayHelper.PrintArray(GetModifiedArray(array, GetAveregeNumberOfArray(array)));

            Console.WriteLine();
            Console.ReadLine();
        }

        private static int[] GetModifiedArray(int[] array, int average)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[i] - average;

            return newArray;
        }

        private static int GetAveregeNumberOfArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
                sum += array[i];

            return sum / array.Length;
        }
    }
}
