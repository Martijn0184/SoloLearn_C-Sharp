using System;

namespace _033_nested_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark = 100;
            
            if (mark >= 50)
            {
                Console.WriteLine("You passed.");
                if (mark == 100)
                {
                    Console.WriteLine("Perfect!");
                }
            }
            else
            {
                Console.WriteLine("You failed.");
            }
        }
    }
}
