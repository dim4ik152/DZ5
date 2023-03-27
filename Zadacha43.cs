using System;

namespace IntersectionOfTwoLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение k1:");
            double k1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b1:");
            double b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение k2:");
            double k2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b2:");
            double b2 = double.Parse(Console.ReadLine());

            double[] intersectionPoint = FindIntersectionPoint(k1, b1, k2, b2);

            if (intersectionPoint != null)
            {
                Console.WriteLine($"Точка пересечения прямых: ({intersectionPoint[0]}; {intersectionPoint[1]})");
            }
            else
            {
                Console.WriteLine("Прямые параллельны и не пересекаются.");
            }
        }

        static double[] FindIntersectionPoint(double k1, double b1, double k2, double b2)
        {
            if (k1 == k2)
            {
                // Прямые параллельны
                return null;
            }

            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            return new double[] { x, y };
        }
    }
}