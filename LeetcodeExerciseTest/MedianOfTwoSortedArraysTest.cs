using LeetcodeExercise;
using LeetcodeExerciseTest.Body;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace LeetcodeExerciseTest
{
    public class MedianOfTwoSortedArraysTest : TestBase
    {
        public MedianOfTwoSortedArraysTest(ITestOutputHelper output) : base(output)
        {
        }

        [Theory]
        [InlineData(new[] { 1, 3 }, new[] { 2 }, 2)]
        [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
        public void CombinationSum_Validation_Logic(int[] array1, int[] array2, decimal anser)
        {
            var value = MedianOfTwoSortedArrays.FindMedianSortedArrays(array1, array2);

            Assert.Equal(value, anser);
        }
    }
}
