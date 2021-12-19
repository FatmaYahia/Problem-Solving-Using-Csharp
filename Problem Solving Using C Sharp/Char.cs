using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Char
    {
        static void Main(string[] args)
        {
            char x = char.Parse(Console.ReadLine());
            if (x < 97)
            {
                Console.WriteLine(char.ToLower(x));
            }
            else
            {
                Console.WriteLine(char.ToUpper(x));
            }
        }
    }
}
