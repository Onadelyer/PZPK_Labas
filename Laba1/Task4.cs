using Extensions;
using System.Drawing;

namespace PZPK_Labas.Laba1
{
    public static class Task4
    {
        public static void Run()
        {
            Console.WriteLine("Завдання 4. Написати програму, яка визначає, чи попадає точка із заданими координатами (х,у) в заштриховану область на рисунку.");


            var point = InputPoint();

            int radius; ConsoleInput.SafeIntInput("Радіус", out radius);



            if (CalculatePointInCircle(point, radius))
                Console.WriteLine("Точка належить заштрихованій області");
            else
                Console.WriteLine("Точка не належить заштрихованій області");


            Console.ReadKey();
            Console.WriteLine();
        }

        public static bool CalculatePointInCircle(Point point, int radius)
        {
            if (point.X > 0 && point.Y > 0)
            {
                return IsPointInCircle(point, radius);
            }
            else if (point.X < 0 && point.Y < 0)
            {
                return IsPointInCircle(point, radius);
            }
            else if (point.X < 0 && point.Y > 0)
            {
                Point point1 = new(0, 0);
                Point point2 = new(0, radius);
                Point point3 = new(-radius, 0);

                return IsPointInTriangle(point, point1, point2, point3);
            }
            else
                return false;
        }

        private static bool IsPointInTriangle(Point point, Point p1, Point p2, Point p3)
        {
            float sign(Point p1, Point p2, Point p3)
            {
                return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
            }

            float d1, d2, d3;
            bool has_neg, has_pos;

            d1 = sign(point, p1, p2);
            d2 = sign(point, p2, p3);
            d3 = sign(point, p3, p1);

            has_neg = d1 < 0 || d2 < 0 || d3 < 0;
            has_pos = d1 > 0 || d2 > 0 || d3 > 0;

            return !(has_neg && has_pos);
        }

        private static bool IsPointInCircle(Point point, int radius)
        {
            return point.X * point.X + point.Y * point.Y <= radius * radius;
        }

        private static Point InputPoint()
        {
            int x;
            int y;

            ConsoleInput.SafeIntInput("X", out x);
            ConsoleInput.SafeIntInput("Y", out y);

            return new Point(x, y);
        }
    }
}
