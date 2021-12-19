using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Comparison
    {
        static void Main(string[] args)
        {
            int a, b;
            char s;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            a = int.Parse(numbers[0]);
            b = int.Parse(numbers[2]);
            s = char.Parse(numbers[1]);
            if (a < b && s == '<')
            {
                Console.WriteLine("Right");
            }
            else if (a > b && s == '>')
            {
                Console.WriteLine("Right");
            }
            else if (a == b && s == '=')
            {
                Console.WriteLine("Right");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
    }
}
