using System;

namespace Problem_Solving_Using_C_Sharp
{
    class Palindrome
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int another = n;
            int rem;
            int reversed = 0;
            while (another > 0)
            {
                rem = another % 10;
                reversed = reversed * 10 + rem;
                another /= 10;
            }
            Console.WriteLine(reversed);
            if (reversed == n)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
