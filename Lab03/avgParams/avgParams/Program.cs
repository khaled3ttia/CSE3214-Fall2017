using System;

namespace avgParams
{
    class Program
    {
        static void Main(string[] args)
        {
            double avg1 = average(5, 8, 12, 10, 50, 123.5, 44);
            double avg2 = average(2, 4.5, 9);
            double avg3 = average(10, 11);
            double avg4 = average();

            Console.WriteLine("avg1 is {0} \navg2 is {1} \navg3 is {2} \navg4 is {3}", avg1, avg2, avg3, avg4);
        }

        static double average(params double[] numbers)
        {
            double sum = 0;
            double avg = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            avg = sum / numbers.Length;
            return avg;
        }
    }
}
