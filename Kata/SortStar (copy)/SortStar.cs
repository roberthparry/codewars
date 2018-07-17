using System;
using System.Linq;

namespace Kata
{
    public class SortStar
    {
        public static string TwoSort(string[] s)
        {
            Array.Sort(s, StringComparer.Ordinal);
            return string.Join("***", s[0].Select(c => $"{c}").ToArray());
        }
    }    
}
