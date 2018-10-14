using System.Linq;

namespace Kata
{
    public static class ArrayDifference
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(i => !b.Contains(i)).ToArray();
        }
    }
}
