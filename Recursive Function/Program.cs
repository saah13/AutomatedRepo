using System;

namespace Recursive_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number from 1 to 20: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine($"{i}! = {Factorial(i)}");
            Console.ReadKey();

        }
        static int Factorial(int i)
        {
            int result;

            if (i == 1)
            {
                return 1;
            }

            else return result = Factorial(i - 1) * i;
        }

    }
}
