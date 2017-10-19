using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            List<string> list = new List<string>();
            do
            {
                Console.WriteLine("Enter some text");
                list.Add(Console.ReadLine());
                do
                {
                    Console.WriteLine("Continue [Y/N]");
                    x = Console.ReadLine();

                } while ((x != "Y" && x != "N"));

            } while (x != "N");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            do
            {
                Console.WriteLine("Wanna delete something [Y/N]");
                x = Console.ReadLine();
            } while ((x != "Y" && x != "N"));
            if (x == "Y")
            {
                Console.WriteLine("Enter what you want to be deleted");
                list.Remove(Console.ReadLine());
                foreach (string i in list)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Congratulations");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Congratulations");
                Console.ReadKey();
            }
        }
    }
}
