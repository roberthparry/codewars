using System;
using System.Linq;

public class Kata
{
    public static string TwoSort(string[] s)
    {
        Array.Sort(s, StringComparer.Ordinal);
        return string.Join("***", s[0].Select(c => $"{c}").ToArray());
    }
}