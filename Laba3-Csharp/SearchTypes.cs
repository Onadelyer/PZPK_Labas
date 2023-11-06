using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_Csharp
{
    public class LongestCommonSubstring
    {
        public static string Search(string str1, string str2)
        {
            int[,] dp = new int[str1.Length + 1, str2.Length + 1];
            int maxLength = 0;
            int endIndex = 0;

            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                        if (dp[i, j] > maxLength)
                        {
                            maxLength = dp[i, j];
                            endIndex = i;
                        }
                    }
                }
            }

            return str1.Substring(endIndex - maxLength, maxLength);
        }
    }

    public class BinarySearch
    {
        public static int Search(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;

                if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // Повертаємо -1, якщо елемент не знайдено
        }
    }

    public class LinearSearch
    {
        public static int Search(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i; // Повертаємо індекс, якщо елемент знайдено
            }
            return -1; // Повертаємо -1, якщо елемент не знайдено
        }
    }
}
