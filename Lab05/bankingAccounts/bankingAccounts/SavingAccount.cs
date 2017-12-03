using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAccounts
{
    class SavingAccount : Account
    {
        protected double interestRate;

        public SavingAccount(string n, int id, double b, double iR) : base(n, id, b)
        {
            this.interestRate = iR;
        }

        public SavingAccount(string n, int id, double b): base(n, id, b)
        {
            this.interestRate = 0.12;
        }

        public SavingAccount(string n, int id) : base(n, id)
        {
            this.interestRate = 0.12;
        }

        public double addInterest()
        {
            double interest = this.balance * this.interestRate;
            if (deposit(interest))
            {
                Console.WriteLine("Interest amount {0} added to balance, new balance is : {1}", interest, getBalanace());
            }
            else
            {
                Console.WriteLine("No interest added");
            }
            return getBalanace();
        }
    }
}
