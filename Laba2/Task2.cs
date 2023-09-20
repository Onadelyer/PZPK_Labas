using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZPK_Labas.Laba2
{
    public static class Task2
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 2. Задано масив. Знайти суму чисел, що знаходяться між максимальним і мінімальним елементами масиву \n" +
                "(в суму включити ці елементи). Вивести суму на екран.");

            int n;
            ConsoleInput.SafeIntInput("Введіть кількість елементів масиву", out n);

            int[] array = ArrayHelper.GenerateArray(n);

            Console.WriteLine("Масив: ");
            ArrayHelper.PrintArray(array);

            GetSumBetweenMaxAndMin(array);
        }

        private static void GetSumBetweenMaxAndMin(int[] array)
        {
            int maxIndex = 0;
            int minIndex = 0;
            int sum = 0;

            // Find max and min index
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;

                if (array[i] < array[minIndex])
                    minIndex = i;
            }

            Console.WriteLine("Максимальний елемент: " + array[maxIndex] + " | " + "Мінімальний елемент: " + array[minIndex]);


            int firstIndex = maxIndex > minIndex ? minIndex : maxIndex;
            int secondIndex = maxIndex < minIndex ? minIndex : maxIndex;

            for(int i = firstIndex; i <= secondIndex;i++)
                sum += array[i];

            Console.WriteLine("Cума між мінімальним і максимальним елементом: " + sum);
        }

    }
}
