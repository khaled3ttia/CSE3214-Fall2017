using System;

namespace pointInCircle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the radius of the circle");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the X-coodinate of the point to be tested");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y-coordinate of the point to be tested");
            double y = double.Parse(Console.ReadLine());

            double z = x * x + y * y;
            double rSquare = r * r;
            if (z <= rSquare)
            {
                Console.WriteLine("Point within the circle");
            }else
            {
                Console.WriteLine("Point outside the circle");
            }
        }
    }
}
