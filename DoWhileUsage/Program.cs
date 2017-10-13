using System;

namespace DoWhileUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();
            int randomNumber = 0;
            do
            {
                randomNumber = RNG.Next(1, 100);
                Console.WriteLine(randomNumber);
            } while (randomNumber != 37);

            Console.ReadKey();


        }
    }
}
