using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace pearsonCoefficient
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines("data.txt");
            int n = lines.Length;
            double[] x = new double[n];
            double[] y = new double[n];
            double[] xy = new double[n];
            double[] xSquare = new double[n];
            double[] ySquare = new double[n];
            double sumX=0, sumY=0, sumxSquare=0, sumySquare=0, sumxy=0;
            for (int i=0; i< n; i++)
            {
                string[] line = lines[i].Split(':');
                x[i] = double.Parse(line[0]);
                sumX += x[i];
                y[i] = double.Parse(line[1]);
                sumY += y[i];

                xy[i] = x[i] * y[i];
                sumxy += xy[i];

                xSquare[i] = Math.Pow(x[i], 2);
                sumxSquare += xSquare[i];

                ySquare[i] = Math.Pow(y[i], 2);
                sumySquare += ySquare[i];
            }
            double r = ((n * sumxy) - (sumX * sumY)) / Math.Sqrt(((n * sumxSquare) - Math.Pow(sumX, 2)) * ((n * sumySquare) - Math.Pow(sumY, 2)));
            Console.WriteLine("r is {0}", r);
        }
    }
}
