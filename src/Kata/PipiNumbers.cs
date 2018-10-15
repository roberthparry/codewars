using System.Numerics;
using System.Collections.Generic;

namespace Kata
{
    public static class PipiNumbers
    {
        private static Dictionary<int, BigInteger> _pipiNumberDict = new Dictionary<int, BigInteger>
        {
            {0, 0}
        };

        public static BigInteger Pipi(int n)
        {
            BigInteger p;
            if (!_pipiNumberDict.TryGetValue(n, out p))
            {
                if (n == 0) return new BigInteger(0);
                p = new BigInteger(n);
                for (int i = 0; i < n; i++)
                {
                    p -= Pipi(i);
                    p *= p;
                }
                _pipiNumberDict[n] = p;
            }

            return p;
        }
    }
}
