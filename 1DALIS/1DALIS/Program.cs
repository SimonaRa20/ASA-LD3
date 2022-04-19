using System;

namespace _1DALIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //public static int F(int n, int m)
        //{
        //    if(x == 0)
        //    {
        //        return y.Length;
        //    }
        //    if(y.Length == 0 && x.Length > 0)
        //    {
        //        return x.Length;
        //    }
        //    else
        //    {
        //        for(int n = 0; n < x.Length; n++)
        //        {
        //            for(int m = 0; m < y.Length; m++)
        //            {
        //                int value1 = 1 + F(x[m-1],n)
        //            }
        //        }
        //    }
        //}

        public static int D(int x, int y)
        {
            if (x == y)
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
