using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Sum_Digits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long a = int.Parse(Console.ReadLine());
            long newA = a, mod = 0, sum = 0;
            int[] aa = new int[5];
            int x = aa.Sum();
            while (newA > 0)
            {
                mod = newA % 10;
                sum += mod;
                newA /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
