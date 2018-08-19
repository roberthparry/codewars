using System;
using System.Linq;

namespace Kata
{
	public static class UnluckyDay
	{
		public static int UnluckyDays(int year)
		{
			return Enumerable.Range(1, 12).Count(i => new DateTime(year, i, 13).DayOfWeek == DayOfWeek.Friday);
		}
	}
}
