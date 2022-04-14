using System;

namespace _3DALIS
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "Ab3bd";
            string B = "dA";

            Console.WriteLine("Minimum number of " +
                              "operations required is " +
                               minOps(A, B));
        }
        public static int minOps(string A, string B)
        {

            // This parts checks whether
            // conversion is possible or not
            if (A.Length != B.Length)
            {
                return -1;
            }

            int i, j, res = 0;
            int[] count = new int[256];

            // count characters in A

            // subtract count for every
            // character in B
            for (i = 0; i < A.Length; i++)
            {
                count[A[i]]++;
                count[B[i]]--;
            }

            // Check if all counts become 0
            for (i = 0; i < 256; i++)
            {
                if (count[i] != 0)
                {
                    return -1;
                }
            }

            i = A.Length - 1;
            j = B.Length - 1;

            while (i >= 0)
            {
                // If there is a mismatch, then
                // keep incrementing result 'res'
                // until B[j] is not found in A[0..i]
                if (A[i] != B[j])
                {
                    res++;
                }
                else
                {
                    j--;
                }
                i--;
            }
            return res;
        }
    }
}
