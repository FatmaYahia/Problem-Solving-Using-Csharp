using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Coordinates_of_a_Point
    {
        static void Main(string[] args)
        {
            double X, Y;
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            X = double.Parse(numbers[0]);
            Y = double.Parse(numbers[1]);

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (X != 0 && Y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (X == 0 && Y != 0)
            {
                Console.WriteLine("Eixo Y");

            }
        }
    }
}
