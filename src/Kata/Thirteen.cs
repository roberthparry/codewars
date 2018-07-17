namespace Kata
{
    public class Thirteen
    {

        private static long[] _10PowMod13 = new long[] { 1, 10, 9, 12, 3, 4 };

        public static long Thirt(long n)
        {
            long sum = 0L;
            for (long num = n, place = 0; num > 0L; num /= 10, place++)
                sum += (num % 10L) * _10PowMod13[place % 6];

            return (sum == n) ? n : Thirt(sum);
        }
    }
}
