using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    public class MedianOfTwoSortedArrays
    {
        public static decimal FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var margeIndex = 0;
            var i = 0;
            var j = 0;
            var marge = new int[nums1.Length + nums2.Length];
            while (i < nums1.Length && j < nums2.Length)
            {
                marge[margeIndex++] = nums1[i] < nums2[j] ? nums1[i++] : nums2[j++];
            }
            while (i < nums1.Length)
            {
                marge[margeIndex++] = nums1[i++];
            }
            while (j < nums2.Length)
            {
                marge[margeIndex++] = nums2[j++];
            }

            return marge.Length % 2 == 0 ? (marge[marge.Length / 2] + marge[(marge.Length - 1) / 2]) / 2.0m : marge[marge.Length / 2];
        }
    }
}
