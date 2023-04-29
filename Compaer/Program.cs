using System;

namespace Compaer
{
    class Program
    {
        static void Main(string[] args)
        {
           bool myCompaer =  Compaers(Console.ReadLine(), Console.ReadLine());
           Console.WriteLine(myCompaer);
        }
        static bool Compaers(int a, int b)
        {
            if (a >= b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Compaers(string a, string b)
        {
            if (string.Compare(a, b) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Compaers(double a, double b)
        {
            if (a >= b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Compaers(char a, char b)
        {
            int c = a.CompareTo(b);
            if (c >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
