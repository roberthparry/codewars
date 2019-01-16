using System;

namespace Kata
{
    public static class IntegerSquareRoot
    {
        public static object SqrtApproximation(int number)
        {
            if (number < 0) throw new ArgumentException();
            if (number < 2) return number;

            int s = number / 2;
            while (s * s > number)
                s = (s + number / s) / 2;

            int t = s + 1;
            if (s * s < number && number < t * t)
                return new int[] { s, t };
            return s;
        }
    }
}
