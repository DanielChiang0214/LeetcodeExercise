namespace LeetcodeExercise
{
    public static class TwoSum
    {
        public static IEnumerable<int> Execute(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.TryGetValue(nums[i], out var differenceIndex))
                {
                    yield return differenceIndex;
                    yield return i;
                    yield break;
                }
                else
                {
                    dict.TryAdd(target - nums[i], i);
                }
            }
        }
    }
}
