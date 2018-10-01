using System;

namespace MaximumDifference
{
    class Program
    {

        static int Difference(int[] a)
        {

            int smallest = a[0];
            int biggest = a[0];

            for (int i = 1; i < a.Length - 1; i++)
            {
                if (smallest > a[i])
                {
                    smallest = a[i];
                }
                if (biggest < a[i])
                {
                    biggest = a[i];
                }
            }

            return biggest - smallest;

        }

        static void Main(string[] args)
        {

            int[] array1 = { 3, 2, 9, 5 };
            int[] array2 = { 1, 1, 1, 1 };

            Console.WriteLine(Difference(array1));
            Console.WriteLine(Difference(array2));

        }
    }
}
