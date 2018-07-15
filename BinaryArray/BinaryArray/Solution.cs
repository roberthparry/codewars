using System.Linq;

namespace Solution
{
    class Kata
    {
		public static int binaryArrayToNumber(int[] bitArray)
        {
            return bitArray.Aggregate(0, (x, y) => x << 1 | y);
        }
    }
}