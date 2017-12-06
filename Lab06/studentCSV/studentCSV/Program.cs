using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace studentCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter("student.csv", true);
                Console.WriteLine("File opened/created successfully, ready to input data");
                Console.WriteLine("Enter student name, type exit if you want to stop");
                string name = Console.ReadLine();

                while (name != "exit")
                {
                    Console.WriteLine("Enter student email:");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter student phone number");
                    string phone = Console.ReadLine();
                    sw.WriteLine(name + "," + email + "," + phone);
                    Console.WriteLine("===========");
                    Console.WriteLine("Enter student name, type exit if you want to stop");
                    name = Console.ReadLine();
                }
                sw.Close();
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("File already in use, please close if open in another program");
                return;
            }
            
        }
    }
}
