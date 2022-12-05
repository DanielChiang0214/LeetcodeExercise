using LeetcodeExerciseTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
	public class Remove_Nth_Node_From_End_of_List
	{
		public ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			var list = new List<ListNode>();
			var temp = head;
			while (temp is not null)
			{
				list.Add(temp);
				temp = temp.next;
			}
			var newNext = list[^n].next;
			if (list.Count - (n + 1) < 0)
			{
				if (newNext is not null)
				{
					return newNext;
				}
				return null;
			}
			list[^(n + 1)].next = newNext;

			return head;
		}
	}
}
