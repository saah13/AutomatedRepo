using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntArray 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter first number");
            array[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            array[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            array[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth number");
            array[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fifth number");
            array[4] = Convert.ToInt32(Console.ReadLine());
            Factorial factorial = new Factorial();
            for (int i = 0; i < array.Length; i++)
            Console.WriteLine($"Factorial of number { array[i]} equals { factorial.Calculate(i)} {factorial.Calculate.res} ");
            Console.ReadKey(); 
        }

    }
}
