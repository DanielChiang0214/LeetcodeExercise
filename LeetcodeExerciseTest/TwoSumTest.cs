using System.Collections.Generic;
using System.Linq;
using LeetcodeExercise;
using LeetcodeExerciseTest.Body;
using Xunit;
using Xunit.Abstractions;

namespace LeetcodeExerciseTest
{
    public class TwoSumText : TestBase
    {
        public TwoSumText(ITestOutputHelper output) : base(output)
        {
        }

        [Theory]
        [InlineData(new[] { 1, 3, 5, 7 }, 4)]
        [InlineData(new[] { 1, 10, 5, 7 }, 15)]
        [InlineData(new[] { 1, 20, 10, 7 }, 11)]
        public void TwoSum_Validation_Logic(int[] nums, int target)
        {
            var answer = TwoSum.Execute(nums, target);
            Assert.Equal(Print(answer.Sum(item => nums[item])), Print(target));
        }
    }
}