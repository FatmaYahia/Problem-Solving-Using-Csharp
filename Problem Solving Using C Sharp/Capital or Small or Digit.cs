using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Capital_or_Small_or_Digit
    {
        static void Main(string[] args)
        {
            char x = char.Parse(Console.ReadLine());
            if (x >= 48 && x <= 57)
            {
                Console.WriteLine("IS DIGIT");
            }
            else if (x >= 97 && x <= 122)
            {
                Console.WriteLine("ALPHA");
                Console.WriteLine("IS SMALL");
            }
            else if (x >= 65 && x <= 90)
            {
                Console.WriteLine("ALPHA");
                Console.WriteLine("IS CAPITAL");
            }
        }
    }
}
