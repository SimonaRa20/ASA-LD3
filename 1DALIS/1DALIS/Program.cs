using System;

namespace _1DALIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = F(1, 2);
            int m2 = F2(1, 2);
            Console.WriteLine(m);
            Console.WriteLine(m2);
        }

        // using recursion
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

        // using dynamic programinc 
        static int F2(int M, int N)
        {
            var F = new int[M + 1, N + 1];

            for (var m = 0; m <= M; m++)
            {
                for (var n = 0; n <= N; n++)
                {
                    if (n == 0)
                    {
                        F[m, n] = m;
                        continue;
                    }
                    if (m == 0 && n > 0)
                    {
                        F[m, n] = n;
                        continue;
                    }
                    F[m, n] = Math.Min((1 + F[m - 1, n]), Math.Min((1 + F[m, n - 1]), (D(m - 1, n - 1) + F[m - 1, n - 1])));
                }
            }

            return F[M, N];
        }
    }
}
