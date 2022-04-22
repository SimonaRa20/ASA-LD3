using System;
using System.Diagnostics;

namespace _3DALIS
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbolSequence = "a";
            string[] sizes = new string[] { "a", "kdj", "jdokw", "khsyrnmnbv", "abjslojsewrwftw", "eqwcagsrtuijdbdlpnva", "bjhcbdwoacnlqkcljkcjlkcss" };

            for (int i = 0; i < sizes.Length; i++)
            {
                Stopwatch time = new Stopwatch();
                //Console.Write(sizes[i]);
                long operationsCount = 0;
                time.Start();

                findMinInsertionsDP(sizes[i].ToCharArray(), sizes[i].Length, ref operationsCount);
                time.Stop();
                Console.WriteLine("Kai n = {0}, n.lenght = {1}, Elapsed = {2}, Operations = {3}",
                    sizes[i], sizes[i].Length, time.Elapsed, operationsCount);
            }

            //Console.WriteLine(findMinInsertions(symbolSequence.ToCharArray(), 0, symbolSequence.Length - 1));
            //Console.Write(findMinInsertionsDP(symbolSequence.ToCharArray(), symbolSequence.Length));

        }

        // recursive method
        static int findMinInsertions(char[] str, int l, int h, ref long operations)
        {
            if (l > h)
            {
                operations += 2;
                return int.MaxValue;
            }
            if (l == h)
            {
                operations += 2;
                return 0;
            }
            if (l == h - 1)
            {
                operations += 2;
                if (str[l] == str[h])
                {
                    operations += 2;
                    return 0;
                }
                else
                {
                    operations += 2;
                    return 1;
                }
            }
            if (str[l] == str[h])
            {
                operations += 2;
                return findMinInsertions(str, l + 1, h - 1, ref operations);
            }
            else
            {
                operations += 2;
                return (Math.Min(findMinInsertions(str, l, h - 1, ref operations), findMinInsertions(str, l + 1, h, ref operations)) + 1);
            }
        }



        // dynamic programing
        static int findMinInsertionsDP(char[] str, int n, ref long operations)
        {
            // Create a table of size n*n. table[i][j]
            // will store minimum number of insertions
            // needed to convert str[i..j] to a simetric sequence.
            int[,] table = new int[n, n];

            // Fill the table
            for (int gap = 1; gap < n; gap++)
            {
                operations += 2;
                for (int l = 0, h = gap; h < n; l++, h++)
                {
                    operations += 2;
                    if (str[l] == str[h])
                    {
                        table[l, h] = table[l + 1, h - 1];
                        operations += 3;
                    }
                    else
                    {
                        table[l, h] = (Math.Min(table[l, h - 1], table[l + 1, h]) + 1);
                        operations += 4;
                    }
                }
            }
            operations += 1;
            // Return minimum number of insertions for str[0..n-1]
            return table[0, n - 1];
        }
    }
}
