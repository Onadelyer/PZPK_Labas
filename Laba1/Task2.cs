using Extensions;

namespace PZPK_Labas.Laba1
{
    public static class Task2
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 2. Дано п’ятизначне число. Визначити суму другої та передостанної його цифр.");

            double fiveDigitsNumber;


            InputFiveDigitsNumber(out fiveDigitsNumber);

            FiveDigitsNumberSum(fiveDigitsNumber);

            Console.ReadKey();
            Console.WriteLine();
        }

        private static void InputFiveDigitsNumber(out double fiveDigitsNumber)
        {
            while (true)
            {
                ConsoleInput.SafeIntInput("Введіть п'ятизначне число", out fiveDigitsNumber);

                if (fiveDigitsNumber < 10000 | fiveDigitsNumber > 99999)
                {
                    Console.WriteLine("Введене число не є п'ятизначним!");
                    continue;
                }

                break;
            }
        }

        private static void FiveDigitsNumberSum(double number)
        {
            int i = 1;
            int sum = 0;

            while (number > 0)
            {
                var digit = number % 10;
                number = Math.Truncate(number / 10);

                if (i == 2 || i == 5)
                    sum += (int)digit;

                i++;
            }

            Console.WriteLine("Сума другої та передостанньої цифр п’ятизначного числа: " + sum);
        }
    }
}
