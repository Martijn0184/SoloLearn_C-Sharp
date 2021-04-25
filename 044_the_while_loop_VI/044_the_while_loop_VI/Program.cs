using System;

namespace _044_the_while_loop_VI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while(x++<5)
            {
                if (x % 2 == 0)
                    x += 2;
            }
        }
    }
}
