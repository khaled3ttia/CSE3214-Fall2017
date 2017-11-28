using System;

namespace ConsoleApp1
{
public class Employee
    {
        protected string FirstName;
        protected string LastName;

        public Employee()
        {
            Console.WriteLine("Parent ");
        }
        public void PrintFull()
        {
            Console.WriteLine("{0} {1}", this.FirstName, this.LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        float yearlySalary;
        public FullTimeEmployee()
        {
            Console.WriteLine("Child Class");
        }
    }

    public class PartTimeEmployee : Employee
    {
        float HourlyRate;

    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            
        }
    }
}
