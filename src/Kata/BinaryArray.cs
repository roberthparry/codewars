using System.Linq;

namespace Kata
{
    class BinaryArray
    {
		public static int binaryArrayToNumber(int[] bitArray)
        {
            return bitArray.Aggregate(0, (x, y) => x << 1 | y);
        }
    }
}