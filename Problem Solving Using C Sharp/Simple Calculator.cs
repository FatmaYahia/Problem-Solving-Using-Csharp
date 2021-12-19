using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Simple_Calculator
    {
        static void Main(string[] args)
        {
            long x, y, summation, subtraction, multiplication;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            x = int.Parse(numbers[0]);
            y = int.Parse(numbers[1]);
            summation = x + y;
            subtraction = x - y;
            multiplication = x * y;
            Console.WriteLine($"{x} + {y} = {summation}");
            Console.WriteLine($"{x} * {y} = {multiplication}");
            Console.WriteLine($"{x} - {y} = {subtraction}");
        }



    }
}
