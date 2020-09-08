using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Console.WriteLine("Hello, !");

            Console.WriteLine("What Year are you born in?");



            string UserInput;
            UserInput = Console.ReadLine();
            int Year;
            Year = Int32.Parse(UserInput);
            int Age = 2020 - Year;
            {
                if (Age < 18) 

                {
                    Console.WriteLine($" You are {Age}, you are too young");

                }else if (Age > 18)
                {
                    Console.WriteLine($" You are {Age}, you are old enough.");
                }
                else
                    Console.WriteLine($" You are {Age}, you are old enough.");

            }



        }
    }

    }
    