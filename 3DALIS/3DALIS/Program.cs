using System;

namespace _3DALIS
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbolSequence = "Ab3bd";

            Console.WriteLine(findMinInsertions(symbolSequence.ToCharArray(), 0, symbolSequence.Length - 1));
            Console.Write(findMinInsertionsDP(symbolSequence.ToCharArray(), symbolSequence.Length));

        }

        // recursive method
        static int findMinInsertions(char[] str, int l, int h)
        {
            // Base Cases
            if (l > h)
            {
                return int.MaxValue;
            }
            if (l == h)
            {
                return 0;
            }
            if (l == h - 1)
            {
                return (str[l] == str[h]) ? 0 : 1;
            }

            // Check if the first and last characters are same.
            // On the basis of the comparison result, decide
            // which subproblem(s) to call
            return (str[l] == str[h]) ? findMinInsertions(str, l + 1, h - 1) :
                                        (Math.Min(findMinInsertions(str, l, h - 1),
                                        findMinInsertions(str, l + 1, h)) + 1);
        }



        // dynamic programing
        static int findMinInsertionsDP(char[] str, int n)
        {
            // Create a table of size n*n. table[i][j]
            // will store minimum number of insertions
            // needed to convert str[i..j] to a palindrome.
            int[,] table = new int[n, n];
            int l, h, gap;

            // Fill the table
            for (gap = 1; gap < n; ++gap)
                for (l = 0, h = gap; h < n; ++l, ++h)
                    table[l, h] = (str[l] == str[h]) ?
                                table[l + 1, h - 1] :
                                (Math.Min(table[l, h - 1],
                                        table[l + 1, h]) + 1);

            // Return minimum number of insertions
            // for str[0..n-1]
            return table[0, n - 1];
        }
    }
}
