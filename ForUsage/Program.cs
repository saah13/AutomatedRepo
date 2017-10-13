using System;

namespace ForUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            var testData = new int[] { 10, 2, 5 };
            int sum = 0;
            int div = testData[0];
            for (int i = 0; i < testData.Length; i++)
            {
                sum += testData[i];
            }
            for (int i = 1; i < testData.Length; i++)
            {
                div /= testData[i];
            }
            Console.WriteLine($"{ sum} {div}");
            Console.ReadKey();
        }
    }
}
