using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAccounts
{
    class CheckingAccount : Account
    {
        protected static int noFreeTransactions = 3;
        protected static double extraFee = 2.5;
        protected int noTransactions;

        public CheckingAccount(string n, int id, double b):base (n, id, b) { }
        public CheckingAccount(string n, int id): base(n, id) { }

        public override bool deposit(double amount)
        {
            bool shouldDeduceExtraFee = noTransactions + 1 > noFreeTransactions;
            double addedBalance = shouldDeduceExtraFee ? amount - extraFee : amount;
            if (addedBalance > 0)
            {
                this.balance += addedBalance;
                noTransactions++;
                Console.WriteLine("Successfully added " + amount + " to balance " + ((shouldDeduceExtraFee) ? "with extra fee of " + extraFee : " "));
                return true;
            }
            else
            {
                Console.WriteLine("Failure, invalid amount or insufficient funds to deduce the extra fee");
                return false;
            }           
        }

        public override bool withdraw(double amount)
        {
            
            bool shouldDeduceExtraFee = noTransactions + 1 > noFreeTransactions;
            double deducedBalance = shouldDeduceExtraFee ? (amount + extraFee) : amount ;
            
            if (this.balance > deducedBalance)
            {
                balance -= deducedBalance;
                noTransactions++;
                Console.WriteLine("Successfully deduced an amount of " + amount + ((shouldDeduceExtraFee) ? " with an extra fee of " + extraFee : " "));
                return true;
            }
            else
            {
                Console.WriteLine("Failure, insufficient funds");
                return false;
            }

        }
    }
}
