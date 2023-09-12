namespace PZPK_Labas.Laba1
{
    public static class Task8
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 8. Написати програму, згідно умови завдання з використанням вкладених інструкцій оператора for.");


            Console.WriteLine($"Сумма послідовності: {SumTask8()}");

            Console.ReadKey();
            Console.WriteLine();
        }

        private static double SumTask8()
        {
            double sum = 0;

            for (int x = 1; x <= 5; x++)
            {
                for (int k = 0; true; k++)
                {
                    double addAmount = Math.Pow(-1, k) * Math.Pow(x, k + 2) / ((k + 1) * Factorial(k + 2));

                    if (addAmount < 0.00000001)
                        break;

                    sum += addAmount;
                }
            }

            sum = Math.Round(sum, 3);

            return sum;
        }

        private static double Factorial(double number)
        {
            if (number == 0)
                return 1;
            else return number * Factorial(number - 1);
        }
    }
}
