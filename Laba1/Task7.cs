using Extensions;

namespace PZPK_Labas.Laba1
{
    public static class Task7
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 7. Написати програму, згідно умови завдання, використовуючи оператор циклу з параметром (оператор for).");

            int k = 9;
            int x;

            ConsoleInput.SafeIntInput("Введіть x", out x);

            Console.WriteLine($"Сума послідовності: {SumTask7(k, x)}");

            Console.ReadKey();
            Console.WriteLine();
        }

        private static double SumTask7(int k, int x)
        {
            double sum = 0;

            for (int n = 1; n < k; n++)
            {
                sum += Math.Pow(-1, n) * ((n + 1) / (Math.Pow(n * x, 2) + 1));
            }

            return sum;
        }
    }
}
