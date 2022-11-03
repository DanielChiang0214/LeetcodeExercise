using LeetcodeExerciseTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    public class MergeKSortedLists
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            var minNode = default(ListNode);
            var dict = new Dictionary<int, List<ListNode>>();
            foreach (var item in lists)
            {
                if (item is null)
                {
                    continue;
                }
                if (dict.TryGetValue(item.val, out var listNodes) == false)
                {
                    if (minNode is null || minNode.val > item.val)
                    {
                        minNode = item;
                    }
                    dict[item.val] = listNodes = new();
                }
                listNodes.Add(item);
            }
            if (minNode is null)
            {
                return minNode!;
            }
            var nextItem = Enumerable.Empty<ListNode>();
            var minlist = dict[minNode.val];
            dict.Remove(minNode.val);
            minNode = new ListNode();
            var current = minNode;
            foreach (var item in minlist)
            {
                if (item.next is not null)
                {
                    nextItem = nextItem.Append(item.next);
                }
                current.next = item;
                current = current.next;
            }
            current.next = MergeKLists(nextItem.Concat(dict.SelectMany(kvp => kvp.Value)).ToArray());
            return minNode.next;
        }
    }
}
