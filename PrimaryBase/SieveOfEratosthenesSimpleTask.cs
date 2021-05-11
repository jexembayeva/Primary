using System;
using System.Numerics;

namespace PrimaryBase
{
    public class SieveOfEratosthenesSimpleTask : ITask
    {
        public string Run(string[] data)
        {
            int n = Convert.ToInt32(data[0]);

            Console.Write(n + " ");
            bool[] divs = new bool[n + 1];
            int count = 0;
            for (BigInteger p = 2; p <= n; p++)
            {
                if (!divs[(int)p])
                {
                    count++;
                    for (BigInteger  j = p * p; j <= n; j += p)
                    {
                        divs[(int)j] = true;
                    }
                }
            }
            Console.Write(count + " ");

            return count.ToString();
        }

    }
}
