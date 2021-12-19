using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Area_of_a_Circle
    {
        static void Main(string[] args)
        {
            const double pi = 3.141592653;
            double r, area;
            r = double.Parse(Console.ReadLine());
            area = pi * Math.Pow(r, 2);
            Console.WriteLine(area);
        }
    }
}
