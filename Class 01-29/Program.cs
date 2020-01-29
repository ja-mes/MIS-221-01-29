using System;

namespace Class_01_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            // use ref to pass by reference

            Console.WriteLine("Number before method: " + number);
            UpdateNumber(ref number); // number of parameters and arguments must be equal
            Console.WriteLine("Number after ref method: " + number);
            UpdateNumber(number);
            Console.WriteLine("Number after val method: " + number);


            Console.ReadKey();
        }

        static void UpdateNumber(ref int num)
        {
            num = num + 5;
            Console.WriteLine("Number inside method: " + num);
        }

        static void UpdateNumber(int num)
        {
            num = num + 5;
            Console.WriteLine("Number inside method: " + num);
        }

    }

}
