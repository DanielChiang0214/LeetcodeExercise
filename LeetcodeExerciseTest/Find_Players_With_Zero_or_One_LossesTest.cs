using LeetcodeExercise;
using LeetcodeExerciseTest.Body;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace LeetcodeExerciseTest
{
	public class Find_Players_With_Zero_or_One_LossesTest : TestBase
	{
		public Find_Players_With_Zero_or_One_LossesTest(ITestOutputHelper output) : base(output)
		{
		}

		[Theory]
		[InlineData(new int[] { 1, 2, 10 }, new int[] { 4, 5, 7, 8 }, new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 3, 6 }, new int[] { 5, 6 }, new int[] { 5, 7 }, new int[] { 4, 5 }, new int[] { 4, 8 }, new int[] { 4, 9 }, new int[] { 10, 4 }, new int[] { 10, 9 })]
		[InlineData(new int[] { 1 }, new int[] { 100000 }, new int[] { 1, 100000 })]
		public void TTTTTT(int[] noDefeat, int[] failedOnce, params int[][] matches)
		{
			for (int i = 0; i < matches.Length; i++)
			{
				Output.WriteLine($"[{matches[i][0]},{matches[i][1]}]");
			}
			var result = new Find_Players_With_Zero_or_One_Losses().FindWinners(matches);
			Assert.Equal(noDefeat, result.First());
			Assert.Equal(failedOnce, result.Skip(1).First());
		}
	}
}
