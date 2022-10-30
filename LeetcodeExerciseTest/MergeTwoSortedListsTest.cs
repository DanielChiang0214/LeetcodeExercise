using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeExercise;
using LeetcodeExerciseTest.Body;
using Xunit;
using Xunit.Abstractions;

namespace LeetcodeExerciseTest
{
    public partial class MergeTwoSortedListsTest : TestBase
    {
        public MergeTwoSortedListsTest(ITestOutputHelper output) : base(output)
        {
        }

        [Theory]
        [InlineData(new[] { 1, 3, 5, 7 }, new[] { 1, 3, 5, 7 })]
        [InlineData(new[] { 1, 7, 10, 14 }, new[] { 0, 2, 4, 6 })]
        [InlineData(new[] { 1 }, new[] { 2 })]
        public void MergeTwoLists_Validation_Logic(int[] list1, int[] list2)
        {
            var temp1 = CreatListNode(list1);
            var temp2 = CreatListNode(list2);
            Print($"{temp1}：{temp2}");
            var answer = MergeTwoSortedLists.Execute(temp1, temp2);
            Print(answer);
        }

        private ListNode CreatListNode(IEnumerable<int> source) =>
            source.Any() ? new(source.First(), CreatListNode(source.Skip(1))) : default;

        public ListNode MergeTwoLists2(ListNode list1, ListNode list2)
        {
            if (list1 is null)
            {
                return list2;
            }
            if (list2 is null)
            {
                return list1;
            }
            var root = new ListNode();
            var current = root;
            while (list1 is not null && list2 is not null)
            {
                _ = list1.val < list2.val ? list1 = (current.next = list1).next : list2 = (current.next = list2).next;
                current = current.next;
            }
            current.next = list1 is null ? list2 : list1;
            return root.next;
        }

        public IEnumerable<int> MergeTwoLists(ListNode list1, ListNode list2)
        {
            var current = default(ListNode);
            while (list1 is not null && list2 is not null)
            {
                _ = list1.val < list2.val ? list1 = (current = list1).next : list2 = (current = list2).next;
                yield return current.val;
            }
            current = list1 is not null ? list1 : list2;
            while (current is not null)
            {
                yield return current.val;
                current = current.next;
            }
        }
    }
}
