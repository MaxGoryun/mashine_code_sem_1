using System;
using System.Net.NetworkInformation;
using System.Security.AccessControl;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");

            string A = Console.ReadLine();

            int a = Convert.ToInt32(A);

            if (a % 2 == 0)
            {
                Console.WriteLine("Число" + a + "четное" );
            }
            if ( a % 2 != 0 )
            {
                Console.WriteLine("Число " + a + " НЕчетное" );
            }


        }
    }

}
