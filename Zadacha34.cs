using System;

namespace EvenNumbersInArray
{
    class Zadacha34
    {
        static void Main(string[] args)
        {
            int[] array = {345, 897, 568, 234};
            int evenCount = CountEvenNumbers(array);

            Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
        }

        static int CountEvenNumbers(int[] array)
        {
            int count = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}