using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DEMOLINQ1
{
    public static class BaseTypeExtensions
    {
        public static bool IsPrime(this int n)
        {
            if (n <= 1) return false;
            if ((n & 1) == 0)
            {
                if (n == 2) return true;
                else return false;
            }
            for (int i = 3; (i * i) <= n; i += 2)
            {
                if ((n % i) == 0) return false;
            }
            return n != 1;
        }
        public static bool IsPrime(this int n, CancellationTokenSource cs)
        {
            if (n == 1000) cs.Cancel();
            return IsPrime(n);
        }
    }
}
