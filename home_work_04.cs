using System;
using System.Net.NetworkInformation;
using System.Security.AccessControl;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1: ");

            string A = Console.ReadLine();

            Console.WriteLine("Введите число 2: ");

            String B = Console.ReadLine();

            Console.WriteLine("Введите число 3: ");

            String C = Console.ReadLine();

            int a = Convert.ToInt32(A);

            int b = Convert.ToInt32(B);

            int c = Convert.ToInt32(C);

            if (a > b & a > c)
            {
                Console.WriteLine("Большее чилсло: " + a);
            }
            if (b > a & b > c)
            {
                Console.WriteLine("Большее чилсло: " + b);
            }
            if ( c > a & c > b)

                Console.WriteLine("Большее чилсло: " + c);

        }
    }

}
