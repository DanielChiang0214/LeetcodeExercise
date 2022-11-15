using LeetcodeExercise.Model;

namespace LeetcodeExercise
{
    public class CountCompleteTreeNodes
    {
        public int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            var count = 1;
            count += CountNodes(root.right);
            count += CountNodes(root.left);
            return count;
        }
    }
}
