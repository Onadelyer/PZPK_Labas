using Extensions;

namespace PZPK_Labas.Laba1
{
    public static class Task5
    {
        private static void Run()
        {
            Console.WriteLine("Завдання 5. Написати програму, яка по даті народження (день d місяць n) визначає знак зодіаку.");

            int day;
            int month;

            InputData(out day, out month);

            Console.WriteLine("Ваш знак зодіаку: " + DetermineZodiacSign(day, month));


            Console.ReadKey();
            Console.WriteLine();
        }

        private static string DetermineZodiacSign(int day, int month)
        {
            string sign = "";

            switch (month)
            {
                case 1:
                    if (day <= 19)
                        sign = "Козеріг";
                    else
                        sign = "Водолій";
                    break;
                case 2:
                    if (day <= 18)
                        sign = "Водолій";
                    else
                        sign = "Риби";
                    break;
                case 3:
                    if (day <= 12)
                        sign = "Риби";
                    else
                        sign = "Овен";
                    break;
                case 4:
                    if (day <= 19)
                        sign = "Овен";
                    else
                        sign = "Телець";
                    break;
                case 5:
                    if (day <= 14)
                        sign = "Телець";
                    else
                        sign = "Близнюки";
                    break;
                case 6:
                    if (day <= 21)
                        sign = "Близнюки";
                    else
                        sign = "Рак";
                    break;
                case 7:
                    if (day <= 22)
                        sign = "Рак";
                    else
                        sign = "Лев";
                    break;
                case 8:
                    if (day <= 22)
                        sign = "Лев";
                    else
                        sign = "Діва";
                    break;
                case 9:
                    if (day <= 22)
                        sign = "Діва";
                    else
                        sign = "Терези";
                    break;
                case 10:
                    if (day <= 23)
                        sign = "Терези";
                    else
                        sign = "Скорпіон";
                    break;
                case 11:
                    if (day <= 21)
                        sign = "Скорпіон";
                    else
                        sign = "Стрілець";
                    break;
                case 12:
                    if (day <= 21)
                        sign = "Стрілець";
                    else
                        sign = "Козеріг";
                    break;
            }

            return sign;
        }

        private static void InputData(out int day, out int month)
        {
            while (true)
            {
                ConsoleInput.SafeIntInput("Введіть день", out day);

                if (day < 1 || day > 31)
                {
                    Console.WriteLine("День повинен бути від 1 до 31!");
                    continue;
                }
                else
                    break;
            }

            while (true)
            {
                ConsoleInput.SafeIntInput("Введіть номер місяця", out month);

                if (month < 1 | month > 12)
                {
                    Console.WriteLine("Номер місяця повинен бути від 1 до 12!");
                    continue;
                }
                else
                    break;
            }
        }
    }
}
