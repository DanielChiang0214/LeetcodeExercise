using System;
using System.Collections.Generic;
using System.Linq;
using LeetcodeExerciseTest.Body;
using Xunit;
using Xunit.Abstractions;

namespace LeetcodeExerciseTest
{

    public class CombinationSumTest : TestBase
    {
        public CombinationSumTest(ITestOutputHelper output) : base(output)
        {
        }
        [Theory]
        [InlineData(new[] { 1, 3, 5, 7 }, 4)]
        [InlineData(new[] { 2, 3, 6, 7 }, 7)]
        [InlineData(new[] { 2, 3, 5 }, 8)]
        public void CombinationSum_Validation_Logic(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            CombinationSum.Execute(candidates, Array.Empty<int>(), target, result);

            foreach (var item in result)
            {
                Output.WriteLine(string.Join(",", item));
            }
        }
    }
}
