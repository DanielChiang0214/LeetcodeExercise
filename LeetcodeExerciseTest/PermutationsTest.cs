using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using LeetcodeExerciseTest.Body;
using Xunit;
using Xunit.Abstractions;

namespace LeetcodeExerciseTest
{

    public class PermutationsTest : TestBase
    {
        public PermutationsTest(ITestOutputHelper output) : base(output)
        {

        }
        [Theory]
        [InlineData(new[] { 1, 2, 3 })]
        [InlineData(new[] { 1, 10, 5, 7 })]
        [InlineData(new[] { 1, 20, 10, 7 })]
        public void Permute_Validation_Logic(int[] nums)
        {
            foreach (var ienumerable in Permutations.Permute(nums))
            {
                Output.WriteLine(string.Join(",", ienumerable));
            }
        }

    }
}
