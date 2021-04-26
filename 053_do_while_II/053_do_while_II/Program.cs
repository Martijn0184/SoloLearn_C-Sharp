using System;

namespace _053_do_while_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 10);
        }
    }
}
