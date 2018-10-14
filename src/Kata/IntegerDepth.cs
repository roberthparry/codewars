namespace Kata
{
    public static class IntegerDepth
    {
        public static void AddDigitsToDigitSet(int n, ref int digitSet)
        {
            digitSet |= 1 << (n % 10);
            if (n < 10) return;
            AddDigitsToDigitSet(n / 10, ref digitSet);
        }

        public static int ComputeDepth(int n)
        {
            int digitSet = 0;
            int depth;
            for (depth = 0; depth < 1023; depth++)
                AddDigitsToDigitSet(n * depth, ref digitSet);
            return depth;
        }

    }
}