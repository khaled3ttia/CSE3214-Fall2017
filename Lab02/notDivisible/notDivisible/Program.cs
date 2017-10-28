using System;

namespace notDivisible
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if ((i % 7 != 0) && (i % 3 != 0))
                {
                    Console.Write(" " + i);
                }
            }
        }
    }
}
