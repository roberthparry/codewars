using System.Numerics;

namespace Kata
{
    public static class FastFibonacci
    {

        public static BigInteger fib(int n)
        {
            if (n < 0) return (n % 2 == 0) ? -fib(-n) : fib(-n);
            if (n < 2) return new BigInteger(n);
            if (n == 2) return BigInteger.One;
            int k = (n + 1) / 2;
            BigInteger f = fib(k - 1);
            BigInteger g = fib(k);
            return (n % 2 == 0) ? g * (f * 2 + g) : f * f + g * g;
        }
    }
}
