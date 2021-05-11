using System;

namespace PrimaryBase
{
    public class SieveOfEratosthenesOptimizedTask : ITask
    {
        public string Run(string[] data)
        {
            int n = Convert.ToInt32(data[0]);

            Console.Write(n + " ");
            bool[] divs = new bool[n + 1];
            int count = 0;
            for (int p = 2; p <= n; p++)
            {
                if (!divs[p])
                {
                    count++;
                    if (p <= Math.Sqrt(n))
                    {
                        for (int j = p * p; j <= n; j += p)
                        {
                            divs[j] = true;
                        }
                    }
                }
            }
            Console.Write(count + " ");

            return count.ToString();
        }

    }
}
