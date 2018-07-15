using System;
using System.Linq;

public static class Kata
{
    public static string SequenceString(int n)
    {
        if (n < 0) return $"{n}<0";
        if (n == 0) return "0=0";
        string SequenceStringBuilder(int m) => (m < 2) ? "1" : $"{SequenceStringBuilder(m - 1)}+{m}";
        return $"{SequenceStringBuilder(n)}={n*(n+1)/2}";
    }
}