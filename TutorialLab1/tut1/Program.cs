using System;

namespace tut1
{

    struct Car
    {
        public string Make;
        public string Model;
        public string Color;

        public void Accelerate()
        {
            Console.WriteLine("Vroom");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();

            myCar.Make = "Tesla";
            myCar.Color = "Blue";
            myCar.Model = "Model Y";

            Console.WriteLine($"My car is a {myCar.Make} {myCar.Model} that is {myCar.Color} in color.");

            myCar.Accelerate();

        }
    }
}
