using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    public class JumpGame
    {
        public static bool CanJump(int[] nums)
        {

            int f = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > f)
                    return false;

                f = Math.Max(f, i + nums[i]);
                if (f > nums.Length)
                    return true;
            }

            return true;
        }
    }
}
