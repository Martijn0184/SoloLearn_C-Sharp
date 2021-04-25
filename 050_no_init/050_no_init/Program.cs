using System;

namespace _050_no_init
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            for (; x > 0; x -= 3)
            {
                Console.WriteLine(x);
            }
        }
    }
}
