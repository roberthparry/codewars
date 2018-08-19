using System.Linq;

namespace Kata
{
	public static class HighestScoringWord
	{
		public static string High(string s)
		{
			int maxScorePos = -1;
			int maxScore = -1;
			string[] words = s.Split(' ');
			for (int i = 0; i < words.Length; i++)
			{
				string word = words[i];
				int score = word.Select(ch => (int)(ch - 'a')).Sum();
				if (score > maxScore)
				{
					maxScore = score;
					maxScorePos = i;
				}
			}
			return words[maxScorePos];
		}
	}
}
