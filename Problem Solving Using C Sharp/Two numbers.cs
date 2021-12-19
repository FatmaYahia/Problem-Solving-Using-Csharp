using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Two_numbers
    {
        static void Main(string[] args)
        {
            double a, b;
            double x;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            a = double.Parse(numbers[0]);
            b = double.Parse(numbers[1]);
            x = a / b;
            Console.WriteLine($"floor {a} / {b} = {Math.Floor(x)}");
            Console.WriteLine($"ceil {a} / {b} = {Math.Ceiling(x)}");
            Console.WriteLine($"round {a} / {b} = {Math.Round(x)}");


        }
    }
}
