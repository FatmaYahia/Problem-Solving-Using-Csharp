using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Max_and_Min
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            a = int.Parse(numbers[0]);
            b = int.Parse(numbers[1]);
            c = int.Parse(numbers[2]);
            if (a <= b && a <= c)
            {
                Console.Write($"{a} ");
                if (b <= c)
                {
                    Console.WriteLine($"{c}");
                }
                else
                {
                    Console.WriteLine($"{b}");

                }
            }
            else if (b <= a && b <= c)
            {
                Console.Write($"{b} ");
                if (a <= c)
                {
                    Console.WriteLine($"{c}");
                }
                else
                {
                    Console.WriteLine($"{a}");
                }
            }
            else if (c <= a && c <= b)
            {
                Console.Write($"{c} ");
                if (b <= a)
                {
                    Console.WriteLine($"{a}");
                }
                else
                {
                    Console.WriteLine($"{b}");
                }
            }
        }
    }
}
