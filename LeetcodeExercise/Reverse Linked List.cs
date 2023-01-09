using LeetcodeExerciseTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    public class Reverse_Linked_List
    {
        public ListNode ReverseList(ListNode head)
        {
            var result = new ListNode();
            var next = default(ListNode);
            var temp = default(ListNode);
            while (head is not null)
            {
                next = head.next;
                temp = result.next;
                result.next = head;
                result.next.next = temp;
                head = next;
            }
            return result.next;
        }

        public ListNode ReverseList_v2(ListNode head)
        {
            var (newHead, current) = ReverseList_2(head);
            current.next = null;
            return newHead.next;
        }

        public (ListNode newHead, ListNode current) ReverseList_2(ListNode head)
        {
            if (head is not null)
            {
                var (newHead, current) = ReverseList_2(head.next);
                current.next = head;
                return (newHead, current.next);
            }
            else
            {
                var temp = new ListNode();
                return (temp, temp);
            }
        }
    }
}
