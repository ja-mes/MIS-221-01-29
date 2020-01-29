using System;

namespace Class_01_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            Console.WriteLine("Number before method: " + number);
            UpdateNumber(number);
            Console.WriteLine("Number after method: " + number);
        }

        static void UpdateNumber(int num)
        {
            num = num + 5;
            Console.WriteLine("Number inside method: " + num);
        }

    }

}
