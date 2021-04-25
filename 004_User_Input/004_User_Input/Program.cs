using System;

namespace _004_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();

            Console.WriteLine("Hello {0}", yourName);
        }
    }
}
