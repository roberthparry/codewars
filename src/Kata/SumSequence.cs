using System;
using System.Linq;

namespace Kata
{
    public static class SumSequence
    {
        public static string SequenceString(int n)
        {
            if (n < 0) return $"{n}<0";
            if (n == 0) return "0=0";
            string SequenceStringBuilder(int m) => (m < 2) ? "0+1" : $"{SequenceStringBuilder(m - 1)}+{m}";
            return $"{SequenceStringBuilder(n)} = {n * (n + 1) / 2}";
        }

        public static String ShowSequence(Int32 n)
        {
            if (n <= 0) return n < 0 ? $"{n}<0" : "0=0";
            return $"0+{String.Join("+", Enumerable.Range(1, n))} = {n * (n + 1) / 2}";
        }
    }
}
