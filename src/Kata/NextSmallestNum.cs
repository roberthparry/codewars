using System;
using System.Collections.Generic;
using System.Linq;

public class NextSmallestNum
{
	public static long NextSmaller(long n)
	{
		List<int> list = ToDigitList(n);
		List<List<int>> permutations = Permutations(list).Where(p => p[0] != 0).ToList();
		List<long> numbers = permutations.Select(ToNumber).ToList();

		return MaxNumberLessThan(numbers, n);
	}

	private static long MaxNumberLessThan(List<long> numbers, long n)
	{
        IEnumerable<long> numbersLess = numbers.Where(num => num < n);
        return numbersLess.Count() == 0 ? -1 : numbersLess.Max();
	}

	private static List<List<int>> Permutations(List<int> list)
	{
		if (list.Count < 2) return new List<List<int>> { list };
		List<List<int>> permutations = new List<List<int>>();
		for (int i = 0; i < list.Count; i++)
		{
			foreach (List<int> permutation in Permutations(CutItemAt(list, i)))
			{
				permutations.Add(new List<int>(permutation) { list[i] });
			}
		}

		return permutations;
	}

	private static List<int> CutItemAt(List<int> list, int i)
	{
		var listClone = new List<int>(list);
		listClone.RemoveAt(i);
		return listClone;
	}

    private static long ToNumber(List<int> digitList)
	{
		return digitList.Select(d => (long)d).Aggregate((acc, d) => d + 10L * acc);
	}

	private static List<int> ToDigitList(long n)
	{
		if (n < 10) return new List<int>{(int)n};
		var list = new List<int>(ToDigitList(n / 10L)){ (int)(n % 10L) };
		return list;
	}
}