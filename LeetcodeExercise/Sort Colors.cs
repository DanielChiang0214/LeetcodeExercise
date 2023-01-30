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
            for (int j = 0; j < nums.Length; j++)
            {
                for (int i = j; i < nums.Length; i++)
                {
                    if (nums[j] > nums[i])
                    {
                        (nums[j], nums[i]) = (nums[i], nums[j]);
                    }
                }
            }
        }
    }
}
