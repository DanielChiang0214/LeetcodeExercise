using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeExercise;
using LeetcodeExerciseTest.Body;
using Xunit;
using Xunit.Abstractions;
using static LeetcodeExerciseTest.MergeTwoSortedListsTest;

namespace LeetcodeExerciseTest
{
    public class AddTwoNumbersTest : TestBase
    {
        public AddTwoNumbersTest(ITestOutputHelper output) : base(output)
        {
        }

        [Theory]
        [InlineData(1, 4)]
        [InlineData(9, 155)]
        [InlineData(4465, 19)]
        public void AddTwoNumbers_Validation_Logic(int number1, int number2)
        {
            var l1 = ListNode.Create(number1);
            var l2 = ListNode.Create(number2);
            var answer = AddTwoNumbers.Execute(l1, l2);
            Output.WriteLine(answer.ToString());
            Assert.Equal(answer.ToInt(), number1 + number2);
        }
    }
}
