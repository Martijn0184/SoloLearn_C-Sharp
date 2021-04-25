using System;

namespace _024_postfix_decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = x--;
            Console.WriteLine(x+" "+y);
        }
    }
}
