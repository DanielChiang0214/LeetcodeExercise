using LeetcodeExerciseTest;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    public static class MergeTwoSortedLists
    {
        public static ListNode Execute(ListNode list1, ListNode list2)
        {
            if (list1 is null)
            {
                return list2;
            }
            if (list2 is null)
            {
                return list1;
            }
            if (list1.val < list2.val)
            {
                list1.next = Execute(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = Execute(list2.next, list1);
                return list2;
            }
        }
    }
}
