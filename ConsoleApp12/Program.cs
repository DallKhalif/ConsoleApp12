using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Compaer();

        }
        static void Compaer()
        {
            try
            {
                Console.WriteLine("Enter the value a : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine(true + "\n" + "a is bigger than b");
                }
                else
                {
                    Console.WriteLine(false + "\n" + "a is less or equal to b");
                }
            }
            catch (Exception)
            {

                Console.WriteLine(false + "\n" + "Just enter the intejer value ");
            }
        }
    }
}
