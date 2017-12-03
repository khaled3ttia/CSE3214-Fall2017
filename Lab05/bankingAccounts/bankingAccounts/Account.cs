using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAccounts
{
    class Account
    {
        protected string name;
        protected int id;
        protected double balance;

        public Account(string n ,int id, double b)
        {
            this.name = n;
            this.id = id;
            this.balance = b;
        }

        public Account(string n, int id)
        {
            this.name = n;
            this.id = id;
            this.balance = 0;
        }

        public virtual bool deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
                Console.WriteLine("Successfully added {0} to balance", amount);
                return true;
            }
            else
            {
                Console.WriteLine("Failure, invalid amount");
                return false;
            }
        }

        public virtual bool withdraw(double amount)
        {
            if (this.balance > amount)
            {
                balance -= amount;
                Console.WriteLine("Successfully withdrawn {0} off balance", amount);
                return true;
            }
            else
            {
                Console.WriteLine("Failure, insufficient funds");
                return false;
            }
        }

        public double getBalanace()
        {
            return this.balance;
        }

        public override string ToString()
        {
            return "Account holder name: " + this.name + " - Account ID: " + this.id + " - Available Balance: " + this.balance;
        }
    }
}
