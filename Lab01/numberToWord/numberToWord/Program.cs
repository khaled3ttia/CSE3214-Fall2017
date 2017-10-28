using System;

namespace numberToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number in the range of 0 to 9");
            int number = int.Parse(Console.ReadLine());
            switch (number) {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("You didn't enter a valid number between 0 and 9");
                    break;

                
            }
            Console.ReadKey();
        }
    }
}
