using System;

namespace LSM
{
    class _11729
    {
        //하노이탑 문제
        //N개의 원탑을 옮기기 위해서는 n-1개의 원탑을 두번 옮기고 + 1회를 더하면 된다
        //이유는 n-1개의 원탑을 A에서 B로 옮기고, n번째 원탑을 A에서 C로 옮기고, n-1개의 원탑을 B에서 C로 옮기면 되기 때문
        
        static StreamWriter sw;

        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (sw = new StreamWriter(Console.OpenStandardOutput())) 
            {
                string line = sr.ReadLine();
                int n = int.Parse(line.Trim());                
                int k = (int)Math.Pow(2, n) - 1;
                sw.WriteLine(k);
                Hanoitop(n, 1, 2, 3);   
                sw.Flush();
            }
        }

        static void Hanoitop(int n, int A, int B, int C) //A를 C로 옮기는 하노이탑 
        {
            //마지막 기둥 옮기기
            if (n == 1)
            {
                sw.WriteLine($"{A} {C}");
                return;
            }
            
            //n-1개를 B 기둥에 옮기기
            Hanoitop(n - 1, A, C, B); 

            //n번째를 C 기둥에 옮기기
            sw.WriteLine($"{A} {C}"); 

            //나머지 n-1개를 C 기둥에 옮기기
            Hanoitop(n - 1, B, A, C);
        }
    }
}