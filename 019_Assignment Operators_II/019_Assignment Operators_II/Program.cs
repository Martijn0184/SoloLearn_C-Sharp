using System;

namespace _019_Assignment_Operators_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 21;
            x *= 2; //equivalent to x = x * 2;
            Console.WriteLine(x);

            int y = 84;
            y /= 2; //equivalent to y = y / 2;
            Console.WriteLine(y);

            int z = 542;
            z %= 100; //equivalent to z = z % 100;
            Console.WriteLine(z);
        }
    }
}
