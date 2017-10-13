using System;

namespace ComparisonOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();
            int randomNumber = RNG.Next(1, 10);
            Console.WriteLine("Enter the number");
            int y = Convert.ToInt32(Console.ReadLine());
            if (randomNumber == y)
            {
                Console.WriteLine("Congratulations");
                Console.ReadKey();
            }
            else if(randomNumber >= y)
            {
                Console.WriteLine($"Your number is smaller,number was {randomNumber} ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Your number is bigger,number was {randomNumber}");
                Console.ReadKey();
            }
           
            
        }
    }
}
