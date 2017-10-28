using System;

namespace individualDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four-digit number");
            int num = int.Parse(Console.ReadLine());
            int a = num % 10;
            int b = (num / 10) % 10;
            int c = (num / 100) % 10;
            int d = (num / 1000) % 10;
            Console.WriteLine("Sum of digits is : {0}", a + b + c + d);
        }
    }
}
