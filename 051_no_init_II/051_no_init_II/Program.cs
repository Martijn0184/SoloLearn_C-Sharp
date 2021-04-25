using System;

namespace _051_no_init_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            for (; x > 0;)
            { 
                Console.WriteLine(x);
                x -= 3;
            }
        }
    }
}
