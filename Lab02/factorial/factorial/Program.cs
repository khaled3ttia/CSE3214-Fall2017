using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            

            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());
            if (k < n && k > 1)
            {
                for (int i =n; i>k; i--)
                {
                    fact *= i;
                }
                Console.WriteLine("The result is {0}", fact); 
            }else
            {
                Console.WriteLine("Please note that 1<K<N");
            }
        }
    }
}
