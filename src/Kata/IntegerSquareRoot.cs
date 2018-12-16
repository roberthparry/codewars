namespace Kata
{
    public static class IntegerSquareRoot
    {
        public static object SqrtApproximation(int number)
        {
            if (number == 0 || number == 1) return number;
            int s = number / 2;
            while (s * s > number)
                s = (s + number / s) / 2;

            if (s * s < number && number < (s + 1) * (s + 1))
                return new int[] { s, s + 1 };
            return s;
        }
    }
}
