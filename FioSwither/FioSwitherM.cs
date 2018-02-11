using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FioSwither
{
    public static class FioSwitherM
    {
        public static void SplitFirst(string data)
        {
            string[] arr = data.Split(new char[] { ' ' });
            Regex initials = new Regex(@"(\b[a-zA-Z])[a-zA-Z]* ?");
            var first = arr.First();
            var second = initials.Replace(arr.ElementAt(1), "$1");
            var third = initials.Replace(arr.ElementAt(2), "$1");
            Console.WriteLine($"{first} {second}.{third}.");
        }
        public static void SplitSecond(string input)
        {
            {
                var data = input.Split(' ').ToList();
                var result = data[0];
                if (data.Count == 3)
                {
                    data.Remove(result);
                    result += " ";
                    data.ForEach(d => result += $"{d[0]}.");
                }
                else
                {
                    throw new NotImplementedException("Convertation works fine only for DIO consisting of 3 words separated by spaces");
                }
                Console.WriteLine(result);
            }
        }
    }
}


