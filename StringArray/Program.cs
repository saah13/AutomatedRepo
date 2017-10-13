using System;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[5];
            Console.WriteLine("Enter first word");
            array[0] = Console.ReadLine();
            Console.WriteLine("Enter second word");
            array[1] = Console.ReadLine();
            Console.WriteLine("Enter third word");
            array[2] = Console.ReadLine();
            Console.WriteLine("Enter fourth word");
            array[3] = Console.ReadLine();
            Console.WriteLine("Enter fifth word");
            array[4] = Console.ReadLine();
            for (int i = 4; i >= 0; i--)
            Console.WriteLine(array[i]);
            Console.ReadKey();
        }
    }
}
