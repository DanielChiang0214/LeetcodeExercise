using LeetcodeExerciseTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    public class Odd_Even_Linked_List
    {
        public ListNode OddEvenList(ListNode head)
        {
            var evenHead = new ListNode();
            var oddHead = new ListNode();
            var even = evenHead;
            var odd = oddHead;
            var index = 0;
            while (head is not null)
            {
                if (index++ % 2 == 0)
                {
                    odd.next = head;
                    odd = odd.next;
                }
                else
                {
                    even.next = head;
                    even = even.next;
                }
                head = head.next;
            }
            Console.WriteLine(odd.val);
            Console.WriteLine(odd.next is null);
            odd.next = evenHead.next;
            var gggg = oddHead.next;
            while (gggg is not null)
            {
                Console.WriteLine(gggg.val);
                gggg = gggg.next;
            }
            return oddHead.next;
        }
    }
}
