using Extensions;

namespace PZPK_Labas.Laba1
{
    public static class Task3
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 3. Написати програму, яка по веденому значенню аргументу обчислює значення функції, що задається у вигляді графіку.");

            for (int i = 0; i < 3; i++)
                GetFunctionValue();
        }

        private static void GetFunctionValue()
        {
            int x;
            ConsoleInput.SafeIntInput("Введіть значення аргументу", out x);

            if (x < -4 || x > 10)
                Console.WriteLine("Значення функції немає");
            else if (x >= -4 && x <= -2)
                Console.WriteLine($"Значення функції: {x + 3}");
            else if (x >= -2 && x <= 4)
                Console.WriteLine($"Значення функції: {-(x / 2)}");
            else if (x >= 4 && x <= 6)
                Console.WriteLine($"Значення функції: {-2}");
            else if (x >= 6 && x <= 10)
                Console.WriteLine($"Значення функції: {Math.Round(-2 + Math.Sqrt(4 - Math.Pow(x - 8, 2)), 3)}");
        }
    }
}
