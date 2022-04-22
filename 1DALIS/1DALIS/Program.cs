using System;

namespace _1DALIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = F(1, 2);

            Console.WriteLine(m);
        }

        public static int F(int n, int m)
        {
            if (n == 0)
            {
                return m;
            }
            if (m == 0 && n > 0)
            {
                return n;
            }
            else
            {
                return Math.Min(Math.Min(1 + F(m - 1, n), 1 + F(m, n - 1)), D(m, n) + F(m - 1, n - 1));
            }
        }

        public static int D(int i, int j)
        {
            int[] x = { 1, 5, 6, 7, 8, 9 };
            int[] y = { 5, 2, 6, 1, 8, 0 };
            if (x[i] == y[j])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
