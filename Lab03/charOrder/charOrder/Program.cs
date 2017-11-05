using System;

namespace charOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            printOrder(word);
        }

        static void printOrder(string s)
        {
            string lowerWord = s.ToLower();
            foreach (char ch in lowerWord)
            {
                Console.Write((int)(ch - 'a'));
            }
        }
    }
}
