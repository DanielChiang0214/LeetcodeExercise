namespace LeetcodeExercise
{
	public class Find_Players_With_Zero_or_One_Losses
	{
		public IList<IList<int>> FindWinners(int[][] matches)
		{
			var key = 0;
			var statistics = new Dictionary<int, int>();
			for (int i = 0; i < matches.Length; i++)
			{
				key = matches[i][0];
				statistics[key] = statistics.TryGetValue(key, out var last) ? last : 0;
				key = matches[i][1];
				statistics[key] = statistics.TryGetValue(key, out var result) ? ++result : 1;
			}

			var noDefeat = new List<int>();
			var failedOnce = new List<int>();
			foreach (var kvp in statistics)
			{
				if (kvp.Value == 0)
				{
					noDefeat.Add(kvp.Key);
				}
				if (kvp.Value == 1)
				{
					failedOnce.Add(kvp.Key);
				}
			}
			noDefeat.Sort();
			failedOnce.Sort();
			return new List<IList<int>>()
			{
				noDefeat,
				failedOnce
			};
		}
	}
}
