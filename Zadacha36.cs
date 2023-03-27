using System;

namespace SumOfElementsAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {3, 7, 23, 12};
            int[] array2 = {-4, -6, 89, 6};

            int sum1 = SumOfElementsAtOddPositions(array1);
            int sum2 = SumOfElementsAtOddPositions(array2);

            Console.WriteLine($"Сумма элементов на нечетных позициях (array1): {sum1}");
            Console.WriteLine($"Сумма элементов на нечетных позициях (array2): {sum2}");
        }

        static int SumOfElementsAtOddPositions(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}