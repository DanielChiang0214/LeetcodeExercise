using LeetcodeExerciseTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    public static class AddTwoNumbers
    {
        public static ListNode Carry = new(1);
        public static ListNode Execute(ListNode l1, ListNode l2)
        {
            if (l1 is null)
            {
                return l2;
            }
            if (l2 is null)
            {
                return l1;
            }
            var sum = l2.val + l1.val;
            return sum >= 10 ?
                new(sum % 10, Execute(Carry, Execute(l1?.next, l2?.next))) :
                new(sum, Execute(l1?.next, l2?.next));
        }
    }
}
