using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    internal class Sort_Colors
    {
        public void SortColors(int[] nums)
        {
            if (nums.Any() == false)
            {
                return;
            }
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                }
            }
        }
    }
}
