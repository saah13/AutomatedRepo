using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTesting
{
    class Program
    {
        public static void Main(string[] args)
        {
            Account[] accounts =
            {
                new Account("Egor","Grivovec",22,"0001 2313 2323 1818",100000.00),
                new Account("Valeriy","Grivovec",55,"0001 2124 5454 7878",100.05),
                new Account("Valentina","Simo",11,"0002 5555 5555 5555",70.00),
                new Account("Ted","Mosby",72,"0002 7541 5454 7878",-9999999.95),
                new Account("Egor","Mosby",22,"0001 2121 8754 6112",0.00),
                new Account("Vladimir","Kirichenko",27,"0002 7777 8888 9999",9000000.00),
                new Account("Olya","Limova",60,"0001 1744 6321 0514",-70000.17),
                new Account("Ebaka","Ebaka",72,"0002 2121 5455 7878",100000.00),
                new Account("Ted","Poplava",10,"0002 4554 5454 7878",0.00),
                new Account("Kilo","Tonna",100,"0001 5454 7878 5555",100.00)
            };
            var firstAccount = accounts.First();
            var lena = accounts.Where(n=> n.FirstName =="Lena").FirstOrDefault();
            var distinctValues = accounts.Select(n => n.FirstName).Distinct().Reverse();
            int count = accounts.Count();
            int countBalanceMoreThanZero = accounts.Count(n => n.Balance > 0);
            Console.WriteLine($"{firstAccount.FirstName} {firstAccount.LastName}");
            Console.WriteLine(lena == null ? "Person zero not found" : lena.FirstName);
            Console.WriteLine(count);
            Console.WriteLine(countBalanceMoreThanZero);
            foreach (var i in distinctValues)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
    public class Account
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string CreditCardNumber { get; private set; }
        public double Balance { get; private set; }

        public Account(string firstName, string lastName, int age, string creditCardNumber, double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            CreditCardNumber = creditCardNumber;
            Balance = balance;
        }
    }
}