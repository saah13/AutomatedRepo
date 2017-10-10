using System;

namespace SwitchUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Vanilla ice cream \n2-Coca cola \n3-Salad \n4-Water \n5-Pizza \n:Enter the number of item:");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine("You selected Vanilla ice cream");
                    break;
                case "2":
                    Console.WriteLine("You selected Coca cola");
                    break;
                case "3":
                    Console.WriteLine("You selected Salad");
                    break;
                case "4":
                    Console.WriteLine("You selected Water");
                    break;
                case "5":
                    Console.WriteLine("You selected Pizza");
                    break;
                default:
                    Console.WriteLine("You selected wrong number");
                    break;
            }
            Console.ReadKey();
        }
    }
}
