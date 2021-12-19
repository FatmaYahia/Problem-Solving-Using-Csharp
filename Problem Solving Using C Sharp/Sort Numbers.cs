using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Sort_Numbers
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);
            if (a <= b && a <= c)
            {
                Console.WriteLine(a);
                if (b <= c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
            }
            else if (b <= c && b <= a)
            {
                Console.WriteLine(b);
                if (a <= c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }
            else if (c <= a && c <= b)
            {
                Console.WriteLine(c);
                if (b <= a)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
            }

            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
