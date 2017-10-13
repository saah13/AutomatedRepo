using System;
using System.Threading;

namespace WhileUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 11;
            while (i > 0)
            {
                Thread.Sleep(1000);
                i--;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
