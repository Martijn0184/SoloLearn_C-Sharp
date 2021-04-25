using System;

namespace _031_the_else_clause
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark = 85;

            if (mark < 50 )
            {
                Console.WriteLine("you failed.");
            }
            else
            {
                Console.WriteLine("You passed.");
            }
        }
    }
}
