using LeetcodeExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    public class Leaf_Similar_Trees
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var temp1 = GetEdnPoint(root1).ToArray();
            var temp2 = GetEdnPoint(root2).ToArray();
            if (temp1.Length != temp2.Length)
            {
                return false;
            }
            for (int i = 0; i < temp1.Length; i++)
            {
                if (temp1[i] != temp2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public IEnumerable<int> GetEdnPoint(TreeNode root)
        {
            if (root is null)
            {
                yield break;
            }
            if (root.left is not null || root.right is not null)
            {
                foreach (var item in GetEdnPoint(root.left).Concat(GetEdnPoint(root.right)))
                {
                    yield return item;
                }
                yield break;
            }
            yield return root.val;
        }
    }
}
