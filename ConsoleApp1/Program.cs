using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Compaer("saa","saa");
        }
        public static void Compaer(string a, string b)
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
