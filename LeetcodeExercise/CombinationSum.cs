using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeExerciseTest
{
    public class CombinationSum     
    {
        public static IList<IList<int>> Execute(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            Execute(candidates, Array.Empty<int>(), target, result);
            return result;
        }
        public static void Execute(int[] candidates, int[] body, int target, IList<IList<int>> @return)
        {
            var temp = body.Sum();
            if (temp == target)
            {
                @return.Add(body.ToList());
            }

            foreach (var item in candidates.Where(i => i >= body.LastOrDefault()).Where(i => i <= target - temp))
            {
                Execute(candidates, body.Append(item).ToArray(), target, @return);
            }
        }
    }
}
