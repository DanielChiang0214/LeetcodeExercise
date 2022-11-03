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
    public class MergeKSortedListsTest : TestBase
    {
        public MergeKSortedListsTest(ITestOutputHelper output) : base(output)
        {
        }
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 1, 3, 5, 7, 9 })]
        public void CombinationSum_Validation_Logic(params int[][] candidates)
        {
            var source = candidates.Select(item => ListNode.Create(item)).ToArray();
            var dd = MergeKSortedLists.MergeKLists(source);

            Output.WriteLine(dd.ToString());
        }
    }
}
