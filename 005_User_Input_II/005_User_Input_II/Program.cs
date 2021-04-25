using System;

namespace _005_User_Input_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old.", age);
        }
    }
}
