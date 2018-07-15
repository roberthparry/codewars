using System.Linq;

public static class Kata
{
    public static int SquareSum(int[] n)
    {
		return n.Select(m => m * m).Sum();
    }
}
