using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0) return "now";
            IEnumerable<string> quantityDescriptions = DescribedQuantities(seconds);
            int unitCount = quantityDescriptions.Count();
            if (unitCount == 1) return quantityDescriptions.Single();
            string priorQuantities = string.Join(", ", quantityDescriptions.Take(unitCount - 1));
            return $"{priorQuantities} and {quantityDescriptions.Last()}";
        }

        private static IEnumerable<string> DescribedQuantities(int seconds)
        {
            var timespan = TimeSpan.FromSeconds(seconds);
            int years = timespan.Days / 365;
            int days = timespan.Days % 365;
            if (years > 0) yield return DescribeQuantity(years, "year");
            if (days > 0) yield return DescribeQuantity(days, "day");
            if (timespan.Hours > 0) yield return DescribeQuantity(timespan.Hours, "hour");
            if (timespan.Minutes > 0) yield return DescribeQuantity(timespan.Minutes, "minute");
            if (timespan.Seconds > 0) yield return DescribeQuantity(timespan.Seconds, "second");
        }

        private static string DescribeQuantity(int quantity, string unit)
        {
            if (quantity == 0) return "";
            var description = $"{quantity} {unit}";
            if (quantity > 1) description = $"{description}s";
            return description;
        }
    }    
}
