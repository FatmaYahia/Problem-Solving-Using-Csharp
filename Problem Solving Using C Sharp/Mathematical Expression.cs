using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Mathematical_Expression
    {
        static void Main(string[] args)
        {
            int a, b, c;
            char s, q;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            a = int.Parse(numbers[0]);
            b = int.Parse(numbers[2]);
            c = int.Parse(numbers[4]);
            q = char.Parse(numbers[3]);
            s = char.Parse(numbers[1]);

            if (a + b == c && s == '+')
            {
                Console.WriteLine("Yes");
            }
            else if (a - b == c && s == '-')
            {
                Console.WriteLine("Yes");
            }
            else if (a * b == c && s == '*')
            {
                Console.WriteLine("Yes");
            }
            else
            {
                if (s == '*')
                {
                    Console.WriteLine(a * b);
                }
                else if (s == '+')
                {
                    Console.WriteLine(a + b);
                }
                else if (s == '-')
                {
                    Console.WriteLine(a - b);
                }
            }
        }
    }
}
