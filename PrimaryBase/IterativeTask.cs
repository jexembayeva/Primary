using System;

namespace PrimaryBase
{
    public class IterativeTask : ITask
    {
        public string Run(string[] data)
        {
            int n = Convert.ToInt32(data[0]);
            int q = 0;
            Console.Write(n + " ");

            for (int j = 2; j <= n; j++)
            {
                if (IsPrime(j))
                {
                    q++;
                }
            }

            Console.Write(q + " ");
            return q.ToString();
        }

        bool IsPrime(int p)
        {
            if (p == 2) return true;
            if (p == 3) return true;
            if (p % 2 == 0) return false;
            if (p % 3 == 0) return false;

            int sqrt = (int)Math.Sqrt(p);

            for (int i = 5; i <= sqrt; i += 6)
            {
                if (p % i == 0)
                {
                    return false;
                }
                if (p % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
