using System.Collections.Generic;
using System.Linq;

namespace LeetcodeExerciseTest
{
    public class Permutations
    {
        public static IEnumerable<IEnumerable<int>> Permute(IEnumerable<int> nums)
        {
            if (!nums.Any())
            {
                yield return Enumerable.Empty<int>();
                yield break;
            }
            foreach (var item in nums)
            {
                foreach (var ienumerable in Permute(nums.Where(o => o != item)))
                {
                    yield return ienumerable.Prepend(item);
                }
            }
        }
    }
}
