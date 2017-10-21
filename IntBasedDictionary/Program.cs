using System;
using System.Collections.Generic;

namespace IntBasedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
            for (int i = 10; i > 0; i--)
            {
                var guid = Guid.NewGuid();
                Console.WriteLine($"Enter {i} more");
                dictionary.Add(guid,Console.ReadLine());
            }
            foreach (var i in dictionary)
            {
                Console.WriteLine($"{i.Key}   {i.Value}");
            }
            Console.ReadKey();
        }

    }

}
