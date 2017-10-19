using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntBasedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Word> dictionary = new List<Word>();
            for (int i = 10; i > 0; i--)
            {
                string guid = Guid.NewGuid().ToString();
                Console.WriteLine($"Enter {i} more");
                dictionary.Add(new Word() { Content = Console.ReadLine(), Id = guid });
            }
            foreach (Word i in dictionary)
            {
                Console.WriteLine($"{i.Id}   {i.Content}");
            }
            Console.ReadKey();
        }
        public class Word
        {
            public string Id { get; set; }
            public string Content { get; set; }
        }
    }

}
