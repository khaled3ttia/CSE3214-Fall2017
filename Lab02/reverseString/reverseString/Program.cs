using System;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string word = Console.ReadLine();

            Console.WriteLine("Reversed string is: ");
            int lastIndex = word.Length - 1;
            for (int i=lastIndex; i>=0; i--)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();
        }
    }
}
