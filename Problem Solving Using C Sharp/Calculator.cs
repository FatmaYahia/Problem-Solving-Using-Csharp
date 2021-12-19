using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int a, b;
            char s = ' ';
            char[] seprator = { '/', '+', '-', '*' };
            string line = Console.ReadLine();
            string[] numbers = line.Split(seprator);
            a = int.Parse(numbers[0]);
            b = int.Parse(numbers[1]);
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '/' || line[i] == '*' || line[i] == '+' || line[i] == '-')
                {
                    s = line[i];
                    break;
                }
            }

            if (s == '+')
            {
                Console.WriteLine($"{a + b}");
            }
            else if (s == '-')
            {
                Console.WriteLine($"{a - b}");
            }
            else if (s == '*')
            {
                Console.WriteLine($"{a * b}");
            }
            else if (s == '/')
            {
                Console.WriteLine($"{a / b}");
            }
        }
    }

}