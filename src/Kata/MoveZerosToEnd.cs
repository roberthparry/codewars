using System.Linq;

namespace Kata
{
    public class MoveZerosToEnd
    {
        public static int[] MoveZeroes(int[] arr) => arr.Where(i => i != 0).Concat(arr.Where(j => j == 0)).ToArray();
    }
}
