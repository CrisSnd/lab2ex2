using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va afisa factorialul unui numar n, n fiind citit de la tastatura */

            int n;

            Console.WriteLine("Introduceti n!:");
            n = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("\n" + factorial);
        }
    }
}
