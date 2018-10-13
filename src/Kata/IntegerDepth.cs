namespace Kata
{
    public static class IntegerDepth
    {
        public static void AddToSet(int n, ref int set)
        {
            set |= 1 << (n % 10);

            if (n < 10)
                return;

            AddToSet(n / 10, ref set);
        }

        public static int ComputeDepth(int n)
        {
            int set = 0;
            int depth = 0;
            do
            {
                depth++;
                AddToSet(n * depth, ref set);
            } while (set < 1023);
            return depth;
        }

    }
}