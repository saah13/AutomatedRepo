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
        public static void Split(string data)
        {
            string[] arr = data.Split(new char[] { ' ' });
            Regex initials = new Regex(@"(\b[a-zA-Z])[a-zA-Z]* ?");
            var first = arr.First();
            var second = initials.Replace(arr.ElementAt(1),"$1");
            var third = initials.Replace(arr.ElementAt(2), "$1");
            Console.WriteLine($"{first} {second}.{third}.");
        }
    }
}
