using System;

namespace DifferenceBetweenMaxAndMin
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = {3, 7, 22, 2, 78};
            double difference = CalculateDifferenceBetweenMaxAndMin(array);

            Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
        }

        static double CalculateDifferenceBetweenMaxAndMin(double[] array)
        {
            double max = array[0];
            double min = array[0];

            foreach (double number in array)
            {
                if (number > max)
                {
                    max = number;
                }

                if (number < min)
                {
                    min = number;
                }
            }

            return max - min;
        }
    }
}