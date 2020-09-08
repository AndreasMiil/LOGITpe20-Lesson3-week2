using System;
using System.Net.Cache;

namespace Week2IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Console.WriteLine("Hello, what is your name?");

            int Age;
            string UserInput;
            Console.WriteLine("How old are you?");
            UserInput = Console.ReadLine();
            Age = Int32.Parse(UserInput);
            if (Age < 18)
            {
                Console.WriteLine($" You are {Age}, you are too young");

            }else if(Age > 18)
            {
                Console.WriteLine($" You are {Age}, you are old enough.");
            }else
                Console.WriteLine($" You are {Age}, you are old enough.");

        }

    }
}
