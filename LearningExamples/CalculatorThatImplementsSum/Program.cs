using System;

namespace CalculatorThatImplementsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first number,then press 'Enter' ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write second number,then press 'Enter' ");
            int y = Convert.ToInt32(Console.ReadLine());
            int Sum = x + y;
            Console.WriteLine($"Your Sum is {Sum}");
            Console.ReadKey();
        }
    }
}
