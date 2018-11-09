using System.Linq;

namespace Kata
{
    public static class ParityOutlier
    {
        public static int Find(int[] integers)
        {
            bool odds = false, evens = false;
            int lastOdd = 0, lastEven = 0;
            foreach (int i in integers)
            {
                if (i % 2 == 0)
                {
                    lastEven = i;
                    if (evens && odds)
                        return lastOdd;
                    evens = true;
                }
                else
                {
                    lastOdd = i;
                    if (odds && evens)
                        return lastEven;
                    odds = true;
                }
            }
            return integers.Last();
        }
    }
}
