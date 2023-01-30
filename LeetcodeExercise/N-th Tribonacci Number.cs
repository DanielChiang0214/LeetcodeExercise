using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeExercise
{
    internal class N_th_Tribonacci_Number
    {
        public int Tribonacci(int n)
        {
            if (n < 3)
            {
                return n;
            }
            var x1 = 0;
            var x2 = 1;
            var x3 = 1;

            while (n-- > 0)
            {
                (x1, x2, x3) = (x2, x3, x1 + x2 + x3);
            }
            return x1;
        }
    }
}
