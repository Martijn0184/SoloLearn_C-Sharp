using System;

namespace _054_do_while_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            do
            {
                a += 3;
            } while (a < 4);
            Console.WriteLine(a);
        }
    }
}
