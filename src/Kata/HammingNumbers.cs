namespace Kata
{
    public class HammingNumbers
    {
        public static long hamming(int n)
        {
            var h = new long[n];
            h[0] = 1;
            long x2 = 2L, x3 = 3L, x5 = 5L;

            int i = 0, j = 0, k = 0;
            for (int index = 1; index < n; index++)
            {
                long x = (x3 > x5) ? x5 : x3;
                h[index] = (x > x2) ? x2 : x;
                if (h[index] == x2) x2 = 2L * h[++i];
                if (h[index] == x3) x3 = 3L * h[++j];
                if (h[index] == x5) x5 = 5L * h[++k];
            }
            return h[n - 1];
        }
    }
}
