namespace PZPK_Labas.Laba1
{
    public static class Task9
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 9. Написати програму, згідно умови завдання, використовуючи оператор циклу з передумовою(оператор while).");

            Console.WriteLine($"Сумма послідовності: {SumTask9()}");

            Console.ReadKey();
            Console.WriteLine();
        }

        private static double SumTask9()
        {
            double sum = 0;

            double tolerance = Math.Pow(10, -5);
            double x = 0.1;
            int n = 1;

            do
            {
                double addAmount = Math.Pow(-1, n - 1) * Math.Pow(x, n - 1) / (Math.Pow(2 * n, n) - 1);

                if (addAmount < tolerance)
                    break;

                sum += addAmount;
                n++;
            } while (true);

            sum = Math.Round(sum, 3);

            return sum;
        }
    }
}
