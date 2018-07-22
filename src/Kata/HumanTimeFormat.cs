using System;
using System.Collections.Generic;

namespace Kata
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            Console.WriteLine($"seconds = {seconds}");
            if (seconds == 0) return "now";

            var now = DateTime.Now;
            var later = now.AddSeconds(seconds);

            Console.WriteLine($"now: {now:yyyy-MM-dd hh:mm:ss}, later: {later:yyyy-MM-dd hh:mm:ss}");

            int nowDoy = now.DayOfYear;
            int laterDoy = later.DayOfYear;
            int nowYear = now.Year;
            int laterYear = later.Year;

            int years = laterYear - nowYear;
            int days = laterDoy - nowDoy;
            if (laterDoy < nowDoy)
            {
                years--;
                DateTime thisTimeLater = now.AddYears(years);
                days = (later - thisTimeLater).Days;
            }

            int nowHour = now.Hour;
            int laterHour = later.Hour;
            if (laterHour < nowHour)
            {
                days--;
                laterHour += 24;
            }

            int nowMinute = now.Minute;
            int laterMinute = later.Minute;
            int hours = laterHour - nowHour;
            if (laterMinute < nowMinute)
            {
                hours--;
                laterMinute += 60;
            }

            int nowSecond = now.Second;
            int laterSecond = later.Second;
            int minutes = laterMinute - nowMinute;
            if (laterSecond < nowSecond)
            {
                minutes--;
                laterSecond += 60;
            }

            int secs = laterSecond - nowSecond;

            var output = new List<string>();

            if (years > 0) output.Add((years > 1) ? $"{years} years" : $"{years} year");
            if (days > 0) output.Add((days > 1) ? $"{days} days" : $"{days} day");
            if (hours > 0) output.Add((hours > 1) ? $"{hours} hours" : $"{hours} hour");
            if (minutes > 0) output.Add((minutes > 1) ? $"{minutes} minutes" : $"{minutes} minute");
            if (secs > 0) output.Add((secs > 1) ? $"{secs} seconds" : $"{secs} second");

            string final = output.Count > 1 ? $" and {output[output.Count - 1]}" : output[0];
            string result = $"{string.Join(", ", output.GetRange(0, output.Count - 1))}{final}";
            return result;
        }
    }    
}
