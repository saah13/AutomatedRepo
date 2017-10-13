using System;

namespace CalculatorThatImplementsSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write first number,then press 'Enter' ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write second number,then press 'Enter' ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Sum is {Sum(x, y)}");
            Console.ReadKey();
        }

        public static int Sum(int x, int y)
        {
            int calculate = x + y;
            return calculate;
        }
    }
}
