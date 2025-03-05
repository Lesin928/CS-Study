using System;
using System.Linq;

namespace LSM
{
    class _1712
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int fixedCost = values[0];  
            int variableCost = values[1];  
            int price = values[2]; 

            if (price <= variableCost)
                Console.WriteLine("-1");  
            else
            {
                int breakEvenPoint = fixedCost / (price - variableCost) + 1;
                Console.WriteLine(breakEvenPoint); 
            }
        }
    }
}