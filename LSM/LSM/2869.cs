using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM
{
    class _2869
    {
        static void Main(string[] args)
        { 
            string[] inputs = Console.ReadLine().Split();
            long A = long.Parse(inputs[0]);
            long B = long.Parse(inputs[1]);
            long V = long.Parse(inputs[2]);

            if (V == A)
            {
                Console.WriteLine(1);
            }
            else if ((V - A) % (A - B) > 0)
            {
                Console.WriteLine((V - A) / (A - B) + 2);
            }
            else
            {
                Console.WriteLine((V - A) / (A - B) + 1);
            }
        }
    }
}

