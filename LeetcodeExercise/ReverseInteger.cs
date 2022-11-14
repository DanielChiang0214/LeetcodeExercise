using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    internal class ReverseInteger
    {
        public int Reverse(int x)
        {
            var result = 0;
            while (x != 0)
            {
                var temp = x % 10;
                x = x / 10;
                var tt = result * 10L + temp;
                if (tt > int.MaxValue || tt < int.MinValue)
                {
                    return 0;
                }
                else
                {
                    result = (int)tt;
                }
            }
            return result;
        }

    }
}
