using System;
using System.IO;

namespace LSM
{
    class _4779
    { 
        static void Cantor(char[] arr, int start, int end)
        {
            int length = end - start + 1;
            if (length < 3)
                return;

            int third = length / 3; 
            for (int i = start + third; i < start + 2 * third; i++)
            {
                arr[i] = ' ';
            } 
            Cantor(arr, start, start + third - 1);
            Cantor(arr, start + 2 * third, end);
        }

        static void Main(string[] args)
        { 
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    if (!int.TryParse(line.Trim(), out int n))
                        continue;

                    // 시작 문자열의 길이: 3^n
                    int length = (int)Math.Pow(3, n);
                    char[] arr = new char[length];

                    // 전체를 '-' 문자로 채움
                    for (int i = 0; i < length; i++)
                    {
                        arr[i] = '-';
                    }

                    Cantor(arr, 0, length - 1);
                    sw.WriteLine(new string(arr));
                }
                sw.Flush();
            }
        }
    }
}