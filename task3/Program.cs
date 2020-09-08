using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Int1;
            string Int2;
            int Num;
            int Num2;
            Console.WriteLine("Hello, choose a number.");
            Int1 = Console.ReadLine();
            Num = Int32.Parse(Int1);
            Console.WriteLine("Pick one more number");
            Int2 = Console.ReadLine();
            Num2 = Int32.Parse(Int2);
            if (Int1 == Int2)
            {
                Console.WriteLine("These numbers are equal");

            }
            else if (Num<Num2)
            {
                Console.WriteLine($"The first number u picked was bigger.");
            }
            else
            {
Console.WriteLine("The second number u picked was bigger.");
            }
            


        }
    }
}
