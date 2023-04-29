using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            CompaerValue(Console.ReadLine(), Console.ReadLine());
        }
        public static void CompaerValue(string a, string b)
        {
            if (string.Compare(a,b) >= 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
