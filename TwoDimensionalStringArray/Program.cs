using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            char key = 'y';
            List<string[]> rows = new List<string[]>();
            while (key == 'y'|| key=='Y')
            {
                Console.WriteLine($"Enter string");
                rows.Add(Console.ReadLine().Split(' '));
                Console.WriteLine("Wanna Continue [y]");
                key = Console.ReadKey(true).KeyChar;
                Console.Clear();
                y++;

            }
            foreach (var element in rows)
            {
                int i = element.Count();
                if (i > x)
                {
                    x = i;
                }
            }
            string[,] array = new string[y, x];
            for (int i = 0; i < y; i++)
            {

                for (int j = 0; j < rows[i].Length; j++)
                {
                    array[i, j] = rows[i][j];
                }
            }
            for (int i = y-1; i >= 0; i--)
            {
                for(int j = x-1; j >=0; j--)
                {
                    Console.Write($"{array[i,j]} ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
