using System;

namespace ForeachUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            var testData = new string[] { "Testing", "is", "awesome!" };
            foreach (string array in testData)
                Console.Write($" {array}");
            Console.ReadKey();
        }
    }
}
