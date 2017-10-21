using System;

namespace IntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5; //Number of elements in array
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
                string input = Console.ReadLine();
                bool result = ValidateNumber(input);
                if (result && int.Parse(input) >= 1 && int.Parse(input) <= 20 )
                {
                    array[--i] = int.Parse(input);

                }
                else
                {
                    Console.WriteLine("You entered invalid number \n");
                }

            }
            for (int y = array.Length-1; y >= 0; y--)
            {
                Console.WriteLine($"Factorial of number {array[y]} equals { Factorial.Calculate(array[y])}");
            }

            Console.ReadKey();

        }
        public static bool ValidateNumber(string value)
        {
            try
            {
                int test = int.Parse(value);
                return true;
            }
            catch(FormatException)
            {
                return false;
            }
        }

    }
}
