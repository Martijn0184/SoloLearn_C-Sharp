using System;

namespace _038_the_default_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 16;
            switch (x)
            {
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 20:
                    Console.WriteLine("Twenty");
                    break;
                default:
                    Console.WriteLine("No Match");
                    break;
            }
        }
    }
}
