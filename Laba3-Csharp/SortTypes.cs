using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_Csharp
{
    public class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }

    public class ShakerSort
    {
        public static void Sort(int[] arr)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
                swapped = false;
                for (int i = arr.Length - 2; i >= 0; i--)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }

    public class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }

    public class StoogeSort
    {
        public static void Sort(int[] arr, int l, int h)
        {
            if (l >= h) return;

            if (arr[l] > arr[h])
            {
                int t = arr[l];
                arr[l] = arr[h];
                arr[h] = t;
            }

            if (h - l + 1 > 2)
            {
                int t = (int)Math.Floor((h - l + 1) / 3.0);
                Sort(arr, l, h - t);
                Sort(arr, l + t, h);
                Sort(arr, l, h - t);
            }
        }
    }

    public class ShellSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
        }
    }

    public class MergeSort
    {
        public static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                Sort(arr, l, m);
                Sort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (int j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            int k = l;
            int a = 0, b = 0;
            while (a < n1 && b < n2)
            {
                if (L[a] <= R[b])
                {
                    arr[k] = L[a];
                    a++;
                }
                else
                {
                    arr[k] = R[b];
                    b++;
                }
                k++;
            }

            while (a < n1)
            {
                arr[k] = L[a];
                a++;
                k++;
            }

            while (b < n2)
            {
                arr[k] = R[b];
                b++;
                k++;
            }
        }
    }

    public class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }
    }

    public class QuickSort
    {
        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }
    }
}
