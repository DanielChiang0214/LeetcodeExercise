using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    public class Minimum_Rounds_to_Complete_All_Tasks
    {
        public int MinimumRounds(int[] tasks)
        {
            var operate = 0;
            var count = 0;
            foreach (var item in tasks.GroupBy(item => item))
            {
                count = item.Count();
                if (count < 2)
                {
                    return -1;
                }
                operate += count % 3 == 0 ? count / 3 : count / 3 + 1;
            }
            return operate;
        }
    }
}
