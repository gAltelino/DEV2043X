using System;

namespace TutorialLab2
{
    class Program
    {

        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {
            int x = (int)Days.Sun;
            int y = (int)Days.Fri;

            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);
            Console.WriteLine(Days.Thu);
        }
    }
}
