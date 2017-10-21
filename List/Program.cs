using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            char userInputKey;
            List<string> list = new List<string>();
            do
            {
                Console.WriteLine("Enter some text");
                list.Add(Console.ReadLine());
                Console.WriteLine("Continue [Y/N]");
                do
                {
                    userInputKey = char.ToUpperInvariant(Console.ReadKey(true).KeyChar);

                } while (userInputKey != 'Y' && userInputKey != 'N');

            } while (userInputKey != 'N');
            Console.Clear();
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Wanna delete something [Y/N]");
            do
            {
                userInputKey = char.ToUpperInvariant(Console.ReadKey(true).KeyChar);
            } while (userInputKey != 'Y' && userInputKey != 'N');
            if (userInputKey == 'Y')
            {
                Console.WriteLine("Enter what you want to be deleted");
                list.Remove(Console.ReadLine());
                foreach (string i in list)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Congratulations");
            Console.ReadKey();
        }
    }
}
