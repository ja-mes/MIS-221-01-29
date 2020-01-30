using System;

namespace Class_01_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Console.WriteLine("Before Method: \tX = " + x + "\tY = " + y);
            Swap(ref x, ref y);
            Console.WriteLine("After Method:\tX = " + x + "\tY = " + y);
            Console.ReadKey();

        }

        static void Swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
            Console.WriteLine("Inside Method:\tX = " + x + "\tY = " + y);
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
