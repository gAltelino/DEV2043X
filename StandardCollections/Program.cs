using System;
using System.Collections;

namespace StandardCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrList = new ArrayList();

            myArrList.Add("First Item");
            myArrList.Add("Third Item");
            myArrList.Add("Second Item");

            myArrList.Sort();

            int itemIndex = myArrList.IndexOf("Third Item");

            foreach (object item in myArrList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine($"Third Item is at index {itemIndex}");
        }
    }
}
