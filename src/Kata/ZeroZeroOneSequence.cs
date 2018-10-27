using System.Linq;

namespace Kata
{
    public static class ZeroZeroOneSequence
    {
        public static int[] Fetch(int numTerms) => Enumerable.Range(1, numTerms).Select(n => (n + 3) / 3 - (n + 2) / 3).ToArray();
    }
}
