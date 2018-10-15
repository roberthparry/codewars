namespace Kata
{
    public static class NthDigit
    {
        public static int FindDigit(int num, int nth)
        {
            if (nth <= 0) return -1;
            if (num < 0) num = -num;
            int denominator = 1;
            for (int i = 1; i < nth; i++) denominator *= 10;
            return (num / denominator) % 10;
        }

        private static readonly int[] _divisors = new int[] {
            0, (int)1e0, (int)1e1, (int)1e2, (int)1e3, (int)1e4, (int)1e5, (int)1e6, (int)1e7, (int)1e8, (int)1e9
        }; 

        public static int FindDigit2(int num, int nth)
        {
            if (nth <= 0) return -1;
            if (nth > 10) return 0;
            if (num < 0) num = -num;
            return (num / _divisors[nth]) % 10;
        }
    } 
}
