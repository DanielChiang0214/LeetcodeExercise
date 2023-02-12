using LeetcodeExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    internal class Flatten_Binary_Tree_to_Linked_List
    {
        public void Flatten(TreeNode root)
        {
            if (root is null)
            {
                return;
            }
            if (root.left is not null)
            {
                if (root.right is not null)
                {
                    var temp = root.left;
                    while (temp.right is not null)
                    {
                        temp = temp.right;
                    }
                    temp.right = root.right;
                }
                root.right = root.left;
                root.left = default!;
            }
            Flatten(root.right);
        }
    }
}
