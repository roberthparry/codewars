namespace Kata
{
    public static class SumFractions
    {
        private static int GreatestCommonDivisor(int m, int n) =>
            (m == 0) ? n : GreatestCommonDivisor(n % m, m);

        private static void LowestForm(int[] frac)
        {
            int commonFactor = GreatestCommonDivisor(frac[0], frac[1]);
            frac[0] /= commonFactor;
            frac[1] /= commonFactor;
        }

        private static void AddFractionTo(int[] frac, int[] frac2)
        {
            int denom = GreatestCommonDivisor(frac[1], frac2[1]);
            denom = frac[1] * frac2[1] / denom;
            frac[0] = frac[0] * (denom / frac[1]) + frac2[0] * (denom / frac2[1]);
            frac[1] = denom;
        }

        public static string SumFracts(int[,] fractions)
        {
            if (fractions == null || fractions.GetLength(0) == 0)
                return null;

            int[] fraction = new int[] { fractions[0, 0], fractions[0, 1] };
            for (int i = 1; i < fractions.GetLength(0); i++)
            {
                int[] nextFraction = new int[] { fractions[i, 0], fractions[i, 1] };
                AddFractionTo(fraction, nextFraction);
            }
            LowestForm(fraction);
            return (fraction[1] == 1) ? $"{fraction[0]}" : $"[{fraction[0]}, {fraction[1]}]";
        }
    }
}
