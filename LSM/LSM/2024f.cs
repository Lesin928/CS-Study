using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


//NYPC 라운드 기록 복원하기 

namespace LSM
{
    class _2024f
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

                    sw.WriteLine();
                }
            }


        }
    }
}