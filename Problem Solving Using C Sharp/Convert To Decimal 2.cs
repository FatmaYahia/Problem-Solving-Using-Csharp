using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Using_C_Sharp
{
    class Convert_To_Decimal_2
    {
        static void Main(string[] args)
        {
            int div, t, n, mod;
            double newNum, dec;
            t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                t--;
                newNum = 0;
                dec = 0;
                n = int.Parse(Console.ReadLine());
                div = n;
                while (div > 0)
                {
                    mod = div % 2;
                    div /= 2;
                    if (mod == 1)
                    {
                        newNum += mod * Math.Pow(2, dec);
                        dec++;
                    }
                }
                Console.WriteLine(newNum);
            }
        }
    }
}
