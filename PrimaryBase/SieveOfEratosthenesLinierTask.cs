using System;
using System.Collections.Generic;

namespace PrimaryBase
{
    public class SieveOfEratosthenesLinierTask : ITask
    {
        public string Run(string[] data)
        {
            int n = Convert.ToInt32(data[0]);
            Console.Write(n + " ");

            int[] lp = new int[n + 1];
            List<int> pr = new List<int>();

            for (int i = 2; i <= n; ++i)
            {
                if (lp[i] == 0)
                {
                    lp[i] = i;
                    pr.Add(i);
                }
                for (int j = 0; j < pr.Count && pr[j] <= lp[i] && i * pr[j] <= n; ++j)
                    lp[i * pr[j]] = pr[j];
            }

            Console.Write(pr.Count + " ");

            return pr.Count.ToString();
        }

    }
}
