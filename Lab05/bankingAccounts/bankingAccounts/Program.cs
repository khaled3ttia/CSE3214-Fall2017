using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new CheckingAccount("Ahmed", 110, 5000);
            Console.WriteLine(a1.ToString());
            a1.deposit(20);
            a1.withdraw(10);
            a1.deposit(5);
            a1.withdraw(10);
            Console.WriteLine("Current Balance is {0}", a1.getBalanace());

            Console.WriteLine("=====================================");

            SavingAccount a2 = new SavingAccount("Ali", 111, 2000, 0.1);
            Console.WriteLine(a2.ToString());
            a2.deposit(1000);
            a2.withdraw(10);
            a2.addInterest();
        }
    }
}
