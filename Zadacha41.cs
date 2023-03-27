using System;

namespace CountPositiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел M:");
            int M = int.Parse(Console.ReadLine());

            int[] numbers = new int[M];
            Console.WriteLine("Введите числа через пробел:");
            string[] inputNumbers = Console.ReadLine().Split(' ');

            for (int i = 0; i < M; i++)
            {
                numbers[i] = int.Parse(inputNumbers[i]);
            }

            int positiveCount = CountPositiveNumbers(numbers);
            Console.WriteLine($"Количество положительных чисел: {positiveCount}");
        }

        static int CountPositiveNumbers(int[] array)
        {
            int count = 0;
            foreach (int number in array)
            {
                if (number > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}