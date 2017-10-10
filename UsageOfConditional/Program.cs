using System;

namespace UsageOfConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int x = Convert.ToInt32(Console.ReadLine());
            int res = x != 0 ? 10 / x : x;
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
