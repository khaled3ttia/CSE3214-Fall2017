using System;

namespace signNoValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNegativeNumbers = 0;
            bool zeroProduct = false;
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                countNegativeNumbers++;
            } else if (a == 0)
            {
                zeroProduct = true;
            }

            Console.WriteLine("Enter seconde number");
            int b = int.Parse(Console.ReadLine());
            if (b < 0)
            {
                countNegativeNumbers++;
            }else if (b ==0)
            {
                zeroProduct = true;
            }
            Console.WriteLine("Enter third number");
            int c = int.Parse(Console.ReadLine());
            if (c < 0)
            {
                countNegativeNumbers++;
            } else if (c == 0)
            {
                zeroProduct = true;
            }
            if (!zeroProduct)
            {
                if (countNegativeNumbers % 2 == 0)
                {
                    Console.WriteLine("The product of the three numbers is positive");
                }
                else
                {
                    Console.WriteLine("The product of three numbers is negative");
                }

            }else
            {
                Console.WriteLine("The product is zero");
            }


        }
    }
}
