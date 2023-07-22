using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");

            string A = Console.ReadLine();

            int a = Convert.ToInt32(A);

            int x = 2;

            int count = 1;

            while (x <= a)
            {
                Console.Write(" " + x );
                x += 2;
                count++;
                
            }

        }
    }

}
