using System;

namespace UsageOfConditionalSecond
{
    class Program
    {
        // Programm is checking the number user typed(is it 42 or not)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the answer to the Meaning of Life, the Universe, and Everything");
            int x = Convert.ToInt32(Console.ReadLine());
            string res = x == 42 ? "You goddam right" : "Nope";
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
