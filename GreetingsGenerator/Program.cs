using System;

namespace GreetingsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please introduce yourself time traveler!");
            string text = Console.ReadLine();
            DateTime date = DateTime.Today;
            Console.WriteLine($"Greetings {text}! Today is {date.ToString("d")}");
            Console.ReadKey();
        }
    }
}
