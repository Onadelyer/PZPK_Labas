using Extensions;
using System.Drawing;

namespace PZPK_Labas.Laba1
{
    public static class Task10
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 10. Серія пострілів по мішені. Студент задає із клавіатури координати десяти пострілів. Обчислити чи відбулось попадання в мішень.");

            int radius;
            ConsoleInput.SafeIntInput("Введіть радіус мішені", out radius);

            int countOfShoots = 3;

            for (int i = 0; i < countOfShoots; i++)
            {
                Console.WriteLine($"Постріл №{i + 1}");
                int x;
                int y;

                ConsoleInput.SafeIntInput("\tX", out x);
                ConsoleInput.SafeIntInput("\tY", out y);

                CalculateHit(i + 1, x, y, radius);
            }


            Console.ReadKey();
            Console.WriteLine();
        }

        private static void CalculateHit(int i, int x, int y, int radius)
        {
            //Console.WriteLine(string.Format("{0,-10} | ({1,-3}, {2, -3}) | {3, -7}", $"№", "X", "Y", "Результат"));

            string result = Task4.CalculatePointInCircle(new Point(x, y), radius) ? "Попав" : "Не попав";

            Console.WriteLine(string.Format("{0,-10} | ({1,-3}, {2, -3}) | {3, -7}", $"Постріл №{i}", x, y, result));
        }
    }
}
