using System;

namespace IntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5; //Number of numbers in the array
            int k = i - 1;
            int[] array = new int[i];
            while (i > 0)
            {
                if (i != 1)
                {
                    Console.WriteLine($"Enter {i} more numbers range 1-20");
                }
                else
                {
                    Console.WriteLine($"Enter {i} more number range 1-20");
                }
                int x = int.Parse(Console.ReadLine());
                if (x >= 1 & x <= 20)
                {
                    array[i - 1] = x;
                    i--;
                }
                else
                {
                    Console.WriteLine("You entered invalid number \n");
                }

            }
            for (int y = k; y >= 0; y--)
            {
                Console.WriteLine($"Factorial of number {array[y]} equals { Factorial.Calculate(array[y])}");
            }

            Console.ReadKey();

        }

    }
}
