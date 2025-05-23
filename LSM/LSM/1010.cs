using System;
using System.IO;

namespace LSM
{
    class _1010
    { 
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int T = int.Parse(sr.ReadLine());

                for (int i = 0; i < T; i++)
                {
                    string[] input = sr.ReadLine().Split();
                    int N = int.Parse(input[0]);
                    int M = int.Parse(input[1]);

                    sw.WriteLine(Combination(M, N));
                }
            }
        }
         
        static long Combination(int n, int r)
        {
            if (r > n - r)
                r = n - r;

            long result = 1;
            for (int i = 0; i < r; i++)
            {
                result *= (n - i);
                result /= (i + 1);
            }

            return result;
        }
    }
}
