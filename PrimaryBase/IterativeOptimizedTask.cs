using System;

namespace PrimaryBase
{
    public class IterativeOptimizedTask : ITask
    {
        int[] primes;
        int count = 0;
        public string Run(string[] data)
        {
            int n = Convert.ToInt32(data[0]);
            Console.Write(n + " ");

            int q = CountPrimes(n);

            Console.Write(q + " ");
            return q.ToString();
        }

        private int CountPrimes(int n)
        {
            count = 0;

            if (n <= 1)
            {
                return count;
            }

            primes = new int[n];
            primes[count++] = 2;
            for (int p = 3; p <= n; p += 2)
            {
                if (IsPrime(p))
                {
                    primes[count++] = p;
                }
            }
            return count;
        }

        private bool IsPrime(int p)
        {
            int sqrt = (int)Math.Sqrt(p);

            for (int i = 0; primes[i] <= sqrt; i++)
            {
                if (p % primes[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
