using System;

namespace KthSmallest
{
    class Program
    {
        static int Ksmallest(int[] a, int k)
        {

            if (k > a.Length || a.Length <= 0)
            {
                return -1;
            }
            else
            {

                int i = 0;
                int temp;
                while (a[i] > a[i + 1] && i < a.Length - 1)
                {
                    temp = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = temp;
                }

                return a[k -1];
            }
        }

        static void Main(string[] args)
        {
            int[] array1 = { 2, 1, 4 };
            int[] array2 = { 7, 2, 1, 6, 1 };

            Console.WriteLine(Ksmallest(array1, 3));
            Console.WriteLine(Ksmallest(array2, 3));

        }
    }
}
