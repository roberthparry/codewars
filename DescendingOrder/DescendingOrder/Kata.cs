using System;

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        int[] digitCounts = new int[10];

        while (num != 0)
        {
            digitCounts[num % 10]++;
            num /= 10;
        }

        int result = 0;
        for (int i = 9; i >= 0; i--)
        {
            for (int j = 0; j < digitCounts[i]; j++)
            {
                result *= 10;
                result += i;
            }
        }

        return result;
    }
}