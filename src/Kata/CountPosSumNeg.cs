using System.Linq;

namespace Kata
{
    public static class CountPosSumNeg
    {
        public static int[] CountPositivesSumNegatives(int[] input) =>
            (input == null || input.Length == 0) ? new int[0] :
                input.Aggregate(new int[] { 0, 0 }, (acc, e) => {
                    if (e > 0) acc[0]++;
                    else if (e < 0) acc[1] += e;
                    return acc;
                });
    }
}
