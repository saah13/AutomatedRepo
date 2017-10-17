using System;

namespace StringArrayThird
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5; //Number of words in the array
            int k = i - 1;
            string[] array = new string[i];
            while (i > 0)
            {
                if (i != 1)
                {
                    Console.WriteLine($"Enter {i} more words");
                }
                else
                {
                    Console.WriteLine($"Enter {i} more word");
                }
                array[i - 1] = Console.ReadLine();
                i--;

            }

            for (int x = 0; x <= k; x++)
            {
                Console.Write($" {array[x]}");
            }

            Console.ReadKey();
        }
    }
}
