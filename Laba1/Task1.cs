using Extensions;

namespace PZPK_Labas.Laba1
{
    public static class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 1. Обчислити площу та периметр рівнобічної трапеції, для якої задано довжини основ та висоту.");

            double trapezoidBase1;
            double trapezoidBase2;
            double height;


            InputTrapeze(out trapezoidBase1, out trapezoidBase2, out height);


            double area = (trapezoidBase1 + trapezoidBase2) * height / 2;
            Console.WriteLine("Площа рівнобічної трапеції: " + area);

            double perimeter = trapezoidBase1 + trapezoidBase2 + trapezoidBase1 + trapezoidBase2;
            Console.WriteLine("Периметр рівнобічної трапеції: " + perimeter);


            Console.ReadKey();
            Console.WriteLine();
        }

        private static void InputTrapeze(out double trapezoidBase1, out double trapezoidBase2, out double height)
        {
            ConsoleInput.SafeIntInput("Введіть довжину першої основи", out trapezoidBase1);
            ConsoleInput.SafeIntInput("Введіть довжину другої основи", out trapezoidBase2);
            ConsoleInput.SafeIntInput("Введіть висоту", out height);
        }
    }
}
