using System;
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

            int a = Convert.ToInt32(A);

            int b = Convert.ToInt32(B);

            if (a > b)
            {
                Console.WriteLine("Большее чилсло: " + a);
            }
            if (b > a)
            {
                Console.WriteLine("Большее чилсло: " + b);
            }

        }
    }

}
