using LeetcodeExerciseTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
	public class Middle_of_the_Linked_List
	{
		public ListNode MiddleNode(ListNode head)
		{
			var index = 0;
			var middle = head;
			while (head.next is not null)
			{	
				head = head.next;
				if (++index % 2 == 1)
				{
					middle = middle.next;
				}
			}
			return middle;
		}
	}
}
