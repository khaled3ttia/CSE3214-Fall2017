using System;

namespace biggestofthree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("The largest of three number is : {0}", myMax(myMax(a, b), c));
        }

        static int myMax(int x, int y)
        {
            return x > y ? x : y;
        }
    }
}
