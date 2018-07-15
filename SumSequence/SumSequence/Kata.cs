using System;
using System.Linq;

public static class Kata
{
    public static string SequenceString(int n)
    {
        if (n < 0) return $"{n}<0";
        if (n == 0) return "0=0";
        return $"{SequenceStringBuilder(n)}={n*(n+1)/2}";
    }

    private static string SequenceStringBuilder(int n) => (n < 2) ? "1" : $"{SequenceStringBuilder(n-1)}+{n}";
}