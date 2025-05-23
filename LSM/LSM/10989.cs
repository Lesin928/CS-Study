using System;
using System.ComponentModel.DataAnnotations;

namespace LSM
{
    class _10989
    {        
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int[] a = new int[10000];
                int n = int.Parse(sr.ReadLine());

                for (int i = 0; i < n; i++)          
                    ++a[int.Parse(sr.ReadLine()) - 1]; 

                for (int i = 1; i <= 10000; i++)  
                { 
                    while (a[i-1]-- > 0) 
                        sw.WriteLine(i);
                } 
            }
        
        }
    }
} 